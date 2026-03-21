using CommunityToolkit.Mvvm.ComponentModel;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;

namespace HexereiKatepnha.Models.ModelsForViews.Calculator;

public partial class Calculator7PlanSettingModel : ObservableObject
{
    public int Index { get; set; } = 1;
    public string ImagePath { get; set; } = "";
    public string StarBackgroundImagePath { get; set; } = "";
    public string ElementImagePath { get; set; } = "";
    public string Name { get; set; } = "";
    [ObservableProperty] private string _levelString = "";
    [ObservableProperty] private string _talentAString = "";
    [ObservableProperty] private string _talentEString = "";
    [ObservableProperty] private string _talentQString = "";
    public string Id { get; set; } = "";
}