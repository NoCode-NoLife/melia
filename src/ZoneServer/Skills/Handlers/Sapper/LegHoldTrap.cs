﻿using System;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Monsters;
using static Melia.Zone.Skills.SkillUseFunctions;
using System.Threading;

namespace Melia.Zone.Skills.Handlers.Sapper
{
	/// <summary>
	/// Handler for the Sapper skill Leg Hold Trap.
	/// </summary>
	[SkillHandler(SkillId.Sapper_LegHoldTrap)]
	public class LegHoldTrap : IGroundSkillHandler
	{
		/// <summary>
		/// Handles the skill, creates a trap object that is triggered when an enemy approaches
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="designatedTarget"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity designatedTarget)
		{
			if (!skill.Vars.TryGet<Position>("Melia.ToolGroundPos", out var targetPos))
			{
				caster.ServerMessage(Localization.Get("No target location specified."));
				return;
			}

			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			if (!caster.Position.InRange2D(farPos, skill.Data.MaxRange))
			{
				caster.ServerMessage(Localization.Get("Too far away."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			this.PlaceTrap(caster, skill, targetPos);
		}

		/// <summary>
		/// Places the trap object (mob) on the floor
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		/// <param name="farPos"></param>
		private async void PlaceTrap(ICombatEntity caster, Skill skill, Position farPos)
		{
			var character = caster as Character;
			var effectId = ForceId.GetNew();

			Send.ZC_NORMAL.Skill_50(character, skill.Id, 1.9375f);

			Send.ZC_SKILL_READY(caster, skill, caster.Position, caster.Position);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, farPos, caster.Direction, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, ForceId.GetNew(), null);
			Send.ZC_NORMAL.ExecuteAnimation(character, "I_archer_shot_LegholdTrap_mash#Bip01 R Hand", 0.3f, "F_smoke008##1", 0.7f, farPos);
			Send.ZC_NORMAL.GroundEffect_59(character, "Sapper_LegHoldTrap_Pad", skill.Id, farPos, effectId, true);

			await Task.Delay(TimeSpan.FromMilliseconds(500));

			var effectId2 = ForceId.GetNew();

			Send.ZC_NORMAL.GroundEffect_59(character, "Sapper_LegHoldTrap_Mine", skill.Id, farPos, effectId2, true);

			var trapObject = new Mob(300010, MonsterType.NPC);

			trapObject.Position = farPos;
			trapObject.Direction = caster.Direction;

			trapObject.Components.Add(new BuffComponent(trapObject));

			caster.Map.AddMonster(trapObject);
			Send.ZC_ENTER_MONSTER(trapObject);
			Send.ZC_OWNER(character, trapObject);
			Send.ZC_FACTION(character.Connection, trapObject, FactionType.Trap);

			var cancellationTokenSource = new CancellationTokenSource();

			this.AlertRange(caster, skill, trapObject, farPos, effectId, cancellationTokenSource.Token);

			// The trap auto-explodes after 20 seconds
			await Task.Delay(TimeSpan.FromSeconds(20));
						
			if (trapObject != null && !trapObject.IsDead)
			{
				Send.ZC_DEAD(trapObject, trapObject.Position);
				cancellationTokenSource.Cancel();
				caster.Map.RemoveMonster(trapObject);
			}
		}

		/// <summary>
		/// Routine that scans for targets that may trigger the trap explosion
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		/// <param name="trap"></param>
		/// <param name="effectId"></param>
		/// <param name="cancellationToken"></param>
		private async void AlertRange(ICombatEntity caster, Skill skill, Mob trap, Position farPos, int effectId, CancellationToken cancellationToken)
		{
			var splashArea = new Circle(farPos, 40);

			Debug.ShowShape(caster.Map, splashArea, edgePoints: false);
			
			while (!cancellationToken.IsCancellationRequested)
			{
				var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
				if (targets.Count > 0)
				{
					await this.TriggerTrap(caster, skill, trap, farPos, effectId);
					break;
				}

				await Task.Delay(TimeSpan.FromMilliseconds(200));
			}
		}

		/// <summary>
		/// Explodes the trap object and does its following effects
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		/// <param name="trap"></param
		/// <param name="farPos"></param>
		/// <param name="effectId></param>
		private async Task TriggerTrap(ICombatEntity caster, Skill skill, Mob trap, Position farPos, int effectId)
		{
			var character = caster as Character;

			Send.ZC_DEAD(trap, trap.Position);
			Send.ZC_NORMAL.GroundEffect_59(character, "Sapper_LegHoldTrap_Pad", skill.Id, farPos, effectId, false);

			caster.Map.RemoveMonster(trap);

			if (character.PlacedTraps.Contains(trap))
			{
				character.PlacedTraps.Remove(trap);
			}

			var newEffectId = ForceId.GetNew();

			Send.ZC_NORMAL.GroundEffect_59(character, "Sapper_Vibora_Pad", skill.Id, farPos, newEffectId, true);

			var cancellationTokenSource = new CancellationTokenSource();

			this.AreaOfEffect(caster, farPos, skill, newEffectId, cancellationTokenSource.Token);

			await Task.Delay(TimeSpan.FromSeconds(15));

			cancellationTokenSource.Cancel();

			Send.ZC_NORMAL.GroundEffect_59(character, "Sapper_Vibora_Pad", skill.Id, farPos, newEffectId, false);
		}

		/// <summary>
		/// Area of effect after the trap was triggered
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="centerPosition"></param>
		/// <param name="skill"></param>
		/// <param name="cancellationToken"></param>
		private async void AreaOfEffect(ICombatEntity caster, Position centerPosition, Skill skill, int effectId, CancellationToken cancellationToken)
		{
			var splashArea = new Circle(centerPosition, 50);

			Debug.ShowShape(caster.Map, splashArea, edgePoints: false);

			await Task.Delay(TimeSpan.FromSeconds(2));

			while (!cancellationToken.IsCancellationRequested)
			{
				var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

				foreach (var target in targets.LimitBySDR(caster, skill))
				{
					// Oficial server skills apply slow while the mob is inside the area
					// But for now we gonna apply 10 seconds slow
					if (!target.Components.Get<BuffComponent>().Has(BuffId.Common_Slow))
					{
						var duration = TimeSpan.FromSeconds(10);
						target.StartBuff(BuffId.Common_Slow, skill.Level, 0, duration, caster);
					}

					if (!target.Components.Get<BuffComponent>().Has(BuffId.LegHoldTrap_Debuff))
					{
						var duration = TimeSpan.FromSeconds(5);
						target.StartBuff(BuffId.LegHoldTrap_Debuff, skill.Level, 0, duration, caster);
					}
					
					var skillHitResult = SCR_SkillHit(caster, target, skill);
					target.TakeDamage(skillHitResult.Damage, caster);

					var hit = new HitInfo(caster, target, skill, skillHitResult);

					Send.ZC_HIT_INFO(caster, target, skill, hit);

					var skillHitResult2 = SCR_SkillHit(caster, target, skill);
					target.TakeDamage(skillHitResult2.Damage, caster);

					var hit2 = new HitInfo(caster, target, skill, skillHitResult2);

					Send.ZC_HIT_INFO(caster, target, skill, hit2);
				}

				await Task.Delay(TimeSpan.FromSeconds(1));
			}
		}
	}
}
