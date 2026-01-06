using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.EntityModels;

namespace HexereiKatepnha.Constants.EntityConstants;

public static class WeaponConstants
{
    // 201 - 单手剑
    // 20101 - 单手剑1星
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
        LevelUpMaterials = WeaponLevelUpConstants.GetWeapon1LevelUpMaterial(MaterialConstants.G3040010, MaterialConstants.G3030001, MaterialConstants.G3090001),
    };

    // 20102 - 单手剑2星
    public static readonly WeaponModel _2010201 = new()
    {
        Rid = 2010201,
        Vid = 11201,
        Name = "银剑",
        Star = 2,
        ImagePath = "/Resources/Images/Weapon/UI_EquipIcon_Sword_Silver.png",
        AwakenImagePath = "/Resources/Images/Weapon/UI_EquipIcon_Sword_Silver_Awaken.png",
        WeaponType = Enumeration.WeaponType.Sword,
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
        LevelUpMaterials = WeaponLevelUpConstants.GetWeapon2LevelUpMaterial(MaterialConstants.G3040010, MaterialConstants.G3030001, MaterialConstants.G3090001),
    };

    // 20103 - 单手剑3星
    public static readonly WeaponModel _2010301 = new()
    {
        Rid = 2010301,
        Vid = 11301,
        Name = "冷刃",
        Star = 3,
        ImagePath = "/Resources/Images/Weapon/UI_EquipIcon_Sword_Steel.png",
        AwakenImagePath = "/Resources/Images/Weapon/UI_EquipIcon_Sword_Steel_Awaken.png",
        WeaponType = Enumeration.WeaponType.Sword,
        SubAffix = Enumeration.Affix.AttackPercent,
        Progression =
        {
            { 1, "对处于水元素或冰元素影响下的敌人，造成的伤害提高12%。" },
            { 2, "对处于水元素或冰元素影响下的敌人，造成的伤害提高15%。" },
            { 3, "对处于水元素或冰元素影响下的敌人，造成的伤害提高18%。" },
            { 4, "对处于水元素或冰元素影响下的敌人，造成的伤害提高21%。" },
            { 5, "对处于水元素或冰元素影响下的敌人，造成的伤害提高24%。" },
        },
        MainAffixNumberDictionary = new Dictionary<Enumeration.Level, double>()
        {
            { Enumeration.Level.L1, 39 }, { Enumeration.Level.L2, 42 }, { Enumeration.Level.L3, 45 }, { Enumeration.Level.L4, 48 }, { Enumeration.Level.L5, 50 },
            { Enumeration.Level.L6, 53 }, { Enumeration.Level.L7, 56 }, { Enumeration.Level.L8, 59 }, { Enumeration.Level.L9, 62 }, { Enumeration.Level.L10, 65 },
            { Enumeration.Level.L11, 68 }, { Enumeration.Level.L12, 71 }, { Enumeration.Level.L13, 74 }, { Enumeration.Level.L14, 77 }, { Enumeration.Level.L15, 79 },
            { Enumeration.Level.L16, 82 }, { Enumeration.Level.L17, 85 }, { Enumeration.Level.L18, 88 }, { Enumeration.Level.L19, 91 }, { Enumeration.Level.L20, 94 }, { Enumeration.Level.L20P, 113 },
            { Enumeration.Level.L21, 116 }, { Enumeration.Level.L22, 119 }, { Enumeration.Level.L23, 122 }, { Enumeration.Level.L24, 125 }, { Enumeration.Level.L25, 127 },
            { Enumeration.Level.L26, 130 }, { Enumeration.Level.L27, 133 }, { Enumeration.Level.L28, 136 }, { Enumeration.Level.L29, 139 }, { Enumeration.Level.L30, 141 },
            { Enumeration.Level.L31, 144 }, { Enumeration.Level.L32, 147 }, { Enumeration.Level.L33, 150 }, { Enumeration.Level.L34, 153 }, { Enumeration.Level.L35, 155 },
            { Enumeration.Level.L36, 158 }, { Enumeration.Level.L37, 161 }, { Enumeration.Level.L38, 164 }, { Enumeration.Level.L39, 166 }, { Enumeration.Level.L40, 169 }, { Enumeration.Level.L40P, 189 },
            { Enumeration.Level.L41, 191 }, { Enumeration.Level.L42, 194 }, { Enumeration.Level.L43, 197 }, { Enumeration.Level.L44, 200 }, { Enumeration.Level.L45, 202 },
            { Enumeration.Level.L46, 205 }, { Enumeration.Level.L47, 208 }, { Enumeration.Level.L48, 211 }, { Enumeration.Level.L49, 213 }, { Enumeration.Level.L50, 216 }, { Enumeration.Level.L50P, 236 },
            { Enumeration.Level.L51, 238 }, { Enumeration.Level.L52, 241 }, { Enumeration.Level.L53, 244 }, { Enumeration.Level.L54, 246 }, { Enumeration.Level.L55, 249 },
            { Enumeration.Level.L56, 252 }, { Enumeration.Level.L57, 255 }, { Enumeration.Level.L58, 257 }, { Enumeration.Level.L59, 260 }, { Enumeration.Level.L60, 263 }, { Enumeration.Level.L60P, 282 },
            { Enumeration.Level.L61, 285 }, { Enumeration.Level.L62, 288 }, { Enumeration.Level.L63, 290 }, { Enumeration.Level.L64, 293 }, { Enumeration.Level.L65, 296 },
            { Enumeration.Level.L66, 298 }, { Enumeration.Level.L67, 301 }, { Enumeration.Level.L68, 304 }, { Enumeration.Level.L69, 306 }, { Enumeration.Level.L70, 309 }, { Enumeration.Level.L70P, 329 },
            { Enumeration.Level.L71, 331 }, { Enumeration.Level.L72, 334 }, { Enumeration.Level.L73, 337 }, { Enumeration.Level.L74, 339 }, { Enumeration.Level.L75, 342 },
            { Enumeration.Level.L76, 345 }, { Enumeration.Level.L77, 347 }, { Enumeration.Level.L78, 350 }, { Enumeration.Level.L79, 353 }, { Enumeration.Level.L80, 355 }, { Enumeration.Level.L80P, 375 },
            { Enumeration.Level.L81, 377 }, { Enumeration.Level.L82, 380 }, { Enumeration.Level.L83, 383 }, { Enumeration.Level.L84, 385 }, { Enumeration.Level.L85, 388 },
            { Enumeration.Level.L86, 391 }, { Enumeration.Level.L87, 393 }, { Enumeration.Level.L88, 396 }, { Enumeration.Level.L89, 399 }, { Enumeration.Level.L90, 401 },
        },
        SubAffixNumberDictionary = new Dictionary<Enumeration.Level, double>()
        {
            { Enumeration.Level.L1, 7.7 }, { Enumeration.Level.L2, 7.7 }, { Enumeration.Level.L3, 7.7 }, { Enumeration.Level.L4, 7.7 }, { Enumeration.Level.L5, 8.9 },
            { Enumeration.Level.L6, 8.9 }, { Enumeration.Level.L7, 8.9 }, { Enumeration.Level.L8, 8.9 }, { Enumeration.Level.L9, 8.9 }, { Enumeration.Level.L10, 10.4 },
            { Enumeration.Level.L11, 10.4 }, { Enumeration.Level.L12, 10.4 }, { Enumeration.Level.L13, 10.4 }, { Enumeration.Level.L14, 10.4 }, { Enumeration.Level.L15, 12.0 },
            { Enumeration.Level.L16, 12.0 }, { Enumeration.Level.L17, 12.0 }, { Enumeration.Level.L18, 12.0 }, { Enumeration.Level.L19, 12.0 }, { Enumeration.Level.L20, 13.5 }, { Enumeration.Level.L20P, 13.5 },
            { Enumeration.Level.L21, 13.5 }, { Enumeration.Level.L22, 13.5 }, { Enumeration.Level.L23, 13.5 }, { Enumeration.Level.L24, 13.5 }, { Enumeration.Level.L25, 15.1 },
            { Enumeration.Level.L26, 15.1 }, { Enumeration.Level.L27, 15.1 }, { Enumeration.Level.L28, 15.1 }, { Enumeration.Level.L29, 15.1 }, { Enumeration.Level.L30, 16.6 },
            { Enumeration.Level.L31, 16.6 }, { Enumeration.Level.L32, 16.6 }, { Enumeration.Level.L33, 16.6 }, { Enumeration.Level.L34, 16.6 }, { Enumeration.Level.L35, 18.2 },
            { Enumeration.Level.L36, 18.2 }, { Enumeration.Level.L37, 18.2 }, { Enumeration.Level.L38, 18.2 }, { Enumeration.Level.L39, 18.2 }, { Enumeration.Level.L40, 19.7 }, { Enumeration.Level.L40P, 19.7 },
            { Enumeration.Level.L41, 19.7 }, { Enumeration.Level.L42, 19.7 }, { Enumeration.Level.L43, 19.7 }, { Enumeration.Level.L44, 19.7 }, { Enumeration.Level.L45, 21.3 },
            { Enumeration.Level.L46, 21.3 }, { Enumeration.Level.L47, 21.3 }, { Enumeration.Level.L48, 21.3 }, { Enumeration.Level.L49, 21.3 }, { Enumeration.Level.L50, 22.8 }, { Enumeration.Level.L50P, 22.8 },
            { Enumeration.Level.L51, 22.8 }, { Enumeration.Level.L52, 22.8 }, { Enumeration.Level.L53, 22.8 }, { Enumeration.Level.L54, 22.8 }, { Enumeration.Level.L55, 24.4 },
            { Enumeration.Level.L56, 24.4 }, { Enumeration.Level.L57, 24.4 }, { Enumeration.Level.L58, 24.4 }, { Enumeration.Level.L59, 24.4 }, { Enumeration.Level.L60, 25.9 }, { Enumeration.Level.L60P, 25.9 },
            { Enumeration.Level.L61, 25.9 }, { Enumeration.Level.L62, 25.9 }, { Enumeration.Level.L63, 25.9 }, { Enumeration.Level.L64, 25.9 }, { Enumeration.Level.L65, 27.5 },
            { Enumeration.Level.L66, 27.5 }, { Enumeration.Level.L67, 27.5 }, { Enumeration.Level.L68, 27.5 }, { Enumeration.Level.L69, 27.5 }, { Enumeration.Level.L70, 29.0 }, { Enumeration.Level.L70P, 29.0 },
            { Enumeration.Level.L71, 29.0 }, { Enumeration.Level.L72, 29.0 }, { Enumeration.Level.L73, 29.0 }, { Enumeration.Level.L74, 29.0 }, { Enumeration.Level.L75, 30.5 },
            { Enumeration.Level.L76, 30.5 }, { Enumeration.Level.L77, 30.5 }, { Enumeration.Level.L78, 30.5 }, { Enumeration.Level.L79, 30.5 }, { Enumeration.Level.L80, 32.1 }, { Enumeration.Level.L80P, 32.1 },
            { Enumeration.Level.L81, 32.1 }, { Enumeration.Level.L82, 32.1 }, { Enumeration.Level.L83, 32.1 }, { Enumeration.Level.L84, 32.1 }, { Enumeration.Level.L85, 33.6 },
            { Enumeration.Level.L86, 33.6 }, { Enumeration.Level.L87, 33.6 }, { Enumeration.Level.L88, 33.6 }, { Enumeration.Level.L89, 33.6 }, { Enumeration.Level.L90, 35.2 },
        },
        LevelUpMaterials = WeaponLevelUpConstants.GetWeapon3LevelUpMaterial(MaterialConstants.G3040010, MaterialConstants.G3030001, MaterialConstants.G3090001), // todo 错误方法
    };

    public static readonly WeaponModel _2010302 = new()
    {
        Rid = 2010302,
        Vid = 11302,
        Name = "黎明神剑",
        Star = 3,
        ImagePath = "/Resources/Images/Weapon/UI_EquipIcon_Sword_Dawn.png",
        AwakenImagePath = "/Resources/Images/Weapon/UI_EquipIcon_Sword_Dawn_Awaken.png",
        WeaponType = Enumeration.WeaponType.Sword,
        SubAffix = Enumeration.Affix.CriticalDamage,
        Progression =
        {
            { 1, "生命值高于90%时，暴击率提升14%。" },
            { 2, "生命值高于90%时，暴击率提升17.5%。" },
            { 3, "生命值高于90%时，暴击率提升21%。" },
            { 4, "生命值高于90%时，暴击率提升24.5%。" },
            { 5, "生命值高于90%时，暴击率提升28%。" },
        },
        MainAffixNumberDictionary = new Dictionary<Enumeration.Level, double>()
        {
            { Enumeration.Level.L1, 39 }, { Enumeration.Level.L2, 42 }, { Enumeration.Level.L3, 45 }, { Enumeration.Level.L4, 48 }, { Enumeration.Level.L5, 50 },
            { Enumeration.Level.L6, 53 }, { Enumeration.Level.L7, 56 }, { Enumeration.Level.L8, 59 }, { Enumeration.Level.L9, 62 }, { Enumeration.Level.L10, 65 },
            { Enumeration.Level.L11, 68 }, { Enumeration.Level.L12, 71 }, { Enumeration.Level.L13, 74 }, { Enumeration.Level.L14, 77 }, { Enumeration.Level.L15, 79 },
            { Enumeration.Level.L16, 82 }, { Enumeration.Level.L17, 85 }, { Enumeration.Level.L18, 88 }, { Enumeration.Level.L19, 91 }, { Enumeration.Level.L20, 94 }, { Enumeration.Level.L20P, 113 },
            { Enumeration.Level.L21, 116 }, { Enumeration.Level.L22, 119 }, { Enumeration.Level.L23, 122 }, { Enumeration.Level.L24, 125 }, { Enumeration.Level.L25, 127 },
            { Enumeration.Level.L26, 130 }, { Enumeration.Level.L27, 133 }, { Enumeration.Level.L28, 136 }, { Enumeration.Level.L29, 139 }, { Enumeration.Level.L30, 141 },
            { Enumeration.Level.L31, 144 }, { Enumeration.Level.L32, 147 }, { Enumeration.Level.L33, 150 }, { Enumeration.Level.L34, 153 }, { Enumeration.Level.L35, 155 },
            { Enumeration.Level.L36, 158 }, { Enumeration.Level.L37, 161 }, { Enumeration.Level.L38, 164 }, { Enumeration.Level.L39, 166 }, { Enumeration.Level.L40, 169 }, { Enumeration.Level.L40P, 189 },
            { Enumeration.Level.L41, 191 }, { Enumeration.Level.L42, 194 }, { Enumeration.Level.L43, 197 }, { Enumeration.Level.L44, 200 }, { Enumeration.Level.L45, 202 },
            { Enumeration.Level.L46, 205 }, { Enumeration.Level.L47, 208 }, { Enumeration.Level.L48, 211 }, { Enumeration.Level.L49, 213 }, { Enumeration.Level.L50, 216 }, { Enumeration.Level.L50P, 236 },
            { Enumeration.Level.L51, 238 }, { Enumeration.Level.L52, 241 }, { Enumeration.Level.L53, 244 }, { Enumeration.Level.L54, 246 }, { Enumeration.Level.L55, 249 },
            { Enumeration.Level.L56, 252 }, { Enumeration.Level.L57, 255 }, { Enumeration.Level.L58, 257 }, { Enumeration.Level.L59, 260 }, { Enumeration.Level.L60, 263 }, { Enumeration.Level.L60P, 282 },
            { Enumeration.Level.L61, 285 }, { Enumeration.Level.L62, 288 }, { Enumeration.Level.L63, 290 }, { Enumeration.Level.L64, 293 }, { Enumeration.Level.L65, 296 },
            { Enumeration.Level.L66, 298 }, { Enumeration.Level.L67, 301 }, { Enumeration.Level.L68, 304 }, { Enumeration.Level.L69, 306 }, { Enumeration.Level.L70, 309 }, { Enumeration.Level.L70P, 329 },
            { Enumeration.Level.L71, 331 }, { Enumeration.Level.L72, 334 }, { Enumeration.Level.L73, 337 }, { Enumeration.Level.L74, 339 }, { Enumeration.Level.L75, 342 },
            { Enumeration.Level.L76, 345 }, { Enumeration.Level.L77, 347 }, { Enumeration.Level.L78, 350 }, { Enumeration.Level.L79, 353 }, { Enumeration.Level.L80, 355 }, { Enumeration.Level.L80P, 375 },
            { Enumeration.Level.L81, 377 }, { Enumeration.Level.L82, 380 }, { Enumeration.Level.L83, 383 }, { Enumeration.Level.L84, 385 }, { Enumeration.Level.L85, 388 },
            { Enumeration.Level.L86, 391 }, { Enumeration.Level.L87, 393 }, { Enumeration.Level.L88, 396 }, { Enumeration.Level.L89, 399 }, { Enumeration.Level.L90, 401 },
        },
        SubAffixNumberDictionary = new Dictionary<Enumeration.Level, double>()
        {
            { Enumeration.Level.L1, 10.2 }, { Enumeration.Level.L2, 10.2 }, { Enumeration.Level.L3, 10.2 }, { Enumeration.Level.L4, 10.2 }, { Enumeration.Level.L5, 11.9 },
            { Enumeration.Level.L6, 11.9 }, { Enumeration.Level.L7, 11.9 }, { Enumeration.Level.L8, 11.9 }, { Enumeration.Level.L9, 11.9 }, { Enumeration.Level.L10, 13.9 },
            { Enumeration.Level.L11, 13.9 }, { Enumeration.Level.L12, 13.9 }, { Enumeration.Level.L13, 13.9 }, { Enumeration.Level.L14, 13.9 }, { Enumeration.Level.L15, 16.0 },
            { Enumeration.Level.L16, 16.0 }, { Enumeration.Level.L17, 16.0 }, { Enumeration.Level.L18, 16.0 }, { Enumeration.Level.L19, 16.0 }, { Enumeration.Level.L20, 18.0 }, { Enumeration.Level.L20P, 18.0 },
            { Enumeration.Level.L21, 18.0 }, { Enumeration.Level.L22, 18.0 }, { Enumeration.Level.L23, 18.0 }, { Enumeration.Level.L24, 18.0 }, { Enumeration.Level.L25, 20.1 },
            { Enumeration.Level.L26, 20.1 }, { Enumeration.Level.L27, 20.1 }, { Enumeration.Level.L28, 20.1 }, { Enumeration.Level.L29, 20.1 }, { Enumeration.Level.L30, 22.1 },
            { Enumeration.Level.L31, 22.1 }, { Enumeration.Level.L32, 22.1 }, { Enumeration.Level.L33, 22.1 }, { Enumeration.Level.L34, 22.1 }, { Enumeration.Level.L35, 24.2 },
            { Enumeration.Level.L36, 24.2 }, { Enumeration.Level.L37, 24.2 }, { Enumeration.Level.L38, 24.2 }, { Enumeration.Level.L39, 24.2 }, { Enumeration.Level.L40, 26.3 }, { Enumeration.Level.L40P, 26.3 },
            { Enumeration.Level.L41, 26.3 }, { Enumeration.Level.L42, 26.3 }, { Enumeration.Level.L43, 26.3 }, { Enumeration.Level.L44, 26.3 }, { Enumeration.Level.L45, 28.3 },
            { Enumeration.Level.L46, 28.3 }, { Enumeration.Level.L47, 28.3 }, { Enumeration.Level.L48, 28.3 }, { Enumeration.Level.L49, 28.3 }, { Enumeration.Level.L50, 30.4 }, { Enumeration.Level.L50P, 30.4 },
            { Enumeration.Level.L51, 30.4 }, { Enumeration.Level.L52, 30.4 }, { Enumeration.Level.L53, 30.4 }, { Enumeration.Level.L54, 30.4 }, { Enumeration.Level.L55, 32.4 },
            { Enumeration.Level.L56, 32.4 }, { Enumeration.Level.L57, 32.4 }, { Enumeration.Level.L58, 32.4 }, { Enumeration.Level.L59, 32.4 }, { Enumeration.Level.L60, 34.5 }, { Enumeration.Level.L60P, 34.5 },
            { Enumeration.Level.L61, 34.5 }, { Enumeration.Level.L62, 34.5 }, { Enumeration.Level.L63, 34.5 }, { Enumeration.Level.L64, 34.5 }, { Enumeration.Level.L65, 36.6 },
            { Enumeration.Level.L66, 36.6 }, { Enumeration.Level.L67, 36.6 }, { Enumeration.Level.L68, 36.6 }, { Enumeration.Level.L69, 36.6 }, { Enumeration.Level.L70, 38.6 }, { Enumeration.Level.L70P, 38.6 },
            { Enumeration.Level.L71, 38.6 }, { Enumeration.Level.L72, 38.6 }, { Enumeration.Level.L73, 38.6 }, { Enumeration.Level.L74, 38.6 }, { Enumeration.Level.L75, 40.7 },
            { Enumeration.Level.L76, 40.7 }, { Enumeration.Level.L77, 40.7 }, { Enumeration.Level.L78, 40.7 }, { Enumeration.Level.L79, 40.7 }, { Enumeration.Level.L80, 42.7 }, { Enumeration.Level.L80P, 42.7 },
            { Enumeration.Level.L81, 42.7 }, { Enumeration.Level.L82, 42.7 }, { Enumeration.Level.L83, 42.7 }, { Enumeration.Level.L84, 42.7 }, { Enumeration.Level.L85, 44.8 },
            { Enumeration.Level.L86, 44.8 }, { Enumeration.Level.L87, 44.8 }, { Enumeration.Level.L88, 44.8 }, { Enumeration.Level.L89, 44.8 }, { Enumeration.Level.L90, 46.9 },
        },
        LevelUpMaterials = WeaponLevelUpConstants.GetWeapon3LevelUpMaterial(MaterialConstants.G3030004, MaterialConstants.G3040001, MaterialConstants.G3090005),
    };

    // 20104 - 单手剑4星
    // 20105 - 单手剑5星
    public static readonly WeaponModel _2010515 = new()
    {
        Rid = 2010515,
        Vid = 11518,
        Name = "黑蚀",
        Star = 5,
        ImagePath = "/Resources/Images/Weapon/UI_EquipIcon_Sword_Motsognir.png",
        AwakenImagePath = "/Resources/Images/Weapon/UI_EquipIcon_Sword_Motsognir_Awaken.png",
        WeaponType = Enumeration.WeaponType.Sword,
        SubAffix = Enumeration.Affix.CriticalRate,
        Progression =
        {
            { 1, "元素爆发造成的暴击伤害提升16%；元素爆发命中敌人时，将获得「白昼之刃」效果：攻击力提升20%，除装备者以外，队伍中附近的当前场上角色攻击力提升16%，持续3秒。此外，队伍拥有「魔导·秘仪」效果时，「白昼之刃」的效果额外提升75%。装备者处于队伍后台时，依然能触发上述效果。" },
            { 2, "元素爆发造成的暴击伤害提升20%；元素爆发命中敌人时，将获得「白昼之刃」效果：攻击力提升25%，除装备者以外，队伍中附近的当前场上角色攻击力提升20%，持续3秒。此外，队伍拥有「魔导·秘仪」效果时，「白昼之刃」的效果额外提升75%。装备者处于队伍后台时，依然能触发上述效果。" },
            { 3, "元素爆发造成的暴击伤害提升24%；元素爆发命中敌人时，将获得「白昼之刃」效果：攻击力提升30%，除装备者以外，队伍中附近的当前场上角色攻击力提升24%，持续3秒。此外，队伍拥有「魔导·秘仪」效果时，「白昼之刃」的效果额外提升75%。装备者处于队伍后台时，依然能触发上述效果。" },
            { 4, "元素爆发造成的暴击伤害提升28%；元素爆发命中敌人时，将获得「白昼之刃」效果：攻击力提升35%，除装备者以外，队伍中附近的当前场上角色攻击力提升28%，持续3秒。此外，队伍拥有「魔导·秘仪」效果时，「白昼之刃」的效果额外提升75%。装备者处于队伍后台时，依然能触发上述效果。" },
            { 5, "元素爆发造成的暴击伤害提升32%；元素爆发命中敌人时，将获得「白昼之刃」效果：攻击力提升40%，除装备者以外，队伍中附近的当前场上角色攻击力提升32%，持续3秒。此外，队伍拥有「魔导·秘仪」效果时，「白昼之刃」的效果额外提升75%。装备者处于队伍后台时，依然能触发上述效果。" },
        },
        MainAffixNumberDictionary = new Dictionary<Enumeration.Level, double>()
        {
            { Enumeration.Level.L1, 46 }, { Enumeration.Level.L2, 50 }, { Enumeration.Level.L3, 54 }, { Enumeration.Level.L4, 58 }, { Enumeration.Level.L5, 62 },
            { Enumeration.Level.L6, 66 }, { Enumeration.Level.L7, 70 }, { Enumeration.Level.L8, 74 }, { Enumeration.Level.L9, 78 }, { Enumeration.Level.L10, 82 },
            { Enumeration.Level.L11, 86 }, { Enumeration.Level.L12, 90 }, { Enumeration.Level.L13, 94 }, { Enumeration.Level.L14, 98 }, { Enumeration.Level.L15, 102 },
            { Enumeration.Level.L16, 106 }, { Enumeration.Level.L17, 110 }, { Enumeration.Level.L18, 114 }, { Enumeration.Level.L19, 118 }, { Enumeration.Level.L20, 122 }, { Enumeration.Level.L20P, 153 },
            { Enumeration.Level.L21, 157 }, { Enumeration.Level.L22, 161 }, { Enumeration.Level.L23, 165 }, { Enumeration.Level.L24, 169 }, { Enumeration.Level.L25, 173 },
            { Enumeration.Level.L26, 177 }, { Enumeration.Level.L27, 181 }, { Enumeration.Level.L28, 185 }, { Enumeration.Level.L29, 190 }, { Enumeration.Level.L30, 194 },
            { Enumeration.Level.L31, 198 }, { Enumeration.Level.L32, 202 }, { Enumeration.Level.L33, 206 }, { Enumeration.Level.L34, 210 }, { Enumeration.Level.L35, 214 },
            { Enumeration.Level.L36, 219 }, { Enumeration.Level.L37, 223 }, { Enumeration.Level.L38, 227 }, { Enumeration.Level.L39, 231 }, { Enumeration.Level.L40, 235 }, { Enumeration.Level.L40P, 266 },
            { Enumeration.Level.L41, 270 }, { Enumeration.Level.L42, 275 }, { Enumeration.Level.L43, 279 }, { Enumeration.Level.L44, 283 }, { Enumeration.Level.L45, 287 },
            { Enumeration.Level.L46, 292 }, { Enumeration.Level.L47, 296 }, { Enumeration.Level.L48, 300 }, { Enumeration.Level.L49, 304 }, { Enumeration.Level.L50, 308 }, { Enumeration.Level.L50P, 340 },
            { Enumeration.Level.L51, 344 }, { Enumeration.Level.L52, 348 }, { Enumeration.Level.L53, 352 }, { Enumeration.Level.L54, 357 }, { Enumeration.Level.L55, 361 },
            { Enumeration.Level.L56, 365 }, { Enumeration.Level.L57, 370 }, { Enumeration.Level.L58, 374 }, { Enumeration.Level.L59, 378 }, { Enumeration.Level.L60, 382 }, { Enumeration.Level.L60P, 414 },
            { Enumeration.Level.L61, 418 }, { Enumeration.Level.L62, 422 }, { Enumeration.Level.L63, 427 }, { Enumeration.Level.L64, 431 }, { Enumeration.Level.L65, 435 },
            { Enumeration.Level.L66, 440 }, { Enumeration.Level.L67, 444 }, { Enumeration.Level.L68, 448 }, { Enumeration.Level.L69, 453 }, { Enumeration.Level.L70, 457 }, { Enumeration.Level.L70P, 488 },
            { Enumeration.Level.L71, 492 }, { Enumeration.Level.L72, 497 }, { Enumeration.Level.L73, 501 }, { Enumeration.Level.L74, 506 }, { Enumeration.Level.L75, 510 },
            { Enumeration.Level.L76, 515 }, { Enumeration.Level.L77, 519 }, { Enumeration.Level.L78, 523 }, { Enumeration.Level.L79, 528 }, { Enumeration.Level.L80, 532 }, { Enumeration.Level.L80P, 563 },
            { Enumeration.Level.L81, 568 }, { Enumeration.Level.L82, 572 }, { Enumeration.Level.L83, 577 }, { Enumeration.Level.L84, 581 }, { Enumeration.Level.L85, 586 },
            { Enumeration.Level.L86, 590 }, { Enumeration.Level.L87, 595 }, { Enumeration.Level.L88, 599 }, { Enumeration.Level.L89, 604 }, { Enumeration.Level.L90, 608 },
        },
        SubAffixNumberDictionary = new Dictionary<Enumeration.Level, double>()
        {
            { Enumeration.Level.L1, 7.2 }, { Enumeration.Level.L2, 7.2 }, { Enumeration.Level.L3, 7.2 }, { Enumeration.Level.L4, 7.2 }, { Enumeration.Level.L5, 8.4 },
            { Enumeration.Level.L6, 8.4 }, { Enumeration.Level.L7, 8.4 }, { Enumeration.Level.L8, 8.4 }, { Enumeration.Level.L9, 8.4 }, { Enumeration.Level.L10, 9.8 },
            { Enumeration.Level.L11, 9.8 }, { Enumeration.Level.L12, 9.8 }, { Enumeration.Level.L13, 9.8 }, { Enumeration.Level.L14, 9.8 }, { Enumeration.Level.L15, 11.3 },
            { Enumeration.Level.L16, 11.3 }, { Enumeration.Level.L17, 11.3 }, { Enumeration.Level.L18, 11.3 }, { Enumeration.Level.L19, 11.3 }, { Enumeration.Level.L20, 12.7 }, { Enumeration.Level.L20P, 12.7 },
            { Enumeration.Level.L21, 12.7 }, { Enumeration.Level.L22, 12.7 }, { Enumeration.Level.L23, 12.7 }, { Enumeration.Level.L24, 12.7 }, { Enumeration.Level.L25, 14.2 },
            { Enumeration.Level.L26, 14.2 }, { Enumeration.Level.L27, 14.2 }, { Enumeration.Level.L28, 14.2 }, { Enumeration.Level.L29, 14.2 }, { Enumeration.Level.L30, 15.6 },
            { Enumeration.Level.L31, 15.6 }, { Enumeration.Level.L32, 15.6 }, { Enumeration.Level.L33, 15.6 }, { Enumeration.Level.L34, 15.6 }, { Enumeration.Level.L35, 17.1 },
            { Enumeration.Level.L36, 17.1 }, { Enumeration.Level.L37, 17.1 }, { Enumeration.Level.L38, 17.1 }, { Enumeration.Level.L39, 17.1 }, { Enumeration.Level.L40, 18.5 }, { Enumeration.Level.L40P, 18.5 },
            { Enumeration.Level.L41, 18.5 }, { Enumeration.Level.L42, 18.5 }, { Enumeration.Level.L43, 18.5 }, { Enumeration.Level.L44, 18.5 }, { Enumeration.Level.L45, 20.0 },
            { Enumeration.Level.L46, 20.0 }, { Enumeration.Level.L47, 20.0 }, { Enumeration.Level.L48, 20.0 }, { Enumeration.Level.L49, 20.0 }, { Enumeration.Level.L50, 21.4 }, { Enumeration.Level.L50P, 21.4 },
            { Enumeration.Level.L51, 21.4 }, { Enumeration.Level.L52, 21.4 }, { Enumeration.Level.L53, 21.4 }, { Enumeration.Level.L54, 21.4 }, { Enumeration.Level.L55, 22.9 },
            { Enumeration.Level.L56, 22.9 }, { Enumeration.Level.L57, 22.9 }, { Enumeration.Level.L58, 22.9 }, { Enumeration.Level.L59, 22.9 }, { Enumeration.Level.L60, 24.4 }, { Enumeration.Level.L60P, 24.4 },
            { Enumeration.Level.L61, 24.4 }, { Enumeration.Level.L62, 24.4 }, { Enumeration.Level.L63, 24.4 }, { Enumeration.Level.L64, 24.4 }, { Enumeration.Level.L65, 25.8 },
            { Enumeration.Level.L66, 25.8 }, { Enumeration.Level.L67, 25.8 }, { Enumeration.Level.L68, 25.8 }, { Enumeration.Level.L69, 25.8 }, { Enumeration.Level.L70, 27.3 }, { Enumeration.Level.L70P, 27.3 },
            { Enumeration.Level.L71, 27.3 }, { Enumeration.Level.L72, 27.3 }, { Enumeration.Level.L73, 27.3 }, { Enumeration.Level.L74, 27.3 }, { Enumeration.Level.L75, 28.7 },
            { Enumeration.Level.L76, 28.7 }, { Enumeration.Level.L77, 28.7 }, { Enumeration.Level.L78, 28.7 }, { Enumeration.Level.L79, 28.7 }, { Enumeration.Level.L80, 30.2 }, { Enumeration.Level.L80P, 30.2 },
            { Enumeration.Level.L81, 30.2 }, { Enumeration.Level.L82, 30.2 }, { Enumeration.Level.L83, 30.2 }, { Enumeration.Level.L84, 30.2 }, { Enumeration.Level.L85, 31.6 },
            { Enumeration.Level.L86, 31.6 }, { Enumeration.Level.L87, 31.6 }, { Enumeration.Level.L88, 31.6 }, { Enumeration.Level.L89, 31.6 }, { Enumeration.Level.L90, 33.1 },
        },
        LevelUpMaterials = WeaponLevelUpConstants.GetWeapon5LevelUpMaterial(MaterialConstants.G3040046, MaterialConstants.G3030076, MaterialConstants.G3090001),
    };


    // 202 - 双手剑
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
    // 20204 - 双手剑4星
    // 20205 - 双手剑5星

    // 203 - 长柄武器
    // 20301 - 长柄武器1星
    public static readonly WeaponModel _2030101 = new()
    {
        Rid = 2030101,
        Vid = 13101,
        Name = "新手长枪",
        Star = 1,
        ImagePath = "/Resources/Images/Weapon/UI_EquipIcon_Pole_Gewalt.png",
        AwakenImagePath = "/Resources/Images/Weapon/UI_EquipIcon_Pole_Gewalt_Awaken.png",
        WeaponType = Enumeration.WeaponType.Pole,
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
        LevelUpMaterials = WeaponLevelUpConstants.GetWeapon1LevelUpMaterial(MaterialConstants.G3040007, MaterialConstants.G3030007, MaterialConstants.G3090009),
    };

    // 20302 - 长柄武器2星
    public static readonly WeaponModel _2030201 = new()
    {
        Rid = 2030201,
        Vid = 13201,
        Name = "铁尖枪",
        Star = 2,
        ImagePath = "/Resources/Images/Weapon/UI_EquipIcon_Pole_Rod.png",
        AwakenImagePath = "/Resources/Images/Weapon/UI_EquipIcon_Pole_Rod_Awaken.png",
        WeaponType = Enumeration.WeaponType.Pole,
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
        LevelUpMaterials = WeaponLevelUpConstants.GetWeapon2LevelUpMaterial(MaterialConstants.G3040007, MaterialConstants.G3030007, MaterialConstants.G3090009),
    };
    // 20303 - 长柄武器3星
    // 20304 - 长柄武器4星
    // 20305 - 长柄武器5星

    // 204 - 法器
    // 20401 - 法器1星
    public static readonly WeaponModel _2040101 = new()
    {
        Rid = 2040101,
        Vid = 14101,
        Name = "学徒笔记",
        Star = 1,
        ImagePath = "/Resources/Images/Weapon/UI_EquipIcon_Catalyst_Apprentice.png",
        AwakenImagePath = "/Resources/Images/Weapon/UI_EquipIcon_Catalyst_Apprentice_Awaken.png",
        WeaponType = Enumeration.WeaponType.Catalyst,
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
        LevelUpMaterials = WeaponLevelUpConstants.GetWeapon1LevelUpMaterial(MaterialConstants.G3040004, MaterialConstants.G3030001, MaterialConstants.G3090001),
    };

    // 20402 - 法器2星
    public static readonly WeaponModel _2040201 = new()
    {
        Rid = 2040201,
        Vid = 14201,
        Name = "口袋魔导书",
        Star = 2,
        ImagePath = "/Resources/Images/Weapon/UI_EquipIcon_Catalyst_Pocket.png",
        AwakenImagePath = "/Resources/Images/Weapon/UI_EquipIcon_Catalyst_Pocket_Awaken.png",
        WeaponType = Enumeration.WeaponType.Catalyst,
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
        LevelUpMaterials = WeaponLevelUpConstants.GetWeapon2LevelUpMaterial(MaterialConstants.G3040004, MaterialConstants.G3030001, MaterialConstants.G3090001),
    };
    // 20403 - 法器3星
    // 20404 - 法器4星
    // 20405 - 法器5星

    // 205 - 弓
    // 20501 - 弓1星
    public static readonly WeaponModel _2050101 = new()
    {
        Rid = 2050101,
        Vid = 15101,
        Name = "猎弓",
        Star = 1,
        ImagePath = "/Resources/Images/Weapon/UI_EquipIcon_Bow_Hunters.png",
        AwakenImagePath = "/Resources/Images/Weapon/UI_EquipIcon_Bow_Hunters_Awaken.png",
        WeaponType = Enumeration.WeaponType.Bow,
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
        LevelUpMaterials = WeaponLevelUpConstants.GetWeapon1LevelUpMaterial(MaterialConstants.G3040016, MaterialConstants.G3030004, MaterialConstants.G3090005),
    };

    // 20502 - 弓2星
    public static readonly WeaponModel _2050201 = new()
    {
        Rid = 2050201,
        Vid = 15201,
        Name = "历练的猎弓",
        Star = 2,
        ImagePath = "/Resources/Images/Weapon/UI_EquipIcon_Bow_Old.png",
        AwakenImagePath = "/Resources/Images/Weapon/UI_EquipIcon_Bow_Old_Awaken.png",
        WeaponType = Enumeration.WeaponType.Bow,
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
        LevelUpMaterials = WeaponLevelUpConstants.GetWeapon2LevelUpMaterial(MaterialConstants.G3040016, MaterialConstants.G3030004, MaterialConstants.G3090005),
    };
    // 20503 - 弓3星
    // 20504 - 弓4星
    // 20505 - 弓5星
}