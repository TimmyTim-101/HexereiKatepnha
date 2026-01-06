using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.EntityModels;

namespace HexereiKatepnha.Constants.EntityConstants.WeaponConstants;

// 202 - 双手剑
public static class Claymore123Constants
{
    // 20201 - 双手剑1星
    public static readonly WeaponModel _2020101 = new()
    {
        Rid = 2020101,
        Vid = 12101,
        Name = "训练大剑",
        Star = 1,
        ImagePath = "/Resources/Images/Weapon/UI_EquipIcon_Claymore_Aniki.png",
        AwakenImagePath = "/Resources/Images/Weapon/UI_EquipIcon_Claymore_Aniki_Awaken.png",
        WeaponType = Enumeration.WeaponType.Claymore,
        SubAffix = Enumeration.Affix.Empty,
        Progression = { { 1, "（无）" }, { 2, "（无）" }, { 3, "（无）" }, { 4, "（无）" }, { 5, "（无）" }, },
        MainAffixNumberDictionary = new Dictionary<Enumeration.Level, double>()
        {
            { Enumeration.Level.L1, 23 }, { Enumeration.Level.L2, 25 }, { Enumeration.Level.L3, 27 }, { Enumeration.Level.L4, 29 }, { Enumeration.Level.L5, 30 },
            { Enumeration.Level.L6, 32 }, { Enumeration.Level.L7, 34 }, { Enumeration.Level.L8, 36 }, { Enumeration.Level.L9, 37 }, { Enumeration.Level.L10, 39 },
            { Enumeration.Level.L11, 41 }, { Enumeration.Level.L12, 42 }, { Enumeration.Level.L13, 44 }, { Enumeration.Level.L14, 46 }, { Enumeration.Level.L15, 48 },
            { Enumeration.Level.L16, 49 }, { Enumeration.Level.L17, 51 }, { Enumeration.Level.L18, 53 }, { Enumeration.Level.L19, 55 }, { Enumeration.Level.L20, 56 }, { Enumeration.Level.L20P, 68 },
            { Enumeration.Level.L21, 70 }, { Enumeration.Level.L22, 71 }, { Enumeration.Level.L23, 73 }, { Enumeration.Level.L24, 75 }, { Enumeration.Level.L25, 76 },
            { Enumeration.Level.L26, 78 }, { Enumeration.Level.L27, 80 }, { Enumeration.Level.L28, 82 }, { Enumeration.Level.L29, 83 }, { Enumeration.Level.L30, 85 },
            { Enumeration.Level.L31, 87 }, { Enumeration.Level.L32, 88 }, { Enumeration.Level.L33, 90 }, { Enumeration.Level.L34, 92 }, { Enumeration.Level.L35, 93 },
            { Enumeration.Level.L36, 95 }, { Enumeration.Level.L37, 97 }, { Enumeration.Level.L38, 98 }, { Enumeration.Level.L39, 100 }, { Enumeration.Level.L40, 102 }, { Enumeration.Level.L40P, 113 },
            { Enumeration.Level.L41, 115 }, { Enumeration.Level.L42, 116 }, { Enumeration.Level.L43, 118 }, { Enumeration.Level.L44, 120 }, { Enumeration.Level.L45, 121 },
            { Enumeration.Level.L46, 123 }, { Enumeration.Level.L47, 125 }, { Enumeration.Level.L48, 126 }, { Enumeration.Level.L49, 128 }, { Enumeration.Level.L50, 130 }, { Enumeration.Level.L50P, 141 },
            { Enumeration.Level.L51, 143 }, { Enumeration.Level.L52, 145 }, { Enumeration.Level.L53, 146 }, { Enumeration.Level.L54, 148 }, { Enumeration.Level.L55, 149 },
            { Enumeration.Level.L56, 151 }, { Enumeration.Level.L57, 153 }, { Enumeration.Level.L58, 154 }, { Enumeration.Level.L59, 156 }, { Enumeration.Level.L60, 158 }, { Enumeration.Level.L60P, 169 },
            { Enumeration.Level.L61, 171 }, { Enumeration.Level.L62, 173 }, { Enumeration.Level.L63, 174 }, { Enumeration.Level.L64, 176 }, { Enumeration.Level.L65, 177 },
            { Enumeration.Level.L66, 179 }, { Enumeration.Level.L67, 181 }, { Enumeration.Level.L68, 182 }, { Enumeration.Level.L69, 184 }, { Enumeration.Level.L70, 185 },
        },
        SubAffixNumberDictionary = new Dictionary<Enumeration.Level, double>()
        {
            { Enumeration.Level.L1, 0 }, { Enumeration.Level.L2, 0 }, { Enumeration.Level.L3, 0 }, { Enumeration.Level.L4, 0 }, { Enumeration.Level.L5, 0 },
            { Enumeration.Level.L6, 0 }, { Enumeration.Level.L7, 0 }, { Enumeration.Level.L8, 0 }, { Enumeration.Level.L9, 0 }, { Enumeration.Level.L10, 0 },
            { Enumeration.Level.L11, 0 }, { Enumeration.Level.L12, 0 }, { Enumeration.Level.L13, 0 }, { Enumeration.Level.L14, 0 }, { Enumeration.Level.L15, 0 },
            { Enumeration.Level.L16, 0 }, { Enumeration.Level.L17, 0 }, { Enumeration.Level.L18, 0 }, { Enumeration.Level.L19, 0 }, { Enumeration.Level.L20, 0 }, { Enumeration.Level.L20P, 0 },
            { Enumeration.Level.L21, 0 }, { Enumeration.Level.L22, 0 }, { Enumeration.Level.L23, 0 }, { Enumeration.Level.L24, 0 }, { Enumeration.Level.L25, 0 },
            { Enumeration.Level.L26, 0 }, { Enumeration.Level.L27, 0 }, { Enumeration.Level.L28, 0 }, { Enumeration.Level.L29, 0 }, { Enumeration.Level.L30, 0 },
            { Enumeration.Level.L31, 0 }, { Enumeration.Level.L32, 0 }, { Enumeration.Level.L33, 0 }, { Enumeration.Level.L34, 0 }, { Enumeration.Level.L35, 0 },
            { Enumeration.Level.L36, 0 }, { Enumeration.Level.L37, 0 }, { Enumeration.Level.L38, 0 }, { Enumeration.Level.L39, 0 }, { Enumeration.Level.L40, 0 }, { Enumeration.Level.L40P, 0 },
            { Enumeration.Level.L41, 0 }, { Enumeration.Level.L42, 0 }, { Enumeration.Level.L43, 0 }, { Enumeration.Level.L44, 0 }, { Enumeration.Level.L45, 0 },
            { Enumeration.Level.L46, 0 }, { Enumeration.Level.L47, 0 }, { Enumeration.Level.L48, 0 }, { Enumeration.Level.L49, 0 }, { Enumeration.Level.L50, 0 }, { Enumeration.Level.L50P, 0 },
            { Enumeration.Level.L51, 0 }, { Enumeration.Level.L52, 0 }, { Enumeration.Level.L53, 0 }, { Enumeration.Level.L54, 0 }, { Enumeration.Level.L55, 0 },
            { Enumeration.Level.L56, 0 }, { Enumeration.Level.L57, 0 }, { Enumeration.Level.L58, 0 }, { Enumeration.Level.L59, 0 }, { Enumeration.Level.L60, 0 }, { Enumeration.Level.L60P, 0 },
            { Enumeration.Level.L61, 0 }, { Enumeration.Level.L62, 0 }, { Enumeration.Level.L63, 0 }, { Enumeration.Level.L64, 0 }, { Enumeration.Level.L65, 0 },
            { Enumeration.Level.L66, 0 }, { Enumeration.Level.L67, 0 }, { Enumeration.Level.L68, 0 }, { Enumeration.Level.L69, 0 }, { Enumeration.Level.L70, 0 },
        },
        LevelUpMaterials = WeaponLevelUpConstants.GetWeapon1LevelUpMaterial(MaterialConstants.G3040001, MaterialConstants.G3030004, MaterialConstants.G3090005),
    };

