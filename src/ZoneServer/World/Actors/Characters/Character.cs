﻿using System;
using System.Linq;
using Melia.Shared.Data.Database;
using Melia.Shared.L10N;
using Melia.Shared.Network.Helpers;
using Melia.Shared.ObjectProperties;
using Melia.Shared.Scripting;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Components;
using Melia.Zone.World.Actors.Monsters;
using Yggdrasil.Composition;
using Yggdrasil.Geometry.Shapes;
using Yggdrasil.Logging;
using Yggdrasil.Scheduling;
using Yggdrasil.Util;

namespace Melia.Zone.World.Actors.Characters
{
	/// <summary>
	/// Represents a player character.
	/// </summary>
	public class Character : Actor, INamedActor, ICombatEntity, ICommander, IPropertyObject, IUpdateable
	{
		private bool _warping;
		private int _destinationChannelId;

		private readonly object _lookAroundLock = new object();
		private readonly object _hpLock = new object();
		private IMonster[] _visibleMonsters = new IMonster[0];
		private Character[] _visibleCharacters = new Character[0];

		/// <summary>
		/// Connection this character uses.
		/// </summary>
		public IZoneConnection Connection { get; set; }

		/// <summary>
		/// Character's unique id.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Character's globally unique id.
		/// </summary>
		/// <remarks>
		/// This is basically the same as Id... but until we're entirely
		/// sure this object business works the way we think it does,
		/// I'll leave it as a reference. At least it seems like the
		/// id doesn't change across play sessions.
		/// </remarks>
		public long ObjectId => this.Id;

		/// <summary>
		/// Id of the character's account.
		/// </summary>
		public long AccountId { get; set; }

		/// <summary>
		/// Returns the character's faction.
		/// </summary>
		public FactionType Faction => FactionType.Law;

		/// <summary>
		/// Character's name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Character's team name.
		/// </summary>
		public string TeamName { get; set; }

		/// <summary>
		/// Character's base job's id.
		/// </summary>
		public JobId JobId { get; set; }

		/// <summary>
		/// Character's base job's class.
		/// </summary>
		public JobClass JobClass => this.JobId.ToClass();

		/// <summary>
		/// Returns reference to character's base job, based on JobId.
		/// </summary>
		public Job Job => this.Jobs.Get(this.JobId);

		/// <summary>
		/// Character's jobs.
		/// </summary>
		/// <remarks>
		/// A character has one base job which determines, for example,
		/// what items they can equip, but they can have various jobs,
		/// that all come with their own skills and abilities.
		/// </remarks>
		public Jobs Jobs { get; }

		/// <summary>
		/// Character's gender.
		/// </summary>
		public Gender Gender { get; set; }

		/// <summary>
		/// Character's hair style.
		/// </summary>
		public int Hair { get; set; }

		/// <summary>
		/// Returns stance, based on job and other factors.
		/// </summary>
		public int Stance { get; protected set; }

		/// <summary>
		/// The map the character is in.
		/// </summary>
		public int MapId { get; set; }

		/// <summary>
		/// Character's head's direction.
		/// </summary>
		public Direction HeadDirection { get; set; }

		/// <summary>
		/// Gets or sets whether the character is moving.
		/// </summary>
		public bool IsMoving { get; set; }

		/// <summary>
		/// Gets or sets whether the character is sitting.
		/// </summary>
		public bool IsSitting { get; set; }

		/// <summary>
		/// Gets or sets whether the character is standing on the ground.
		/// </summary>
		public bool IsGrounded { get; set; }

		/// <summary>
		/// The character's inventory.
		/// </summary>
		public Inventory Inventory { get; }

		/// <summary>
		/// Gets or set the character's greeting message.
		/// </summary>
		public string GreetingMessage { get; set; }

		/// <summary>
		/// Holds the order of successive changes in character HP.
		/// A higher value indicates the latest damage taken.
		/// </summary>
		/// TODO: I'm not sure when this gets rolled over;
		///   More investigation is needed.
		public int HpChangeCounter { get; private set; }

		/// <summary>
		/// Specifies whether the character currently updates the visible
		/// entities around the character.
		/// </summary>
		public bool EyesOpen { get; private set; }

		/// <summary>
		/// Character's scripting variables.
		/// </summary>
		public VariablesContainer Variables { get; } = new VariablesContainer();

