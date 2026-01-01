using HexereiKatepnha.Models.EntityModels;

namespace HexereiKatepnha.Constants.EntityConstants;

public static class MaterialConstants
{
    // 301 - 摩拉
    public static readonly MaterialModel _3010001 = new()
    {
        Rid = 3010001,
        Vid = 202,
        Name = "摩拉",
        Star = 3,
        MaterialType = Enumeration.MaterialType.Mora,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_202.png"
    };

    // 302 - 角色经验素材
    public static readonly MaterialModel _3020001 = new()
    {
        Rid = 3020001,
        Vid = 104003,
        Name = "大英雄的经验",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterExp,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104003.png"
    };

    public static readonly MaterialModel _3020002 = new()
    {
        Rid = 3020002,
        Vid = 104002,
        Name = "冒险家的经验",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterExp,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104002.png"
    };

    public static readonly MaterialModel _3020003 = new()
    {
        Rid = 3020003,
        Vid = 104001,
        Name = "流浪者的经验",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterExp,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104001.png"
    };

    // 303 - 角色与武器培养素材_234
    public static readonly MaterialModel _3030001 = new()
    {
        Rid = 3030001,
        Vid = 112016,
        Name = "黑晶号角",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112016.png"
    };

    public static readonly MaterialModel _3030002 = new()
    {
        Rid = 3030002,
        Vid = 112015,
        Name = "黑铜号角",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112015.png"
    };

    public static readonly MaterialModel _3030003 = new()
    {
        Rid = 3030003,
        Vid = 112014,
        Name = "沉重号角",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112014.png"
    };

    public static readonly MaterialGroupModel G3030001 = new([_3030001, _3030002, _3030003], 3);

    public static readonly MaterialModel _3030004 = new()
    {
        Rid = 3030004,
        Vid = 112022,
        Name = "地脉的新芽",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112022.png"
    };

    public static readonly MaterialModel _3030005 = new()
    {
        Rid = 3030005,
        Vid = 112021,
        Name = "地脉的枯叶",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112021.png"
    };

    public static readonly MaterialModel _3030006 = new()
    {
        Rid = 3030006,
        Vid = 112020,
        Name = "地脉的旧枝",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112020.png"
    };

    public static readonly MaterialGroupModel G3030004 = new([_3030004, _3030005, _3030006], 3);

    public static readonly MaterialModel _3030007 = new()
    {
        Rid = 3030007,
        Vid = 112025,
        Name = "混沌炉心",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112025.png"
    };

    public static readonly MaterialModel _3030008 = new()
    {
        Rid = 3030008,
        Vid = 112024,
        Name = "混沌回路",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112024.png"
    };

    public static readonly MaterialModel _3030009 = new()
    {
        Rid = 3030009,
        Vid = 112023,
        Name = "混沌装置",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112023.png"
    };

    public static readonly MaterialGroupModel G3030007 = new([_3030007, _3030008, _3030009], 3);

    public static readonly MaterialModel _3030010 = new()
    {
        Rid = 3030010,
        Vid = 112028,
        Name = "雾虚灯芯",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112028.png"
    };

    public static readonly MaterialModel _3030011 = new()
    {
        Rid = 3030011,
        Vid = 112027,
        Name = "雾虚草囊",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112027.png"
    };

    public static readonly MaterialModel _3030012 = new()
    {
        Rid = 3030012,
        Vid = 112026,
        Name = "雾虚花粉",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112026.png"
    };

    public static readonly MaterialGroupModel G3030010 = new([_3030010, _3030011, _3030012], 3);

    public static readonly MaterialModel _3030013 = new()
    {
        Rid = 3030013,
        Vid = 112031,
        Name = "督察长祭刀",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112031.png"
    };

    public static readonly MaterialModel _3030014 = new()
    {
        Rid = 3030014,
        Vid = 112030,
        Name = "特工祭刀",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112030.png"
    };

    public static readonly MaterialModel _3030015 = new()
    {
        Rid = 3030015,
        Vid = 112029,
        Name = "猎兵祭刀",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112029.png"
    };

    public static readonly MaterialGroupModel G3030013 = new([_3030013, _3030014, _3030015], 3);

    public static readonly MaterialModel _3030016 = new()
    {
        Rid = 3030016,
        Vid = 112043,
        Name = "石化的骨片",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112043.png"
    };

    public static readonly MaterialModel _3030017 = new()
    {
        Rid = 3030017,
        Vid = 112042,
        Name = "结实的骨片",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112042.png"
    };

    public static readonly MaterialModel _3030018 = new()
    {
        Rid = 3030018,
        Vid = 112041,
        Name = "脆弱的骨片",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112041.png"
    };

    public static readonly MaterialGroupModel G3030016 = new([_3030016, _3030017, _3030018], 3);

    public static readonly MaterialModel _3030019 = new()
    {
        Rid = 3030019,
        Vid = 112049,
        Name = "混沌真眼",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112049.png"
    };

    public static readonly MaterialModel _3030020 = new()
    {
        Rid = 3030020,
        Vid = 112048,
        Name = "混沌枢纽",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112048.png"
    };

    public static readonly MaterialModel _3030021 = new()
    {
        Rid = 3030021,
        Vid = 112047,
        Name = "混沌机关",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112047.png"
    };

    public static readonly MaterialGroupModel G3030019 = new([_3030019, _3030020, _3030021], 3);

    public static readonly MaterialModel _3030022 = new()
    {
        Rid = 3030022,
        Vid = 112052,
        Name = "偏光棱镜",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112052.png"
    };

    public static readonly MaterialModel _3030023 = new()
    {
        Rid = 3030023,
        Vid = 112051,
        Name = "水晶棱镜",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112051.png"
    };

    public static readonly MaterialModel _3030024 = new()
    {
        Rid = 3030024,
        Vid = 112050,
        Name = "黯淡棱镜",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112050.png"
    };

    public static readonly MaterialGroupModel G3030022 = new([_3030022, _3030023, _3030024], 3);

    public static readonly MaterialModel _3030025 = new()
    {
        Rid = 3030025,
        Vid = 112058,
        Name = "隐兽鬼爪",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112058.png"
    };

    public static readonly MaterialModel _3030026 = new()
    {
        Rid = 3030026,
        Vid = 112057,
        Name = "隐兽利爪",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112057.png"
    };

    public static readonly MaterialModel _3030027 = new()
    {
        Rid = 3030027,
        Vid = 112056,
        Name = "隐兽指爪",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112056.png"
    };

    public static readonly MaterialGroupModel G3030025 = new([_3030025, _3030026, _3030026], 3);

    public static readonly MaterialModel _3030028 = new()
    {
        Rid = 3030028,
        Vid = 112019,
        Name = "幽邃刻像",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112019.png"
    };

    public static readonly MaterialModel _3030029 = new()
    {
        Rid = 3030029,
        Vid = 112018,
        Name = "夤夜刻像",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112018.png"
    };

    public static readonly MaterialModel _3030030 = new()
    {
        Rid = 3030030,
        Vid = 112017,
        Name = "晦暗刻像",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112017.png"
    };

    public static readonly MaterialGroupModel G3030028 = new([_3030028, _3030029, _3030030], 3);

    public static readonly MaterialModel _3030031 = new()
    {
        Rid = 3030031,
        Vid = 112064,
        Name = "茁壮菌核",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112064.png"
    };

    public static readonly MaterialModel _3030032 = new()
    {
        Rid = 3030032,
        Vid = 112063,
        Name = "休眠菌核",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112063.png"
    };

    public static readonly MaterialModel _3030033 = new()
    {
        Rid = 3030033,
        Vid = 112062,
        Name = "失活菌核",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112062.png"
    };

    public static readonly MaterialGroupModel G3030031 = new([_3030031, _3030032, _3030033], 3);

    public static readonly MaterialModel _3030034 = new()
    {
        Rid = 3030034,
        Vid = 112070,
        Name = "混沌锚栓",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112070.png"
    };

    public static readonly MaterialModel _3030035 = new()
    {
        Rid = 3030035,
        Vid = 112069,
        Name = "混沌模块",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112069.png"
    };

    public static readonly MaterialModel _3030036 = new()
    {
        Rid = 3030036,
        Vid = 112068,
        Name = "混沌容器",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112068.png"
    };

    public static readonly MaterialGroupModel G3030034 = new([_3030034, _3030035, _3030036], 3);

    public static readonly MaterialModel _3030037 = new()
    {
        Rid = 3030037,
        Vid = 112073,
        Name = "辉光棱晶",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112073.png"
    };

    public static readonly MaterialModel _3030038 = new()
    {
        Rid = 3030038,
        Vid = 112072,
        Name = "混浊棱晶",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112072.png"
    };

    public static readonly MaterialModel _3030039 = new()
    {
        Rid = 3030039,
        Vid = 112071,
        Name = "破缺棱晶",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112071.png"
    };

    public static readonly MaterialGroupModel G3030037 = new([_3030037, _3030038, _3030039], 3);

    public static readonly MaterialModel _3030040 = new()
    {
        Rid = 3030040,
        Vid = 112076,
        Name = "锲纹的横脊",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112076.png"
    };

    public static readonly MaterialModel _3030041 = new()
    {
        Rid = 3030041,
        Vid = 112075,
        Name = "密固的横脊",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112075.png"
    };

    public static readonly MaterialModel _3030042 = new()
    {
        Rid = 3030042,
        Vid = 112074,
        Name = "残毁的横脊",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112074.png"
    };

    public static readonly MaterialGroupModel G3030040 = new([_3030040, _3030041, _3030042], 3);

    public static readonly MaterialModel _3030043 = new()
    {
        Rid = 3030043,
        Vid = 112079,
        Name = "漫游者的盛放之花",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112079.png"
    };

    public static readonly MaterialModel _3030044 = new()
    {
        Rid = 3030044,
        Vid = 112078,
        Name = "何人所珍藏之花",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112078.png"
    };

    public static readonly MaterialModel _3030045 = new()
    {
        Rid = 3030045,
        Vid = 112077,
        Name = "来自何处的待放之花",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112077.png"
    };

    public static readonly MaterialGroupModel G3030043 = new([_3030043, _3030044, _3030045], 3);

    public static readonly MaterialModel _3030046 = new()
    {
        Rid = 3030046,
        Vid = 112088,
        Name = "初生的浊水幻灵",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112088.png"
    };

    public static readonly MaterialModel _3030047 = new()
    {
        Rid = 3030047,
        Vid = 112087,
        Name = "浊水的一掬",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112087.png"
    };

    public static readonly MaterialModel _3030048 = new()
    {
        Rid = 3030048,
        Vid = 112086,
        Name = "浊水的一滴",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112086.png"
    };

    public static readonly MaterialGroupModel G3030046 = new([_3030046, _3030047, _3030048], 3);

    public static readonly MaterialModel _3030049 = new()
    {
        Rid = 3030049,
        Vid = 112091,
        Name = "异界生命核",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112091.png"
    };

    public static readonly MaterialModel _3030050 = new()
    {
        Rid = 3030050,
        Vid = 112090,
        Name = "外世突触",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112090.png"
    };

    public static readonly MaterialModel _3030051 = new()
    {
        Rid = 3030051,
        Vid = 112089,
        Name = "隙间之核",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112089.png"
    };

