﻿using Melia.Shared.ObjectProperties;
using Melia.Shared.Game.Const;
using Melia.Shared.World;

namespace Melia.Barracks.Database
{
	public class Companion
	{
		/// <summary>
		/// Companion's unique id.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Companion's globally unique id.
		/// </summary>
		public long ObjectId => ObjectIdRanges.Companions + this.Id;

		/// <summary>
		/// Id of the companion's account.
		/// </summary>
		public long AccountId { get; set; }

		/// <summary>
		/// Id of the companion's account.
		/// </summary>
		public long AccountObject => this.AccountId;

		/// <summary>
		/// Id of the associated character.
		/// </summary>
		public long CharacterId { get; set; } = 0;

		/// <summary>
		/// Visual Id of the companion
		/// </summary>
		public int MonsterId { get; set; }

		/// <summary>
		/// Index of companion in companion list.
		/// </summary>
		public byte Index { get; set; }

		/// <summary>
		/// Companion's name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Layer in the barrack that the companion should appear in.
		/// </summary>
		public int BarracksLayer { get; set; }

		/// <summary>
		/// Companion's position in barracks.
		/// </summary>
		public Position BarracksPosition { get; set; }

		/// <summary>
		/// Companion's direction in barracks.
		/// </summary>
		public Direction BarracksDirection { get; set; }

		/// <summary>
		/// Companion's experience point shown as level in barracks.
		/// </summary>
		public long Exp { get; set; }

		/// <summary>
		/// Companion ctor
		/// </summary>
		/// <param name="id"></param>
		/// <param name="accountId"></param>
		/// <param name="characterId">Set to 0 means no unassigned companion</param>
		public Companion(long id, long accountId, long characterId = 0)
		{
			this.Id = id;
			this.AccountId = accountId;
			this.CharacterId = characterId;
			this.BarracksPosition = new Position(30.350805f, 17.948700f, 7.398606f);
			this.BarracksDirection = new Direction(45);
			this.BarracksLayer = 1;
		}
	}
}
