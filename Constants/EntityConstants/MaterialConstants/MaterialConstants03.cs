using HexereiKatepnha.Models.EntityModels;

namespace HexereiKatepnha.Constants.EntityConstants.MaterialConstants;

public class MaterialConstants03
{
    // 303 - 角色与武器培养素材_234
    public static readonly MaterialModel _3030001 = new()
    {
        Rid = 3030001,
        Vid = 112016,
        Name = "黑晶号角",
        GoodKey = "BlackCrystalHorn",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112016.png"
    };

    public static readonly MaterialModel _3030002 = new()
    {
        Rid = 3030002,
        Vid = 112015,
        Name = "黑铜号角",
        GoodKey = "BlackBronzeHorn",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112015.png"
    };

    public static readonly MaterialModel _3030003 = new()
    {
        Rid = 3030003,
        Vid = 112014,
        Name = "沉重号角",
        GoodKey = "HeavyHorn",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112014.png"
    };

    public static readonly MaterialGroupModel G3030001 = new([_3030001, _3030002, _3030003]);

    public static readonly MaterialModel _3030004 = new()
    {
        Rid = 3030004,
        Vid = 112022,
        Name = "地脉的新芽",
        GoodKey = "LeyLineSprout",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112022.png"
    };

    public static readonly MaterialModel _3030005 = new()
    {
        Rid = 3030005,
        Vid = 112021,
        Name = "地脉的枯叶",
        GoodKey = "DeadLeyLineLeaves",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112021.png"
    };

    public static readonly MaterialModel _3030006 = new()
    {
        Rid = 3030006,
        Vid = 112020,
        Name = "地脉的旧枝",
        GoodKey = "DeadLeyLineBranch",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112020.png"
    };

    public static readonly MaterialGroupModel G3030004 = new([_3030004, _3030005, _3030006]);

    public static readonly MaterialModel _3030007 = new()
    {
        Rid = 3030007,
        Vid = 112025,
        Name = "混沌炉心",
        GoodKey = "ChaosCore",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112025.png"
    };

    public static readonly MaterialModel _3030008 = new()
    {
        Rid = 3030008,
        Vid = 112024,
        Name = "混沌回路",
        GoodKey = "ChaosCircuit",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112024.png"
    };

    public static readonly MaterialModel _3030009 = new()
    {
        Rid = 3030009,
        Vid = 112023,
        Name = "混沌装置",
        GoodKey = "ChaosDevice",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112023.png"
    };

    public static readonly MaterialGroupModel G3030007 = new([_3030007, _3030008, _3030009]);

    public static readonly MaterialModel _3030010 = new()
    {
        Rid = 3030010,
        Vid = 112028,
        Name = "雾虚灯芯",
        GoodKey = "MistGrassWick",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112028.png"
    };

    public static readonly MaterialModel _3030011 = new()
    {
        Rid = 3030011,
        Vid = 112027,
        Name = "雾虚草囊",
        GoodKey = "MistGrass",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112027.png"
    };

    public static readonly MaterialModel _3030012 = new()
    {
        Rid = 3030012,
        Vid = 112026,
        Name = "雾虚花粉",
        GoodKey = "MistGrassPollen",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112026.png"
    };

    public static readonly MaterialGroupModel G3030010 = new([_3030010, _3030011, _3030012]);

    public static readonly MaterialModel _3030013 = new()
    {
        Rid = 3030013,
        Vid = 112031,
        Name = "督察长祭刀",
        GoodKey = "InspectorsSacrificialKnife",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112031.png"
    };

    public static readonly MaterialModel _3030014 = new()
    {
        Rid = 3030014,
        Vid = 112030,
        Name = "特工祭刀",
        GoodKey = "AgentsSacrificialKnife",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112030.png"
    };

    public static readonly MaterialModel _3030015 = new()
    {
        Rid = 3030015,
        Vid = 112029,
        Name = "猎兵祭刀",
        GoodKey = "HuntersSacrificialKnife",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112029.png"
    };

    public static readonly MaterialGroupModel G3030013 = new([_3030013, _3030014, _3030015]);

    public static readonly MaterialModel _3030016 = new()
    {
        Rid = 3030016,
        Vid = 112043,
        Name = "石化的骨片",
        GoodKey = "FossilizedBoneShard",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112043.png"
    };

    public static readonly MaterialModel _3030017 = new()
    {
        Rid = 3030017,
        Vid = 112042,
        Name = "结实的骨片",
        GoodKey = "SturdyBoneShard",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112042.png"
    };

    public static readonly MaterialModel _3030018 = new()
    {
        Rid = 3030018,
        Vid = 112041,
        Name = "脆弱的骨片",
        GoodKey = "FragileBoneShard",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112041.png"
    };

