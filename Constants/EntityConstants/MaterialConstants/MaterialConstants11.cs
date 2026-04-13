using HexereiKatepnha.Models.EntityModels;

namespace HexereiKatepnha.Constants.EntityConstants.MaterialConstants;

public class MaterialConstants11
{
    // 311 - 武器强化素材
    public static readonly MaterialModel _3110001 = new()
    {
        Rid = 3110001,
        Vid = 104013,
        Name = "精锻用魔矿",
        GoodKey = "MysticEnhancementOre",
        Star = 3,
        MaterialType = Enumeration.MaterialType.WeaponExp,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104013.png"
    };

    public static readonly MaterialModel _3110002 = new()
    {
        Rid = 3110002,
        Vid = 104012,
        Name = "精锻用良矿",
        GoodKey = "FineEnhancementOre",
        Star = 2,
        MaterialType = Enumeration.MaterialType.WeaponExp,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104012.png"
    };

    public static readonly MaterialModel _3110003 = new()
    {
        Rid = 3110003,
        Vid = 104011,
        Name = "精锻用杂矿",
        GoodKey = "EnhancementOre",
        Star = 1,
        MaterialType = Enumeration.MaterialType.WeaponExp,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104011.png"
    };
}