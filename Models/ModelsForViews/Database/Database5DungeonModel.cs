using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;

namespace HexereiKatepnha.Models.ModelsForViews.Database;

public class Database5DungeonModel
{
    public string Name { get; set; } = "";
    public string ImagePath { get; set; } = "";
    public int Cost { get; set; }
    public string TimeString { get; set; } = "";
    public List<DungeonDropItemModel> DropItemList { get; set; } = [];
    public bool IsCost => Cost != 0;
    public int DropHeight { get; set; } = 142;
    public string ResinImagePath { get; set; } = StringConstants.ResinImagePath;
    public bool IsTimeLimit { get; set; }
}

public class DungeonDropItemModel
{
    public string MaterialName { get; set; } = "";
    public string MaterialImagePath { get; set; } = "";
    public string MaterialStarImagePath { get; set; } = "";
    public double DropNum { get; set; }
    public bool IsShow { get; set; } = true;
}