    // 20202 - 双手剑2星
    public static readonly WeaponModel _2020201 = new()
    {
        Rid = 2020201,
        Vid = 12201,
        Name = "佣兵重剑",
        Star = 2,
        ImagePath = "/Resources/Images/Weapon/UI_EquipIcon_Claymore_Oyaji.png",
        AwakenImagePath = "/Resources/Images/Weapon/UI_EquipIcon_Claymore_Oyaji_Awaken.png",
        WeaponType = Enumeration.WeaponType.Claymore,
        SubAffix = Enumeration.Affix.Empty,
        Progression = { { 1, "（无）" }, { 2, "（无）" }, { 3, "（无）" }, { 4, "（无）" }, { 5, "（无）" }, },
        MainAffixNumberDictionary = new Dictionary<Enumeration.Level, double>()
        {
            { Enumeration.Level.L1, 33 }, { Enumeration.Level.L2, 35 }, { Enumeration.Level.L3, 38 }, { Enumeration.Level.L4, 40 }, { Enumeration.Level.L5, 43 },
            { Enumeration.Level.L6, 45 }, { Enumeration.Level.L7, 48 }, { Enumeration.Level.L8, 50 }, { Enumeration.Level.L9, 53 }, { Enumeration.Level.L10, 55 },
            { Enumeration.Level.L11, 58 }, { Enumeration.Level.L12, 60 }, { Enumeration.Level.L13, 63 }, { Enumeration.Level.L14, 65 }, { Enumeration.Level.L15, 68 },
            { Enumeration.Level.L16, 70 }, { Enumeration.Level.L17, 72 }, { Enumeration.Level.L18, 75 }, { Enumeration.Level.L19, 77 }, { Enumeration.Level.L20, 80 }, { Enumeration.Level.L20P, 91 },
            { Enumeration.Level.L21, 94 }, { Enumeration.Level.L22, 96 }, { Enumeration.Level.L23, 99 }, { Enumeration.Level.L24, 101 }, { Enumeration.Level.L25, 103 },
            { Enumeration.Level.L26, 106 }, { Enumeration.Level.L27, 108 }, { Enumeration.Level.L28, 111 }, { Enumeration.Level.L29, 113 }, { Enumeration.Level.L30, 115 },
            { Enumeration.Level.L31, 118 }, { Enumeration.Level.L32, 120 }, { Enumeration.Level.L33, 123 }, { Enumeration.Level.L34, 125 }, { Enumeration.Level.L35, 127 },
            { Enumeration.Level.L36, 130 }, { Enumeration.Level.L37, 132 }, { Enumeration.Level.L38, 134 }, { Enumeration.Level.L39, 137 }, { Enumeration.Level.L40, 139 }, { Enumeration.Level.L40P, 151 },
            { Enumeration.Level.L41, 153 }, { Enumeration.Level.L42, 155 }, { Enumeration.Level.L43, 158 }, { Enumeration.Level.L44, 160 }, { Enumeration.Level.L45, 162 },
            { Enumeration.Level.L46, 165 }, { Enumeration.Level.L47, 167 }, { Enumeration.Level.L48, 169 }, { Enumeration.Level.L49, 172 }, { Enumeration.Level.L50, 174 }, { Enumeration.Level.L50P, 186 },
            { Enumeration.Level.L51, 188 }, { Enumeration.Level.L52, 190 }, { Enumeration.Level.L53, 193 }, { Enumeration.Level.L54, 195 }, { Enumeration.Level.L55, 197 },
            { Enumeration.Level.L56, 199 }, { Enumeration.Level.L57, 202 }, { Enumeration.Level.L58, 204 }, { Enumeration.Level.L59, 206 }, { Enumeration.Level.L60, 209 }, { Enumeration.Level.L60P, 220 },
            { Enumeration.Level.L61, 223 }, { Enumeration.Level.L62, 225 }, { Enumeration.Level.L63, 227 }, { Enumeration.Level.L64, 230 }, { Enumeration.Level.L65, 232 },
            { Enumeration.Level.L66, 234 }, { Enumeration.Level.L67, 236 }, { Enumeration.Level.L68, 239 }, { Enumeration.Level.L69, 241 }, { Enumeration.Level.L70, 243 },
        },
        SubAffixNumberDictionary = new Dictionary<Enumeration.Level, double>()
        {
            { Enumeration.Level.L1, 0 }, { Enumeration.Level.L2, 0 }, { Enumeration.Level.L3, 0 }, { Enumeration.Level.L4, 0 }, { Enumeration.Level.L5, 0 },
            { Enumeration.Level.L6, 0 }, { Enumeration.Level.L7, 0 }, { Enumeration.Level.L8, 0 }, { Enumeration.Level.L9, 0 }, { Enumeration.Level.L10, 0 },
            { Enumeration.Level.L11, 0 }, { Enumeration.Level.L12, 0 }, { Enumeration.Level.L13, 0 }, { Enumeration.Level.L14, 0 }, { Enumeration.Level.L15, 0 },
            { Enumeration.Level.L16, 0 }, { Enumeration.Level.L17, 0 }, { Enumeration.Level.L18, 0 }, { Enumeration.Level.L19, 0 }, { Enumeration.Level.L20, 0 }, { Enumeration.Level.L20P, 0 },
            { Enumeration.Level.L21, 0 }, { Enumeration.Level.L22, 0 }, { Enumeration.Level.L23, 0 }, { Enumeration.Level.L24, 0 }, { Enumeration.Level.L25, 0 },
            { Enumeration.Level.L26, 0 }, { Enumeration.Level.L27, 0 }, { Enumeration.Level.L28, 0 }, { Enumeration.Level.L29, 0 }, { Enumeration.Level.L30, 0 },
            { Enumeration.Level.L31, 0 }, { Enumeration.Level.L32, 0 }, { Enumeration.Level.L33, 0 }, { Enumeration.Level.L34, 0 }, { Enumeration.Level.L35, 0 },
            { Enumeration.Level.L36, 0 }, { Enumeration.Level.L37, 0 }, { Enumeration.Level.L38, 0 }, { Enumeration.Level.L39, 0 }, { Enumeration.Level.L40, 0 }, { Enumeration.Level.L40P, 0 },
            { Enumeration.Level.L41, 0 }, { Enumeration.Level.L42, 0 }, { Enumeration.Level.L43, 0 }, { Enumeration.Level.L44, 0 }, { Enumeration.Level.L45, 0 },
            { Enumeration.Level.L46, 0 }, { Enumeration.Level.L47, 0 }, { Enumeration.Level.L48, 0 }, { Enumeration.Level.L49, 0 }, { Enumeration.Level.L50, 0 }, { Enumeration.Level.L50P, 0 },
            { Enumeration.Level.L51, 0 }, { Enumeration.Level.L52, 0 }, { Enumeration.Level.L53, 0 }, { Enumeration.Level.L54, 0 }, { Enumeration.Level.L55, 0 },
            { Enumeration.Level.L56, 0 }, { Enumeration.Level.L57, 0 }, { Enumeration.Level.L58, 0 }, { Enumeration.Level.L59, 0 }, { Enumeration.Level.L60, 0 }, { Enumeration.Level.L60P, 0 },
            { Enumeration.Level.L61, 0 }, { Enumeration.Level.L62, 0 }, { Enumeration.Level.L63, 0 }, { Enumeration.Level.L64, 0 }, { Enumeration.Level.L65, 0 },
            { Enumeration.Level.L66, 0 }, { Enumeration.Level.L67, 0 }, { Enumeration.Level.L68, 0 }, { Enumeration.Level.L69, 0 }, { Enumeration.Level.L70, 0 },
        },
        LevelUpMaterials = WeaponLevelUpConstants.GetWeapon2LevelUpMaterial(MaterialConstants.G3040001, MaterialConstants.G3030004, MaterialConstants.G3090005),
    };
    // 20203 - 双手剑3星
}