    public static readonly MaterialGroupModel G3030049 = new([_3030049, _3030050, _3030051], 3);

    public static readonly MaterialModel _3030052 = new()
    {
        Rid = 3030052,
        Vid = 112094,
        Name = "役人的时时刻刻",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112094.png"
    };

    public static readonly MaterialModel _3030053 = new()
    {
        Rid = 3030053,
        Vid = 112093,
        Name = "役人的制式怀表",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112093.png"
    };

    public static readonly MaterialModel _3030054 = new()
    {
        Rid = 3030054,
        Vid = 112092,
        Name = "老旧的役人怀表",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112092.png"
    };

    public static readonly MaterialGroupModel G3030052 = new([_3030052, _3030053, _3030054], 3);

    public static readonly MaterialModel _3030055 = new()
    {
        Rid = 3030055,
        Vid = 112097,
        Name = "渊光鳍翅",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112097.png"
    };

    public static readonly MaterialModel _3030056 = new()
    {
        Rid = 3030056,
        Vid = 112096,
        Name = "月色鳍翅",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112096.png"
    };

    public static readonly MaterialModel _3030057 = new()
    {
        Rid = 3030057,
        Vid = 112095,
        Name = "羽状鳍翅",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112095.png"
    };

    public static readonly MaterialGroupModel G3030055 = new([_3030055, _3030056, _3030057], 3);

    public static readonly MaterialModel _3030058 = new()
    {
        Rid = 3030058,
        Vid = 112100,
        Name = "未熄的剑柄",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112100.png"
    };

    public static readonly MaterialModel _3030059 = new()
    {
        Rid = 3030059,
        Vid = 112099,
        Name = "裂断的剑柄",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112099.png"
    };

    public static readonly MaterialModel _3030060 = new()
    {
        Rid = 3030060,
        Vid = 112098,
        Name = "残毁的剑柄",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112098.png"
    };

    public static readonly MaterialGroupModel G3030058 = new([_3030058, _3030059, _3030060], 3);

    public static readonly MaterialModel _3030061 = new()
    {
        Rid = 3030061,
        Vid = 112109,
        Name = "意志巡游的符像",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112109.png"
    };

    public static readonly MaterialModel _3030062 = new()
    {
        Rid = 3030062,
        Vid = 112108,
        Name = "意志明晰的寄偶",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112108.png"
    };

    public static readonly MaterialModel _3030063 = new()
    {
        Rid = 3030063,
        Vid = 112107,
        Name = "意志破碎的残片",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112107.png"
    };

    public static readonly MaterialGroupModel G3030061 = new([_3030061, _3030062, _3030063], 3);

    public static readonly MaterialModel _3030064 = new()
    {
        Rid = 3030064,
        Vid = 112112,
        Name = "聚燃的游像眼",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112112.png"
    };

    public static readonly MaterialModel _3030065 = new()
    {
        Rid = 3030065,
        Vid = 112111,
        Name = "聚燃的命种",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112111.png"
    };

    public static readonly MaterialModel _3030066 = new()
    {
        Rid = 3030066,
        Vid = 112110,
        Name = "聚燃的石块",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112110.png"
    };

    public static readonly MaterialGroupModel G3030064 = new([_3030064, _3030065, _3030066], 3);

    public static readonly MaterialModel _3030067 = new()
    {
        Rid = 3030067,
        Vid = 112115,
        Name = "秘源真芯",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112115.png"
    };

    public static readonly MaterialModel _3030068 = new()
    {
        Rid = 3030068,
        Vid = 112114,
        Name = "秘源机鞘",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112114.png"
    };

    public static readonly MaterialModel _3030069 = new()
    {
        Rid = 3030069,
        Vid = 112113,
        Name = "秘源轴",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112113.png"
    };

    public static readonly MaterialGroupModel G3030067 = new([_3030067, _3030068, _3030069], 3);

    public static readonly MaterialModel _3030070 = new()
    {
        Rid = 3030070,
        Vid = 112118,
        Name = "迷光的蜷叶之心",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112118.png"
    };

    public static readonly MaterialModel _3030071 = new()
    {
        Rid = 3030071,
        Vid = 112117,
        Name = "惑光的阔叶",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112117.png"
    };

    public static readonly MaterialModel _3030072 = new()
    {
        Rid = 3030072,
        Vid = 112116,
        Name = "折光的胚芽",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112116.png"
    };

    public static readonly MaterialGroupModel G3030070 = new([_3030070, _3030071, _3030072], 3);

    public static readonly MaterialModel _3030073 = new()
    {
        Rid = 3030073,
        Vid = 112121,
        Name = "明燃的棱状壳",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112121.png"
    };

    public static readonly MaterialModel _3030074 = new()
    {
        Rid = 3030074,
        Vid = 112120,
        Name = "蕴热的背壳",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112120.png"
    };

    public static readonly MaterialModel _3030075 = new()
    {
        Rid = 3030075,
        Vid = 112119,
        Name = "冷裂壳块",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112119.png"
    };

    public static readonly MaterialGroupModel G3030073 = new([_3030073, _3030074, _3030075], 3);

    public static readonly MaterialModel _3030076 = new()
    {
        Rid = 3030076,
        Vid = 112130,
        Name = "霜夜的煌荣",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112130.png"
    };

    public static readonly MaterialModel _3030077 = new()
    {
        Rid = 3030077,
        Vid = 112129,
        Name = "霜夜的柔辉",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112129.png"
    };

    public static readonly MaterialModel _3030078 = new()
    {
        Rid = 3030078,
        Vid = 112128,
        Name = "霜夜的残照",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112128.png"
    };

    public static readonly MaterialGroupModel G3030076 = new([_3030076, _3030077, _3030078], 3);

    public static readonly MaterialModel _3030079 = new()
    {
        Rid = 3030079,
        Vid = 112133,
        Name = "繁光躯外骸",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112133.png"
    };

    public static readonly MaterialModel _3030080 = new()
    {
        Rid = 3030080,
        Vid = 112132,
        Name = "稀光遗骼",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112132.png"
    };

    public static readonly MaterialModel _3030081 = new()
    {
        Rid = 3030081,
        Vid = 112131,
        Name = "失光块骨",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112131.png"
    };

    public static readonly MaterialGroupModel G3030079 = new([_3030079, _3030080, _3030081], 3);

    public static readonly MaterialModel _3030082 = new()
    {
        Rid = 3030082,
        Vid = 112136,
        Name = "幽雾兜盔",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112136.png"
    };

    public static readonly MaterialModel _3030083 = new()
    {
        Rid = 3030083,
        Vid = 112135,
        Name = "幽雾片甲",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112135.png"
    };

    public static readonly MaterialModel _3030084 = new()
    {
        Rid = 3030084,
        Vid = 112134,
        Name = "幽雾化形",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112134.png"
    };

    public static readonly MaterialGroupModel G3030082 = new([_3030082, _3030083, _3030084], 3);

    // 304 - 角色与武器培养素材_123
    public static readonly MaterialModel _3040001 = new()
    {
        Rid = 3040001,
        Vid = 112004,
        Name = "史莱姆原浆",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112004.png"
    };

    public static readonly MaterialModel _3040002 = new()
    {
        Rid = 3040002,
        Vid = 112003,
        Name = "史莱姆清",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112003.png"
    };

    public static readonly MaterialModel _3040003 = new()
    {
        Rid = 3040003,
        Vid = 112002,
        Name = "史莱姆凝液",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112002.png"
    };

    public static readonly MaterialGroupModel G3040001 = new([_3040001, _3040002, _3040003], 3);

    public static readonly MaterialModel _3040004 = new()
    {
        Rid = 3040004,
        Vid = 112007,
        Name = "不祥的面具",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112007.png"
    };

    public static readonly MaterialModel _3040005 = new()
    {
        Rid = 3040005,
        Vid = 112006,
        Name = "污秽的面具",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112006.png"
    };

    public static readonly MaterialModel _3040006 = new()
    {
        Rid = 3040006,
        Vid = 112005,
        Name = "破损的面具",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112005.png"
    };

    public static readonly MaterialGroupModel G3040004 = new([_3040004, _3040005, _3040006], 3);

    public static readonly MaterialModel _3040007 = new()
    {
        Rid = 3040007,
        Vid = 112010,
        Name = "禁咒绘卷",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112010.png"
    };

    public static readonly MaterialModel _3040008 = new()
    {
        Rid = 3040008,
        Vid = 112009,
        Name = "封魔绘卷",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112009.png"
    };

    public static readonly MaterialModel _3040009 = new()
    {
        Rid = 3040009,
        Vid = 112008,
        Name = "导能绘卷",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112008.png"
    };

    public static readonly MaterialGroupModel G3040007 = new([_3040007, _3040008, _3040009], 3);

    public static readonly MaterialModel _3040010 = new()
    {
        Rid = 3040010,
        Vid = 112013,
        Name = "历战的箭簇",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112013.png"
    };

    public static readonly MaterialModel _3040011 = new()
    {
        Rid = 3040011,
        Vid = 112012,
        Name = "锐利的箭簇",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112012.png"
    };

    public static readonly MaterialModel _3040012 = new()
    {
        Rid = 3040012,
        Vid = 112011,
        Name = "牢固的箭簇",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112011.png"
    };

    public static readonly MaterialGroupModel G3040010 = new([_3040010, _3040011, _3040012], 3);

    public static readonly MaterialModel _3040013 = new()
    {
        Rid = 3040013,
        Vid = 112034,
        Name = "尉官的徽记",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112034.png"
    };

    public static readonly MaterialModel _3040014 = new()
    {
        Rid = 3040014,
        Vid = 112033,
        Name = "士官的徽记",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112033.png"
    };

    public static readonly MaterialModel _3040015 = new()
    {
        Rid = 3040015,
        Vid = 112032,
        Name = "新兵的徽记",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112032.png"
    };

    public static readonly MaterialGroupModel G3040013 = new([_3040013, _3040014, _3040015], 3);

    public static readonly MaterialModel _3040016 = new()
    {
        Rid = 3040016,
        Vid = 112037,
        Name = "攫金鸦印",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112037.png"
    };

    public static readonly MaterialModel _3040017 = new()
    {
        Rid = 3040017,
        Vid = 112036,
        Name = "藏银鸦印",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112036.png"
    };

    public static readonly MaterialModel _3040018 = new()
    {
        Rid = 3040018,
        Vid = 112035,
        Name = "寻宝鸦印",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112035.png"
    };

    public static readonly MaterialGroupModel G3040016 = new([_3040016, _3040017, _3040018], 3);

    public static readonly MaterialModel _3040019 = new()
    {
        Rid = 3040019,
        Vid = 112040,
        Name = "原素花蜜",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112040.png"
    };

    public static readonly MaterialModel _3040020 = new()
    {
        Rid = 3040020,
        Vid = 112039,
        Name = "微光花蜜",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112039.png"
    };

    public static readonly MaterialModel _3040021 = new()
    {
        Rid = 3040021,
        Vid = 112038,
        Name = "骗骗花蜜",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112038.png"
    };

    public static readonly MaterialGroupModel G3040019 = new([_3040019, _3040020, _3040021], 3);

    public static readonly MaterialModel _3040022 = new()
    {
        Rid = 3040022,
        Vid = 112046,
        Name = "名刀镡",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112046.png"
    };

