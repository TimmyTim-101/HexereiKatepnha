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
    public static readonly List<MaterialModel> AllMaterialCharacterWeaponEnhancement1 =
    [
        MaterialConstants._3030001, MaterialConstants._3030002, MaterialConstants._3030003, MaterialConstants._3030004, MaterialConstants._3030005, MaterialConstants._3030006, MaterialConstants._3030007, MaterialConstants._3030008,
        MaterialConstants._3030009, MaterialConstants._3030010, MaterialConstants._3030011, MaterialConstants._3030012, MaterialConstants._3030013, MaterialConstants._3030014, MaterialConstants._3030015, MaterialConstants._3030016,
        MaterialConstants._3030017, MaterialConstants._3030018, MaterialConstants._3030019, MaterialConstants._3030020, MaterialConstants._3030021, MaterialConstants._3030022, MaterialConstants._3030023, MaterialConstants._3030024,
        MaterialConstants._3030025, MaterialConstants._3030026, MaterialConstants._3030027, MaterialConstants._3030028, MaterialConstants._3030029, MaterialConstants._3030030, MaterialConstants._3030031, MaterialConstants._3030032,
        MaterialConstants._3030033, MaterialConstants._3030034, MaterialConstants._3030035, MaterialConstants._3030036, MaterialConstants._3030037, MaterialConstants._3030038, MaterialConstants._3030039, MaterialConstants._3030040,
        MaterialConstants._3030041, MaterialConstants._3030042, MaterialConstants._3030043, MaterialConstants._3030044, MaterialConstants._3030045, MaterialConstants._3030046, MaterialConstants._3030047, MaterialConstants._3030048,
        MaterialConstants._3030049, MaterialConstants._3030050, MaterialConstants._3030051, MaterialConstants._3030052, MaterialConstants._3030053, MaterialConstants._3030054, MaterialConstants._3030055, MaterialConstants._3030056,
        MaterialConstants._3030057, MaterialConstants._3030058, MaterialConstants._3030059, MaterialConstants._3030060, MaterialConstants._3030061, MaterialConstants._3030062, MaterialConstants._3030063, MaterialConstants._3030064,
        MaterialConstants._3030065, MaterialConstants._3030066, MaterialConstants._3030067, MaterialConstants._3030068, MaterialConstants._3030069, MaterialConstants._3030070, MaterialConstants._3030071, MaterialConstants._3030072,
        MaterialConstants._3030073, MaterialConstants._3030074, MaterialConstants._3030075, MaterialConstants._3030076, MaterialConstants._3030077, MaterialConstants._3030078, MaterialConstants._3030079, MaterialConstants._3030080,
        MaterialConstants._3030081, MaterialConstants._3030082, MaterialConstants._3030083, MaterialConstants._3030084,
    ];

    // 304 - 角色与武器培养素材_123
    public static readonly List<MaterialModel> AllMaterialCharacterWeaponEnhancement2 =
    [
        MaterialConstants._3040001, MaterialConstants._3040002, MaterialConstants._3040003, MaterialConstants._3040004, MaterialConstants._3040005, MaterialConstants._3040006, MaterialConstants._3040007, MaterialConstants._3040008,
        MaterialConstants._3040009, MaterialConstants._3040010, MaterialConstants._3040011, MaterialConstants._3040012, MaterialConstants._3040013, MaterialConstants._3040014, MaterialConstants._3040015, MaterialConstants._3040016,
        MaterialConstants._3040017, MaterialConstants._3040018, MaterialConstants._3040019, MaterialConstants._3040020, MaterialConstants._3040021, MaterialConstants._3040022, MaterialConstants._3040023, MaterialConstants._3040024,
        MaterialConstants._3040025, MaterialConstants._3040026, MaterialConstants._3040027, MaterialConstants._3040028, MaterialConstants._3040029, MaterialConstants._3040030, MaterialConstants._3040031, MaterialConstants._3040032,
        MaterialConstants._3040033, MaterialConstants._3040034, MaterialConstants._3040035, MaterialConstants._3040036, MaterialConstants._3040037, MaterialConstants._3040038, MaterialConstants._3040039, MaterialConstants._3040040,
        MaterialConstants._3040041, MaterialConstants._3040042, MaterialConstants._3040043, MaterialConstants._3040044, MaterialConstants._3040045, MaterialConstants._3040046, MaterialConstants._3040047, MaterialConstants._3040048,
        MaterialConstants._3040049, MaterialConstants._3040050, MaterialConstants._3040051,
    ];

    // 305 - 角色培养素材_周本
    public static readonly List<MaterialModel> AllMaterialCharacterLevelUp1 =
    [
        MaterialConstants._3050001, MaterialConstants._3050002, MaterialConstants._3050003, MaterialConstants._3050004, MaterialConstants._3050005, MaterialConstants._3050006, MaterialConstants._3050007, MaterialConstants._3050008,
        MaterialConstants._3050009, MaterialConstants._3050010, MaterialConstants._3050011, MaterialConstants._3050012, MaterialConstants._3050013, MaterialConstants._3050014, MaterialConstants._3050015, MaterialConstants._3050016,
        MaterialConstants._3050017, MaterialConstants._3050018, MaterialConstants._3050019, MaterialConstants._3050020, MaterialConstants._3050021, MaterialConstants._3050022, MaterialConstants._3050023, MaterialConstants._3050024,
        MaterialConstants._3050025, MaterialConstants._3050026, MaterialConstants._3050027, MaterialConstants._3050028, MaterialConstants._3050029, MaterialConstants._3050030, MaterialConstants._3050031, MaterialConstants._3050032,
        MaterialConstants._3050033, MaterialConstants._3050034, MaterialConstants._3050035, MaterialConstants._3050036, MaterialConstants._3050037,
    ];

    // 306 - 角色培养素材_40体力BOSS
    public static readonly List<MaterialModel> AllMaterialCharacterLevelUp2 =
    [
        MaterialConstants._3060001, MaterialConstants._3060002, MaterialConstants._3060003, MaterialConstants._3060004, MaterialConstants._3060005, MaterialConstants._3060006, MaterialConstants._3060007, MaterialConstants._3060008,
        MaterialConstants._3060009, MaterialConstants._3060010, MaterialConstants._3060011, MaterialConstants._3060012, MaterialConstants._3060013, MaterialConstants._3060014, MaterialConstants._3060015, MaterialConstants._3060016,
        MaterialConstants._3060017, MaterialConstants._3060018, MaterialConstants._3060019, MaterialConstants._3060020, MaterialConstants._3060021, MaterialConstants._3060022, MaterialConstants._3060023, MaterialConstants._3060024,
        MaterialConstants._3060025, MaterialConstants._3060026, MaterialConstants._3060027, MaterialConstants._3060028, MaterialConstants._3060029, MaterialConstants._3060030, MaterialConstants._3060031, MaterialConstants._3060032,
        MaterialConstants._3060033, MaterialConstants._3060034, MaterialConstants._3060035, MaterialConstants._3060036, MaterialConstants._3060037, MaterialConstants._3060038, MaterialConstants._3060039, MaterialConstants._3060040,
        MaterialConstants._3060041, MaterialConstants._3060042,
    ];

    // 307 - 角色突破素材_钻儿块儿片儿粒儿
    public static readonly List<MaterialModel> AllMaterialCharacterAscension =
    [
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
    public static readonly List<MaterialModel> AllMaterialCharacterTalent =
    [
        MaterialConstants._3080001, MaterialConstants._3080002, MaterialConstants._3080003, MaterialConstants._3080004, MaterialConstants._3080005, MaterialConstants._3080006, MaterialConstants._3080007, MaterialConstants._3080008,
        MaterialConstants._3080009, MaterialConstants._3080010, MaterialConstants._3080011, MaterialConstants._3080012, MaterialConstants._3080013, MaterialConstants._3080014, MaterialConstants._3080015, MaterialConstants._3080016,
        MaterialConstants._3080017, MaterialConstants._3080018, MaterialConstants._3080019, MaterialConstants._3080020, MaterialConstants._3080021, MaterialConstants._3080022, MaterialConstants._3080023, MaterialConstants._3080024,
        MaterialConstants._3080025, MaterialConstants._3080026, MaterialConstants._3080027, MaterialConstants._3080028, MaterialConstants._3080029, MaterialConstants._3080030, MaterialConstants._3080031, MaterialConstants._3080032,
        MaterialConstants._3080033, MaterialConstants._3080034, MaterialConstants._3080035, MaterialConstants._3080036, MaterialConstants._3080037, MaterialConstants._3080038, MaterialConstants._3080039, MaterialConstants._3080040,
        MaterialConstants._3080041, MaterialConstants._3080042, MaterialConstants._3080043, MaterialConstants._3080044, MaterialConstants._3080045, MaterialConstants._3080046, MaterialConstants._3080047, MaterialConstants._3080048,
        MaterialConstants._3080049, MaterialConstants._3080050, MaterialConstants._3080051, MaterialConstants._3080052, MaterialConstants._3080053, MaterialConstants._3080054, MaterialConstants._3080055, MaterialConstants._3080056,
        MaterialConstants._3080057, MaterialConstants._3080058, MaterialConstants._3080059, MaterialConstants._3080060, MaterialConstants._3080061, MaterialConstants._3080062, MaterialConstants._3080063,
        MaterialConstants._3080000,
    ];

    // 309 - 武器突破素材
    public static readonly List<MaterialModel> AllMaterialWeaponAscension =
    [
        MaterialConstants._3090001, MaterialConstants._3090002, MaterialConstants._3090003, MaterialConstants._3090004, MaterialConstants._3090005, MaterialConstants._3090006, MaterialConstants._3090007, MaterialConstants._3090008,
        MaterialConstants._3090009, MaterialConstants._3090010, MaterialConstants._3090011, MaterialConstants._3090012, MaterialConstants._3090013, MaterialConstants._3090014, MaterialConstants._3090015, MaterialConstants._3090016,
        MaterialConstants._3090017, MaterialConstants._3090018, MaterialConstants._3090019, MaterialConstants._3090020, MaterialConstants._3090021, MaterialConstants._3090022, MaterialConstants._3090023, MaterialConstants._3090024,
        MaterialConstants._3090025, MaterialConstants._3090026, MaterialConstants._3090027, MaterialConstants._3090028, MaterialConstants._3090029, MaterialConstants._3090030, MaterialConstants._3090031, MaterialConstants._3090032,
        MaterialConstants._3090033, MaterialConstants._3090034, MaterialConstants._3090035, MaterialConstants._3090036, MaterialConstants._3090037, MaterialConstants._3090038, MaterialConstants._3090039, MaterialConstants._3090040,
        MaterialConstants._3090041, MaterialConstants._3090042, MaterialConstants._3090043, MaterialConstants._3090044, MaterialConstants._3090045, MaterialConstants._3090046, MaterialConstants._3090047, MaterialConstants._3090048,
        MaterialConstants._3090049, MaterialConstants._3090050, MaterialConstants._3090051, MaterialConstants._3090052, MaterialConstants._3090053, MaterialConstants._3090054, MaterialConstants._3090055, MaterialConstants._3090056,
        MaterialConstants._3090057, MaterialConstants._3090058, MaterialConstants._3090059, MaterialConstants._3090060, MaterialConstants._3090061, MaterialConstants._3090062, MaterialConstants._3090063, MaterialConstants._3090064,
        MaterialConstants._3090065, MaterialConstants._3090066, MaterialConstants._3090067, MaterialConstants._3090068, MaterialConstants._3090069, MaterialConstants._3090070, MaterialConstants._3090071, MaterialConstants._3090072,
        MaterialConstants._3090073, MaterialConstants._3090074, MaterialConstants._3090075, MaterialConstants._3090076, MaterialConstants._3090077, MaterialConstants._3090078, MaterialConstants._3090079, MaterialConstants._3090080,
        MaterialConstants._3090081, MaterialConstants._3090082, MaterialConstants._3090083, MaterialConstants._3090084,
    ];

    // 310 - 地方特产
    public static readonly List<MaterialModel> AllMaterialLocalSpecialty =
    [
        // 31001 - 蒙德地方特产
        MaterialConstants._3100101, MaterialConstants._3100102, MaterialConstants._3100103, MaterialConstants._3100104, MaterialConstants._3100105, MaterialConstants._3100106, MaterialConstants._3100107, MaterialConstants._3100108,
        // 31002 - 璃月地方特产
        MaterialConstants._3100201, MaterialConstants._3100202, MaterialConstants._3100203, MaterialConstants._3100204, MaterialConstants._3100205, MaterialConstants._3100206, MaterialConstants._3100207, MaterialConstants._3100208, MaterialConstants._3100209,
        // 31003 - 稻妻地方特产
        MaterialConstants._3100301, MaterialConstants._3100302, MaterialConstants._3100303, MaterialConstants._3100304, MaterialConstants._3100305, MaterialConstants._3100306, MaterialConstants._3100307, MaterialConstants._3100308, MaterialConstants._3100309,
        // 31004 - 须弥地方特产
        MaterialConstants._3100401, MaterialConstants._3100402, MaterialConstants._3100403, MaterialConstants._3100404, MaterialConstants._3100405, MaterialConstants._3100406, MaterialConstants._3100407, MaterialConstants._3100408, MaterialConstants._3100409,
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
    // 401 - 地方特产
    public static readonly List<DungeonModel> AllDungeonLocalSpecialty =
    [
        DungeonConstants._4010001, DungeonConstants._4010002, DungeonConstants._4010003, DungeonConstants._4010004, DungeonConstants._4010005, DungeonConstants._4010006, DungeonConstants._4010007,
    ];

    // 402 - 地脉衍出
    public static readonly List<DungeonModel> AllDungeonLeyLineOutcrop = [DungeonConstants._4020001, DungeonConstants._4020002];

    // 403 - 普通怪物
    public static readonly List<DungeonModel> AllDungeonEasy =
    [
        DungeonConstants._4030001, DungeonConstants._4030002, DungeonConstants._4030003, DungeonConstants._4030004, DungeonConstants._4030005, DungeonConstants._4030006, DungeonConstants._4030007, DungeonConstants._4030008,
        DungeonConstants._4030009, DungeonConstants._4030010, DungeonConstants._4030011, DungeonConstants._4030012, DungeonConstants._4030013, DungeonConstants._4030014, DungeonConstants._4030015, DungeonConstants._4030016,
        DungeonConstants._4030017,
    ];

    // 404 - 精英怪物
    public static readonly List<DungeonModel> AllDungeonElite =
    [
        DungeonConstants._4040001, DungeonConstants._4040002, DungeonConstants._4040003, DungeonConstants._4040004, DungeonConstants._4040005, DungeonConstants._4040006, DungeonConstants._4040007, DungeonConstants._4040008,
        DungeonConstants._4040009, DungeonConstants._4040010, DungeonConstants._4040011, DungeonConstants._4040012, DungeonConstants._4040013, DungeonConstants._4040014, DungeonConstants._4040015, DungeonConstants._4040016,
        DungeonConstants._4040017, DungeonConstants._4040018, DungeonConstants._4040019, DungeonConstants._4040020, DungeonConstants._4040021, DungeonConstants._4040022, DungeonConstants._4040023, DungeonConstants._4040024,
        DungeonConstants._4040025, DungeonConstants._4040026, DungeonConstants._4040027, DungeonConstants._4040028, DungeonConstants._4040029, DungeonConstants._4040030, DungeonConstants._4040031,
    ];

    // 405 - 40体力BOSS
    public static readonly List<DungeonModel> AllDungeonBoss =
    [
        DungeonConstants._4050001, DungeonConstants._4050002, DungeonConstants._4050003, DungeonConstants._4050004, DungeonConstants._4050005, DungeonConstants._4050006, DungeonConstants._4050007, DungeonConstants._4050008,
        DungeonConstants._4050009, DungeonConstants._4050010, DungeonConstants._4050011, DungeonConstants._4050012, DungeonConstants._4050013, DungeonConstants._4050014, DungeonConstants._4050015, DungeonConstants._4050016,
        DungeonConstants._4050017, DungeonConstants._4050018, DungeonConstants._4050019, DungeonConstants._4050020, DungeonConstants._4050021, DungeonConstants._4050022, DungeonConstants._4050023, DungeonConstants._4050024,
        DungeonConstants._4050025, DungeonConstants._4050026, DungeonConstants._4050027, DungeonConstants._4050028, DungeonConstants._4050029, DungeonConstants._4050030, DungeonConstants._4050031, DungeonConstants._4050032,
        DungeonConstants._4050033, DungeonConstants._4050034, DungeonConstants._4050035, DungeonConstants._4050036, DungeonConstants._4050037, DungeonConstants._4050038, DungeonConstants._4050039, DungeonConstants._4050040,
        DungeonConstants._4050041
    ];

    // 406 - 圣遗物
    public static readonly List<DungeonModel> AllDungeonArtifact = [];

    // 407 - 武器
    public static readonly List<DungeonModel> AllDungeonWeaponAscension = [];

    // 408 - 天赋
    public static readonly List<DungeonModel> AllDungeonCharacterTalent = [];

    // 409 - 60体力BOSS
    public static readonly List<DungeonModel> AllDungeonTrounce =
    [
        DungeonConstants._4090001, DungeonConstants._4090002, DungeonConstants._4090003, DungeonConstants._4090004, DungeonConstants._4090005, DungeonConstants._4090006, DungeonConstants._4090007, DungeonConstants._4090008,
        DungeonConstants._4090009, DungeonConstants._4090010, DungeonConstants._4090011, DungeonConstants._4090012,
    ];

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

    // 所有group
    public static readonly List<MaterialGroupModel> AllGroup =
    [
        // 303 - 角色与武器培养素材_234
        MaterialConstants.G3030001, MaterialConstants.G3030004, MaterialConstants.G3030007, MaterialConstants.G3030010, MaterialConstants.G3030013, MaterialConstants.G3030016, MaterialConstants.G3030019, MaterialConstants.G3030022,
        MaterialConstants.G3030025, MaterialConstants.G3030028, MaterialConstants.G3030031, MaterialConstants.G3030034, MaterialConstants.G3030037, MaterialConstants.G3030040, MaterialConstants.G3030043, MaterialConstants.G3030046,
        MaterialConstants.G3030049, MaterialConstants.G3030052, MaterialConstants.G3030055, MaterialConstants.G3030058, MaterialConstants.G3030061, MaterialConstants.G3030064, MaterialConstants.G3030067, MaterialConstants.G3030070,
        MaterialConstants.G3030073, MaterialConstants.G3030076, MaterialConstants.G3030079, MaterialConstants.G3030082,
        // 304 - 角色与武器培养素材_123
        MaterialConstants.G3040001, MaterialConstants.G3040004, MaterialConstants.G3040007, MaterialConstants.G3040010, MaterialConstants.G3040013, MaterialConstants.G3040016, MaterialConstants.G3040019, MaterialConstants.G3040022,
        MaterialConstants.G3040025, MaterialConstants.G3040028, MaterialConstants.G3040031, MaterialConstants.G3040034, MaterialConstants.G3040037, MaterialConstants.G3040040, MaterialConstants.G3040043, MaterialConstants.G3040046,
        MaterialConstants.G3040049,
        // 307 - 角色突破素材_钻儿块儿片儿粒儿
        MaterialConstants.G3070101, MaterialConstants.G3070201, MaterialConstants.G3070301, MaterialConstants.G3070401, MaterialConstants.G3070501, MaterialConstants.G3070601, MaterialConstants.G3070701, MaterialConstants.G3070801,
        // 308 - 角色天赋素材
        MaterialConstants.G3080001, MaterialConstants.G3080004, MaterialConstants.G3080007, MaterialConstants.G3080010, MaterialConstants.G3080013, MaterialConstants.G3080016, MaterialConstants.G3080019, MaterialConstants.G3080022,
        MaterialConstants.G3080025, MaterialConstants.G3080028, MaterialConstants.G3080031, MaterialConstants.G3080034, MaterialConstants.G3080037, MaterialConstants.G3080040, MaterialConstants.G3080043, MaterialConstants.G3080046,
        MaterialConstants.G3080049, MaterialConstants.G3080052, MaterialConstants.G3080055, MaterialConstants.G3080058, MaterialConstants.G3080061,
        // 309 - 武器突破素材
        MaterialConstants.G3090001, MaterialConstants.G3090005, MaterialConstants.G3090009, MaterialConstants.G3090013, MaterialConstants.G3090017, MaterialConstants.G3090021, MaterialConstants.G3090025, MaterialConstants.G3090029,
        MaterialConstants.G3090033, MaterialConstants.G3090037, MaterialConstants.G3090041, MaterialConstants.G3090045, MaterialConstants.G3090049, MaterialConstants.G3090053, MaterialConstants.G3090057, MaterialConstants.G3090061,
        MaterialConstants.G3090065, MaterialConstants.G3090069, MaterialConstants.G3090073, MaterialConstants.G3090077, MaterialConstants.G3090081,
    ];
}