using System.Windows.Media.Media3D;
using HexereiKatepnha.Models.EntityModels;

namespace HexereiKatepnha.Constants.EntityConstants;

public static class WeaponConstants
{
    public static readonly WeaponModel _2010101 = new()
    {
        Rid = 2010101,
        Vid = 11101,
        Name = "无锋剑",
        Star = 1,
        ImagePath = "/Resources/Images/Weapon/UI_EquipIcon_Sword_Blunt.png",
        AwakenImagePath = "/Resources/Images/Weapon/UI_EquipIcon_Sword_Blunt_Awaken.png",
        WeaponType = Enumeration.WeaponType.Sword,
        SubAffix = Enumeration.Affix.Empty,
        Progression =
        {
            {1, "（无）"},
            {2, "（无）"},
            {3, "（无）"},
            {4, "（无）"},
            {5, "（无）"},
        },
        MainAffixNumberDictionary = FigureConstants.Weapon1AttackMap,
        SubAffixNumberDictionary = FigureConstants.Weapon1SubAffixMap,
        LevelUpMaterials = FigureConstants.GetWeapon1LevelUpMaterial(MaterialConstants.G3040010, MaterialConstants.G3030001, MaterialConstants.G3090001),
    };
}