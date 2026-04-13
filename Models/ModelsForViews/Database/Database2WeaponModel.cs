using HexereiKatepnha.Constants.EntityConstants;

namespace HexereiKatepnha.Models.ModelsForViews.Database;

public class Database2WeaponModel
{
    public int Vid { get; set; }
    public string Name { get; set; } = "";
    public string ImagePath { get; set; } = "";
    public string AwakenImagePath { get; set; } = "";
    public string BackgroundImagePath { get; set; } = "";
    public int Star { get; set; }
    public string StarImagePath { get; set; } = "";
    public Enumeration.WeaponType WeaponType { get; set; } = Enumeration.WeaponType.Unknown;
    public string WeaponTypeName { get; set; } = "";
    public string WeaponTypeImagePath { get; set; } = "";
    public string SubAffixName { get; set; } = "";
    public List<DungeonDropItemModel> NeedMaterialList { get; set; } = [];
    public string Progression1 { get; set; } = "";
    public string Progression2 { get; set; } = "";
    public string Progression3 { get; set; } = "";
    public string Progression4 { get; set; } = "";
    public string Progression5 { get; set; } = "";
    public List<WeaponLevelStatModel> SimpleLevelStatTable { get; set; } = [];
    public List<WeaponLevelStatModel> FullLevelStatTable { get; set; } = [];
}

public class WeaponLevelStatModel
{
    public string S1 { get; set; } = "";
    public string S2 { get; set; } = "";
    public string S3 { get; set; } = "";
}