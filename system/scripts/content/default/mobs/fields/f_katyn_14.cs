//--- Melia Script -----------------------------------------------------------
// f_katyn_14
//
//--- Description -----------------------------------------------------------
// Sets up the f_katyn_14 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FKatyn14MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("Spawner1.f_katyn_14", MonsterId.Rootcrystal_02, 20, TimeSpan.FromMilliseconds(5000));
		AddSpawner("Spawner2.f_katyn_14", MonsterId.Honey_Bee, 20, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner3.f_katyn_14", MonsterId.Fisherman_Red, 30, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner4.f_katyn_14", MonsterId.Mushroom_Ent_Blue, 7, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner5.f_katyn_14", MonsterId.Puragi_Blue, 50, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner6.f_katyn_14", MonsterId.Fisherman_Red, 40, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner7.f_katyn_14", MonsterId.Honey_Bee, 40, TimeSpan.FromMilliseconds(0));

		// Monster Spawn Points -----------------------------

		// Rootcrystal_02 Spawn Points
		AddSpawnPoint("Spawner1.f_katyn_14", "f_katyn_14", Spot(1249, -979, 30));
		AddSpawnPoint("Spawner1.f_katyn_14", "f_katyn_14", Spot(-143, -681, 30));
		AddSpawnPoint("Spawner1.f_katyn_14", "f_katyn_14", Spot(-2065, -1136, 30));
		AddSpawnPoint("Spawner1.f_katyn_14", "f_katyn_14", Spot(-1749, 735, 30));

		// Honey_Bee Spawn Points
		AddSpawnPoint("Spawner2.f_katyn_14", "f_katyn_14", Spot(-309.24988, -575.8472, 9999));

		// Fisherman_Red Spawn Points
		AddSpawnPoint("Spawner3.f_katyn_14", "f_katyn_14", Spot(-1810.67, -1158.445, 9999));

		// Mushroom_Ent_Blue Spawn Points
		AddSpawnPoint("Spawner4.f_katyn_14", "f_katyn_14", Spot(-1849.8284, 566.271, 9999));

		// Puragi_Blue Spawn Points
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2087.655, -1955.0045, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1938.5796, -750.67303, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2363.438, -530.3408, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2287.9436, 147.99515, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2331.166, -276.148, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2136.3142, -899.37805, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(842.046, 234.93793, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(873.75214, -1380.3894, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1088.8665, -1440.2477, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(746.8396, 193.89952, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(556.86066, -1193.9968, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1308.3448, -1613.4673, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2114.2498, 283.92474, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2148.3306, 396.31006, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2845.0576, -2205.8052, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(3008.1592, -2159.784, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2136.9097, 435.03088, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2096.155, 452.45178, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2185.6213, 437.9158, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2216.3462, 401.0445, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2205.4834, 343.78473, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2156.8691, 312.34454, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2112.2986, 337.73462, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2050.1113, 282.54156, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2119.9717, 127.80119, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2179.657, 224.92818, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2297.3381, 187.48169, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2286.2407, 100.85464, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2208.9207, 109.98531, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2324.0793, 113.85332, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2257.7263, 197.34625, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2351.9822, -307.9577, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2327.7668, -362.6445, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2340.8, -398.48495, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2314.856, -442.87958, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2355.2256, -470.7756, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2463.921, -626.7484, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2503.5955, -639.4431, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2527.9404, -662.4004, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2523.3677, -720.5043, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2484.6511, -689.3624, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2387.7117, -693.6879, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2335.531, -764.2048, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2333.7798, -711.7874, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2556.9048, -736.14087, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2540.383, -807.26117, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2566.5415, -824.1609, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2501.4255, -857.65643, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2331.1572, -833.9468, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2080.9497, -625.4653, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2095.1924, -661.8275, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2012.1772, -697.3177, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1981.7272, -633.86884, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1954.0469, -685.98944, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1895.4668, -692.16943, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1994.6555, -753.5115, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2021.7546, -786.2677, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2148.814, -799.6003, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2187.2573, -887.3517, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2083.3196, -899.0239, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2188.715, -934.965, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2151.246, -944.78, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2154.7324, -1002.6605, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2097.7598, -1001.9567, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2067.2405, -967.61914, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2217.7786, -1067.655, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2262.358, -1072.3297, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2263.5837, -1128.9749, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2161.6912, -1089, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2192.6526, -1025.3553, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2242.3271, -1020.5153, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2291.5803, -1024.725, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2311.644, -1083.9856, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2312.1394, -1127.6622, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2080.4993, -1190.0399, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2084.6387, -1116.1306, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2043.625, -1070.6208, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1995.4879, -1105.5769, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2018.252, -1211.9418, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1940.6976, -1258.4641, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1918.646, -1060.314, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1958.8707, -1002.6419, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(3066.6968, -2267.2986, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2990.4248, -2303.303, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2825.8818, -2298.7434, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2941.7078, -2197.423, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2913.7727, -2288.5984, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2872.1917, -2158.8623, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2915.8518, -2084.2002, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2945.025, -2036.2137, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2890.699, -1978.7767, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2831.8313, -2061.8625, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1962.5206, -1712.5806, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1973.8394, -1795.2495, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1950.2195, -1676.4032, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1946.3331, -1620.2578, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(2035.0364, -1902.225, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(968.28595, 289.8217, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(922.2517, 140.345, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(993.1256, 207.30302, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(918.6178, 293.52417, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(866.41156, 80.47366, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(802.7412, 143.77107, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(808.2416, 34.576077, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(808.92285, 293.72992, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(866.5518, -39.169975, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1022.2385, -71.02019, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(983.52203, 73.39129, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(919.4077, -110.52275, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1049.8284, -425.04144, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(976.9294, -494.75488, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(960.86633, -373.98395, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(952.05975, -638.4447, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1051.9574, -651.0364, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1219.2673, -667.2611, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1154.4664, -534.137, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1164.205, -465.35162, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1138.5906, -386.97858, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1030.0924, -561.27637, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1093.4691, -710.3192, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1347.6256, -1613.4312, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1301.8335, -1673.4569, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1260.1549, -1656.303, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1261.1027, -1601.7104, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1217.4143, -1635.4976, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1233.2333, -1574.0454, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1228.4371, -1533.5315, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1168.0996, -1623.3969, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1130.4341, -1689.5271, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1150.6194, -1474.0205, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1166.4573, -1420.2485, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1150.5793, -1377.584, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1122.2806, -1332.5859, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(883.1707, -1747.4628, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(881.99286, -1658.2686, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(994.72253, -1639.1906, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1048.0399, -1755.0525, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1048.0372, -1699.785, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(962.09894, -1763.01, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(914.601, -1485.9966, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(960.67334, -1400.359, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1011.2617, -1492.3103, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1047.7424, -1325.5126, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(980.7983, -1178.7595, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(920.93225, -1237.2916, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(649.92834, -1228.407, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(499.98828, -1155.7505, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(462.51324, -1131.0217, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(712.7288, -1245.5343, 30));
		AddSpawnPoint("Spawner5.f_katyn_14", "f_katyn_14", Spot(1067.991, -1217.1729, 30));

		// Fisherman_Red Spawn Points
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-304.27054, 529.44507, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-395.8711, 147.91531, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-759.0257, 360.16122, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1351.9026, 734.1696, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1359.8398, 1097.4341, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2891.0996, 608.26544, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2663.0527, 795.95056, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2930.9485, 1346.5066, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2579.7715, 1623.2456, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1765.1863, 565.5967, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1794.6086, -1379.762, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2964.8528, -1343.3031, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1051.2263, -1156.1123, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-266.9281, 660.978, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-321.5272, 684.4751, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-169.08295, 462.6045, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-237.14352, 469.25668, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-144.5997, 345.8294, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-225.19098, 223.41139, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-354.8717, 190.62943, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-306.0559, 310.4817, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-385.25485, 385.0259, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-457.9992, 486.54163, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-419.91547, 480.104, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-419.14618, 612.8713, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-569.9375, 461.48102, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-647.14215, 282.0072, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-591.2847, 367.80823, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-548.4852, 381.95718, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-415.31662, 223.4366, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-383.13168, 272.7817, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-748.6355, 329.6138, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-796.71246, 303.91556, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-839.41925, 317.02402, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-773.45685, 261.2527, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1254.1658, 694.74225, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1288.6382, 729.0483, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1044.9719, 950.8545, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1015.1514, 853.1709, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1170.8953, 886.0249, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1151.3353, 994.8301, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1224.7406, 1020.5966, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1314.0222, 950.2598, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1129.6149, 924.20026, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-964.1722, 867.4682, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-964.18176, 784.15454, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-982.7275, 679.0446, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1086.589, 733.71967, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1112.0685, 545.2675, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1018.0862, 577.58344, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1182.8201, 587.15356, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1277.451, 490.81204, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1216.1223, 430.0034, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1064.7385, 467.96436, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1152.8976, 797.70233, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1331.2205, 851.8475, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1327.2496, 990.1104, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1395.1871, 929.2219, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1683.3887, 674.60645, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1750.7701, 716.2351, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1723.294, 812.82465, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1875.6621, 576.3883, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1916.349, 1093.6414, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1972.9873, 1045.5371, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-1832.5286, 1034.9673, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2534.516, 1639.9409, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2511.1206, 1503.2954, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2454.92, 1535.2712, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2375.3315, 1556.4169, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2393.3752, 1501.2026, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2397.089, 1458.1462, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2456.8892, 1293.4445, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2401.0642, 1346.2192, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2372.9082, 1290.9303, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2534.3665, 1196.1095, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2587.1575, 1326.252, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2648.878, 1359.5607, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2643.6394, 1212.6981, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2707.423, 1202.8646, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2820.8723, 1220.0563, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2801.504, 1391.3962, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2649.4307, 1572.3315, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2651.3765, 1522.2765, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2712.435, 1423.1569, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2833.2952, 1433.4404, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2880.3171, 1315.8512, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2719.2917, 1301.2247, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2632.2427, 769.48535, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2567.5435, 764.2624, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2408.682, 769.8698, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2425.7576, 687.628, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2408.8914, 439.86157, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2502.1094, 389.2109, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2630.5286, 416.8235, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2519.5112, 500.16763, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2425.454, 470.11258, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2632.162, 338.21124, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2836.955, 323.62143, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2938.837, 468.22537, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2763.851, 448.97772, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2721.157, 432.13248, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2799.053, 576.72437, 30));
		AddSpawnPoint("Spawner6.f_katyn_14", "f_katyn_14", Spot(-2697.6282, 683.93384, 30));

		// Honey_Bee Spawn Points
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-2148.0042, -1208.8018, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-1855.8665, -1380.2838, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-1790.4982, -971.59247, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-1426.2793, -1186.4127, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-1147.383, -1129.8127, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-2480.0127, -1239.1793, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-2911.7754, -1414.1617, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-2929.47, -1208.6777, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-346.38333, 76.68518, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-305.50327, 485.68085, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-871.7664, 292.92285, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-1293.5555, 647.4944, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-1274.4298, 1025.9171, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-1548.954, 672.06104, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-1837.6719, 1089.3644, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-2543.6306, 416.85626, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-673.2294, -938.8631, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-484.4041, -563.84454, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3213.975, 1429.056, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3370.6704, 1236.3628, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3261.58, 1322.5096, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3320.5513, 1440.0526, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3450.7854, 1356.5544, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3436.0352, 1502.1256, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3240.6106, 1621.9126, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3437.8528, 1676.8411, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3414.974, 1635.8263, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3371.6597, 1551.9774, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3544.3232, 1574.6277, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3535.1597, 1506.8124, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3587.078, 1436.6309, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3627.3757, 1379.0371, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3670.0684, 1447.94, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3733.7834, 1235.8634, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3721.051, 1155.6788, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3631.8396, 1239.4149, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3534.308, 1210.3552, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3480.789, 1244.7715, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3466.1252, 1148.3706, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3823.891, 1288.137, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3700.4624, 1335.8723, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-327.70447, -520.1076, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-366.72375, -580.7695, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-415.27557, -636.9001, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-662.09247, -571.91425, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-741.3704, -556.2278, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-570.4682, -375.9221, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-628.63416, -313.89243, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-503.37988, -833.0919, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-478.6996, -840.6407, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-541.3313, -809.5708, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-1111.8693, -1150.6221, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-1119.6948, -1202.7941, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-1173.49, -1195.1255, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-1367.3201, -1162.3698, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-1460.1627, -1185.6655, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-1511.4647, -1157.5681, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-1805.5928, -1293.5664, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-2015.0829, -1130.7002, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-1937.1543, -1036.421, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-1821.4148, -919.916, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-1702.3773, -870.66656, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-1609.2087, -916.06836, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-1631.4167, -1113.8142, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-1689.6271, -1196.0137, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-1784.3627, -1337.0786, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-1722.6727, -1073.9161, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-1981.4065, -1230.5232, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-2132.371, -1276.2218, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-1993.7158, -1015.2271, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-1887.3584, -914.56476, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-2268.5356, -1223.3195, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-2418.1243, -1218.9054, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-2468.5708, -1180.0436, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-2883.3923, -1470.679, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-2854.0095, -1204.4948, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-2882.4417, -1269.3966, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-2839.7263, -1305.0121, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-2925.9463, -1368.0901, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3072.7664, -1417.3881, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3134.8894, -1468.9774, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3033.84, -1228.727, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3022.8745, -1171.79, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3018.3652, -1120.2306, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-2831.9265, -1450.3356, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-2834.0957, -1522.4844, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-3013.7646, -1567.8, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-2807.3755, -1436.1089, 30));
		AddSpawnPoint("Spawner7.f_katyn_14", "f_katyn_14", Spot(-2750.1357, -1436.4644, 30));

	}
}
