﻿using Melia.Shared.Game.Const;
using Melia.Shared.World;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills.Handlers.Clerics.Sadhu
{
	/// <summary>
	/// Handler for the Sadhu skill Posession.
	/// </summary>
	[SkillHandler(SkillId.Sadhu_Possession)]
	public class Sadhu_Possession : Sadhu_Skill_Base, IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, makes the character out of body.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="target"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			Handle(skill, caster, originPos, farPos, target, BuffId.OOBE_Possession_Buff);
		}
	}
}
