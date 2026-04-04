using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.ConfigModels;

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
    [ObservableProperty] private ObservableCollection<ObservableCollection<string>> _affixStringList = new();
    [ObservableProperty] private int _progression;
    [ObservableProperty] private string _levelNumberString = StringConstants.LevelNumberString[Enumeration.Level.L1];
    [ObservableProperty] private string _levelNameString = StringConstants.LevelNameString[Enumeration.Level.L1];
    [ObservableProperty] private string _levelGoalNumberString = StringConstants.LevelNumberString[Enumeration.Level.L1];
    [ObservableProperty] private string _description = "";
    [ObservableProperty] private string _characterName = "";
    [ObservableProperty] private string _characterImagePath = StringConstants.EmptyImagePath;
    [ObservableProperty] private string _characterBackgroundImagePath = StringConstants.EmptyImagePath;
    [ObservableProperty] private string _characterElementImagePath = StringConstants.EmptyImagePath;
    [ObservableProperty] private SingleBackpackWeaponConfigModel _config = new();
    [ObservableProperty] private int _subExp;
    [ObservableProperty] private int _levelTotalExp = 1;
    [ObservableProperty] private bool _isShowProgress = true;

    partial void OnSubExpChanged(int value)
    {
        SubExp = Math.Min(value, LevelTotalExp - 1);
        Config.SubExp = SubExp;
        App.BackpackWeaponConfigManagerInstance!.UpdateSubExp(Id, SubExp);
    }
}