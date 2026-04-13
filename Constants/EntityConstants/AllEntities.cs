using HexereiKatepnha.Constants.EntityConstants.CharacterConstants;
using HexereiKatepnha.Constants.EntityConstants.MaterialConstants;
using HexereiKatepnha.Constants.EntityConstants.WeaponConstants;
using HexereiKatepnha.Models.EntityModels;

namespace HexereiKatepnha.Constants.EntityConstants;

public static class AllEntities
{
    // 1 - 角色
    public static readonly List<CharacterModel> AllCharacter =
    [
        CharacterConstantsPage12._1010112, CharacterConstantsPage12._1010111,
        CharacterConstantsPage11._1010110, CharacterConstantsPage11._1010109, CharacterConstantsPage11._1010108, CharacterConstantsPage11._1010107, CharacterConstantsPage11._1010106,
        CharacterConstantsPage11._1010105, CharacterConstantsPage11._1010104, CharacterConstantsPage11._1010103, CharacterConstantsPage11._1010102, CharacterConstantsPage11._1010101,
        CharacterConstantsPage10._1010100, CharacterConstantsPage10._1010099, CharacterConstantsPage10._1010098, CharacterConstantsPage10._1010097, CharacterConstantsPage10._1010096,
        CharacterConstantsPage10._1010095, CharacterConstantsPage10._1010094, CharacterConstantsPage10._1010093, CharacterConstantsPage10._1010092, CharacterConstantsPage10._1010091,
        CharacterConstantsPage09._1010090, CharacterConstantsPage09._1010089, CharacterConstantsPage09._1010088, CharacterConstantsPage09._1010087, CharacterConstantsPage09._1010086,
        CharacterConstantsPage09._1010085, CharacterConstantsPage09._1010084, CharacterConstantsPage09._1010083, CharacterConstantsPage09._1010082, CharacterConstantsPage09._1010081,
        CharacterConstantsPage08._1010080, CharacterConstantsPage08._1010079, CharacterConstantsPage08._1010078, CharacterConstantsPage08._1010077, CharacterConstantsPage08._1010076,
        CharacterConstantsPage08._1010075, CharacterConstantsPage08._1010074, CharacterConstantsPage08._1010073, CharacterConstantsPage08._1010072, CharacterConstantsPage08._1010071,
        CharacterConstantsPage07._1010070, CharacterConstantsPage07._1010069, CharacterConstantsPage07._1010068, CharacterConstantsPage07._1010067, CharacterConstantsPage07._1010066,
        CharacterConstantsPage07._1010065, CharacterConstantsPage07._1010064, CharacterConstantsPage07._1010063, CharacterConstantsPage07._1010062, CharacterConstantsPage07._1010061,
        CharacterConstantsPage06._1010060, CharacterConstantsPage06._1010059, CharacterConstantsPage06._1010058, CharacterConstantsPage06._1010057, CharacterConstantsPage06._1010056,
        CharacterConstantsPage06._1010055, CharacterConstantsPage06._1010054, CharacterConstantsPage06._1010053, CharacterConstantsPage06._1010052, CharacterConstantsPage06._1010051,
        CharacterConstantsPage05._1010050, CharacterConstantsPage05._1010049, CharacterConstantsPage05._1010048, CharacterConstantsPage05._1010047, CharacterConstantsPage05._1010046,
        CharacterConstantsPage05._1010045, CharacterConstantsPage05._1010044, CharacterConstantsPage05._1010043, CharacterConstantsPage05._1010042, CharacterConstantsPage05._1010041,
        CharacterConstantsPage04._1010040, CharacterConstantsPage04._1010039, CharacterConstantsPage04._1010038, CharacterConstantsPage04._1010037, CharacterConstantsPage04._1010036,
        CharacterConstantsPage04._1010035, CharacterConstantsPage04._1010034, CharacterConstantsPage04._1010033, CharacterConstantsPage04._1010032, CharacterConstantsPage04._1010031,
        CharacterConstantsPage03._1010030, CharacterConstantsPage03._1010029, CharacterConstantsPage03._1010028, CharacterConstantsPage03._1010027, CharacterConstantsPage03._1010026,
        CharacterConstantsPage03._1010025, CharacterConstantsPage03._1010024, CharacterConstantsPage03._1010023, CharacterConstantsPage03._1010022, CharacterConstantsPage03._1010021,
        CharacterConstantsPage02._1010020, CharacterConstantsPage02._1010019, CharacterConstantsPage02._1010018, CharacterConstantsPage02._1010017, CharacterConstantsPage02._1010016,
        CharacterConstantsPage02._1010015, CharacterConstantsPage02._1010014, CharacterConstantsPage02._1010013, CharacterConstantsPage02._1010012, CharacterConstantsPage02._1010011,
        CharacterConstantsPage01._1010010, CharacterConstantsPage01._1010009, CharacterConstantsPage01._1010008, CharacterConstantsPage01._1010007, CharacterConstantsPage01._1010006,
        CharacterConstantsPage01._1010005, CharacterConstantsPage01._1010004, CharacterConstantsPage01._1010003, CharacterConstantsPage01._1010002, CharacterConstantsPage01._1010001,
    ];

