using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.ConfigModels;
using HexereiKatepnha.Models.EntityModels;

namespace HexereiKatepnha.Models.ModelsForViews.Backpack;

public partial class Backpack1CharacterModel : ObservableObject
{
    public int Rid { get; set; }
    public string ImagePath { get; set; } = "";
    public Enumeration.ElementType ElementType { get; set; } = Enumeration.ElementType.Unknown;
    public string ElementImagePath { get; set; } = "";
    public string BackgroundImagePath { get; set; } = "";
    public string Name { get; set; } = "";
    public int Star { get; set; }
    public Enumeration.WeaponType WeaponType { get; set; } = Enumeration.WeaponType.Unknown;
    [ObservableProperty] private SingleBackpackCharacterConfigModel _characterConfigModel = new();
    [ObservableProperty] private string _levelString = StringConstants.LevelNameString[Enumeration.Level.L1];
    [ObservableProperty] private string _talentAString = StringConstants.LevelNumberString[Enumeration.Level.L1];
    [ObservableProperty] private string _talentEString = StringConstants.LevelNumberString[Enumeration.Level.L1];
    [ObservableProperty] private string _talentQString = StringConstants.LevelNumberString[Enumeration.Level.L1];
    public Dictionary<int, ImageDescriptionPairModel> TalentPropertyDictionary { get; set; } = new();
    public Dictionary<int, ImageDescriptionPairModel> AscensionPropertyDictionary { get; set; } = new();
    [ObservableProperty] private ObservableCollection<double> _ascensionOpacityList = [1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0];
}