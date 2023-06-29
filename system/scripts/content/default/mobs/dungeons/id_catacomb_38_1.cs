//--- Melia Script -----------------------------------------------------------
// id_catacomb_38_1
//
//--- Description -----------------------------------------------------------
// Sets up the id_catacomb_38_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class IdCatacomb381MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("Spawner1.id_catacomb_38_1", MonsterId.Socket_Bow, 30, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner2.id_catacomb_38_1", MonsterId.Socket_Mage, 30, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner3.id_catacomb_38_1", MonsterId.Velffigy_Green, 50, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner4.id_catacomb_38_1", MonsterId.Rootcrystal_01, 7, TimeSpan.FromMilliseconds(30000));

		// Monster Spawn Points -----------------------------

		// Socket_Bow Spawn Points
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-756.6504, 267.94608, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-313.4369, 219.9249, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-813.81635, -5.598984, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1413.575, 813.42175, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1267.0913, 1062.417, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(1568.1772, 1137.2885, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(333.67468, -64.81942, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(333.32492, 147.52975, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1350.1875, 944.00085, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(1211.7295, -93.81282, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(1316.0544, -604.2256, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(1617.6757, -545.1328, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(1630.152, -95.21479, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(1117.7156, -531.28906, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(1408.8544, -306.37778, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(1525.0114, 32.65277, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-496.6005, 338.3412, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1132.2351, 991.69147, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1572.892, 855.4279, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-447.805, 60.203556, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(1278.4292, 1141.795, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(1122.7745, 979.5606, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(94.63771, -723.32886, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(73.9772, -657.1662, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(187.9099, -614.57465, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(85.42193, -549.8992, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(400.86755, -469.15994, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(490.95703, -515.88434, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(513.38043, -585.40424, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(501.1244, -698.75073, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(500.2328, -758.93286, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(379.5451, -787.77954, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(315.22003, -737.4204, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(421.4203, -722.97595, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(250.06006, -790.02124, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(312.10733, -813.23553, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(164.16318, -795.47205, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(258.39456, -703.13776, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(336.89597, -619.82874, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(424.26187, -538.3231, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(451.44104, -440.98706, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(352.02713, -516.3419, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(280.4308, -567.23914, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(254.76115, -639.43933, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(195.43349, -534.4791, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(136.64758, -654.29407, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(140.26385, -474.5054, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(525.27954, 60.269787, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(527.4444, 134.798, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(466.4857, 146.03178, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(463.62717, 105.06023, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(374.59735, 105.01183, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(401.09082, 151.49081, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(260.0764, 77.75045, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(197.81146, -12.523331, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(195.9087, -110.68832, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(295.70218, -115.1915, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(265.74725, 12.135046, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(338.9938, -1.0752759, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(383.27582, -91.29962, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(454.67938, -118.56789, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(524.41125, -99.527405, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(418.6178, 16.4073, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(458.2576, -53.14354, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(386.61313, 61.812347, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(335.50226, -130.18602, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(205.64444, 44.827915, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-293.698, 8.804489, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-385.04425, -38.817753, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-468.6753, -47.42649, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-755.53375, -24.09341, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-832.9328, 72.522766, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-873.4184, 24.054396, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-753.71625, 49.113884, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-900.18097, 206.00224, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-887.5819, 376.9989, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-777.1404, 425.4992, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-814.287, 363.76602, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-594.6866, 447.37515, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-401.88046, 424.26392, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-334.59015, 376.09607, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-296.5762, 328.90002, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-282.80457, 289.81607, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-440.10757, 387.17926, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-552.6354, 401.50177, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-439.2434, 138.63274, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-355.22772, 144.83936, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-457.35553, -613.95917, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-430.57672, -698.6855, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-427.45435, -795.069, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-466.86456, -870.5357, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-618.1882, -893.8139, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-701.8018, -925.80334, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-787.4, -868.73114, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-795.0785, -766.70905, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-798.6425, -691.526, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-689.2658, -631.11395, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-594.34656, -625.32605, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-540.6831, -650.78107, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-636.17664, -724.09235, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-628.2081, -792.9305, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-578.0807, -776.8805, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-583.6126, -870.9235, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-731.801, -820.2462, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-721.6892, -737.07086, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-668.2451, -677.2306, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-503.40143, -940.9524, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-432.9246, -924.819, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-416.09177, -850.3885, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-391.03348, -727.09906, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-479.57764, -710.03094, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-396.7466, -623.804, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-804.26404, -940.1814, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-655.8024, -946.5353, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1039.3517, -1422.284, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-935.47186, -1465.8364, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-871.2698, -1541.2822, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-923.32947, -1626.2324, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-913.5434, -1686.7528, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1103.5653, -1687.8958, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1114.3663, -1515.6615, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1259.5194, -1687.451, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1320.5267, -1482.9192, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1293.1447, -1364.5725, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1173.913, -1296.5033, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1323.4238, -1317.9204, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1059.9622, -1279.9563, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-938.236, -1292.2323, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-842.06866, -1303.684, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-850.2814, -1386.5469, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-898.1197, -1469.5824, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-915.9116, -1572.0874, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-863.8754, -1655.1743, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1048.5695, -1470.0078, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1002.0762, -1505.9664, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1109.2894, -1593.059, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1060.7168, -1624.6462, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-841.13684, -1720.1622, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-972.8573, -1644.4003, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-978.6154, -1547.9772, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1108.4174, -1417.9039, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1232.8662, -1369.97, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1152.239, -1609.4304, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1297.5554, -1624.7727, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1181.6667, -1708.5408, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1328.6978, -1545.1124, 30));
		AddSpawnPoint("Spawner1.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1331.8717, -1412.957, 30));

		// Socket_Mage Spawn Points
		AddSpawnPoint("Spawner2.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1001.7162, -1603.5688, 30));
		AddSpawnPoint("Spawner2.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1144.5616, -1364.2958, 30));
		AddSpawnPoint("Spawner2.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1216.5216, -1564.7797, 30));
		AddSpawnPoint("Spawner2.id_catacomb_38_1", "id_catacomb_38_1", Spot(-931.3535, -1416.3496, 30));
		AddSpawnPoint("Spawner2.id_catacomb_38_1", "id_catacomb_38_1", Spot(-750.987, -655.5559, 30));
		AddSpawnPoint("Spawner2.id_catacomb_38_1", "id_catacomb_38_1", Spot(-502.80234, -676.87994, 30));
		AddSpawnPoint("Spawner2.id_catacomb_38_1", "id_catacomb_38_1", Spot(-674.4337, -863.5313, 30));
		AddSpawnPoint("Spawner2.id_catacomb_38_1", "id_catacomb_38_1", Spot(185.17282, -698.7534, 30));
		AddSpawnPoint("Spawner2.id_catacomb_38_1", "id_catacomb_38_1", Spot(233.94472, -460.2763, 30));
		AddSpawnPoint("Spawner2.id_catacomb_38_1", "id_catacomb_38_1", Spot(442.7342, -633.8768, 30));
		AddSpawnPoint("Spawner2.id_catacomb_38_1", "id_catacomb_38_1", Spot(1214.2252, -338.56796, 30));
		AddSpawnPoint("Spawner2.id_catacomb_38_1", "id_catacomb_38_1", Spot(1711.7203, -355.75415, 30));
		AddSpawnPoint("Spawner2.id_catacomb_38_1", "id_catacomb_38_1", Spot(1444.9946, -620.8512, 30));
		AddSpawnPoint("Spawner2.id_catacomb_38_1", "id_catacomb_38_1", Spot(1446.2682, -89.77947, 30));
		AddSpawnPoint("Spawner2.id_catacomb_38_1", "id_catacomb_38_1", Spot(1453.5184, -432.74426, 30));
		AddSpawnPoint("Spawner2.id_catacomb_38_1", "id_catacomb_38_1", Spot(1214.2291, -51.86488, 30));
		AddSpawnPoint("Spawner2.id_catacomb_38_1", "id_catacomb_38_1", Spot(158.2666, -590.7387, 30));
		AddSpawnPoint("Spawner2.id_catacomb_38_1", "id_catacomb_38_1", Spot(-494.9513, -816.20483, 30));
		AddSpawnPoint("Spawner2.id_catacomb_38_1", "id_catacomb_38_1", Spot(258.84253, -62.249687, 30));
		AddSpawnPoint("Spawner2.id_catacomb_38_1", "id_catacomb_38_1", Spot(500.38745, 4.9909096, 30));

		// Velffigy_Green Spawn Points
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(136.95845, 1173.0006, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(369.82925, 1032.4949, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1306.3815, 912.3051, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1309.2699, 1287.1099, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1510.7274, 1003.0668, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1529.5122, 1384.907, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1073.6724, 1161.2162, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-9.463304, 922.58795, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-647.66864, 378.99457, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-324.95773, 77.309586, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1466.5092, 960.4479, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1268.3431, 816.8558, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1493.8099, 1092.2102, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-648.6405, 116.19724, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-525.0472, 177.76999, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(579.75256, -11.577963, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(332.1053, 68.30628, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(111.78197, -15.605151, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1098.4573, 1391.8706, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(961.3116, 1441.0968, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-825.0112, 267.18497, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-531.4788, -104.14353, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-472.8339, 423.28146, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1377.865, 1229.8562, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1458.7211, 1402.5259, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1520.1517, 1252.6151, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1501.2278, 1172.4077, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1573.5474, 1199.1409, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1425.1788, 1214.0103, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1561.2023, 1099.0868, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1430.0763, 1003.0345, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1457.3284, 1101.5228, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1417.5822, 933.38855, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1291.5378, 1018.9232, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1423.6418, 1111.6498, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1295.1274, 1214.2256, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1373.5691, 1155.8358, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1231.786, 1080.0139, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1229.4481, 983.4326, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1135.1044, 1077.4032, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1166.9192, 1184.71, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1215.5894, 1143.3395, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1117.855, 1222.2997, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1408.8884, 1437.7532, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1398.6207, 1358.0282, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1317.6881, 1388.8547, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1254.544, 1470.8033, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1265.3873, 1357.055, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1124.9507, 1313.0967, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1173.2914, 1414.5645, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1200.2949, 1281.3912, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1069.4583, 1268.9742, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1051.5953, 1401.2579, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1620.2158, 1390.5853, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1612.9296, 1314.7361, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1444.6359, 1298.8555, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1390.9703, 1285.8549, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1366.2909, 1093.3536, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1627.0637, 1061.7524, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1625.5067, 950.78345, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1570.7253, 902.0884, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1484.7366, 907.6886, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1353.6049, 861.06146, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1219.6228, 829.4366, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1126.488, 824.04346, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1035.5455, 928.99097, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(991.4229, 1038.8538, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1081.9601, 1059.3859, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1603.4407, 7.6544304, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1673.064, -24.059923, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1569.5184, -68.49717, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1611.5664, -151.77097, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1704.495, -214.85901, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1671.2473, -305.25385, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1689.7084, -414.4656, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1750.9531, -524.53503, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1686.7098, -653.32996, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1621.4811, -603.30927, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1556.6586, -439.8713, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1504.8551, -384.22742, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1358.8585, -430.41272, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1366.4264, -330.48584, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1428.3344, -380.55875, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1557.6107, -661.2531, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1417.6702, -578.48584, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1488.0358, -658.6593, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1273.4886, -637.1961, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1132.9207, -634.2759, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1196.3838, -550.58374, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1234.8196, -603.1831, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1177.034, -507.1509, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1273.6711, -347.45322, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1228.8951, -444.39124, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1218.0826, -272.01486, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1198.8448, -328.44397, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1332.2513, -118.3568, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1365.905, -204, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1450.9249, -225.80537, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1279.6825, -75.35572, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1255.242, -193.21964, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1169.8395, -247.49548, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1510.7688, -290.12503, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(1578.1835, -408.087, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(492.16385, 937.1424, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(335.83688, 944.08984, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(209.55844, 941.80835, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(209.15494, 1118.9308, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(309.95007, 1167.225, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(424.04053, 1139.9689, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(460.73752, 1099.2675, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(487.74994, 1030.1896, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(342.43466, 1112.3807, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(432.73642, 1222.2959, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(488.08832, 1178.1038, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(354.41827, 1226.3586, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(264.48026, 1214.5742, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(265.63733, 1052.0652, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(290.37933, 980.70416, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(159.46451, 1071.5278, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(133.40459, 987.7066, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(62.625217, 965.3634, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-3.435093, 988.54517, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-47.8588, 937.8031, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1136.7258, 800.0879, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1214.3184, 758.15656, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1131.6014, 901.3801, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1227.4113, 905.6244, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1138.626, 1066.0886, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1193.1918, 1157.3281, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1199.4841, 1027.8907, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1249.7394, 978.98346, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1292.1094, 887.3474, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1335.0145, 773.3309, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1464.4037, 779.6783, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1456.133, 870.06793, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1565.2455, 933.423, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1618.7979, 893.60486, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1597.4188, 1050.2269, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1608.8035, 1139.7847, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1428.7899, 1126.9451, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1516.9224, 1014.1522, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1384.9119, 1037.6719, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1256.2261, 1146.8374, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1139.8976, 1134.4847, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1217.6028, 1108.9058, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1343.4095, 1082.7515, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1390.5002, 964.9413, 30));
		AddSpawnPoint("Spawner3.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1396.9072, 876.68634, 30));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint("Spawner4.id_catacomb_38_1", "id_catacomb_38_1", Spot(1282.1924, 18.004013, 100));
		AddSpawnPoint("Spawner4.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1027.0051, -1510.5182, 100));
		AddSpawnPoint("Spawner4.id_catacomb_38_1", "id_catacomb_38_1", Spot(419.41348, -522.24963, 100));
		AddSpawnPoint("Spawner4.id_catacomb_38_1", "id_catacomb_38_1", Spot(-547.9602, 36.682076, 100));
		AddSpawnPoint("Spawner4.id_catacomb_38_1", "id_catacomb_38_1", Spot(-1369.87, 1038.8936, 100));
		AddSpawnPoint("Spawner4.id_catacomb_38_1", "id_catacomb_38_1", Spot(358.9082, 1123.4089, 100));
		AddSpawnPoint("Spawner4.id_catacomb_38_1", "id_catacomb_38_1", Spot(1397.2501, 1438.5646, 100));

	}
}
