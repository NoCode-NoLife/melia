//--- Melia Script -----------------------------------------------------------
// f_rokas_25
//
//--- Description -----------------------------------------------------------
// Sets up the f_rokas_25 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FRokas25MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("Spawner1.f_rokas_25", MonsterId.Rootcrystal_05, 13, TimeSpan.FromMilliseconds(5000));
		AddSpawner("Spawner2.f_rokas_25", MonsterId.Chupacabra_Desert, 15, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner3.f_rokas_25", MonsterId.Chupacabra_Desert, 25, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner4.f_rokas_25", MonsterId.Zinute, 40, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner5.f_rokas_25", MonsterId.Zinute, 20, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner6.f_rokas_25", MonsterId.Chupacabra_Desert, 40, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner7.f_rokas_25", MonsterId.Lichenclops, 40, TimeSpan.FromMilliseconds(0));

		// Monster Spawn Points -----------------------------

		// Rootcrystal_05 Spawn Points
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(-1994, -546, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(-1054, 502, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(925, -111, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(2194, -429, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(-2010, -1146, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(-1798, -904, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(-2357, -827, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(-2348, -541, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(-2200, 326, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(-2161, 499, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(-1987, 292, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(-1851, 937, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(-1902, 822, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(-2097, 724, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(-1680, 920, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(-1491, 670, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(-793, 544, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(-1017, 810, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(-716, 230, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(-939, 293, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(-11.34, 571.03, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(148, 666, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(306, 478, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(367, 594, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(454, 401, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(888, 1131, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(653, 1063, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(1182, -285, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(1264, -34, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(1735, -33, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(1839, -611, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(2042, 22, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(2472, -586, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(2399, -104, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(2109, 604, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(2307, 474, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(1989, 279, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(2847, -97, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(3128, -171, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(2927, -435, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(2179, -819, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(2728, -905, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(2352, -1139, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(1423, -933, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(1686, -849, 150));
		AddSpawnPoint("Spawner1.f_rokas_25", "f_rokas_25", Spot(1688, -1246, 150));

		// Chupacabra_Desert Spawn Points
		AddSpawnPoint("Spawner2.f_rokas_25", "f_rokas_25", Spot(-2235.0293, -724.48395, 25));
		AddSpawnPoint("Spawner2.f_rokas_25", "f_rokas_25", Spot(1749.9844, -410.20123, 25));
		AddSpawnPoint("Spawner2.f_rokas_25", "f_rokas_25", Spot(2335.8667, -112.60266, 25));
		AddSpawnPoint("Spawner2.f_rokas_25", "f_rokas_25", Spot(2364.3818, -504.94196, 25));
		AddSpawnPoint("Spawner2.f_rokas_25", "f_rokas_25", Spot(-2077.09, -1125.0852, 25));
		AddSpawnPoint("Spawner2.f_rokas_25", "f_rokas_25", Spot(810.74115, 1060.7643, 25));
		AddSpawnPoint("Spawner2.f_rokas_25", "f_rokas_25", Spot(1934.0895, -41.803688, 25));
		AddSpawnPoint("Spawner2.f_rokas_25", "f_rokas_25", Spot(2031.7378, -502.48148, 25));
		AddSpawnPoint("Spawner2.f_rokas_25", "f_rokas_25", Spot(-2101.7725, 320.15802, 25));
		AddSpawnPoint("Spawner2.f_rokas_25", "f_rokas_25", Spot(-2362.2812, -924.4751, 25));
		AddSpawnPoint("Spawner2.f_rokas_25", "f_rokas_25", Spot(-1945.0334, -1045.6852, 25));
		AddSpawnPoint("Spawner2.f_rokas_25", "f_rokas_25", Spot(-2064.3484, -739.86017, 25));
		AddSpawnPoint("Spawner2.f_rokas_25", "f_rokas_25", Spot(-2464.3809, -701.3928, 25));
		AddSpawnPoint("Spawner2.f_rokas_25", "f_rokas_25", Spot(-1810.374, -855.09204, 25));
		AddSpawnPoint("Spawner2.f_rokas_25", "f_rokas_25", Spot(-1835.6423, -1271.5677, 25));
		AddSpawnPoint("Spawner2.f_rokas_25", "f_rokas_25", Spot(-1722.8336, -1173.5894, 25));
		AddSpawnPoint("Spawner2.f_rokas_25", "f_rokas_25", Spot(-1701.0286, -931.1043, 25));
		AddSpawnPoint("Spawner2.f_rokas_25", "f_rokas_25", Spot(-2146.088, -921.1177, 25));
		AddSpawnPoint("Spawner2.f_rokas_25", "f_rokas_25", Spot(-2032.3643, -838.75726, 25));
		AddSpawnPoint("Spawner2.f_rokas_25", "f_rokas_25", Spot(-1996.7454, 422.35834, 25));
		AddSpawnPoint("Spawner2.f_rokas_25", "f_rokas_25", Spot(-2296.8525, 402.31934, 25));
		AddSpawnPoint("Spawner3.f_rokas_25", "f_rokas_25", Spot(-2047.4963, 704.5645, 9999));

		// Zinute Spawn Points
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(-2058.42, -865.30145, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(-1033.8402, 488.6983, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(-2347.1775, -713.6448, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(-1816.8989, -1222.369, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(-2163.4653, -1204.3613, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(-672.14166, 637.27234, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1968.1079, -522.6002, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2032.8438, -19.887016, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2295.893, -373.37662, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(-2236.3533, -1012.4318, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(-1979.8689, -1195.1973, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(-1830.0535, -860.69556, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(-2218.2744, -636.2796, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(-1854.7017, -1034.6877, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(-2044.607, -1050.6765, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(-2518.2769, -688.48126, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(-2346.3767, -875.9086, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2418.7527, -583.5518, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2471.4697, -499.44522, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2553.5042, -400.8264, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2528.0354, -323.6279, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2516.12, -204.1948, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2498.236, -105.79523, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2463.0422, -42.50817, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2375.5105, -154.23468, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2346.2346, -246.3141, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2309.0955, -313.06628, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2370.2944, -379.15106, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2452.7568, -428.10992, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2467.3389, -352.7154, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2492.883, -266.28766, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2432.626, -214.9502, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2350.3916, -579.174, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2287.5627, -470.57678, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2180.1638, -434.79156, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2214.937, -501.64536, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2199.7312, -569.10974, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2242.9329, -641.80164, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2111.6472, -650.6738, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2038.7892, -543.49255, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2108.1387, -541.7686, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2098.2288, -433.3269, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2013.8826, -598.95435, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1946.6426, -583.3106, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1854.2878, -609.9929, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1866.7639, -664.8633, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1780.7142, -652.1101, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1721.6743, -600.0917, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1682.3805, -618.3241, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1723.1304, -456.79755, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1852.0928, -552.45685, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1780.44, -482.97488, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1885.3026, -463.5903, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1825.0999, -398.94327, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1684.4294, -340.37045, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1586.1555, -379.49844, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1602.1132, -441.3485, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1592.1702, -313.60046, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1702.1516, -246.47298, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1759.9612, -207.17625, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1669.9563, -280.01508, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1763.6694, -118.06253, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1802.3818, -24.825794, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1735.9048, -10.486366, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1818.4781, -88.00316, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1849.9056, -14.060276, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1888.2443, 41.134605, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1971.1637, 11.731583, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1901.4344, -14.54184, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2033.2716, 94.49477, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2065.6626, 39.00934, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2135.4124, -1.768544, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2160.795, -63.96661, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2226.8987, -100.313, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2145.944, -105.06806, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2079.4094, -7.343384, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2113.737, -140.68474, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2203.1804, -149.26396, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2204.1533, -212.31833, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2153.5352, -184.93611, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2182.3416, -271.5792, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(2002.2128, -321.5071, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1991.1106, -266.64484, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1928.9111, -312.8946, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1917.6982, -194.2616, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1942.4408, -115.9994, 25));
		AddSpawnPoint("Spawner4.f_rokas_25", "f_rokas_25", Spot(1881.2578, -63.46595, 25));
		AddSpawnPoint("Spawner5.f_rokas_25", "f_rokas_25", Spot(-1184.5322, 614.3639, 9999));

		// Chupacabra_Desert Spawn Points
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1078.5798, -178.20851, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1853.4153, -159.25082, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2243.249, -444.94693, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1604.7222, -290.89877, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1069.4257, -308.7183, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(916.31, -76.6968, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1155.9177, -4.547493, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-953.79956, 462.89136, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-960.4378, 657.3295, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-681.7899, 714.76733, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-834.408, 560.7337, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-636.9688, 427.30325, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-1224.9109, 494.30902, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-1109.4655, 635.1218, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-553.363, 545.04675, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-941.8628, 860.3941, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2048.4856, -294.68106, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2639.9524, -1115.3037, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2614.2844, -1189.3444, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2685.2732, -1146.8342, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2722.6555, -1073.5529, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2699.749, -983.35504, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2700.3784, -897.9739, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2632.4805, -866.6423, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2563.333, -846.9516, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2574.8308, -886.1659, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2680.5325, -1029.0984, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2393.4917, -220.69676, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2384.5898, -1151.8297, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2338.6453, -892.06934, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2389.092, -825.5369, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2411.0645, -945.3367, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2294.9348, -929.36633, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2244.2236, -893.40405, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2515.088, -839.8296, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2266.446, -977.53455, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2306.553, -878.9412, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2341.2332, -1048.0231, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2449.5493, -981.1763, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2393.4814, -508.29047, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2597.0247, -910.1352, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2667.0654, -825.76953, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2737.796, -920.7639, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2373.9375, -306.2457, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2726.5825, -1038.5836, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1831.1311, -1189.456, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2268.5083, -314.72882, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1744.5414, -1155.4326, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2155.5938, -488.73135, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1640.717, -1245.7959, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1535.7744, -1199.677, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1452.5004, -1114.914, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1442.5682, -996.1872, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1556.6573, -873.82404, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1626.9065, -848.86145, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1702.8995, -861.91644, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1677.08, -799.0166, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1786.038, -863.2746, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1753.6604, -823.04047, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1695.8335, -539.0791, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1834.6304, -1008.4464, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1879.7587, -1032.1802, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1787.1792, -939.1753, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1835.238, -1073.362, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1773.5099, -1026.5577, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1815.3417, -970.13965, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1730.5009, -899.4922, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1799.3093, -1086.0059, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1798.1414, -1151.791, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1971.2281, -539.0054, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1645.6367, -1196.2802, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1692.5663, -1268.0615, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(2042.4458, -41.91651, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1497.2769, -1174.7898, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1560.1833, -915.6609, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1509.9501, -854.8651, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(811.7057, 1100.082, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1001.0295, 1085.503, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(964.53467, 1175.1924, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(944.40485, 1055.3724, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(874.85425, 1040.443, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(933.9645, 1344.3983, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(927.3379, 1121.5488, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(1082.8601, 1181.9645, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(778.649, 1169.9608, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(725.56793, 1008.3336, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(666.9633, 1009.9402, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(737.8677, 1105.0298, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(849.3504, 1167.7916, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(881.35126, 1233.9297, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(865.65204, 1100.8677, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-2276.4448, 362.2159, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-2257.8394, 514.03564, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-2213.755, 403.5128, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-2048.995, 208.00421, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-2231.674, 377.1426, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-2136.5312, 163.4951, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-2241.2378, 292.69266, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-1956.6139, 291.79962, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-2135.7354, 241.91052, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-2056.5967, 388.2993, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-2114.783, 435.02292, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-2040.3291, 442.8707, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-1913.9718, 490.65833, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-1856.4797, 401.46637, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-1894.8894, 369.66956, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-1945.5686, 417.33475, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-1905.452, 429.41113, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-1971.8143, 492.4469, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-2068.1072, 311.2717, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-1993.1136, 686.5233, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-1885.3307, 723.9734, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-1846.3032, 777.7984, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-1770.9203, 760.4501, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-1795.0673, 832.65924, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-1867.2345, 860.53864, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-1937.556, 881.2819, 25));
		AddSpawnPoint("Spawner6.f_rokas_25", "f_rokas_25", Spot(-1825.3071, 907.5806, 25));

		// Lichenclops Spawn Points
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-957.1166, 599.8021, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-764.4185, 396.71576, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-743.96014, 630.49445, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(1021.1287, -164.46466, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(1153.629, 10.127258, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(1783.7683, -326.41632, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2128.8933, -508.0389, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2421.4565, -292.5136, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2200.9648, -49.541748, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2828.9502, -193.06427, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2941.0662, -424.13818, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(1745.0797, -1093.0797, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(1446.3937, -949.2509, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2478.7139, -1179.6846, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2640.4866, -938.6837, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2460.0342, -877.38025, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-1081.3634, 479.174, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-1246.677, 676.90027, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(1152.8036, -356.09897, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(1996.05, -173.75314, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(1685.4891, -540.87, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2502.8596, -603.5137, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(3056.726, -268.0704, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(1568.3329, -1166.4296, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(3111.7854, -449.82245, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(3158.1516, -375.06946, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(3088.214, -341.1986, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(3125.001, -207.89227, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(3132.9436, -123.9587, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(3053.9644, -118.17245, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2969.8198, -91.62458, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2873.5635, -112.75305, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2803.0444, -66.30466, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2769.5112, -159.31104, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2814.8425, -127.91297, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2778.7039, -233.36491, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2782.5562, -296.3011, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2792.4214, -352.4298, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2800.3904, -413.89368, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2822.3452, -468.6708, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2876.64, -416.47635, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2915.9543, -484.24924, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(3032.9028, -523.78, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2998.8179, -455.7148, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(3094.4023, -494.31662, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(3045.0994, -415.96567, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(3099.1628, -390.7571, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(3043.0532, -185.2183, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(3102.7766, -165.65576, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(1965.6744, -455.79395, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2136.6177, -408.09027, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2225.9626, -386.41174, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2315.5237, -426.03958, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2376.2034, -459.73132, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2375.8633, -314.5994, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2296.8384, -242.94379, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2327.6611, -193.05182, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2420.922, -100.05643, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2375.559, -40.140667, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2295.4336, -7.0608025, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2224.526, 10.658234, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2145.852, 68.54629, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2053.7346, -59.942062, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2111.0813, -56.653202, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2105.5952, -184.91743, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2560.531, -263.88574, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2574.6602, -358.8016, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2430.8027, -364.96387, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2423.533, -541.64087, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2451.4417, -651.7158, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2370.8083, -617.54114, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2187.5342, -612.9212, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2078.8193, -584.1338, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(2073.3208, -473.22385, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(1220.9764, -258.87637, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(1262.6614, -150.92703, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(1223.1337, -35.268005, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(1069.9208, -0.18651152, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(953.90515, -40.769386, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(883.9838, 1.5581932, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(947.5623, 24.371326, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(1018.586, -64.896355, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(839.0453, -104.40932, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(924.05176, -151.60954, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(915.8176, -210.99324, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(928.58685, -268.40396, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(976.7812, -327.21274, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(1076.6951, -373.0178, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(1024.5569, -321.57324, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(1110.088, -331.1214, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(1205.7292, -391.382, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(1193.3591, -308.148, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(1268.685, -231.71335, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(1250.2545, -106.13198, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-576.1906, 639.28687, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-619.301, 684.1486, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-533.3802, 488.8753, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-616.04486, 539.6852, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-669.18866, 445.55515, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-701.1426, 370.05234, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-800.1818, 440.62173, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-893.7103, 316.24493, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-934.8163, 229.44516, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-983.77515, 321.72336, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-882.0228, 261.13434, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-983.84894, 432.96927, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-1106.8544, 537.09204, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-1044.9856, 628.73, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-1015.2421, 541.6321, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-979.6939, 721.52136, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-875.56555, 730.1093, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-872.68085, 686.86676, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-883.3376, 544.0251, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-872.7951, 647.4552, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-896.57166, 464.46332, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-919.0222, 378.2826, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-813.98157, 499.92416, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-770.7142, 604.7515, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-787.26733, 727.8174, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-631.5008, 601.70386, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-594.79816, 449.90155, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-732.9395, 444.6948, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-665.1651, 512.9888, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-735.92084, 253.45895, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-642.6146, 288.32922, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-527.9601, 407.28052, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-624.80505, 395.02454, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-1053.5187, 412.045, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-1103.3281, 378.5879, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-2234.5168, -1102.5654, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-2144.407, -1050.0465, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-2133.0784, -988.7235, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-2034.2268, -959.02783, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-1973.301, -983.44836, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-1887.2673, -927.81824, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-1776.3738, -926.65607, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-1792.9515, -1033.5896, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-1947.4633, -1088.7606, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-2111.4253, -1266.7632, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-2286.5474, -1121.6324, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-2400.6318, -1004.3768, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-2506.556, -874.0303, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-2437.6248, -783.9608, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-2322.5261, -818.9894, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-2132.7227, -653.43634, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-2116.2234, -523.81335, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-2246.4548, -914.15, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-1933.2618, -571.1037, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-1870.8438, -650.7008, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-1898.0637, -769.1462, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-1860.4513, -572.30884, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-2022.1726, -587.31866, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-2180.2751, -459.55505, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-2095.2363, -423.953, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-2142.9448, -734.8623, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-2166.827, -547.7403, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-1887.8523, -836.0438, 30));
		AddSpawnPoint("Spawner7.f_rokas_25", "f_rokas_25", Spot(-1926.3533, -642.2527, 30));

	}
}
