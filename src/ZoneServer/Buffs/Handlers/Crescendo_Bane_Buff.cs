﻿using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Crescendo Bane Buff, which decreases Wugushi skill damage cycle
	/// </summary>
	[BuffHandler(BuffId.Crescendo_Bane_Buff)]
	public class Crescendo_Bane_Buff : BuffHandler
	{
		// TODO: Implement this
		public override void OnStart(Buff buff)
		{

		}

		// TODO: Implement this
		public override void OnEnd(Buff buff)
		{

		}

		private float getBonusRatio(Skill skill)
		{
			return 12 + skill.Level * 2;
		}
	}
}
