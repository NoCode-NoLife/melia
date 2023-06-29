//--- Melia Script -----------------------------------------------------------
// f_pilgrimroad_41_1
//
//--- Description -----------------------------------------------------------
// Sets up the f_pilgrimroad_41_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FPilgrimroad411MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_pilgrimroad_41_1", MonsterId.Tiny_Brown, Properties("MHP", 456418, "MINPATK", 6370, "MAXPATK", 7731, "MINMATK", 6370, "MAXMATK", 7731, "DEF", 62744, "MDEF", 62744));
		AddPropertyOverrides("f_pilgrimroad_41_1", MonsterId.Tiny_Bow_Green, Properties("MHP", 456762, "MINPATK", 6374, "MAXPATK", 7736, "MINMATK", 6374, "MAXMATK", 7736, "DEF", 62882, "MDEF", 62882));
		AddPropertyOverrides("f_pilgrimroad_41_1", MonsterId.Wendigo_Magician_Blue, Properties("MHP", 457391, "MINPATK", 6383, "MAXPATK", 7746, "MINMATK", 6383, "MAXMATK", 7746, "DEF", 63134, "MDEF", 63134));

		// Monster Spawners --------------------------------

		AddSpawner("Spawner1.f_pilgrimroad_41_1", MonsterId.Rootcrystal_05, 16, TimeSpan.FromMilliseconds(5000));
		AddSpawner("Spawner2.f_pilgrimroad_41_1", MonsterId.Tiny_Brown, 30, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner3.f_pilgrimroad_41_1", MonsterId.Tiny_Bow_Green, 10, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner4.f_pilgrimroad_41_1", MonsterId.Wendigo_Magician_Blue, 10, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner5.f_pilgrimroad_41_1", MonsterId.Tiny_Bow_Green, 30, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner6.f_pilgrimroad_41_1", MonsterId.Tiny_Brown, 4, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner7.f_pilgrimroad_41_1", MonsterId.Tiny_Brown, 70, TimeSpan.FromMilliseconds(0));

		// Monster Spawn Points -----------------------------

		// Rootcrystal_05 Spawn Points
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-980.78345, -1026.7244, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-993.2418, -818.3947, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-702.0451, -975.10815, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-723.5587, -753.0212, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1231.7931, -297.93933, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-82.76709, -909.9945, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(14.595799, -707.85376, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(165.3728, -847.8319, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-893.4783, 160.91284, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-457.877, -439.58746, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1543.2329, 670.41516, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1436.6495, 823.53174, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-764.419, 404.4103, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-571.32776, 909.30035, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-320.9069, 957.5587, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(82.45672, 1004.5923, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(472.69046, 1028.4829, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-60.22777, 258.59952, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-113.89394, -138.77194, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(278.99988, -42.58488, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(446.40924, 473.50116, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(916.4279, 920.6755, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1020.6411, 652.61206, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(684.3441, -267.74335, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(910.0633, -326.27554, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1097.3652, 114.08388, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1373.9105, 236.55115, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1843.1223, 414.57922, 50));

		// Tiny_Brown Spawn Points
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-128.60738, 19.41961, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-81.37822, 168.84627, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(144.60634, 305.07562, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(85.08118, 84.213326, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(14.197405, -71.477516, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(159.81282, -202.40807, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(337.24475, 141.90956, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-368.15305, -356.50647, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-581.3191, -575.57416, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-590.0895, -291.65894, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-792.6019, 140.67891, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-985.45123, 128.14832, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1176.8002, -235.09857, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1337.992, -452.98306, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-838.8035, -718.5198, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-944.6279, -911.8436, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-841.4485, -1100.9835, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-601.96844, -924.7015, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-756.973, -904.418, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-164.64311, -1022.0566, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(52.498154, -1044.497, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-68.54405, -770.00934, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(136.96727, -666.90265, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(85.89469, -911.84204, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(249.47867, -924.3434, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(458.34836, -706.11993, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(582.6422, -418.92725, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(604.71924, -520.5214, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(735.6239, -164.09999, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(830.2646, -115.05878, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(810.0584, -334.4091, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1196.0504, 137.69577, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1197.1201, 309.93417, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-369.5963, 764.6835, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1604.661, 281.14526, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1850.1394, 513.8274, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1991.0637, 282.11032, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1810.8951, 303.68103, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1081.3038, 486.7758, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1129.1333, 693.0359, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(820.8751, 680.24713, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(680.14954, 780.80634, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(909.7751, 1022.2531, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(936.15314, 730.94135, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1064.0852, 904.0125, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(629.95087, 697.0039, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(279.61414, 394.81113, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-223.28992, 282.80164, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-661.34357, 733.371, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-500.4375, 1030.1619, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-395.9405, 900.87354, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-27.227573, 1123.755, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(106.68715, 886.7449, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(287.6912, 1199.6646, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(219.22012, 841.7092, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(929.6461, 905.1584, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-932.42664, 348.13892, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1350.8032, 587.70856, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1597.5458, 578.2238, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1600.2137, 908.0813, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1366.1058, 741.7932, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-265.02847, -167.73033, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-654.8503, 838.0588, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-153.46146, 920.05817, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(127.08839, 1124.3419, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(301.12262, 1024.8876, 25));

		// Tiny_Bow_Green Spawn Points
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1722.2145, 377.4149, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1960.1058, 433.70694, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1860.1259, 173.20973, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1704.6212, 227.19191, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1188.0481, 49.05242, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1123.5336, 230.25226, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1286.8224, 263.6927, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1327.9999, 87.804306, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1037.7976, 757.12805, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(918.56354, 656.654, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(751.6648, 773.4152, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(994.58496, 1011.4035, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(968.0196, 845.7717, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1151.051, 911.40234, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(491.43045, 550.20154, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(347.26526, 531.20374, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(561.10077, 318.75095, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(619.2761, -1.583231, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(625.90375, -339.7624, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(772.7537, -233.26085, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1014.4431, -24.890203, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(685.126, -393.1827, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(916.2645, -413.30728, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(525.76776, -617.89935, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(364.74478, -753.8364, 25));

		// Wendigo_Magician_Blue Spawn Points
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-244.36887, -48.309162, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(57.031967, 248.53561, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(248.8698, 273.9548, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(144.54836, -4.1026535, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-172.29033, 157.19414, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-193.12445, -259.25604, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-472.11792, -349.36725, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-612.6053, -693.1613, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-833.8754, -821.4753, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-802.4402, -1005.3542, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-662.3306, -836.40137, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-607.49243, -1046.1794, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-190.25864, -860.28015, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(104.37625, -773.47815, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-21.715733, -620.2732, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-184.9155, -768.264, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(248.0188, -770.6187, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(4.3754883, -932.6551, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1005.3829, -945.87964, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1222.7633, -421.18915, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1048.8799, -604.94257, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1288.8131, -215.69724, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-944.96173, 42.714222, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-841.30566, 464.37296, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1012.2021, 317.88953, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-861.8641, 76.81822, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-605.0105, -136.29352, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1320.3132, 668.1847, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1483.211, 578.23914, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1662.9957, 680.77496, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1408.3418, 916.5371, 25));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1510.8828, 753.0168, 25));

		// Tiny_Bow_Green Spawn Points
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-897.2633, -1001.536, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-707.0376, -1053.6132, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-925.72235, -758.06866, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-751.2981, -653.04425, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-862.3946, -564.8045, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-453.4423, -534.52606, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-443.92386, -230.51477, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-692.68054, -179.7391, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-794.90985, 48.30385, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1070.0013, 124.11475, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-772.34216, 288.79364, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1285.6038, -112.20132, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1402.1205, -293.82764, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1179.616, -514.7233, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-825.91473, -910.6662, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-52.981148, -1016.6929, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-117.88197, -653.6382, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(71.78568, -589.62256, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1.9789963, -839.59033, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(150.09842, -963.4093, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(445.7102, -608.97046, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(732.50714, -339.27826, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(572.3822, -270.97577, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(725.65875, -507.8804, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(944.18774, -204.23932, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(698.6821, -37.489613, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(850.6957, -211.45195, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(587.12665, -152.5028, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(792.5974, -416.35538, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-61.104748, -211.85144, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-267.0572, 108.37508, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-110.69087, 359.4306, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(3.3848724, 81.73685, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(196.95995, -104.55543, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(353.69247, 24.718424, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(232.66527, 104.52613, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(23.457014, 379.4182, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(122.02639, 450.40552, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(367.33945, 397.3949, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-238.11975, 377.8796, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-723.4339, 500.93094, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-669.29346, 997.36383, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-513.0417, 708.61005, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-293.13818, 1056.937, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-250.27127, 815.4325, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-23.079504, 1012.8384, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(23.3745, 859.39575, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(200.49617, 1110.9746, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(318.91782, 886.1916, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(188.11168, 964.4872, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(654.8377, 653.19666, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(870.62897, 817.3724, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1068.3752, 1042.233, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1099.8169, 819.21106, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-933.088, 222.56233, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1385.0952, 649.0907, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1623.8113, 780.7735, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1531.2433, 947.7355, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-889.5996, -26.474344, 25));

		// Tiny_Brown Spawn Points
		AddSpawnPoint("Spawner6.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-739.729, -1100.4407, 25));
		AddSpawnPoint("Spawner6.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-886.36426, -860.0175, 25));
		AddSpawnPoint("Spawner6.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-697.0666, -869.52356, 25));
		AddSpawnPoint("Spawner6.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-887.2721, -643.97473, 25));
		AddSpawnPoint("Spawner6.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1284.5272, -404.6504, 25));
		AddSpawnPoint("Spawner6.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1303.6086, -270.32285, 25));
		AddSpawnPoint("Spawner6.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1133.2103, -368.51517, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-80.33365, -973.9851, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(142.14238, -1012.8772, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-62.864677, -685.87396, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(265.83517, -820.86206, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(366.28467, 927.71857, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(27.249886, 1073.8862, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-161.15192, 860.81824, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-253.87968, 278.60083, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(199.02722, 317.03143, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-945.86084, 291.4083, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-795.84314, 234.60461, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1965.4199, 388.52808, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1935.0786, 501.0252, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1839.0691, 473.4737, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1739.279, 357.4676, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-83.551926, -260.38165, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(187.34975, -213.73834, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1966.2421, 328.0642, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1984.6139, 232.4429, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1923.1356, 196.05185, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1814.1456, 196.5725, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(167.62247, 1070.8422, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-502.61923, 961.22656, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1691.8445, 280.95914, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1656.5272, 241.03664, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(23.229885, 298.64297, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1601.3126, 390.37845, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-872.4114, 54.58299, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1712.3777, 474.12836, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-18.635578, 99.2332, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-363.33804, 1068.1595, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-616.316, 1030.5879, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(795.85095, 969.2653, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(714.5514, 989.77203, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(181.47845, 874.3773, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1208.9332, 118.54307, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1252.7125, -17.812347, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1315.5198, 62.729454, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1079.853, 30.704384, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(810.61487, 732.88196, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1118.222, 929.42554, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1089.6892, 652.78345, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1150.1562, 92.909164, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(947.17145, 819.79913, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(856.3574, 746.1197, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-592.47253, 794.52203, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1506.0127, 617.94366, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-339.89062, 848.4696, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(123.44038, -104.67084, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1111.8904, 218.86357, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1391.6729, 830.60187, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1155.4191, 277.97678, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1111.5828, 348.31113, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(225.22957, 121.70212, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1352.2328, 152.43811, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1244.9032, 274.62656, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-186.48105, -36.996693, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1412.7246, 218.40967, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1065.7561, 855.4129, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(1335.6337, 305.73715, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(368.3637, 1090.378, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(839.41724, -167.5404, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(716.367, -107.23299, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(609.5267, -220.24101, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(778.4201, -214.01894, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(920.03326, -304.72, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(621.40045, -96.97705, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1252.2505, -382.5126, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(841.6434, -432.01752, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(579.7133, -302.79156, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(32.858162, 39.719948, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(600.9406, -390.49152, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(694.34393, -527.387, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(644.6998, -503.754, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(676.79364, -338.915, 25));
		AddSpawnPoint("Spawner7.f_pilgrimroad_41_1", "f_pilgrimroad_41_1", Spot(-1123.1554, -216.79811, 25));

	}
}