    // 2 - 武器
    public static readonly List<WeaponModel> AllWeapon =
    [
        // 201 - 单手剑
        Sword123Constants._2010101,
        Sword123Constants._2010201,
        Sword123Constants._2010301, Sword123Constants._2010302, Sword123Constants._2010303, Sword123Constants._2010304, Sword123Constants._2010305, Sword123Constants._2010306,
        Sword4Constants._2010401, Sword4Constants._2010402, Sword4Constants._2010403, Sword4Constants._2010404, Sword4Constants._2010405, Sword4Constants._2010406, Sword4Constants._2010407, Sword4Constants._2010408,
        Sword4Constants._2010409, Sword4Constants._2010410, Sword4Constants._2010411, Sword4Constants._2010412, Sword4Constants._2010413, Sword4Constants._2010414, Sword4Constants._2010415, Sword4Constants._2010416,
        Sword4Constants._2010417, Sword4Constants._2010418, Sword4Constants._2010419, Sword4Constants._2010420, Sword4Constants._2010421, Sword4Constants._2010422, Sword4Constants._2010423, Sword4Constants._2010424,
        Sword4Constants._2010425, Sword4Constants._2010426, Sword4Constants._2010427, Sword4Constants._2010428,
        Sword5Constants._2010501, Sword5Constants._2010502, Sword5Constants._2010503, Sword5Constants._2010504, Sword5Constants._2010505, Sword5Constants._2010506, Sword5Constants._2010507, Sword5Constants._2010508,
        Sword5Constants._2010509, Sword5Constants._2010510, Sword5Constants._2010511, Sword5Constants._2010512, Sword5Constants._2010513, Sword5Constants._2010514, Sword5Constants._2010515, Sword5Constants._2010516,
        // 202 - 双手剑
        Claymore123Constants._2020101,
        Claymore123Constants._2020201,
        Claymore123Constants._2020301, Claymore123Constants._2020302, Claymore123Constants._2020303, Claymore123Constants._2020304, Claymore123Constants._2020305,
        Claymore4Constants._2020401, Claymore4Constants._2020402, Claymore4Constants._2020403, Claymore4Constants._2020404, Claymore4Constants._2020405, Claymore4Constants._2020406, Claymore4Constants._2020407, Claymore4Constants._2020408,
        Claymore4Constants._2020409, Claymore4Constants._2020410, Claymore4Constants._2020411, Claymore4Constants._2020412, Claymore4Constants._2020413, Claymore4Constants._2020414, Claymore4Constants._2020415, Claymore4Constants._2020416,
        Claymore4Constants._2020417, Claymore4Constants._2020418, Claymore4Constants._2020419, Claymore4Constants._2020420, Claymore4Constants._2020421, Claymore4Constants._2020422, Claymore4Constants._2020423, Claymore4Constants._2020424,
        Claymore4Constants._2020425,
        Claymore5Constants._2020501, Claymore5Constants._2020502, Claymore5Constants._2020503, Claymore5Constants._2020504, Claymore5Constants._2020505, Claymore5Constants._2020506, Claymore5Constants._2020507, Claymore5Constants._2020508,
        Claymore5Constants._2020509, Claymore5Constants._2020510,
        // 203 - 长柄武器
        Pole123Constants._2030101,
        Pole123Constants._2030201,
        Pole123Constants._2030301, Pole123Constants._2030302, Pole123Constants._2030303,
        Pole4Constants._2030401, Pole4Constants._2030402, Pole4Constants._2030403, Pole4Constants._2030404, Pole4Constants._2030405, Pole4Constants._2030406, Pole4Constants._2030407, Pole4Constants._2030408,
        Pole4Constants._2030409, Pole4Constants._2030410, Pole4Constants._2030411, Pole4Constants._2030412, Pole4Constants._2030413, Pole4Constants._2030414, Pole4Constants._2030415, Pole4Constants._2030416,
        Pole4Constants._2030417, Pole4Constants._2030418, Pole4Constants._2030419, Pole4Constants._2030420, Pole4Constants._2030421, Pole4Constants._2030422, Pole4Constants._2030423,
        Pole5Constants._2030501, Pole5Constants._2030502, Pole5Constants._2030503, Pole5Constants._2030504, Pole5Constants._2030505, Pole5Constants._2030506, Pole5Constants._2030507, Pole5Constants._2030508,
        Pole5Constants._2030509, Pole5Constants._2030510, Pole5Constants._2030511, Pole5Constants._2030512,
        // 204 - 法器
        Catalyst123Constants._2040101,
        Catalyst123Constants._2040201,
        Catalyst123Constants._2040301, Catalyst123Constants._2040302, Catalyst123Constants._2040303, Catalyst123Constants._2040304, Catalyst123Constants._2040305,
        Catalyst4Constants._2040401, Catalyst4Constants._2040402, Catalyst4Constants._2040403, Catalyst4Constants._2040404, Catalyst4Constants._2040405, Catalyst4Constants._2040406, Catalyst4Constants._2040407, Catalyst4Constants._2040408,
        Catalyst4Constants._2040409, Catalyst4Constants._2040410, Catalyst4Constants._2040411, Catalyst4Constants._2040412, Catalyst4Constants._2040413, Catalyst4Constants._2040414, Catalyst4Constants._2040415, Catalyst4Constants._2040416,
        Catalyst4Constants._2040417, Catalyst4Constants._2040418, Catalyst4Constants._2040419, Catalyst4Constants._2040420, Catalyst4Constants._2040421, Catalyst4Constants._2040422, Catalyst4Constants._2040423, Catalyst4Constants._2040424,
        Catalyst4Constants._2040425,
        Catalyst5Constants._2040501, Catalyst5Constants._2040502, Catalyst5Constants._2040503, Catalyst5Constants._2040504, Catalyst5Constants._2040505, Catalyst5Constants._2040506, Catalyst5Constants._2040507, Catalyst5Constants._2040508,
        Catalyst5Constants._2040509, Catalyst5Constants._2040510, Catalyst5Constants._2040511, Catalyst5Constants._2040512, Catalyst5Constants._2040513, Catalyst5Constants._2040514, Catalyst5Constants._2040515, Catalyst5Constants._2040516,
        Catalyst5Constants._2040517, Catalyst5Constants._2040518,
        // 205 - 弓
        Bow123Constants._2050101,
        Bow123Constants._2050201,
        Bow123Constants._2050301, Bow123Constants._2050302, Bow123Constants._2050303, Bow123Constants._2050304, Bow123Constants._2050305,
        Bow4Constants._2050401, Bow4Constants._2050402, Bow4Constants._2050403, Bow4Constants._2050404, Bow4Constants._2050405, Bow4Constants._2050406, Bow4Constants._2050407, Bow4Constants._2050408,
        Bow4Constants._2050409, Bow4Constants._2050410, Bow4Constants._2050411, Bow4Constants._2050412, Bow4Constants._2050413, Bow4Constants._2050414, Bow4Constants._2050415, Bow4Constants._2050416,
        Bow4Constants._2050417, Bow4Constants._2050418, Bow4Constants._2050419, Bow4Constants._2050420, Bow4Constants._2050421, Bow4Constants._2050422, Bow4Constants._2050423, Bow4Constants._2050424,
        Bow4Constants._2050425, Bow4Constants._2050426, Bow4Constants._2050427, Bow4Constants._2050428,
        Bow5Constants._2050501, Bow5Constants._2050502, Bow5Constants._2050503, Bow5Constants._2050504, Bow5Constants._2050505, Bow5Constants._2050506, Bow5Constants._2050507, Bow5Constants._2050508,
        Bow5Constants._2050509, Bow5Constants._2050510, Bow5Constants._2050511, Bow5Constants._2050512,
    ];