    public static readonly MaterialGroupModel G3030016 = new([_3030016, _3030017, _3030018]);

    public static readonly MaterialModel _3030019 = new()
    {
        Rid = 3030019,
        Vid = 112049,
        Name = "混沌真眼",
        GoodKey = "ChaosOculus",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112049.png"
    };

    public static readonly MaterialModel _3030020 = new()
    {
        Rid = 3030020,
        Vid = 112048,
        Name = "混沌枢纽",
        GoodKey = "ChaosAxis",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112048.png"
    };

    public static readonly MaterialModel _3030021 = new()
    {
        Rid = 3030021,
        Vid = 112047,
        Name = "混沌机关",
        GoodKey = "ChaosGear",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112047.png"
    };

    public static readonly MaterialGroupModel G3030019 = new([_3030019, _3030020, _3030021]);

    public static readonly MaterialModel _3030022 = new()
    {
        Rid = 3030022,
        Vid = 112052,
        Name = "偏光棱镜",
        GoodKey = "PolarizingPrism",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112052.png"
    };

    public static readonly MaterialModel _3030023 = new()
    {
        Rid = 3030023,
        Vid = 112051,
        Name = "水晶棱镜",
        GoodKey = "CrystalPrism",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112051.png"
    };

    public static readonly MaterialModel _3030024 = new()
    {
        Rid = 3030024,
        Vid = 112050,
        Name = "黯淡棱镜",
        GoodKey = "DismalPrism",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112050.png"
    };

    public static readonly MaterialGroupModel G3030022 = new([_3030022, _3030023, _3030024]);

    public static readonly MaterialModel _3030025 = new()
    {
        Rid = 3030025,
        Vid = 112058,
        Name = "隐兽鬼爪",
        GoodKey = "ConcealedTalon",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112058.png"
    };

    public static readonly MaterialModel _3030026 = new()
    {
        Rid = 3030026,
        Vid = 112057,
        Name = "隐兽利爪",
        GoodKey = "ConcealedUnguis",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112057.png"
    };

    public static readonly MaterialModel _3030027 = new()
    {
        Rid = 3030027,
        Vid = 112056,
        Name = "隐兽指爪",
        GoodKey = "ConcealedClaw",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112056.png"
    };

    public static readonly MaterialGroupModel G3030025 = new([_3030025, _3030026, _3030027]);

    public static readonly MaterialModel _3030028 = new()
    {
        Rid = 3030028,
        Vid = 112019,
        Name = "幽邃刻像",
        GoodKey = "DeathlyStatuette",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112019.png"
    };

    public static readonly MaterialModel _3030029 = new()
    {
        Rid = 3030029,
        Vid = 112018,
        Name = "夤夜刻像",
        GoodKey = "DarkStatuette",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112018.png"
    };

    public static readonly MaterialModel _3030030 = new()
    {
        Rid = 3030030,
        Vid = 112017,
        Name = "晦暗刻像",
        GoodKey = "GloomyStatuette",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112017.png"
    };

    public static readonly MaterialGroupModel G3030028 = new([_3030028, _3030029, _3030030]);

    public static readonly MaterialModel _3030031 = new()
    {
        Rid = 3030031,
        Vid = 112064,
        Name = "茁壮菌核",
        GoodKey = "RobustFungalNucleus",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112064.png"
    };

    public static readonly MaterialModel _3030032 = new()
    {
        Rid = 3030032,
        Vid = 112063,
        Name = "休眠菌核",
        GoodKey = "DormantFungalNucleus",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112063.png"
    };

    public static readonly MaterialModel _3030033 = new()
    {
        Rid = 3030033,
        Vid = 112062,
        Name = "失活菌核",
        GoodKey = "InactivatedFungalNucleus",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112062.png"
    };

    public static readonly MaterialGroupModel G3030031 = new([_3030031, _3030032, _3030033]);

    public static readonly MaterialModel _3030034 = new()
    {
        Rid = 3030034,
        Vid = 112070,
        Name = "混沌锚栓",
        GoodKey = "ChaosBolt",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112070.png"
    };

    public static readonly MaterialModel _3030035 = new()
    {
        Rid = 3030035,
        Vid = 112069,
        Name = "混沌模块",
        GoodKey = "ChaosModule",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112069.png"
    };

    public static readonly MaterialModel _3030036 = new()
    {
        Rid = 3030036,
        Vid = 112068,
        Name = "混沌容器",
        GoodKey = "ChaosStorage",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112068.png"
    };

