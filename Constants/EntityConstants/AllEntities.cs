using HexereiKatepnha.Models.EntityModels;

namespace HexereiKatepnha.Constants.EntityConstants;

public static class AllEntities
{
    // 1 - 角色

    // 2 - 武器
    // 3 - 材料
    // 301 - 摩拉
    public static readonly List<MaterialModel> AllMaterialMora = [MaterialConstants._3010001];

    // 302 - 角色经验素材
    public static readonly List<MaterialModel> AllMaterialCharacterExp = [MaterialConstants._3020001, MaterialConstants._3020002, MaterialConstants._3020003];

    // 303 - 角色与武器培养素材_234
    public static readonly List<MaterialModel> AllMaterialCharacterWeaponEnhancement1 = [];

    // 304 - 角色与武器培养素材_123
    public static readonly List<MaterialModel> AllMaterialCharacterWeaponEnhancement2 = [];

    // 305 - 角色培养素材_周本
    public static readonly List<MaterialModel> AllMaterialCharacterLevelUp1 = [
        MaterialConstants._3050001, MaterialConstants._3050002, MaterialConstants._3050003, MaterialConstants._3050004, MaterialConstants._3050005, MaterialConstants._3050006, MaterialConstants._3050007, MaterialConstants._3050008, 
        MaterialConstants._3050009, MaterialConstants._3050010, MaterialConstants._3050011, MaterialConstants._3050012, MaterialConstants._3050013, MaterialConstants._3050014, MaterialConstants._3050015, MaterialConstants._3050016, 
        MaterialConstants._3050017, MaterialConstants._3050018, MaterialConstants._3050019, MaterialConstants._3050020, MaterialConstants._3050021, MaterialConstants._3050022, MaterialConstants._3050023, MaterialConstants._3050024, 
        MaterialConstants._3050025, MaterialConstants._3050026, MaterialConstants._3050027, MaterialConstants._3050028, MaterialConstants._3050029, MaterialConstants._3050030, MaterialConstants._3050031, MaterialConstants._3050032, 
        MaterialConstants._3050033, MaterialConstants._3050034, MaterialConstants._3050035, MaterialConstants._3050036, MaterialConstants._3050037,
    ];

    // 306 - 角色培养素材_40体力BOSS
    public static readonly List<MaterialModel> AllMaterialCharacterLevelUp2 = [
        MaterialConstants._3060001, MaterialConstants._3060002, MaterialConstants._3060003, MaterialConstants._3060004, MaterialConstants._3060005, MaterialConstants._3060006, MaterialConstants._3060007, MaterialConstants._3060008, 
        MaterialConstants._3060009, MaterialConstants._3060010, MaterialConstants._3060011, MaterialConstants._3060012, MaterialConstants._3060013, MaterialConstants._3060014, MaterialConstants._3060015, MaterialConstants._3060016, 
        MaterialConstants._3060017, MaterialConstants._3060018, MaterialConstants._3060019, MaterialConstants._3060020, MaterialConstants._3060021, MaterialConstants._3060022, MaterialConstants._3060023, MaterialConstants._3060024, 
        MaterialConstants._3060025, MaterialConstants._3060026, MaterialConstants._3060027, MaterialConstants._3060028, MaterialConstants._3060029, MaterialConstants._3060030, MaterialConstants._3060031, MaterialConstants._3060032, 
        MaterialConstants._3060033, MaterialConstants._3060034, MaterialConstants._3060035, MaterialConstants._3060036, MaterialConstants._3060037, MaterialConstants._3060038, MaterialConstants._3060039, MaterialConstants._3060040, 
        MaterialConstants._3060041, MaterialConstants._3060042,
    ];

    // 307 - 角色突破素材_钻儿块儿片儿粒儿
    public static readonly List<MaterialModel> AllMaterialCharacterAscension = [
        MaterialConstants._3070101, MaterialConstants._3070102, MaterialConstants._3070103, MaterialConstants._3070104, // 30701 - 旅行者 
        MaterialConstants._3070201, MaterialConstants._3070202, MaterialConstants._3070203, MaterialConstants._3070204, // 30702 - 火
        MaterialConstants._3070301, MaterialConstants._3070302, MaterialConstants._3070303, MaterialConstants._3070304, // 30703 - 水
        MaterialConstants._3070401, MaterialConstants._3070402, MaterialConstants._3070403, MaterialConstants._3070404, // 30704 - 草
        MaterialConstants._3070501, MaterialConstants._3070502, MaterialConstants._3070503, MaterialConstants._3070504, // 30705 - 雷
        MaterialConstants._3070601, MaterialConstants._3070602, MaterialConstants._3070603, MaterialConstants._3070604, // 30706 - 风
        MaterialConstants._3070701, MaterialConstants._3070702, MaterialConstants._3070703, MaterialConstants._3070704, // 30707 - 冰
        MaterialConstants._3070801, MaterialConstants._3070802, MaterialConstants._3070803, MaterialConstants._3070804, // 30708 - 岩
    ];