    // 3 - 材料
    // 301 - 摩拉
    public static readonly List<MaterialModel> AllMaterialMora = [MaterialConstants01._3010001];

    // 302 - 角色经验素材
    public static readonly List<MaterialModel> AllMaterialCharacterExp = [MaterialConstants02._3020001, MaterialConstants02._3020002, MaterialConstants02._3020003];

    // 303 - 角色与武器培养素材_234
    public static readonly List<MaterialModel> AllMaterialCharacterWeaponEnhancement1 =
    [
        MaterialConstants03._3030001, MaterialConstants03._3030002, MaterialConstants03._3030003, MaterialConstants03._3030004, MaterialConstants03._3030005, MaterialConstants03._3030006, MaterialConstants03._3030007, MaterialConstants03._3030008,
        MaterialConstants03._3030009, MaterialConstants03._3030010, MaterialConstants03._3030011, MaterialConstants03._3030012, MaterialConstants03._3030013, MaterialConstants03._3030014, MaterialConstants03._3030015, MaterialConstants03._3030016,
        MaterialConstants03._3030017, MaterialConstants03._3030018, MaterialConstants03._3030019, MaterialConstants03._3030020, MaterialConstants03._3030021, MaterialConstants03._3030022, MaterialConstants03._3030023, MaterialConstants03._3030024,
        MaterialConstants03._3030025, MaterialConstants03._3030026, MaterialConstants03._3030027, MaterialConstants03._3030028, MaterialConstants03._3030029, MaterialConstants03._3030030, MaterialConstants03._3030031, MaterialConstants03._3030032,
        MaterialConstants03._3030033, MaterialConstants03._3030034, MaterialConstants03._3030035, MaterialConstants03._3030036, MaterialConstants03._3030037, MaterialConstants03._3030038, MaterialConstants03._3030039, MaterialConstants03._3030040,
        MaterialConstants03._3030041, MaterialConstants03._3030042, MaterialConstants03._3030043, MaterialConstants03._3030044, MaterialConstants03._3030045, MaterialConstants03._3030046, MaterialConstants03._3030047, MaterialConstants03._3030048,
        MaterialConstants03._3030049, MaterialConstants03._3030050, MaterialConstants03._3030051, MaterialConstants03._3030052, MaterialConstants03._3030053, MaterialConstants03._3030054, MaterialConstants03._3030055, MaterialConstants03._3030056,
        MaterialConstants03._3030057, MaterialConstants03._3030058, MaterialConstants03._3030059, MaterialConstants03._3030060, MaterialConstants03._3030061, MaterialConstants03._3030062, MaterialConstants03._3030063, MaterialConstants03._3030064,
        MaterialConstants03._3030065, MaterialConstants03._3030066, MaterialConstants03._3030067, MaterialConstants03._3030068, MaterialConstants03._3030069, MaterialConstants03._3030070, MaterialConstants03._3030071, MaterialConstants03._3030072,
        MaterialConstants03._3030073, MaterialConstants03._3030074, MaterialConstants03._3030075, MaterialConstants03._3030076, MaterialConstants03._3030077, MaterialConstants03._3030078, MaterialConstants03._3030079, MaterialConstants03._3030080,
        MaterialConstants03._3030081, MaterialConstants03._3030082, MaterialConstants03._3030083, MaterialConstants03._3030084, MaterialConstants03._3030085, MaterialConstants03._3030086, MaterialConstants03._3030087, MaterialConstants03._3030088,
        MaterialConstants03._3030089, MaterialConstants03._3030090,
    ];