    public static readonly MaterialGroupModel G3030034 = new([_3030034, _3030035, _3030036]);

    public static readonly MaterialModel _3030037 = new()
    {
        Rid = 3030037,
        Vid = 112073,
        Name = "辉光棱晶",
        GoodKey = "RadiantPrism",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112073.png"
    };

    public static readonly MaterialModel _3030038 = new()
    {
        Rid = 3030038,
        Vid = 112072,
        Name = "混浊棱晶",
        GoodKey = "TurbidPrism",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112072.png"
    };

    public static readonly MaterialModel _3030039 = new()
    {
        Rid = 3030039,
        Vid = 112071,
        Name = "破缺棱晶",
        GoodKey = "DamagedPrism",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112071.png"
    };

    public static readonly MaterialGroupModel G3030037 = new([_3030037, _3030038, _3030039]);

    public static readonly MaterialModel _3030040 = new()
    {
        Rid = 3030040,
        Vid = 112076,
        Name = "锲纹的横脊",
        GoodKey = "MarkedShell",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112076.png"
    };

    public static readonly MaterialModel _3030041 = new()
    {
        Rid = 3030041,
        Vid = 112075,
        Name = "密固的横脊",
        GoodKey = "SturdyShell",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112075.png"
    };

    public static readonly MaterialModel _3030042 = new()
    {
        Rid = 3030042,
        Vid = 112074,
        Name = "残毁的横脊",
        GoodKey = "DesiccatedShell",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112074.png"
    };

    public static readonly MaterialGroupModel G3030040 = new([_3030040, _3030041, _3030042]);

    public static readonly MaterialModel _3030043 = new()
    {
        Rid = 3030043,
        Vid = 112079,
        Name = "漫游者的盛放之花",
        GoodKey = "WanderersBloomingFlower",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112079.png"
    };

    public static readonly MaterialModel _3030044 = new()
    {
        Rid = 3030044,
        Vid = 112078,
        Name = "何人所珍藏之花",
        GoodKey = "TreasuredFlower",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112078.png"
    };

    public static readonly MaterialModel _3030045 = new()
    {
        Rid = 3030045,
        Vid = 112077,
        Name = "来自何处的待放之花",
        GoodKey = "AFlowerYetToBloom",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112077.png"
    };

    public static readonly MaterialGroupModel G3030043 = new([_3030043, _3030044, _3030045]);

    public static readonly MaterialModel _3030046 = new()
    {
        Rid = 3030046,
        Vid = 112088,
        Name = "初生的浊水幻灵",
        GoodKey = "NewbornTaintedHydroPhantasm",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112088.png"
    };

    public static readonly MaterialModel _3030047 = new()
    {
        Rid = 3030047,
        Vid = 112087,
        Name = "浊水的一掬",
        GoodKey = "ScoopOfTaintedWater",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112087.png"
    };

    public static readonly MaterialModel _3030048 = new()
    {
        Rid = 3030048,
        Vid = 112086,
        Name = "浊水的一滴",
        GoodKey = "DropOfTaintedWater",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112086.png"
    };

    public static readonly MaterialGroupModel G3030046 = new([_3030046, _3030047, _3030048]);

    public static readonly MaterialModel _3030049 = new()
    {
        Rid = 3030049,
        Vid = 112091,
        Name = "异界生命核",
        GoodKey = "AlienLifeCore",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112091.png"
    };

    public static readonly MaterialModel _3030050 = new()
    {
        Rid = 3030050,
        Vid = 112090,
        Name = "外世突触",
        GoodKey = "ForeignSynapse",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112090.png"
    };

    public static readonly MaterialModel _3030051 = new()
    {
        Rid = 3030051,
        Vid = 112089,
        Name = "隙间之核",
        GoodKey = "RiftCore",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112089.png"
    };

    public static readonly MaterialGroupModel G3030049 = new([_3030049, _3030050, _3030051]);

    public static readonly MaterialModel _3030052 = new()
    {
        Rid = 3030052,
        Vid = 112094,
        Name = "役人的时时刻刻",
        GoodKey = "OperativesConstancy",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112094.png"
    };

    public static readonly MaterialModel _3030053 = new()
    {
        Rid = 3030053,
        Vid = 112093,
        Name = "役人的制式怀表",
        GoodKey = "OperativesStandardPocketWatch",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112093.png"
    };

    public static readonly MaterialModel _3030054 = new()
    {
        Rid = 3030054,
        Vid = 112092,
        Name = "老旧的役人怀表",
        GoodKey = "OldOperativesPocketWatch",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112092.png"
    };

    public static readonly MaterialGroupModel G3030052 = new([_3030052, _3030053, _3030054]);

