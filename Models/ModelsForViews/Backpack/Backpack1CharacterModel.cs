using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.ConfigModels;
using HexereiKatepnha.Models.EntityModels;

namespace HexereiKatepnha.Models.ModelsForViews.Backpack;

public class Backpack1CharacterModel
{
    public string ImagePath { get; set; } = "";
    public Enumeration.ElementType ElementType { get; set; } = Enumeration.ElementType.Unknown;
    public string ElementImagePath { get; set; } = "";
    public string BackgroundImagePath { get; set; } = "";
    public string Name { get; set; } = "";
    public Enumeration.WeaponType WeaponType { get; set; } = Enumeration.WeaponType.Unknown;
    public SingleBackpackCharacterConfigModel CharacterConfigModel { get; set; } = new();
    public string LevelString { get; set; } = StringConstants.LevelNameString[Enumeration.Level.L1];
    public string TalentAString { get; set; } = StringConstants.LevelNumberString[Enumeration.Level.L1];
    public string TalentEString { get; set; } = StringConstants.LevelNumberString[Enumeration.Level.L1];
    public string TalentQString { get; set; } = StringConstants.LevelNumberString[Enumeration.Level.L1];
    public Dictionary<int, ImageDescriptionPairModel> TalentPropertyDictionary { get; set; } = new();
    public Dictionary<int, ImageDescriptionPairModel> AscensionPropertyDictionary { get; set; } = new();
    public List<double> AscensionOpacityList { get; set; } = [1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0];
}