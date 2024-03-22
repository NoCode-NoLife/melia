//--- Melia Script -----------------------------------------------------------
// Veja Ravine Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_huevillage_58_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Game.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FHuevillage581MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_huevillage_58_1", MonsterId.Tanu, Properties("MHP", 26846, "MINPATK", 846, "MAXPATK", 942, "MINMATK", 846, "MAXMATK", 942, "DEF", 167, "MDEF", 167));
		AddPropertyOverrides("f_huevillage_58_1", MonsterId.Tipio, Properties("MHP", 26947, "MINPATK", 847, "MAXPATK", 944, "MINMATK", 847, "MAXMATK", 944, "DEF", 167, "MDEF", 167));
		AddPropertyOverrides("f_huevillage_58_1", MonsterId.Beetow, Properties("MHP", 27133, "MINPATK", 850, "MAXPATK", 947, "MINMATK", 850, "MAXMATK", 947, "DEF", 167, "MDEF", 167));
		AddPropertyOverrides("f_huevillage_58_1", MonsterId.Doyor, Properties("MHP", 27373, "MINPATK", 853, "MAXPATK", 950, "MINMATK", 853, "MAXMATK", 950, "DEF", 168, "MDEF", 168));
		AddPropertyOverrides("f_huevillage_58_1", MonsterId.Siaulav_Bow, Properties("MHP", 27657, "MINPATK", 856, "MAXPATK", 955, "MINMATK", 856, "MAXMATK", 955, "DEF", 168, "MDEF", 168));
		AddPropertyOverrides("f_huevillage_58_1", MonsterId.Boss_Merregina, Properties("MHP", 132623, "MINPATK", 1756, "MAXPATK", 1958, "MINMATK", 1756, "MAXMATK", 1958, "DEF", 344, "MDEF", 344));
		AddPropertyOverrides("f_huevillage_58_1", MonsterId.Boss_Moyabruka, Properties("MHP", 134313, "MINPATK", 1765, "MAXPATK", 1970, "MINMATK", 1765, "MAXMATK", 1970, "DEF", 345, "MDEF", 345));

		// Monster Spawners ---------------------------------

		AddSpawner("f_huevillage_58_1.Id1", MonsterId.Tanu, min: 8, max: 10);
		AddSpawner("f_huevillage_58_1.Id2", MonsterId.Tipio, min: 15, max: 20);
		AddSpawner("f_huevillage_58_1.Id3", MonsterId.Beetow, min: 9, max: 12);
		AddSpawner("f_huevillage_58_1.Id4", MonsterId.Rootcrystal_01, min: 9, max: 12, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("f_huevillage_58_1.Id5", MonsterId.Tipio, min: 64, max: 85);
		AddSpawner("f_huevillage_58_1.Id6", MonsterId.Doyor, min: 9, max: 12);
		AddSpawner("f_huevillage_58_1.Id7", MonsterId.Tipio, min: 4, max: 5);
		AddSpawner("f_huevillage_58_1.Id8", MonsterId.Siaulav_Bow, min: 8, max: 10);

		// Monster Spawn Points -----------------------------

		// 'Tanu' GenType 19 Spawn Points
		AddSpawnPoint("f_huevillage_58_1.Id1", "f_huevillage_58_1", Rectangle(1229, 1061, 20));
		AddSpawnPoint("f_huevillage_58_1.Id1", "f_huevillage_58_1", Rectangle(1322, 1162, 20));
		AddSpawnPoint("f_huevillage_58_1.Id1", "f_huevillage_58_1", Rectangle(1409, 813, 20));
		AddSpawnPoint("f_huevillage_58_1.Id1", "f_huevillage_58_1", Rectangle(1562, 883, 20));
		AddSpawnPoint("f_huevillage_58_1.Id1", "f_huevillage_58_1", Rectangle(1314, 946, 20));
		AddSpawnPoint("f_huevillage_58_1.Id1", "f_huevillage_58_1", Rectangle(1470, 1247, 20));
		AddSpawnPoint("f_huevillage_58_1.Id1", "f_huevillage_58_1", Rectangle(1251, 824, 20));
		AddSpawnPoint("f_huevillage_58_1.Id1", "f_huevillage_58_1", Rectangle(871, 1002, 20));
		AddSpawnPoint("f_huevillage_58_1.Id1", "f_huevillage_58_1", Rectangle(986, 879, 20));
		AddSpawnPoint("f_huevillage_58_1.Id1", "f_huevillage_58_1", Rectangle(1082, 956, 20));
		AddSpawnPoint("f_huevillage_58_1.Id1", "f_huevillage_58_1", Rectangle(1575, 1061, 20));
		AddSpawnPoint("f_huevillage_58_1.Id1", "f_huevillage_58_1", Rectangle(1422, 1066, 20));
		AddSpawnPoint("f_huevillage_58_1.Id1", "f_huevillage_58_1", Rectangle(1476, 932, 20));
		AddSpawnPoint("f_huevillage_58_1.Id1", "f_huevillage_58_1", Rectangle(1511, 753, 20));

		// 'Tipio' GenType 20 Spawn Points
		AddSpawnPoint("f_huevillage_58_1.Id2", "f_huevillage_58_1", Rectangle(708, -1080, 9999));

		// 'Beetow' GenType 22 Spawn Points
		AddSpawnPoint("f_huevillage_58_1.Id3", "f_huevillage_58_1", Rectangle(888, 909, 20));
		AddSpawnPoint("f_huevillage_58_1.Id3", "f_huevillage_58_1", Rectangle(1286, 1006, 20));
		AddSpawnPoint("f_huevillage_58_1.Id3", "f_huevillage_58_1", Rectangle(-727, 920, 20));
		AddSpawnPoint("f_huevillage_58_1.Id3", "f_huevillage_58_1", Rectangle(1425, 773, 20));
		AddSpawnPoint("f_huevillage_58_1.Id3", "f_huevillage_58_1", Rectangle(-281, 765, 20));
		AddSpawnPoint("f_huevillage_58_1.Id3", "f_huevillage_58_1", Rectangle(1587, 1000, 20));
		AddSpawnPoint("f_huevillage_58_1.Id3", "f_huevillage_58_1", Rectangle(-222, 964, 20));
		AddSpawnPoint("f_huevillage_58_1.Id3", "f_huevillage_58_1", Rectangle(-451, 957, 20));
		AddSpawnPoint("f_huevillage_58_1.Id3", "f_huevillage_58_1", Rectangle(-967, 874, 20));
		AddSpawnPoint("f_huevillage_58_1.Id3", "f_huevillage_58_1", Rectangle(-883, 1195, 20));
		AddSpawnPoint("f_huevillage_58_1.Id3", "f_huevillage_58_1", Rectangle(1434, 1090, 20));

		// 'Rootcrystal_01' GenType 27 Spawn Points
		AddSpawnPoint("f_huevillage_58_1.Id4", "f_huevillage_58_1", Rectangle(1027, -1010, 100));
		AddSpawnPoint("f_huevillage_58_1.Id4", "f_huevillage_58_1", Rectangle(447, -1097, 100));
		AddSpawnPoint("f_huevillage_58_1.Id4", "f_huevillage_58_1", Rectangle(-588, -1229, 100));
		AddSpawnPoint("f_huevillage_58_1.Id4", "f_huevillage_58_1", Rectangle(324, -544, 100));
		AddSpawnPoint("f_huevillage_58_1.Id4", "f_huevillage_58_1", Rectangle(706, -290, 100));
		AddSpawnPoint("f_huevillage_58_1.Id4", "f_huevillage_58_1", Rectangle(-456, -99, 100));
		AddSpawnPoint("f_huevillage_58_1.Id4", "f_huevillage_58_1", Rectangle(-927, 607, 100));
		AddSpawnPoint("f_huevillage_58_1.Id4", "f_huevillage_58_1", Rectangle(-1169, 958, 100));
		AddSpawnPoint("f_huevillage_58_1.Id4", "f_huevillage_58_1", Rectangle(-861, 1202, 100));
		AddSpawnPoint("f_huevillage_58_1.Id4", "f_huevillage_58_1", Rectangle(558, 911, 100));
		AddSpawnPoint("f_huevillage_58_1.Id4", "f_huevillage_58_1", Rectangle(1482, 1196, 100));
		AddSpawnPoint("f_huevillage_58_1.Id4", "f_huevillage_58_1", Rectangle(1446, 779, 100));

		// 'Tipio' GenType 30 Spawn Points
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-459, -1253, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-383, -1049, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-676, -1187, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-591, -1035, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-265, -1190, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(434, -598, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(290, -602, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-350, -169, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-364, -398, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-521, -240, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(242, -444, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-689, -1256, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-631, -1247, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-585, -1216, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-620, -1163, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-683, -1102, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-660, -1048, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-697, -993, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-637, -956, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-635, -994, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-543, -951, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-468, -962, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-414, -943, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-465, -1007, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-321, -1020, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-288, -1091, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-346, -1149, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-392, -1108, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-345, -1100, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-433, -1198, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-511, -1220, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-550, -1166, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-549, -1061, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-452, -1082, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-479, -1173, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-518, -1311, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-633, -1309, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-552, -1264, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-416, -1309, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-350, -1352, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-309, -1309, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-280, -1265, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-345, -1231, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-262, -1137, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-176, -1122, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-211, -1233, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-170, -1172, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-393, -1168, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-497, -1121, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-487, -1052, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-131, -1226, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(645, -1158, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(776, -1107, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(929, -1039, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(939, -1115, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1040, -1070, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1107, -994, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1183, -970, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1247, -984, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1270, -1009, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1305, -1070, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1310, -1191, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1283, -1307, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1114, -1305, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(989, -1225, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1145, -1190, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1065, -1263, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1062, -1140, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1167, -1097, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1239, -1160, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1186, -1247, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1366, -1114, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1368, -1228, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1100, -933, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1257, -919, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1173, -1058, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1007, -1016, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(688, -1214, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(560, -1294, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(440, -1376, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(351, -1348, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(281, -1331, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(222, -1263, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(191, -1188, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(196, -1106, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(253, -1030, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(310, -1001, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(310, -949, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(220, -976, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(412, -982, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(576, -983, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(577, -1065, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(481, -1183, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(272, -1156, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(382, -1082, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(397, -1173, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(322, -1271, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(455, -1292, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(407, -1248, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(466, -1108, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(459, -984, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(517, -953, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(508, -1052, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(545, -1137, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(564, -1242, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(330, -1211, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(310, -1107, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(260, -1214, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(253, -1107, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(165, -1058, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(200, -931, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(368, -580, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(428, -520, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(510, -505, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(574, -495, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(614, -379, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(545, -367, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(484, -403, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(464, -330, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(552, -237, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(619, -222, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(685, -248, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(764, -254, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(811, -301, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(756, -214, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(816, -414, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(732, -352, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(655, -347, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(612, -298, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(551, -312, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(706, -306, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(827, -466, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(839, -357, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(711, -487, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(747, -554, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(732, -458, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(772, -394, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(695, -617, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(579, -635, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(632, -646, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(575, -557, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(503, -681, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(522, -604, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(576, -386, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(646, -449, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(636, -557, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(549, -463, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(488, -483, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(468, -546, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(378, -641, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(362, -525, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(313, -480, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(359, -425, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(421, -384, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(817, -523, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(639, -513, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(683, -175, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(517, -275, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(630, -179, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(579, -431, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(310, -453, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-413, -118, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-502, -86, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-441, -183, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-585, -277, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-552, -336, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-498, -334, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-440, -268, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-358, -236, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-336, -204, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-420, -235, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-392, -313, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-398, -367, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-296, -418, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-326, -459, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-251, -373, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-251, -309, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-288, -250, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-348, -196, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-342, -310, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-287, -349, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-376, -279, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-486, -212, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-541, -151, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-546, -60, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-558, -240, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-866, 1143, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-814, 1058, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-777, 1023, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-813, 945, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-901, 944, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-997, 951, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-1041, 947, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-1123, 937, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-1180, 995, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-1147, 1050, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-1102, 1101, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-1048, 1106, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-969, 1116, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-914, 1111, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-873, 1085, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-879, 1032, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-1036, 1011, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-1112, 986, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-1073, 1045, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-948, 1036, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-949, 1157, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-1015, 1159, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-1126, 1139, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-1172, 1104, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-1192, 902, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-1087, 875, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-998, 1076, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-856, 976, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-953, 984, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-857, 879, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-767, 861, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-629, 860, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-661, 947, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-583, 914, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-522, 844, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-501, 932, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-323, 906, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-372, 810, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-371, 963, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-301, 998, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-270, 909, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-176, 885, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-142, 1031, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-75, 1000, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-100, 940, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-60, 869, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-71, 766, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-191, 794, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-373, 729, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-307, 813, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-245, 840, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-178, 688, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-72, 708, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-279, 650, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(-277, 829, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(902, 961, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(871, 866, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(944, 873, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(974, 956, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1045, 896, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(963, 913, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1022, 988, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1085, 917, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1166, 927, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1145, 992, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1240, 881, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1234, 957, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1312, 884, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1314, 799, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1373, 768, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1473, 802, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1525, 824, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1577, 856, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1619, 941, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1635, 1085, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1563, 1129, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1547, 1205, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1464, 1190, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1382, 1211, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1298, 1211, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1248, 1158, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1274, 1101, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1352, 1107, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1373, 1009, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1395, 935, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1325, 1049, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1450, 1015, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1496, 1093, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1542, 1023, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1553, 950, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1491, 881, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1428, 875, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1425, 970, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1278, 914, 35));
		AddSpawnPoint("f_huevillage_58_1.Id5", "f_huevillage_58_1", Rectangle(1187, 873, 35));

		// 'Doyor' GenType 31 Spawn Points
		AddSpawnPoint("f_huevillage_58_1.Id6", "f_huevillage_58_1", Rectangle(-576, -1294, 35));
		AddSpawnPoint("f_huevillage_58_1.Id6", "f_huevillage_58_1", Rectangle(-561, -1003, 35));
		AddSpawnPoint("f_huevillage_58_1.Id6", "f_huevillage_58_1", Rectangle(-234, -1316, 35));
		AddSpawnPoint("f_huevillage_58_1.Id6", "f_huevillage_58_1", Rectangle(-101, -1113, 35));
		AddSpawnPoint("f_huevillage_58_1.Id6", "f_huevillage_58_1", Rectangle(283, -554, 35));
		AddSpawnPoint("f_huevillage_58_1.Id6", "f_huevillage_58_1", Rectangle(472, -597, 35));
		AddSpawnPoint("f_huevillage_58_1.Id6", "f_huevillage_58_1", Rectangle(417, -457, 35));
		AddSpawnPoint("f_huevillage_58_1.Id6", "f_huevillage_58_1", Rectangle(-35, -406, 35));
		AddSpawnPoint("f_huevillage_58_1.Id6", "f_huevillage_58_1", Rectangle(-329, -334, 35));
		AddSpawnPoint("f_huevillage_58_1.Id6", "f_huevillage_58_1", Rectangle(-519, -272, 35));
		AddSpawnPoint("f_huevillage_58_1.Id6", "f_huevillage_58_1", Rectangle(-482, -137, 35));

		// 'Tipio' GenType 37 Spawn Points
		AddSpawnPoint("f_huevillage_58_1.Id7", "f_huevillage_58_1", Rectangle(-184, 746, 50));
		AddSpawnPoint("f_huevillage_58_1.Id7", "f_huevillage_58_1", Rectangle(-166, 972, 50));
		AddSpawnPoint("f_huevillage_58_1.Id7", "f_huevillage_58_1", Rectangle(-461, 904, 50));

		// 'Siaulav_Bow' GenType 44 Spawn Points
		AddSpawnPoint("f_huevillage_58_1.Id8", "f_huevillage_58_1", Rectangle(-168, -1259, 35));
		AddSpawnPoint("f_huevillage_58_1.Id8", "f_huevillage_58_1", Rectangle(-414, -1027, 35));
		AddSpawnPoint("f_huevillage_58_1.Id8", "f_huevillage_58_1", Rectangle(1371, 855, 35));
		AddSpawnPoint("f_huevillage_58_1.Id8", "f_huevillage_58_1", Rectangle(1412, 1144, 35));
		AddSpawnPoint("f_huevillage_58_1.Id8", "f_huevillage_58_1", Rectangle(-422, 895, 35));
		AddSpawnPoint("f_huevillage_58_1.Id8", "f_huevillage_58_1", Rectangle(-118, 850, 35));
		AddSpawnPoint("f_huevillage_58_1.Id8", "f_huevillage_58_1", Rectangle(-229, 1013, 35));
		AddSpawnPoint("f_huevillage_58_1.Id8", "f_huevillage_58_1", Rectangle(-713, 916, 35));
		AddSpawnPoint("f_huevillage_58_1.Id8", "f_huevillage_58_1", Rectangle(-276, 720, 35));
		AddSpawnPoint("f_huevillage_58_1.Id8", "f_huevillage_58_1", Rectangle(1217, 1013, 35));
		AddSpawnPoint("f_huevillage_58_1.Id8", "f_huevillage_58_1", Rectangle(1500, 992, 35));
		AddSpawnPoint("f_huevillage_58_1.Id8", "f_huevillage_58_1", Rectangle(-450, -325, 35));
		AddSpawnPoint("f_huevillage_58_1.Id8", "f_huevillage_58_1", Rectangle(-359, -143, 35));
		AddSpawnPoint("f_huevillage_58_1.Id8", "f_huevillage_58_1", Rectangle(-545, -185, 35));
		AddSpawnPoint("f_huevillage_58_1.Id8", "f_huevillage_58_1", Rectangle(-605, -1110, 35));
	}
}