    public static readonly MaterialModel _3030055 = new()
    {
        Rid = 3030055,
        Vid = 112097,
        Name = "渊光鳍翅",
        GoodKey = "ChasmlightFin",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112097.png"
    };

    public static readonly MaterialModel _3030056 = new()
    {
        Rid = 3030056,
        Vid = 112096,
        Name = "月色鳍翅",
        GoodKey = "LunarFin",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112096.png"
    };

    public static readonly MaterialModel _3030057 = new()
    {
        Rid = 3030057,
        Vid = 112095,
        Name = "羽状鳍翅",
        GoodKey = "FeatheryFin",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112095.png"
    };

    public static readonly MaterialGroupModel G3030055 = new([_3030055, _3030056, _3030057]);

    public static readonly MaterialModel _3030058 = new()
    {
        Rid = 3030058,
        Vid = 112100,
        Name = "未熄的剑柄",
        GoodKey = "StillSmolderingHilt",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112100.png"
    };

    public static readonly MaterialModel _3030059 = new()
    {
        Rid = 3030059,
        Vid = 112099,
        Name = "裂断的剑柄",
        GoodKey = "SplinteredHilt",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112099.png"
    };

    public static readonly MaterialModel _3030060 = new()
    {
        Rid = 3030060,
        Vid = 112098,
        Name = "残毁的剑柄",
        GoodKey = "RuinedHilt",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112098.png"
    };

    public static readonly MaterialGroupModel G3030058 = new([_3030058, _3030059, _3030060]);

    public static readonly MaterialModel _3030061 = new()
    {
        Rid = 3030061,
        Vid = 112109,
        Name = "意志巡游的符像",
        GoodKey = "SigilOfAStridingWill",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112109.png"
    };

    public static readonly MaterialModel _3030062 = new()
    {
        Rid = 3030062,
        Vid = 112108,
        Name = "意志明晰的寄偶",
        GoodKey = "LocusOfAClearWill",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112108.png"
    };

    public static readonly MaterialModel _3030063 = new()
    {
        Rid = 3030063,
        Vid = 112107,
        Name = "意志破碎的残片",
        GoodKey = "ShardOfAShatteredWill",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112107.png"
    };

    public static readonly MaterialGroupModel G3030061 = new([_3030061, _3030062, _3030063]);

    public static readonly MaterialModel _3030064 = new()
    {
        Rid = 3030064,
        Vid = 112112,
        Name = "聚燃的游像眼",
        GoodKey = "IgnitedSeeingEye",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112112.png"
    };

    public static readonly MaterialModel _3030065 = new()
    {
        Rid = 3030065,
        Vid = 112111,
        Name = "聚燃的命种",
        GoodKey = "IgnitedSeedOfLife",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112111.png"
    };

    public static readonly MaterialModel _3030066 = new()
    {
        Rid = 3030066,
        Vid = 112110,
        Name = "聚燃的石块",
        GoodKey = "IgnitedStone",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112110.png"
    };

    public static readonly MaterialGroupModel G3030064 = new([_3030064, _3030065, _3030066]);

    public static readonly MaterialModel _3030067 = new()
    {
        Rid = 3030067,
        Vid = 112115,
        Name = "秘源真芯",
        GoodKey = "HeartOfTheSecretSource",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112115.png"
    };

    public static readonly MaterialModel _3030068 = new()
    {
        Rid = 3030068,
        Vid = 112114,
        Name = "秘源机鞘",
        GoodKey = "SheathOfTheSecretSource",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112114.png"
    };

    public static readonly MaterialModel _3030069 = new()
    {
        Rid = 3030069,
        Vid = 112113,
        Name = "秘源轴",
        GoodKey = "AxisOfTheSecretSource",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112113.png"
    };

    public static readonly MaterialGroupModel G3030067 = new([_3030067, _3030068, _3030069]);

    public static readonly MaterialModel _3030070 = new()
    {
        Rid = 3030070,
        Vid = 112118,
        Name = "迷光的蜷叶之心",
        GoodKey = "IllusoryLeafcoil",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112118.png"
    };

    public static readonly MaterialModel _3030071 = new()
    {
        Rid = 3030071,
        Vid = 112117,
        Name = "惑光的阔叶",
        GoodKey = "BewilderingBroadleaf",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112117.png"
    };

    public static readonly MaterialModel _3030072 = new()
    {
        Rid = 3030072,
        Vid = 112116,
        Name = "折光的胚芽",
        GoodKey = "RefractiveBud",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112116.png"
    };

    public static readonly MaterialGroupModel G3030070 = new([_3030070, _3030071, _3030072]);