    // 304 - 角色与武器培养素材_123
    public static readonly List<MaterialModel> AllMaterialCharacterWeaponEnhancement2 =
    [
        MaterialConstants04._3040001, MaterialConstants04._3040002, MaterialConstants04._3040003, MaterialConstants04._3040004, MaterialConstants04._3040005, MaterialConstants04._3040006, MaterialConstants04._3040007, MaterialConstants04._3040008,
        MaterialConstants04._3040009, MaterialConstants04._3040010, MaterialConstants04._3040011, MaterialConstants04._3040012, MaterialConstants04._3040013, MaterialConstants04._3040014, MaterialConstants04._3040015, MaterialConstants04._3040016,
        MaterialConstants04._3040017, MaterialConstants04._3040018, MaterialConstants04._3040019, MaterialConstants04._3040020, MaterialConstants04._3040021, MaterialConstants04._3040022, MaterialConstants04._3040023, MaterialConstants04._3040024,
        MaterialConstants04._3040025, MaterialConstants04._3040026, MaterialConstants04._3040027, MaterialConstants04._3040028, MaterialConstants04._3040029, MaterialConstants04._3040030, MaterialConstants04._3040031, MaterialConstants04._3040032,
        MaterialConstants04._3040033, MaterialConstants04._3040034, MaterialConstants04._3040035, MaterialConstants04._3040036, MaterialConstants04._3040037, MaterialConstants04._3040038, MaterialConstants04._3040039, MaterialConstants04._3040040,
        MaterialConstants04._3040041, MaterialConstants04._3040042, MaterialConstants04._3040043, MaterialConstants04._3040044, MaterialConstants04._3040045, MaterialConstants04._3040046, MaterialConstants04._3040047, MaterialConstants04._3040048,
        MaterialConstants04._3040049, MaterialConstants04._3040050, MaterialConstants04._3040051,
    ];

    // 305 - 角色培养素材_周本
    public static readonly List<MaterialModel> AllMaterialCharacterLevelUp1 =
    [
        MaterialConstants05._3050001, MaterialConstants05._3050002, MaterialConstants05._3050003, MaterialConstants05._3050004, MaterialConstants05._3050005, MaterialConstants05._3050006, MaterialConstants05._3050007, MaterialConstants05._3050008,
        MaterialConstants05._3050009, MaterialConstants05._3050010, MaterialConstants05._3050011, MaterialConstants05._3050012, MaterialConstants05._3050013, MaterialConstants05._3050014, MaterialConstants05._3050015, MaterialConstants05._3050016,
        MaterialConstants05._3050017, MaterialConstants05._3050018, MaterialConstants05._3050019, MaterialConstants05._3050020, MaterialConstants05._3050021, MaterialConstants05._3050022, MaterialConstants05._3050023, MaterialConstants05._3050024,
        MaterialConstants05._3050025, MaterialConstants05._3050026, MaterialConstants05._3050027, MaterialConstants05._3050028, MaterialConstants05._3050029, MaterialConstants05._3050030, MaterialConstants05._3050031, MaterialConstants05._3050032,
        MaterialConstants05._3050033, MaterialConstants05._3050034, MaterialConstants05._3050035, MaterialConstants05._3050036, MaterialConstants05._3050037, MaterialConstants05._3050038, MaterialConstants05._3050039, MaterialConstants05._3050040,
    ];

