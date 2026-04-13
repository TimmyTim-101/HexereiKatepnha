using HexereiKatepnha.Models.EntityModels;

namespace HexereiKatepnha.Constants.EntityConstants.MaterialConstants;

public class MaterialConstants04
{
    // 304 - 角色与武器培养素材_123
    public static readonly MaterialModel _3040001 = new()
    {
        Rid = 3040001,
        Vid = 112004,
        Name = "史莱姆原浆",
        GoodKey = "SlimeConcentrate",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112004.png"
    };

    public static readonly MaterialModel _3040002 = new()
    {
        Rid = 3040002,
        Vid = 112003,
        Name = "史莱姆清",
        GoodKey = "SlimeSecretions",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112003.png"
    };

    public static readonly MaterialModel _3040003 = new()
    {
        Rid = 3040003,
        Vid = 112002,
        Name = "史莱姆凝液",
        GoodKey = "SlimeCondensate",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112002.png"
    };

    public static readonly MaterialGroupModel G3040001 = new([_3040001, _3040002, _3040003]);

    public static readonly MaterialModel _3040004 = new()
    {
        Rid = 3040004,
        Vid = 112007,
        Name = "不祥的面具",
        GoodKey = "OminousMask",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112007.png"
    };

    public static readonly MaterialModel _3040005 = new()
    {
        Rid = 3040005,
        Vid = 112006,
        Name = "污秽的面具",
        GoodKey = "StainedMask",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112006.png"
    };

    public static readonly MaterialModel _3040006 = new()
    {
        Rid = 3040006,
        Vid = 112005,
        Name = "破损的面具",
        GoodKey = "DamagedMask",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112005.png"
    };

    public static readonly MaterialGroupModel G3040004 = new([_3040004, _3040005, _3040006]);

    public static readonly MaterialModel _3040007 = new()
    {
        Rid = 3040007,
        Vid = 112010,
        Name = "禁咒绘卷",
        GoodKey = "ForbiddenCurseScroll",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112010.png"
    };

    public static readonly MaterialModel _3040008 = new()
    {
        Rid = 3040008,
        Vid = 112009,
        Name = "封魔绘卷",
        GoodKey = "SealedScroll",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112009.png"
    };

    public static readonly MaterialModel _3040009 = new()
    {
        Rid = 3040009,
        Vid = 112008,
        Name = "导能绘卷",
        GoodKey = "DiviningScroll",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112008.png"
    };

    public static readonly MaterialGroupModel G3040007 = new([_3040007, _3040008, _3040009]);

    public static readonly MaterialModel _3040010 = new()
    {
        Rid = 3040010,
        Vid = 112013,
        Name = "历战的箭簇",
        GoodKey = "WeatheredArrowhead",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112013.png"
    };

    public static readonly MaterialModel _3040011 = new()
    {
        Rid = 3040011,
        Vid = 112012,
        Name = "锐利的箭簇",
        GoodKey = "SharpArrowhead",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112012.png"
    };

    public static readonly MaterialModel _3040012 = new()
    {
        Rid = 3040012,
        Vid = 112011,
        Name = "牢固的箭簇",
        GoodKey = "FirmArrowhead",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112011.png"
    };

    public static readonly MaterialGroupModel G3040010 = new([_3040010, _3040011, _3040012]);

    public static readonly MaterialModel _3040013 = new()
    {
        Rid = 3040013,
        Vid = 112034,
        Name = "尉官的徽记",
        GoodKey = "LieutenantsInsignia",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112034.png"
    };

    public static readonly MaterialModel _3040014 = new()
    {
        Rid = 3040014,
        Vid = 112033,
        Name = "士官的徽记",
        GoodKey = "SergeantsInsignia",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112033.png"
    };

    public static readonly MaterialModel _3040015 = new()
    {
        Rid = 3040015,
        Vid = 112032,
        Name = "新兵的徽记",
        GoodKey = "RecruitsInsignia",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112032.png"
    };

    public static readonly MaterialGroupModel G3040013 = new([_3040013, _3040014, _3040015]);

    public static readonly MaterialModel _3040016 = new()
    {
        Rid = 3040016,
        Vid = 112037,
        Name = "攫金鸦印",
        GoodKey = "GoldenRavenInsignia",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112037.png"
    };

    public static readonly MaterialModel _3040017 = new()
    {
        Rid = 3040017,
        Vid = 112036,
        Name = "藏银鸦印",
        GoodKey = "SilverRavenInsignia",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112036.png"
    };