		/// <summary>
		/// Specifies which hats are visible on the character.
		/// </summary>
		/// <remarks>
		/// TODO: Handle toggling and save/load with character.
		/// </remarks>
		public HatVisibleStates VisibleHats => HatVisibleStates.Hat1 | HatVisibleStates.Hat2 | HatVisibleStates.Hat3;

		/// <summary>
		/// Current experience points.
		/// </summary>
		public int Exp { get; set; }

		/// <summary>
		/// Current maximum experience points.
		/// </summary>
		public int MaxExp { get; set; }

		/// <summary>
		/// Total number of accumulated experience points.
		/// </summary>
		public long TotalExp { get; set; }

		/// <summary>
		/// Character's class level.
		/// </summary>
		public int ClassLevel
		{
			get
			{
				var job = this.Jobs.Get(this.JobId);
				return job.Level;
			}
		}

		/// <summary>
		/// Returns the character's current level.
		/// </summary>
		public int Level => (int)this.Properties.GetFloat(PropertyName.Lv);

		/// <summary>
		/// Returns the character's current HP.
		/// </summary>
		public int Hp => (int)this.Properties.GetFloat(PropertyName.HP);

		/// <summary>
		/// Returns the character's max HP.
		/// </summary>
		public int MaxHp => (int)this.Properties.GetFloat(PropertyName.MHP);

		/// <summary>
		/// Returns the character's current SP.
		/// </summary>
		public int Sp => (int)this.Properties.GetFloat(PropertyName.SP);

		/// <summary>
		/// Returns the character's max SP.
		/// </summary>
		public int MaxSp => (int)this.Properties.GetFloat(PropertyName.MSP);

		/// <summary>
		/// Returns the character's current stamina.
		/// </summary>
		public int Stamina => this.Properties.Stamina;

		/// <summary>
		/// Returns the character's max stamina.
		/// </summary>
		public int MaxStamina => this.Properties.MaxStamina;

		/// <summary>
		/// Returns true if the character has run out of HP and died.
		/// </summary>
		public bool IsDead => (this.Hp == 0);

		/// <summary>
		/// Returns the character's move speed via its MSPD property.
		/// </summary>
		public float MoveSpeed => this.Properties.GetFloat(PropertyName.MSPD);

		/// <summary>
		/// Returns the character's component collection.
		/// </summary>
		public ComponentCollection Components { get; } = new ComponentCollection();

		/// <summary>
		/// Character's session objects.
		/// </summary>
		public SessionObjects SessionObjects { get; } = new SessionObjects();

		/// <summary>
		/// Character's skills.
		/// </summary>
		public CharacterSkills Skills { get; }

		/// <summary>
		/// Character's abilities.
		/// </summary>
		public Abilities Abilities { get; }

		/// <summary>
		/// Character's buffs.
		/// </summary>
		public BuffCollection Buffs { get; }

		/// <summary>
		/// Character's properties.
		/// </summary>
		/// <remarks>
		/// Beware, some of these are reference properties that can't be
		/// set directly. Use this object's actual properties whenever
		/// possible.
		/// </remarks>
		public CharacterProperties Properties { get; }

		/// <summary>
		/// Returns a reference to the character's properties.
		/// </summary>
		Properties IPropertyHolder.Properties => this.Properties;

		/// <summary>
		/// Gets or sets the player's localizer.
		/// </summary>
		public Localizer Localizer
		{
			get => _localizer ?? ZoneServer.Instance.MultiLocalization.GetDefault();
			private set => _localizer = value;
		}
		private Localizer _localizer;

		/// <summary>
		/// Raised when the characters sits down or stands up.
		/// </summary>
		public event Action<Character> SitStatusChanged;

		/// <summary>
		/// Creates new character.
		/// </summary>
		public Character() : base()
		{
			this.Components.Add(this.Inventory = new Inventory(this));
			this.Components.Add(this.Jobs = new Jobs(this));
			this.Components.Add(this.Skills = new CharacterSkills(this));
			this.Components.Add(this.Abilities = new Abilities(this));
			this.Components.Add(this.Buffs = new BuffCollection(this));
			this.Components.Add(new Recovery(this));

			this.Properties = new CharacterProperties(this);

			this.AddSessionObjects();
		}

