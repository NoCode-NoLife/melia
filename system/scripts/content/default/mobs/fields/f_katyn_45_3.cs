//--- Melia Script -----------------------------------------------------------
// f_katyn_45_3
//
//--- Description -----------------------------------------------------------
// Sets up the f_katyn_45_3 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FKatyn453MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("Spawner1.f_katyn_45_3", MonsterId.Mushroom_Boy_Yellow, 45, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner2.f_katyn_45_3", MonsterId.Sakmoli_Purple, 15, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner3.f_katyn_45_3", MonsterId.Jellyfish_Green, 15, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner4.f_katyn_45_3", MonsterId.Fisherman_Blue, 15, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner5.f_katyn_45_3", MonsterId.Rootcrystal_04, 22, TimeSpan.FromMilliseconds(30000));
		AddSpawner("Spawner6.f_katyn_45_3", MonsterId.Mushroom_Boy_Yellow, 35, TimeSpan.FromMilliseconds(0));
		AddSpawner("Spawner7.f_katyn_45_3", MonsterId.Mushroom_Boy_Yellow, 40, TimeSpan.FromMilliseconds(0));

		// Monster Spawn Points -----------------------------

		// Mushroom_Boy_Yellow Spawn Points
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1398.8334, 1002.4848, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1044.8121, 1304.2465, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-539.8811, 1336.6653, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-532.4746, 1551.929, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-748.558, 1178.5981, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1550.4448, 1859.0992, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1071.4789, 1895.6677, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-198.28134, 1155.0245, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-694.68634, 745.0368, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1178.5803, 587.21936, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-844.98157, 990.2625, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-696.8855, 470.77045, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1331.6216, 345.56104, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-363.87897, 453.99637, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-352.01205, 560.4924, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-75.359055, 46.010704, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(56.834812, 370.7228, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-117.21287, 280.34833, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-497.62064, -46.80145, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-183.74542, 851.06934, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1168.1509, 1182.3329, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1315.5493, 1219.537, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-776.41425, 263.55588, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-680.1299, -104.72784, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1140.5608, -99.89363, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1538.1171, -152.93031, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1561.4344, -329.509, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1322.542, -417.86954, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-894.5571, -390.87717, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-961.7896, -358.10846, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-982.24133, -444.03085, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1185.2357, -728.0346, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1589.0244, -847.2204, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1436.0116, -1049.4102, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1218.7526, -908.98914, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1415.5243, -586.35565, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1006.4227, -996.1215, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1091.8507, -1250.9208, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-826.6907, -695.81067, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-886.06213, -1278.5863, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-580.072, -828.5039, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-571.4811, -1115.2028, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-599.8476, -1452.6396, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-694.28937, -1327.0383, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-423.83026, 322.8321, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1332.5052, 661.51636, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1409.9552, 852.25366, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1097.0889, 1270.4564, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-920.9304, 1217.1572, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1116.9598, 881.7013, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-452.48132, 1065.3496, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-499.64374, 933.534, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-421.797, 1292.2349, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-389.06976, 1672.0217, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-466.6091, 1955.2902, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-773.4219, 1819.5953, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-776.0298, 1520.681, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(90.81841, 173.22649, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-283.22952, 88.831314, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(8.184059, 551.2675, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1020.0909, -20.836395, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1309.4459, -32.261852, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1074.9518, -562.75116, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1971.6367, 498.01468, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-2008.6001, 368.53052, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1778.3132, 130.8623, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1737.8206, -118.91048, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-1432.7212, -742.988, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-360.7881, -921.23157, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-447.96237, -1000.5671, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-429.00558, -1334.8895, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-598.1378, -1241.0442, 30));
		AddSpawnPoint("Spawner1.f_katyn_45_3", "f_katyn_45_3", Spot(-747.60895, -907.1737, 30));

		// Sakmoli_Purple Spawn Points
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-1586.5829, -814.6048, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-1309.6589, -698.6294, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-1062.3527, -881.42084, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-1375.785, -972.9156, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-1248.9911, -930.00214, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-1126.522, -956.3806, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-1578.3522, -1097.9912, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-1441.4775, -588.5265, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-1385.5905, -726.576, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-1501.4785, -668.94714, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-1008.7426, -783.1044, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-957.4491, -1206.9758, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-1077.2949, -1362.5653, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-1109.9226, -1234.5431, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-760.61414, -1277.9403, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-636.7936, -1375.116, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-425.1274, -1236.2716, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-488.611, -984.7783, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-710.52246, -1039.4331, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-504.87054, -817.3551, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-817.2405, -785.7892, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-816.81165, -601.85815, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-1005.0144, -614.64264, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-467.03418, -731.3425, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-280.742, -770.6413, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(187.06184, -842.1144, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(36.992455, -684.1312, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(1049.5848, -414.43906, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-58.21213, -1083.0885, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-201.64224, -1441.0398, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(1083.4099, -675.7452, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-314.754, -1488.3412, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(176.50378, -1259.1207, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(959.4124, -823.9912, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(806.5066, -1170.4197, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(199.00803, -986.24146, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-81.60886, -926.98645, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(325.4525, -520.9069, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(183.94276, -584.4254, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(1075.7058, -160.23154, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(273.25653, -990.9395, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(31.690247, -1333.319, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(405.47272, -1144.1034, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(509.46445, -871.2895, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(657.2425, -631.23474, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(657.8855, -865.2961, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(544.9478, -532.954, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(553.68365, -746.9122, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(817.27576, -516.0928, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-1560.9844, -266.7693, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-1068.5867, 14.171005, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(306.03497, -674.2467, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-1039.9385, -363.54053, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(-380.28702, -1257.8126, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(1048.1703, -895.6602, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(1079.0243, 132.66917, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(719.30835, -1440.8813, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(608.5503, -1457.2234, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(871.233, -1012.0413, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(608.486, -1080.312, 30));
		AddSpawnPoint("Spawner2.f_katyn_45_3", "f_katyn_45_3", Spot(574.9842, -1289.9259, 30));

		// Jellyfish_Green Spawn Points
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(530.6885, -1057.8165, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(683.12415, -1167.2598, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(644.3223, -1340.6145, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(700.1033, -1529.442, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(816.5997, -1265.7756, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(924.34674, -1114.5325, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(761.4334, -1048.4178, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(970.43036, -876.47754, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(1130.9402, -824.7127, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(1254.2827, -606.0358, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(1046.6323, -666.0875, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(1070.0857, -35.469486, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(739.86975, -608.22894, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(502.29694, -870.83276, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(933.2891, 220.44604, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(907.8561, -481.17328, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(404.13586, -1069.9926, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(268.88367, -1339.8451, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(73.97209, -1319.9453, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(-558.3147, -1077.0696, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(567.00525, -1224.561, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(-468.78912, -908.8595, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(-379.5558, -1118.4331, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(-751.6182, -756.37555, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(596.9825, -738.6902, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(1090.529, -385.3702, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(1081.8909, -166.55725, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(542.1895, -486.17444, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(1048.2217, 388.54956, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(867.7323, -15.734493, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(1094.6343, 264.01828, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(1128.61, 115.50574, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(1154.0167, 470.0197, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(1310.6946, 354.05188, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(1178.2091, 669.2297, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(218.17236, -887.49445, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(347.5288, -539.749, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(100.6459, -763.0422, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(-94.00152, -976.3387, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(55.311684, -799.6371, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(-0.7632332, -1133.2555, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(-175.55017, -1083.8523, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(-136.37341, -751.1748, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(29.854929, -548.53784, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(264.72287, -1163.6742, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(376.35196, -660.895, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(1218.3167, 864.3202, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(1154.6227, 1287.2892, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(1377.3865, 1060.2543, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(1347.546, 1451.1482, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(1156.4556, 1427.9847, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(1395.8984, 1242.1019, 30));
		AddSpawnPoint("Spawner3.f_katyn_45_3", "f_katyn_45_3", Spot(1583.0206, 1258.1411, 30));

		// Fisherman_Blue Spawn Points
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(-527.67993, -754.0347, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(-234.61507, -680.3553, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(308.05328, -979.8725, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(-263.08224, -1382.8268, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(175.78961, -1272.4728, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(658.87085, -1126.7197, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(725.3305, -722.8502, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(967.1072, 6.1200714, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(1170.1553, 403.6319, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(1160.0269, 1131.3649, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(1363.805, 913.24445, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(268.541, -573.4297, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(-836.3052, -626.9622, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(-983.5725, -912.2078, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(-830.28595, -1288.431, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(-348.53204, -951.98157, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(-1161.7843, -1201.6724, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(-1096.6901, -407.9795, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(-1511.4196, -549.8882, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(-1650.4095, -357.56616, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(-342.0547, 117.16495, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(-1790.4513, 238.10481, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(-940.3324, 532.706, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(-651.1487, 727.28217, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(-1189.8896, 810.5948, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(-778.78253, 1221.119, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(-559.8525, 1472.997, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(-392.49072, -817.8748, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(917.3963, -468.46796, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(1129.4933, 660.56274, 30));
		AddSpawnPoint("Spawner4.f_katyn_45_3", "f_katyn_45_3", Spot(1336.5033, 1488.749, 30));

		// Rootcrystal_04 Spawn Points
		AddSpawnPoint("Spawner5.f_katyn_45_3", "f_katyn_45_3", Spot(-153.55121, -1397.1956, 50));
		AddSpawnPoint("Spawner5.f_katyn_45_3", "f_katyn_45_3", Spot(-646.51117, -1282.4586, 50));
		AddSpawnPoint("Spawner5.f_katyn_45_3", "f_katyn_45_3", Spot(-943.7501, -1055.8202, 50));
		AddSpawnPoint("Spawner5.f_katyn_45_3", "f_katyn_45_3", Spot(-1469.4198, -818.2046, 50));
		AddSpawnPoint("Spawner5.f_katyn_45_3", "f_katyn_45_3", Spot(-1643.7587, -288.11575, 50));
		AddSpawnPoint("Spawner5.f_katyn_45_3", "f_katyn_45_3", Spot(-909.4687, -559.388, 50));
		AddSpawnPoint("Spawner5.f_katyn_45_3", "f_katyn_45_3", Spot(3.3465397, -777.5803, 50));
		AddSpawnPoint("Spawner5.f_katyn_45_3", "f_katyn_45_3", Spot(481.62234, -1022.0688, 50));
		AddSpawnPoint("Spawner5.f_katyn_45_3", "f_katyn_45_3", Spot(752.2081, -1242.1572, 50));
		AddSpawnPoint("Spawner5.f_katyn_45_3", "f_katyn_45_3", Spot(1058.6912, -821.0108, 50));
		AddSpawnPoint("Spawner5.f_katyn_45_3", "f_katyn_45_3", Spot(749.21497, -535.47577, 50));
		AddSpawnPoint("Spawner5.f_katyn_45_3", "f_katyn_45_3", Spot(1120.5411, -294.06766, 50));
		AddSpawnPoint("Spawner5.f_katyn_45_3", "f_katyn_45_3", Spot(1239.859, 118.76253, 50));
		AddSpawnPoint("Spawner5.f_katyn_45_3", "f_katyn_45_3", Spot(1259.8524, 526.6687, 50));
		AddSpawnPoint("Spawner5.f_katyn_45_3", "f_katyn_45_3", Spot(1305.2794, 1229.8293, 50));
		AddSpawnPoint("Spawner5.f_katyn_45_3", "f_katyn_45_3", Spot(-132.9018, 335.52957, 50));
		AddSpawnPoint("Spawner5.f_katyn_45_3", "f_katyn_45_3", Spot(-458.52136, 517.23914, 50));
		AddSpawnPoint("Spawner5.f_katyn_45_3", "f_katyn_45_3", Spot(-964.59467, 963.3888, 50));
		AddSpawnPoint("Spawner5.f_katyn_45_3", "f_katyn_45_3", Spot(-297.9123, 1230.1348, 50));
		AddSpawnPoint("Spawner5.f_katyn_45_3", "f_katyn_45_3", Spot(-346.79456, 1927.4937, 50));
		AddSpawnPoint("Spawner5.f_katyn_45_3", "f_katyn_45_3", Spot(-1221.68, 1863.2678, 50));
		AddSpawnPoint("Spawner5.f_katyn_45_3", "f_katyn_45_3", Spot(-1407.3148, 1133.8867, 50));

		// Mushroom_Boy_Yellow Spawn Points
		AddSpawnPoint("Spawner6.f_katyn_45_3", "f_katyn_45_3", Spot(-739.6688, -679.85345, 9999));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(-135.0536, -1427.9462, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(82.04938, -1327.9563, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(4.2910233, -1175.6821, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(266.7014, -1139.554, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(308.56525, -1260.0094, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(490.81113, -1113.6362, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(430.83203, -1005.0009, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(461.85834, -850.22614, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(617.4784, -644.43726, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(692.69543, -764.98914, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(590.0856, -741.0073, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(843.0588, -529.6532, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1106.1051, -402.3157, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1005.9579, -566.31494, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(917.8117, -413.34662, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1116.5126, -82.50562, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(968.35046, 51.492588, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(881.5339, 261.58417, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1048.4095, 383.82767, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1048.7635, 255.64957, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1238.7163, 144.65025, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1221.5337, 510.48083, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1139.0426, 622.6935, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1139.0426, 622.6935, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1193.9337, 915.12354, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1127.538, 670.3242, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1288.5969, 1142.716, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1102.632, 1279.5721, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1366.4696, 1421.2048, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1322.7677, 1275.8331, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1240.9993, 1465.5511, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1268.5282, 1608.578, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(317.4674, -735.9479, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(199.94214, -918.0298, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(100.73419, -996.7235, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(137.1695, -795.51984, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(-27.47621, -836.418, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(34.897472, -650.1145, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(-138.35223, -702.3575, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(229.06862, -486.28696, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(-35.80316, -491.70923, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(-855.301, -340.43658, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(-165.78464, -883.9557, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(-284.3909, -700.8125, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(-409.64194, -802.69336, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(-315.21603, -981.49786, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(-361.34402, -1115.2931, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(-368.82913, -1274.0887, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(-578.9328, -1314.7698, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(-567.14197, -1000.5388, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(-335.94034, -830.6309, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(-663.08923, -670.27295, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(-653.3651, 319.81586, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(-348.01944, 212.76053, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(-61.485016, 428.38577, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(627.6606, -1339.5211, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(721.09515, -1391.1257, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(802.36096, -1273.2397, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(658.98956, -1192.7992, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(582.3339, -1102.0587, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(900.1939, -1095.4253, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(748.6349, -1075.5046, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(772.87836, -1149.544, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(932.49396, -974.1982, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1014.4956, -879.65564, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(990.27954, -789.18286, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1154.6521, -727.80054, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1070.9648, -815.3969, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(852.80304, -912.0939, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(733.3927, -1009.5635, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(751.856, -584.62085, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(615.5664, -483.0381, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(522.36237, -542.41486, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(459.33685, -440.7405, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(416.10312, -611.09894, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(253.13896, -608.2718, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(218.60336, -1272.708, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1087.7545, -243.33543, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1115.8992, 126.96293, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1266.92, 334.95294, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1167.6042, 762.2775, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1180.952, 1428.6526, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1473.8035, 1595.5747, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1542.5784, 1363.2391, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1452.4003, 1134.8962, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1355.9778, 923.13654, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1306.3231, 971.51355, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1158.194, 1174.7183, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1091.7811, 1366.3324, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1081.0941, 501.38016, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1060.5237, 142.05936, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1280.3561, -59.041145, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1314.0812, 10.707186, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1163.9485, -576.3165, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(1055.381, -652.9083, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(-427.6478, -1508.1191, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(-255.95927, -1483.3557, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(-618.2032, -1516.2198, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(-208.80986, -1322.8513, 25));
		AddSpawnPoint("Spawner7.f_katyn_45_3", "f_katyn_45_3", Spot(24.014973, -1444.7922, 25));

	}
}
