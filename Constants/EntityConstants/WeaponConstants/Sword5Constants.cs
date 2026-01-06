using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.EntityModels;

namespace HexereiKatepnha.Constants.EntityConstants.WeaponConstants;

public static class Sword5Constants
{
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
}