    // 306 - 角色培养素材_40体力BOSS
    public static readonly List<MaterialModel> AllMaterialCharacterLevelUp2 =
    [
        MaterialConstants06._3060001, MaterialConstants06._3060002, MaterialConstants06._3060003, MaterialConstants06._3060004, MaterialConstants06._3060005, MaterialConstants06._3060006, MaterialConstants06._3060007, MaterialConstants06._3060008,
        MaterialConstants06._3060009, MaterialConstants06._3060010, MaterialConstants06._3060011, MaterialConstants06._3060012, MaterialConstants06._3060013, MaterialConstants06._3060014, MaterialConstants06._3060015, MaterialConstants06._3060016,
        MaterialConstants06._3060017, MaterialConstants06._3060018, MaterialConstants06._3060019, MaterialConstants06._3060020, MaterialConstants06._3060021, MaterialConstants06._3060022, MaterialConstants06._3060023, MaterialConstants06._3060024,
        MaterialConstants06._3060025, MaterialConstants06._3060026, MaterialConstants06._3060027, MaterialConstants06._3060028, MaterialConstants06._3060029, MaterialConstants06._3060030, MaterialConstants06._3060031, MaterialConstants06._3060032,
        MaterialConstants06._3060033, MaterialConstants06._3060034, MaterialConstants06._3060035, MaterialConstants06._3060036, MaterialConstants06._3060037, MaterialConstants06._3060038, MaterialConstants06._3060039, MaterialConstants06._3060040,
        MaterialConstants06._3060041, MaterialConstants06._3060042, MaterialConstants06._3060043, MaterialConstants06._3060044, MaterialConstants06._3060045,
    ];

    // 307 - 角色突破素材_钻儿块儿片儿粒儿
    public static readonly List<MaterialModel> AllMaterialCharacterAscension =
    [
        MaterialConstants07._3070101, MaterialConstants07._3070102, MaterialConstants07._3070103, MaterialConstants07._3070104, // 30701 - 旅行者 
        MaterialConstants07._3070201, MaterialConstants07._3070202, MaterialConstants07._3070203, MaterialConstants07._3070204, // 30702 - 火
        MaterialConstants07._3070301, MaterialConstants07._3070302, MaterialConstants07._3070303, MaterialConstants07._3070304, // 30703 - 水
        MaterialConstants07._3070401, MaterialConstants07._3070402, MaterialConstants07._3070403, MaterialConstants07._3070404, // 30704 - 草
        MaterialConstants07._3070501, MaterialConstants07._3070502, MaterialConstants07._3070503, MaterialConstants07._3070504, // 30705 - 雷
        MaterialConstants07._3070601, MaterialConstants07._3070602, MaterialConstants07._3070603, MaterialConstants07._3070604, // 30706 - 风
        MaterialConstants07._3070701, MaterialConstants07._3070702, MaterialConstants07._3070703, MaterialConstants07._3070704, // 30707 - 冰
        MaterialConstants07._3070801, MaterialConstants07._3070802, MaterialConstants07._3070803, MaterialConstants07._3070804, // 30708 - 岩
    ];

    // 308 - 角色天赋素材
    public static readonly List<MaterialModel> AllMaterialCharacterTalent =
    [
        MaterialConstants08._3080001, MaterialConstants08._3080002, MaterialConstants08._3080003, MaterialConstants08._3080004, MaterialConstants08._3080005, MaterialConstants08._3080006, MaterialConstants08._3080007, MaterialConstants08._3080008,
        MaterialConstants08._3080009, MaterialConstants08._3080010, MaterialConstants08._3080011, MaterialConstants08._3080012, MaterialConstants08._3080013, MaterialConstants08._3080014, MaterialConstants08._3080015, MaterialConstants08._3080016,
        MaterialConstants08._3080017, MaterialConstants08._3080018, MaterialConstants08._3080019, MaterialConstants08._3080020, MaterialConstants08._3080021, MaterialConstants08._3080022, MaterialConstants08._3080023, MaterialConstants08._3080024,
        MaterialConstants08._3080025, MaterialConstants08._3080026, MaterialConstants08._3080027, MaterialConstants08._3080028, MaterialConstants08._3080029, MaterialConstants08._3080030, MaterialConstants08._3080031, MaterialConstants08._3080032,
        MaterialConstants08._3080033, MaterialConstants08._3080034, MaterialConstants08._3080035, MaterialConstants08._3080036, MaterialConstants08._3080037, MaterialConstants08._3080038, MaterialConstants08._3080039, MaterialConstants08._3080040,
        MaterialConstants08._3080041, MaterialConstants08._3080042, MaterialConstants08._3080043, MaterialConstants08._3080044, MaterialConstants08._3080045, MaterialConstants08._3080046, MaterialConstants08._3080047, MaterialConstants08._3080048,
        MaterialConstants08._3080049, MaterialConstants08._3080050, MaterialConstants08._3080051, MaterialConstants08._3080052, MaterialConstants08._3080053, MaterialConstants08._3080054, MaterialConstants08._3080055, MaterialConstants08._3080056,
        MaterialConstants08._3080057, MaterialConstants08._3080058, MaterialConstants08._3080059, MaterialConstants08._3080060, MaterialConstants08._3080061, MaterialConstants08._3080062, MaterialConstants08._3080063,
        MaterialConstants08._3080000,
    ];

