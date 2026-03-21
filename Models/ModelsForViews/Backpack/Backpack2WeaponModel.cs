using CommunityToolkit.Mvvm.ComponentModel;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;

namespace HexereiKatepnha.Models.ModelsForViews.Backpack;

public partial class Backpack2WeaponModel : ObservableObject
{
    public string Id { get; set; } = "";
    public int Rid { get; set; }
    public string Name { get; set; } = "";
    public int Star { get; set; }
    [ObservableProperty] private string _imagePath = "";
    public string BackgroundImagePath { get; set; } = "";
    public string WeaponTypeImagePath { get; set; } = "";
    public Enumeration.WeaponType WeaponType = Enumeration.WeaponType.Unknown;
    [ObservableProperty] private int _progression;
    [ObservableProperty] private string _levelNumberString = StringConstants.LevelNumberString[Enumeration.Level.L1];
    [ObservableProperty] private string _levelNameString = StringConstants.LevelNameString[Enumeration.Level.L1];
    [ObservableProperty] private string _levelGoalNumberString = StringConstants.LevelNumberString[Enumeration.Level.L1];
    [ObservableProperty] private string _description = "";
    [ObservableProperty] private string _characterName = "";
    [ObservableProperty] private string _characterImagePath = "/Resources/Images/empty_item.png";
    [ObservableProperty] private string _characterBackgroundImagePath = "/Resources/Images/empty_item.png";
    [ObservableProperty] private string _characterElementImagePath = "/Resources/Images/empty_item.png";
}