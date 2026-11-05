using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Constants.EntityConstants.MaterialConstants;
using HexereiKatepnha.Models.EntityModels;

namespace HexereiKatepnha.Constants.EntityConstants.CharacterConstants;

public class CharacterConstantsPage13
{
    public static CharacterModel _1010121 = new()
    {
        Rid = 1010121,
        Vid = 10000136,
        Name = "米提亚",
        GoodKey = "Mitya",
        Star = 5,
        ImagePath = "/Resources/Images/Character/UI_AvatarIcon_Mitya.png",
        ElementType = Enumeration.ElementType.Electro,
        WeaponType = Enumeration.WeaponType.Catalyst,
        BirthMonth = 2,
        BirthDay = 8,
        Talent = new Dictionary<int, ImageDescriptionPairModel>()
        {
            { 1, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/Skill_A_Catalyst_MD.png", Description = "链式反应" } },
            { 2, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/Skill_S_Mitya_01.png", Description = "律定·变量侦测" } },
            { 3, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/Skill_E_Mitya_01_HD.png", Description = "解析·递变之理" } },
        },
        Constellation = new Dictionary<int, ImageDescriptionPairModel>()
        {
            { 1, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Mitya_01.png", Description = "缺位寻踪的观察者" } },
            { 2, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Mitya_02.png", Description = "惰性之外的沉寂物" } },
            { 3, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_U_Mitya_01.png", Description = "拓扑不变的扭结弦" } },
            { 4, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Mitya_03.png", Description = "衰变相生的同位素" } },
            { 5, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_U_Mitya_02.png", Description = "勘定万物的周期律" } },
            { 6, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Mitya_04.png", Description = "元素阶跃的理之门" } },
        },
        AffixDictionary = new Dictionary<Enumeration.Level, Dictionary<Enumeration.Affix, double>>()
        {
            {
                Enumeration.Level.L1,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 906 }, { Enumeration.Affix.Attack, 20 }, { Enumeration.Affix.Defense, 62 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L2,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 981 }, { Enumeration.Affix.Attack, 22 }, { Enumeration.Affix.Defense, 67 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L3,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1056 }, { Enumeration.Affix.Attack, 24 }, { Enumeration.Affix.Defense, 72 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L4,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1132 }, { Enumeration.Affix.Attack, 26 }, { Enumeration.Affix.Defense, 77 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L5,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1207 }, { Enumeration.Affix.Attack, 27 }, { Enumeration.Affix.Defense, 82 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L6,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1283 }, { Enumeration.Affix.Attack, 29 }, { Enumeration.Affix.Defense, 87 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L7,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1358 }, { Enumeration.Affix.Attack, 31 }, { Enumeration.Affix.Defense, 92 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L8,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1435 }, { Enumeration.Affix.Attack, 32 }, { Enumeration.Affix.Defense, 98 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L9,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1511 }, { Enumeration.Affix.Attack, 34 }, { Enumeration.Affix.Defense, 103 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L10,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1586 }, { Enumeration.Affix.Attack, 36 }, { Enumeration.Affix.Defense, 108 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L11,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1662 }, { Enumeration.Affix.Attack, 38 }, { Enumeration.Affix.Defense, 113 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L12,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1738 }, { Enumeration.Affix.Attack, 39 }, { Enumeration.Affix.Defense, 118 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L13,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1814 }, { Enumeration.Affix.Attack, 41 }, { Enumeration.Affix.Defense, 123 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L14,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1891 }, { Enumeration.Affix.Attack, 43 }, { Enumeration.Affix.Defense, 129 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L15,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1967 }, { Enumeration.Affix.Attack, 44 }, { Enumeration.Affix.Defense, 134 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L16,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2043 }, { Enumeration.Affix.Attack, 46 }, { Enumeration.Affix.Defense, 139 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L17,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2120 }, { Enumeration.Affix.Attack, 48 }, { Enumeration.Affix.Defense, 144 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L18,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2196 }, { Enumeration.Affix.Attack, 50 }, { Enumeration.Affix.Defense, 149 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L19,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2273 }, { Enumeration.Affix.Attack, 51 }, { Enumeration.Affix.Defense, 155 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L20,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2349 }, { Enumeration.Affix.Attack, 53 }, { Enumeration.Affix.Defense, 160 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L20P,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3126 }, { Enumeration.Affix.Attack, 71 }, { Enumeration.Affix.Defense, 213 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L21,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3203 }, { Enumeration.Affix.Attack, 72 }, { Enumeration.Affix.Defense, 218 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L22,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3280 }, { Enumeration.Affix.Attack, 74 }, { Enumeration.Affix.Defense, 223 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L23,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3357 }, { Enumeration.Affix.Attack, 76 }, { Enumeration.Affix.Defense, 228 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L24,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3434 }, { Enumeration.Affix.Attack, 78 }, { Enumeration.Affix.Defense, 234 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L25,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3511 }, { Enumeration.Affix.Attack, 79 }, { Enumeration.Affix.Defense, 239 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L26,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3589 }, { Enumeration.Affix.Attack, 81 }, { Enumeration.Affix.Defense, 244 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L27,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3666 }, { Enumeration.Affix.Attack, 83 }, { Enumeration.Affix.Defense, 249 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L28,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3743 }, { Enumeration.Affix.Attack, 85 }, { Enumeration.Affix.Defense, 255 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L29,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3820 }, { Enumeration.Affix.Attack, 86 }, { Enumeration.Affix.Defense, 260 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L30,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3897 }, { Enumeration.Affix.Attack, 88 }, { Enumeration.Affix.Defense, 265 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L31,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3975 }, { Enumeration.Affix.Attack, 90 }, { Enumeration.Affix.Defense, 270 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L32,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4053 }, { Enumeration.Affix.Attack, 92 }, { Enumeration.Affix.Defense, 276 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L33,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4131 }, { Enumeration.Affix.Attack, 93 }, { Enumeration.Affix.Defense, 281 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L34,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4208 }, { Enumeration.Affix.Attack, 95 }, { Enumeration.Affix.Defense, 286 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L35,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4286 }, { Enumeration.Affix.Attack, 97 }, { Enumeration.Affix.Defense, 292 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L36,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4365 }, { Enumeration.Affix.Attack, 99 }, { Enumeration.Affix.Defense, 297 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L37,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4443 }, { Enumeration.Affix.Attack, 100 }, { Enumeration.Affix.Defense, 302 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L38,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4520 }, { Enumeration.Affix.Attack, 102 }, { Enumeration.Affix.Defense, 308 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L39,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4598 }, { Enumeration.Affix.Attack, 104 }, { Enumeration.Affix.Defense, 313 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L40,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4677 }, { Enumeration.Affix.Attack, 106 }, { Enumeration.Affix.Defense, 318 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L40P,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5229 }, { Enumeration.Affix.Attack, 118 }, { Enumeration.Affix.Defense, 356 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L41,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5307 }, { Enumeration.Affix.Attack, 120 }, { Enumeration.Affix.Defense, 361 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L42,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5386 }, { Enumeration.Affix.Attack, 122 }, { Enumeration.Affix.Defense, 366 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L43,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5464 }, { Enumeration.Affix.Attack, 124 }, { Enumeration.Affix.Defense, 372 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L44,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5542 }, { Enumeration.Affix.Attack, 125 }, { Enumeration.Affix.Defense, 377 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L45,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5621 }, { Enumeration.Affix.Attack, 127 }, { Enumeration.Affix.Defense, 382 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L46,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5700 }, { Enumeration.Affix.Attack, 129 }, { Enumeration.Affix.Defense, 388 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L47,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5779 }, { Enumeration.Affix.Attack, 131 }, { Enumeration.Affix.Defense, 393 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L48,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5857 }, { Enumeration.Affix.Attack, 132 }, { Enumeration.Affix.Defense, 399 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L49,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5937 }, { Enumeration.Affix.Attack, 134 }, { Enumeration.Affix.Defense, 404 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L50,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6016 }, { Enumeration.Affix.Attack, 136 }, { Enumeration.Affix.Defense, 409 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L50P,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6752 }, { Enumeration.Affix.Attack, 153 }, { Enumeration.Affix.Defense, 459 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L51,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6830 }, { Enumeration.Affix.Attack, 154 }, { Enumeration.Affix.Defense, 465 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L52,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6910 }, { Enumeration.Affix.Attack, 156 }, { Enumeration.Affix.Defense, 470 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L53,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6989 }, { Enumeration.Affix.Attack, 158 }, { Enumeration.Affix.Defense, 476 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L54,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7069 }, { Enumeration.Affix.Attack, 160 }, { Enumeration.Affix.Defense, 481 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L55,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7148 }, { Enumeration.Affix.Attack, 162 }, { Enumeration.Affix.Defense, 486 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L56,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7228 }, { Enumeration.Affix.Attack, 163 }, { Enumeration.Affix.Defense, 492 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L57,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7308 }, { Enumeration.Affix.Attack, 165 }, { Enumeration.Affix.Defense, 497 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L58,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7387 }, { Enumeration.Affix.Attack, 167 }, { Enumeration.Affix.Defense, 503 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L59,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7467 }, { Enumeration.Affix.Attack, 169 }, { Enumeration.Affix.Defense, 508 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L60,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7547 }, { Enumeration.Affix.Attack, 171 }, { Enumeration.Affix.Defense, 514 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L60P,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8098 }, { Enumeration.Affix.Attack, 183 }, { Enumeration.Affix.Defense, 551 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L61,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8178 }, { Enumeration.Affix.Attack, 185 }, { Enumeration.Affix.Defense, 556 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L62,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8258 }, { Enumeration.Affix.Attack, 187 }, { Enumeration.Affix.Defense, 562 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L63,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8338 }, { Enumeration.Affix.Attack, 189 }, { Enumeration.Affix.Defense, 567 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L64,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8418 }, { Enumeration.Affix.Attack, 190 }, { Enumeration.Affix.Defense, 573 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L65,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8499 }, { Enumeration.Affix.Attack, 192 }, { Enumeration.Affix.Defense, 578 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L66,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8579 }, { Enumeration.Affix.Attack, 194 }, { Enumeration.Affix.Defense, 584 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L67,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8659 }, { Enumeration.Affix.Attack, 196 }, { Enumeration.Affix.Defense, 589 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L68,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8740 }, { Enumeration.Affix.Attack, 198 }, { Enumeration.Affix.Defense, 595 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L69,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8820 }, { Enumeration.Affix.Attack, 199 }, { Enumeration.Affix.Defense, 600 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L70,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8901 }, { Enumeration.Affix.Attack, 201 }, { Enumeration.Affix.Defense, 606 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L70P,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9453 }, { Enumeration.Affix.Attack, 214 }, { Enumeration.Affix.Defense, 643 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L71,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9533 }, { Enumeration.Affix.Attack, 216 }, { Enumeration.Affix.Defense, 649 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L72,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9615 }, { Enumeration.Affix.Attack, 217 }, { Enumeration.Affix.Defense, 654 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L73,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9695 }, { Enumeration.Affix.Attack, 219 }, { Enumeration.Affix.Defense, 660 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L74,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9776 }, { Enumeration.Affix.Attack, 221 }, { Enumeration.Affix.Defense, 665 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L75,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9857 }, { Enumeration.Affix.Attack, 223 }, { Enumeration.Affix.Defense, 671 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L76,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9938 }, { Enumeration.Affix.Attack, 225 }, { Enumeration.Affix.Defense, 676 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L77,
                new Dictionary<Enumeration.Affix, double>()
                    { { Enumeration.Affix.Health, 10020 }, { Enumeration.Affix.Attack, 227 }, { Enumeration.Affix.Defense, 682 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L78,
                new Dictionary<Enumeration.Affix, double>()
                    { { Enumeration.Affix.Health, 10101 }, { Enumeration.Affix.Attack, 228 }, { Enumeration.Affix.Defense, 687 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L79,
                new Dictionary<Enumeration.Affix, double>()
                    { { Enumeration.Affix.Health, 10183 }, { Enumeration.Affix.Attack, 230 }, { Enumeration.Affix.Defense, 693 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L80,
                new Dictionary<Enumeration.Affix, double>()
                    { { Enumeration.Affix.Health, 10264 }, { Enumeration.Affix.Attack, 232 }, { Enumeration.Affix.Defense, 698 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L80P,
                new Dictionary<Enumeration.Affix, double>()
                    { { Enumeration.Affix.Health, 10816 }, { Enumeration.Affix.Attack, 245 }, { Enumeration.Affix.Defense, 736 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L81,
                new Dictionary<Enumeration.Affix, double>()
                    { { Enumeration.Affix.Health, 10897 }, { Enumeration.Affix.Attack, 246 }, { Enumeration.Affix.Defense, 742 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L82,
                new Dictionary<Enumeration.Affix, double>()
                    { { Enumeration.Affix.Health, 10979 }, { Enumeration.Affix.Attack, 248 }, { Enumeration.Affix.Defense, 747 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L83,
                new Dictionary<Enumeration.Affix, double>()
                    { { Enumeration.Affix.Health, 11060 }, { Enumeration.Affix.Attack, 250 }, { Enumeration.Affix.Defense, 753 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L84,
                new Dictionary<Enumeration.Affix, double>()
                    { { Enumeration.Affix.Health, 11142 }, { Enumeration.Affix.Attack, 252 }, { Enumeration.Affix.Defense, 758 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L85,
                new Dictionary<Enumeration.Affix, double>()
                    { { Enumeration.Affix.Health, 11223 }, { Enumeration.Affix.Attack, 254 }, { Enumeration.Affix.Defense, 764 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L86,
                new Dictionary<Enumeration.Affix, double>()
                    { { Enumeration.Affix.Health, 11306 }, { Enumeration.Affix.Attack, 256 }, { Enumeration.Affix.Defense, 769 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L87,
                new Dictionary<Enumeration.Affix, double>()
                    { { Enumeration.Affix.Health, 11387 }, { Enumeration.Affix.Attack, 258 }, { Enumeration.Affix.Defense, 775 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L88,
                new Dictionary<Enumeration.Affix, double>()
                    { { Enumeration.Affix.Health, 11470 }, { Enumeration.Affix.Attack, 259 }, { Enumeration.Affix.Defense, 780 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L89,
                new Dictionary<Enumeration.Affix, double>()
                    { { Enumeration.Affix.Health, 11552 }, { Enumeration.Affix.Attack, 261 }, { Enumeration.Affix.Defense, 786 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L90,
                new Dictionary<Enumeration.Affix, double>()
                    { { Enumeration.Affix.Health, 11634 }, { Enumeration.Affix.Attack, 263 }, { Enumeration.Affix.Defense, 792 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L95,
                new Dictionary<Enumeration.Affix, double>()
                    { { Enumeration.Affix.Health, 12047 }, { Enumeration.Affix.Attack, 293 }, { Enumeration.Affix.Defense, 820 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L100,
                new Dictionary<Enumeration.Affix, double>()
                    { { Enumeration.Affix.Health, 12460 }, { Enumeration.Affix.Attack, 322 }, { Enumeration.Affix.Defense, 848 }, { Enumeration.Affix.ElementalMastery, 100 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
        },
        LevelUpMaterials = CharacterLevelUpConstants.GetCharacterLevelUpMaterial(MaterialConstants10._3100805, MaterialConstants06._3060049, MaterialConstants07.G3070501, MaterialConstants04.G3040055),
        Talent1Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants05._3050038, MaterialConstants04.G3040055, MaterialConstants08.G3080064),
        Talent2Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants05._3050038, MaterialConstants04.G3040055, MaterialConstants08.G3080064),
        Talent3Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants05._3050038, MaterialConstants04.G3040055, MaterialConstants08.G3080064),
    };


    public static CharacterModel _1010122 = new()
    {
        Rid = 1010122,
        Vid = 10000137,
        Name = "瓦列里",
        GoodKey = "Valeriy",
        Star = 4,
        ImagePath = "/Resources/Images/Character/UI_AvatarIcon_Valeriy.png",
        ElementType = Enumeration.ElementType.Electro,
        WeaponType = Enumeration.WeaponType.Sword,
        BirthMonth = 3,
        BirthDay = 24,
        Talent = new Dictionary<int, ImageDescriptionPairModel>()
        {
            { 1, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/Skill_A_01.png", Description = "近卫战法·盾剑攻斥" } },
            { 2, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/Skill_S_Valeriy_01.png", Description = "攻势防御·堡垒骤进" } },
            { 3, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/Skill_E_Valeriy_01_HD.png", Description = "火力焦点·雷霰急袭" } },
        },
        Constellation = new Dictionary<int, ImageDescriptionPairModel>()
        {
            { 1, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Valeriy_01.png", Description = "持续压制的时序" } },
            { 2, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Valeriy_02.png", Description = "伴随冲阵的队型" } },
            { 3, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_U_Valeriy_01.png", Description = "白刃对决的戒备" } },
            { 4, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Valeriy_03.png", Description = "不惧折损的韧性" } },
            { 5, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_U_Valeriy_02.png", Description = "分割歼灭的专意" } },
            { 6, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Valeriy_04.png", Description = "穿透敌阵的威能" } },
        },
        AffixDictionary = new Dictionary<Enumeration.Level, Dictionary<Enumeration.Affix, double>>()
        {
            {
                Enumeration.Level.L1,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 839 }, { Enumeration.Affix.Attack, 21 }, { Enumeration.Affix.Defense, 59 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L2,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 908 }, { Enumeration.Affix.Attack, 23 }, { Enumeration.Affix.Defense, 64 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L3,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 977 }, { Enumeration.Affix.Attack, 25 }, { Enumeration.Affix.Defense, 69 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L4,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1047 }, { Enumeration.Affix.Attack, 27 }, { Enumeration.Affix.Defense, 74 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L5,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1116 }, { Enumeration.Affix.Attack, 28 }, { Enumeration.Affix.Defense, 78 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L6,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1185 }, { Enumeration.Affix.Attack, 30 }, { Enumeration.Affix.Defense, 83 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L7,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1254 }, { Enumeration.Affix.Attack, 32 }, { Enumeration.Affix.Defense, 88 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L8,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1324 }, { Enumeration.Affix.Attack, 34 }, { Enumeration.Affix.Defense, 93 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L9,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1393 }, { Enumeration.Affix.Attack, 35 }, { Enumeration.Affix.Defense, 98 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L10,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1462 }, { Enumeration.Affix.Attack, 37 }, { Enumeration.Affix.Defense, 103 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L11,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1532 }, { Enumeration.Affix.Attack, 39 }, { Enumeration.Affix.Defense, 108 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L12,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1601 }, { Enumeration.Affix.Attack, 41 }, { Enumeration.Affix.Defense, 112 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L13,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1670 }, { Enumeration.Affix.Attack, 43 }, { Enumeration.Affix.Defense, 117 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L14,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1739 }, { Enumeration.Affix.Attack, 44 }, { Enumeration.Affix.Defense, 122 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L15,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1809 }, { Enumeration.Affix.Attack, 46 }, { Enumeration.Affix.Defense, 127 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L16,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1878 }, { Enumeration.Affix.Attack, 48 }, { Enumeration.Affix.Defense, 132 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L17,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1947 }, { Enumeration.Affix.Attack, 50 }, { Enumeration.Affix.Defense, 137 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L18,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2017 }, { Enumeration.Affix.Attack, 51 }, { Enumeration.Affix.Defense, 142 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L19,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2085 }, { Enumeration.Affix.Attack, 53 }, { Enumeration.Affix.Defense, 147 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L20,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2155 }, { Enumeration.Affix.Attack, 55 }, { Enumeration.Affix.Defense, 151 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L20P,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2782 }, { Enumeration.Affix.Attack, 71 }, { Enumeration.Affix.Defense, 195 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L21,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2850 }, { Enumeration.Affix.Attack, 73 }, { Enumeration.Affix.Defense, 200 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L22,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2920 }, { Enumeration.Affix.Attack, 74 }, { Enumeration.Affix.Defense, 205 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L23,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2990 }, { Enumeration.Affix.Attack, 76 }, { Enumeration.Affix.Defense, 210 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L24,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3058 }, { Enumeration.Affix.Attack, 78 }, { Enumeration.Affix.Defense, 215 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L25,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3128 }, { Enumeration.Affix.Attack, 80 }, { Enumeration.Affix.Defense, 220 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L26,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3197 }, { Enumeration.Affix.Attack, 81 }, { Enumeration.Affix.Defense, 225 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L27,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3267 }, { Enumeration.Affix.Attack, 83 }, { Enumeration.Affix.Defense, 230 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L28,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3335 }, { Enumeration.Affix.Attack, 85 }, { Enumeration.Affix.Defense, 234 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L29,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3405 }, { Enumeration.Affix.Attack, 87 }, { Enumeration.Affix.Defense, 239 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L30,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3474 }, { Enumeration.Affix.Attack, 88 }, { Enumeration.Affix.Defense, 244 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L31,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3543 }, { Enumeration.Affix.Attack, 90 }, { Enumeration.Affix.Defense, 249 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L32,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3613 }, { Enumeration.Affix.Attack, 92 }, { Enumeration.Affix.Defense, 254 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L33,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3682 }, { Enumeration.Affix.Attack, 94 }, { Enumeration.Affix.Defense, 259 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L34,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3751 }, { Enumeration.Affix.Attack, 96 }, { Enumeration.Affix.Defense, 264 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L35,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3820 }, { Enumeration.Affix.Attack, 97 }, { Enumeration.Affix.Defense, 268 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L36,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3890 }, { Enumeration.Affix.Attack, 99 }, { Enumeration.Affix.Defense, 273 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L37,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3959 }, { Enumeration.Affix.Attack, 101 }, { Enumeration.Affix.Defense, 278 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L38,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4028 }, { Enumeration.Affix.Attack, 103 }, { Enumeration.Affix.Defense, 283 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L39,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4098 }, { Enumeration.Affix.Attack, 104 }, { Enumeration.Affix.Defense, 288 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L40,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4167 }, { Enumeration.Affix.Attack, 106 }, { Enumeration.Affix.Defense, 293 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L40P,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4612 }, { Enumeration.Affix.Attack, 117 }, { Enumeration.Affix.Defense, 324 }, { Enumeration.Affix.AttackPercent, 6.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L41,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4681 }, { Enumeration.Affix.Attack, 119 }, { Enumeration.Affix.Defense, 329 }, { Enumeration.Affix.AttackPercent, 6.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L42,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4750 }, { Enumeration.Affix.Attack, 121 }, { Enumeration.Affix.Defense, 334 }, { Enumeration.Affix.AttackPercent, 6.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L43,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4820 }, { Enumeration.Affix.Attack, 123 }, { Enumeration.Affix.Defense, 339 }, { Enumeration.Affix.AttackPercent, 6.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L44,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4889 }, { Enumeration.Affix.Attack, 125 }, { Enumeration.Affix.Defense, 344 }, { Enumeration.Affix.AttackPercent, 6.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L45,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4958 }, { Enumeration.Affix.Attack, 126 }, { Enumeration.Affix.Defense, 348 }, { Enumeration.Affix.AttackPercent, 6.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L46,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5028 }, { Enumeration.Affix.Attack, 128 }, { Enumeration.Affix.Defense, 353 }, { Enumeration.Affix.AttackPercent, 6.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L47,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5097 }, { Enumeration.Affix.Attack, 130 }, { Enumeration.Affix.Defense, 358 }, { Enumeration.Affix.AttackPercent, 6.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L48,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5166 }, { Enumeration.Affix.Attack, 132 }, { Enumeration.Affix.Defense, 363 }, { Enumeration.Affix.AttackPercent, 6.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L49,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5235 }, { Enumeration.Affix.Attack, 133 }, { Enumeration.Affix.Defense, 368 }, { Enumeration.Affix.AttackPercent, 6.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L50,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5305 }, { Enumeration.Affix.Attack, 135 }, { Enumeration.Affix.Defense, 373 }, { Enumeration.Affix.AttackPercent, 6.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L50P,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5898 }, { Enumeration.Affix.Attack, 150 }, { Enumeration.Affix.Defense, 414 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L51,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5967 }, { Enumeration.Affix.Attack, 152 }, { Enumeration.Affix.Defense, 419 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L52,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6037 }, { Enumeration.Affix.Attack, 154 }, { Enumeration.Affix.Defense, 424 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L53,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6106 }, { Enumeration.Affix.Attack, 156 }, { Enumeration.Affix.Defense, 429 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L54,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6175 }, { Enumeration.Affix.Attack, 157 }, { Enumeration.Affix.Defense, 434 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L55,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6245 }, { Enumeration.Affix.Attack, 159 }, { Enumeration.Affix.Defense, 439 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L56,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6314 }, { Enumeration.Affix.Attack, 161 }, { Enumeration.Affix.Defense, 444 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L57,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6383 }, { Enumeration.Affix.Attack, 163 }, { Enumeration.Affix.Defense, 449 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L58,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6452 }, { Enumeration.Affix.Attack, 164 }, { Enumeration.Affix.Defense, 453 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L59,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6522 }, { Enumeration.Affix.Attack, 166 }, { Enumeration.Affix.Defense, 458 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L60,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6591 }, { Enumeration.Affix.Attack, 168 }, { Enumeration.Affix.Defense, 463 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L60P,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7037 }, { Enumeration.Affix.Attack, 179 }, { Enumeration.Affix.Defense, 494 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L61,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7105 }, { Enumeration.Affix.Attack, 181 }, { Enumeration.Affix.Defense, 499 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L62,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7175 }, { Enumeration.Affix.Attack, 183 }, { Enumeration.Affix.Defense, 504 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L63,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7244 }, { Enumeration.Affix.Attack, 185 }, { Enumeration.Affix.Defense, 509 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L64,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7313 }, { Enumeration.Affix.Attack, 186 }, { Enumeration.Affix.Defense, 514 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L65,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7382 }, { Enumeration.Affix.Attack, 188 }, { Enumeration.Affix.Defense, 519 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L66,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7452 }, { Enumeration.Affix.Attack, 190 }, { Enumeration.Affix.Defense, 524 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L67,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7521 }, { Enumeration.Affix.Attack, 192 }, { Enumeration.Affix.Defense, 528 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L68,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7590 }, { Enumeration.Affix.Attack, 193 }, { Enumeration.Affix.Defense, 533 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L69,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7660 }, { Enumeration.Affix.Attack, 195 }, { Enumeration.Affix.Defense, 538 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L70,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7729 }, { Enumeration.Affix.Attack, 197 }, { Enumeration.Affix.Defense, 543 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L70P,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8174 }, { Enumeration.Affix.Attack, 208 }, { Enumeration.Affix.Defense, 574 }, { Enumeration.Affix.AttackPercent, 18.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L71,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8244 }, { Enumeration.Affix.Attack, 210 }, { Enumeration.Affix.Defense, 579 }, { Enumeration.Affix.AttackPercent, 18.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L72,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8312 }, { Enumeration.Affix.Attack, 212 }, { Enumeration.Affix.Defense, 584 }, { Enumeration.Affix.AttackPercent, 18.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L73,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8382 }, { Enumeration.Affix.Attack, 214 }, { Enumeration.Affix.Defense, 589 }, { Enumeration.Affix.AttackPercent, 18.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L74,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8452 }, { Enumeration.Affix.Attack, 215 }, { Enumeration.Affix.Defense, 594 }, { Enumeration.Affix.AttackPercent, 18.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L75,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8520 }, { Enumeration.Affix.Attack, 217 }, { Enumeration.Affix.Defense, 599 }, { Enumeration.Affix.AttackPercent, 18.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L76,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8590 }, { Enumeration.Affix.Attack, 219 }, { Enumeration.Affix.Defense, 604 }, { Enumeration.Affix.AttackPercent, 18.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L77,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8659 }, { Enumeration.Affix.Attack, 221 }, { Enumeration.Affix.Defense, 608 }, { Enumeration.Affix.AttackPercent, 18.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L78,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8728 }, { Enumeration.Affix.Attack, 222 }, { Enumeration.Affix.Defense, 613 }, { Enumeration.Affix.AttackPercent, 18.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L79,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8797 }, { Enumeration.Affix.Attack, 224 }, { Enumeration.Affix.Defense, 618 }, { Enumeration.Affix.AttackPercent, 18.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L80,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8867 }, { Enumeration.Affix.Attack, 226 }, { Enumeration.Affix.Defense, 623 }, { Enumeration.Affix.AttackPercent, 18.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L80P,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9312 }, { Enumeration.Affix.Attack, 237 }, { Enumeration.Affix.Defense, 654 }, { Enumeration.Affix.AttackPercent, 24.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L81,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9382 }, { Enumeration.Affix.Attack, 239 }, { Enumeration.Affix.Defense, 659 }, { Enumeration.Affix.AttackPercent, 24.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L82,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9450 }, { Enumeration.Affix.Attack, 241 }, { Enumeration.Affix.Defense, 664 }, { Enumeration.Affix.AttackPercent, 24.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L83,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9520 }, { Enumeration.Affix.Attack, 243 }, { Enumeration.Affix.Defense, 669 }, { Enumeration.Affix.AttackPercent, 24.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L84,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9589 }, { Enumeration.Affix.Attack, 244 }, { Enumeration.Affix.Defense, 674 }, { Enumeration.Affix.AttackPercent, 24.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L85,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9658 }, { Enumeration.Affix.Attack, 246 }, { Enumeration.Affix.Defense, 679 }, { Enumeration.Affix.AttackPercent, 24.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L86,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9727 }, { Enumeration.Affix.Attack, 248 }, { Enumeration.Affix.Defense, 683 }, { Enumeration.Affix.AttackPercent, 24.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L87,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9797 }, { Enumeration.Affix.Attack, 250 }, { Enumeration.Affix.Defense, 688 }, { Enumeration.Affix.AttackPercent, 24.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L88,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9866 }, { Enumeration.Affix.Attack, 251 }, { Enumeration.Affix.Defense, 693 }, { Enumeration.Affix.AttackPercent, 24.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L89,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9935 }, { Enumeration.Affix.Attack, 253 }, { Enumeration.Affix.Defense, 698 }, { Enumeration.Affix.AttackPercent, 24.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L90,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10005 }, { Enumeration.Affix.Attack, 255 }, { Enumeration.Affix.Defense, 703 }, { Enumeration.Affix.AttackPercent, 24.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L95,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10351 }, { Enumeration.Affix.Attack, 287 }, { Enumeration.Affix.Defense, 727 }, { Enumeration.Affix.AttackPercent, 24.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L100,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10697 }, { Enumeration.Affix.Attack, 320 }, { Enumeration.Affix.Defense, 752 }, { Enumeration.Affix.AttackPercent, 24.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
        },
        LevelUpMaterials = CharacterLevelUpConstants.GetCharacterLevelUpMaterial(MaterialConstants10._3100804, MaterialConstants06._3060047, MaterialConstants07.G3070501, MaterialConstants04.G3040052),
        Talent1Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants05._3050041, MaterialConstants04.G3040052, MaterialConstants08.G3080070),
        Talent2Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants05._3050041, MaterialConstants04.G3040052, MaterialConstants08.G3080070),
        Talent3Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants05._3050041, MaterialConstants04.G3040052, MaterialConstants08.G3080070),
    };
}