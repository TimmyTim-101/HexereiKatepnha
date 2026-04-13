namespace HexereiKatepnha.Models.ModelsForViews;

public class BirthdayCharacterModel
{
    public string ImagePath { get; set; } = "";
    public string BackgroundPath { get; set; } = "";
    public string StarImagePath { get; set; } = "";
    public string ElementImagePath { get; set; } = "";
    public string Name { get; set; } = "";
    public string BirthdayString { get; set; } = "";
    public bool IsTodayBirthday { get; set; }
    public bool IsNotTodayBirthday { get; set; } = true;
}

public class BaseUpdateInfoModel
{
    public string Color { get; set; } = "White";
    public string Info { get; set; } = "";
}

public class MileStoneUpdateInfoModel : BaseUpdateInfoModel
{
    public MileStoneUpdateInfoModel(string i)
    {
        Color = "Gold";
        Info = i;
    }
}

public class RegularUpdateInfoModel : BaseUpdateInfoModel
{
    public RegularUpdateInfoModel(string i)
    {
        Info = i;
    }
}