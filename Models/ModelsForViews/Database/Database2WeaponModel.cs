using HexereiKatepnha.Models.ModelsForViews.Database.SubModels;

namespace HexereiKatepnha.Models.ModelsForViews.Database;

public class Database2WeaponModel
{
    public int Vid { get; set; }
    public string Name { get; set; } = "";
    public string ImagePath { get; set; } = "";
    public string AwakenImagePath { get; set; } = "";
    public string BackgroundImagePath { get; set; } = "";
    public string StarImagePath { get; set; } = "";
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