    // 308 - 角色天赋素材
    public static readonly List<MaterialModel> AllMaterialCharacterTalent = [];

    // 309 - 武器突破素材
    public static readonly List<MaterialModel> AllMaterialWeaponAscension = [];

    // 310 - 地方特产
    public static readonly List<MaterialModel> AllMaterialLocalSpecialty =
    [
        // 31001 - 蒙德地方特产
        MaterialConstants._3100101, MaterialConstants._3100102, MaterialConstants._3100103, MaterialConstants._3100104, MaterialConstants._3100105, MaterialConstants._3100106, MaterialConstants._3100107, MaterialConstants._3100108,
        // 31002 - 璃月地方特产
        MaterialConstants._3100201, MaterialConstants._3100202, MaterialConstants._3100203, MaterialConstants._3100204, MaterialConstants._3100205, MaterialConstants._3100206, MaterialConstants._3100207, MaterialConstants._3100208,MaterialConstants._3100209,
        // 31003 - 稻妻地方特产
        MaterialConstants._3100301, MaterialConstants._3100302, MaterialConstants._3100303, MaterialConstants._3100304, MaterialConstants._3100305, MaterialConstants._3100306, MaterialConstants._3100307, MaterialConstants._3100308,MaterialConstants._3100309,
        // 31004 - 须弥地方特产
        MaterialConstants._3100401, MaterialConstants._3100402, MaterialConstants._3100403, MaterialConstants._3100404, MaterialConstants._3100405, MaterialConstants._3100406, MaterialConstants._3100407, MaterialConstants._3100408,MaterialConstants._3100409,
        // 31005 - 枫丹地方特产
        MaterialConstants._3100501, MaterialConstants._3100502, MaterialConstants._3100503, MaterialConstants._3100504, MaterialConstants._3100505, MaterialConstants._3100506, MaterialConstants._3100507, MaterialConstants._3100508,
        // 31006 - 纳塔地方特产
        MaterialConstants._3100601, MaterialConstants._3100602, MaterialConstants._3100603, MaterialConstants._3100604, MaterialConstants._3100605, MaterialConstants._3100606, MaterialConstants._3100607, MaterialConstants._3100608,
        // 31007 - 挪德卡莱地方特产
        MaterialConstants._3100701, MaterialConstants._3100702, MaterialConstants._3100703,
    ];

    // 311 - 武器强化素材
    public static readonly List<MaterialModel> AllMaterialWeaponExp = [MaterialConstants._3110001, MaterialConstants._3110002, MaterialConstants._3110003];

    // 4 - 秘境
    // 5 - 圣遗物
    public static readonly List<ArtifactSetModel> AllArtifactSetEntities =
    [
        ArtifactConstants._501, ArtifactConstants._502, ArtifactConstants._503, ArtifactConstants._504, ArtifactConstants._505, ArtifactConstants._506, ArtifactConstants._507, ArtifactConstants._508,
        ArtifactConstants._509, ArtifactConstants._510, ArtifactConstants._511, ArtifactConstants._512, ArtifactConstants._513, ArtifactConstants._514, ArtifactConstants._515, ArtifactConstants._516,
        ArtifactConstants._517, ArtifactConstants._518, ArtifactConstants._519, ArtifactConstants._520, ArtifactConstants._521, ArtifactConstants._522, ArtifactConstants._523, ArtifactConstants._524,
        ArtifactConstants._525, ArtifactConstants._526, ArtifactConstants._527, ArtifactConstants._528, ArtifactConstants._529, ArtifactConstants._530, ArtifactConstants._531, ArtifactConstants._532,
        ArtifactConstants._533, ArtifactConstants._534, ArtifactConstants._535, ArtifactConstants._536, ArtifactConstants._537, ArtifactConstants._538, ArtifactConstants._539, ArtifactConstants._540,
        ArtifactConstants._541, ArtifactConstants._542, ArtifactConstants._543, ArtifactConstants._544, ArtifactConstants._545, ArtifactConstants._546, ArtifactConstants._547, ArtifactConstants._548,
        ArtifactConstants._549, ArtifactConstants._550, ArtifactConstants._551, ArtifactConstants._552, ArtifactConstants._553, ArtifactConstants._554, ArtifactConstants._555, ArtifactConstants._556,
        ArtifactConstants._557,
    ];
}