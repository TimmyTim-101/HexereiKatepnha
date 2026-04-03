using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Models.ModelsForViews.Database.SubModels;

namespace HexereiKatepnha.Models.ModelsForViews.Database;

public class Database1CharacterModel
{
    public string ImagePath { get; set; } = "";
    public Enumeration.ElementType ElementType { get; set; } = Enumeration.ElementType.Unknown;
    public string ElementImagePath { get; set; } = "";
    public string BackgroundImagePath { get; set; } = "";
    public string Name { get; set; } = "";
    public int Vid { get; set; }
    public int Star { get; set; }
    public string StarImagePath { get; set; } = "";
    public string BirthdayString { get; set; } = "";
    public Enumeration.WeaponType WeaponType { get; set; } = Enumeration.WeaponType.Unknown;
    public string WeaponTypeName { get; set; } = "";
    public string WeaponTypeImagePath { get; set; } = "";
    public List<DungeonDropItemModel> NeedMaterialList { get; set; } = [];
    public string Talent1ImagePath { get; set; } = "";
    public string Talent1Description { get; set; } = "";
    public string Talent2ImagePath { get; set; } = "";
    public string Talent2Description { get; set; } = "";
    public string Talent3ImagePath { get; set; } = "";
    public string Talent3Description { get; set; } = "";
    public string Ascension1ImagePath { get; set; } = "";
    public string Ascension1Description { get; set; } = "";
    public string Ascension2ImagePath { get; set; } = "";
    public string Ascension2Description { get; set; } = "";
    public string Ascension3ImagePath { get; set; } = "";
    public string Ascension3Description { get; set; } = "";
    public string Ascension4ImagePath { get; set; } = "";
    public string Ascension4Description { get; set; } = "";
    public string Ascension5ImagePath { get; set; } = "";
    public string Ascension5Description { get; set; } = "";
    public string Ascension6ImagePath { get; set; } = "";
    public string Ascension6Description { get; set; } = "";

    public List<CharacterStatModel> SimpleLevelStatTable { get; set; } = [];
    public List<CharacterStatModel> FullLevelStatTable { get; set; } = [];
}

public class CharacterStatModel
{
    public string S1 { get; set; } = "";
    public string S2 { get; set; } = "";
    public string S3 { get; set; } = "";
    public string S4 { get; set; } = "";
    public string S5 { get; set; } = "";
    public string S6 { get; set; } = "";
    public string S7 { get; set; } = "";
    public bool HasS7 => !string.IsNullOrEmpty(S7);
}