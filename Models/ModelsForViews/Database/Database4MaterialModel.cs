namespace HexereiKatepnha.Models.ModelsForViews.Database;

public class Database4MaterialModel
{
    public int Vid { get; set; }
    public string Name { get; set; } = "";
    public string ImagePath { get; set; } = "";
    public string BackgroundImagePath { get; set; } = "";
    public string StarImagePath { get; set; } = "";
}

public class Database4MaterialGroupModel
{
    public string CategoryName { get; set; } = "";
    public List<Database4MaterialModel> ItemList { get; set; } = [];
}