    public static readonly MaterialModel _3030073 = new()
    {
        Rid = 3030073,
        Vid = 112121,
        Name = "明燃的棱状壳",
        GoodKey = "BlazingPrismshell",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112121.png"
    };

    public static readonly MaterialModel _3030074 = new()
    {
        Rid = 3030074,
        Vid = 112120,
        Name = "蕴热的背壳",
        GoodKey = "WarmBackShell",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112120.png"
    };

    public static readonly MaterialModel _3030075 = new()
    {
        Rid = 3030075,
        Vid = 112119,
        Name = "冷裂壳块",
        GoodKey = "ColdCrackedShellshard",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112119.png"
    };

    public static readonly MaterialGroupModel G3030073 = new([_3030073, _3030074, _3030075]);

    public static readonly MaterialModel _3030076 = new()
    {
        Rid = 3030076,
        Vid = 112130,
        Name = "霜夜的煌荣",
        GoodKey = "FrostnightsGlory",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112130.png"
    };

    public static readonly MaterialModel _3030077 = new()
    {
        Rid = 3030077,
        Vid = 112129,
        Name = "霜夜的柔辉",
        GoodKey = "FrostnightsGlow",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112129.png"
    };

    public static readonly MaterialModel _3030078 = new()
    {
        Rid = 3030078,
        Vid = 112128,
        Name = "霜夜的残照",
        GoodKey = "FrostnightsGlimmer",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112128.png"
    };

    public static readonly MaterialGroupModel G3030076 = new([_3030076, _3030077, _3030078]);

    public static readonly MaterialModel _3030079 = new()
    {
        Rid = 3030079,
        Vid = 112133,
        Name = "繁光躯外骸",
        GoodKey = "RadiantExoskeleton",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112133.png"
    };

    public static readonly MaterialModel _3030080 = new()
    {
        Rid = 3030080,
        Vid = 112132,
        Name = "稀光遗骼",
        GoodKey = "GlowingRemains",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112132.png"
    };

    public static readonly MaterialModel _3030081 = new()
    {
        Rid = 3030081,
        Vid = 112131,
        Name = "失光块骨",
        GoodKey = "LightlessBone",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112131.png"
    };

    public static readonly MaterialGroupModel G3030079 = new([_3030079, _3030080, _3030081]);

    public static readonly MaterialModel _3030082 = new()
    {
        Rid = 3030082,
        Vid = 112136,
        Name = "幽雾兜盔",
        GoodKey = "MistshroudHelmet",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112136.png"
    };

    public static readonly MaterialModel _3030083 = new()
    {
        Rid = 3030083,
        Vid = 112135,
        Name = "幽雾片甲",
        GoodKey = "MistshroudPlate",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112135.png"
    };

    public static readonly MaterialModel _3030084 = new()
    {
        Rid = 3030084,
        Vid = 112134,
        Name = "幽雾化形",
        GoodKey = "MistshroudManifestation",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112134.png"
    };

    public static readonly MaterialGroupModel G3030082 = new([_3030082, _3030083, _3030084]);

    public static readonly MaterialModel _3030085 = new()
    {
        Rid = 3030085,
        Vid = 112139,
        Name = "深黯的钩喙",
        GoodKey = "HookedBeakOfTheDeepShadow",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112139.png"
    };

    public static readonly MaterialModel _3030086 = new()
    {
        Rid = 3030086,
        Vid = 112138,
        Name = "深黯的怪核",
        GoodKey = "AberrantCoreOfTheDeepShadow",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112138.png"
    };

    public static readonly MaterialModel _3030087 = new()
    {
        Rid = 3030087,
        Vid = 112137,
        Name = "深黯的裂眼",
        GoodKey = "FracturedEyeOfTheDeepShadow",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112137.png"
    };

    public static readonly MaterialGroupModel G3030085 = new([_3030085, _3030086, _3030087]);

    public static readonly MaterialModel _3030088 = new()
    {
        Rid = 3030088,
        Vid = 112142,
        Name = "宝饰的焰剑",
        GoodKey = "JeweledFlamingHilt",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112142.png"
    };

    public static readonly MaterialModel _3030089 = new()
    {
        Rid = 3030089,
        Vid = 112141,
        Name = "残失的焰剑",
        GoodKey = "FracturedFlamingHilt",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112141.png"
    };

    public static readonly MaterialModel _3030090 = new()
    {
        Rid = 3030090,
        Vid = 112140,
        Name = "失色的焰剑",
        GoodKey = "FadedFlamingHilt",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement1,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112140.png"
    };

    public static readonly MaterialGroupModel G3030088 = new([_3030088, _3030089, _3030090]);
}