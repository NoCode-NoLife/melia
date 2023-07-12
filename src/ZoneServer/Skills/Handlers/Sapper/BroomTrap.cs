﻿using System;
using System.Threading.Tasks;
using System.Threading;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors.Monsters;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Sapper
{
	/// <summary>
	/// Handler for the Sapper skill Broom Trap.
	/// </summary>
	[SkillHandler(SkillId.Sapper_BroomTrap)]
	public class BroomTrap : IGroundSkillHandler
	{
		/// <summary>
		/// Handles the skill, creates an trap object on the floor on
		/// the first usage and explodes it on the second usage attempt
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="designatedTarget"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity designatedTarget)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			this.PlaceTrap(skill, caster, caster.Position);
		}

		/// <summary>
		/// Places the trap object (mob) on the floor
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		/// <param name="farPos"></param>
		private async void PlaceTrap(Skill skill, ICombatEntity caster, Position farPos)
		{
			var effectId = ForceId.GetNew();

			await Task.Delay(TimeSpan.FromMilliseconds(100));

			Send.ZC_SKILL_READY(caster, skill, caster.Position, caster.Position);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, caster.Position, caster.Direction, caster.Position);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, caster.Position, ForceId.GetNew(), null);

			await Task.Delay(TimeSpan.FromMilliseconds(50));

			Send.ZC_NORMAL.GroundEffect_59(caster, caster.Direction, "rope_pad", skill.Id, farPos, effectId, true);

			var trapObject = new Mob(57195, MonsterType.NPC);

			trapObject.Position = farPos;
			trapObject.Direction = caster.Direction;

			caster.Map.AddMonster(trapObject);

			Send.ZC_ENTER_MONSTER(trapObject);
			Send.ZC_OWNER(caster, trapObject);
			Send.ZC_FACTION(caster, trapObject, FactionType.Trap);

			Send.ZC_NORMAL.GroundEffect_123(caster, "I_laser013", farPos);

			await Task.Delay(TimeSpan.FromMilliseconds(100));

			this.AreaOfEffect(skill, caster, trapObject, effectId);
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="trapObject"></param>
		/// <param name="effectId"></param>
		private async void AreaOfEffect(Skill skill, ICombatEntity caster, Mob trapObject, int effectId)
		{
			using (var cancellationTokenSource = new CancellationTokenSource())
			{
				cancellationTokenSource.CancelAfter(TimeSpan.FromSeconds(16));
				var center = caster.Position;

				var fan = new BladedFan(center, 3, 85, 15);
				var delay = TimeSpan.FromMilliseconds(100);

				await Task.Delay(TimeSpan.FromMilliseconds(350));

				fan.RotateAround(center, 60);

				while (!cancellationTokenSource.IsCancellationRequested)
				{
					fan.RotateAround(center, 14f);

					// The Shape appears to be slightly behind the effect movement but it works nicely.
					Debug.ShowShape(caster.Map, fan, delay, rangePreview: false);

					var targets = caster.Map.GetAttackableEntitiesIn(caster, fan);

					foreach (var target in targets.LimitRandom(15))
					{
						var skillHitResult = SCR_SkillHit(caster, target, skill);
						target.TakeDamage(skillHitResult.Damage, caster);

						var hit = new HitInfo(caster, target, skill, skillHitResult);

						Send.ZC_HIT_INFO(caster, target, skill, hit);
					}

					await Task.Delay(delay);
				}

				Send.ZC_NORMAL.GroundEffect_59(caster, caster.Direction, "rope_pad", skill.Id, center, effectId, false);
				Send.ZC_DEAD(trapObject, trapObject.Position);
				caster.Map.RemoveMonster(trapObject);
			}
		}
	}
}