    public static readonly MaterialModel _3040018 = new()
    {
        Rid = 3040018,
        Vid = 112035,
        Name = "寻宝鸦印",
        GoodKey = "TreasureHoarderInsignia",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112035.png"
    };

    public static readonly MaterialGroupModel G3040016 = new([_3040016, _3040017, _3040018]);

    public static readonly MaterialModel _3040019 = new()
    {
        Rid = 3040019,
        Vid = 112040,
        Name = "原素花蜜",
        GoodKey = "EnergyNectar",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112040.png"
    };

    public static readonly MaterialModel _3040020 = new()
    {
        Rid = 3040020,
        Vid = 112039,
        Name = "微光花蜜",
        GoodKey = "ShimmeringNectar",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112039.png"
    };

    public static readonly MaterialModel _3040021 = new()
    {
        Rid = 3040021,
        Vid = 112038,
        Name = "骗骗花蜜",
        GoodKey = "WhopperflowerNectar",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112038.png"
    };

    public static readonly MaterialGroupModel G3040019 = new([_3040019, _3040020, _3040021]);

    public static readonly MaterialModel _3040022 = new()
    {
        Rid = 3040022,
        Vid = 112046,
        Name = "名刀镡",
        GoodKey = "FamedHandguard",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112046.png"
    };

    public static readonly MaterialModel _3040023 = new()
    {
        Rid = 3040023,
        Vid = 112045,
        Name = "影打刀镡",
        GoodKey = "KageuchiHandguard",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112045.png"
    };

    public static readonly MaterialModel _3040024 = new()
    {
        Rid = 3040024,
        Vid = 112044,
        Name = "破旧的刀镡",
        GoodKey = "OldHandguard",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112044.png"
    };

    public static readonly MaterialGroupModel G3040022 = new([_3040022, _3040023, _3040024]);

    public static readonly MaterialModel _3040025 = new()
    {
        Rid = 3040025,
        Vid = 112055,
        Name = "浮游晶化核",
        GoodKey = "SpectralNucleus",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112055.png"
    };

    public static readonly MaterialModel _3040026 = new()
    {
        Rid = 3040026,
        Vid = 112054,
        Name = "浮游幽核",
        GoodKey = "SpectralHeart",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112054.png"
    };

    public static readonly MaterialModel _3040027 = new()
    {
        Rid = 3040027,
        Vid = 112053,
        Name = "浮游干核",
        GoodKey = "SpectralHusk",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112053.png"
    };

    public static readonly MaterialGroupModel G3040025 = new([_3040025, _3040026, _3040027]);

    public static readonly MaterialModel _3040028 = new()
    {
        Rid = 3040028,
        Vid = 112061,
        Name = "孢囊晶尘",
        GoodKey = "CrystallineCystDust",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112061.png"
    };

    public static readonly MaterialModel _3040029 = new()
    {
        Rid = 3040029,
        Vid = 112060,
        Name = "荧光孢粉",
        GoodKey = "LuminescentPollen",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112060.png"
    };

    public static readonly MaterialModel _3040030 = new()
    {
        Rid = 3040030,
        Vid = 112059,
        Name = "蕈兽孢子",
        GoodKey = "FungalSpores",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112059.png"
    };

    public static readonly MaterialGroupModel G3040028 = new([_3040028, _3040029, _3040030]);

    public static readonly MaterialModel _3040031 = new()
    {
        Rid = 3040031,
        Vid = 112067,
        Name = "织金红绸",
        GoodKey = "RichRedBrocade",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112067.png"
    };

    public static readonly MaterialModel _3040032 = new()
    {
        Rid = 3040032,
        Vid = 112066,
        Name = "镶边红绸",
        GoodKey = "TrimmedRedSilk",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112066.png"
    };

    public static readonly MaterialModel _3040033 = new()
    {
        Rid = 3040033,
        Vid = 112065,
        Name = "褪色红绸",
        GoodKey = "FadedRedSatin",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112065.png"
    };

    public static readonly MaterialGroupModel G3040031 = new([_3040031, _3040032, _3040033]);

    public static readonly MaterialModel _3040034 = new()
    {
        Rid = 3040034,
        Vid = 112082,
        Name = "异色结晶石",
        GoodKey = "XenochromaticCrystal",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112082.png"
    };

