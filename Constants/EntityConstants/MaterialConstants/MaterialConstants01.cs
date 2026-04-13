using HexereiKatepnha.Models.EntityModels;

namespace HexereiKatepnha.Constants.EntityConstants.MaterialConstants;

public static class MaterialConstants01
{
    // 301 - 摩拉
    public static readonly MaterialModel _3010001 = new()
    {
        Rid = 3010001,
        Vid = 202,
        Name = "摩拉",
        GoodKey = "Mora",
        Star = 3,
        MaterialType = Enumeration.MaterialType.Mora,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_202.png"
    };
}