		/// <summary>
		/// Adds default session objects.
		/// </summary>
		private void AddSessionObjects()
		{
			// The exact purpose of those objects is unknown right now,
			// but apparently they hold some properties of importance.
			// For now we'll add only one, to be able to get rid of the
			// message "You can buy items from a shop", which has been
			// bugging me. I know I can buy items! I coded that!
			// 
			// Update: Disabling this for now so we can take a fresh
			//   look at session objects. Curiously, I don't get the
			//   aformentioned tooltip anymore right now, even if this
			//   object is missing.
			//this.SessionObjects.Add(new SessionObject(SessionObjectId.Jansori));
		}

		/// <summary>
		/// Gives character its initial properties if they're missing,
		/// such as on a newly created character.
		/// </summary>
		public void InitProperties()
		{
			if (this.Job == null)
				throw new InvalidOperationException("Character's jobs need to be loaded before initializing the properties.");

			// We need something to check whether the properties were
			// already initialized. Let's just use a variable for that.
			if (!this.Variables.Perm.Has("PropertiesInitialized"))
			{
				this.Properties.SetFloat("Lv", 1);
				this.Exp = 0;
				this.TotalExp = 0;
				this.MaxExp = ZoneServer.Instance.Data.ExpDb.GetNextExp(1);

				this.Properties.SetFloat("STR_JOB", this.Job.Data.Str);
				this.Properties.SetFloat("CON_JOB", this.Job.Data.Con);
				this.Properties.SetFloat("INT_JOB", this.Job.Data.Int);
				this.Properties.SetFloat("MNA_JOB", this.Job.Data.Spr);
				this.Properties.SetFloat("DEX_JOB", this.Job.Data.Dex);
				this.Properties.SetFloat("HP", this.Properties.CFloat("MHP").Recalculate());
				this.Properties.SetFloat("SP", this.Properties.CFloat("MSP").Recalculate());

				this.Properties.Stamina = (int)this.Properties.CFloat("MaxSta").Recalculate();

				this.Variables.Perm.SetBool("PropertiesInitialized", true);
			}

			this.Properties.RecalculateAll();
			this.Properties.InitAutoUpdates();
		}

		/// <summary>
		/// Updates character and its components.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			this.Components.Update(elapsed);
		}

		/// <summary>
		/// Returns character's jump type.
		/// </summary>
		/// <returns></returns>
		public int GetJumpType()
		{
			return 1;
		}

		/// <summary>
		/// Sets character's position.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		public void SetPosition(float x, float y, float z)
			=> this.SetPosition(new Position(x, y, z));

		/// <summary>
		/// Sets character's position.
		/// </summary>
		/// <param name="pos"></param>
		public void SetPosition(Position pos)
		{
			this.Position = pos;
		}

		/// <summary>
		/// Sets character's direction.
		/// </summary>
		/// <param name="cos"></param>
		/// <param name="sin"></param>
		public void SetDirection(float cos, float sin)
			=> this.SetDirection(new Direction(cos, sin));

		/// <summary>
		/// Sets character's direction.
		/// </summary>
		/// <param name="dir"></param>
		public void SetDirection(Direction dir)
		{
			this.Direction = dir;
		}

		/// <summary>
		/// Sets character's direction.
		/// </summary>
		/// <param name="cos"></param>
		/// <param name="sin"></param>
		public void SetHeadDirection(float cos, float sin)
			=> this.SetHeadDirection(new Direction(cos, sin));

		/// <summary>
		/// Sets character's direction.
		/// </summary>
		/// <param name="dir"></param>
		public void SetHeadDirection(Direction dir)
		{
			this.HeadDirection = dir;
		}

		/// <summary>
		/// Starts movement.
		/// </summary>
		/// <param name="pos"></param>
		/// <param name="dir"></param>
		/// <param name="unkFloat"></param>
		/// <param name="unkByte"></param>
		public void Jump(Position pos, Direction dir, float unkFloat, byte unkByte)
		{
			this.SetPosition(pos);
			this.SetDirection(dir);
			this.IsMoving = true;

			Send.ZC_JUMP(this, pos, dir, unkFloat, unkByte);
		}

