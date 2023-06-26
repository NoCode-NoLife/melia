//--- Melia Script -----------------------------------------------------------
// f_katyn_17
//
//--- Description -----------------------------------------------------------
// Sets up the f_katyn_17 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FKatyn17MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Populations
		var Jellyfish_1_20 = AddMonsterGenerator(MonsterId.Jellyfish, "f_katyn_17", 20);
		var Terranymph_2_15 = AddMonsterGenerator(MonsterId.TerraNymph, "f_katyn_17", 15);
		var WoodgoblinBlack_3_30 = AddMonsterGenerator(MonsterId.Woodgoblin_Black, "f_katyn_17", 30);
		var Terranymph_4_20 = AddMonsterGenerator(MonsterId.TerraNymph, "f_katyn_17", 20);
		var WoodgoblinBlack_5_30 = AddMonsterGenerator(MonsterId.Woodgoblin_Black, "f_katyn_17", 30);

		// Monster Spawners
		AddSpawnPoint(Jellyfish_1_20, TimeSpan.FromMilliseconds(15000), "f_katyn_17", Spot(2157.84, -3368.98, 9999));
		AddSpawnPoint(Terranymph_2_15, TimeSpan.FromMilliseconds(15000), "f_katyn_17", Spot(2088.9377, -3363.0562, 9999));
		AddSpawnPoint(WoodgoblinBlack_3_30, TimeSpan.FromMilliseconds(15000), "f_katyn_17", Spot(856.21704, -2556.583, 9999));
		AddSpawnPoint(Terranymph_4_20, TimeSpan.FromMilliseconds(5000), "f_katyn_17", Spot(-365.0645, 575.12976, 30));
		AddSpawnPoint(Terranymph_4_20, TimeSpan.FromMilliseconds(5000), "f_katyn_17", Spot(-211.9953, 772.6199, 30));
		AddSpawnPoint(Terranymph_4_20, TimeSpan.FromMilliseconds(5000), "f_katyn_17", Spot(-95.256386, 984.68414, 30));
		AddSpawnPoint(Terranymph_4_20, TimeSpan.FromMilliseconds(5000), "f_katyn_17", Spot(-446.6643, 2912.2134, 30));
		AddSpawnPoint(Terranymph_4_20, TimeSpan.FromMilliseconds(5000), "f_katyn_17", Spot(-129.01588, 480.78302, 30));
		AddSpawnPoint(Terranymph_4_20, TimeSpan.FromMilliseconds(5000), "f_katyn_17", Spot(-567.34796, 2572.7617, 30));
		AddSpawnPoint(Terranymph_4_20, TimeSpan.FromMilliseconds(5000), "f_katyn_17", Spot(2.0755424, 759.79126, 30));
		AddSpawnPoint(Terranymph_4_20, TimeSpan.FromMilliseconds(5000), "f_katyn_17", Spot(-686.8902, 709.49963, 30));
		AddSpawnPoint(Terranymph_4_20, TimeSpan.FromMilliseconds(5000), "f_katyn_17", Spot(-659.7813, 886.89075, 30));
		AddSpawnPoint(Terranymph_4_20, TimeSpan.FromMilliseconds(5000), "f_katyn_17", Spot(-641.075, 486.56894, 30));
		AddSpawnPoint(Terranymph_4_20, TimeSpan.FromMilliseconds(5000), "f_katyn_17", Spot(-354.64273, 2655.65, 30));
		AddSpawnPoint(Terranymph_4_20, TimeSpan.FromMilliseconds(5000), "f_katyn_17", Spot(-718.06177, 2738.056, 30));
		AddSpawnPoint(WoodgoblinBlack_5_30, TimeSpan.FromMilliseconds(5000), "f_katyn_17", Spot(-910.71124, 2486.9568, 30));
		AddSpawnPoint(WoodgoblinBlack_5_30, TimeSpan.FromMilliseconds(5000), "f_katyn_17", Spot(-226.57361, 489.3312, 30));
		AddSpawnPoint(WoodgoblinBlack_5_30, TimeSpan.FromMilliseconds(5000), "f_katyn_17", Spot(-872.1727, 2844.4114, 30));
		AddSpawnPoint(WoodgoblinBlack_5_30, TimeSpan.FromMilliseconds(5000), "f_katyn_17", Spot(10.323874, 821.9414, 30));
		AddSpawnPoint(WoodgoblinBlack_5_30, TimeSpan.FromMilliseconds(5000), "f_katyn_17", Spot(-643.28424, 2700.7104, 30));
		AddSpawnPoint(WoodgoblinBlack_5_30, TimeSpan.FromMilliseconds(5000), "f_katyn_17", Spot(-415.56906, 2961.5134, 30));
		AddSpawnPoint(WoodgoblinBlack_5_30, TimeSpan.FromMilliseconds(5000), "f_katyn_17", Spot(-388.32007, 3172.816, 30));
		AddSpawnPoint(WoodgoblinBlack_5_30, TimeSpan.FromMilliseconds(5000), "f_katyn_17", Spot(-202.91437, 3037.9417, 30));
		AddSpawnPoint(WoodgoblinBlack_5_30, TimeSpan.FromMilliseconds(5000), "f_katyn_17", Spot(-126.34724, 2574.186, 30));
		AddSpawnPoint(WoodgoblinBlack_5_30, TimeSpan.FromMilliseconds(5000), "f_katyn_17", Spot(-467.9537, 2532.1345, 30));
		AddSpawnPoint(WoodgoblinBlack_5_30, TimeSpan.FromMilliseconds(5000), "f_katyn_17", Spot(-631.00806, 528.67395, 30));
		AddSpawnPoint(WoodgoblinBlack_5_30, TimeSpan.FromMilliseconds(5000), "f_katyn_17", Spot(-321.69556, 711.8754, 30));

	}
}
