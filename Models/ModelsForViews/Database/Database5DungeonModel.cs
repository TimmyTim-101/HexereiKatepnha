using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Models.ModelsForViews.Database.SubModels;

namespace HexereiKatepnha.Models.ModelsForViews.Database;

public class Database5DungeonModel
{
    public string Name { get; set; } = "";
    public string ImagePath { get; set; } = "";
    public int Cost { get; set; }
    public string TimeString { get; set; } = "";
    public List<DungeonDropItemModel> DropItemList { get; set; } = [];
    public string ResinImagePath { get; set; } = StringConstants.ResinImagePath;
}