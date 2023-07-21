//--- Melia Script -----------------------------------------------------------
// Shaton Reservoir Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_farm_49_3'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FFarm493MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_farm_49_3.Id1", MonsterId.Melatanun, 38, 50, TimeSpan.FromMilliseconds(20000), TendencyType.Aggressive);
		AddSpawner("f_farm_49_3.Id2", MonsterId.Melatanun, 19, 25, TimeSpan.FromMilliseconds(30000), TendencyType.Aggressive);
		AddSpawner("f_farm_49_3.Id3", MonsterId.Carcashu_Green, 38, 50, TimeSpan.FromMilliseconds(20000), TendencyType.Aggressive);
		AddSpawner("f_farm_49_3.Id4", MonsterId.Tree_Root_Mole_Pink, 12, 15, TimeSpan.FromMilliseconds(30000), TendencyType.Aggressive);
		AddSpawner("f_farm_49_3.Id5", MonsterId.Tree_Root_Mole_Pink, 12, 15, TimeSpan.FromMilliseconds(35000), TendencyType.Aggressive);
		AddSpawner("f_farm_49_3.Id6", MonsterId.Rootcrystal_01, 8, 10, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Melatanun' GenType 2 Spawn Points
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(868, -744, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(800, -540, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(-62, -635, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(36, -520, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(187, -637, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(-53, -218, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(42, -11, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(-176, -124, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(1509, -99, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(1599, 40, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(1429, 51, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(84, -644, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(116, -188, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(-61, -84, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(18, -778, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(1509, -244, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(1501, 172, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(1646, -161, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(783, -130, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(812, -229, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(1083, -55, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(695, -205, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(613, -182, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(612, -245, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(612, -68, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(718, 12, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(770, 93, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(856, 144, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(986, 2, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(986, -138, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(798, -37, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(891, -145, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(1093, -741, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(970, -772, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(832, -899, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(789, -834, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(826, -649, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(1027, -608, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(966, -574, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(995, -510, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(1040, -509, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(997, -457, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(898, -434, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(732, -444, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(718, -637, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(824, -445, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(922, -675, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(-127, -533, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(136, -54, 25));
		AddSpawnPoint("f_farm_49_3.Id1", "f_farm_49_3", Rectangle(-93, 36, 25));

		// 'Melatanun' GenType 5 Spawn Points
		AddSpawnPoint("f_farm_49_3.Id2", "f_farm_49_3", Rectangle(705, -83, 9999));

		// 'Carcashu_Green' GenType 6 Spawn Points
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(307, -443, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(-183, -233, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(-81, 27, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(1438, 60, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(1627, 231, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(1572, 122, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(1665, 117, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(1641, 37, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(1652, -77, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(1676, -196, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(1561, -213, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(1460, -143, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(1565, -118, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(1497, 162, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(1421, 176, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(1351, 60, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(1338, -42, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(1392, -129, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(1413, -18, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(1479, -70, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(1538, 30, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(252, -746, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(172, -798, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(84, -844, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(174, -708, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(224, -621, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(350, -509, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(197, -485, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(78, -614, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(116, -493, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(-19, -465, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(-27, -786, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(-25, -646, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(-141, -733, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(-82, -590, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(-62, -518, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(-151, -517, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(-195, -596, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(36, -114, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(78, -5, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(140, -146, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(120, -244, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(38, -292, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(-109, -301, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(-173, -231, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(-85, -223, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(-74, -130, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(27, 44, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(-11, -42, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(-15, 62, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(-172, -84, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(-148, 21, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(-187, -15, 25));
		AddSpawnPoint("f_farm_49_3.Id3", "f_farm_49_3", Rectangle(-240, -125, 25));

		// 'Tree_Root_Mole_Pink' GenType 54 Spawn Points
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1430, 1029, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1474, 1225, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1328, 1400, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1257, 1187, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-469, 1706, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-371, 1947, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(68, 1785, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-189, 1699, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-185, 1870, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1155, -1058, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1432, -1292, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1322, -1451, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1770, -201, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1629, 42, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1452, -235, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1365, 2, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1167, -869, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1563, -102, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1863, -57, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1583, 1414, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(71, 1950, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(92, 1851, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(119, 1906, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(142, 1812, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(139, 1757, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(87, 1701, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(46, 1655, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-18, 1666, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-80, 1685, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-47, 1720, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(15, 1707, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(60, 1734, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(12, 1835, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-9, 1764, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-60, 1845, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(25, 1918, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-39, 1916, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-10, 2000, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-29, 2086, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-100, 2073, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-91, 2013, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-116, 1957, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-149, 1895, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-114, 1775, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-209, 1728, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-174, 1778, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-130, 1844, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-166, 2066, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-161, 2004, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-251, 1997, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-285, 1945, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-285, 1875, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-317, 1798, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-287, 1698, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-229, 1637, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-173, 1638, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-235, 1553, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-318, 1596, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-369, 1692, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-417, 1628, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-419, 1769, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-362, 1866, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-458, 1854, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-431, 1914, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-532, 1879, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-549, 1824, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-518, 1796, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-575, 1709, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-506, 1738, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-540, 1682, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-422, 1709, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1359, 1526, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1343, 1472, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1411, 1575, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1470, 1559, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1524, 1520, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1548, 1458, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1566, 1346, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1637, 1330, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1622, 1380, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1515, 1212, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1479, 1336, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1387, 1355, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1286, 1281, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1346, 1179, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1223, 1123, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1147, 1154, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1273, 1049, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1349, 964, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1414, 919, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1484, 920, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1510, 1021, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1512, 1177, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1378, 1150, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1328, 1088, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1349, 1032, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1291, 1158, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1420, 1102, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1516, 1091, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1467, 1147, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1586, 1166, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1554, 1283, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1490, 1295, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1429, 1312, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1375, 1304, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1295, 1357, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1238, 1327, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1248, 1261, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1172, 1264, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1335, 1326, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1452, 1407, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1531, 1401, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1578, 1246, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1552, 1147, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1478, 1080, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1218, 1073, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1407, 42, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1446, 113, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1536, 116, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1539, 31, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1465, 14, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1326, -46, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1234, -80, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1276, -117, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1320, -211, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1381, -298, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1420, -360, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1487, -363, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1494, -290, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1500, -184, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1418, -137, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1402, -201, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1351, -104, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1436, -47, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1528, -36, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1505, -111, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1596, -174, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1677, -121, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1759, -111, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1842, -234, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1895, -321, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1942, -242, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1940, -116, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1903, -156, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1837, -146, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1790, -45, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1825, 9, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1721, 19, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1630, 0, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1688, -46, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1610, -37, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1076, -904, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1217, -822, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1232, -886, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1159, -926, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1079, -974, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1084, -799, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-981, -834, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-970, -900, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-976, -943, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-961, -1022, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1015, -1099, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1072, -1137, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1101, -1211, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1105, -1292, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1156, -1399, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1241, -1497, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1386, -1488, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1499, -1420, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1564, -1329, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1595, -1206, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1487, -1145, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1394, -1135, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1318, -1214, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1263, -1288, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1248, -1371, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1211, -1323, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1203, -1214, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1293, -1150, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1269, -1058, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1218, -947, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1289, -923, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1177, -990, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1222, -1035, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1068, -1048, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1018, -948, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1134, -1139, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1339, -1337, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1430, -1396, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1533, -1281, 30));
		AddSpawnPoint("f_farm_49_3.Id4", "f_farm_49_3", Rectangle(-1445, -1203, 30));

		// 'Tree_Root_Mole_Pink' GenType 57 Spawn Points
		AddSpawnPoint("f_farm_49_3.Id5", "f_farm_49_3", Rectangle(-1210, -1135, 9999));

		// 'Rootcrystal_01' GenType 58 Spawn Points
		AddSpawnPoint("f_farm_49_3.Id6", "f_farm_49_3", Rectangle(879, -626, 50));
		AddSpawnPoint("f_farm_49_3.Id6", "f_farm_49_3", Rectangle(38, -652, 50));
		AddSpawnPoint("f_farm_49_3.Id6", "f_farm_49_3", Rectangle(-11, -242, 50));
		AddSpawnPoint("f_farm_49_3.Id6", "f_farm_49_3", Rectangle(1480, -52, 50));
		AddSpawnPoint("f_farm_49_3.Id6", "f_farm_49_3", Rectangle(-1107, -1103, 50));
		AddSpawnPoint("f_farm_49_3.Id6", "f_farm_49_3", Rectangle(-1373, -1370, 50));
		AddSpawnPoint("f_farm_49_3.Id6", "f_farm_49_3", Rectangle(-1817, -845, 50));
		AddSpawnPoint("f_farm_49_3.Id6", "f_farm_49_3", Rectangle(-1843, -126, 50));
		AddSpawnPoint("f_farm_49_3.Id6", "f_farm_49_3", Rectangle(-1403, -189, 50));
		AddSpawnPoint("f_farm_49_3.Id6", "f_farm_49_3", Rectangle(-1426, 1148, 50));
		AddSpawnPoint("f_farm_49_3.Id6", "f_farm_49_3", Rectangle(-852, 804, 50));
		AddSpawnPoint("f_farm_49_3.Id6", "f_farm_49_3", Rectangle(-346, 1871, 50));
		AddSpawnPoint("f_farm_49_3.Id6", "f_farm_49_3", Rectangle(-13, 1837, 50));
		AddSpawnPoint("f_farm_49_3.Id6", "f_farm_49_3", Rectangle(968, 1254, 50));
	}
}