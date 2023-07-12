﻿using System;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Scripting;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters.Components;

namespace Melia.Zone.Skills.Handlers.Enchanter
{
	/// <summary>
	/// Handler for the Enchanter skill Agility.
	/// </summary>
	[SkillHandler(SkillId.Enchanter_Agility)]
	public class Agility : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, apply a buff to the caster.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="target"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			originPos = caster.Position;

			var duration = TimeSpan.FromMinutes(30);
			var buffArg2 = 0f;
			var abilityComponent = caster.Components.Get<AbilityComponent>();

			if (abilityComponent != null && abilityComponent.Has(AbilityId.Enchanter10))
			{
				var SCR_Get_SkillFactor = ScriptableFunctions.Skill.Get("SCR_Get_SkillFactor");
				var abilityBonus = SCR_Get_SkillFactor(skill);
				buffArg2 = abilityBonus;
			}

			caster.StartBuff(BuffId.Agility_Buff, skill.Level, buffArg2, duration, caster);

			// TODO: Apply this buff on party members and pets as well

			Send.ZC_SKILL_READY(caster, skill, caster.Position, caster.Position);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, originPos, null);
		}
	}
}
