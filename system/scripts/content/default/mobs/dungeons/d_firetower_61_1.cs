//--- Melia Script -----------------------------------------------------------
// d_firetower_61_1
//
//--- Description -----------------------------------------------------------
// Sets up the d_firetower_61_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class DFiretower611MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("Spawner1.d_firetower_61_1", MonsterId.Raider_Bow, 10, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner2.d_firetower_61_1", MonsterId.Socket_Bow_Brown, 50, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner3.d_firetower_61_1", MonsterId.Anchor, 20, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner4.d_firetower_61_1", MonsterId.Socket_Bow_Brown, 25, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner5.d_firetower_61_1", MonsterId.Boss_Marionette, 0, TimeSpan.FromMilliseconds(7200000));
		AddSpawner("Spawner6.d_firetower_61_1", MonsterId.Rootcrystal_04, 20, TimeSpan.FromMilliseconds(30000));

		// Monster Spawn Points -----------------------------

		// Raider_Bow Spawn Points
		AddSpawnPoint("Spawner1.d_firetower_61_1", "d_firetower_61_1", Spot(-124.28546, 719.9453, 35));
		AddSpawnPoint("Spawner1.d_firetower_61_1", "d_firetower_61_1", Spot(-100.69872, 907.7206, 35));
		AddSpawnPoint("Spawner1.d_firetower_61_1", "d_firetower_61_1", Spot(-113.48001, 560.65247, 35));
		AddSpawnPoint("Spawner1.d_firetower_61_1", "d_firetower_61_1", Spot(34.60267, 740.04114, 35));
		AddSpawnPoint("Spawner1.d_firetower_61_1", "d_firetower_61_1", Spot(-1018.7795, 767.0631, 35));
		AddSpawnPoint("Spawner1.d_firetower_61_1", "d_firetower_61_1", Spot(-994.65155, 1117.2344, 35));
		AddSpawnPoint("Spawner1.d_firetower_61_1", "d_firetower_61_1", Spot(-926.5294, 906.4789, 35));
		AddSpawnPoint("Spawner1.d_firetower_61_1", "d_firetower_61_1", Spot(759.5909, 1028.0162, 35));
		AddSpawnPoint("Spawner1.d_firetower_61_1", "d_firetower_61_1", Spot(764.2453, 734.0568, 35));
		AddSpawnPoint("Spawner1.d_firetower_61_1", "d_firetower_61_1", Spot(598.54114, 1175.0568, 35));
		AddSpawnPoint("Spawner1.d_firetower_61_1", "d_firetower_61_1", Spot(614.6905, 843.9636, 35));
		AddSpawnPoint("Spawner1.d_firetower_61_1", "d_firetower_61_1", Spot(-920.2072, 619.4111, 35));
		AddSpawnPoint("Spawner1.d_firetower_61_1", "d_firetower_61_1", Spot(-234.9132, 743.805, 35));

		// Socket_Bow_Brown Spawn Points
		AddSpawnPoint("Spawner2.d_firetower_61_1", "d_firetower_61_1", Spot(-845.9106, -1414.0845, 30));
		AddSpawnPoint("Spawner2.d_firetower_61_1", "d_firetower_61_1", Spot(-956.1421, -1260.3531, 30));
		AddSpawnPoint("Spawner2.d_firetower_61_1", "d_firetower_61_1", Spot(-682.103, -1031.8292, 30));
		AddSpawnPoint("Spawner2.d_firetower_61_1", "d_firetower_61_1", Spot(-1510.2856, -667.1944, 30));
		AddSpawnPoint("Spawner2.d_firetower_61_1", "d_firetower_61_1", Spot(-1378.922, -878.59644, 30));
		AddSpawnPoint("Spawner2.d_firetower_61_1", "d_firetower_61_1", Spot(-1308.6782, -637.70496, 30));
		AddSpawnPoint("Spawner2.d_firetower_61_1", "d_firetower_61_1", Spot(-1913.16, -1106.7289, 30));
		AddSpawnPoint("Spawner2.d_firetower_61_1", "d_firetower_61_1", Spot(-1724.0581, -1098.6893, 30));
		AddSpawnPoint("Spawner2.d_firetower_61_1", "d_firetower_61_1", Spot(-1295.4421, -1704.9774, 30));
		AddSpawnPoint("Spawner2.d_firetower_61_1", "d_firetower_61_1", Spot(-1145.4296, -1684.3141, 30));
		AddSpawnPoint("Spawner2.d_firetower_61_1", "d_firetower_61_1", Spot(-1283.201, -1579.624, 30));
		AddSpawnPoint("Spawner2.d_firetower_61_1", "d_firetower_61_1", Spot(-757.973, -1217.6863, 30));
		AddSpawnPoint("Spawner2.d_firetower_61_1", "d_firetower_61_1", Spot(-1283.3225, -450.9571, 30));

		// Anchor Spawn Points
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(978.414, -479.13254, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(687.4963, -807.7768, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(690.9494, -1054.6661, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(621.70483, -1042.032, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(554.84064, -1173.5216, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(626.09174, -1129.6433, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(1098.2256, -626.88385, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(1066.4008, -682.81476, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(1152.939, -730.958, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(364.0826, -1143.2148, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1813.2968, -1116.1089, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1847.9391, -1065.353, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1815.7681, -1021.1465, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1780.8038, -1196.814, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1709.4275, -1191.1257, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1726.4999, -1034.9432, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1639.9407, -1090.4756, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1771.6571, -966.2074, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1856.7496, -978.49, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1899.9574, -1038.4386, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1866.733, -1164.0588, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1861.3142, -1124.3303, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1806.4287, -1163.7091, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1749.9835, -1137.4995, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1788.8535, -1061.0846, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1683.9603, -1053.5706, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1759.1874, -1014.8031, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1664.3687, -1146.0487, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1749.7108, -1229.2839, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1872.9545, -1020.2828, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1757.338, -1089.8578, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1721.3932, -981.18225, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1840.4828, -1210.8762, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1899.5355, -1182.0933, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1934.6447, -1069.5079, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1519.941, -738.04156, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1413.8959, -836.80023, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1427.1456, -750.434, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1473.5425, -631.16486, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1433.8137, -593.6747, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1393.0714, -541.98, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1344.1964, -492.09094, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1304.1716, -549.5837, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1262.3851, -578.6662, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1232.8726, -622.18005, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1202.1067, -698.73285, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1246.337, -743.80695, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1308.6929, -713.3901, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1355.0244, -656.6853, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1247.6104, -663.5627, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1374.4025, -751.76086, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1419.3036, -702.26025, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1315.8337, -799.01965, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1282.0271, -775.21893, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1342.1469, -834.3739, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1344.2743, -706.72845, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1333.0779, -600.2942, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1220.2341, -473.549, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1200.8429, -535.27484, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1156.171, -567.07086, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-625.7381, -1096.5831, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-571.7692, -1136.6985, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-532.9601, -1198.0992, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-555.6393, -1260.9979, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-607.9577, -1304.3016, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-611.3791, -1250.1232, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-662.0847, -1188.3171, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-677.1903, -1135.9407, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-731.6897, -1133.2137, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-764.748, -1080.8618, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-770.389, -1016.3481, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-724.1038, -996.6355, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-809.8646, -1107.0035, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-859.0954, -1125.3206, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-891.54474, -1164.0803, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-929.03625, -1195.2278, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-803.3511, -1188.6072, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-703.8386, -1236.1426, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-794.11816, -1309.6678, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-842.51776, -1267.51, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-738.7315, -1263.5817, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-663.5895, -1292.0566, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-646.18256, -1363.4889, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-697.04565, -1404.9198, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-697.07434, -1343.8308, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-745.29456, -1438.6539, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-790.61285, -1433.1959, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-866.6948, -1363.1826, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-915.47015, -1331.4918, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-862.6124, -1326.1731, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1200.6748, -1563.2219, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1136.0024, -1584.0453, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1076.6482, -1655.2976, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1126.0123, -1760.1931, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1176.2421, -1811.9576, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1203.4469, -1750.2803, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1224.9905, -1705.0817, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1258.0946, -1675.8365, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1312.7345, -1643.8656, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1220.9653, -1648.2418, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1253.9034, -1765.9125, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1258.3927, -1726.235, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1354.9084, -1676.1378, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1342.0984, -1606.3745, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1258.3553, -1633.9663, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1170.4818, -1623.1279, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1075.1171, -1693.3687, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1113.766, -1658.1046, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1150.7891, -1737.4779, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1213.3635, -1789.4713, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1315.7152, -1749.7607, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1268.7532, -1808.7982, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1366.8057, -1726.3081, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1183.7783, -1699.3964, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1172.8707, -1772.3146, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-163.67696, -1178.3923, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-158.6396, -1339.2329, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-180.55222, -1273.798, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-150.19635, -1230.4238, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-153.9867, -1304.2355, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1004.2919, 711.3459, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-993.0552, 623.3839, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-922.0922, 673.30615, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-868.7998, 726.81104, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-944.66266, 749.9138, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-874.0383, 816.1611, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1010.0568, 869.25146, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-951.5436, 819.1123, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-863.4566, 895.9456, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1004.5165, 915.1947, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-959.8361, 989.99915, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-892.76117, 998.6267, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-845.4904, 1050.9042, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-919.24603, 1069.1201, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1002.8814, 1062.4233, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-920.56854, 1127.4518, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-853.7194, 1130.4791, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-936.8065, 1208.0591, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-882.80835, 1171.0481, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-1032.6898, 1160.6283, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-956.70087, 1100.2606, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-891.49603, 1050.4666, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-855.33044, 958.02997, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-969.91815, 875.8791, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-898.9564, 769.1917, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-153.06503, 974.8634, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-30.92193, 957.9272, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(32.422363, 885.2202, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-29.750168, 838.3073, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-139.30287, 880.6574, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-159.20375, 807.7327, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-84.77119, 790.33954, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-27.309021, 725.28766, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(23.941673, 795.9188, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(57.711914, 681.7659, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(99.1983, 638.8809, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(84.65762, 555.03375, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(18.79773, 514.1579, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(2.3743134, 604.5759, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-74.82385, 650.4529, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-156.44608, 667.1599, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-196.08978, 616.4715, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-164.80952, 556.7945, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-133.79689, 609.8908, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(-33.88317, 628.7803, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(749.8581, 657.22363, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(855.34314, 648.18585, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(935.86237, 681.14484, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(673.4219, 686.169, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(741.0237, 792.6096, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(935.17145, 743.3597, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(943.2227, 839.49194, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(948.89984, 896.492, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(951.81885, 987.4867, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(954.0801, 1074.4956, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(932.75006, 1169.6141, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(827.2918, 1184.0846, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(725.8869, 1223.1089, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(762.596, 1138.6085, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(706.81396, 1136.2383, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(622.49146, 1015.5292, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(767.66785, 961.0504, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(848.9261, 943.9379, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(793.99884, 863.7862, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(734.9022, 857.705, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(612.588, 652.68835, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(731.3095, 700.26965, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(692.9307, 840.2969, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(681.6315, 950.73065, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(628.1298, 949.85767, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(731.5987, 976.9342, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(887.78845, 980.99884, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(899.9189, 1050.7622, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(826.24304, 1094.5072, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(897.0601, 1232.2833, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(899.5708, 903.39404, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(899.6275, 831.7538, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(808.4476, 836.23267, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(875.641, 690.2813, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(806.31287, 678.2947, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(452.7566, -1196.9343, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(378.2587, -1286.0419, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(318.24036, -1237.1749, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(282.06845, -1196.4696, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(377.06693, -1231.8159, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(443.20206, -1128.1897, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(427.83664, -1075.0074, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(522.2106, -1053.3242, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(520.887, -1171.4318, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(568.42725, -1088.4436, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(565.32996, -978.2599, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(629.8496, -894.6894, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(681.32666, -985.7169, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(728.067, -916.14935, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(701.83765, -878.19446, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(781.87024, -822.975, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(789.4601, -757.89813, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(820.22595, -848.5389, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(903.43854, -758.1757, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(821.60486, -685.9967, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(852.09625, -753.9863, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(926.6244, -607.9571, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(881.98, -601.76135, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(952.5425, -722.0579, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(1006.7435, -622.7274, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(908.41376, -673.16345, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(988.6564, -543.68896, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(1051.6174, -425.9834, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(1077.498, -347.09583, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(1136.9772, -329.0028, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(1169.1935, -433.65384, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(1092.7185, -512.6243, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(1125.4622, -411.43973, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(1219.0348, -493.05853, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(1140.1708, -554.25214, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(1055.0271, -590.5404, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(914.1737, -530.66345, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(1010.4326, -687.63086, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(1192.3934, -704.5849, 30));
		AddSpawnPoint("Spawner3.d_firetower_61_1", "d_firetower_61_1", Spot(1197.5712, -772.9748, 30));

		// Socket_Bow_Brown Spawn Points
		AddSpawnPoint("Spawner4.d_firetower_61_1", "d_firetower_61_1", Spot(-140.697, -1266.9506, 9999));
		AddSpawnPoint("Spawner4.d_firetower_61_1", "d_firetower_61_1", Spot(1256.4255, -418.04083, 9999));
		AddSpawnPoint("Spawner4.d_firetower_61_1", "d_firetower_61_1", Spot(1197.1055, -374.49097, 9999));
		AddSpawnPoint("Spawner4.d_firetower_61_1", "d_firetower_61_1", Spot(1009.8329, -415.9323, 9999));
		AddSpawnPoint("Spawner4.d_firetower_61_1", "d_firetower_61_1", Spot(874.63806, -650.90234, 9999));
		AddSpawnPoint("Spawner4.d_firetower_61_1", "d_firetower_61_1", Spot(679.1366, -937.79376, 9999));
		AddSpawnPoint("Spawner4.d_firetower_61_1", "d_firetower_61_1", Spot(612.2753, -990.2491, 9999));
		AddSpawnPoint("Spawner4.d_firetower_61_1", "d_firetower_61_1", Spot(503.8206, -1110.2852, 9999));
		AddSpawnPoint("Spawner4.d_firetower_61_1", "d_firetower_61_1", Spot(406.80896, -1247.5251, 9999));
		AddSpawnPoint("Spawner4.d_firetower_61_1", "d_firetower_61_1", Spot(287.86664, -1315.1316, 9999));
		AddSpawnPoint("Spawner4.d_firetower_61_1", "d_firetower_61_1", Spot(353.10654, -1158.6982, 9999));

		// Boss_Marionette Spawn Points
		AddSpawnPoint("Spawner5.d_firetower_61_1", "d_firetower_61_1", Spot(1792.0118, 216.57356, 20));

		// Rootcrystal_04 Spawn Points
		AddSpawnPoint("Spawner6.d_firetower_61_1", "d_firetower_61_1", Spot(-362.05627, -1921.8156, 100));
		AddSpawnPoint("Spawner6.d_firetower_61_1", "d_firetower_61_1", Spot(327.96472, -1252.7332, 100));
		AddSpawnPoint("Spawner6.d_firetower_61_1", "d_firetower_61_1", Spot(-136.21518, -1713.6892, 100));
		AddSpawnPoint("Spawner6.d_firetower_61_1", "d_firetower_61_1", Spot(765.7132, -1437.6464, 100));
		AddSpawnPoint("Spawner6.d_firetower_61_1", "d_firetower_61_1", Spot(575.95764, -1081.9592, 100));
		AddSpawnPoint("Spawner6.d_firetower_61_1", "d_firetower_61_1", Spot(840.87604, -729.71344, 100));
		AddSpawnPoint("Spawner6.d_firetower_61_1", "d_firetower_61_1", Spot(1182.5339, -390.30103, 100));
		AddSpawnPoint("Spawner6.d_firetower_61_1", "d_firetower_61_1", Spot(1713.9985, -102.74456, 100));
		AddSpawnPoint("Spawner6.d_firetower_61_1", "d_firetower_61_1", Spot(1931.3812, 212.28296, 100));
		AddSpawnPoint("Spawner6.d_firetower_61_1", "d_firetower_61_1", Spot(-141.20386, -1020.4518, 100));
		AddSpawnPoint("Spawner6.d_firetower_61_1", "d_firetower_61_1", Spot(-781.24207, -1240.051, 100));
		AddSpawnPoint("Spawner6.d_firetower_61_1", "d_firetower_61_1", Spot(-1163.9615, -1639.0349, 100));
		AddSpawnPoint("Spawner6.d_firetower_61_1", "d_firetower_61_1", Spot(-1790.8033, -1063.2521, 100));
		AddSpawnPoint("Spawner6.d_firetower_61_1", "d_firetower_61_1", Spot(-1299.6039, -768.09564, 100));
		AddSpawnPoint("Spawner6.d_firetower_61_1", "d_firetower_61_1", Spot(-83.506744, 605.2147, 100));
		AddSpawnPoint("Spawner6.d_firetower_61_1", "d_firetower_61_1", Spot(-58.31372, 955.9928, 100));
		AddSpawnPoint("Spawner6.d_firetower_61_1", "d_firetower_61_1", Spot(-617.0758, 825.93854, 100));
		AddSpawnPoint("Spawner6.d_firetower_61_1", "d_firetower_61_1", Spot(-955.05646, 733.41583, 100));
		AddSpawnPoint("Spawner6.d_firetower_61_1", "d_firetower_61_1", Spot(-903.14825, 1052.9316, 100));
		AddSpawnPoint("Spawner6.d_firetower_61_1", "d_firetower_61_1", Spot(753.25903, 711.73474, 100));
		AddSpawnPoint("Spawner6.d_firetower_61_1", "d_firetower_61_1", Spot(718.80884, 1023.5789, 100));
		AddSpawnPoint("Spawner6.d_firetower_61_1", "d_firetower_61_1", Spot(1042.7471, 1410.736, 100));
		AddSpawnPoint("Spawner6.d_firetower_61_1", "d_firetower_61_1", Spot(1326.4666, 1752.0461, 100));
		AddSpawnPoint("Spawner6.d_firetower_61_1", "d_firetower_61_1", Spot(1254.9791, 1854.442, 100));
		AddSpawnPoint("Spawner6.d_firetower_61_1", "d_firetower_61_1", Spot(-133.08928, 1612.6195, 100));
		AddSpawnPoint("Spawner6.d_firetower_61_1", "d_firetower_61_1", Spot(8.239677, 1774.8738, 100));

	}
}
