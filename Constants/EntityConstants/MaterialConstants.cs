using HexereiKatepnha.Models.EntityModels;

namespace HexereiKatepnha.Constants.EntityConstants;

public static class MaterialConstants
{
    // 摩拉
    public static readonly MaterialModel _3010001 = new()
    {
        Rid = 3010001,
        Vid = 202,
        Name = "摩拉",
        Star = 3,
        MaterialType = Enumeration.MaterialType.Mora,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_202.png"
    };
    
    // 角色经验素材
    // 角色与武器培养素材_234
    // 角色与武器培养素材_123
    // 角色培养素材_周本
    // 角色培养素材_40体力BOSS
    // 角色突破素材_钻儿块儿片儿粒儿
    // 角色天赋素材
    // 武器突破素材
    // 地方特产
    public static readonly MaterialModel _3100101 = new()
    {
        Rid = 3100101,
        Vid = 100021,
        Name = "钩钩果",
        Star = 1,
        MaterialType = Enumeration.MaterialType.LocalSpecialty,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_100021.png"
    };

}