﻿using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills.Handlers.Scouts.Scout
{
	/// <summary>
	/// Handler for the Scout skill Cloaking.
	/// </summary>
	[SkillHandler(SkillId.Scout_Cloaking)]
	public class Scout_Cloaking : ISelfSkillHandler
	{
		/// <summary>
		/// Handles skill, applying a buff to the caster.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="dir"></param>
		/// <exception cref="NotImplementedException"></exception>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Direction dir)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			var duration = TimeSpan.FromSeconds(20);
			caster.StartBuff(BuffId.Cloaking_Buff, skill.Level, 0, duration, caster);

			Send.ZC_SKILL_MELEE_TARGET(caster, skill, caster, null);
		}
	}
}