		/// <summary>
		/// Starts movement.
		/// </summary>
		/// <param name="pos"></param>
		/// <param name="dir"></param>
		/// <param name="unkFloat"></param>
		public void Move(Position pos, Direction dir, float unkFloat)
		{
			this.SetPosition(pos);
			this.SetDirection(dir);
			this.IsMoving = true;

			Send.ZC_MOVE_DIR(this, pos, dir, unkFloat);
		}

		/// <summary>
		/// Stops movement.
		/// </summary>
		/// <param name="pos"></param>
		/// <param name="dir"></param>
		public void StopMove(Position pos, Direction dir)
		{
			this.SetPosition(pos);
			this.SetDirection(dir);
			this.IsMoving = false;

			// Sending ZC_MOVE_STOP works as well, but it doesn't have
			// a direction, so the character stops and looks north
			// on others' screens.
			Send.ZC_PC_MOVE_STOP(this, this.Position, this.Direction);

			this.Buffs.Remove(BuffId.DashRun);
		}

		/// <summary>
		/// Warps character to given location.
		/// </summary>
		/// <param name="location"></param>
		public void Warp(Location location)
			=> this.Warp(location.MapId, location.Position);

		/// <summary>
		/// Warps character to given location.
		/// </summary>
		/// <param name="mapName"></param>
		/// <param name="pos"></param>
		/// <exception cref="ArgumentException">Thrown if map doesn't exist in data.</exception>
		public void Warp(string mapName, Position pos)
		{
			if (!ZoneServer.Instance.Data.MapDb.TryFind(mapName, out var map))
				throw new ArgumentException("Map '" + mapName + "' not found in data.");

			this.Warp(map.Id, pos);
		}

		/// <summary>
		/// Warps character to given location.
		/// </summary>
		/// <param name="mapId"></param>
		/// <param name="pos"></param>
		/// <exception cref="ArgumentException">Thrown if map doesn't exist in world.</exception>
		public void Warp(int mapId, Position pos)
		{
			if (!ZoneServer.Instance.World.TryGetMap(mapId, out var map))
				throw new ArgumentException("Map with id '" + mapId + "' doesn't exist in world.");

			this.Position = pos;

			if (this.MapId == mapId)
			{
				Send.ZC_SET_POS(this);
			}
			else
			{
				this.MapId = mapId;
				_warping = true;

				Send.ZC_MOVE_ZONE(this.Connection);
			}
		}

		/// <summary>
		/// Makes character warp to the same map on another, previously
		/// selected channel.
		/// </summary>
		internal void WarpChannel(int channelId)
		{
			_warping = true;
			_destinationChannelId = channelId;

			Send.ZC_SAVE_INFO(this.Connection);
			Send.ZC_MOVE_ZONE(this.Connection);
		}

		/// <summary>
		/// Finalizes warp, after client announced readiness.
		/// </summary>
		public void FinalizeWarp()
		{
			// Check permission
			if (!_warping)
			{
				Log.Warning("Character.FinalizeWarp: Player '{0}' tried to warp without permission.", this.AccountId);
				return;
			}

			_warping = false;

			ZoneServer.Instance.Database.SaveCharacter(this);

			// Get channel
			var availableZones = ZoneServer.Instance.ServerList.GetZoneServers(this.MapId);
			if (availableZones.Length == 0)
				throw new Exception($"No suitable zone server found for map '{this.MapId}'");

			var channelId = Math2.Clamp(0, availableZones.Length, _destinationChannelId);
			var serverInfo = availableZones[channelId];

			Send.ZC_MOVE_ZONE_OK(this, channelId, serverInfo.Ip, serverInfo.Port, this.MapId);
		}

		/// <summary>
		/// Increases character's level by the given amount.
		/// </summary>
		/// <param name="amount"></param>
		public void LevelUp(int amount = 1)
		{
			if (amount < 1)
				throw new ArgumentException("Amount can't be lower than 1.");

			var newLevel = this.Properties.Modify("Lv", amount);
			this.Properties.Modify("StatByLevel", amount);

			this.MaxExp = ZoneServer.Instance.Data.ExpDb.GetNextExp((int)newLevel);
			this.Heal();

			Send.ZC_MAX_EXP_CHANGED(this, 0);
			Send.ZC_PC_LEVELUP(this);
			Send.ZC_UPDATE_ALL_STATUS(this);
			Send.ZC_OBJECT_PROPERTY(this);
			Send.ZC_ADDON_MSG(this, 3, "NOTICE_Dm_levelup_base", "!@#$Auto_KaeLigTeo_LeBeli_SangSeungHayeossSeupNiDa#@!");
			Send.ZC_NORMAL.LevelUp(this);
		}

