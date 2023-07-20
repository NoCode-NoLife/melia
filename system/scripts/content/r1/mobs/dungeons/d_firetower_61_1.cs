//--- Melia Script -----------------------------------------------------------
// Roxona Reconstruction Agency West Building Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_firetower_61_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DFiretower611MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("d_firetower_61_1.Id1", MonsterId.Raider_Bow, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_61_1.Id2", MonsterId.Socket_Bow_Brown, 38, 50, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_61_1.Id3", MonsterId.Anchor, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_61_1.Id4", MonsterId.Socket_Bow_Brown, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_firetower_61_1.Id5", MonsterId.Boss_Marionette, 0, 0, TimeSpan.FromMilliseconds(7200000), TendencyType.Aggressive);
		AddSpawner("d_firetower_61_1.Id6", MonsterId.Rootcrystal_04, 15, 20, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Raider_Bow' GenType 1 Spawn Points
		AddSpawnPoint("d_firetower_61_1.Id1", "d_firetower_61_1", Rectangle(-124, 719, 35));
		AddSpawnPoint("d_firetower_61_1.Id1", "d_firetower_61_1", Rectangle(-100, 907, 35));
		AddSpawnPoint("d_firetower_61_1.Id1", "d_firetower_61_1", Rectangle(-113, 560, 35));
		AddSpawnPoint("d_firetower_61_1.Id1", "d_firetower_61_1", Rectangle(34, 740, 35));
		AddSpawnPoint("d_firetower_61_1.Id1", "d_firetower_61_1", Rectangle(-1018, 767, 35));
		AddSpawnPoint("d_firetower_61_1.Id1", "d_firetower_61_1", Rectangle(-994, 1117, 35));
		AddSpawnPoint("d_firetower_61_1.Id1", "d_firetower_61_1", Rectangle(-926, 906, 35));
		AddSpawnPoint("d_firetower_61_1.Id1", "d_firetower_61_1", Rectangle(759, 1028, 35));
		AddSpawnPoint("d_firetower_61_1.Id1", "d_firetower_61_1", Rectangle(764, 734, 35));
		AddSpawnPoint("d_firetower_61_1.Id1", "d_firetower_61_1", Rectangle(598, 1175, 35));
		AddSpawnPoint("d_firetower_61_1.Id1", "d_firetower_61_1", Rectangle(614, 843, 35));
		AddSpawnPoint("d_firetower_61_1.Id1", "d_firetower_61_1", Rectangle(-920, 619, 35));
		AddSpawnPoint("d_firetower_61_1.Id1", "d_firetower_61_1", Rectangle(-234, 743, 35));

		// 'Socket_Bow_Brown' GenType 2 Spawn Points
		AddSpawnPoint("d_firetower_61_1.Id2", "d_firetower_61_1", Rectangle(-845, -1414, 30));
		AddSpawnPoint("d_firetower_61_1.Id2", "d_firetower_61_1", Rectangle(-956, -1260, 30));
		AddSpawnPoint("d_firetower_61_1.Id2", "d_firetower_61_1", Rectangle(-682, -1031, 30));
		AddSpawnPoint("d_firetower_61_1.Id2", "d_firetower_61_1", Rectangle(-1510, -667, 30));
		AddSpawnPoint("d_firetower_61_1.Id2", "d_firetower_61_1", Rectangle(-1378, -878, 30));
		AddSpawnPoint("d_firetower_61_1.Id2", "d_firetower_61_1", Rectangle(-1308, -637, 30));
		AddSpawnPoint("d_firetower_61_1.Id2", "d_firetower_61_1", Rectangle(-1913, -1106, 30));
		AddSpawnPoint("d_firetower_61_1.Id2", "d_firetower_61_1", Rectangle(-1724, -1098, 30));
		AddSpawnPoint("d_firetower_61_1.Id2", "d_firetower_61_1", Rectangle(-1295, -1704, 30));
		AddSpawnPoint("d_firetower_61_1.Id2", "d_firetower_61_1", Rectangle(-1145, -1684, 30));
		AddSpawnPoint("d_firetower_61_1.Id2", "d_firetower_61_1", Rectangle(-1283, -1579, 30));
		AddSpawnPoint("d_firetower_61_1.Id2", "d_firetower_61_1", Rectangle(-757, -1217, 30));
		AddSpawnPoint("d_firetower_61_1.Id2", "d_firetower_61_1", Rectangle(-1283, -450, 30));

		// 'Anchor' GenType 3 Spawn Points
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(978, -479, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(687, -807, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(690, -1054, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(621, -1042, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(554, -1173, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(626, -1129, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(1098, -626, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(1066, -682, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(1152, -730, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(364, -1143, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1813, -1116, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1847, -1065, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1815, -1021, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1780, -1196, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1709, -1191, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1726, -1034, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1639, -1090, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1771, -966, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1856, -978, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1899, -1038, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1866, -1164, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1861, -1124, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1806, -1163, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1749, -1137, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1788, -1061, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1683, -1053, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1759, -1014, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1664, -1146, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1749, -1229, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1872, -1020, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1757, -1089, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1721, -981, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1840, -1210, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1899, -1182, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1934, -1069, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1519, -738, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1413, -836, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1427, -750, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1473, -631, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1433, -593, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1393, -541, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1344, -492, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1304, -549, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1262, -578, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1232, -622, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1202, -698, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1246, -743, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1308, -713, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1355, -656, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1247, -663, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1374, -751, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1419, -702, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1315, -799, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1282, -775, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1342, -834, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1344, -706, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1333, -600, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1220, -473, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1200, -535, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1156, -567, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-625, -1096, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-571, -1136, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-532, -1198, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-555, -1260, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-607, -1304, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-611, -1250, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-662, -1188, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-677, -1135, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-731, -1133, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-764, -1080, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-770, -1016, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-724, -996, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-809, -1107, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-859, -1125, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-891, -1164, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-929, -1195, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-803, -1188, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-703, -1236, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-794, -1309, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-842, -1267, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-738, -1263, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-663, -1292, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-646, -1363, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-697, -1404, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-697, -1343, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-745, -1438, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-790, -1433, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-866, -1363, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-915, -1331, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-862, -1326, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1200, -1563, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1136, -1584, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1076, -1655, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1126, -1760, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1176, -1811, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1203, -1750, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1224, -1705, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1258, -1675, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1312, -1643, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1220, -1648, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1253, -1765, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1258, -1726, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1354, -1676, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1342, -1606, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1258, -1633, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1170, -1623, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1075, -1693, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1113, -1658, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1150, -1737, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1213, -1789, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1315, -1749, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1268, -1808, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1366, -1726, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1183, -1699, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1172, -1772, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-163, -1178, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-158, -1339, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-180, -1273, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-150, -1230, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-153, -1304, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1004, 711, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-993, 623, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-922, 673, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-868, 726, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-944, 749, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-874, 816, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1010, 869, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-951, 819, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-863, 895, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1004, 915, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-959, 989, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-892, 998, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-845, 1050, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-919, 1069, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1002, 1062, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-920, 1127, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-853, 1130, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-936, 1208, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-882, 1171, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-1032, 1160, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-956, 1100, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-891, 1050, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-855, 958, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-969, 875, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-898, 769, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-153, 974, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-30, 957, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(32, 885, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-29, 838, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-139, 880, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-159, 807, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-84, 790, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-27, 725, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(23, 795, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(57, 681, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(99, 638, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(84, 555, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(18, 514, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(2, 604, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-74, 650, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-156, 667, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-196, 616, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-164, 556, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-133, 609, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(-33, 628, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(749, 657, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(855, 648, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(935, 681, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(673, 686, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(741, 792, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(935, 743, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(943, 839, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(948, 896, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(951, 987, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(954, 1074, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(932, 1169, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(827, 1184, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(725, 1223, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(762, 1138, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(706, 1136, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(622, 1015, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(767, 961, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(848, 943, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(793, 863, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(734, 857, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(612, 652, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(731, 700, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(692, 840, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(681, 950, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(628, 949, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(731, 976, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(887, 980, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(899, 1050, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(826, 1094, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(897, 1232, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(899, 903, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(899, 831, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(808, 836, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(875, 690, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(806, 678, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(452, -1196, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(378, -1286, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(318, -1237, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(282, -1196, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(377, -1231, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(443, -1128, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(427, -1075, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(522, -1053, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(520, -1171, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(568, -1088, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(565, -978, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(629, -894, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(681, -985, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(728, -916, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(701, -878, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(781, -822, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(789, -757, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(820, -848, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(903, -758, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(821, -685, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(852, -753, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(926, -607, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(881, -601, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(952, -722, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(1006, -622, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(908, -673, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(988, -543, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(1051, -425, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(1077, -347, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(1136, -329, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(1169, -433, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(1092, -512, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(1125, -411, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(1219, -493, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(1140, -554, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(1055, -590, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(914, -530, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(1010, -687, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(1192, -704, 30));
		AddSpawnPoint("d_firetower_61_1.Id3", "d_firetower_61_1", Rectangle(1197, -772, 30));

		// 'Socket_Bow_Brown' GenType 4 Spawn Points
		AddSpawnPoint("d_firetower_61_1.Id4", "d_firetower_61_1", Rectangle(-140, -1266, 9999));
		AddSpawnPoint("d_firetower_61_1.Id4", "d_firetower_61_1", Rectangle(1256, -418, 9999));
		AddSpawnPoint("d_firetower_61_1.Id4", "d_firetower_61_1", Rectangle(1197, -374, 9999));
		AddSpawnPoint("d_firetower_61_1.Id4", "d_firetower_61_1", Rectangle(1009, -415, 9999));
		AddSpawnPoint("d_firetower_61_1.Id4", "d_firetower_61_1", Rectangle(874, -650, 9999));
		AddSpawnPoint("d_firetower_61_1.Id4", "d_firetower_61_1", Rectangle(679, -937, 9999));
		AddSpawnPoint("d_firetower_61_1.Id4", "d_firetower_61_1", Rectangle(612, -990, 9999));
		AddSpawnPoint("d_firetower_61_1.Id4", "d_firetower_61_1", Rectangle(503, -1110, 9999));
		AddSpawnPoint("d_firetower_61_1.Id4", "d_firetower_61_1", Rectangle(406, -1247, 9999));
		AddSpawnPoint("d_firetower_61_1.Id4", "d_firetower_61_1", Rectangle(287, -1315, 9999));
		AddSpawnPoint("d_firetower_61_1.Id4", "d_firetower_61_1", Rectangle(353, -1158, 9999));

		// 'Boss_Marionette' GenType 7 Spawn Points
		AddSpawnPoint("d_firetower_61_1.Id5", "d_firetower_61_1", Rectangle(1792, 216, 20));

		// 'Rootcrystal_04' GenType 28 Spawn Points
		AddSpawnPoint("d_firetower_61_1.Id6", "d_firetower_61_1", Rectangle(-362, -1921, 100));
		AddSpawnPoint("d_firetower_61_1.Id6", "d_firetower_61_1", Rectangle(327, -1252, 100));
		AddSpawnPoint("d_firetower_61_1.Id6", "d_firetower_61_1", Rectangle(-136, -1713, 100));
		AddSpawnPoint("d_firetower_61_1.Id6", "d_firetower_61_1", Rectangle(765, -1437, 100));
		AddSpawnPoint("d_firetower_61_1.Id6", "d_firetower_61_1", Rectangle(575, -1081, 100));
		AddSpawnPoint("d_firetower_61_1.Id6", "d_firetower_61_1", Rectangle(840, -729, 100));
		AddSpawnPoint("d_firetower_61_1.Id6", "d_firetower_61_1", Rectangle(1182, -390, 100));
		AddSpawnPoint("d_firetower_61_1.Id6", "d_firetower_61_1", Rectangle(1713, -102, 100));
		AddSpawnPoint("d_firetower_61_1.Id6", "d_firetower_61_1", Rectangle(1931, 212, 100));
		AddSpawnPoint("d_firetower_61_1.Id6", "d_firetower_61_1", Rectangle(-141, -1020, 100));
		AddSpawnPoint("d_firetower_61_1.Id6", "d_firetower_61_1", Rectangle(-781, -1240, 100));
		AddSpawnPoint("d_firetower_61_1.Id6", "d_firetower_61_1", Rectangle(-1163, -1639, 100));
		AddSpawnPoint("d_firetower_61_1.Id6", "d_firetower_61_1", Rectangle(-1790, -1063, 100));
		AddSpawnPoint("d_firetower_61_1.Id6", "d_firetower_61_1", Rectangle(-1299, -768, 100));
		AddSpawnPoint("d_firetower_61_1.Id6", "d_firetower_61_1", Rectangle(-83, 605, 100));
		AddSpawnPoint("d_firetower_61_1.Id6", "d_firetower_61_1", Rectangle(-58, 955, 100));
		AddSpawnPoint("d_firetower_61_1.Id6", "d_firetower_61_1", Rectangle(-617, 825, 100));
		AddSpawnPoint("d_firetower_61_1.Id6", "d_firetower_61_1", Rectangle(-955, 733, 100));
		AddSpawnPoint("d_firetower_61_1.Id6", "d_firetower_61_1", Rectangle(-903, 1052, 100));
		AddSpawnPoint("d_firetower_61_1.Id6", "d_firetower_61_1", Rectangle(753, 711, 100));
		AddSpawnPoint("d_firetower_61_1.Id6", "d_firetower_61_1", Rectangle(718, 1023, 100));
		AddSpawnPoint("d_firetower_61_1.Id6", "d_firetower_61_1", Rectangle(1042, 1410, 100));
		AddSpawnPoint("d_firetower_61_1.Id6", "d_firetower_61_1", Rectangle(1326, 1752, 100));
		AddSpawnPoint("d_firetower_61_1.Id6", "d_firetower_61_1", Rectangle(1254, 1854, 100));
		AddSpawnPoint("d_firetower_61_1.Id6", "d_firetower_61_1", Rectangle(-133, 1612, 100));
		AddSpawnPoint("d_firetower_61_1.Id6", "d_firetower_61_1", Rectangle(8, 1774, 100));
	}
}
