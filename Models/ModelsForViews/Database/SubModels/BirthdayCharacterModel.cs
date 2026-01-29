namespace HexereiKatepnha.Models.ModelsForViews.Database.SubModels;

public class BirthdayCharacterModel
{
    public string ImagePath { get; set; } = "";
    public string BackgroundPath { get; set; } = "";
    public string StarImagePath { get; set; } = "";
    public string ElementImagePath { get; set; } = "";
    public string Name { get; set; } = "";
    public string BirthdayString { get; set; } = "";
    public bool IsTodayBirthday { get; set; } = false;
    public bool IsNotTodayBirthday { get; set; } = true;
}