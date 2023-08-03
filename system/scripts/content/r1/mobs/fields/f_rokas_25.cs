//--- Melia Script -----------------------------------------------------------
// Ramstis Ridge Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_rokas_25'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FRokas25MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_rokas_25.Id1", MonsterId.Zinute, min: 15, max: 20);
		AddSpawner("f_rokas_25.Id2", MonsterId.Zinute, min: 30, max: 40);
		AddSpawner("f_rokas_25.Id3", MonsterId.Chupacabra_Desert, min: 12, max: 15);
		AddSpawner("f_rokas_25.Id4", MonsterId.Rootcrystal_05, min: 10, max: 13, respawn: TimeSpan.FromMilliseconds(5000));
		AddSpawner("f_rokas_25.Id5", MonsterId.Chupacabra_Desert, min: 19, max: 25);
		AddSpawner("f_rokas_25.Id6", MonsterId.Chupacabra_Desert, min: 30, max: 40);
		AddSpawner("f_rokas_25.Id7", MonsterId.Lichenclops, min: 30, max: 40);

		// Monster Spawn Points -----------------------------

		// 'Zinute' GenType 40 Spawn Points
		AddSpawnPoint("f_rokas_25.Id1", "f_rokas_25", Rectangle(-1184, 614, 9999));

		// 'Zinute' GenType 41 Spawn Points
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(-2058, -865, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(-1033, 488, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(-2347, -713, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(-1816, -1222, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(-2163, -1204, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(-672, 637, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1968, -522, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2032, -19, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2295, -373, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(-2236, -1012, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(-1979, -1195, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(-1830, -860, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(-2218, -636, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(-1854, -1034, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(-2044, -1050, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(-2518, -688, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(-2346, -875, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2418, -583, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2471, -499, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2553, -400, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2528, -323, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2516, -204, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2498, -105, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2463, -42, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2375, -154, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2346, -246, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2309, -313, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2370, -379, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2452, -428, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2467, -352, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2492, -266, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2432, -214, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2350, -579, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2287, -470, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2180, -434, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2214, -501, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2199, -569, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2242, -641, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2111, -650, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2038, -543, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2108, -541, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2098, -433, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2013, -598, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1946, -583, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1854, -609, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1866, -664, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1780, -652, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1721, -600, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1682, -618, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1723, -456, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1852, -552, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1780, -482, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1885, -463, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1825, -398, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1684, -340, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1586, -379, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1602, -441, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1592, -313, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1702, -246, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1759, -207, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1669, -280, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1763, -118, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1802, -24, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1735, -10, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1818, -88, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1849, -14, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1888, 41, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1971, 11, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1901, -14, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2033, 94, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2065, 39, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2135, -1, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2160, -63, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2226, -100, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2145, -105, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2079, -7, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2113, -140, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2203, -149, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2204, -212, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2153, -184, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2182, -271, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(2002, -321, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1991, -266, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1928, -312, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1917, -194, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1942, -115, 25));
		AddSpawnPoint("f_rokas_25.Id2", "f_rokas_25", Rectangle(1881, -63, 25));

		// 'Chupacabra_Desert' GenType 43 Spawn Points
		AddSpawnPoint("f_rokas_25.Id3", "f_rokas_25", Rectangle(-2235, -724, 25));
		AddSpawnPoint("f_rokas_25.Id3", "f_rokas_25", Rectangle(1749, -410, 25));
		AddSpawnPoint("f_rokas_25.Id3", "f_rokas_25", Rectangle(2335, -112, 25));
		AddSpawnPoint("f_rokas_25.Id3", "f_rokas_25", Rectangle(2364, -504, 25));
		AddSpawnPoint("f_rokas_25.Id3", "f_rokas_25", Rectangle(-2077, -1125, 25));
		AddSpawnPoint("f_rokas_25.Id3", "f_rokas_25", Rectangle(810, 1060, 25));
		AddSpawnPoint("f_rokas_25.Id3", "f_rokas_25", Rectangle(1934, -41, 25));
		AddSpawnPoint("f_rokas_25.Id3", "f_rokas_25", Rectangle(2031, -502, 25));
		AddSpawnPoint("f_rokas_25.Id3", "f_rokas_25", Rectangle(-2101, 320, 25));
		AddSpawnPoint("f_rokas_25.Id3", "f_rokas_25", Rectangle(-2362, -924, 25));
		AddSpawnPoint("f_rokas_25.Id3", "f_rokas_25", Rectangle(-1945, -1045, 25));
		AddSpawnPoint("f_rokas_25.Id3", "f_rokas_25", Rectangle(-2064, -739, 25));
		AddSpawnPoint("f_rokas_25.Id3", "f_rokas_25", Rectangle(-2464, -701, 25));
		AddSpawnPoint("f_rokas_25.Id3", "f_rokas_25", Rectangle(-1810, -855, 25));
		AddSpawnPoint("f_rokas_25.Id3", "f_rokas_25", Rectangle(-1835, -1271, 25));
		AddSpawnPoint("f_rokas_25.Id3", "f_rokas_25", Rectangle(-1722, -1173, 25));
		AddSpawnPoint("f_rokas_25.Id3", "f_rokas_25", Rectangle(-1701, -931, 25));
		AddSpawnPoint("f_rokas_25.Id3", "f_rokas_25", Rectangle(-2146, -921, 25));
		AddSpawnPoint("f_rokas_25.Id3", "f_rokas_25", Rectangle(-2032, -838, 25));
		AddSpawnPoint("f_rokas_25.Id3", "f_rokas_25", Rectangle(-1996, 422, 25));
		AddSpawnPoint("f_rokas_25.Id3", "f_rokas_25", Rectangle(-2296, 402, 25));

		// 'Rootcrystal_05' GenType 600 Spawn Points
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(-1994, -546, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(-1054, 502, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(925, -111, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(2194, -429, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(-2010, -1146, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(-1798, -904, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(-2357, -827, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(-2348, -541, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(-2200, 326, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(-2161, 499, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(-1987, 292, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(-1851, 937, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(-1902, 822, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(-2097, 724, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(-1680, 920, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(-1491, 670, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(-793, 544, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(-1017, 810, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(-716, 230, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(-939, 293, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(-11, 571, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(148, 666, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(306, 478, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(367, 594, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(454, 401, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(888, 1131, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(653, 1063, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(1182, -285, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(1264, -34, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(1735, -33, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(1839, -611, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(2042, 22, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(2472, -586, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(2399, -104, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(2109, 604, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(2307, 474, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(1989, 279, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(2847, -97, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(3128, -171, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(2927, -435, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(2179, -819, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(2728, -905, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(2352, -1139, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(1423, -933, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(1686, -849, 150));
		AddSpawnPoint("f_rokas_25.Id4", "f_rokas_25", Rectangle(1688, -1246, 150));

		// 'Chupacabra_Desert' GenType 657 Spawn Points
		AddSpawnPoint("f_rokas_25.Id5", "f_rokas_25", Rectangle(-2047, 704, 9999));

		// 'Chupacabra_Desert' GenType 670 Spawn Points
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1078, -178, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1853, -159, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2243, -444, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1604, -290, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1069, -308, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(916, -76, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1155, -4, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-953, 462, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-960, 657, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-681, 714, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-834, 560, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-636, 427, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-1224, 494, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-1109, 635, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-553, 545, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-941, 860, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2048, -294, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2639, -1115, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2614, -1189, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2685, -1146, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2722, -1073, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2699, -983, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2700, -897, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2632, -866, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2563, -846, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2574, -886, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2680, -1029, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2393, -220, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2384, -1151, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2338, -892, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2389, -825, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2411, -945, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2294, -929, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2244, -893, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2515, -839, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2266, -977, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2306, -878, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2341, -1048, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2449, -981, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2393, -508, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2597, -910, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2667, -825, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2737, -920, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2373, -306, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2726, -1038, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1831, -1189, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2268, -314, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1744, -1155, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2155, -488, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1640, -1245, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1535, -1199, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1452, -1114, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1442, -996, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1556, -873, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1626, -848, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1702, -861, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1677, -799, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1786, -863, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1753, -823, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1695, -539, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1834, -1008, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1879, -1032, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1787, -939, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1835, -1073, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1773, -1026, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1815, -970, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1730, -899, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1799, -1086, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1798, -1151, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1971, -539, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1645, -1196, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1692, -1268, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(2042, -41, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1497, -1174, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1560, -915, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1509, -854, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(811, 1100, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1001, 1085, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(964, 1175, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(944, 1055, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(874, 1040, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(933, 1344, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(927, 1121, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(1082, 1181, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(778, 1169, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(725, 1008, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(666, 1009, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(737, 1105, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(849, 1167, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(881, 1233, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(865, 1100, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-2276, 362, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-2257, 514, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-2213, 403, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-2048, 208, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-2231, 377, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-2136, 163, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-2241, 292, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-1956, 291, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-2135, 241, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-2056, 388, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-2114, 435, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-2040, 442, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-1913, 490, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-1856, 401, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-1894, 369, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-1945, 417, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-1905, 429, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-1971, 492, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-2068, 311, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-1993, 686, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-1885, 723, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-1846, 777, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-1770, 760, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-1795, 832, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-1867, 860, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-1937, 881, 25));
		AddSpawnPoint("f_rokas_25.Id6", "f_rokas_25", Rectangle(-1825, 907, 25));

		// 'Lichenclops' GenType 671 Spawn Points
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-957, 599, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-764, 396, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-743, 630, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(1021, -164, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(1153, 10, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(1783, -326, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2128, -508, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2421, -292, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2200, -49, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2828, -193, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2941, -424, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(1745, -1093, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(1446, -949, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2478, -1179, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2640, -938, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2460, -877, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-1081, 479, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-1246, 676, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(1152, -356, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(1996, -173, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(1685, -540, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2502, -603, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(3056, -268, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(1568, -1166, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(3111, -449, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(3158, -375, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(3088, -341, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(3125, -207, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(3132, -123, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(3053, -118, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2969, -91, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2873, -112, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2803, -66, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2769, -159, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2814, -127, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2778, -233, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2782, -296, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2792, -352, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2800, -413, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2822, -468, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2876, -416, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2915, -484, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(3032, -523, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2998, -455, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(3094, -494, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(3045, -415, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(3099, -390, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(3043, -185, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(3102, -165, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(1965, -455, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2136, -408, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2225, -386, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2315, -426, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2376, -459, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2375, -314, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2296, -242, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2327, -193, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2420, -100, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2375, -40, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2295, -7, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2224, 10, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2145, 68, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2053, -59, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2111, -56, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2105, -184, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2560, -263, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2574, -358, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2430, -364, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2423, -541, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2451, -651, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2370, -617, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2187, -612, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2078, -584, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(2073, -473, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(1220, -258, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(1262, -150, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(1223, -35, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(1069, 0, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(953, -40, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(883, 1, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(947, 24, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(1018, -64, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(839, -104, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(924, -151, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(915, -210, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(928, -268, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(976, -327, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(1076, -373, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(1024, -321, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(1110, -331, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(1205, -391, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(1193, -308, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(1268, -231, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(1250, -106, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-576, 639, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-619, 684, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-533, 488, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-616, 539, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-669, 445, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-701, 370, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-800, 440, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-893, 316, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-934, 229, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-983, 321, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-882, 261, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-983, 432, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-1106, 537, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-1044, 628, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-1015, 541, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-979, 721, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-875, 730, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-872, 686, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-883, 544, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-872, 647, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-896, 464, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-919, 378, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-813, 499, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-770, 604, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-787, 727, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-631, 601, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-594, 449, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-732, 444, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-665, 512, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-735, 253, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-642, 288, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-527, 407, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-624, 395, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-1053, 412, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-1103, 378, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-2234, -1102, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-2144, -1050, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-2133, -988, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-2034, -959, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-1973, -983, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-1887, -927, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-1776, -926, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-1792, -1033, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-1947, -1088, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-2111, -1266, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-2286, -1121, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-2400, -1004, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-2506, -874, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-2437, -783, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-2322, -818, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-2132, -653, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-2116, -523, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-2246, -914, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-1933, -571, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-1870, -650, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-1898, -769, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-1860, -572, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-2022, -587, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-2180, -459, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-2095, -423, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-2142, -734, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-2166, -547, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-1887, -836, 30));
		AddSpawnPoint("f_rokas_25.Id7", "f_rokas_25", Rectangle(-1926, -642, 30));
	}
}
