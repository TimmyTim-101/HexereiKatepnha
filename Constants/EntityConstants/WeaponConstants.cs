using System.Windows.Media.Media3D;
using HexereiKatepnha.Models.EntityModels;

namespace HexereiKatepnha.Constants.EntityConstants;

public static class WeaponConstants
{
    public static readonly WeaponModel _9999999 = new()
    {
        Rid = 9999999,
        Vid = 9999999,
        Name = "白雨心弦",
        Star = 5,
        ImagePath = "/Resources/Images/Materials/UI_ItemIcon_202.png",
        WeaponType = Enumeration.WeaponType.Bow,
        SubAffix = Enumeration.Affix.HealthPercent,
        Progression =
        {
            { 1, "装备者能获得「疗护」效果，持有1/2/3层疗护时，生命值上限提升12%/24%/40%。在下列情况下，装备者将各获得1层疗护：施放元素战技时，持续25秒；生命之契的数值增加时，持续25秒；进行治疗时，持续20秒，装备者处于队伍后台时依然能触发。每层疗护的持续时间独立计算。此外，处于3层疗护状态下时，元素爆发的暴击率提升28%，该效果将在疗护不足3层4秒后移除。" },
            { 2, "装备者能获得「疗护」效果，持有1/2/3层疗护时，生命值上限提升15%/30%/50%。在下列情况下，装备者将各获得1层疗护：施放元素战技时，持续25秒；生命之契的数值增加时，持续25秒；进行治疗时，持续20秒，装备者处于队伍后台时依然能触发。每层疗护的持续时间独立计算。此外，处于3层疗护状态下时，元素爆发的暴击率提升35%，该效果将在疗护不足3层4秒后移除。" },
            { 3, "装备者能获得「疗护」效果，持有1/2/3层疗护时，生命值上限提升18%/36%/60%。在下列情况下，装备者将各获得1层疗护：施放元素战技时，持续25秒；生命之契的数值增加时，持续25秒；进行治疗时，持续20秒，装备者处于队伍后台时依然能触发。每层疗护的持续时间独立计算。此外，处于3层疗护状态下时，元素爆发的暴击率提升42%，该效果将在疗护不足3层4秒后移除。" },
            { 4, "装备者能获得「疗护」效果，持有1/2/3层疗护时，生命值上限提升21%/42%/70%。在下列情况下，装备者将各获得1层疗护：施放元素战技时，持续25秒；生命之契的数值增加时，持续25秒；进行治疗时，持续20秒，装备者处于队伍后台时依然能触发。每层疗护的持续时间独立计算。此外，处于3层疗护状态下时，元素爆发的暴击率提升49%，该效果将在疗护不足3层4秒后移除。" },
            { 5, "装备者能获得「疗护」效果，持有1/2/3层疗护时，生命值上限提升24%/48%/80%。在下列情况下，装备者将各获得1层疗护：施放元素战技时，持续25秒；生命之契的数值增加时，持续25秒；进行治疗时，持续20秒，装备者处于队伍后台时依然能触发。每层疗护的持续时间独立计算。此外，处于3层疗护状态下时，元素爆发的暴击率提升56%，该效果将在疗护不足3层4秒后移除。" },
        },
        MainAffixNumberDictionary =
        {
            { Enumeration.Level.L1, 44 },
            { Enumeration.Level.L5, 58 },
            { Enumeration.Level.L10, 76 },
            { Enumeration.Level.L15, 93 },
            { Enumeration.Level.L20, 110 },
            { Enumeration.Level.L20P, 141 },
            { Enumeration.Level.L25, 158 },
            { Enumeration.Level.L30, 176 },
            { Enumeration.Level.L35, 193 },
            { Enumeration.Level.L40, 210 },
            { Enumeration.Level.L40P, 241 },
            { Enumeration.Level.L45, 258 },
            { Enumeration.Level.L50, 275 },
            { Enumeration.Level.L50P, 307 },
            { Enumeration.Level.L55, 324 },
        },
        SubAffixNumberDictionary =
        {
            { Enumeration.Level.L1, 14.4 },
            { Enumeration.Level.L5, 16.7 },
            { Enumeration.Level.L10, 19.6 },
            { Enumeration.Level.L15, 22.5 },
            { Enumeration.Level.L20, 25.4 },
            { Enumeration.Level.L20P, 25.4 },
            { Enumeration.Level.L25, 28.4 },
            { Enumeration.Level.L30, 31.3 },
            { Enumeration.Level.L35, 34.2 },
            { Enumeration.Level.L40, 37.1 },
            { Enumeration.Level.L40P, 37.1 },
            { Enumeration.Level.L45, 40.0 },
            { Enumeration.Level.L50, 42.9 },
            { Enumeration.Level.L50P, 42.9 },
            { Enumeration.Level.L55, 45.8 },
        },
        LevelUpMaterials =
        {
            { Enumeration.Level.L1, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 600 }] },
            { Enumeration.Level.L2, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 1600 }] },
            { Enumeration.Level.L3, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 2600 }] },
            { Enumeration.Level.L4, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 3600 }] },
            { Enumeration.Level.L5, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 4600 }] },
            { Enumeration.Level.L6, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 5600 }] },
            { Enumeration.Level.L7, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 5600 }] },
            { Enumeration.Level.L8, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 5600 }] },
            { Enumeration.Level.L9, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 5600 }] },
            { Enumeration.Level.L10, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 5600 }] },
            { Enumeration.Level.L11, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 5600 }] },
            { Enumeration.Level.L12, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 5600 }] },
        },
    };
}