		/// <summary>
		/// Gives skill points to the current job and updates client.
		/// </summary>
		/// <param name="amount"></param>
		private void ClassLevelUp(int amount = 1)
		{
			if (amount < 1)
				throw new ArgumentException("Amount can't be lower than 1.");

			this.Jobs.ModifySkillPoints(this.JobId, amount);
			this.Heal();

			Send.ZC_OBJECT_PROPERTY(this);
			Send.ZC_ADDON_MSG(this, 3, "NOTICE_Dm_levelup_skill", "!@#$Auto_KeulLeSeu_LeBeli_SangSeungHayeossSeupNiDa#@!");
			Send.ZC_NORMAL.ClassLevelUp(this);
		}

		/// <summary>
		/// Heals character's HP, SP, and Stamina fully and updates
		/// the client.
		/// </summary>
		public void Heal()
		{
			this.Properties.SetFloat("HP", this.Properties.GetFloat(PropertyName.MHP));
			this.Properties.SetFloat("SP", this.Properties.GetFloat(PropertyName.MSP));

			Send.ZC_UPDATE_ALL_STATUS(this);
		}

		/// <summary>
		/// Heals character's HP and SP by the given amounts and updates
		/// the client.
		/// </summary>
		/// <param name="hpAmount"></param>
		/// <param name="spAmount"></param>
		public void Heal(float hpAmount, float spAmount)
		{
			if (hpAmount == 0 && spAmount == 0)
				return;

			this.Properties.Modify("HP", hpAmount);
			this.Properties.Modify("SP", spAmount);

			Send.ZC_UPDATE_ALL_STATUS(this);
		}

		/// <summary>
		/// Modifies character's HP by the given amount and updates the
		/// client with ZC_ADD_HP.
		/// </summary>
		/// <param name="amount"></param>
		public void ModifyHp(int amount)
		{
			int hp, priority;
			var negative = (amount < 0);

			// Make sure it's not possible for two calls to interfere
			// with each other, so that the correct amount makes it to
			// the client, with the correct priority.
			lock (_hpLock)
			{
				hp = (int)this.Properties.Modify("HP", amount);
				priority = (this.HpChangeCounter += 1);
			}

			Send.ZC_ADD_HP(this, amount, negative, hp, priority);
		}

		/// <summary>
		/// Modifies character's SP by the given amount and updates the
		/// client with ZC_UPDATE_SP.
		/// </summary>
		/// <param name="amount"></param>
		public void ModifySp(int amount)
		{
			var sp = (int)this.Properties.Modify("SP", amount);
			Send.ZC_UPDATE_SP(this, sp);
		}

		/// <summary>
		/// Modifies character's current stamina and updates the client.
		/// </summary>
		/// <param name="amount"></param>
		public void ModifyStamina(int amount)
		{
			this.Properties.Stamina += amount;
			Send.ZC_STAMINA(this, this.Properties.Stamina);
		}

		/// <summary>
		/// Modifies the character's ability points by the given amount
		/// and updates the respective property on the client.
		/// </summary>
		/// <param name="amount"></param>
		public void ModifyAbilityPoints(int amount)
		{
			var abilityPoints = int.Parse(this.Properties.GetString(PropertyName.AbilityPoint));
			abilityPoints += amount;
			this.Properties.SetString("AbilityPoint", abilityPoints.ToString());

			Send.ZC_OBJECT_PROPERTY(this, "AbilityPoint");
		}