    public static readonly MaterialModel _3040023 = new()
    {
        Rid = 3040023,
        Vid = 112045,
        Name = "影打刀镡",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112045.png"
    };

    public static readonly MaterialModel _3040024 = new()
    {
        Rid = 3040024,
        Vid = 112044,
        Name = "破旧的刀镡",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112044.png"
    };

    public static readonly MaterialGroupModel G3040022 = new([_3040022, _3040023, _3040024], 3);

    public static readonly MaterialModel _3040025 = new()
    {
        Rid = 3040025,
        Vid = 112055,
        Name = "浮游晶化核",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112055.png"
    };

    public static readonly MaterialModel _3040026 = new()
    {
        Rid = 3040026,
        Vid = 112054,
        Name = "浮游幽核",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112054.png"
    };

    public static readonly MaterialModel _3040027 = new()
    {
        Rid = 3040027,
        Vid = 112053,
        Name = "浮游干核",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112053.png"
    };

    public static readonly MaterialGroupModel G3040025 = new([_3040025, _3040026, _3040027], 3);

    public static readonly MaterialModel _3040028 = new()
    {
        Rid = 3040028,
        Vid = 112061,
        Name = "孢囊晶尘",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112061.png"
    };

    public static readonly MaterialModel _3040029 = new()
    {
        Rid = 3040029,
        Vid = 112060,
        Name = "荧光孢粉",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112060.png"
    };

    public static readonly MaterialModel _3040030 = new()
    {
        Rid = 3040030,
        Vid = 112059,
        Name = "蕈兽孢子",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112059.png"
    };

    public static readonly MaterialGroupModel G3040028 = new([_3040028, _3040029, _3040030], 3);

    public static readonly MaterialModel _3040031 = new()
    {
        Rid = 3040031,
        Vid = 112067,
        Name = "织金红绸",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112067.png"
    };

    public static readonly MaterialModel _3040032 = new()
    {
        Rid = 3040032,
        Vid = 112066,
        Name = "镶边红绸",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112066.png"
    };

    public static readonly MaterialModel _3040033 = new()
    {
        Rid = 3040033,
        Vid = 112065,
        Name = "褪色红绸",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112065.png"
    };

    public static readonly MaterialGroupModel G3040031 = new([_3040031, _3040032, _3040033], 3);

    public static readonly MaterialModel _3040034 = new()
    {
        Rid = 3040034,
        Vid = 112082,
        Name = "异色结晶石",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112082.png"
    };

    public static readonly MaterialModel _3040035 = new()
    {
        Rid = 3040035,
        Vid = 112081,
        Name = "异海之块",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112081.png"
    };

    public static readonly MaterialModel _3040036 = new()
    {
        Rid = 3040036,
        Vid = 112080,
        Name = "异海凝珠",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112080.png"
    };

    public static readonly MaterialGroupModel G3040034 = new([_3040034, _3040035, _3040036], 3);

    public static readonly MaterialModel _3040037 = new()
    {
        Rid = 3040037,
        Vid = 112085,
        Name = "奇械机芯齿轮",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112085.png"
    };

    public static readonly MaterialModel _3040038 = new()
    {
        Rid = 3040038,
        Vid = 112084,
        Name = "机关正齿轮",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112084.png"
    };

    public static readonly MaterialModel _3040039 = new()
    {
        Rid = 3040039,
        Vid = 112083,
        Name = "啮合齿轮",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112083.png"
    };

    public static readonly MaterialGroupModel G3040037 = new([_3040037, _3040038, _3040039], 3);

    public static readonly MaterialModel _3040040 = new()
    {
        Rid = 3040040,
        Vid = 112103,
        Name = "横行霸者的利齿",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112103.png"
    };

    public static readonly MaterialModel _3040041 = new()
    {
        Rid = 3040041,
        Vid = 112102,
        Name = "老练的坚齿",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112102.png"
    };

    public static readonly MaterialModel _3040042 = new()
    {
        Rid = 3040042,
        Vid = 112101,
        Name = "稚嫩的尖齿",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112101.png"
    };

    public static readonly MaterialGroupModel G3040040 = new([_3040040, _3040041, _3040042], 3);

    public static readonly MaterialModel _3040043 = new()
    {
        Rid = 3040043,
        Vid = 112106,
        Name = "龙冠武士的金哨",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112106.png"
    };

    public static readonly MaterialModel _3040044 = new()
    {
        Rid = 3040044,
        Vid = 112105,
        Name = "战士的铁哨",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112105.png"
    };

    public static readonly MaterialModel _3040045 = new()
    {
        Rid = 3040045,
        Vid = 112104,
        Name = "卫从的木哨",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112104.png"
    };

    public static readonly MaterialGroupModel G3040043 = new([_3040043, _3040044, _3040045], 3);

    public static readonly MaterialModel _3040046 = new()
    {
        Rid = 3040046,
        Vid = 112124,
        Name = "精制机轴",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112124.png"
    };

    public static readonly MaterialModel _3040047 = new()
    {
        Rid = 3040047,
        Vid = 112123,
        Name = "加固机轴",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112123.png"
    };

    public static readonly MaterialModel _3040048 = new()
    {
        Rid = 3040048,
        Vid = 112122,
        Name = "毁损机轴",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112122.png"
    };

    public static readonly MaterialGroupModel G3040046 = new([_3040046, _3040047, _3040048], 3);

    public static readonly MaterialModel _3040049 = new()
    {
        Rid = 3040049,
        Vid = 112127,
        Name = "霜镌的执凭",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112127.png"
    };

    public static readonly MaterialModel _3040050 = new()
    {
        Rid = 3040050,
        Vid = 112126,
        Name = "精致的执凭",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112126.png"
    };

    public static readonly MaterialModel _3040051 = new()
    {
        Rid = 3040051,
        Vid = 112125,
        Name = "磨损的执凭",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112125.png"
    };

    public static readonly MaterialGroupModel G3040049 = new([_3040049, _3040050, _3040051], 3);

    // 305 - 角色培养素材_周本
    public static readonly MaterialModel _3050001 = new()
    {
        Rid = 3050001,
        Vid = 113003,
        Name = "东风之翎",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113003.png"
    };

    public static readonly MaterialModel _3050002 = new()
    {
        Rid = 3050002,
        Vid = 113004,
        Name = "东风之爪",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113004.png"
    };

    public static readonly MaterialModel _3050003 = new()
    {
        Rid = 3050003,
        Vid = 113005,
        Name = "东风的吐息",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113005.png"
    };

    public static readonly MaterialModel _3050004 = new()
    {
        Rid = 3050004,
        Vid = 113006,
        Name = "北风之尾",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113006.png"
    };

    public static readonly MaterialModel _3050005 = new()
    {
        Rid = 3050005,
        Vid = 113007,
        Name = "北风之环",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113007.png"
    };

    public static readonly MaterialModel _3050006 = new()
    {
        Rid = 3050006,
        Vid = 113008,
        Name = "北风的魂匣",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113008.png"
    };

    public static readonly MaterialModel _3050007 = new()
    {
        Rid = 3050007,
        Vid = 113013,
        Name = "吞天之鲸·只角",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113013.png"
    };

    public static readonly MaterialModel _3050008 = new()
    {
        Rid = 3050008,
        Vid = 113014,
        Name = "魔王之刃·残片",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113014.png"
    };

    public static readonly MaterialModel _3050009 = new()
    {
        Rid = 3050009,
        Vid = 113015,
        Name = "武炼之魂·孤影",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113015.png"
    };

    public static readonly MaterialModel _3050010 = new()
    {
        Rid = 3050010,
        Vid = 113017,
        Name = "龙王之冕",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113017.png"
    };

    public static readonly MaterialModel _3050011 = new()
    {
        Rid = 3050011,
        Vid = 113018,
        Name = "血玉之枝",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113018.png"
    };

    public static readonly MaterialModel _3050012 = new()
    {
        Rid = 3050012,
        Vid = 113019,
        Name = "鎏金之鳞",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113019.png"
    };

    public static readonly MaterialModel _3050013 = new()
    {
        Rid = 3050013,
        Vid = 113025,
        Name = "熔毁之刻",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113025.png"
    };

    public static readonly MaterialModel _3050014 = new()
    {
        Rid = 3050014,
        Vid = 113026,
        Name = "狱火之蝶",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113026.png"
    };

    public static readonly MaterialModel _3050015 = new()
    {
        Rid = 3050015,
        Vid = 113027,
        Name = "灰烬之心",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113027.png"
    };

    public static readonly MaterialModel _3050016 = new()
    {
        Rid = 3050016,
        Vid = 113032,
        Name = "凶将之手眼",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113032.png"
    };

    public static readonly MaterialModel _3050017 = new()
    {
        Rid = 3050017,
        Vid = 113033,
        Name = "祸神之禊泪",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113033.png"
    };

    public static readonly MaterialModel _3050018 = new()
    {
        Rid = 3050018,
        Vid = 113034,
        Name = "万劫之真意",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113034.png"
    };

    public static readonly MaterialModel _3050019 = new()
    {
        Rid = 3050019,
        Vid = 113041,
        Name = "傀儡的悬丝",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113041.png"
    };

    public static readonly MaterialModel _3050020 = new()
    {
        Rid = 3050020,
        Vid = 113042,
        Name = "无心的渊镜",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113042.png"
    };

    public static readonly MaterialModel _3050021 = new()
    {
        Rid = 3050021,
        Vid = 113043,
        Name = "空行的虚铃",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113043.png"
    };

    public static readonly MaterialModel _3050022 = new()
    {
        Rid = 3050022,
        Vid = 113046,
        Name = "生长天地之蕨草",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113046.png"
    };

    public static readonly MaterialModel _3050023 = new()
    {
        Rid = 3050023,
        Vid = 113047,
        Name = "原初绿洲之初绽",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113047.png"
    };

    public static readonly MaterialModel _3050024 = new()
    {
        Rid = 3050024,
        Vid = 113048,
        Name = "亘古树海之一瞬",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113048.png"
    };

    public static readonly MaterialModel _3050025 = new()
    {
        Rid = 3050025,
        Vid = 113054,
        Name = "无光丝线",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113054.png"
    };

    public static readonly MaterialModel _3050026 = new()
    {
        Rid = 3050026,
        Vid = 113055,
        Name = "无光涡眼",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113055.png"
    };

    public static readonly MaterialModel _3050027 = new()
    {
        Rid = 3050027,
        Vid = 113056,
        Name = "无光质块",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113056.png"
    };

    public static readonly MaterialModel _3050028 = new()
    {
        Rid = 3050028,
        Vid = 113060,
        Name = "残火灯烛",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113060.png"
    };

    public static readonly MaterialModel _3050029 = new()
    {
        Rid = 3050029,
        Vid = 113061,
        Name = "丝织之羽",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113061.png"
    };

    public static readonly MaterialModel _3050030 = new()
    {
        Rid = 3050030,
        Vid = 113062,
        Name = "否定裁断",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113062.png"
    };

    public static readonly MaterialModel _3050031 = new()
    {
        Rid = 3050031,
        Vid = 113063,
        Name = "星与火的基石",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113063.png"
    };

    public static readonly MaterialModel _3050032 = new()
    {
        Rid = 3050032,
        Vid = 113068,
        Name = "蚀灭的灵犀",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113068.png"
    };

