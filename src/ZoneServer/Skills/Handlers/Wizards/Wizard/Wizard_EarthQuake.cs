﻿using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Wizards.Wizard
{
	/// <summary>
	/// Handler for the Wizard skill Earthquake.
	/// </summary>
	[SkillHandler(SkillId.Wizard_EarthQuake)]
	public class Wizard_EarthQuake : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, damaging targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity designatedTarget)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 50, width: 50, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Circle, splashParam);

			// Attack targets
			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var damageDelay = TimeSpan.FromMilliseconds(200);

			var skillHits = new List<SkillHitInfo>();

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var targetLethargic = target.IsBuffActive(BuffId.Lethargy_Debuff);

				var skillHitResult = SCR_SkillHit(caster, target, skill, SkillModifier.MultiHitIf(2, targetLethargic));
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, TimeSpan.Zero);

				// Ability "Earthquake: Remove Knockdown"
				if (!caster.IsAbilityActive(AbilityId.Wizard23))
				{
					skillHit.KnockBackInfo = new KnockBackInfo(caster.Position, target.Position, skill);
					skillHit.ApplyKnockBack(target);
				}

				skillHits.Add(skillHit);
			}

			var targetHandle = targets.FirstOrDefault()?.Handle ?? 0;

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, targetHandle, originPos, originPos.GetDirection(farPos), Position.Zero);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, skillHits);
		}
	}
}
