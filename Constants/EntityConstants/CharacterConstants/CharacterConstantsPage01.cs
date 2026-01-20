using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.EntityModels;

namespace HexereiKatepnha.Constants.EntityConstants.CharacterConstants;

public class CharacterConstantsPage01
{
    public static CharacterModel _1010100 = new()
    {
        Rid = 1010100,
        Vid = 10000100,
        Name = "卡齐娜",
        Star = 4,
        ImagePath = "/Resources/Images/Character/UI_AvatarIcon_Kachina.png",
        ElementType = Enumeration.ElementType.Geo,
        WeaponType = Enumeration.WeaponType.Pole,
        BirthMonth = 4,
        BirthDay = 22,
        Talent = new Dictionary<int, ImageDescriptionPairModel>()
        {
            { 1, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/Skill_A_03.png", Description = "嵴之啮咬" } },
            { 2, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/Skill_S_Kachina_01.png", Description = "出击，冲天转转！" } },
            { 3, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/Skill_E_Kachina_01.png", Description = "现在，认真时间！" } },
        },
        Ascension = new Dictionary<int, ImageDescriptionPairModel>()
        {
            { 1, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Kachina_01.png", Description = "晶片，也是一种宝石" } },
            { 2, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Kachina_02.png", Description = "不能少了…冲天转转" } },
            { 3, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_U_Kachina_01.png", Description = "改良型·平衡稳定器" } },
            { 4, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Kachina_03.png", Description = "敌人越多，越要小心" } },
            { 5, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_U_Kachina_02.png", Description = "迄今为止，所有收藏" } },
            { 6, new ImageDescriptionPairModel() { ImagePath = "/Resources/Images/CharacterSkillTalent/UI_Talent_S_Kachina_04.png", Description = "这一次，我一定要赢" } },
        },
        AffixDictionary = new Dictionary<Enumeration.Level, Dictionary<Enumeration.Affix, double>>()
        {
            { Enumeration.Level.L1, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 989 }, { Enumeration.Affix.Attack, 18 }, { Enumeration.Affix.Defense, 66 }, { Enumeration.Affix.GeoDamage, 0 } } },
            { Enumeration.Level.L2, new Dictionary<Enumeration.Affix, double>() { { Enumeration.Affix.Health, 1071 }, { Enumeration.Affix.Attack, 20 }, { Enumeration.Affix.Defense, 72 }, { Enumeration.Affix.GeoDamage, 0 } } },
        },
        LevelUpMaterials = CharacterLevelUpConstants.GetCharacterLevelUpMaterial(MaterialConstants._3100603, MaterialConstants._3060033, MaterialConstants.G3070801, MaterialConstants.G3040043),
        Talent1Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants._3050028, MaterialConstants.G3040043, MaterialConstants.G3080052),
        Talent2Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants._3050028, MaterialConstants.G3040043, MaterialConstants.G3080052),
        Talent3Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants._3050028, MaterialConstants.G3040043, MaterialConstants.G3080052),
    };
}