    public static readonly MaterialModel _3050033 = new()
    {
        Rid = 3050033,
        Vid = 113069,
        Name = "蚀灭的阳焰",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113069.png"
    };

    public static readonly MaterialModel _3050034 = new()
    {
        Rid = 3050034,
        Vid = 113070,
        Name = "蚀灭的鳞羽",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113070.png"
    };

    public static readonly MaterialModel _3050035 = new()
    {
        Rid = 3050035,
        Vid = 113073,
        Name = "升扬样本·骑士",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113073.png"
    };

    public static readonly MaterialModel _3050036 = new()
    {
        Rid = 3050036,
        Vid = 113074,
        Name = "升扬样本·战车",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113074.png"
    };

    public static readonly MaterialModel _3050037 = new()
    {
        Rid = 3050037,
        Vid = 113075,
        Name = "升扬样本·王族",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113075.png"
    };

    // 306 - 角色培养素材_40体力BOSS
    public static readonly MaterialModel _3060001 = new()
    {
        Rid = 3060001,
        Vid = 113001,
        Name = "飓风之种",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113001.png"
    };

    public static readonly MaterialModel _3060002 = new()
    {
        Rid = 3060002,
        Vid = 113002,
        Name = "雷光棱镜",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113002.png"
    };

    public static readonly MaterialModel _3060003 = new()
    {
        Rid = 3060003,
        Vid = 113009,
        Name = "玄岩之塔",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113009.png"
    };

    public static readonly MaterialModel _3060004 = new()
    {
        Rid = 3060004,
        Vid = 113010,
        Name = "极寒之核",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113010.png"
    };

    public static readonly MaterialModel _3060005 = new()
    {
        Rid = 3060005,
        Vid = 113011,
        Name = "常燃火种",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113011.png"
    };

    public static readonly MaterialModel _3060006 = new()
    {
        Rid = 3060006,
        Vid = 113012,
        Name = "净水之心",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113012.png"
    };

    public static readonly MaterialModel _3060007 = new()
    {
        Rid = 3060007,
        Vid = 113016,
        Name = "未熟之玉",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113016.png"
    };

    public static readonly MaterialModel _3060008 = new()
    {
        Rid = 3060008,
        Vid = 113020,
        Name = "晶凝之华",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113020.png"
    };

    public static readonly MaterialModel _3060009 = new()
    {
        Rid = 3060009,
        Vid = 113022,
        Name = "魔偶机心",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113022.png"
    };

    public static readonly MaterialModel _3060010 = new()
    {
        Rid = 3060010,
        Vid = 113023,
        Name = "恒常机关之心",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113023.png"
    };

    public static readonly MaterialModel _3060011 = new()
    {
        Rid = 3060011,
        Vid = 113024,
        Name = "阴燃之珠",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113024.png"
    };

    public static readonly MaterialModel _3060012 = new()
    {
        Rid = 3060012,
        Vid = 113028,
        Name = "排异之露",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113028.png"
    };

    public static readonly MaterialModel _3060013 = new()
    {
        Rid = 3060013,
        Vid = 113029,
        Name = "雷霆数珠",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113029.png"
    };

    public static readonly MaterialModel _3060014 = new()
    {
        Rid = 3060014,
        Vid = 113030,
        Name = "兽境王器",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113030.png"
    };

    public static readonly MaterialModel _3060015 = new()
    {
        Rid = 3060015,
        Vid = 113031,
        Name = "龙嗣伪鳍",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113031.png"
    };

    public static readonly MaterialModel _3060016 = new()
    {
        Rid = 3060016,
        Vid = 113035,
        Name = "符纹之齿",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113035.png"
    };

    public static readonly MaterialModel _3060017 = new()
    {
        Rid = 3060017,
        Vid = 113036,
        Name = "蕈王钩喙",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113036.png"
    };

    public static readonly MaterialModel _3060018 = new()
    {
        Rid = 3060018,
        Vid = 113037,
        Name = "藏雷野实",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113037.png"
    };

    public static readonly MaterialModel _3060019 = new()
    {
        Rid = 3060019,
        Vid = 113038,
        Name = "永续机芯",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113038.png"
    };

    public static readonly MaterialModel _3060020 = new()
    {
        Rid = 3060020,
        Vid = 113039,
        Name = "导光四面体",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113039.png"
    };

    public static readonly MaterialModel _3060021 = new()
    {
        Rid = 3060021,
        Vid = 113040,
        Name = "灭诤草蔓",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113040.png"
    };

    public static readonly MaterialModel _3060022 = new()
    {
        Rid = 3060022,
        Vid = 113044,
        Name = "苍砾蕊羽",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113044.png"
    };

    public static readonly MaterialModel _3060023 = new()
    {
        Rid = 3060023,
        Vid = 113045,
        Name = "常暗圆环",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113045.png"
    };

    public static readonly MaterialModel _3060024 = new()
    {
        Rid = 3060024,
        Vid = 113049,
        Name = "奇械发条备件·歌裴莉娅",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113049.png"
    };

    public static readonly MaterialModel _3060025 = new()
    {
        Rid = 3060025,
        Vid = 113050,
        Name = "奇械发条备件·科培琉司",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113050.png"
    };

    public static readonly MaterialModel _3060026 = new()
    {
        Rid = 3060026,
        Vid = 113051,
        Name = "帝皇的决断",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113051.png"
    };

    public static readonly MaterialModel _3060027 = new()
    {
        Rid = 3060027,
        Vid = 113052,
        Name = "「图比昂装置」",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113052.png"
    };

    public static readonly MaterialModel _3060028 = new()
    {
        Rid = 3060028,
        Vid = 113053,
        Name = "原海麟角",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113053.png"
    };

    public static readonly MaterialModel _3060029 = new()
    {
        Rid = 3060029,
        Vid = 113057,
        Name = "未能达成超越之水",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113057.png"
    };

    public static readonly MaterialModel _3060030 = new()
    {
        Rid = 3060030,
        Vid = 113058,
        Name = "凝云鳞甲",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113058.png"
    };

    public static readonly MaterialModel _3060031 = new()
    {
        Rid = 3060031,
        Vid = 113059,
        Name = "金色旋律的断章",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113059.png"
    };

    public static readonly MaterialModel _3060032 = new()
    {
        Rid = 3060032,
        Vid = 113064,
        Name = "受祝所缚之印",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113064.png"
    };

    public static readonly MaterialModel _3060033 = new()
    {
        Rid = 3060033,
        Vid = 113065,
        Name = "过熟的火榴果",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113065.png"
    };

    public static readonly MaterialModel _3060034 = new()
    {
        Rid = 3060034,
        Vid = 113066,
        Name = "秘刻金纹的源核",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113066.png"
    };

    public static readonly MaterialModel _3060035 = new()
    {
        Rid = 3060035,
        Vid = 113067,
        Name = "深邃纠缠的凝视",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113067.png"
    };

    public static readonly MaterialModel _3060036 = new()
    {
        Rid = 3060036,
        Vid = 113071,
        Name = "谜土的护符",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113071.png"
    };

    public static readonly MaterialModel _3060037 = new()
    {
        Rid = 3060037,
        Vid = 113072,
        Name = "龙像的无智核",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113072.png"
    };

    public static readonly MaterialModel _3060038 = new()
    {
        Rid = 3060038,
        Vid = 113076,
        Name = "秘源积气喉",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113076.png"
    };

    public static readonly MaterialModel _3060039 = new()
    {
        Rid = 3060039,
        Vid = 113077,
        Name = "精密型月矩力冲鸭模具",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113077.png"
    };

    public static readonly MaterialModel _3060040 = new()
    {
        Rid = 3060040,
        Vid = 113078,
        Name = "承光的鳞羽",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113078.png"
    };

    public static readonly MaterialModel _3060041 = new()
    {
        Rid = 3060041,
        Vid = 113079,
        Name = "漫光的辉角",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113079.png"
    };

    public static readonly MaterialModel _3060042 = new()
    {
        Rid = 3060042,
        Vid = 113080,
        Name = "循环式军用月矩核心",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterLevelUp1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_113080.png"
    };

    // 307 - 角色突破素材_钻儿块儿片儿粒儿
    public static readonly MaterialModel _3070101 = new()
    {
        Rid = 3070101,
        Vid = 104104,
        Name = "璀璨原钻",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104104.png"
    };

    public static readonly MaterialModel _3070102 = new()
    {
        Rid = 3070102,
        Vid = 104103,
        Name = "璀璨原钻块",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104103.png"
    };

    public static readonly MaterialModel _3070103 = new()
    {
        Rid = 3070103,
        Vid = 104102,
        Name = "璀璨原钻断片",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104102.png"
    };

    public static readonly MaterialModel _3070104 = new()
    {
        Rid = 3070104,
        Vid = 104101,
        Name = "璀璨原钻碎屑",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104101.png"
    };

    public static readonly MaterialGroupModel G3070101 = new([_3070101, _3070102, _3070103, _3070104], 3);

    public static readonly MaterialModel _3070201 = new()
    {
        Rid = 3070201,
        Vid = 104114,
        Name = "燃愿玛瑙",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104114.png"
    };

    public static readonly MaterialModel _3070202 = new()
    {
        Rid = 3070202,
        Vid = 104113,
        Name = "燃愿玛瑙块",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104113.png"
    };

    public static readonly MaterialModel _3070203 = new()
    {
        Rid = 3070203,
        Vid = 104112,
        Name = "燃愿玛瑙断片",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104112.png"
    };

    public static readonly MaterialModel _3070204 = new()
    {
        Rid = 3070204,
        Vid = 104111,
        Name = "燃愿玛瑙碎屑",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104111.png"
    };

    public static readonly MaterialGroupModel G3070201 = new([_3070201, _3070202, _3070203, _3070204], 3);

    public static readonly MaterialModel _3070301 = new()
    {
        Rid = 3070301,
        Vid = 104124,
        Name = "涤净青金",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104124.png"
    };

    public static readonly MaterialModel _3070302 = new()
    {
        Rid = 3070302,
        Vid = 104123,
        Name = "涤净青金块",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104123.png"
    };

    public static readonly MaterialModel _3070303 = new()
    {
        Rid = 3070303,
        Vid = 104122,
        Name = "涤净青金断片",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104122.png"
    };

    public static readonly MaterialModel _3070304 = new()
    {
        Rid = 3070304,
        Vid = 104121,
        Name = "涤净青金碎屑",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104121.png"
    };

    public static readonly MaterialGroupModel G3070301 = new([_3070301, _3070302, _3070303, _3070304], 3);

    public static readonly MaterialModel _3070401 = new()
    {
        Rid = 3070401,
        Vid = 104134,
        Name = "生长碧翡",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104134.png"
    };

    public static readonly MaterialModel _3070402 = new()
    {
        Rid = 3070402,
        Vid = 104133,
        Name = "生长碧翡块",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104133.png"
    };

    public static readonly MaterialModel _3070403 = new()
    {
        Rid = 3070403,
        Vid = 104132,
        Name = "生长碧翡断片",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104132.png"
    };

    public static readonly MaterialModel _3070404 = new()
    {
        Rid = 3070404,
        Vid = 104131,
        Name = "生长碧翡碎屑",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104131.png"
    };

    public static readonly MaterialGroupModel G3070401 = new([_3070401, _3070402, _3070403, _3070404], 3);