		/// <summary>
		/// Grants exp to character and handles level ups.
		/// </summary>
		/// <param name="exp"></param>
		/// <param name="classExp"></param>
		/// <param name="monster"></param>
		public void GiveExp(int exp, int classExp, IMonster monster)
		{
			// Base EXP
			this.Exp += exp;
			this.TotalExp += exp;

			Send.ZC_EXP_UP_BY_MONSTER(this, exp, classExp, monster);
			Send.ZC_EXP_UP(this, exp, classExp); // Not always sent? Might be quest related?

			while (this.Exp >= this.MaxExp)
			{
				this.Exp -= this.MaxExp;
				this.LevelUp();
			}

			// Class EXP
			var classLevel = this.ClassLevel;
			var rank = this.Jobs.GetCurrentRank();
			var job = this.Job;
			var maxTotalExp = ZoneServer.Instance.Data.ExpDb.GetNextTotalClassExp(rank, 15);

			// Limit EXP to the total max, otherwise the client will
			// display level 1 with 0%.
			job.TotalExp = (int)Math.Min(maxTotalExp, ((long)job.TotalExp + classExp));

			var newClassLevel = this.ClassLevel;
			var diff = (newClassLevel - classLevel);

			Send.ZC_JOB_EXP_UP(this, classExp);

			if (diff > 0)
				this.ClassLevelUp(diff);
		}

		/// <summary>
		/// Returns ids of equipped items.
		/// </summary>
		/// <returns></returns>
		public int[] GetEquipIds()
		{
			return this.Inventory.GetEquipIds();
		}

		/// <summary>
		/// Updates visible entities around character.
		/// </summary>
		public void LookAround()
		{
			if (!this.EyesOpen)
				return;

			lock (_lookAroundLock)
			{
				// Get lists
				var currentlyVisibleMonsters = this.Map.GetVisibleMonsters(this);
				var currentlyVisibleCharacters = this.Map.GetVisibleCharacters(this);

				// Appears
				var appearMonsters = currentlyVisibleMonsters.Except(_visibleMonsters);
				var appearCharacters = currentlyVisibleCharacters.Except(_visibleCharacters);

				// Disappears
				var disappearMonsters = _visibleMonsters.Except(currentlyVisibleMonsters);
				var disappearCharacters = _visibleCharacters.Except(currentlyVisibleCharacters);

				// Monsters
				foreach (var monster in appearMonsters)
				{
					Send.ZC_ENTER_MONSTER(this.Connection, monster);

					if (monster is ICombatEntity entity)
						Send.ZC_FACTION(this.Connection, monster, entity.Faction);
				}

				foreach (var monster in disappearMonsters)
					Send.ZC_LEAVE(this.Connection, monster);

				// Characters
				foreach (var character in appearCharacters)
					Send.ZC_ENTER_PC(this.Connection, character);

				foreach (var character in disappearCharacters)
					Send.ZC_LEAVE(this.Connection, character);

				// Save lists for next run
				_visibleMonsters = currentlyVisibleMonsters;
				_visibleCharacters = currentlyVisibleCharacters;
			}
		}

		/// <summary>
		/// Starts auto-updates of visible entities.
		/// </summary>
		public void OpenEyes()
		{
			this.EyesOpen = true;
			this.LookAround();
		}

		/// <summary>
		/// Stops auto-updates of visible entities.
		/// </summary>
		public void CloseEyes()
		{
			this.EyesOpen = false;

			lock (_lookAroundLock)
			{
				foreach (var monster in _visibleMonsters)
					Send.ZC_LEAVE(this.Connection, monster);

				foreach (var character in _visibleCharacters)
					Send.ZC_LEAVE(this.Connection, character);

				_visibleMonsters = new IMonster[0];
				_visibleCharacters = new Character[0];
			}
		}

		/// <summary>
		/// Sets direction and updates clients.
		/// </summary>
		/// <param name="dir"></param>
		public void Rotate(Direction dir)
		{
			if (this.Direction != dir)
				this.SetDirection(dir);

			Send.ZC_ROTATE(this);
		}

		/// <summary>
		/// Sets direction and updates clients.
		/// </summary>
		/// <param name="d1"></param>
		/// <param name="d2"></param>
		public void RotateHead(Direction dir)
		{
			if (this.HeadDirection != dir)
				this.SetHeadDirection(dir);

			Send.ZC_HEAD_ROTATE(this);
		}

		/// <summary>
		/// Returns the character's current location.
		/// </summary>
		/// <returns></returns>
		public Location GetLocation()
		{
			return new Location(this.MapId, this.Position);
		}

