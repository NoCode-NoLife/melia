//--- Melia Script -----------------------------------------------------------
// Kule Peak Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_katyn_18'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FKatyn18MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_katyn_18", MonsterId.Zibu_Maize_Red, Properties("MHP", 536103, "MINPATK", 7395, "MAXPATK", 8990, "MINMATK", 7395, "MAXMATK", 8990, "DEF", 95790, "MDEF", 95790));
		AddPropertyOverrides("f_katyn_18", MonsterId.Siaulav_Red, Properties("MHP", 538326, "MINPATK", 7423, "MAXPATK", 9025, "MINMATK", 7423, "MAXMATK", 9025, "DEF", 96890, "MDEF", 96890));
		AddPropertyOverrides("f_katyn_18", MonsterId.Siaulav_Bow_Black, Properties("MHP", 540677, "MINPATK", 7454, "MAXPATK", 9062, "MINMATK", 7454, "MAXMATK", 9062, "DEF", 98052, "MDEF", 98052));
		AddPropertyOverrides("f_katyn_18", MonsterId.Siaulav_Mage_Black, Properties("MHP", 543149, "MINPATK", 7485, "MAXPATK", 9101, "MINMATK", 7485, "MAXMATK", 9101, "DEF", 99275, "MDEF", 99275));

		// Monster Spawners ---------------------------------

		AddSpawner("f_katyn_18.Id1", MonsterId.Zibu_Maize_Red, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_katyn_18.Id2", MonsterId.Siaulav_Red, 64, 85, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_katyn_18.Id3", MonsterId.Siaulav_Bow_Black, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_katyn_18.Id4", MonsterId.Siaulav_Mage_Black, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_katyn_18.Id5", MonsterId.Siaulav_Bow_Black, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_katyn_18.Id6", MonsterId.Rootcrystal_01, 16, 21, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Zibu_Maize_Red' GenType 21 Spawn Points
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(181, -890, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(243, -350, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(537, -754, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(459, -1082, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(688, -1196, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(875, -810, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(567, 385, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(546, 932, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(1054, 1303, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(1566, 1292, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(2036, 1332, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(2223, 914, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(2101, 864, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(2146, 465, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(2161, 601, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(2121, 138, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(1918, -56, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(1741, -400, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(2013, -482, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(2114, -135, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(1950, -264, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(1503, -111, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(1493, 105, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(1878, 85, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(1776, -1249, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(1624, -1240, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(1449, -1272, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(1260, -1330, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(1079, -1354, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(1397, -2050, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(1296, -2007, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(1324, -2212, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(1158, -2248, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(1276, -2347, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(1209, -2118, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(1065, -2129, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(1094, -2296, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(1017, -1344, 40));
		AddSpawnPoint("f_katyn_18.Id1", "f_katyn_18", Rectangle(915, -1415, 40));

		// 'Siaulav_Red' GenType 22 Spawn Points
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(893, -2607, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(876, -2463, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(800, -2334, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(820, -1886, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(783, -1762, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(793, -1333, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(944, -1366, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1692, -1339, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1521, -2464, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1915, -2075, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1649, -2046, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2002, -1846, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2394, -1381, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2460, -960, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2301, -1028, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2248, -779, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2205, -560, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2000, -579, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2129, -349, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1775, -336, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1845, 51, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2014, 45, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(701, -2216, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(610, -2166, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2487, -1992, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2324, -1997, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2382, -2078, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2195, -2118, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2045, -2149, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2111, -2042, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2323, -1834, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2134, -1818, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2024, -1967, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2225, -1727, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2304, -1650, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2452, -1739, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2459, -1787, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2367, -922, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2387, -964, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2386, -1019, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2264, -796, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2303, -735, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2062, -610, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1838, -512, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1871, -123, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1983, -77, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2056, -252, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2140, -116, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1329, -145, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1614, 16, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1508, -400, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1353, -299, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1640, 156, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1694, 99, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1538, -133, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1521, -523, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1651, -328, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1361, -440, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1154, -207, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1123, 12, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1253, 43, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1416, 61, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1554, 98, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2181, 508, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2205, 559, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2226, 621, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2098, 908, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2087, 1112, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2152, 1022, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(2215, 956, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(976, 1351, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1130, 1410, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(923, 1484, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(937, 1260, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1061, 1152, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1398, 1259, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1262, 1183, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1241, 1336, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(787, 1453, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(636, 1213, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(729, 1323, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(838, 1265, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(838, 1386, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(757, 1189, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(723, 1166, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(583, 897, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(556, 879, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(483, -275, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(512, -391, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(507, -324, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(158, -464, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(126, -420, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(148, -331, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(224, -399, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(164, -562, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(51, -704, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(86, -756, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(352, -894, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(346, -806, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(403, -893, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(454, -909, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(427, -975, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(385, -1063, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(572, -1035, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(594, -1128, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(667, -1170, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(793, -1500, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(983, -1456, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1161, -1309, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(783, -1552, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(864, -1623, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(862, -1735, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(929, -1715, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(870, -1809, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(861, -2099, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(790, -2190, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(928, -2496, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1562, -2521, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1584, -2580, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1527, -2596, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1476, -2496, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1403, -2531, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1267, -2357, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1206, -2371, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1560, -1402, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1813, -1267, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1831, -1153, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1726, -1205, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1335, -1273, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1436, -1386, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1192, -1390, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(1090, -1408, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(543, -467, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(664, -509, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(582, -598, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(721, -685, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(772, -728, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(904, -773, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(964, -791, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(892, -576, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(362, -2175, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(390, -2279, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(339, -2326, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(230, -2396, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(271, -2148, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(380, -2007, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(403, -1956, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-407, -2445, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-344, -2384, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-469, -2468, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-577, -2418, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-494, -2398, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-632, -2475, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-776, -2464, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-837, -2489, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-914, -2447, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-1131, -1900, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-1232, -1866, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-1112, -1797, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-1217, -1745, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-1298, -1745, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-1320, -1668, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-1203, -1657, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-864, -1694, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-891, -1626, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-1046, -1656, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-1056, -1166, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-1279, -1172, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-1067, -914, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-1408, -1128, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-1466, -684, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-1347, -777, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-1349, -873, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-918, -879, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-1088, -652, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-1709, -289, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-1695, -245, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-1706, -211, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-1681, 118, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-1751, 160, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-1717, 227, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-1820, 263, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-1840, 411, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-1792, 438, 40));
		AddSpawnPoint("f_katyn_18.Id2", "f_katyn_18", Rectangle(-1689, 331, 40));

		// 'Siaulav_Bow_Black' GenType 23 Spawn Points
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(-495, -2445, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(-646, -2521, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(-1015, -2366, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(-1132, -2258, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(-997, -1660, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(-1285, -1633, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(-1275, -1347, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(-1381, -1193, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(-1423, -766, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(-979, -742, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(-1078, -431, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(-1148, -561, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(-1035, -165, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(-1735, -257, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(-1549, -702, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(-1866, 258, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(-1688, 78, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(-1805, 651, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(-982, -1070, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(-1120, -1138, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(-1264, -1488, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(-1238, -1982, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(-975, -2477, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(-328, -2481, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(-37, -2298, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(-24, -2447, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(64, -2519, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(193, -2298, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(128, -2337, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(273, -2422, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(101, -2042, 40));
		AddSpawnPoint("f_katyn_18.Id3", "f_katyn_18", Rectangle(195, -1960, 40));

		// 'Siaulav_Mage_Black' GenType 24 Spawn Points
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(1761, -1203, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(1576, -1481, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(1510, -1187, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(1295, -1386, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(1059, -1263, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(848, -1477, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(688, -978, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(365, -334, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(98, -590, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(394, -646, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(627, -515, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(1416, -260, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(1345, -104, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(1540, 209, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(1694, -163, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(1791, -531, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(2066, -246, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(1970, 150, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(1687, -413, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(1305, -129, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(1167, 23, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(-1135, -1627, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(-1277, -1818, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(-982, -1628, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(-1116, -1710, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(-1367, -1361, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(-1237, -917, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(-1428, -1035, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(-1437, -766, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(-1102, -841, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(-1018, -411, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(-1065, -580, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(-1059, -148, 40));
		AddSpawnPoint("f_katyn_18.Id4", "f_katyn_18", Rectangle(-1237, -1107, 40));

		// 'Siaulav_Bow_Black' GenType 25 Spawn Points
		AddSpawnPoint("f_katyn_18.Id5", "f_katyn_18", Rectangle(1510, -263, 9999));

		// 'Rootcrystal_01' GenType 26 Spawn Points
		AddSpawnPoint("f_katyn_18.Id6", "f_katyn_18", Rectangle(716, 1235, 100));
		AddSpawnPoint("f_katyn_18.Id6", "f_katyn_18", Rectangle(931, 1295, 100));
		AddSpawnPoint("f_katyn_18.Id6", "f_katyn_18", Rectangle(2161, 1061, 100));
		AddSpawnPoint("f_katyn_18.Id6", "f_katyn_18", Rectangle(2053, -362, 100));
		AddSpawnPoint("f_katyn_18.Id6", "f_katyn_18", Rectangle(1273, -383, 100));
		AddSpawnPoint("f_katyn_18.Id6", "f_katyn_18", Rectangle(1675, 18, 100));
		AddSpawnPoint("f_katyn_18.Id6", "f_katyn_18", Rectangle(886, -685, 100));
		AddSpawnPoint("f_katyn_18.Id6", "f_katyn_18", Rectangle(515, -521, 100));
		AddSpawnPoint("f_katyn_18.Id6", "f_katyn_18", Rectangle(533, 278, 100));
		AddSpawnPoint("f_katyn_18.Id6", "f_katyn_18", Rectangle(733, -1430, 100));
		AddSpawnPoint("f_katyn_18.Id6", "f_katyn_18", Rectangle(1597, -1273, 100));
		AddSpawnPoint("f_katyn_18.Id6", "f_katyn_18", Rectangle(2425, -1110, 100));
		AddSpawnPoint("f_katyn_18.Id6", "f_katyn_18", Rectangle(2168, -2029, 100));
		AddSpawnPoint("f_katyn_18.Id6", "f_katyn_18", Rectangle(1242, -2209, 100));
		AddSpawnPoint("f_katyn_18.Id6", "f_katyn_18", Rectangle(89, -2305, 100));
		AddSpawnPoint("f_katyn_18.Id6", "f_katyn_18", Rectangle(-424, -2468, 100));
		AddSpawnPoint("f_katyn_18.Id6", "f_katyn_18", Rectangle(-978, -2415, 100));
		AddSpawnPoint("f_katyn_18.Id6", "f_katyn_18", Rectangle(-1056, -1742, 100));
		AddSpawnPoint("f_katyn_18.Id6", "f_katyn_18", Rectangle(-1332, -1245, 100));
		AddSpawnPoint("f_katyn_18.Id6", "f_katyn_18", Rectangle(-1017, -883, 100));
		AddSpawnPoint("f_katyn_18.Id6", "f_katyn_18", Rectangle(-1765, 222, 100));
	}
}