    public static readonly MaterialModel _3070501 = new()
    {
        Rid = 3070501,
        Vid = 104144,
        Name = "最胜紫晶",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104144.png"
    };

    public static readonly MaterialModel _3070502 = new()
    {
        Rid = 3070502,
        Vid = 104143,
        Name = "最胜紫晶块",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104143.png"
    };

    public static readonly MaterialModel _3070503 = new()
    {
        Rid = 3070503,
        Vid = 104142,
        Name = "最胜紫晶断片",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104142.png"
    };

    public static readonly MaterialModel _3070504 = new()
    {
        Rid = 3070504,
        Vid = 104141,
        Name = "最胜紫晶碎屑",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104141.png"
    };

    public static readonly MaterialGroupModel G3070501 = new([_3070501, _3070502, _3070503, _3070504], 3);

    public static readonly MaterialModel _3070601 = new()
    {
        Rid = 3070601,
        Vid = 104154,
        Name = "自在松石",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104154.png"
    };

    public static readonly MaterialModel _3070602 = new()
    {
        Rid = 3070602,
        Vid = 104153,
        Name = "自在松石块",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104153.png"
    };

    public static readonly MaterialModel _3070603 = new()
    {
        Rid = 3070603,
        Vid = 104152,
        Name = "自在松石断片",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104152.png"
    };

    public static readonly MaterialModel _3070604 = new()
    {
        Rid = 3070604,
        Vid = 104151,
        Name = "自在松石碎屑",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104151.png"
    };

    public static readonly MaterialGroupModel G3070601 = new([_3070601, _3070602, _3070603, _3070604], 3);

    public static readonly MaterialModel _3070701 = new()
    {
        Rid = 3070701,
        Vid = 104164,
        Name = "哀叙冰玉",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104164.png"
    };

    public static readonly MaterialModel _3070702 = new()
    {
        Rid = 3070702,
        Vid = 104163,
        Name = "哀叙冰玉块",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104163.png"
    };

    public static readonly MaterialModel _3070703 = new()
    {
        Rid = 3070703,
        Vid = 104162,
        Name = "哀叙冰玉断片",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104162.png"
    };

    public static readonly MaterialModel _3070704 = new()
    {
        Rid = 3070704,
        Vid = 104161,
        Name = "哀叙冰玉碎屑",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104161.png"
    };

    public static readonly MaterialGroupModel G3070701 = new([_3070701, _3070702, _3070703, _3070704], 3);

    public static readonly MaterialModel _3070801 = new()
    {
        Rid = 3070801,
        Vid = 104174,
        Name = "坚牢黄玉",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104174.png"
    };

    public static readonly MaterialModel _3070802 = new()
    {
        Rid = 3070802,
        Vid = 104173,
        Name = "坚牢黄玉块",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104173.png"
    };

    public static readonly MaterialModel _3070803 = new()
    {
        Rid = 3070803,
        Vid = 104172,
        Name = "坚牢黄玉断片",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104172.png"
    };

    public static readonly MaterialModel _3070804 = new()
    {
        Rid = 3070804,
        Vid = 104171,
        Name = "坚牢黄玉碎屑",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104171.png"
    };

    public static readonly MaterialGroupModel G3070801 = new([_3070801, _3070802, _3070803, _3070804], 3);

    // 308 - 角色天赋素材
    public static readonly MaterialModel _3080000 = new()
    {
        Rid = 3080000,
        Vid = 104319,
        Name = "智识之冕",
        Star = 5,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104319.png"
    };

    public static readonly MaterialModel _3080001 = new()
    {
        Rid = 3080001,
        Vid = 104303,
        Name = "「自由」的哲学",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104303.png"
    };

    public static readonly MaterialModel _3080002 = new()
    {
        Rid = 3080002,
        Vid = 104302,
        Name = "「自由」的指引",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104302.png"
    };

    public static readonly MaterialModel _3080003 = new()
    {
        Rid = 3080003,
        Vid = 104301,
        Name = "「自由」的教导",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104301.png"
    };

    public static readonly MaterialGroupModel G3080001 = new([_3080001, _3080002, _3080003], 3);

    public static readonly MaterialModel _3080004 = new()
    {
        Rid = 3080004,
        Vid = 104306,
        Name = "「抗争」的哲学",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104306.png"
    };

    public static readonly MaterialModel _3080005 = new()
    {
        Rid = 3080005,
        Vid = 104305,
        Name = "「抗争」的指引",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104305.png"
    };

    public static readonly MaterialModel _3080006 = new()
    {
        Rid = 3080006,
        Vid = 104304,
        Name = "「抗争」的教导",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104304.png"
    };

    public static readonly MaterialGroupModel G3080004 = new([_3080004, _3080005, _3080006], 3);

    public static readonly MaterialModel _3080007 = new()
    {
        Rid = 3080007,
        Vid = 104309,
        Name = "「诗文」的哲学",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104309.png"
    };

    public static readonly MaterialModel _3080008 = new()
    {
        Rid = 3080008,
        Vid = 104308,
        Name = "「诗文」的指引",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104308.png"
    };

    public static readonly MaterialModel _3080009 = new()
    {
        Rid = 3080009,
        Vid = 104307,
        Name = "「诗文」的教导",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104307.png"
    };

    public static readonly MaterialGroupModel G3080007 = new([_3080007, _3080008, _3080009], 3);

    public static readonly MaterialModel _3080010 = new()
    {
        Rid = 3080010,
        Vid = 104312,
        Name = "「繁荣」的哲学",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104312.png"
    };

    public static readonly MaterialModel _3080011 = new()
    {
        Rid = 3080011,
        Vid = 104311,
        Name = "「繁荣」的指引",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104311.png"
    };

    public static readonly MaterialModel _3080012 = new()
    {
        Rid = 3080012,
        Vid = 104310,
        Name = "「繁荣」的教导",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104310.png"
    };

    public static readonly MaterialGroupModel G3080010 = new([_3080010, _3080011, _3080012], 3);

    public static readonly MaterialModel _3080013 = new()
    {
        Rid = 3080013,
        Vid = 104315,
        Name = "「勤劳」的哲学",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104315.png"
    };

    public static readonly MaterialModel _3080014 = new()
    {
        Rid = 3080014,
        Vid = 104314,
        Name = "「勤劳」的指引",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104314.png"
    };

    public static readonly MaterialModel _3080015 = new()
    {
        Rid = 3080015,
        Vid = 104313,
        Name = "「勤劳」的教导",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104313.png"
    };

    public static readonly MaterialGroupModel G3080013 = new([_3080013, _3080014, _3080015], 3);

    public static readonly MaterialModel _3080016 = new()
    {
        Rid = 3080016,
        Vid = 104318,
        Name = "「黄金」的哲学",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104318.png"
    };

    public static readonly MaterialModel _3080017 = new()
    {
        Rid = 3080017,
        Vid = 104317,
        Name = "「黄金」的指引",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104317.png"
    };

    public static readonly MaterialModel _3080018 = new()
    {
        Rid = 3080018,
        Vid = 104316,
        Name = "「黄金」的教导",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104316.png"
    };

    public static readonly MaterialGroupModel G3080016 = new([_3080016, _3080017, _3080018], 3);

    public static readonly MaterialModel _3080019 = new()
    {
        Rid = 3080019,
        Vid = 104322,
        Name = "「浮世」的哲学",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104322.png"
    };

    public static readonly MaterialModel _3080020 = new()
    {
        Rid = 3080020,
        Vid = 104321,
        Name = "「浮世」的指引",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104321.png"
    };

    public static readonly MaterialModel _3080021 = new()
    {
        Rid = 3080021,
        Vid = 104320,
        Name = "「浮世」的教导",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104320.png"
    };

    public static readonly MaterialGroupModel G3080019 = new([_3080019, _3080020, _3080021], 3);

    public static readonly MaterialModel _3080022 = new()
    {
        Rid = 3080022,
        Vid = 104325,
        Name = "「风雅」的哲学",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104325.png"
    };

    public static readonly MaterialModel _3080023 = new()
    {
        Rid = 3080023,
        Vid = 104324,
        Name = "「风雅」的指引",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104324.png"
    };

    public static readonly MaterialModel _3080024 = new()
    {
        Rid = 3080024,
        Vid = 104323,
        Name = "「风雅」的教导",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104323.png"
    };

    public static readonly MaterialGroupModel G3080022 = new([_3080022, _3080023, _3080024], 3);

    public static readonly MaterialModel _3080025 = new()
    {
        Rid = 3080025,
        Vid = 104328,
        Name = "「天光」的哲学",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104328.png"
    };

    public static readonly MaterialModel _3080026 = new()
    {
        Rid = 3080026,
        Vid = 104327,
        Name = "「天光」的指引",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104327.png"
    };

    public static readonly MaterialModel _3080027 = new()
    {
        Rid = 3080027,
        Vid = 104326,
        Name = "「天光」的教导",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104326.png"
    };

    public static readonly MaterialGroupModel G3080025 = new([_3080025, _3080026, _3080027], 3);

    public static readonly MaterialModel _3080028 = new()
    {
        Rid = 3080028,
        Vid = 104331,
        Name = "「诤言」的哲学",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104331.png"
    };

    public static readonly MaterialModel _3080029 = new()
    {
        Rid = 3080029,
        Vid = 104330,
        Name = "「诤言」的指引",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104330.png"
    };

    public static readonly MaterialModel _3080030 = new()
    {
        Rid = 3080030,
        Vid = 104329,
        Name = "「诤言」的教导",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104329.png"
    };

    public static readonly MaterialGroupModel G3080028 = new([_3080028, _3080029, _3080030], 3);

    public static readonly MaterialModel _3080031 = new()
    {
        Rid = 3080031,
        Vid = 104334,
        Name = "「巧思」的哲学",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104334.png"
    };

    public static readonly MaterialModel _3080032 = new()
    {
        Rid = 3080032,
        Vid = 104333,
        Name = "「巧思」的指引",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104333.png"
    };

    public static readonly MaterialModel _3080033 = new()
    {
        Rid = 3080033,
        Vid = 104332,
        Name = "「巧思」的教导",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104332.png"
    };

    public static readonly MaterialGroupModel G3080031 = new([_3080031, _3080032, _3080033], 3);

    public static readonly MaterialModel _3080034 = new()
    {
        Rid = 3080034,
        Vid = 104337,
        Name = "「笃行」的哲学",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104337.png"
    };

    public static readonly MaterialModel _3080035 = new()
    {
        Rid = 3080035,
        Vid = 104336,
        Name = "「笃行」的指引",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104336.png"
    };

    public static readonly MaterialModel _3080036 = new()
    {
        Rid = 3080036,
        Vid = 104335,
        Name = "「笃行」的教导",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104335.png"
    };

    public static readonly MaterialGroupModel G3080034 = new([_3080034, _3080035, _3080036], 3);

    public static readonly MaterialModel _3080037 = new()
    {
        Rid = 3080037,
        Vid = 104340,
        Name = "「公平」的哲学",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104340.png"
    };

    public static readonly MaterialModel _3080038 = new()
    {
        Rid = 3080038,
        Vid = 104339,
        Name = "「公平」的指引",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104339.png"
    };

    public static readonly MaterialModel _3080039 = new()
    {
        Rid = 3080039,
        Vid = 104338,
        Name = "「公平」的教导",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104338.png"
    };

