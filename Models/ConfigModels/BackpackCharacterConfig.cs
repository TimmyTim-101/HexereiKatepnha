using CommunityToolkit.Mvvm.ComponentModel;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.EntityModels;

namespace HexereiKatepnha.Models.ConfigModels;

public class BackpackCharacterConfig
{
    public Dictionary<int, SingleBackpackCharacterConfigModel> CharacterConfig { get; set; } = new();
}

public partial class SingleBackpackCharacterConfigModel : ObservableObject
{
    [ObservableProperty] private Enumeration.Level _characterLevel = Enumeration.Level.L1;
    [ObservableProperty] private Enumeration.Level _talentALevel = Enumeration.Level.L1;
    [ObservableProperty] private Enumeration.Level _talentELevel = Enumeration.Level.L1;
    [ObservableProperty] private Enumeration.Level _talentQLevel = Enumeration.Level.L1;
    [ObservableProperty] private int _ascension;
    [ObservableProperty] private Enumeration.Level _characterLevelGoal = Enumeration.Level.L1;
    [ObservableProperty] private Enumeration.Level _talentALevelGoal = Enumeration.Level.L1;
    [ObservableProperty] private Enumeration.Level _talentELevelGoal = Enumeration.Level.L1;
    [ObservableProperty] private Enumeration.Level _talentQLevelGoal = Enumeration.Level.L1;
    public int SubExp { get; set; }
}