		/// <summary>
		/// Sends server message to character.
		/// </summary>
		/// <remarks>
		/// Abuses a certain system message that takes two parameters,
		/// which are then output, separated by a colon. Since there's
		/// no customizable server message packet I know of, this will
		/// serve as the next best thing for now, and is certainly an
		/// improvement over using ZC_CHAT.
		/// </remarks>
		/// <param name="format"></param>
		public void ServerMessage(string format, params object[] args)
		{
			if (args.Length > 0)
				format = string.Format(format, args);

			// Since there doesn't seem to be a way to send custom system
			// messages, we're abusing clientmessage 21254, which has the
			// format "X:Y", where we replace X and Y with a prefix and
			// our custom message.
			Send.ZC_SYSTEM_MSG(this, 21254, new MsgParameter("Hour", "Server "), new MsgParameter("Min", " " + format));
		}

		/// <summary>
		/// Sends server message to character.
		/// </summary>
		/// <param name="format"></param>
		/// <param name="args"></param>
		public void MsgBox(string format, params object[] args)
		{
			if (args.Length > 0)
				format = string.Format(format, args);

			if (format.IndexOf("'") != -1)
				format = format.Replace("'", "\\'");

			Send.ZC_EXEC_CLIENT_SCP(this.Connection, "ui.MsgBox('" + format + "')");
		}

		/// <summary>
		/// Adds amount to character's stat points and updates the client.
		/// </summary>
		/// <param name="amount"></param>
		public void AddStatPoints(int amount)
		{
			if (amount < 1)
				throw new ArgumentException("Amount can't be negative.");

			this.Properties.Modify("StatByBonus", amount);
			Send.ZC_OBJECT_PROPERTY(this, "StatByBonus");
		}

		/// <summary>
		/// Resets the character's stats.
		/// </summary>
		/// <remarks>
		/// Sets all stats to 1 (some level bonuses might still apply,
		/// raising the default value above 1) and gives back the points
		/// that were put into the stats. Also resets the points the
		/// character got from its job on creation.
		/// </remarks>
		public void ResetStats()
		{
			var character = this;

			// The three properties that control the stat points are
			// StatByLevel, StatByBonus, and UsedStat. The first two
			// get added together and UsedStat is subtracted to arrive
			// at the number of available stat points. To reset the
			// stat points that were used, all we have to do is reset
			// UsedStat and the *_STAT properties. For a full reset,
			// however, that allows for distributing the initial stats
			// from the chosen job, we need to give the player the points
			// that went into the *_JOB properties, which we'll just add
			// to StatByBonus.

			var jobStatPoints = character.Properties.Sum("STR_JOB", "CON_JOB", "INT_JOB", "MNA_JOB", "DEX_JOB") - 5;
			character.Properties.Modify("StatByBonus", jobStatPoints);

			character.Properties.SetFloat("UsedStat", 0);

			character.Properties.SetFloat("STR_STAT", 0);
			character.Properties.SetFloat("CON_STAT", 0);
			character.Properties.SetFloat("INT_STAT", 0);
			character.Properties.SetFloat("MNA_STAT", 0);
			character.Properties.SetFloat("DEX_STAT", 0);

			character.Properties.SetFloat("STR_JOB", 1);
			character.Properties.SetFloat("CON_JOB", 1);
			character.Properties.SetFloat("INT_JOB", 1);
			character.Properties.SetFloat("MNA_JOB", 1);
			character.Properties.SetFloat("DEX_JOB", 1);

			// TODO: Add semi-automatic updating of all properties that
			//   changed.
			Send.ZC_OBJECT_PROPERTY(character,
				"STR", "STR_STAT", "STR_JOB", "CON", "CON_STAT", "CON_JOB",
				"INT", "INT_STAT", "INT_JOB", "MNA", "MNA_STAT", "MNA_JOB",
				"DEX", "DEX_STAT", "DEX_JOB",
				"UsedStat", "StatByLevel", "StatByBonus",
				"MINPATK", "MAXPATK", "MINMATK", "MAXMATK", "MINPATK_SUB", "MAXPATK_SUB",
				"CRTATK", "HR", "DR", "BLK_BREAK", "BLK", "RHP",
				"RSP", "MHP", "MSP"
			);
		}

		/// <summary>
		/// Resets the character's skills.
		/// </summary>
		/// <remarks>
		/// Resets the levels of all skills the character has and returns
		/// the points that were put into them to the jobs.
		/// </remarks>
		public void ResetSkills()
		{
			// Remove all skills
			foreach (var skill in this.Skills.GetList())
				this.Skills.Remove(skill.Id);

			// Reset jobs' skill points, so they're equal to their level,
			// minus 1, because 1 is the default level.
			foreach (var job in this.Jobs.GetList())
				job.SetSkillPoints(job.Level - 1);
		}