    public static readonly MaterialGroupModel G3080037 = new([_3080037, _3080038, _3080039], 3);

    public static readonly MaterialModel _3080040 = new()
    {
        Rid = 3080040,
        Vid = 104343,
        Name = "「正义」的哲学",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104343.png"
    };

    public static readonly MaterialModel _3080041 = new()
    {
        Rid = 3080041,
        Vid = 104342,
        Name = "「正义」的指引",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104342.png"
    };

    public static readonly MaterialModel _3080042 = new()
    {
        Rid = 3080042,
        Vid = 104341,
        Name = "「正义」的教导",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104341.png"
    };

    public static readonly MaterialGroupModel G3080040 = new([_3080040, _3080041, _3080042], 3);

    public static readonly MaterialModel _3080043 = new()
    {
        Rid = 3080043,
        Vid = 104346,
        Name = "「秩序」的哲学",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104346.png"
    };

    public static readonly MaterialModel _3080044 = new()
    {
        Rid = 3080044,
        Vid = 104345,
        Name = "「秩序」的指引",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104345.png"
    };

    public static readonly MaterialModel _3080045 = new()
    {
        Rid = 3080045,
        Vid = 104344,
        Name = "「秩序」的教导",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104344.png"
    };

    public static readonly MaterialGroupModel G3080043 = new([_3080043, _3080044, _3080045], 3);

    public static readonly MaterialModel _3080046 = new()
    {
        Rid = 3080046,
        Vid = 104349,
        Name = "「角逐」的哲学",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104349.png"
    };

    public static readonly MaterialModel _3080047 = new()
    {
        Rid = 3080047,
        Vid = 104348,
        Name = "「角逐」的指引",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104348.png"
    };

    public static readonly MaterialModel _3080048 = new()
    {
        Rid = 3080048,
        Vid = 104347,
        Name = "「角逐」的教导",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104347.png"
    };

    public static readonly MaterialGroupModel G3080046 = new([_3080046, _3080047, _3080048], 3);

    public static readonly MaterialModel _3080049 = new()
    {
        Rid = 3080049,
        Vid = 104352,
        Name = "「焚燔」的哲学",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104352.png"
    };

    public static readonly MaterialModel _3080050 = new()
    {
        Rid = 3080050,
        Vid = 104351,
        Name = "「焚燔」的指引",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104351.png"
    };

    public static readonly MaterialModel _3080051 = new()
    {
        Rid = 3080051,
        Vid = 104350,
        Name = "「焚燔」的教导",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104350.png"
    };

    public static readonly MaterialGroupModel G3080049 = new([_3080049, _3080050, _3080051], 3);

    public static readonly MaterialModel _3080052 = new()
    {
        Rid = 3080052,
        Vid = 104355,
        Name = "「纷争」的哲学",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104355.png"
    };

    public static readonly MaterialModel _3080053 = new()
    {
        Rid = 3080053,
        Vid = 104354,
        Name = "「纷争」的指引",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104354.png"
    };

    public static readonly MaterialModel _3080054 = new()
    {
        Rid = 3080054,
        Vid = 104353,
        Name = "「纷争」的教导",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104353.png"
    };

    public static readonly MaterialGroupModel G3080052 = new([_3080052, _3080053, _3080054], 3);

    public static readonly MaterialModel _3080055 = new()
    {
        Rid = 3080055,
        Vid = 104358,
        Name = "「月光」的哲学",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104358.png"
    };

    public static readonly MaterialModel _3080056 = new()
    {
        Rid = 3080056,
        Vid = 104357,
        Name = "「月光」的指引",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104357.png"
    };

    public static readonly MaterialModel _3080057 = new()
    {
        Rid = 3080057,
        Vid = 104356,
        Name = "「月光」的教导",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104356.png"
    };

    public static readonly MaterialGroupModel G3080055 = new([_3080055, _3080056, _3080057], 3);

    public static readonly MaterialModel _3080058 = new()
    {
        Rid = 3080058,
        Vid = 104361,
        Name = "「乐园」的哲学",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104361.png"
    };

    public static readonly MaterialModel _3080059 = new()
    {
        Rid = 3080059,
        Vid = 104360,
        Name = "「乐园」的指引",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104360.png"
    };

    public static readonly MaterialModel _3080060 = new()
    {
        Rid = 3080060,
        Vid = 104359,
        Name = "「乐园」的教导",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104359.png"
    };

    public static readonly MaterialGroupModel G3080058 = new([_3080058, _3080059, _3080060], 3);

    public static readonly MaterialModel _3080061 = new()
    {
        Rid = 3080061,
        Vid = 104364,
        Name = "「浪迹」的哲学",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104364.png"
    };

    public static readonly MaterialModel _3080062 = new()
    {
        Rid = 3080062,
        Vid = 104363,
        Name = "「浪迹」的指引",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104363.png"
    };

    public static readonly MaterialModel _3080063 = new()
    {
        Rid = 3080063,
        Vid = 104362,
        Name = "「浪迹」的教导",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterTalent,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104362.png"
    };

    public static readonly MaterialGroupModel G3080061 = new([_3080061, _3080062, _3080063], 3);

    // 309 - 武器突破素材
    public static readonly MaterialModel _3090001 = new()
    {
        Rid = 3090001,
        Vid = 114004,
        Name = "高塔孤王的碎梦",
        Star = 5,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114004.png"
    };

    public static readonly MaterialModel _3090002 = new()
    {
        Rid = 3090002,
        Vid = 114003,
        Name = "高塔孤王的断片",
        Star = 4,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114003.png"
    };

    public static readonly MaterialModel _3090003 = new()
    {
        Rid = 3090003,
        Vid = 114002,
        Name = "高塔孤王的残垣",
        Star = 3,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114002.png"
    };

    public static readonly MaterialModel _3090004 = new()
    {
        Rid = 3090004,
        Vid = 114001,
        Name = "高塔孤王的破瓦",
        Star = 2,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114001.png"
    };

    public static readonly MaterialGroupModel G3090001 = new([_3090001, _3090002, _3090003, _3090004], 3);

    public static readonly MaterialModel _3090005 = new()
    {
        Rid = 3090005,
        Vid = 114008,
        Name = "凛风奔狼的怀乡",
        Star = 5,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114008.png"
    };

    public static readonly MaterialModel _3090006 = new()
    {
        Rid = 3090006,
        Vid = 114007,
        Name = "凛风奔狼的断牙",
        Star = 4,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114007.png"
    };

    public static readonly MaterialModel _3090007 = new()
    {
        Rid = 3090007,
        Vid = 114006,
        Name = "凛风奔狼的裂齿",
        Star = 3,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114006.png"
    };

    public static readonly MaterialModel _3090008 = new()
    {
        Rid = 3090008,
        Vid = 114005,
        Name = "凛风奔狼的始龀",
        Star = 2,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114005.png"
    };

    public static readonly MaterialGroupModel G3090005 = new([_3090005, _3090006, _3090007, _3090008], 3);

    public static readonly MaterialModel _3090009 = new()
    {
        Rid = 3090009,
        Vid = 114012,
        Name = "狮牙斗士的理想",
        Star = 5,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114012.png"
    };

    public static readonly MaterialModel _3090010 = new()
    {
        Rid = 3090010,
        Vid = 114011,
        Name = "狮牙斗士的镣铐",
        Star = 4,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114011.png"
    };

    public static readonly MaterialModel _3090011 = new()
    {
        Rid = 3090011,
        Vid = 114010,
        Name = "狮牙斗士的铁链",
        Star = 3,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114010.png"
    };

    public static readonly MaterialModel _3090012 = new()
    {
        Rid = 3090012,
        Vid = 114009,
        Name = "狮牙斗士的枷锁",
        Star = 2,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114009.png"
    };

    public static readonly MaterialGroupModel G3090009 = new([_3090009, _3090010, _3090011, _3090012], 3);

    public static readonly MaterialModel _3090013 = new()
    {
        Rid = 3090013,
        Vid = 114016,
        Name = "孤云寒林的神体",
        Star = 5,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114016.png"
    };

    public static readonly MaterialModel _3090014 = new()
    {
        Rid = 3090014,
        Vid = 114015,
        Name = "孤云寒林的圣骸",
        Star = 4,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114015.png"
    };

    public static readonly MaterialModel _3090015 = new()
    {
        Rid = 3090015,
        Vid = 114014,
        Name = "孤云寒林的辉岩",
        Star = 3,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114014.png"
    };

    public static readonly MaterialModel _3090016 = new()
    {
        Rid = 3090016,
        Vid = 114013,
        Name = "孤云寒林的光砂",
        Star = 2,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114013.png"
    };

    public static readonly MaterialGroupModel G3090013 = new([_3090013, _3090014, _3090015, _3090016], 3);

    public static readonly MaterialModel _3090017 = new()
    {
        Rid = 3090017,
        Vid = 114020,
        Name = "雾海云间的转还",
        Star = 5,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114020.png"
    };

    public static readonly MaterialModel _3090018 = new()
    {
        Rid = 3090018,
        Vid = 114019,
        Name = "雾海云间的金丹",
        Star = 4,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114019.png"
    };

    public static readonly MaterialModel _3090019 = new()
    {
        Rid = 3090019,
        Vid = 114018,
        Name = "雾海云间的汞丹",
        Star = 3,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114018.png"
    };

    public static readonly MaterialModel _3090020 = new()
    {
        Rid = 3090020,
        Vid = 114017,
        Name = "雾海云间的铅丹",
        Star = 2,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114017.png"
    };

    public static readonly MaterialGroupModel G3090017 = new([_3090017, _3090018, _3090019, _3090020], 3);

    public static readonly MaterialModel _3090021 = new()
    {
        Rid = 3090021,
        Vid = 114024,
        Name = "漆黑陨铁的一块",
        Star = 5,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114024.png"
    };

    public static readonly MaterialModel _3090022 = new()
    {
        Rid = 3090022,
        Vid = 114023,
        Name = "漆黑陨铁的一角",
        Star = 4,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114023.png"
    };

    public static readonly MaterialModel _3090023 = new()
    {
        Rid = 3090023,
        Vid = 114022,
        Name = "漆黑陨铁的一片",
        Star = 3,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114022.png"
    };

    public static readonly MaterialModel _3090024 = new()
    {
        Rid = 3090024,
        Vid = 114021,
        Name = "漆黑陨铁的一粒",
        Star = 2,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114021.png"
    };

    public static readonly MaterialGroupModel G3090021 = new([_3090021, _3090022, _3090023, _3090024], 3);

    public static readonly MaterialModel _3090025 = new()
    {
        Rid = 3090025,
        Vid = 114028,
        Name = "远海夷地的金枝",
        Star = 5,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114028.png"
    };

    public static readonly MaterialModel _3090026 = new()
    {
        Rid = 3090026,
        Vid = 114027,
        Name = "远海夷地的琼枝",
        Star = 4,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114027.png"
    };

    public static readonly MaterialModel _3090027 = new()
    {
        Rid = 3090027,
        Vid = 114026,
        Name = "远海夷地的玉枝",
        Star = 3,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114026.png"
    };

    public static readonly MaterialModel _3090028 = new()
    {
        Rid = 3090028,
        Vid = 114025,
        Name = "远海夷地的瑚枝",
        Star = 2,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114025.png"
    };

