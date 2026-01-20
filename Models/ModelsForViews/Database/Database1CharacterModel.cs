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

}