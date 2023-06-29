//--- Melia Script -----------------------------------------------------------
// f_3cmlake_27_1
//
//--- Description -----------------------------------------------------------
// Sets up the f_3cmlake_27_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class F3Cmlake271MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_3cmlake_27_1", MonsterId.Amacalf, Properties("MHP", 670334, "MINPATK", 9121, "MAXPATK", 11112, "MINMATK", 9121, "MAXMATK", 11112, "DEF", 169929, "MDEF", 169929));
		AddPropertyOverrides("f_3cmlake_27_1", MonsterId.Amphibigola, Properties("MHP", 670640, "MINPATK", 9125, "MAXPATK", 11117, "MINMATK", 9125, "MAXMATK", 11117, "DEF", 170147, "MDEF", 170147));

		// Monster Spawners --------------------------------

		AddSpawner("Spawner1.f_3cmlake_27_1", MonsterId.Amacalf, 117, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner2.f_3cmlake_27_1", MonsterId.Amphibigola, 122, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner3.f_3cmlake_27_1", MonsterId.Rootcrystal_02, 20, TimeSpan.FromMilliseconds(20000));

		// Monster Spawn Points -----------------------------

		// Amacalf Spawn Points
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1719.5702, 399.77542, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1704.2559, 569.70636, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1775.6149, 206.37741, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1859.6849, 114.37962, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1938.4827, 216.56029, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1951.0146, 348.61914, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1833.0852, 370.5721, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1727.1526, 500.07388, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1603.2437, 537.53265, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1831.1902, 499.75583, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(9.734798, 508.98114, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(43.03676, 262.64282, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(18.064507, 401.62622, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-48.66594, 126.38789, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-144.70253, -23.694595, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-264.82523, -288.0027, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(20.419222, -378.614, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(158.26398, -300.96585, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(278.94244, -312.86328, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(322.17773, -180.60478, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(189.98505, -197.76122, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(328.48618, -35.175392, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(153.25276, -40.92962, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(237.33026, -102.99208, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1.0550232, -26.627502, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-77.93553, -276.69357, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-950.95667, 444.21213, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-870.6388, 342.42474, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-672.6639, 369.07434, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-572.134, 364.13226, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-639.2543, 473.8781, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-740.3427, 471.64053, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-793.3015, 348.41617, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-848.541, 487.76254, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1591.5671, 628.3775, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1689.302, 584.77954, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1423.0673, 566.25073, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1310.9655, 647.34076, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1617.4795, 755.0258, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1517.1451, 539.10876, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-742.4224, 1137.9252, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-424.35138, 691.79456, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1642.3148, 343.8749, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1686.35, 703.544, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-776.33813, 786.0829, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-304.29895, 780.95135, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1519.0756, 767.8833, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1417.1427, 664.73303, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1615.8256, 441.697, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1106.1538, -844.8777, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1056.9846, -694.4309, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1194.9081, -697.37335, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1203.3649, -838.9795, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1397.3529, 736.55975, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1509.1942, 693.22485, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-742.1893, 845.67346, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-691.29254, 1104.6473, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(163.45363, -436.8011, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-91.85952, -180.45721, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1663.2197, 255.88603, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-758.52423, 608.1961, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-592.9475, 571.0265, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-703.6879, 669.8081, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(564.4114, -79.63162, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-184.5041, -218.07188, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-195.31859, -357.52103, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(25.826721, -244.64986, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(460.3375, -122.97398, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-25.288368, 733.6261, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-92.77323, 835.2002, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(29.974968, 803.99115, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-7.7173767, 923.2507, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-213.32623, 1441.5477, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-81.90593, 1367.4862, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-302.85516, 1267.9542, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-175.49438, 1293.7538, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-359.82767, 1435.9973, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-479.29147, 1244.571, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-289.46976, 1533.9044, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-119.33765, 1508.4819, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-46.533592, 1216.0549, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-183.68887, 1149.5013, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(979.9653, 217.06705, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1053.1815, 312.85938, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(975.6706, 315.41782, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1031.3479, 416.57697, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(957.69495, 490.86145, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(898.11597, 412.58466, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(864.35895, 551.13385, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(739.05286, 494.32028, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(639.5935, 399.84796, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(636.9383, 494.82312, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(636.5484, 275.31006, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(722.1614, 176.9536, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(759.77423, 92.79207, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(872.6605, 146.39494, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(872.7515, 648.157, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(745.1531, 592.84766, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(997.6872, -842.0513, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1048.0846, -788.29333, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(897.9009, 745.2098, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(839.16595, 835.47986, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1819.0829, 595.2217, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1615.1138, 665.4568, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1759.4808, 678.39294, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1913.5173, 603.164, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1963.9635, 479.0797, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1867.716, 255.55089, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1995.623, 74.20766, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(784.03674, 343.83496, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(550.4396, 381.90305, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1066.5316, 531.46344, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-389.502, 1315.108, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-261.94275, 1363.1934, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-224.69121, 1596.2201, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-151.84137, 1219.3319, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-322.3728, 1108.4473, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-102.61114, 1080.1262, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-767.55286, 425.95416, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-708.41974, 284.24835, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1659.7938, 610.6872, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1732.3483, 647.5879, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1468.5928, 438.7635, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1414.9807, 492.6343, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1510.1694, 623.4348, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1324.931, 808.71893, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1516.9727, 842.16046, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-136.22992, -332.04123, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-233.97092, -443.0754, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-406.21655, -294.23004, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(97.2616, -345.4494, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(91.16225, -82.26412, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(232.6288, 59.696903, 20));
		AddSpawnPoint("Spawner1.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(337.68262, -402.2838, 20));

		// Amphibigola Spawn Points
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1372.7128, -649.0366, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1364.7927, -757.65375, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1484.8239, -749.64984, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1496.5181, -659.42474, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1593.6477, -580.93677, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1754.1912, -669.169, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1718.8892, -507.78802, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1563.6844, -482.3048, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1071.5413, -1004.1232, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1089.5156, -1118.5443, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1233.8679, -1144.2865, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1213.8997, -1025.0773, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1500.0428, -976.06854, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1443.7422, -1085.6344, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1566.5305, -1114.7817, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1703.359, -877.45917, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1567.3717, -861.9969, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1434.3091, -538.0443, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1652.5927, -721.0809, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1590.7662, -951.97327, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(679.78876, -977.52673, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(597.3218, -1056.408, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(560.2796, -915.1763, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(630.023, -807.9733, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(291.33813, -771.9824, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(275.91425, -901.854, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(359.95547, -844.50793, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(453.5504, -933.3046, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(496.7547, -770.59094, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-11.765558, -921.6348, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(39.558975, -1052.8595, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(184.10645, -1112.4868, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(122.3398, -985.6411, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(127.15952, -876.9718, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(293.9113, -1064.5077, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(409.1033, -1040.3434, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(463.24307, -1148.8711, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-846.1368, -1198.842, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-730.4917, -1262.1797, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-703.80286, -1160.7041, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-929.5813, -1022.0512, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1527.222, -590.66144, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-770.21246, -1020.5019, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-664.9644, -900.0489, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-829.56116, -924.25055, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-494.48724, -891.68823, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-490.74057, -1037.4353, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-643.28455, -1026.5817, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-570.8532, -1180.1527, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-971.42786, -510.478, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1027.705, -646.6016, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1065.9675, -514.3328, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-944.17017, -257.75278, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1044.2277, -353.41632, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-924.27026, -383.74734, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-979.424, -172.9292, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-896.7465, -479.06, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-852.6085, -660.0028, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-752.7445, -567.0014, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-781.7251, -426.02463, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-966.1439, -595.0882, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-870.8523, -334.68726, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-666.0744, 1566.9738, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-710.7591, 1489.0304, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-628.1973, 1490.012, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(702.9334, 308.52185, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(110.76456, 38.584892, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(117.20144, -204.07721, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(986.88513, 1047.6605, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(3.6409302, -116.38219, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(886.6733, 309.72052, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(821.3288, 230.96921, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(892.50543, 956.0581, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(18.137672, 52.31346, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(818.53687, 1123.1589, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(712.0632, 1171.0297, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(765.5511, 1016.8862, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(883.42804, 1071.2567, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(850.24963, 1203.2217, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(962.09326, 1164.2256, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1076.583, 1096.1378, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1811.1843, -573.16205, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1883.8579, -485.88022, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1833.409, -346.8933, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1720.2522, -332.22784, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1801.4209, -430.75955, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1721.0983, -465.52386, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1723.5281, -525.9946, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1646.6593, -587.579, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(130.82883, -1109.2878, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(210.16214, -1181.9517, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(308.7637, -1164.3872, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(235.94841, -1007.7943, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(195.48125, -793.79895, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(341.93903, -976.8581, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(402.3239, -749.7225, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(500.3357, -839.33923, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(801.5113, -891.1059, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(888.56866, -784.43677, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-269.17856, -1102.6134, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-357.72372, -1046.5566, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-839.8532, -1114.0979, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-854.33374, -1031.0417, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-655.3133, -1096.0923, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-566.6666, -929.4085, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-824.9479, -845.5398, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-889.7756, -783.16345, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1346.8096, -847.114, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1320.2207, -968.0002, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1374.9971, -1186.0664, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1535.871, -1176.9384, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1726.6932, -1201.7406, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1713.6558, -1055.7992, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1598.6533, -771.66565, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1354.5253, -547.97034, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1129.3473, -537.17725, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1292.485, -781.7093, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1458.9786, -861.17236, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-834.5514, -545.9278, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-555.69025, -1089.5532, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-737.17377, -947.2469, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-773.68585, -1147.412, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(684.8758, 1080.0819, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1032.051, 1229.0829, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(734.22437, 1254.0461, 20));
		AddSpawnPoint("Spawner2.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1746.7052, -249.20833, 20));

		// Rootcrystal_02 Spawn Points
		AddSpawnPoint("Spawner3.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1776.1188, 346.7532, 200));
		AddSpawnPoint("Spawner3.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1112.6938, -794.75476, 200));
		AddSpawnPoint("Spawner3.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(734.7366, 140.30185, 200));
		AddSpawnPoint("Spawner3.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(862.96173, 939.182, 200));
		AddSpawnPoint("Spawner3.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1094.607, 418.14627, 200));
		AddSpawnPoint("Spawner3.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1449.732, -544.0135, 200));
		AddSpawnPoint("Spawner3.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(108.68891, -368.53058, 200));
		AddSpawnPoint("Spawner3.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(104.42198, 49.664814, 200));
		AddSpawnPoint("Spawner3.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-344.07898, -75.41631, 200));
		AddSpawnPoint("Spawner3.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(621.30023, -915.9114, 200));
		AddSpawnPoint("Spawner3.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(24.127508, -1025.3655, 200));
		AddSpawnPoint("Spawner3.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(1608.2781, -1110.7617, 200));
		AddSpawnPoint("Spawner3.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-601.42834, -1015.2891, 200));
		AddSpawnPoint("Spawner3.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-931.66895, -636.9195, 200));
		AddSpawnPoint("Spawner3.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-906.71454, -241.27856, 200));
		AddSpawnPoint("Spawner3.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1753.7709, -392.04688, 200));
		AddSpawnPoint("Spawner3.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-1596.1376, 551.8641, 200));
		AddSpawnPoint("Spawner3.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-28.93172, 890.98926, 200));
		AddSpawnPoint("Spawner3.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-703.7825, 486.17444, 200));
		AddSpawnPoint("Spawner3.f_3cmlake_27_1", "f_3cmlake_27_1", Spot(-214.16235, 1385.5714, 200));

	}
}