    public static readonly MaterialGroupModel G3090025 = new([_3090025, _3090026, _3090027, _3090028], 3);

    public static readonly MaterialModel _3090029 = new()
    {
        Rid = 3090029,
        Vid = 114032,
        Name = "鸣神御灵的勇武",
        Star = 5,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114032.png"
    };

    public static readonly MaterialModel _3090030 = new()
    {
        Rid = 3090030,
        Vid = 114031,
        Name = "鸣神御灵的亲爱",
        Star = 4,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114031.png"
    };

    public static readonly MaterialModel _3090031 = new()
    {
        Rid = 3090031,
        Vid = 114030,
        Name = "鸣神御灵的欢喜",
        Star = 3,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114030.png"
    };

    public static readonly MaterialModel _3090032 = new()
    {
        Rid = 3090032,
        Vid = 114029,
        Name = "鸣神御灵的明惠",
        Star = 2,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114029.png"
    };

    public static readonly MaterialGroupModel G3090029 = new([_3090029, _3090030, _3090031, _3090032], 3);

    public static readonly MaterialModel _3090033 = new()
    {
        Rid = 3090033,
        Vid = 114036,
        Name = "今昔剧画之鬼人",
        Star = 5,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114036.png"
    };

    public static readonly MaterialModel _3090034 = new()
    {
        Rid = 3090034,
        Vid = 114035,
        Name = "今昔剧画之一角",
        Star = 4,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114035.png"
    };

    public static readonly MaterialModel _3090035 = new()
    {
        Rid = 3090035,
        Vid = 114034,
        Name = "今昔剧画之虎啮",
        Star = 3,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114034.png"
    };

    public static readonly MaterialModel _3090036 = new()
    {
        Rid = 3090036,
        Vid = 114033,
        Name = "今昔剧画之恶尉",
        Star = 2,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114033.png"
    };

    public static readonly MaterialGroupModel G3090033 = new([_3090033, _3090034, _3090035, _3090036], 3);

    public static readonly MaterialModel _3090037 = new()
    {
        Rid = 3090037,
        Vid = 114040,
        Name = "谧林涓露的金符",
        Star = 5,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114040.png"
    };

    public static readonly MaterialModel _3090038 = new()
    {
        Rid = 3090038,
        Vid = 114039,
        Name = "谧林涓露的银符",
        Star = 4,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114039.png"
    };

    public static readonly MaterialModel _3090039 = new()
    {
        Rid = 3090039,
        Vid = 114038,
        Name = "谧林涓露的铁符",
        Star = 3,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114038.png"
    };

    public static readonly MaterialModel _3090040 = new()
    {
        Rid = 3090040,
        Vid = 114037,
        Name = "谧林涓露的铜符",
        Star = 2,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114037.png"
    };

    public static readonly MaterialGroupModel G3090037 = new([_3090037, _3090038, _3090039, _3090040], 3);

    public static readonly MaterialModel _3090041 = new()
    {
        Rid = 3090041,
        Vid = 114044,
        Name = "绿洲花园的真谛",
        Star = 5,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114044.png"
    };

    public static readonly MaterialModel _3090042 = new()
    {
        Rid = 3090042,
        Vid = 114043,
        Name = "绿洲花园的哀思",
        Star = 4,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114043.png"
    };

    public static readonly MaterialModel _3090043 = new()
    {
        Rid = 3090043,
        Vid = 114042,
        Name = "绿洲花园的恩惠",
        Star = 3,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114042.png"
    };

    public static readonly MaterialModel _3090044 = new()
    {
        Rid = 3090044,
        Vid = 114041,
        Name = "绿洲花园的追忆",
        Star = 2,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114041.png"
    };

    public static readonly MaterialGroupModel G3090041 = new([_3090041, _3090042, _3090043, _3090044], 3);

    public static readonly MaterialModel _3090045 = new()
    {
        Rid = 3090045,
        Vid = 114048,
        Name = "烈日威权的旧日",
        Star = 5,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114048.png"
    };

    public static readonly MaterialModel _3090046 = new()
    {
        Rid = 3090046,
        Vid = 114047,
        Name = "烈日威权的梦想",
        Star = 4,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114047.png"
    };

    public static readonly MaterialModel _3090047 = new()
    {
        Rid = 3090047,
        Vid = 114046,
        Name = "烈日威权的余光",
        Star = 3,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114046.png"
    };

    public static readonly MaterialModel _3090048 = new()
    {
        Rid = 3090048,
        Vid = 114045,
        Name = "烈日威权的残响",
        Star = 2,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114045.png"
    };

    public static readonly MaterialGroupModel G3090045 = new([_3090045, _3090046, _3090047, _3090048], 3);

    public static readonly MaterialModel _3090049 = new()
    {
        Rid = 3090049,
        Vid = 114052,
        Name = "悠古弦音的回响",
        Star = 5,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114052.png"
    };

    public static readonly MaterialModel _3090050 = new()
    {
        Rid = 3090050,
        Vid = 114051,
        Name = "悠古弦音的乐章",
        Star = 4,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114051.png"
    };

    public static readonly MaterialModel _3090051 = new()
    {
        Rid = 3090051,
        Vid = 114050,
        Name = "悠古弦音的断章",
        Star = 3,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114050.png"
    };

    public static readonly MaterialModel _3090052 = new()
    {
        Rid = 3090052,
        Vid = 114049,
        Name = "悠古弦音的残章",
        Star = 2,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114049.png"
    };

    public static readonly MaterialGroupModel G3090049 = new([_3090049, _3090050, _3090051, _3090052], 3);

    public static readonly MaterialModel _3090053 = new()
    {
        Rid = 3090053,
        Vid = 114056,
        Name = "纯圣露滴的真粹",
        Star = 5,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114056.png"
    };

    public static readonly MaterialModel _3090054 = new()
    {
        Rid = 3090054,
        Vid = 114055,
        Name = "纯圣露滴的醴泉",
        Star = 4,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114055.png"
    };

    public static readonly MaterialModel _3090055 = new()
    {
        Rid = 3090055,
        Vid = 114054,
        Name = "纯圣露滴的凝华",
        Star = 3,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114054.png"
    };

    public static readonly MaterialModel _3090056 = new()
    {
        Rid = 3090056,
        Vid = 114053,
        Name = "纯圣露滴的滤渣",
        Star = 2,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114053.png"
    };

    public static readonly MaterialGroupModel G3090053 = new([_3090053, _3090054, _3090055, _3090056], 3);

    public static readonly MaterialModel _3090057 = new()
    {
        Rid = 3090057,
        Vid = 114060,
        Name = "无垢之海的金杯",
        Star = 5,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114060.png"
    };

    public static readonly MaterialModel _3090058 = new()
    {
        Rid = 3090058,
        Vid = 114059,
        Name = "无垢之海的银杯",
        Star = 4,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114059.png"
    };

    public static readonly MaterialModel _3090059 = new()
    {
        Rid = 3090059,
        Vid = 114058,
        Name = "无垢之海的酒盏",
        Star = 3,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114058.png"
    };

    public static readonly MaterialModel _3090060 = new()
    {
        Rid = 3090060,
        Vid = 114057,
        Name = "无垢之海的苦盏",
        Star = 2,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114057.png"
    };

    public static readonly MaterialGroupModel G3090057 = new([_3090057, _3090058, _3090059, _3090060], 3);

    public static readonly MaterialModel _3090061 = new()
    {
        Rid = 3090061,
        Vid = 114064,
        Name = "贡祭炽心的荣膺",
        Star = 5,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114064.png"
    };

    public static readonly MaterialModel _3090062 = new()
    {
        Rid = 3090062,
        Vid = 114063,
        Name = "贡祭炽心的决绝",
        Star = 4,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114063.png"
    };

    public static readonly MaterialModel _3090063 = new()
    {
        Rid = 3090063,
        Vid = 114062,
        Name = "贡祭炽心的踌躇",
        Star = 3,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114062.png"
    };

    public static readonly MaterialModel _3090064 = new()
    {
        Rid = 3090064,
        Vid = 114061,
        Name = "贡祭炽心的惶恐",
        Star = 2,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114061.png"
    };

    public static readonly MaterialGroupModel G3090061 = new([_3090061, _3090062, _3090063, _3090064], 3);

    public static readonly MaterialModel _3090065 = new()
    {
        Rid = 3090065,
        Vid = 114068,
        Name = "谵妄圣主的神面",
        Star = 5,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114068.png"
    };

    public static readonly MaterialModel _3090066 = new()
    {
        Rid = 3090066,
        Vid = 114067,
        Name = "谵妄圣主的容光",
        Star = 4,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114067.png"
    };

    public static readonly MaterialModel _3090067 = new()
    {
        Rid = 3090067,
        Vid = 114066,
        Name = "谵妄圣主的余哀",
        Star = 3,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114066.png"
    };

    public static readonly MaterialModel _3090068 = new()
    {
        Rid = 3090068,
        Vid = 114065,
        Name = "谵妄圣主的朽败",
        Star = 2,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114065.png"
    };

    public static readonly MaterialGroupModel G3090065 = new([_3090065, _3090066, _3090067, _3090068], 3);

    public static readonly MaterialModel _3090069 = new()
    {
        Rid = 3090069,
        Vid = 114072,
        Name = "神合秘烟的启示",
        Star = 5,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114072.png"
    };

    public static readonly MaterialModel _3090070 = new()
    {
        Rid = 3090070,
        Vid = 114071,
        Name = "神合秘烟的征兆",
        Star = 4,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114071.png"
    };

    public static readonly MaterialModel _3090071 = new()
    {
        Rid = 3090071,
        Vid = 114070,
        Name = "神合秘烟的预感",
        Star = 3,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114070.png"
    };

    public static readonly MaterialModel _3090072 = new()
    {
        Rid = 3090072,
        Vid = 114069,
        Name = "神合秘烟的思绪",
        Star = 2,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114069.png"
    };

    public static readonly MaterialGroupModel G3090069 = new([_3090069, _3090070, _3090071, _3090072], 3);

    public static readonly MaterialModel _3090073 = new()
    {
        Rid = 3090073,
        Vid = 114076,
        Name = "奇巧秘器的真愿",
        Star = 5,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114076.png"
    };

    public static readonly MaterialModel _3090074 = new()
    {
        Rid = 3090074,
        Vid = 114075,
        Name = "奇巧秘器的继业",
        Star = 4,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114075.png"
    };

    public static readonly MaterialModel _3090075 = new()
    {
        Rid = 3090075,
        Vid = 114074,
        Name = "奇巧秘器的模本",
        Star = 3,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114074.png"
    };

    public static readonly MaterialModel _3090076 = new()
    {
        Rid = 3090076,
        Vid = 114073,
        Name = "奇巧秘器的残件",
        Star = 2,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114073.png"
    };

    public static readonly MaterialGroupModel G3090073 = new([_3090073, _3090074, _3090075, _3090076], 3);

    public static readonly MaterialModel _3090077 = new()
    {
        Rid = 3090077,
        Vid = 114080,
        Name = "长夜燧火的烈辉",
        Star = 5,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114080.png"
    };

    public static readonly MaterialModel _3090078 = new()
    {
        Rid = 3090078,
        Vid = 114079,
        Name = "长夜燧火的明焰",
        Star = 4,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114079.png"
    };