    // 309 - 武器突破素材
    public static readonly List<MaterialModel> AllMaterialWeaponAscension =
    [
        MaterialConstants09._3090001, MaterialConstants09._3090002, MaterialConstants09._3090003, MaterialConstants09._3090004, MaterialConstants09._3090005, MaterialConstants09._3090006, MaterialConstants09._3090007, MaterialConstants09._3090008,
        MaterialConstants09._3090009, MaterialConstants09._3090010, MaterialConstants09._3090011, MaterialConstants09._3090012, MaterialConstants09._3090013, MaterialConstants09._3090014, MaterialConstants09._3090015, MaterialConstants09._3090016,
        MaterialConstants09._3090017, MaterialConstants09._3090018, MaterialConstants09._3090019, MaterialConstants09._3090020, MaterialConstants09._3090021, MaterialConstants09._3090022, MaterialConstants09._3090023, MaterialConstants09._3090024,
        MaterialConstants09._3090025, MaterialConstants09._3090026, MaterialConstants09._3090027, MaterialConstants09._3090028, MaterialConstants09._3090029, MaterialConstants09._3090030, MaterialConstants09._3090031, MaterialConstants09._3090032,
        MaterialConstants09._3090033, MaterialConstants09._3090034, MaterialConstants09._3090035, MaterialConstants09._3090036, MaterialConstants09._3090037, MaterialConstants09._3090038, MaterialConstants09._3090039, MaterialConstants09._3090040,
        MaterialConstants09._3090041, MaterialConstants09._3090042, MaterialConstants09._3090043, MaterialConstants09._3090044, MaterialConstants09._3090045, MaterialConstants09._3090046, MaterialConstants09._3090047, MaterialConstants09._3090048,
        MaterialConstants09._3090049, MaterialConstants09._3090050, MaterialConstants09._3090051, MaterialConstants09._3090052, MaterialConstants09._3090053, MaterialConstants09._3090054, MaterialConstants09._3090055, MaterialConstants09._3090056,
        MaterialConstants09._3090057, MaterialConstants09._3090058, MaterialConstants09._3090059, MaterialConstants09._3090060, MaterialConstants09._3090061, MaterialConstants09._3090062, MaterialConstants09._3090063, MaterialConstants09._3090064,
        MaterialConstants09._3090065, MaterialConstants09._3090066, MaterialConstants09._3090067, MaterialConstants09._3090068, MaterialConstants09._3090069, MaterialConstants09._3090070, MaterialConstants09._3090071, MaterialConstants09._3090072,
        MaterialConstants09._3090073, MaterialConstants09._3090074, MaterialConstants09._3090075, MaterialConstants09._3090076, MaterialConstants09._3090077, MaterialConstants09._3090078, MaterialConstants09._3090079, MaterialConstants09._3090080,
        MaterialConstants09._3090081, MaterialConstants09._3090082, MaterialConstants09._3090083, MaterialConstants09._3090084,
    ];

    // 310 - 地方特产
    public static readonly List<MaterialModel> AllMaterialLocalSpecialty =
    [
        // 31001 - 蒙德地方特产
        MaterialConstants10._3100101, MaterialConstants10._3100102, MaterialConstants10._3100103, MaterialConstants10._3100104, MaterialConstants10._3100105, MaterialConstants10._3100106, MaterialConstants10._3100107, MaterialConstants10._3100108, MaterialConstants10._3100109,
        // 31002 - 璃月地方特产
        MaterialConstants10._3100201, MaterialConstants10._3100202, MaterialConstants10._3100203, MaterialConstants10._3100204, MaterialConstants10._3100205, MaterialConstants10._3100206, MaterialConstants10._3100207, MaterialConstants10._3100208, MaterialConstants10._3100209,
        // 31003 - 稻妻地方特产
        MaterialConstants10._3100301, MaterialConstants10._3100302, MaterialConstants10._3100303, MaterialConstants10._3100304, MaterialConstants10._3100305, MaterialConstants10._3100306, MaterialConstants10._3100307, MaterialConstants10._3100308, MaterialConstants10._3100309,
        // 31004 - 须弥地方特产
        MaterialConstants10._3100401, MaterialConstants10._3100402, MaterialConstants10._3100403, MaterialConstants10._3100404, MaterialConstants10._3100405, MaterialConstants10._3100406, MaterialConstants10._3100407, MaterialConstants10._3100408, MaterialConstants10._3100409,
        // 31005 - 枫丹地方特产
        MaterialConstants10._3100501, MaterialConstants10._3100502, MaterialConstants10._3100503, MaterialConstants10._3100504, MaterialConstants10._3100505, MaterialConstants10._3100506, MaterialConstants10._3100507, MaterialConstants10._3100508,
        // 31006 - 纳塔地方特产
        MaterialConstants10._3100601, MaterialConstants10._3100602, MaterialConstants10._3100603, MaterialConstants10._3100604, MaterialConstants10._3100605, MaterialConstants10._3100606, MaterialConstants10._3100607, MaterialConstants10._3100608,
        // 31007 - 挪德卡莱地方特产
        MaterialConstants10._3100701, MaterialConstants10._3100702, MaterialConstants10._3100703, MaterialConstants10._3100704, MaterialConstants10._3100705,
    ];

