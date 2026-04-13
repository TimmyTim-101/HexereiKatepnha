namespace HexereiKatepnha.Models.ModelsForViews;

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