    public static readonly MaterialModel _3090079 = new()
    {
        Rid = 3090079,
        Vid = 114078,
        Name = "长夜燧火的残照",
        Star = 3,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114078.png"
    };

    public static readonly MaterialModel _3090080 = new()
    {
        Rid = 3090080,
        Vid = 114077,
        Name = "长夜燧火的余烬",
        Star = 2,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114077.png"
    };

    public static readonly MaterialGroupModel G3090077 = new([_3090077, _3090078, _3090079, _3090080], 3);

    public static readonly MaterialModel _3090081 = new()
    {
        Rid = 3090081,
        Vid = 114084,
        Name = "终北遗嗣的煌熠",
        Star = 5,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114084.png"
    };

    public static readonly MaterialModel _3090082 = new()
    {
        Rid = 3090082,
        Vid = 114083,
        Name = "终北遗嗣的祷献",
        Star = 4,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114083.png"
    };

    public static readonly MaterialModel _3090083 = new()
    {
        Rid = 3090083,
        Vid = 114082,
        Name = "终北遗嗣的迷顽",
        Star = 3,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114082.png"
    };

    public static readonly MaterialModel _3090084 = new()
    {
        Rid = 3090084,
        Vid = 114081,
        Name = "终北遗嗣的哀荣",
        Star = 2,
        MaterialType = Enumeration.MaterialType.WeaponAscension,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_114081.png"
    };

    public static readonly MaterialGroupModel G3090081 = new([_3090081, _3090082, _3090083, _3090084], 3);

    // 310 - 地方特产
    public static readonly MaterialModel _3100101 = new()
    {
        Rid = 3100101,
        Vid = 100021,
        Name = "钩钩果",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_100021.png"
    };

    public static readonly MaterialModel _3100102 = new()
    {
        Rid = 3100102,
        Vid = 100022,
        Name = "落落莓",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_100022.png"
    };

    public static readonly MaterialModel _3100103 = new()
    {
        Rid = 3100103,
        Vid = 100023,
        Name = "塞西莉亚花",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_100023.png"
    };

    public static readonly MaterialModel _3100104 = new()
    {
        Rid = 3100104,
        Vid = 100024,
        Name = "风车菊",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_100024.png"
    };

    public static readonly MaterialModel _3100105 = new()
    {
        Rid = 3100105,
        Vid = 100025,
        Name = "慕风蘑菇",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_100025.png"
    };

    public static readonly MaterialModel _3100106 = new()
    {
        Rid = 3100106,
        Vid = 100055,
        Name = "小灯草",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_100055.png"
    };

    public static readonly MaterialModel _3100107 = new()
    {
        Rid = 3100107,
        Vid = 100056,
        Name = "嘟嘟莲",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_100056.png"
    };

    public static readonly MaterialModel _3100108 = new()
    {
        Rid = 3100108,
        Vid = 100057,
        Name = "蒲公英籽",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_100057.png"
    };

    public static readonly MaterialModel _3100201 = new()
    {
        Rid = 3100201,
        Vid = 100027,
        Name = "绝云椒椒",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_100027.png"
    };

    public static readonly MaterialModel _3100202 = new()
    {
        Rid = 3100202,
        Vid = 100028,
        Name = "夜泊石",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_100028.png"
    };

    public static readonly MaterialModel _3100203 = new()
    {
        Rid = 3100203,
        Vid = 100029,
        Name = "霓裳花",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_100029.png"
    };

    public static readonly MaterialModel _3100204 = new()
    {
        Rid = 3100204,
        Vid = 100030,
        Name = "琉璃百合",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_100030.png"
    };

    public static readonly MaterialModel _3100205 = new()
    {
        Rid = 3100205,
        Vid = 100031,
        Name = "清心",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_100031.png"
    };

    public static readonly MaterialModel _3100206 = new()
    {
        Rid = 3100206,
        Vid = 100033,
        Name = "星螺",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_100033.png"
    };

    public static readonly MaterialModel _3100207 = new()
    {
        Rid = 3100207,
        Vid = 100034,
        Name = "琉璃袋",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_100034.png"
    };

    public static readonly MaterialModel _3100208 = new()
    {
        Rid = 3100208,
        Vid = 100058,
        Name = "石珀",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_100058.png"
    };

    public static readonly MaterialModel _3100209 = new()
    {
        Rid = 3100209,
        Vid = 101241,
        Name = "清水玉",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101241.png"
    };

    public static readonly MaterialModel _3100301 = new()
    {
        Rid = 3100301,
        Vid = 101201,
        Name = "鬼兜虫",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101201.png"
    };

    public static readonly MaterialModel _3100302 = new()
    {
        Rid = 3100302,
        Vid = 101202,
        Name = "绯樱绣球",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101202.png"
    };

    public static readonly MaterialModel _3100303 = new()
    {
        Rid = 3100303,
        Vid = 101203,
        Name = "晶化骨髓",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101203.png"
    };

    public static readonly MaterialModel _3100304 = new()
    {
        Rid = 3100304,
        Vid = 101204,
        Name = "血斛",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101204.png"
    };

    public static readonly MaterialModel _3100305 = new()
    {
        Rid = 3100305,
        Vid = 101205,
        Name = "鸣草",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101205.png"
    };

    public static readonly MaterialModel _3100306 = new()
    {
        Rid = 3100306,
        Vid = 101206,
        Name = "海灵芝",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101206.png"
    };

    public static readonly MaterialModel _3100307 = new()
    {
        Rid = 3100307,
        Vid = 101207,
        Name = "珊瑚真珠",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101207.png"
    };

    public static readonly MaterialModel _3100308 = new()
    {
        Rid = 3100308,
        Vid = 101208,
        Name = "天云草实",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101208.png"
    };

    public static readonly MaterialModel _3100309 = new()
    {
        Rid = 3100309,
        Vid = 101209,
        Name = "幽灯蕈",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101209.png"
    };

    public static readonly MaterialModel _3100401 = new()
    {
        Rid = 3100401,
        Vid = 101213,
        Name = "树王圣体菇",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101213.png"
    };

    public static readonly MaterialModel _3100402 = new()
    {
        Rid = 3100402,
        Vid = 101214,
        Name = "帕蒂沙兰",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101214.png"
    };

    public static readonly MaterialModel _3100403 = new()
    {
        Rid = 3100403,
        Vid = 101215,
        Name = "月莲",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101215.png"
    };

    public static readonly MaterialModel _3100404 = new()
    {
        Rid = 3100404,
        Vid = 101217,
        Name = "劫波莲",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101217.png"
    };

    public static readonly MaterialModel _3100405 = new()
    {
        Rid = 3100405,
        Vid = 101220,
        Name = "赤念果",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101220.png"
    };

    public static readonly MaterialModel _3100406 = new()
    {
        Rid = 3100406,
        Vid = 101222,
        Name = "沙脂蛹",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101222.png"
    };

    public static readonly MaterialModel _3100407 = new()
    {
        Rid = 3100407,
        Vid = 101223,
        Name = "悼灵花",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101223.png"
    };

    public static readonly MaterialModel _3100408 = new()
    {
        Rid = 3100408,
        Vid = 101224,
        Name = "万相石",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101224.png"
    };

    public static readonly MaterialModel _3100409 = new()
    {
        Rid = 3100409,
        Vid = 101225,
        Name = "圣金虫",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101225.png"
    };

    public static readonly MaterialModel _3100501 = new()
    {
        Rid = 3100501,
        Vid = 101232,
        Name = "苍晶螺",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101232.png"
    };

    public static readonly MaterialModel _3100502 = new()
    {
        Rid = 3100502,
        Vid = 101233,
        Name = "海露花",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101233.png"
    };

    public static readonly MaterialModel _3100503 = new()
    {
        Rid = 3100503,
        Vid = 101235,
        Name = "柔灯铃",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101235.png"
    };

    public static readonly MaterialModel _3100504 = new()
    {
        Rid = 3100504,
        Vid = 101236,
        Name = "虹彩蔷薇",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101236.png"
    };

    public static readonly MaterialModel _3100505 = new()
    {
        Rid = 3100505,
        Vid = 101237,
        Name = "幽光星星",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101237.png"
    };

    public static readonly MaterialModel _3100506 = new()
    {
        Rid = 3100506,
        Vid = 101238,
        Name = "湖光铃兰",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101238.png"
    };

    public static readonly MaterialModel _3100507 = new()
    {
        Rid = 3100507,
        Vid = 101239,
        Name = "子探测单元",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101239.png"
    };

    public static readonly MaterialModel _3100508 = new()
    {
        Rid = 3100508,
        Vid = 101240,
        Name = "初露之源",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101240.png"
    };

    public static readonly MaterialModel _3100601 = new()
    {
        Rid = 3100601,
        Vid = 101247,
        Name = "浪沫羽鳃",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101247.png"
    };

    public static readonly MaterialModel _3100602 = new()
    {
        Rid = 3100602,
        Vid = 101248,
        Name = "灼灼彩菊",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101248.png"
    };

    public static readonly MaterialModel _3100603 = new()
    {
        Rid = 3100603,
        Vid = 101249,
        Name = "青蜜莓",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101249.png"
    };

    public static readonly MaterialModel _3100604 = new()
    {
        Rid = 3100604,
        Vid = 101250,
        Name = "肉龙掌",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101250.png"
    };

    public static readonly MaterialModel _3100605 = new()
    {
        Rid = 3100605,
        Vid = 101252,
        Name = "微光角菌",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101252.png"
    };

    public static readonly MaterialModel _3100606 = new()
    {
        Rid = 3100606,
        Vid = 101253,
        Name = "枯叶紫英",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101253.png"
    };

    public static readonly MaterialModel _3100607 = new()
    {
        Rid = 3100607,
        Vid = 101254,
        Name = "云岩裂叶",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101254.png"
    };

    public static readonly MaterialModel _3100608 = new()
    {
        Rid = 3100608,
        Vid = 101255,
        Name = "琉鳞石",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101255.png"
    };

    public static readonly MaterialModel _3100701 = new()
    {
        Rid = 3100701,
        Vid = 101257,
        Name = "便携轴承",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101257.png"
    };

    public static readonly MaterialModel _3100702 = new()
    {
        Rid = 3100702,
        Vid = 101261,
        Name = "霜盏花",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101261.png"
    };

    public static readonly MaterialModel _3100703 = new()
    {
        Rid = 3100703,
        Vid = 101263,
        Name = "月落银",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_101263.png"
    };

    // 311 - 武器强化素材
    public static readonly MaterialModel _3110001 = new()
    {
        Rid = 3110001,
        Vid = 104013,
        Name = "精锻用魔矿",
        Star = 3,
        MaterialType = Enumeration.MaterialType.WeaponExp,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104013.png"
    };

    public static readonly MaterialModel _3110002 = new()
    {
        Rid = 3110002,
        Vid = 104012,
        Name = "精锻用良矿",
        Star = 2,
        MaterialType = Enumeration.MaterialType.WeaponExp,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104012.png"
    };

    public static readonly MaterialModel _3110003 = new()
    {
        Rid = 3110003,
        Vid = 104011,
        Name = "精锻用杂矿",
        Star = 1,
        MaterialType = Enumeration.MaterialType.WeaponExp,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104011.png"
    };
}