    public static readonly MaterialModel _3040035 = new()
    {
        Rid = 3040035,
        Vid = 112081,
        Name = "异海之块",
        GoodKey = "TransoceanicChunk",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112081.png"
    };

    public static readonly MaterialModel _3040036 = new()
    {
        Rid = 3040036,
        Vid = 112080,
        Name = "异海凝珠",
        GoodKey = "TransoceanicPearl",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112080.png"
    };

    public static readonly MaterialGroupModel G3040034 = new([_3040034, _3040035, _3040036]);

    public static readonly MaterialModel _3040037 = new()
    {
        Rid = 3040037,
        Vid = 112085,
        Name = "奇械机芯齿轮",
        GoodKey = "ArtificedDynamicGear",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112085.png"
    };

    public static readonly MaterialModel _3040038 = new()
    {
        Rid = 3040038,
        Vid = 112084,
        Name = "机关正齿轮",
        GoodKey = "MechanicalSpurGear",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112084.png"
    };

    public static readonly MaterialModel _3040039 = new()
    {
        Rid = 3040039,
        Vid = 112083,
        Name = "啮合齿轮",
        GoodKey = "MeshingGear",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112083.png"
    };

    public static readonly MaterialGroupModel G3040037 = new([_3040037, _3040038, _3040039]);

    public static readonly MaterialModel _3040040 = new()
    {
        Rid = 3040040,
        Vid = 112103,
        Name = "横行霸者的利齿",
        GoodKey = "TyrantsFang",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112103.png"
    };

    public static readonly MaterialModel _3040041 = new()
    {
        Rid = 3040041,
        Vid = 112102,
        Name = "老练的坚齿",
        GoodKey = "SeasonedFang",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112102.png"
    };

    public static readonly MaterialModel _3040042 = new()
    {
        Rid = 3040042,
        Vid = 112101,
        Name = "稚嫩的尖齿",
        GoodKey = "JuvenileFang",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112101.png"
    };

    public static readonly MaterialGroupModel G3040040 = new([_3040040, _3040041, _3040042]);

    public static readonly MaterialModel _3040043 = new()
    {
        Rid = 3040043,
        Vid = 112106,
        Name = "龙冠武士的金哨",
        GoodKey = "SaurianCrownedWarriorsGoldenWhistle",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112106.png"
    };

    public static readonly MaterialModel _3040044 = new()
    {
        Rid = 3040044,
        Vid = 112105,
        Name = "战士的铁哨",
        GoodKey = "WarriorsMetalWhistle",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112105.png"
    };

    public static readonly MaterialModel _3040045 = new()
    {
        Rid = 3040045,
        Vid = 112104,
        Name = "卫从的木哨",
        GoodKey = "SentrysWoodenWhistle",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112104.png"
    };

    public static readonly MaterialGroupModel G3040043 = new([_3040043, _3040044, _3040045]);

    public static readonly MaterialModel _3040046 = new()
    {
        Rid = 3040046,
        Vid = 112124,
        Name = "精制机轴",
        GoodKey = "PrecisionDriveShaft",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112124.png"
    };

    public static readonly MaterialModel _3040047 = new()
    {
        Rid = 3040047,
        Vid = 112123,
        Name = "加固机轴",
        GoodKey = "ReinforcedDriveShaft",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112123.png"
    };

    public static readonly MaterialModel _3040048 = new()
    {
        Rid = 3040048,
        Vid = 112122,
        Name = "毁损机轴",
        GoodKey = "BrokenDriveShaft",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112122.png"
    };

    public static readonly MaterialGroupModel G3040046 = new([_3040046, _3040047, _3040048]);

    public static readonly MaterialModel _3040049 = new()
    {
        Rid = 3040049,
        Vid = 112127,
        Name = "霜镌的执凭",
        GoodKey = "FrostEtchedWarrant",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112127.png"
    };

    public static readonly MaterialModel _3040050 = new()
    {
        Rid = 3040050,
        Vid = 112126,
        Name = "精致的执凭",
        GoodKey = "ImmaculateWarrant",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112126.png"
    };

    public static readonly MaterialModel _3040051 = new()
    {
        Rid = 3040051,
        Vid = 112125,
        Name = "磨损的执凭",
        GoodKey = "TatteredWarrant",
        Star = 1,
        MaterialType = Enumeration.MaterialType.CharacterWeaponEnhancement2,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_112125.png"
    };

    public static readonly MaterialGroupModel G3040049 = new([_3040049, _3040050, _3040051]);
}