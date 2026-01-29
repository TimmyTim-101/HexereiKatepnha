using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.ModelsForViews.Database.SubModels;

namespace HexereiKatepnha.Models.ModelsForViews.Database;

public class Database1CharacterModel
{
    public string ImagePath { get; set; } = "";
    public string ElementImagePath { get; set; } = "";
    public string BackgroundImagePath { get; set; } = "";
    public string Name { get; set; } = "";
    public int Vid { get; set; }
    public string StarImagePath { get; set; } = "";
    public string BirthdayString { get; set; } = "";
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

    public List<List<string>> SimpleLevelStatTable { get; set; } = [];
    public List<List<string>> FullLevelStatTable { get; set; } = [];
}