		/// <summary>
		/// Sets and returns the currently correct stance, based on this
		/// character's properties. Does not update client.
		/// </summary>
		public int UpdateStance()
		{
			var jobId = this.JobId;
			var riding = false;
			var rightHand = this.Inventory.GetItem(EquipSlot.RightHand).Data.EquipType1;
			var leftHand = this.Inventory.GetItem(EquipSlot.LeftHand).Data.EquipType1;

			this.Stance = ZoneServer.Instance.Data.StanceConditionDb.FindStanceId(jobId, riding, rightHand, leftHand);

			return this.Stance;
		}

		/// <summary>
		/// Returns a random physical attack damage value.
		/// </summary>
		/// <returns></returns>
		public int GetRandomPAtk()
		{
			var rnd = RandomProvider.Get();

			var min = (int)this.Properties.GetFloat(PropertyName.MINPATK);
			var max = (int)this.Properties.GetFloat(PropertyName.MAXPATK);

			return rnd.Next(min, max + 1);
		}

		/// <summary>
		/// Returns a random magic attack damage value.
		/// </summary>
		/// <returns></returns>
		public int GetRandomMAtk()
		{
			var rnd = RandomProvider.Get();

			var min = (int)this.Properties.GetFloat(PropertyName.MINMATK);
			var max = (int)this.Properties.GetFloat(PropertyName.MAXMATK);

			return rnd.Next(min, max + 1);
		}

		/// <summary>
		/// Returns a random physical or magic attack damage value,
		/// for usage with the given skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <returns></returns>
		public int GetRandomAtk(Skill skill)
		{
			if (skill.Data.ClassType <= SkillClassType.Missile)
				return this.GetRandomPAtk();
			else
				return this.GetRandomMAtk();
		}

		/// <summary>
		/// These should be reference properties?
		/// PCETC Properties
		/// </summary>
		public void SendPCEtcProperties()
		{
			var pcEtcProps = new Properties("PCEtc");
			pcEtcProps.SetString("SkintoneName", "skintone2");
			pcEtcProps.SetString("StartHairName", "UnbalancedShortcut");
			pcEtcProps.SetFloat("LobbyMapID", this.MapId);
			pcEtcProps.SetString("RepresentationClassID", this.JobId.ToString());
			pcEtcProps.SetFloat("LastPlayDate", 20210728);
			pcEtcProps.SetFloat("CTRLTYPE_RESET_EXCEPT", 1);

			Send.ZC_OBJECT_PROPERTY(this.Connection, this, pcEtcProps);
		}

		/// <summary>
		/// Makes character take damage and kills them if their HP reached 0.
		/// Returns true if the character is dead.
		/// </summary>
		/// <param name="damage"></param>
		/// <param name="from"></param>
		/// <returns></returns>
		public bool TakeDamage(int damage, Character from)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns true if the character can attack the entity.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		public bool CanAttack(ICombatEntity entity)
		{
			// For now, let's specify that characters can attack actual
			// monsters.
			return (entity is IMonster monster && monster.MonsterType == MonsterType.Mob);
		}

		/// <summary>
		/// Turns item monster into an item and adds it to the character's
		/// inventory.
		/// </summary>
		/// <param name="itemMonster"></param>
		public void PickUp(ItemMonster itemMonster)
		{
			itemMonster.PickedUp = true;
			itemMonster.Item.ClearProtections();

			// Play pickup animation. This is what actually makes the item
			// disappear, the client doesn't seem to react to ZC_LEAVE in
			// the case of items. Or at least not reliably? It's weird.
			Send.ZC_ITEM_GET(this, itemMonster);

			// Add the item to the inventory
			this.Inventory.Add(itemMonster.Item, InventoryAddType.PickUp);

			// Remove it from the map, so it can't be picked up again.
			this.Map.RemoveMonster(itemMonster);
		}

		/// <summary>
		/// Toggles whether the character is sitting or not.
		/// </summary>
		public void ToggleSitting()
		{
			this.IsSitting = !this.IsSitting;
			this.SitStatusChanged?.Invoke(this);

			Send.ZC_REST_SIT(this);
		}
	}
}