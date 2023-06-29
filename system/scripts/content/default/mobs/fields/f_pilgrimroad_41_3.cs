//--- Melia Script -----------------------------------------------------------
// f_pilgrimroad_41_3
//
//--- Description -----------------------------------------------------------
// Sets up the f_pilgrimroad_41_3 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FPilgrimroad413MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("Spawner1.f_pilgrimroad_41_3", MonsterId.Rootcrystal_01, 12, TimeSpan.FromMilliseconds(5000));
		AddSpawner("Spawner2.f_pilgrimroad_41_3", MonsterId.Minos_Green, 70, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner3.f_pilgrimroad_41_3", MonsterId.Minos_Bow_Green, 20, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner4.f_pilgrimroad_41_3", MonsterId.Lapasape_Mage_Brown, 30, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner5.f_pilgrimroad_41_3", MonsterId.Lapasape_Mage_Brown, 30, TimeSpan.FromMilliseconds(0));

		// Monster Spawn Points -----------------------------

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1097.8883, 680.544, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1020.6835, 443.0401, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-839.6953, 634.40875, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1082.6256, -109.07273, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-984.2088, -393.91705, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-772.95184, -178.1169, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1252.7906, -972.621, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-891.9371, -821.6462, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-936.7012, -1131.027, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-320.22644, -833.0854, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-48.868332, -882.96454, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-81.74655, -169.38205, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(85.788445, 164.55771, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(248.18672, -160.85555, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-326.78174, 880.89624, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-18.04481, 910.42267, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(722.30554, -320.8334, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(931.20966, -574.8629, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1066.7759, -320.25705, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(795.0647, 316.3767, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1130.7832, 362.85034, 50));
		AddSpawnPoint("Spawner1.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1094.2958, 1086.1292, 50));

		// Minos_Green Spawn Points
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-184.05585, -115.06728, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-136.77406, 97.060326, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-52.71746, 187.08467, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(44.967167, 41.345325, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(52.869034, -94.346634, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(137.548, -271.75824, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(301.0901, -178.48663, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(237.23927, 111.77631, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-297.77554, 815.28906, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-330.7957, 1012.9056, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-168.92421, 944.13995, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(17.218264, 835.2786, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1166.995, 311.4266, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-969.8334, 371.6357, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1165.4414, 758.2331, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1095.0366, 422.28275, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1165.8418, 545.1015, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-962.7284, -92.807175, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1140.3463, -200.63972, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-856.8754, -196.50966, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-948.0938, -385.6031, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1195.0762, -819.58716, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-962.7121, -833.5043, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-860.194, -957.59155, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-958.22424, -1126.5502, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1112.7732, -1029.9276, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1289.1279, -1047.6292, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-395.1858, -814.8168, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-231.00397, -755.2706, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-242.96828, -878.5612, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-185.15987, -1020.2038, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-54.387413, -956.4823, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(729.32245, -522.0095, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(920.2159, -443.35483, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(985.2315, -292.2166, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1060.2471, -437.77383, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(950.31354, -564.7522, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(823.1407, -613.2743, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1108.7087, 1272.8599, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1272.1453, 935.86865, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1112.9746, -644.31793, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1165.495, -446.61993, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(820.9601, 1025.0288, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(924.73065, 900.19104, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1178.7416, 944.8268, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1207.4828, 1102.7975, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(912.506, 1226.512, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1176.345, -1197.8866, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1153.1897, -1152.154, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1235.2329, -1138.0236, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1205.5151, -1055.4052, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1157.472, -986.88525, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1221.1417, -928.51825, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1233.6411, -1002.824, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1156.8025, -927.6295, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1233.6454, -853.22296, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1170.5105, -877.3886, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1328.1948, -984.65607, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1290.8171, -851.367, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-881.80023, -769.8491, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-839.76996, -790.85876, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-847.5053, -851.8358, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-915.07837, -944.7005, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-920.1249, -896.4106, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-891.97754, -1013.8264, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-801.4538, -1072.5209, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-848.9975, -1158.9103, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-903.2826, -1193.5295, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-868.198, -1129.6487, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-871.74243, -1078.3556, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-801.1312, -1010.2715, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-779.9792, -884.8496, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-808.3769, -944.6536, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-951.53033, -1007.1372, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-844.6148, -899.6356, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-961.1529, -1209.1497, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-801.3178, -1121.954, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1123.6237, -436.00693, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1120.2965, -371.3631, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1161.0829, -411.0164, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1143.3813, -334.0196, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1113.787, -274.19275, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1079.7133, -319.1453, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1038.8776, -226.9023, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1086.556, -215.69719, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1061.0634, -138.46216, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1094.0768, -81.90207, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1039.8328, -53.487217, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-903.509, -141.47581, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-993.92194, -106.00956, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-954.55743, -451.0957, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-903.2047, -425.53113, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-914.4676, -468.4671, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-831.8151, -460.26053, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-772.39233, -390.86334, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-696.83276, -264.6631, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-757.56384, -279.89426, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-719.6412, -142.44002, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-815.25226, -134.29817, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-828.99097, -84.46564, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-773.7867, -37.204697, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-736.9063, -84.86123, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-914.9575, -83.756615, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1003.3983, -22.156492, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1147.9822, 366.96643, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1185.0426, 465.25714, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1198.8494, 522.2973, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1209.2028, 576.4072, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1106.9208, 816.287, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-872.2348, 806.5786, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-807.107, 789.5211, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-934.8609, 798.32904, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1066.0604, 644.3876, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1005.1351, 667.4657, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-993.50366, 583.4098, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-996.23083, 488.12125, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-979.76794, 428.28525, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-928.29456, 451.0181, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-859.2837, 502.0294, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-884.8472, 572.8689, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-908.30585, 643.196, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-784.6478, 652.8773, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-750.4154, 524.975, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-737.96075, 433.42334, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-816.7834, 451.66812, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-792.66846, 567.3954, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-939.1784, 659.967, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-264.9054, 1114.0132, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-191.83545, 1066.4811, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-237.90477, 1019.1496, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-375.0539, 1020.4714, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-249.32693, 956.8138, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-274.08316, 928.84, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-212.86957, 857.0652, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-346.36447, 824.3775, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-238.80942, 790.49084, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-177.04927, 816.51935, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-19.273811, 755.5368, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(55.383224, 797.9528, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(73.18012, 871.76294, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(51.487934, 919.78925, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(60.99083, 981.71234, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(39.823837, 1027.64, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(14.816594, 1078.5505, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-16.988152, 1109.9885, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-509.80814, 810.6107, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-582.5005, 761.86456, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-322.93033, 878.3222, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-238.26656, 888.79834, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-279.84695, 752.94995, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-228.54434, 742.1416, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-128.18938, 708.432, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(40.321186, 737.91077, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-34.509373, 799.147, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-146.56526, 594.16797, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(68.96532, 234.29437, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(213.95712, 230.2445, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(65.063896, 174.1993, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(39.78614, 81.72554, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-72.5345, 10.344919, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-130.46272, 27.345493, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-106.29089, -49.588593, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-23.606144, -63.73858, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-154.71394, -173.11136, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-243.69705, -159.63782, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-289.39764, -99.001816, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-57.115032, -155.99292, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(56.556446, -32.74381, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(135.4535, -8.170295, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(333.13376, 16.990517, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(191.52934, 82.07399, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(19.796959, -286.40085, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-19.204754, -218.1013, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(121.35638, -180.52962, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(231.10706, -212.96725, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(284.99255, -250.50128, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(200.66704, -286.9857, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(195.30128, -221.49307, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(89.53826, -284.58752, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(29.035292, -323.79633, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(950.70483, -315.4585, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1043.0397, -224.80826, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1063.8737, -317.45438, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1164.8877, -368.63123, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1071.603, -482.0994, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1131.0134, -584.6385, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1057.8074, -663.1014, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1015.0839, -585.35944, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(832.899, -693.3575, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(885.4358, -604.8447, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(780.3388, -572.6829, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(948.969, -510.80133, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(848.4971, -384.40338, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(768.2208, -324.6449, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(800.83136, -250.42383, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(953.9157, -255.10187, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(718.02075, -470.21216, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(794.36414, -510.34613, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(914.9336, -483.51624, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(900.71075, -354.9544, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(887.96564, 1179.6547, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(985.2646, 1227.1726, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(765.84735, 1213.3353, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(709.61096, 1068.7736, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(768.43304, 1013.597, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(740.2184, 906.5537, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(785.8207, 928.8062, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(889.11743, 979.2195, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(947.16174, 964.87317, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(871.416, 1039.634, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1166.1033, 872.9119, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1178.6456, 992.4209, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1271.7765, 1086.5396, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1175.6453, 1137.5345, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1071.4883, 1183.9918, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1030.0878, 877.7334, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(844.8846, 926.30054, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1049.9484, 1069.2703, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1028.0376, 1120.1111, 25));
		AddSpawnPoint("Spawner2.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1130.0258, 1038.9998, 25));

		// Minos_Bow_Green Spawn Points
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1227.3223, 719.2787, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-955.83105, 846.04645, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1112.4562, 685.3362, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-843.0963, 366.16348, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1266.2264, 481.09387, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-338.04706, -925.1226, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-249.20352, -773.47894, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-100.64926, -805.656, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-180.4526, -888.95404, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-209.51407, -1034.1741, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-384.08377, -742.8881, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-574.8731, -516.97363, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-469.2638, -639.79047, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1019.2261, 82.87745, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1041.8186, 233.98132, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-559.072, 793.88617, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-632.2143, 759.39105, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(862.74384, -534.32263, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1084.2328, 858.31445, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(969.88806, 1314.4292, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1234.9155, 1176.6748, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1059.7025, -584.55896, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(924.48895, -661.99976, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1107.0052, -260.74692, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(827.7043, -294.2026, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(720.439, 1123.7634, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(440.80472, 194.79126, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-212.38382, -46.504852, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(9.005066, -155.65094, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(184.39378, -84.774796, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(118.32035, 203.24202, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1.0236335, 34.12917, 25));
		AddSpawnPoint("Spawner3.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-109.28162, 214.61719, 25));

		// Lapasape_Mage_Brown Spawn Points
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1173.8176, -321.10568, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1206.8544, 884.83374, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(996.5374, 849.9374, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1076.3756, 923.05927, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1285.3276, 1040.8988, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1127.2401, -528.667, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-153.46684, -80.967865, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(88.62635, -69.795876, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(34.513145, -198.07527, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-53.260036, 92.43389, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(119.14861, 171.90337, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(304.9365, 78.475945, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-178.38516, 131.53987, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-403.27365, 939.5227, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-289.72174, 877.46204, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-157.84433, 917.075, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-344.14474, 1119.6986, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-69.75563, 1047.5057, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-4.455208, 851.4362, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-188.261, 755.2583, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(674.19275, -416.39825, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(773.9944, -422.69165, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(693.4246, -305.0675, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(884.9061, -225.70334, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1104.2133, -345.00876, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(973.2647, -389.90906, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1003.2906, -497.71606, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(992.42065, -643.0151, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(849.72205, 1127.3184, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(1158.5826, 1190.0488, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(813.16876, 1255.6525, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(722.7508, 978.85547, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(838.434, 873.1084, 20));
		AddSpawnPoint("Spawner4.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(994.0018, -188.26378, 20));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-374.86594, -938.7699, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-252.11328, -802.5588, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-201.82918, -939.7554, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-117.50688, -725.8493, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-434.22153, -736.92395, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(0.05803585, -914.38434, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-682.7923, -499.51956, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-886.14105, -346.99725, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1166.5297, -1077.7361, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-944.3369, -1104.0842, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1318.702, -913.1062, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1065.5739, -897.1946, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1188.2362, -766.64124, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-934.76996, -784.6805, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-771.18176, -969.64966, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1081.6079, -1205.3513, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1274.2275, -1087.4373, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1088.2993, -481.7507, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1201.4377, -344.06635, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-836.24384, -326.92245, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1135.2678, -155.5817, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-973.53796, -161.98007, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1051.0271, 11.232587, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-863.5981, -10.838677, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-714.6333, -193.64957, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1012.348, 95.271614, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1011.4072, 329.76752, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1176.6476, 405.07053, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1223.1, 623.6605, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1075.0396, 506.67792, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-1052.251, 792.23254, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-955.5779, 534.8973, 25));
		AddSpawnPoint("Spawner5.f_pilgrimroad_41_3", "f_pilgrimroad_41_3", Spot(-898.64075, 380.95294, 25));

	}
}
