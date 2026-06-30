using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Constants.EntityConstants.MaterialConstants;
using HexereiKatepnha.Models.EntityModels;

namespace HexereiKatepnha.Constants.EntityConstants.CharacterConstants;

public static class CharacterConstantsPage12
{
    public static CharacterModel _1010111 = new()
    {
        Rid = 1010111,
        Vid = 10000128,
        Name = "法尔伽",
        GoodKey = "Varka",
        Star = 5,
        ImagePath = "/Resources/Images/Character/UI_AvatarIcon_Varka.png",
        ElementType = Enumeration.ElementType.Anemo,
        WeaponType = Enumeration.WeaponType.Claymore,
        BirthMonth = 2,
        BirthDay = 17,
        Talent = new Dictionary<int, ImageDescriptionPairModel>()
        {
            { 1, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/Skill_A_04.png", Description = "西风剑术·流光之舞" } },
            { 2, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/Skill_S_Varka_01.png", Description = "烈风终坠" } },
            { 3, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/Skill_E_Varka_01.png", Description = "我即朔风" } },
        },
        Constellation = new Dictionary<int, ImageDescriptionPairModel>()
        {
            { 1, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Varka_01.png", Description = "「来吧，朋友，让我们在月下共舞」" } },
            { 2, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Varka_02.png", Description = "「待天光破晓，我们便要踏上征途」" } },
            { 3, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_U_Varka_01.png", Description = "「朋友，莫要再饮令人落泪的苦酒」" } },
            { 4, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Varka_03.png", Description = "「因为无人能夺去我们歌唱的自由」" } },
            { 5, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_U_Varka_02.png", Description = "「斟满杯中佳酿吧，暴君来了又去」" } },
            { 6, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Varka_04.png", Description = "「我心爱的蒙德呀，依然屹立如初」" } },
        },
        AffixDictionary = new Dictionary<Enumeration.Level, Dictionary<Enumeration.Affix, double>>()
        {
            { Enumeration.Level.L1, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 982 }, { Enumeration.Affix.Attack, 27 }, { Enumeration.Affix.Defense, 62 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L2, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1063 }, { Enumeration.Affix.Attack, 30 }, { Enumeration.Affix.Defense, 67 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L3, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1145 }, { Enumeration.Affix.Attack, 32 }, { Enumeration.Affix.Defense, 72 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L4, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1227 }, { Enumeration.Affix.Attack, 34 }, { Enumeration.Affix.Defense, 77 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L5, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1309 }, { Enumeration.Affix.Attack, 37 }, { Enumeration.Affix.Defense, 83 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L6, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1391 }, { Enumeration.Affix.Attack, 39 }, { Enumeration.Affix.Defense, 88 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L7, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1473 }, { Enumeration.Affix.Attack, 41 }, { Enumeration.Affix.Defense, 93 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L8, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1555 }, { Enumeration.Affix.Attack, 44 }, { Enumeration.Affix.Defense, 98 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L9, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1638 }, { Enumeration.Affix.Attack, 46 }, { Enumeration.Affix.Defense, 103 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L10, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1719 }, { Enumeration.Affix.Attack, 48 }, { Enumeration.Affix.Defense, 108 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L11, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1802 }, { Enumeration.Affix.Attack, 50 }, { Enumeration.Affix.Defense, 114 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L12, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1884 }, { Enumeration.Affix.Attack, 53 }, { Enumeration.Affix.Defense, 119 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L13, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1967 }, { Enumeration.Affix.Attack, 55 }, { Enumeration.Affix.Defense, 124 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L14, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2050 }, { Enumeration.Affix.Attack, 57 }, { Enumeration.Affix.Defense, 129 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L15, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2133 }, { Enumeration.Affix.Attack, 60 }, { Enumeration.Affix.Defense, 134 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L16, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2215 }, { Enumeration.Affix.Attack, 62 }, { Enumeration.Affix.Defense, 140 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L17, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2299 }, { Enumeration.Affix.Attack, 64 }, { Enumeration.Affix.Defense, 145 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L18, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2381 }, { Enumeration.Affix.Attack, 67 }, { Enumeration.Affix.Defense, 150 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L19, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2465 }, { Enumeration.Affix.Attack, 69 }, { Enumeration.Affix.Defense, 155 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L20, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2547 }, { Enumeration.Affix.Attack, 71 }, { Enumeration.Affix.Defense, 161 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L20P, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3389 }, { Enumeration.Affix.Attack, 95 }, { Enumeration.Affix.Defense, 214 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L21, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3472 }, { Enumeration.Affix.Attack, 97 }, { Enumeration.Affix.Defense, 219 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L22, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3556 }, { Enumeration.Affix.Attack, 99 }, { Enumeration.Affix.Defense, 224 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L23, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3639 }, { Enumeration.Affix.Attack, 102 }, { Enumeration.Affix.Defense, 230 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L24, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3723 }, { Enumeration.Affix.Attack, 104 }, { Enumeration.Affix.Defense, 235 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L25, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3806 }, { Enumeration.Affix.Attack, 106 }, { Enumeration.Affix.Defense, 240 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L26, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3891 }, { Enumeration.Affix.Attack, 109 }, { Enumeration.Affix.Defense, 245 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L27, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3974 }, { Enumeration.Affix.Attack, 111 }, { Enumeration.Affix.Defense, 251 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L28, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4058 }, { Enumeration.Affix.Attack, 113 }, { Enumeration.Affix.Defense, 256 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L29, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4142 }, { Enumeration.Affix.Attack, 116 }, { Enumeration.Affix.Defense, 261 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L30, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4226 }, { Enumeration.Affix.Attack, 118 }, { Enumeration.Affix.Defense, 266 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L31, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4310 }, { Enumeration.Affix.Attack, 121 }, { Enumeration.Affix.Defense, 272 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L32, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4394 }, { Enumeration.Affix.Attack, 123 }, { Enumeration.Affix.Defense, 277 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L33, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4479 }, { Enumeration.Affix.Attack, 125 }, { Enumeration.Affix.Defense, 282 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L34, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4562 }, { Enumeration.Affix.Attack, 128 }, { Enumeration.Affix.Defense, 288 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L35, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4647 }, { Enumeration.Affix.Attack, 130 }, { Enumeration.Affix.Defense, 293 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L36, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4732 }, { Enumeration.Affix.Attack, 132 }, { Enumeration.Affix.Defense, 298 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L37, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4817 }, { Enumeration.Affix.Attack, 135 }, { Enumeration.Affix.Defense, 304 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L38, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4901 }, { Enumeration.Affix.Attack, 137 }, { Enumeration.Affix.Defense, 309 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L39, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4986 }, { Enumeration.Affix.Attack, 139 }, { Enumeration.Affix.Defense, 314 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L40, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5071 }, { Enumeration.Affix.Attack, 142 }, { Enumeration.Affix.Defense, 320 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L40P, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5669 }, { Enumeration.Affix.Attack, 159 }, { Enumeration.Affix.Defense, 358 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L41, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5754 }, { Enumeration.Affix.Attack, 161 }, { Enumeration.Affix.Defense, 363 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L42, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5839 }, { Enumeration.Affix.Attack, 163 }, { Enumeration.Affix.Defense, 368 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L43, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5925 }, { Enumeration.Affix.Attack, 166 }, { Enumeration.Affix.Defense, 374 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L44, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6009 }, { Enumeration.Affix.Attack, 168 }, { Enumeration.Affix.Defense, 379 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L45, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6094 }, { Enumeration.Affix.Attack, 170 }, { Enumeration.Affix.Defense, 384 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L46, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6180 }, { Enumeration.Affix.Attack, 173 }, { Enumeration.Affix.Defense, 390 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L47, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6265 }, { Enumeration.Affix.Attack, 175 }, { Enumeration.Affix.Defense, 395 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L48, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6351 }, { Enumeration.Affix.Attack, 178 }, { Enumeration.Affix.Defense, 401 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L49, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6437 }, { Enumeration.Affix.Attack, 180 }, { Enumeration.Affix.Defense, 406 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L50, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6523 }, { Enumeration.Affix.Attack, 182 }, { Enumeration.Affix.Defense, 411 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L50P, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7320 }, { Enumeration.Affix.Attack, 205 }, { Enumeration.Affix.Defense, 462 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L51, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7406 }, { Enumeration.Affix.Attack, 207 }, { Enumeration.Affix.Defense, 467 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L52, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7492 }, { Enumeration.Affix.Attack, 210 }, { Enumeration.Affix.Defense, 472 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L53, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7577 }, { Enumeration.Affix.Attack, 212 }, { Enumeration.Affix.Defense, 478 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L54, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7664 }, { Enumeration.Affix.Attack, 214 }, { Enumeration.Affix.Defense, 483 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L55, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7750 }, { Enumeration.Affix.Attack, 217 }, { Enumeration.Affix.Defense, 489 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L56, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7837 }, { Enumeration.Affix.Attack, 219 }, { Enumeration.Affix.Defense, 494 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L57, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7923 }, { Enumeration.Affix.Attack, 222 }, { Enumeration.Affix.Defense, 500 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L58, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8009 }, { Enumeration.Affix.Attack, 224 }, { Enumeration.Affix.Defense, 505 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L59, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8096 }, { Enumeration.Affix.Attack, 226 }, { Enumeration.Affix.Defense, 511 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L60, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8182 }, { Enumeration.Affix.Attack, 229 }, { Enumeration.Affix.Defense, 516 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L60P, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8780 }, { Enumeration.Affix.Attack, 246 }, { Enumeration.Affix.Defense, 554 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L61, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8867 }, { Enumeration.Affix.Attack, 248 }, { Enumeration.Affix.Defense, 559 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L62, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8953 }, { Enumeration.Affix.Attack, 250 }, { Enumeration.Affix.Defense, 565 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L63, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9041 }, { Enumeration.Affix.Attack, 253 }, { Enumeration.Affix.Defense, 570 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L64, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9127 }, { Enumeration.Affix.Attack, 255 }, { Enumeration.Affix.Defense, 576 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L65, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9214 }, { Enumeration.Affix.Attack, 258 }, { Enumeration.Affix.Defense, 581 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L66, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9302 }, { Enumeration.Affix.Attack, 260 }, { Enumeration.Affix.Defense, 587 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L67, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9388 }, { Enumeration.Affix.Attack, 263 }, { Enumeration.Affix.Defense, 592 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L68, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9476 }, { Enumeration.Affix.Attack, 265 }, { Enumeration.Affix.Defense, 598 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L69, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9563 }, { Enumeration.Affix.Attack, 267 }, { Enumeration.Affix.Defense, 603 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L70, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9650 }, { Enumeration.Affix.Attack, 270 }, { Enumeration.Affix.Defense, 609 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L70P, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10249 }, { Enumeration.Affix.Attack, 287 }, { Enumeration.Affix.Defense, 646 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L71, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10336 }, { Enumeration.Affix.Attack, 289 }, { Enumeration.Affix.Defense, 652 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L72, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10424 }, { Enumeration.Affix.Attack, 292 }, { Enumeration.Affix.Defense, 657 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L73, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10512 }, { Enumeration.Affix.Attack, 294 }, { Enumeration.Affix.Defense, 663 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L74, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10599 }, { Enumeration.Affix.Attack, 296 }, { Enumeration.Affix.Defense, 668 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L75, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10688 }, { Enumeration.Affix.Attack, 299 }, { Enumeration.Affix.Defense, 674 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L76, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10775 }, { Enumeration.Affix.Attack, 301 }, { Enumeration.Affix.Defense, 680 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L77, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10863 }, { Enumeration.Affix.Attack, 304 }, { Enumeration.Affix.Defense, 685 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L78, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10952 }, { Enumeration.Affix.Attack, 306 }, { Enumeration.Affix.Defense, 691 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L79, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 11040 }, { Enumeration.Affix.Attack, 309 }, { Enumeration.Affix.Defense, 696 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L80, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 11128 }, { Enumeration.Affix.Attack, 311 }, { Enumeration.Affix.Defense, 702 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L80P, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 11727 }, { Enumeration.Affix.Attack, 328 }, { Enumeration.Affix.Defense, 740 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L81, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 11815 }, { Enumeration.Affix.Attack, 330 }, { Enumeration.Affix.Defense, 745 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L82, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 11903 }, { Enumeration.Affix.Attack, 333 }, { Enumeration.Affix.Defense, 751 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L83, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 11992 }, { Enumeration.Affix.Attack, 335 }, { Enumeration.Affix.Defense, 756 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L84, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 12080 }, { Enumeration.Affix.Attack, 338 }, { Enumeration.Affix.Defense, 762 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L85, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 12168 }, { Enumeration.Affix.Attack, 340 }, { Enumeration.Affix.Defense, 767 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L86, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 12258 }, { Enumeration.Affix.Attack, 343 }, { Enumeration.Affix.Defense, 773 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L87, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 12346 }, { Enumeration.Affix.Attack, 345 }, { Enumeration.Affix.Defense, 779 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L88, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 12436 }, { Enumeration.Affix.Attack, 348 }, { Enumeration.Affix.Defense, 784 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L89, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 12525 }, { Enumeration.Affix.Attack, 350 }, { Enumeration.Affix.Defense, 790 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L90, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 12613 }, { Enumeration.Affix.Attack, 353 }, { Enumeration.Affix.Defense, 795 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L95, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 13061 }, { Enumeration.Affix.Attack, 392 }, { Enumeration.Affix.Defense, 824 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L100, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 13510 }, { Enumeration.Affix.Attack, 432 }, { Enumeration.Affix.Defense, 852 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
        },
        LevelUpMaterials = CharacterLevelUpConstants.GetCharacterLevelUpMaterial(MaterialConstants10._3100101, MaterialConstants06._3060044, MaterialConstants07.G3070601, MaterialConstants04.G3040046),
        Talent1Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants05._3050036, MaterialConstants04.G3040046, MaterialConstants08.G3080001),
        Talent2Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants05._3050036, MaterialConstants04.G3040046, MaterialConstants08.G3080001),
        Talent3Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants05._3050036, MaterialConstants04.G3040046, MaterialConstants08.G3080001),
    };

    public static CharacterModel _1010112 = new()
    {
        Rid = 1010112,
        Vid = 10000130,
        Name = "莉奈娅",
        GoodKey = "Linnea",
        Star = 5,
        ImagePath = "/Resources/Images/Character/UI_AvatarIcon_Linnea.png",
        ElementType = Enumeration.ElementType.Geo,
        WeaponType = Enumeration.WeaponType.Bow,
        BirthMonth = 5,
        BirthDay = 23,
        Talent = new Dictionary<int, ImageDescriptionPairModel>()
        {
            { 1, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/Skill_A_02.png", Description = "捕获方案" } },
            { 2, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/Skill_S_Linnea_01.png", Description = "对策·露米呀吼吼！" } },
            { 3, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/Skill_E_Linnea_01.png", Description = "备忘·绝境生存指南" } },
        },
        Constellation = new Dictionary<int, ImageDescriptionPairModel>()
        {
            { 1, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Linnea_01.png", Description = "未完成的分类" } },
            { 2, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Linnea_02.png", Description = "喜或悲的谕告" } },
            { 3, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_U_Linnea_01.png", Description = "热闹的记录页" } },
            { 4, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Linnea_03.png", Description = "专家的直感觉" } },
            { 5, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_U_Linnea_02.png", Description = "仙乡的赠别礼" } },
            { 6, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Linnea_04.png", Description = "黄金猎犬之梦" } },
        },
        AffixDictionary = new Dictionary<Enumeration.Level, Dictionary<Enumeration.Affix, double>>()
        {
            { Enumeration.Level.L1, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 770 }, { Enumeration.Affix.Attack, 11 }, { Enumeration.Affix.Defense, 71 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L2, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 834 }, { Enumeration.Affix.Attack, 12 }, { Enumeration.Affix.Defense, 76 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L3, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 898 }, { Enumeration.Affix.Attack, 13 }, { Enumeration.Affix.Defense, 82 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L4, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 963 }, { Enumeration.Affix.Attack, 14 }, { Enumeration.Affix.Defense, 88 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L5, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1027 }, { Enumeration.Affix.Attack, 15 }, { Enumeration.Affix.Defense, 94 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L6, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1091 }, { Enumeration.Affix.Attack, 16 }, { Enumeration.Affix.Defense, 100 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L7, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1155 }, { Enumeration.Affix.Attack, 17 }, { Enumeration.Affix.Defense, 106 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L8, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1220 }, { Enumeration.Affix.Attack, 18 }, { Enumeration.Affix.Defense, 112 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L9, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1285 }, { Enumeration.Affix.Attack, 19 }, { Enumeration.Affix.Defense, 118 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L10, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1349 }, { Enumeration.Affix.Attack, 20 }, { Enumeration.Affix.Defense, 124 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L11, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1413 }, { Enumeration.Affix.Attack, 21 }, { Enumeration.Affix.Defense, 130 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L12, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1478 }, { Enumeration.Affix.Attack, 21 }, { Enumeration.Affix.Defense, 135 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L13, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1543 }, { Enumeration.Affix.Attack, 22 }, { Enumeration.Affix.Defense, 141 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L14, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1608 }, { Enumeration.Affix.Attack, 23 }, { Enumeration.Affix.Defense, 147 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L15, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1673 }, { Enumeration.Affix.Attack, 24 }, { Enumeration.Affix.Defense, 153 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L16, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1738 }, { Enumeration.Affix.Attack, 25 }, { Enumeration.Affix.Defense, 159 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L17, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1803 }, { Enumeration.Affix.Attack, 26 }, { Enumeration.Affix.Defense, 165 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L18, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1868 }, { Enumeration.Affix.Attack, 27 }, { Enumeration.Affix.Defense, 171 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L19, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1933 }, { Enumeration.Affix.Attack, 28 }, { Enumeration.Affix.Defense, 177 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L20, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1998 }, { Enumeration.Affix.Attack, 29 }, { Enumeration.Affix.Defense, 183 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L20P, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2659 }, { Enumeration.Affix.Attack, 39 }, { Enumeration.Affix.Defense, 244 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L21, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2724 }, { Enumeration.Affix.Attack, 40 }, { Enumeration.Affix.Defense, 250 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L22, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2790 }, { Enumeration.Affix.Attack, 40 }, { Enumeration.Affix.Defense, 256 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L23, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2855 }, { Enumeration.Affix.Attack, 41 }, { Enumeration.Affix.Defense, 262 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L24, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2920 }, { Enumeration.Affix.Attack, 42 }, { Enumeration.Affix.Defense, 268 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L25, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2986 }, { Enumeration.Affix.Attack, 43 }, { Enumeration.Affix.Defense, 274 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L26, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3052 }, { Enumeration.Affix.Attack, 44 }, { Enumeration.Affix.Defense, 280 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L27, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3118 }, { Enumeration.Affix.Attack, 45 }, { Enumeration.Affix.Defense, 286 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L28, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3183 }, { Enumeration.Affix.Attack, 46 }, { Enumeration.Affix.Defense, 292 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L29, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3249 }, { Enumeration.Affix.Attack, 47 }, { Enumeration.Affix.Defense, 298 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L30, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3315 }, { Enumeration.Affix.Attack, 48 }, { Enumeration.Affix.Defense, 304 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L31, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3381 }, { Enumeration.Affix.Attack, 49 }, { Enumeration.Affix.Defense, 310 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L32, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3447 }, { Enumeration.Affix.Attack, 50 }, { Enumeration.Affix.Defense, 316 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L33, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3514 }, { Enumeration.Affix.Attack, 51 }, { Enumeration.Affix.Defense, 322 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L34, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3579 }, { Enumeration.Affix.Attack, 52 }, { Enumeration.Affix.Defense, 328 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L35, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3645 }, { Enumeration.Affix.Attack, 53 }, { Enumeration.Affix.Defense, 334 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L36, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3712 }, { Enumeration.Affix.Attack, 54 }, { Enumeration.Affix.Defense, 340 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L37, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3779 }, { Enumeration.Affix.Attack, 55 }, { Enumeration.Affix.Defense, 346 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L38, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3845 }, { Enumeration.Affix.Attack, 56 }, { Enumeration.Affix.Defense, 352 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L39, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3911 }, { Enumeration.Affix.Attack, 57 }, { Enumeration.Affix.Defense, 358 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L40, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3978 }, { Enumeration.Affix.Attack, 58 }, { Enumeration.Affix.Defense, 365 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L40P, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4447 }, { Enumeration.Affix.Attack, 65 }, { Enumeration.Affix.Defense, 408 }, { Enumeration.Affix.CriticalRate, 9.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L41, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4514 }, { Enumeration.Affix.Attack, 65 }, { Enumeration.Affix.Defense, 414 }, { Enumeration.Affix.CriticalRate, 9.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L42, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4581 }, { Enumeration.Affix.Attack, 66 }, { Enumeration.Affix.Defense, 420 }, { Enumeration.Affix.CriticalRate, 9.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L43, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4648 }, { Enumeration.Affix.Attack, 67 }, { Enumeration.Affix.Defense, 426 }, { Enumeration.Affix.CriticalRate, 9.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L44, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4714 }, { Enumeration.Affix.Attack, 68 }, { Enumeration.Affix.Defense, 432 }, { Enumeration.Affix.CriticalRate, 9.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L45, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4781 }, { Enumeration.Affix.Attack, 69 }, { Enumeration.Affix.Defense, 438 }, { Enumeration.Affix.CriticalRate, 9.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L46, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4848 }, { Enumeration.Affix.Attack, 70 }, { Enumeration.Affix.Defense, 444 }, { Enumeration.Affix.CriticalRate, 9.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L47, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4915 }, { Enumeration.Affix.Attack, 71 }, { Enumeration.Affix.Defense, 450 }, { Enumeration.Affix.CriticalRate, 9.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L48, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4982 }, { Enumeration.Affix.Attack, 72 }, { Enumeration.Affix.Defense, 457 }, { Enumeration.Affix.CriticalRate, 9.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L49, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5050 }, { Enumeration.Affix.Attack, 73 }, { Enumeration.Affix.Defense, 463 }, { Enumeration.Affix.CriticalRate, 9.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L50, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5117 }, { Enumeration.Affix.Attack, 74 }, { Enumeration.Affix.Defense, 469 }, { Enumeration.Affix.CriticalRate, 9.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L50P, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5742 }, { Enumeration.Affix.Attack, 83 }, { Enumeration.Affix.Defense, 526 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L51, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5809 }, { Enumeration.Affix.Attack, 84 }, { Enumeration.Affix.Defense, 532 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L52, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5877 }, { Enumeration.Affix.Attack, 85 }, { Enumeration.Affix.Defense, 539 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L53, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5944 }, { Enumeration.Affix.Attack, 86 }, { Enumeration.Affix.Defense, 545 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L54, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6012 }, { Enumeration.Affix.Attack, 87 }, { Enumeration.Affix.Defense, 551 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L55, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6080 }, { Enumeration.Affix.Attack, 88 }, { Enumeration.Affix.Defense, 557 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L56, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6148 }, { Enumeration.Affix.Attack, 89 }, { Enumeration.Affix.Defense, 563 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L57, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6215 }, { Enumeration.Affix.Attack, 90 }, { Enumeration.Affix.Defense, 570 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L58, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6283 }, { Enumeration.Affix.Attack, 91 }, { Enumeration.Affix.Defense, 576 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L59, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6351 }, { Enumeration.Affix.Attack, 92 }, { Enumeration.Affix.Defense, 582 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L60, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6419 }, { Enumeration.Affix.Attack, 93 }, { Enumeration.Affix.Defense, 588 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L60P, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6888 }, { Enumeration.Affix.Attack, 100 }, { Enumeration.Affix.Defense, 631 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L61, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6956 }, { Enumeration.Affix.Attack, 101 }, { Enumeration.Affix.Defense, 638 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L62, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7024 }, { Enumeration.Affix.Attack, 102 }, { Enumeration.Affix.Defense, 644 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L63, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7092 }, { Enumeration.Affix.Attack, 103 }, { Enumeration.Affix.Defense, 650 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L64, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7160 }, { Enumeration.Affix.Attack, 104 }, { Enumeration.Affix.Defense, 656 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L65, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7228 }, { Enumeration.Affix.Attack, 105 }, { Enumeration.Affix.Defense, 663 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L66, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7297 }, { Enumeration.Affix.Attack, 106 }, { Enumeration.Affix.Defense, 669 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L67, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7365 }, { Enumeration.Affix.Attack, 107 }, { Enumeration.Affix.Defense, 675 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L68, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7433 }, { Enumeration.Affix.Attack, 108 }, { Enumeration.Affix.Defense, 681 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L69, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7502 }, { Enumeration.Affix.Attack, 109 }, { Enumeration.Affix.Defense, 688 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L70, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7570 }, { Enumeration.Affix.Attack, 110 }, { Enumeration.Affix.Defense, 694 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L70P, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8040 }, { Enumeration.Affix.Attack, 117 }, { Enumeration.Affix.Defense, 737 }, { Enumeration.Affix.CriticalRate, 19.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L71, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8108 }, { Enumeration.Affix.Attack, 118 }, { Enumeration.Affix.Defense, 743 }, { Enumeration.Affix.CriticalRate, 19.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L72, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8178 }, { Enumeration.Affix.Attack, 119 }, { Enumeration.Affix.Defense, 750 }, { Enumeration.Affix.CriticalRate, 19.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L73, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8246 }, { Enumeration.Affix.Attack, 120 }, { Enumeration.Affix.Defense, 756 }, { Enumeration.Affix.CriticalRate, 19.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L74, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8315 }, { Enumeration.Affix.Attack, 121 }, { Enumeration.Affix.Defense, 762 }, { Enumeration.Affix.CriticalRate, 19.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L75, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8384 }, { Enumeration.Affix.Attack, 122 }, { Enumeration.Affix.Defense, 768 }, { Enumeration.Affix.CriticalRate, 19.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L76, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8453 }, { Enumeration.Affix.Attack, 123 }, { Enumeration.Affix.Defense, 775 }, { Enumeration.Affix.CriticalRate, 19.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L77, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8522 }, { Enumeration.Affix.Attack, 124 }, { Enumeration.Affix.Defense, 781 }, { Enumeration.Affix.CriticalRate, 19.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L78, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8591 }, { Enumeration.Affix.Attack, 125 }, { Enumeration.Affix.Defense, 787 }, { Enumeration.Affix.CriticalRate, 19.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L79, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8661 }, { Enumeration.Affix.Attack, 126 }, { Enumeration.Affix.Defense, 794 }, { Enumeration.Affix.CriticalRate, 19.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L80, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8730 }, { Enumeration.Affix.Attack, 127 }, { Enumeration.Affix.Defense, 800 }, { Enumeration.Affix.CriticalRate, 19.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L80P, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9199 }, { Enumeration.Affix.Attack, 133 }, { Enumeration.Affix.Defense, 843 }, { Enumeration.Affix.CriticalRate, 24.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L81, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9268 }, { Enumeration.Affix.Attack, 134 }, { Enumeration.Affix.Defense, 849 }, { Enumeration.Affix.CriticalRate, 24.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L82, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9338 }, { Enumeration.Affix.Attack, 135 }, { Enumeration.Affix.Defense, 856 }, { Enumeration.Affix.CriticalRate, 24.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L83, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9407 }, { Enumeration.Affix.Attack, 136 }, { Enumeration.Affix.Defense, 862 }, { Enumeration.Affix.CriticalRate, 24.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L84, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9476 }, { Enumeration.Affix.Attack, 137 }, { Enumeration.Affix.Defense, 869 }, { Enumeration.Affix.CriticalRate, 24.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L85, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9546 }, { Enumeration.Affix.Attack, 138 }, { Enumeration.Affix.Defense, 875 }, { Enumeration.Affix.CriticalRate, 24.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L86, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9616 }, { Enumeration.Affix.Attack, 139 }, { Enumeration.Affix.Defense, 881 }, { Enumeration.Affix.CriticalRate, 24.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L87, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9685 }, { Enumeration.Affix.Attack, 140 }, { Enumeration.Affix.Defense, 888 }, { Enumeration.Affix.CriticalRate, 24.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L88, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9755 }, { Enumeration.Affix.Attack, 141 }, { Enumeration.Affix.Defense, 894 }, { Enumeration.Affix.CriticalRate, 24.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L89, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9825 }, { Enumeration.Affix.Attack, 143 }, { Enumeration.Affix.Defense, 901 }, { Enumeration.Affix.CriticalRate, 24.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L90, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9895 }, { Enumeration.Affix.Attack, 144 }, { Enumeration.Affix.Defense, 907 }, { Enumeration.Affix.CriticalRate, 24.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L95, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10246 }, { Enumeration.Affix.Attack, 160 }, { Enumeration.Affix.Defense, 939 }, { Enumeration.Affix.CriticalRate, 24.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L100, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10598 }, { Enumeration.Affix.Attack, 176 }, { Enumeration.Affix.Defense, 971 }, { Enumeration.Affix.CriticalRate, 24.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
        },
        LevelUpMaterials = CharacterLevelUpConstants.GetCharacterLevelUpMaterial(MaterialConstants10._3100109, MaterialConstants06._3060045, MaterialConstants07.G3070801, MaterialConstants04.G3040049),
        Talent1Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants05._3050040, MaterialConstants04.G3040049, MaterialConstants08.G3080061),
        Talent2Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants05._3050040, MaterialConstants04.G3040049, MaterialConstants08.G3080061),
        Talent3Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants05._3050040, MaterialConstants04.G3040049, MaterialConstants08.G3080061),
    };

    public static CharacterModel _1010113 = new()
    {
        Rid = 1010113,
        Vid = 10000132,
        Name = "布伦妮",
        GoodKey = "Prune",
        Star = 4,
        ImagePath = "/Resources/Images/Character/UI_AvatarIcon_Prune.png",
        ElementType = Enumeration.ElementType.Anemo,
        WeaponType = Enumeration.WeaponType.Catalyst,
        BirthMonth = 11,
        BirthDay = 20,
        Talent = new Dictionary<int, ImageDescriptionPairModel>()
        {
            { 1, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/Skill_A_Catalyst_MD.png", Description = "隆咚咚·破魔之锤" } },
            { 2, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/Skill_S_Prune_01.png", Description = "叮铃铃·猎魔之音" } },
            { 3, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/Skill_E_Prune_01.png", Description = "铃鸣·狩魔之刻" } },
        },
        Constellation = new Dictionary<int, ImageDescriptionPairModel>()
        {
            { 1, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Prune_01.png", Description = "立下寻救的誓言，旅途由此开端" } },
            { 2, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Prune_02.png", Description = "整理杂乱的包袱，元素妙力果然" } },
            { 3, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_U_Prune_01.png", Description = "同旅商队过山关，眼眸景色又转" } },
            { 4, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Prune_03.png", Description = "循风同行回头看，影子还缺一半" } },
            { 5, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_U_Prune_02.png", Description = "输了一百次不算，明日接着再战" } },
            { 6, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Prune_04.png", Description = "故事结尾在这儿，念给伙伴听完" } },
        },
        AffixDictionary = new Dictionary<Enumeration.Level, Dictionary<Enumeration.Affix, double>>()
        {
            {
                Enumeration.Level.L1,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 811 }, { Enumeration.Affix.Attack, 19 }, { Enumeration.Affix.Defense, 49 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L2,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 879 }, { Enumeration.Affix.Attack, 20 }, { Enumeration.Affix.Defense, 53 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L3,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 945 }, { Enumeration.Affix.Attack, 22 }, { Enumeration.Affix.Defense, 57 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L4,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1013 }, { Enumeration.Affix.Attack, 23 }, { Enumeration.Affix.Defense, 61 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L5,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1079 }, { Enumeration.Affix.Attack, 25 }, { Enumeration.Affix.Defense, 65 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L6,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1147 }, { Enumeration.Affix.Attack, 26 }, { Enumeration.Affix.Defense, 69 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L7,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1213 }, { Enumeration.Affix.Attack, 28 }, { Enumeration.Affix.Defense, 73 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L8,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1281 }, { Enumeration.Affix.Attack, 29 }, { Enumeration.Affix.Defense, 77 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L9,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1348 }, { Enumeration.Affix.Attack, 31 }, { Enumeration.Affix.Defense, 81 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L10,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1414 }, { Enumeration.Affix.Attack, 32 }, { Enumeration.Affix.Defense, 85 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L11,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1482 }, { Enumeration.Affix.Attack, 34 }, { Enumeration.Affix.Defense, 89 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L12,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1548 }, { Enumeration.Affix.Attack, 35 }, { Enumeration.Affix.Defense, 93 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L13,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1616 }, { Enumeration.Affix.Attack, 37 }, { Enumeration.Affix.Defense, 97 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L14,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1682 }, { Enumeration.Affix.Attack, 38 }, { Enumeration.Affix.Defense, 101 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L15,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1750 }, { Enumeration.Affix.Attack, 40 }, { Enumeration.Affix.Defense, 105 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L16,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1817 }, { Enumeration.Affix.Attack, 41 }, { Enumeration.Affix.Defense, 109 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L17,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1883 }, { Enumeration.Affix.Attack, 43 }, { Enumeration.Affix.Defense, 113 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L18,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1951 }, { Enumeration.Affix.Attack, 45 }, { Enumeration.Affix.Defense, 117 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L19,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2017 }, { Enumeration.Affix.Attack, 46 }, { Enumeration.Affix.Defense, 121 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L20,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2085 }, { Enumeration.Affix.Attack, 48 }, { Enumeration.Affix.Defense, 125 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L20P,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2691 }, { Enumeration.Affix.Attack, 61 }, { Enumeration.Affix.Defense, 161 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L21,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2757 }, { Enumeration.Affix.Attack, 63 }, { Enumeration.Affix.Defense, 165 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L22,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2825 }, { Enumeration.Affix.Attack, 64 }, { Enumeration.Affix.Defense, 169 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L23,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2892 }, { Enumeration.Affix.Attack, 66 }, { Enumeration.Affix.Defense, 173 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L24,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2959 }, { Enumeration.Affix.Attack, 68 }, { Enumeration.Affix.Defense, 177 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L25,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3026 }, { Enumeration.Affix.Attack, 69 }, { Enumeration.Affix.Defense, 181 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L26,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3093 }, { Enumeration.Affix.Attack, 71 }, { Enumeration.Affix.Defense, 185 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L27,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3160 }, { Enumeration.Affix.Attack, 72 }, { Enumeration.Affix.Defense, 189 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L28,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3227 }, { Enumeration.Affix.Attack, 74 }, { Enumeration.Affix.Defense, 193 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L29,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3294 }, { Enumeration.Affix.Attack, 75 }, { Enumeration.Affix.Defense, 197 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L30,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3360 }, { Enumeration.Affix.Attack, 77 }, { Enumeration.Affix.Defense, 201 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L31,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3428 }, { Enumeration.Affix.Attack, 78 }, { Enumeration.Affix.Defense, 205 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L32,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3495 }, { Enumeration.Affix.Attack, 80 }, { Enumeration.Affix.Defense, 210 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L33,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3562 }, { Enumeration.Affix.Attack, 81 }, { Enumeration.Affix.Defense, 213 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L34,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3629 }, { Enumeration.Affix.Attack, 83 }, { Enumeration.Affix.Defense, 218 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L35,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3696 }, { Enumeration.Affix.Attack, 84 }, { Enumeration.Affix.Defense, 222 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L36,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3763 }, { Enumeration.Affix.Attack, 86 }, { Enumeration.Affix.Defense, 226 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L37,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3829 }, { Enumeration.Affix.Attack, 87 }, { Enumeration.Affix.Defense, 230 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L38,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3897 }, { Enumeration.Affix.Attack, 89 }, { Enumeration.Affix.Defense, 234 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L39,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3964 }, { Enumeration.Affix.Attack, 90 }, { Enumeration.Affix.Defense, 238 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L40,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4031 }, { Enumeration.Affix.Attack, 92 }, { Enumeration.Affix.Defense, 242 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L40P,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4461 }, { Enumeration.Affix.Attack, 102 }, { Enumeration.Affix.Defense, 267 }, { Enumeration.Affix.AttackPercent, 6.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L41,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4529 }, { Enumeration.Affix.Attack, 103 }, { Enumeration.Affix.Defense, 271 }, { Enumeration.Affix.AttackPercent, 6.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L42,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4595 }, { Enumeration.Affix.Attack, 105 }, { Enumeration.Affix.Defense, 275 }, { Enumeration.Affix.AttackPercent, 6.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L43,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4663 }, { Enumeration.Affix.Attack, 106 }, { Enumeration.Affix.Defense, 279 }, { Enumeration.Affix.AttackPercent, 6.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L44,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4729 }, { Enumeration.Affix.Attack, 108 }, { Enumeration.Affix.Defense, 283 }, { Enumeration.Affix.AttackPercent, 6.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L45,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4797 }, { Enumeration.Affix.Attack, 109 }, { Enumeration.Affix.Defense, 288 }, { Enumeration.Affix.AttackPercent, 6.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L46,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4864 }, { Enumeration.Affix.Attack, 111 }, { Enumeration.Affix.Defense, 292 }, { Enumeration.Affix.AttackPercent, 6.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L47,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4931 }, { Enumeration.Affix.Attack, 113 }, { Enumeration.Affix.Defense, 296 }, { Enumeration.Affix.AttackPercent, 6.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L48,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4998 }, { Enumeration.Affix.Attack, 114 }, { Enumeration.Affix.Defense, 300 }, { Enumeration.Affix.AttackPercent, 6.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L49,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5064 }, { Enumeration.Affix.Attack, 116 }, { Enumeration.Affix.Defense, 304 }, { Enumeration.Affix.AttackPercent, 6.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L50,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5132 }, { Enumeration.Affix.Attack, 117 }, { Enumeration.Affix.Defense, 308 }, { Enumeration.Affix.AttackPercent, 6.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L50P,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5706 }, { Enumeration.Affix.Attack, 130 }, { Enumeration.Affix.Defense, 342 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L51,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5773 }, { Enumeration.Affix.Attack, 132 }, { Enumeration.Affix.Defense, 346 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L52,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5840 }, { Enumeration.Affix.Attack, 133 }, { Enumeration.Affix.Defense, 350 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L53,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5907 }, { Enumeration.Affix.Attack, 135 }, { Enumeration.Affix.Defense, 354 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L54,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5974 }, { Enumeration.Affix.Attack, 136 }, { Enumeration.Affix.Defense, 358 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L55,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6041 }, { Enumeration.Affix.Attack, 138 }, { Enumeration.Affix.Defense, 362 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L56,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6108 }, { Enumeration.Affix.Attack, 139 }, { Enumeration.Affix.Defense, 366 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L57,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6175 }, { Enumeration.Affix.Attack, 141 }, { Enumeration.Affix.Defense, 370 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L58,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6242 }, { Enumeration.Affix.Attack, 142 }, { Enumeration.Affix.Defense, 374 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L59,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6309 }, { Enumeration.Affix.Attack, 144 }, { Enumeration.Affix.Defense, 378 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L60,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6376 }, { Enumeration.Affix.Attack, 146 }, { Enumeration.Affix.Defense, 382 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L60P,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6807 }, { Enumeration.Affix.Attack, 155 }, { Enumeration.Affix.Defense, 408 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L61,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6874 }, { Enumeration.Affix.Attack, 157 }, { Enumeration.Affix.Defense, 412 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L62,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6941 }, { Enumeration.Affix.Attack, 158 }, { Enumeration.Affix.Defense, 416 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L63,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7008 }, { Enumeration.Affix.Attack, 160 }, { Enumeration.Affix.Defense, 420 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L64,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7075 }, { Enumeration.Affix.Attack, 161 }, { Enumeration.Affix.Defense, 424 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L65,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7141 }, { Enumeration.Affix.Attack, 163 }, { Enumeration.Affix.Defense, 428 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L66,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7209 }, { Enumeration.Affix.Attack, 165 }, { Enumeration.Affix.Defense, 432 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L67,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7276 }, { Enumeration.Affix.Attack, 166 }, { Enumeration.Affix.Defense, 436 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L68,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7343 }, { Enumeration.Affix.Attack, 168 }, { Enumeration.Affix.Defense, 440 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L69,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7410 }, { Enumeration.Affix.Attack, 169 }, { Enumeration.Affix.Defense, 444 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L70,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7477 }, { Enumeration.Affix.Attack, 171 }, { Enumeration.Affix.Defense, 448 }, { Enumeration.Affix.AttackPercent, 12.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L70P,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7907 }, { Enumeration.Affix.Attack, 180 }, { Enumeration.Affix.Defense, 474 }, { Enumeration.Affix.AttackPercent, 18.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L71,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7975 }, { Enumeration.Affix.Attack, 182 }, { Enumeration.Affix.Defense, 478 }, { Enumeration.Affix.AttackPercent, 18.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L72,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8041 }, { Enumeration.Affix.Attack, 184 }, { Enumeration.Affix.Defense, 482 }, { Enumeration.Affix.AttackPercent, 18.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L73,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8109 }, { Enumeration.Affix.Attack, 185 }, { Enumeration.Affix.Defense, 486 }, { Enumeration.Affix.AttackPercent, 18.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L74,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8176 }, { Enumeration.Affix.Attack, 187 }, { Enumeration.Affix.Defense, 490 }, { Enumeration.Affix.AttackPercent, 18.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L75,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8242 }, { Enumeration.Affix.Attack, 188 }, { Enumeration.Affix.Defense, 494 }, { Enumeration.Affix.AttackPercent, 18.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L76,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8310 }, { Enumeration.Affix.Attack, 190 }, { Enumeration.Affix.Defense, 498 }, { Enumeration.Affix.AttackPercent, 18.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L77,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8376 }, { Enumeration.Affix.Attack, 191 }, { Enumeration.Affix.Defense, 502 }, { Enumeration.Affix.AttackPercent, 18.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L78,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8444 }, { Enumeration.Affix.Attack, 193 }, { Enumeration.Affix.Defense, 506 }, { Enumeration.Affix.AttackPercent, 18.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L79,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8510 }, { Enumeration.Affix.Attack, 194 }, { Enumeration.Affix.Defense, 510 }, { Enumeration.Affix.AttackPercent, 18.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L80,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8578 }, { Enumeration.Affix.Attack, 196 }, { Enumeration.Affix.Defense, 514 }, { Enumeration.Affix.AttackPercent, 18.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L80P,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9008 }, { Enumeration.Affix.Attack, 206 }, { Enumeration.Affix.Defense, 540 }, { Enumeration.Affix.AttackPercent, 24.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L81,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9076 }, { Enumeration.Affix.Attack, 207 }, { Enumeration.Affix.Defense, 544 }, { Enumeration.Affix.AttackPercent, 24.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L82,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9142 }, { Enumeration.Affix.Attack, 209 }, { Enumeration.Affix.Defense, 548 }, { Enumeration.Affix.AttackPercent, 24.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L83,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9210 }, { Enumeration.Affix.Attack, 210 }, { Enumeration.Affix.Defense, 552 }, { Enumeration.Affix.AttackPercent, 24.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L84,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9276 }, { Enumeration.Affix.Attack, 212 }, { Enumeration.Affix.Defense, 556 }, { Enumeration.Affix.AttackPercent, 24.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L85,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9344 }, { Enumeration.Affix.Attack, 213 }, { Enumeration.Affix.Defense, 560 }, { Enumeration.Affix.AttackPercent, 24.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L86,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9410 }, { Enumeration.Affix.Attack, 215 }, { Enumeration.Affix.Defense, 564 }, { Enumeration.Affix.AttackPercent, 24.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L87,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9477 }, { Enumeration.Affix.Attack, 216 }, { Enumeration.Affix.Defense, 568 }, { Enumeration.Affix.AttackPercent, 24.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L88,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9544 }, { Enumeration.Affix.Attack, 218 }, { Enumeration.Affix.Defense, 572 }, { Enumeration.Affix.AttackPercent, 24.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L89,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9611 }, { Enumeration.Affix.Attack, 219 }, { Enumeration.Affix.Defense, 576 }, { Enumeration.Affix.AttackPercent, 24.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L90,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9679 }, { Enumeration.Affix.Attack, 221 }, { Enumeration.Affix.Defense, 580 }, { Enumeration.Affix.AttackPercent, 24.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L95,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10013 }, { Enumeration.Affix.Attack, 249 }, { Enumeration.Affix.Defense, 600 }, { Enumeration.Affix.AttackPercent, 24.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L100,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10348 }, { Enumeration.Affix.Attack, 277 }, { Enumeration.Affix.Defense, 620 }, { Enumeration.Affix.AttackPercent, 24.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
        },
        LevelUpMaterials = CharacterLevelUpConstants.GetCharacterLevelUpMaterial(MaterialConstants10._3100704, MaterialConstants06._3060041, MaterialConstants07.G3070601, MaterialConstants04.G3040016),
        Talent1Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants05._3050038, MaterialConstants04.G3040016, MaterialConstants08.G3080004),
        Talent2Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants05._3050038, MaterialConstants04.G3040016, MaterialConstants08.G3080004),
        Talent3Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants05._3050038, MaterialConstants04.G3040016, MaterialConstants08.G3080004),
    };

    public static CharacterModel _1010114 = new()
    {
        Rid = 1010114,
        Vid = 10000131,
        Name = "尼可",
        GoodKey = "Nicole",
        Star = 5,
        ImagePath = "/Resources/Images/Character/UI_AvatarIcon_Nicole.png",
        ElementType = Enumeration.ElementType.Pyro,
        WeaponType = Enumeration.WeaponType.Catalyst,
        BirthMonth = 9,
        BirthDay = 29,
        Talent = new Dictionary<int, ImageDescriptionPairModel>()
        {
            { 1, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/Skill_A_Catalyst_MD.png", Description = "托喻" } },
            { 2, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/Skill_S_Nicole_01.png", Description = "圣言默示·未现之光" } },
            { 3, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/Skill_E_Nicole_01.png", Description = "圣言默示·天路历程" } },
        },
        Constellation = new Dictionary<int, ImageDescriptionPairModel>()
        {
            { 1, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Nicole_01.png", Description = "「不要惧怕，蒙眷爱的人之子呀」" } },
            { 2, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Nicole_02.png", Description = "「我要教导你，指引你应走的路」" } },
            { 3, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_U_Nicole_01.png", Description = "「为你身边的灯，为你前方的光」" } },
            { 4, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Nicole_03.png", Description = "「向左或向右，无论你行往何方」" } },
            { 5, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_U_Nicole_02.png", Description = "「我就要有话对你说，在你身旁」" } },
            { 6, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Nicole_04.png", Description = "「这便是正确的道路，莫要彷徨」" } },
        },
        AffixDictionary = new Dictionary<Enumeration.Level, Dictionary<Enumeration.Affix, double>>()
        {
            {
                Enumeration.Level.L1,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 810 }, { Enumeration.Affix.Attack, 27 }, { Enumeration.Affix.Defense, 44 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L2,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 878 }, { Enumeration.Affix.Attack, 29 }, { Enumeration.Affix.Defense, 47 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L3,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 945 }, { Enumeration.Affix.Attack, 31 }, { Enumeration.Affix.Defense, 51 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L4,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1013 }, { Enumeration.Affix.Attack, 33 }, { Enumeration.Affix.Defense, 55 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L5,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1080 }, { Enumeration.Affix.Attack, 35 }, { Enumeration.Affix.Defense, 58 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L6,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1148 }, { Enumeration.Affix.Attack, 38 }, { Enumeration.Affix.Defense, 62 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L7,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1215 }, { Enumeration.Affix.Attack, 40 }, { Enumeration.Affix.Defense, 66 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L8,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1284 }, { Enumeration.Affix.Attack, 42 }, { Enumeration.Affix.Defense, 69 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L9,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1352 }, { Enumeration.Affix.Attack, 44 }, { Enumeration.Affix.Defense, 73 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L10,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1419 }, { Enumeration.Affix.Attack, 47 }, { Enumeration.Affix.Defense, 77 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L11,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1487 }, { Enumeration.Affix.Attack, 49 }, { Enumeration.Affix.Defense, 80 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L12,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1555 }, { Enumeration.Affix.Attack, 51 }, { Enumeration.Affix.Defense, 84 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L13,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1623 }, { Enumeration.Affix.Attack, 53 }, { Enumeration.Affix.Defense, 88 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L14,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1692 }, { Enumeration.Affix.Attack, 56 }, { Enumeration.Affix.Defense, 91 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L15,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1760 }, { Enumeration.Affix.Attack, 58 }, { Enumeration.Affix.Defense, 95 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L16,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1828 }, { Enumeration.Affix.Attack, 60 }, { Enumeration.Affix.Defense, 99 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L17,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1897 }, { Enumeration.Affix.Attack, 62 }, { Enumeration.Affix.Defense, 103 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L18,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1965 }, { Enumeration.Affix.Attack, 65 }, { Enumeration.Affix.Defense, 106 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L19,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2034 }, { Enumeration.Affix.Attack, 67 }, { Enumeration.Affix.Defense, 110 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L20,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2102 }, { Enumeration.Affix.Attack, 69 }, { Enumeration.Affix.Defense, 114 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L20P,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2797 }, { Enumeration.Affix.Attack, 92 }, { Enumeration.Affix.Defense, 151 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L21,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2866 }, { Enumeration.Affix.Attack, 94 }, { Enumeration.Affix.Defense, 155 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L22,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2935 }, { Enumeration.Affix.Attack, 96 }, { Enumeration.Affix.Defense, 159 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L23,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3003 }, { Enumeration.Affix.Attack, 99 }, { Enumeration.Affix.Defense, 162 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L24,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3072 }, { Enumeration.Affix.Attack, 101 }, { Enumeration.Affix.Defense, 166 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L25,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3141 }, { Enumeration.Affix.Attack, 103 }, { Enumeration.Affix.Defense, 170 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L26,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3211 }, { Enumeration.Affix.Attack, 106 }, { Enumeration.Affix.Defense, 174 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L27,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3280 }, { Enumeration.Affix.Attack, 108 }, { Enumeration.Affix.Defense, 177 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L28,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3349 }, { Enumeration.Affix.Attack, 110 }, { Enumeration.Affix.Defense, 181 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L29,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3418 }, { Enumeration.Affix.Attack, 112 }, { Enumeration.Affix.Defense, 185 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L30,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3487 }, { Enumeration.Affix.Attack, 115 }, { Enumeration.Affix.Defense, 188 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L31,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3557 }, { Enumeration.Affix.Attack, 117 }, { Enumeration.Affix.Defense, 192 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L32,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3627 }, { Enumeration.Affix.Attack, 119 }, { Enumeration.Affix.Defense, 196 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L33,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3696 }, { Enumeration.Affix.Attack, 121 }, { Enumeration.Affix.Defense, 200 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L34,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3765 }, { Enumeration.Affix.Attack, 124 }, { Enumeration.Affix.Defense, 203 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L35,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3835 }, { Enumeration.Affix.Attack, 126 }, { Enumeration.Affix.Defense, 207 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L36,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3905 }, { Enumeration.Affix.Attack, 128 }, { Enumeration.Affix.Defense, 211 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L37,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3975 }, { Enumeration.Affix.Attack, 131 }, { Enumeration.Affix.Defense, 215 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L38,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4045 }, { Enumeration.Affix.Attack, 133 }, { Enumeration.Affix.Defense, 219 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L39,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4114 }, { Enumeration.Affix.Attack, 135 }, { Enumeration.Affix.Defense, 222 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L40,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4185 }, { Enumeration.Affix.Attack, 138 }, { Enumeration.Affix.Defense, 226 }, { Enumeration.Affix.AttackPercent, 0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L40P,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4678 }, { Enumeration.Affix.Attack, 154 }, { Enumeration.Affix.Defense, 253 }, { Enumeration.Affix.AttackPercent, 7.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L41,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4748 }, { Enumeration.Affix.Attack, 156 }, { Enumeration.Affix.Defense, 257 }, { Enumeration.Affix.AttackPercent, 7.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L42,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4819 }, { Enumeration.Affix.Attack, 158 }, { Enumeration.Affix.Defense, 260 }, { Enumeration.Affix.AttackPercent, 7.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L43,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4889 }, { Enumeration.Affix.Attack, 161 }, { Enumeration.Affix.Defense, 264 }, { Enumeration.Affix.AttackPercent, 7.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L44,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4959 }, { Enumeration.Affix.Attack, 163 }, { Enumeration.Affix.Defense, 268 }, { Enumeration.Affix.AttackPercent, 7.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L45,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5029 }, { Enumeration.Affix.Attack, 165 }, { Enumeration.Affix.Defense, 272 }, { Enumeration.Affix.AttackPercent, 7.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L46,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5100 }, { Enumeration.Affix.Attack, 168 }, { Enumeration.Affix.Defense, 276 }, { Enumeration.Affix.AttackPercent, 7.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L47,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5170 }, { Enumeration.Affix.Attack, 170 }, { Enumeration.Affix.Defense, 279 }, { Enumeration.Affix.AttackPercent, 7.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L48,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5241 }, { Enumeration.Affix.Attack, 172 }, { Enumeration.Affix.Defense, 283 }, { Enumeration.Affix.AttackPercent, 7.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L49,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5312 }, { Enumeration.Affix.Attack, 175 }, { Enumeration.Affix.Defense, 287 }, { Enumeration.Affix.AttackPercent, 7.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L50,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5383 }, { Enumeration.Affix.Attack, 177 }, { Enumeration.Affix.Defense, 291 }, { Enumeration.Affix.AttackPercent, 7.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L50P,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6041 }, { Enumeration.Affix.Attack, 198 }, { Enumeration.Affix.Defense, 326 }, { Enumeration.Affix.AttackPercent, 14.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L51,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6111 }, { Enumeration.Affix.Attack, 201 }, { Enumeration.Affix.Defense, 330 }, { Enumeration.Affix.AttackPercent, 14.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L52,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6183 }, { Enumeration.Affix.Attack, 203 }, { Enumeration.Affix.Defense, 334 }, { Enumeration.Affix.AttackPercent, 14.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L53,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6253 }, { Enumeration.Affix.Attack, 205 }, { Enumeration.Affix.Defense, 338 }, { Enumeration.Affix.AttackPercent, 14.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L54,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6324 }, { Enumeration.Affix.Attack, 208 }, { Enumeration.Affix.Defense, 342 }, { Enumeration.Affix.AttackPercent, 14.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L55,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6396 }, { Enumeration.Affix.Attack, 210 }, { Enumeration.Affix.Defense, 346 }, { Enumeration.Affix.AttackPercent, 14.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L56,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6467 }, { Enumeration.Affix.Attack, 212 }, { Enumeration.Affix.Defense, 350 }, { Enumeration.Affix.AttackPercent, 14.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L57,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6538 }, { Enumeration.Affix.Attack, 215 }, { Enumeration.Affix.Defense, 353 }, { Enumeration.Affix.AttackPercent, 14.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L58,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6610 }, { Enumeration.Affix.Attack, 217 }, { Enumeration.Affix.Defense, 357 }, { Enumeration.Affix.AttackPercent, 14.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L59,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6681 }, { Enumeration.Affix.Attack, 220 }, { Enumeration.Affix.Defense, 361 }, { Enumeration.Affix.AttackPercent, 14.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L60,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6752 }, { Enumeration.Affix.Attack, 222 }, { Enumeration.Affix.Defense, 365 }, { Enumeration.Affix.AttackPercent, 14.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L60P,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7246 }, { Enumeration.Affix.Attack, 238 }, { Enumeration.Affix.Defense, 392 }, { Enumeration.Affix.AttackPercent, 14.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L61,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7317 }, { Enumeration.Affix.Attack, 240 }, { Enumeration.Affix.Defense, 395 }, { Enumeration.Affix.AttackPercent, 14.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L62,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7389 }, { Enumeration.Affix.Attack, 243 }, { Enumeration.Affix.Defense, 399 }, { Enumeration.Affix.AttackPercent, 14.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L63,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7461 }, { Enumeration.Affix.Attack, 245 }, { Enumeration.Affix.Defense, 403 }, { Enumeration.Affix.AttackPercent, 14.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L64,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7532 }, { Enumeration.Affix.Attack, 247 }, { Enumeration.Affix.Defense, 407 }, { Enumeration.Affix.AttackPercent, 14.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L65,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7604 }, { Enumeration.Affix.Attack, 250 }, { Enumeration.Affix.Defense, 411 }, { Enumeration.Affix.AttackPercent, 14.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L66,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7676 }, { Enumeration.Affix.Attack, 252 }, { Enumeration.Affix.Defense, 415 }, { Enumeration.Affix.AttackPercent, 14.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L67,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7748 }, { Enumeration.Affix.Attack, 255 }, { Enumeration.Affix.Defense, 419 }, { Enumeration.Affix.AttackPercent, 14.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L68,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7820 }, { Enumeration.Affix.Attack, 257 }, { Enumeration.Affix.Defense, 423 }, { Enumeration.Affix.AttackPercent, 14.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L69,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7892 }, { Enumeration.Affix.Attack, 259 }, { Enumeration.Affix.Defense, 427 }, { Enumeration.Affix.AttackPercent, 14.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L70,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7964 }, { Enumeration.Affix.Attack, 262 }, { Enumeration.Affix.Defense, 430 }, { Enumeration.Affix.AttackPercent, 14.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L70P,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8458 }, { Enumeration.Affix.Attack, 278 }, { Enumeration.Affix.Defense, 457 }, { Enumeration.Affix.AttackPercent, 21.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L71,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8530 }, { Enumeration.Affix.Attack, 280 }, { Enumeration.Affix.Defense, 461 }, { Enumeration.Affix.AttackPercent, 21.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L72,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8603 }, { Enumeration.Affix.Attack, 283 }, { Enumeration.Affix.Defense, 465 }, { Enumeration.Affix.AttackPercent, 21.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L73,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8675 }, { Enumeration.Affix.Attack, 285 }, { Enumeration.Affix.Defense, 469 }, { Enumeration.Affix.AttackPercent, 21.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L74,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8747 }, { Enumeration.Affix.Attack, 287 }, { Enumeration.Affix.Defense, 473 }, { Enumeration.Affix.AttackPercent, 21.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L75,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8820 }, { Enumeration.Affix.Attack, 290 }, { Enumeration.Affix.Defense, 477 }, { Enumeration.Affix.AttackPercent, 21.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L76,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8892 }, { Enumeration.Affix.Attack, 292 }, { Enumeration.Affix.Defense, 481 }, { Enumeration.Affix.AttackPercent, 21.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L77,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8965 }, { Enumeration.Affix.Attack, 295 }, { Enumeration.Affix.Defense, 485 }, { Enumeration.Affix.AttackPercent, 21.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L78,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9038 }, { Enumeration.Affix.Attack, 297 }, { Enumeration.Affix.Defense, 488 }, { Enumeration.Affix.AttackPercent, 21.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L79,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9111 }, { Enumeration.Affix.Attack, 299 }, { Enumeration.Affix.Defense, 492 }, { Enumeration.Affix.AttackPercent, 21.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L80,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9184 }, { Enumeration.Affix.Attack, 302 }, { Enumeration.Affix.Defense, 496 }, { Enumeration.Affix.AttackPercent, 21.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L80P,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9677 }, { Enumeration.Affix.Attack, 318 }, { Enumeration.Affix.Defense, 523 }, { Enumeration.Affix.AttackPercent, 28.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L81,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9750 }, { Enumeration.Affix.Attack, 320 }, { Enumeration.Affix.Defense, 527 }, { Enumeration.Affix.AttackPercent, 28.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L82,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9823 }, { Enumeration.Affix.Attack, 323 }, { Enumeration.Affix.Defense, 531 }, { Enumeration.Affix.AttackPercent, 28.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L83,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9896 }, { Enumeration.Affix.Attack, 325 }, { Enumeration.Affix.Defense, 535 }, { Enumeration.Affix.AttackPercent, 28.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L84,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9969 }, { Enumeration.Affix.Attack, 328 }, { Enumeration.Affix.Defense, 539 }, { Enumeration.Affix.AttackPercent, 28.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L85,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10042 }, { Enumeration.Affix.Attack, 330 }, { Enumeration.Affix.Defense, 543 }, { Enumeration.Affix.AttackPercent, 28.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L86,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10116 }, { Enumeration.Affix.Attack, 332 }, { Enumeration.Affix.Defense, 547 }, { Enumeration.Affix.AttackPercent, 28.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L87,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10189 }, { Enumeration.Affix.Attack, 335 }, { Enumeration.Affix.Defense, 551 }, { Enumeration.Affix.AttackPercent, 28.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L88,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10262 }, { Enumeration.Affix.Attack, 337 }, { Enumeration.Affix.Defense, 555 }, { Enumeration.Affix.AttackPercent, 28.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L89,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10336 }, { Enumeration.Affix.Attack, 340 }, { Enumeration.Affix.Defense, 559 }, { Enumeration.Affix.AttackPercent, 28.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L90,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10409 }, { Enumeration.Affix.Attack, 342 }, { Enumeration.Affix.Defense, 563 }, { Enumeration.Affix.AttackPercent, 28.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L95,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10779 }, { Enumeration.Affix.Attack, 381 }, { Enumeration.Affix.Defense, 583 }, { Enumeration.Affix.AttackPercent, 28.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
            {
                Enumeration.Level.L100,
                new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 11149 }, { Enumeration.Affix.Attack, 419 }, { Enumeration.Affix.Defense, 603 }, { Enumeration.Affix.AttackPercent, 28.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, }
            },
        },
        LevelUpMaterials = CharacterLevelUpConstants.GetCharacterLevelUpMaterial(MaterialConstants10._3100705, MaterialConstants06._3060043, MaterialConstants07.G3070201, MaterialConstants04.G3040049),
        Talent1Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants05._3050041, MaterialConstants04.G3040049, MaterialConstants08.G3080058),
        Talent2Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants05._3050041, MaterialConstants04.G3040049, MaterialConstants08.G3080058),
        Talent3Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants05._3050041, MaterialConstants04.G3040049, MaterialConstants08.G3080058),
    };

    public static CharacterModel _1010115 = new()
    {
        Rid = 1010115,
        Vid = 10000129,
        Name = "洛恩",
        GoodKey = "Lohen",
        Star = 5,
        ImagePath = "/Resources/Images/Character/UI_AvatarIcon_Lohen.png",
        ElementType = Enumeration.ElementType.Cryo,
        WeaponType = Enumeration.WeaponType.Pole,
        BirthMonth = 4,
        BirthDay = 3,
        Talent = new Dictionary<int, ImageDescriptionPairModel>()
        {
            { 1, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/Skill_A_03.png", Description = "西风枪术·破誓" } },
            { 2, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/Skill_S_Lohen_01.png", Description = "奇兵诡出" } },
            { 3, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/Skill_E_Lohen_01.png", Description = "裁罚遂成" } },
        },
        Constellation = new Dictionary<int, ImageDescriptionPairModel>()
        {
            { 1, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Lohen_01.png", Description = "往昔微风，载满悲歌" } },
            { 2, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Lohen_02.png", Description = "凡飞翔者，皆为靶标" } },
            { 3, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_U_Lohen_01.png", Description = "唯有锋刃，能愈此伤" } },
            { 4, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Lohen_03.png", Description = "爱若流光，逝如欢歌" } },
            { 5, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_U_Lohen_02.png", Description = "无可窥探，无可质疑" } },
            { 6, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Lohen_04.png", Description = "身沦魂销，唯余欢悦" } },
        },
        AffixDictionary = new Dictionary<Enumeration.Level, Dictionary<Enumeration.Affix, double>>()
        {
            { Enumeration.Level.L1, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1001 }, { Enumeration.Affix.Attack, 27 }, { Enumeration.Affix.Defense, 61 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L2, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1084 }, { Enumeration.Affix.Attack, 29 }, { Enumeration.Affix.Defense, 66 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L3, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1167 }, { Enumeration.Affix.Attack, 31 }, { Enumeration.Affix.Defense, 71 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L4, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1251 }, { Enumeration.Affix.Attack, 34 }, { Enumeration.Affix.Defense, 76 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L5, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1334 }, { Enumeration.Affix.Attack, 36 }, { Enumeration.Affix.Defense, 81 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L6, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1418 }, { Enumeration.Affix.Attack, 38 }, { Enumeration.Affix.Defense, 86 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L7, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1501 }, { Enumeration.Affix.Attack, 40 }, { Enumeration.Affix.Defense, 92 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L8, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1586 }, { Enumeration.Affix.Attack, 42 }, { Enumeration.Affix.Defense, 97 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L9, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1670 }, { Enumeration.Affix.Attack, 45 }, { Enumeration.Affix.Defense, 102 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L10, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1753 }, { Enumeration.Affix.Attack, 47 }, { Enumeration.Affix.Defense, 107 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L11, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1837 }, { Enumeration.Affix.Attack, 49 }, { Enumeration.Affix.Defense, 112 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L12, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1921 }, { Enumeration.Affix.Attack, 51 }, { Enumeration.Affix.Defense, 117 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L13, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2005 }, { Enumeration.Affix.Attack, 54 }, { Enumeration.Affix.Defense, 122 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L14, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2090 }, { Enumeration.Affix.Attack, 56 }, { Enumeration.Affix.Defense, 127 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L15, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2174 }, { Enumeration.Affix.Attack, 58 }, { Enumeration.Affix.Defense, 133 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L16, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2258 }, { Enumeration.Affix.Attack, 60 }, { Enumeration.Affix.Defense, 138 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L17, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2343 }, { Enumeration.Affix.Attack, 63 }, { Enumeration.Affix.Defense, 143 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L18, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2427 }, { Enumeration.Affix.Attack, 65 }, { Enumeration.Affix.Defense, 148 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L19, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2512 }, { Enumeration.Affix.Attack, 67 }, { Enumeration.Affix.Defense, 153 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L20, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2597 }, { Enumeration.Affix.Attack, 70 }, { Enumeration.Affix.Defense, 158 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L20P, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3455 }, { Enumeration.Affix.Attack, 93 }, { Enumeration.Affix.Defense, 211 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L21, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3540 }, { Enumeration.Affix.Attack, 95 }, { Enumeration.Affix.Defense, 216 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L22, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3625 }, { Enumeration.Affix.Attack, 97 }, { Enumeration.Affix.Defense, 221 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L23, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3710 }, { Enumeration.Affix.Attack, 99 }, { Enumeration.Affix.Defense, 226 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L24, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3795 }, { Enumeration.Affix.Attack, 102 }, { Enumeration.Affix.Defense, 231 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L25, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3880 }, { Enumeration.Affix.Attack, 104 }, { Enumeration.Affix.Defense, 237 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L26, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3966 }, { Enumeration.Affix.Attack, 106 }, { Enumeration.Affix.Defense, 242 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L27, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4051 }, { Enumeration.Affix.Attack, 109 }, { Enumeration.Affix.Defense, 247 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L28, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4136 }, { Enumeration.Affix.Attack, 111 }, { Enumeration.Affix.Defense, 252 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L29, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4223 }, { Enumeration.Affix.Attack, 113 }, { Enumeration.Affix.Defense, 257 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L30, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4308 }, { Enumeration.Affix.Attack, 115 }, { Enumeration.Affix.Defense, 263 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L31, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4394 }, { Enumeration.Affix.Attack, 118 }, { Enumeration.Affix.Defense, 268 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L32, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4480 }, { Enumeration.Affix.Attack, 120 }, { Enumeration.Affix.Defense, 273 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L33, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4566 }, { Enumeration.Affix.Attack, 122 }, { Enumeration.Affix.Defense, 278 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L34, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4651 }, { Enumeration.Affix.Attack, 125 }, { Enumeration.Affix.Defense, 284 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L35, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4737 }, { Enumeration.Affix.Attack, 127 }, { Enumeration.Affix.Defense, 289 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L36, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4824 }, { Enumeration.Affix.Attack, 129 }, { Enumeration.Affix.Defense, 294 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L37, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4910 }, { Enumeration.Affix.Attack, 132 }, { Enumeration.Affix.Defense, 299 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L38, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4996 }, { Enumeration.Affix.Attack, 134 }, { Enumeration.Affix.Defense, 305 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L39, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5082 }, { Enumeration.Affix.Attack, 136 }, { Enumeration.Affix.Defense, 310 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L40, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5170 }, { Enumeration.Affix.Attack, 138 }, { Enumeration.Affix.Defense, 315 }, { Enumeration.Affix.CriticalDamage, 50.0 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L40P, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5779 }, { Enumeration.Affix.Attack, 155 }, { Enumeration.Affix.Defense, 352 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L41, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5865 }, { Enumeration.Affix.Attack, 157 }, { Enumeration.Affix.Defense, 358 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L42, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5952 }, { Enumeration.Affix.Attack, 159 }, { Enumeration.Affix.Defense, 363 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L43, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6040 }, { Enumeration.Affix.Attack, 162 }, { Enumeration.Affix.Defense, 368 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L44, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6126 }, { Enumeration.Affix.Attack, 164 }, { Enumeration.Affix.Defense, 373 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L45, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6213 }, { Enumeration.Affix.Attack, 166 }, { Enumeration.Affix.Defense, 379 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L46, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6300 }, { Enumeration.Affix.Attack, 169 }, { Enumeration.Affix.Defense, 384 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L47, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6387 }, { Enumeration.Affix.Attack, 171 }, { Enumeration.Affix.Defense, 389 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L48, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6474 }, { Enumeration.Affix.Attack, 173 }, { Enumeration.Affix.Defense, 395 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L49, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6562 }, { Enumeration.Affix.Attack, 176 }, { Enumeration.Affix.Defense, 400 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L50, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6649 }, { Enumeration.Affix.Attack, 178 }, { Enumeration.Affix.Defense, 405 }, { Enumeration.Affix.CriticalDamage, 59.6 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L50P, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7462 }, { Enumeration.Affix.Attack, 200 }, { Enumeration.Affix.Defense, 455 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L51, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7549 }, { Enumeration.Affix.Attack, 202 }, { Enumeration.Affix.Defense, 460 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L52, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7637 }, { Enumeration.Affix.Attack, 205 }, { Enumeration.Affix.Defense, 466 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L53, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7725 }, { Enumeration.Affix.Attack, 207 }, { Enumeration.Affix.Defense, 471 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L54, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7813 }, { Enumeration.Affix.Attack, 209 }, { Enumeration.Affix.Defense, 476 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L55, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7901 }, { Enumeration.Affix.Attack, 212 }, { Enumeration.Affix.Defense, 482 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L56, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7989 }, { Enumeration.Affix.Attack, 214 }, { Enumeration.Affix.Defense, 487 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L57, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8077 }, { Enumeration.Affix.Attack, 216 }, { Enumeration.Affix.Defense, 492 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L58, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8165 }, { Enumeration.Affix.Attack, 219 }, { Enumeration.Affix.Defense, 498 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L59, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8253 }, { Enumeration.Affix.Attack, 221 }, { Enumeration.Affix.Defense, 503 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L60, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8341 }, { Enumeration.Affix.Attack, 223 }, { Enumeration.Affix.Defense, 509 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L60P, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8951 }, { Enumeration.Affix.Attack, 240 }, { Enumeration.Affix.Defense, 546 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L61, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9039 }, { Enumeration.Affix.Attack, 242 }, { Enumeration.Affix.Defense, 551 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L62, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9127 }, { Enumeration.Affix.Attack, 244 }, { Enumeration.Affix.Defense, 556 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L63, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9216 }, { Enumeration.Affix.Attack, 247 }, { Enumeration.Affix.Defense, 562 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L64, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9304 }, { Enumeration.Affix.Attack, 249 }, { Enumeration.Affix.Defense, 567 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L65, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9393 }, { Enumeration.Affix.Attack, 252 }, { Enumeration.Affix.Defense, 573 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L66, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9482 }, { Enumeration.Affix.Attack, 254 }, { Enumeration.Affix.Defense, 578 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L67, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9571 }, { Enumeration.Affix.Attack, 256 }, { Enumeration.Affix.Defense, 583 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L68, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9660 }, { Enumeration.Affix.Attack, 259 }, { Enumeration.Affix.Defense, 589 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L69, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9749 }, { Enumeration.Affix.Attack, 261 }, { Enumeration.Affix.Defense, 594 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L70, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9838 }, { Enumeration.Affix.Attack, 264 }, { Enumeration.Affix.Defense, 600 }, { Enumeration.Affix.CriticalDamage, 69.2 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L70P, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10448 }, { Enumeration.Affix.Attack, 280 }, { Enumeration.Affix.Defense, 637 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L71, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10537 }, { Enumeration.Affix.Attack, 282 }, { Enumeration.Affix.Defense, 642 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L72, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10627 }, { Enumeration.Affix.Attack, 285 }, { Enumeration.Affix.Defense, 648 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L73, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10716 }, { Enumeration.Affix.Attack, 287 }, { Enumeration.Affix.Defense, 653 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L74, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10805 }, { Enumeration.Affix.Attack, 289 }, { Enumeration.Affix.Defense, 659 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L75, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10895 }, { Enumeration.Affix.Attack, 292 }, { Enumeration.Affix.Defense, 664 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L76, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10984 }, { Enumeration.Affix.Attack, 294 }, { Enumeration.Affix.Defense, 670 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L77, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 11074 }, { Enumeration.Affix.Attack, 297 }, { Enumeration.Affix.Defense, 675 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L78, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 11164 }, { Enumeration.Affix.Attack, 299 }, { Enumeration.Affix.Defense, 681 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L79, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 11254 }, { Enumeration.Affix.Attack, 301 }, { Enumeration.Affix.Defense, 686 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L80, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 11345 }, { Enumeration.Affix.Attack, 304 }, { Enumeration.Affix.Defense, 692 }, { Enumeration.Affix.CriticalDamage, 78.8 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L80P, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 11954 }, { Enumeration.Affix.Attack, 320 }, { Enumeration.Affix.Defense, 729 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L81, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 12044 }, { Enumeration.Affix.Attack, 323 }, { Enumeration.Affix.Defense, 734 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L82, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 12134 }, { Enumeration.Affix.Attack, 325 }, { Enumeration.Affix.Defense, 740 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L83, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 12225 }, { Enumeration.Affix.Attack, 327 }, { Enumeration.Affix.Defense, 745 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L84, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 12315 }, { Enumeration.Affix.Attack, 330 }, { Enumeration.Affix.Defense, 751 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L85, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 12405 }, { Enumeration.Affix.Attack, 332 }, { Enumeration.Affix.Defense, 756 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L86, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 12496 }, { Enumeration.Affix.Attack, 335 }, { Enumeration.Affix.Defense, 762 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L87, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 12586 }, { Enumeration.Affix.Attack, 337 }, { Enumeration.Affix.Defense, 767 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L88, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 12677 }, { Enumeration.Affix.Attack, 340 }, { Enumeration.Affix.Defense, 773 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L89, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 12768 }, { Enumeration.Affix.Attack, 342 }, { Enumeration.Affix.Defense, 778 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L90, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 12858 }, { Enumeration.Affix.Attack, 344 }, { Enumeration.Affix.Defense, 784 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L95, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 13315 }, { Enumeration.Affix.Attack, 383 }, { Enumeration.Affix.Defense, 812 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
            { Enumeration.Level.L100, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 13772 }, { Enumeration.Affix.Attack, 422 }, { Enumeration.Affix.Defense, 840 }, { Enumeration.Affix.CriticalDamage, 88.4 }, { Enumeration.Affix.CriticalRate, 5.0 }, } },
        },
        LevelUpMaterials = CharacterLevelUpConstants.GetCharacterLevelUpMaterial(MaterialConstants10._3100109, MaterialConstants06._3060044, MaterialConstants07.G3070701, MaterialConstants04.G3040010),
        Talent1Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants05._3050035, MaterialConstants04.G3040010, MaterialConstants08.G3080004),
        Talent2Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants05._3050035, MaterialConstants04.G3040010, MaterialConstants08.G3080004),
        Talent3Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants05._3050035, MaterialConstants04.G3040010, MaterialConstants08.G3080004),
    };

    public static CharacterModel _1010116 = new()
    {
        Rid = 1010116,
        Vid = 10000133,
        Name = "桑多涅",
        GoodKey = "Sandrone",
        Star = 5,
        ImagePath = "/Resources/Images/Character/UI_AvatarIcon_MarionetteNew.png",
        ElementType = Enumeration.ElementType.Cryo,
        WeaponType = Enumeration.WeaponType.Claymore,
        BirthMonth = 1,
        BirthDay = 13,
        Talent = new Dictionary<int, ImageDescriptionPairModel>()
        {
            { 1, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/Skill_A_04.png", Description = "事象数式·自明演绎" } },
            { 2, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/Skill_S_MarionetteNew_01.png", Description = "事象数式·游衍解析" } },
            { 3, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/Skill_E_MarionetteNew_01.png", Description = "事象数式·万理证毕" } },
        },
        Constellation = new Dictionary<int, ImageDescriptionPairModel>()
        {
            { 1, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_MarionetteNew_01.png", Description = "鎏金未凋，夕暮已远" } },
            { 2, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_MarionetteNew_02.png", Description = "回望镜中，时岁翩然" } },
            { 3, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_U_MarionetteNew_01.png", Description = "不叹日落，不羡月升" } },
            { 4, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_MarionetteNew_03.png", Description = "世事皆数，昼来夜往" } },
            { 5, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_U_MarionetteNew_02.png", Description = "万象皆灰，唯理明畅" } },
            { 6, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_MarionetteNew_04.png", Description = "水仙梦醒，且望晨光" } },
        },
        AffixDictionary = new Dictionary<Enumeration.Level, Dictionary<Enumeration.Affix, double>>()
        {
            { Enumeration.Level.L1, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1030 }, { Enumeration.Affix.Attack, 27 }, { Enumeration.Affix.Defense, 59 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L2, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1115 }, { Enumeration.Affix.Attack, 29 }, { Enumeration.Affix.Defense, 63 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L3, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1200 }, { Enumeration.Affix.Attack, 31 }, { Enumeration.Affix.Defense, 68 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L4, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1287 }, { Enumeration.Affix.Attack, 33 }, { Enumeration.Affix.Defense, 73 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L5, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1372 }, { Enumeration.Affix.Attack, 35 }, { Enumeration.Affix.Defense, 78 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L6, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1459 }, { Enumeration.Affix.Attack, 38 }, { Enumeration.Affix.Defense, 83 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L7, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1544 }, { Enumeration.Affix.Attack, 40 }, { Enumeration.Affix.Defense, 88 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L8, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1631 }, { Enumeration.Affix.Attack, 42 }, { Enumeration.Affix.Defense, 93 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L9, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1717 }, { Enumeration.Affix.Attack, 44 }, { Enumeration.Affix.Defense, 98 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L10, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1803 }, { Enumeration.Affix.Attack, 47 }, { Enumeration.Affix.Defense, 103 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L11, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1889 }, { Enumeration.Affix.Attack, 49 }, { Enumeration.Affix.Defense, 107 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L12, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1976 }, { Enumeration.Affix.Attack, 51 }, { Enumeration.Affix.Defense, 112 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L13, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2062 }, { Enumeration.Affix.Attack, 53 }, { Enumeration.Affix.Defense, 117 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L14, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2150 }, { Enumeration.Affix.Attack, 56 }, { Enumeration.Affix.Defense, 122 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L15, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2236 }, { Enumeration.Affix.Attack, 58 }, { Enumeration.Affix.Defense, 127 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L16, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2323 }, { Enumeration.Affix.Attack, 60 }, { Enumeration.Affix.Defense, 132 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L17, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2410 }, { Enumeration.Affix.Attack, 62 }, { Enumeration.Affix.Defense, 137 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L18, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2497 }, { Enumeration.Affix.Attack, 65 }, { Enumeration.Affix.Defense, 142 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L19, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2584 }, { Enumeration.Affix.Attack, 67 }, { Enumeration.Affix.Defense, 147 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L20, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 2671 }, { Enumeration.Affix.Attack, 69 }, { Enumeration.Affix.Defense, 152 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L20P, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3554 }, { Enumeration.Affix.Attack, 92 }, { Enumeration.Affix.Defense, 202 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L21, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3641 }, { Enumeration.Affix.Attack, 94 }, { Enumeration.Affix.Defense, 207 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L22, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3729 }, { Enumeration.Affix.Attack, 96 }, { Enumeration.Affix.Defense, 212 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L23, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3816 }, { Enumeration.Affix.Attack, 99 }, { Enumeration.Affix.Defense, 217 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L24, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3904 }, { Enumeration.Affix.Attack, 101 }, { Enumeration.Affix.Defense, 222 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L25, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 3991 }, { Enumeration.Affix.Attack, 103 }, { Enumeration.Affix.Defense, 227 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L26, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4080 }, { Enumeration.Affix.Attack, 106 }, { Enumeration.Affix.Defense, 232 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L27, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4167 }, { Enumeration.Affix.Attack, 108 }, { Enumeration.Affix.Defense, 237 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L28, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4255 }, { Enumeration.Affix.Attack, 110 }, { Enumeration.Affix.Defense, 242 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L29, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4343 }, { Enumeration.Affix.Attack, 112 }, { Enumeration.Affix.Defense, 247 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L30, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4431 }, { Enumeration.Affix.Attack, 115 }, { Enumeration.Affix.Defense, 252 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L31, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4519 }, { Enumeration.Affix.Attack, 117 }, { Enumeration.Affix.Defense, 257 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L32, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4608 }, { Enumeration.Affix.Attack, 119 }, { Enumeration.Affix.Defense, 262 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L33, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4696 }, { Enumeration.Affix.Attack, 121 }, { Enumeration.Affix.Defense, 267 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L34, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4784 }, { Enumeration.Affix.Attack, 124 }, { Enumeration.Affix.Defense, 272 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L35, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4872 }, { Enumeration.Affix.Attack, 126 }, { Enumeration.Affix.Defense, 277 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L36, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 4962 }, { Enumeration.Affix.Attack, 128 }, { Enumeration.Affix.Defense, 282 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L37, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5051 }, { Enumeration.Affix.Attack, 131 }, { Enumeration.Affix.Defense, 287 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L38, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5139 }, { Enumeration.Affix.Attack, 133 }, { Enumeration.Affix.Defense, 292 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L39, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5228 }, { Enumeration.Affix.Attack, 135 }, { Enumeration.Affix.Defense, 297 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L40, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5317 }, { Enumeration.Affix.Attack, 138 }, { Enumeration.Affix.Defense, 302 }, { Enumeration.Affix.CriticalRate, 5.0 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L40P, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 5944 }, { Enumeration.Affix.Attack, 154 }, { Enumeration.Affix.Defense, 338 }, { Enumeration.Affix.CriticalRate, 9.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L41, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6033 }, { Enumeration.Affix.Attack, 156 }, { Enumeration.Affix.Defense, 343 }, { Enumeration.Affix.CriticalRate, 9.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L42, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6123 }, { Enumeration.Affix.Attack, 158 }, { Enumeration.Affix.Defense, 348 }, { Enumeration.Affix.CriticalRate, 9.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L43, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6212 }, { Enumeration.Affix.Attack, 161 }, { Enumeration.Affix.Defense, 353 }, { Enumeration.Affix.CriticalRate, 9.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L44, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6301 }, { Enumeration.Affix.Attack, 163 }, { Enumeration.Affix.Defense, 358 }, { Enumeration.Affix.CriticalRate, 9.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L45, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6390 }, { Enumeration.Affix.Attack, 165 }, { Enumeration.Affix.Defense, 364 }, { Enumeration.Affix.CriticalRate, 9.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L46, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6480 }, { Enumeration.Affix.Attack, 168 }, { Enumeration.Affix.Defense, 369 }, { Enumeration.Affix.CriticalRate, 9.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L47, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6569 }, { Enumeration.Affix.Attack, 170 }, { Enumeration.Affix.Defense, 374 }, { Enumeration.Affix.CriticalRate, 9.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L48, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6659 }, { Enumeration.Affix.Attack, 172 }, { Enumeration.Affix.Defense, 379 }, { Enumeration.Affix.CriticalRate, 9.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L49, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6750 }, { Enumeration.Affix.Attack, 175 }, { Enumeration.Affix.Defense, 384 }, { Enumeration.Affix.CriticalRate, 9.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L50, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 6839 }, { Enumeration.Affix.Attack, 177 }, { Enumeration.Affix.Defense, 389 }, { Enumeration.Affix.CriticalRate, 9.8 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L50P, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7675 }, { Enumeration.Affix.Attack, 198 }, { Enumeration.Affix.Defense, 437 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L51, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7765 }, { Enumeration.Affix.Attack, 201 }, { Enumeration.Affix.Defense, 442 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L52, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7856 }, { Enumeration.Affix.Attack, 203 }, { Enumeration.Affix.Defense, 447 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L53, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 7945 }, { Enumeration.Affix.Attack, 205 }, { Enumeration.Affix.Defense, 452 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L54, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8036 }, { Enumeration.Affix.Attack, 208 }, { Enumeration.Affix.Defense, 457 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L55, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8126 }, { Enumeration.Affix.Attack, 210 }, { Enumeration.Affix.Defense, 462 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L56, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8217 }, { Enumeration.Affix.Attack, 212 }, { Enumeration.Affix.Defense, 467 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L57, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8308 }, { Enumeration.Affix.Attack, 215 }, { Enumeration.Affix.Defense, 473 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L58, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8398 }, { Enumeration.Affix.Attack, 217 }, { Enumeration.Affix.Defense, 478 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L59, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8489 }, { Enumeration.Affix.Attack, 220 }, { Enumeration.Affix.Defense, 483 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L60, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 8579 }, { Enumeration.Affix.Attack, 222 }, { Enumeration.Affix.Defense, 488 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L60P, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9207 }, { Enumeration.Affix.Attack, 238 }, { Enumeration.Affix.Defense, 524 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L61, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9297 }, { Enumeration.Affix.Attack, 240 }, { Enumeration.Affix.Defense, 529 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L62, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9388 }, { Enumeration.Affix.Attack, 243 }, { Enumeration.Affix.Defense, 534 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L63, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9480 }, { Enumeration.Affix.Attack, 245 }, { Enumeration.Affix.Defense, 539 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L64, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9570 }, { Enumeration.Affix.Attack, 247 }, { Enumeration.Affix.Defense, 544 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L65, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9662 }, { Enumeration.Affix.Attack, 250 }, { Enumeration.Affix.Defense, 550 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L66, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9753 }, { Enumeration.Affix.Attack, 252 }, { Enumeration.Affix.Defense, 555 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L67, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9844 }, { Enumeration.Affix.Attack, 255 }, { Enumeration.Affix.Defense, 560 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L68, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 9936 }, { Enumeration.Affix.Attack, 257 }, { Enumeration.Affix.Defense, 565 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L69, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10027 }, { Enumeration.Affix.Attack, 259 }, { Enumeration.Affix.Defense, 570 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L70, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10119 }, { Enumeration.Affix.Attack, 262 }, { Enumeration.Affix.Defense, 576 }, { Enumeration.Affix.CriticalRate, 14.6 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L70P, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10746 }, { Enumeration.Affix.Attack, 278 }, { Enumeration.Affix.Defense, 611 }, { Enumeration.Affix.CriticalRate, 19.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L71, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10838 }, { Enumeration.Affix.Attack, 280 }, { Enumeration.Affix.Defense, 617 }, { Enumeration.Affix.CriticalRate, 19.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L72, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 10930 }, { Enumeration.Affix.Attack, 283 }, { Enumeration.Affix.Defense, 622 }, { Enumeration.Affix.CriticalRate, 19.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L73, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 11022 }, { Enumeration.Affix.Attack, 285 }, { Enumeration.Affix.Defense, 627 }, { Enumeration.Affix.CriticalRate, 19.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L74, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 11114 }, { Enumeration.Affix.Attack, 287 }, { Enumeration.Affix.Defense, 632 }, { Enumeration.Affix.CriticalRate, 19.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L75, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 11206 }, { Enumeration.Affix.Attack, 290 }, { Enumeration.Affix.Defense, 638 }, { Enumeration.Affix.CriticalRate, 19.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L76, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 11298 }, { Enumeration.Affix.Attack, 292 }, { Enumeration.Affix.Defense, 643 }, { Enumeration.Affix.CriticalRate, 19.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L77, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 11391 }, { Enumeration.Affix.Attack, 295 }, { Enumeration.Affix.Defense, 648 }, { Enumeration.Affix.CriticalRate, 19.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L78, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 11483 }, { Enumeration.Affix.Attack, 297 }, { Enumeration.Affix.Defense, 653 }, { Enumeration.Affix.CriticalRate, 19.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L79, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 11576 }, { Enumeration.Affix.Attack, 299 }, { Enumeration.Affix.Defense, 659 }, { Enumeration.Affix.CriticalRate, 19.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L80, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 11669 }, { Enumeration.Affix.Attack, 302 }, { Enumeration.Affix.Defense, 664 }, { Enumeration.Affix.CriticalRate, 19.4 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L80P, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 12296 }, { Enumeration.Affix.Attack, 318 }, { Enumeration.Affix.Defense, 700 }, { Enumeration.Affix.CriticalRate, 24.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L81, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 12389 }, { Enumeration.Affix.Attack, 320 }, { Enumeration.Affix.Defense, 705 }, { Enumeration.Affix.CriticalRate, 24.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L82, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 12481 }, { Enumeration.Affix.Attack, 323 }, { Enumeration.Affix.Defense, 710 }, { Enumeration.Affix.CriticalRate, 24.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L83, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 12574 }, { Enumeration.Affix.Attack, 325 }, { Enumeration.Affix.Defense, 715 }, { Enumeration.Affix.CriticalRate, 24.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L84, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 12667 }, { Enumeration.Affix.Attack, 328 }, { Enumeration.Affix.Defense, 721 }, { Enumeration.Affix.CriticalRate, 24.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L85, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 12759 }, { Enumeration.Affix.Attack, 330 }, { Enumeration.Affix.Defense, 726 }, { Enumeration.Affix.CriticalRate, 24.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L86, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 12853 }, { Enumeration.Affix.Attack, 332 }, { Enumeration.Affix.Defense, 731 }, { Enumeration.Affix.CriticalRate, 24.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L87, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 12946 }, { Enumeration.Affix.Attack, 335 }, { Enumeration.Affix.Defense, 736 }, { Enumeration.Affix.CriticalRate, 24.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L88, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 13039 }, { Enumeration.Affix.Attack, 337 }, { Enumeration.Affix.Defense, 742 }, { Enumeration.Affix.CriticalRate, 24.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L89, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 13133 }, { Enumeration.Affix.Attack, 340 }, { Enumeration.Affix.Defense, 747 }, { Enumeration.Affix.CriticalRate, 24.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L90, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 13226 }, { Enumeration.Affix.Attack, 342 }, { Enumeration.Affix.Defense, 752 }, { Enumeration.Affix.CriticalRate, 24.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L95, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 13695 }, { Enumeration.Affix.Attack, 381 }, { Enumeration.Affix.Defense, 779 }, { Enumeration.Affix.CriticalRate, 24.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
            { Enumeration.Level.L100, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 14166 }, { Enumeration.Affix.Attack, 419 }, { Enumeration.Affix.Defense, 806 }, { Enumeration.Affix.CriticalRate, 24.2 }, { Enumeration.Affix.CriticalDamage, 50.0 }, } },
        },
        LevelUpMaterials = CharacterLevelUpConstants.GetCharacterLevelUpMaterial(MaterialConstants10._3100507, MaterialConstants06._3060045, MaterialConstants07.G3070701, MaterialConstants04.G3040046),
        Talent1Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants05._3050039, MaterialConstants04.G3040046, MaterialConstants08.G3080061),
        Talent2Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants05._3050039, MaterialConstants04.G3040046, MaterialConstants08.G3080061),
        Talent3Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants05._3050039, MaterialConstants04.G3040046, MaterialConstants08.G3080061),
    };
}