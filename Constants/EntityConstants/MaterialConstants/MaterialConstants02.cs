using HexereiKatepnha.Models.EntityModels;

namespace HexereiKatepnha.Constants.EntityConstants.MaterialConstants;

public static class MaterialConstants02
{
    // 302 - 角色经验素材
    public static readonly MaterialModel _3020001 = new()
    {
        Rid = 3020001,
        Vid = 104003,
        Name = "大英雄的经验",
        GoodKey = "HerosWit",
        Star = 4,
        MaterialType = Enumeration.MaterialType.CharacterExp,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104003.png"
    };

    public static readonly MaterialModel _3020002 = new()
    {
        Rid = 3020002,
        Vid = 104002,
        Name = "冒险家的经验",
        GoodKey = "AdventurersExperience",
        Star = 3,
        MaterialType = Enumeration.MaterialType.CharacterExp,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104002.png"
    };

    public static readonly MaterialModel _3020003 = new()
    {
        Rid = 3020003,
        Vid = 104001,
        Name = "流浪者的经验",
        GoodKey = "WanderersAdvice",
        Star = 2,
        MaterialType = Enumeration.MaterialType.CharacterExp,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_104001.png"
    };
}