    // 311 - 武器强化素材
    public static readonly List<MaterialModel> AllMaterialWeaponExp = [MaterialConstants11._3110001, MaterialConstants11._3110002, MaterialConstants11._3110003];

    public static readonly List<List<MaterialModel>> AllMaterialLists =
    [
        AllMaterialMora, AllMaterialCharacterExp, AllMaterialWeaponExp, AllMaterialCharacterWeaponEnhancement1, AllMaterialCharacterWeaponEnhancement2, AllMaterialCharacterLevelUp1,
        AllMaterialCharacterLevelUp2, AllMaterialCharacterAscension, AllMaterialCharacterTalent, AllMaterialWeaponAscension, AllMaterialLocalSpecialty,
    ];

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
        DungeonConstants._4040025, DungeonConstants._4040026, DungeonConstants._4040027, DungeonConstants._4040028, DungeonConstants._4040029, DungeonConstants._4040030, DungeonConstants._4040031, DungeonConstants._4040032,
        DungeonConstants._4040033,
    ];

    // 405 - 40体力BOSS
    public static readonly List<DungeonModel> AllDungeonBoss =
    [
        DungeonConstants._4050001, DungeonConstants._4050002, DungeonConstants._4050003, DungeonConstants._4050004, DungeonConstants._4050005, DungeonConstants._4050006, DungeonConstants._4050007, DungeonConstants._4050008,
        DungeonConstants._4050009, DungeonConstants._4050010, DungeonConstants._4050011, DungeonConstants._4050012, DungeonConstants._4050013, DungeonConstants._4050014, DungeonConstants._4050015, DungeonConstants._4050016,
        DungeonConstants._4050017, DungeonConstants._4050018, DungeonConstants._4050019, DungeonConstants._4050020, DungeonConstants._4050021, DungeonConstants._4050022, DungeonConstants._4050023, DungeonConstants._4050024,
        DungeonConstants._4050025, DungeonConstants._4050026, DungeonConstants._4050027, DungeonConstants._4050028, DungeonConstants._4050029, DungeonConstants._4050030, DungeonConstants._4050031, DungeonConstants._4050032,
        DungeonConstants._4050033, DungeonConstants._4050034, DungeonConstants._4050035, DungeonConstants._4050036, DungeonConstants._4050037, DungeonConstants._4050038, DungeonConstants._4050039, DungeonConstants._4050040,
        DungeonConstants._4050041, DungeonConstants._4050042, DungeonConstants._4050043, DungeonConstants._4050044,
    ];

    // 406 - 圣遗物
    public static readonly List<DungeonModel> AllDungeonArtifact =
    [
        DungeonConstants._4060001, DungeonConstants._4060002, DungeonConstants._4060003, DungeonConstants._4060004, DungeonConstants._4060005, DungeonConstants._4060006, DungeonConstants._4060007, DungeonConstants._4060008,
        DungeonConstants._4060009, DungeonConstants._4060010, DungeonConstants._4060011, DungeonConstants._4060012, DungeonConstants._4060013, DungeonConstants._4060014, DungeonConstants._4060015, DungeonConstants._4060016,
        DungeonConstants._4060017, DungeonConstants._4060018, DungeonConstants._4060019, DungeonConstants._4060020,
    ];

    // 407 - 武器
    public static readonly List<DungeonModel> AllDungeonWeaponAscension =
    [
        DungeonConstants._4070001, DungeonConstants._4070002, DungeonConstants._4070003, DungeonConstants._4070004, DungeonConstants._4070005, DungeonConstants._4070006, DungeonConstants._4070007, DungeonConstants._4070008,
        DungeonConstants._4070009, DungeonConstants._4070010, DungeonConstants._4070011, DungeonConstants._4070012, DungeonConstants._4070013, DungeonConstants._4070014, DungeonConstants._4070015, DungeonConstants._4070016,
        DungeonConstants._4070017, DungeonConstants._4070018, DungeonConstants._4070019, DungeonConstants._4070020, DungeonConstants._4070021,
    ];

    // 408 - 天赋
    public static readonly List<DungeonModel> AllDungeonCharacterTalent =
    [
        DungeonConstants._4080001, DungeonConstants._4080002, DungeonConstants._4080003, DungeonConstants._4080004, DungeonConstants._4080005, DungeonConstants._4080006, DungeonConstants._4080007, DungeonConstants._4080008,
        DungeonConstants._4080009, DungeonConstants._4080010, DungeonConstants._4080011, DungeonConstants._4080012, DungeonConstants._4080013, DungeonConstants._4080014, DungeonConstants._4080015, DungeonConstants._4080016,
        DungeonConstants._4080017, DungeonConstants._4080018, DungeonConstants._4080019, DungeonConstants._4080020, DungeonConstants._4080021,
    ];

    // 409 - 60体力BOSS
    public static readonly List<DungeonModel> AllDungeonTrounce =
    [
        DungeonConstants._4090001, DungeonConstants._4090002, DungeonConstants._4090003, DungeonConstants._4090004, DungeonConstants._4090005, DungeonConstants._4090006, DungeonConstants._4090007, DungeonConstants._4090008,
        DungeonConstants._4090009, DungeonConstants._4090010, DungeonConstants._4090011, DungeonConstants._4090012, DungeonConstants._4090013,
    ];

    public static readonly List<List<DungeonModel>> AllDungeonLists =
    [
        AllDungeonLocalSpecialty, AllDungeonEasy, AllDungeonElite, AllDungeonLeyLineOutcrop, AllDungeonCharacterTalent, AllDungeonWeaponAscension, AllDungeonBoss, AllDungeonTrounce
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
        ArtifactConstants._557, ArtifactConstants._558, ArtifactConstants._559,
    ];

    // 所有group
    public static readonly List<MaterialGroupModel> AllGroup =
    [
        // 303 - 角色与武器培养素材_234
        MaterialConstants03.G3030001, MaterialConstants03.G3030004, MaterialConstants03.G3030007, MaterialConstants03.G3030010, MaterialConstants03.G3030013, MaterialConstants03.G3030016, MaterialConstants03.G3030019, MaterialConstants03.G3030022,
        MaterialConstants03.G3030025, MaterialConstants03.G3030028, MaterialConstants03.G3030031, MaterialConstants03.G3030034, MaterialConstants03.G3030037, MaterialConstants03.G3030040, MaterialConstants03.G3030043, MaterialConstants03.G3030046,
        MaterialConstants03.G3030049, MaterialConstants03.G3030052, MaterialConstants03.G3030055, MaterialConstants03.G3030058, MaterialConstants03.G3030061, MaterialConstants03.G3030064, MaterialConstants03.G3030067, MaterialConstants03.G3030070,
        MaterialConstants03.G3030073, MaterialConstants03.G3030076, MaterialConstants03.G3030079, MaterialConstants03.G3030082, MaterialConstants03.G3030085, MaterialConstants03.G3030088,
        // 304 - 角色与武器培养素材_123
        MaterialConstants04.G3040001, MaterialConstants04.G3040004, MaterialConstants04.G3040007, MaterialConstants04.G3040010, MaterialConstants04.G3040013, MaterialConstants04.G3040016, MaterialConstants04.G3040019, MaterialConstants04.G3040022,
        MaterialConstants04.G3040025, MaterialConstants04.G3040028, MaterialConstants04.G3040031, MaterialConstants04.G3040034, MaterialConstants04.G3040037, MaterialConstants04.G3040040, MaterialConstants04.G3040043, MaterialConstants04.G3040046,
        MaterialConstants04.G3040049,
        // 307 - 角色突破素材_钻儿块儿片儿粒儿
        MaterialConstants07.G3070101, MaterialConstants07.G3070201, MaterialConstants07.G3070301, MaterialConstants07.G3070401, MaterialConstants07.G3070501, MaterialConstants07.G3070601, MaterialConstants07.G3070701, MaterialConstants07.G3070801,
        // 308 - 角色天赋素材
        MaterialConstants08.G3080001, MaterialConstants08.G3080004, MaterialConstants08.G3080007, MaterialConstants08.G3080010, MaterialConstants08.G3080013, MaterialConstants08.G3080016, MaterialConstants08.G3080019, MaterialConstants08.G3080022,
        MaterialConstants08.G3080025, MaterialConstants08.G3080028, MaterialConstants08.G3080031, MaterialConstants08.G3080034, MaterialConstants08.G3080037, MaterialConstants08.G3080040, MaterialConstants08.G3080043, MaterialConstants08.G3080046,
        MaterialConstants08.G3080049, MaterialConstants08.G3080052, MaterialConstants08.G3080055, MaterialConstants08.G3080058, MaterialConstants08.G3080061,
        // 309 - 武器突破素材
        MaterialConstants09.G3090001, MaterialConstants09.G3090005, MaterialConstants09.G3090009, MaterialConstants09.G3090013, MaterialConstants09.G3090017, MaterialConstants09.G3090021, MaterialConstants09.G3090025, MaterialConstants09.G3090029,
        MaterialConstants09.G3090033, MaterialConstants09.G3090037, MaterialConstants09.G3090041, MaterialConstants09.G3090045, MaterialConstants09.G3090049, MaterialConstants09.G3090053, MaterialConstants09.G3090057, MaterialConstants09.G3090061,
        MaterialConstants09.G3090065, MaterialConstants09.G3090069, MaterialConstants09.G3090073, MaterialConstants09.G3090077, MaterialConstants09.G3090081,
    ];
}