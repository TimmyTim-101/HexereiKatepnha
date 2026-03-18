using CommunityToolkit.Mvvm.ComponentModel;
using HexereiKatepnha.Constants.EntityConstants;

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
    [ObservableProperty] private int _ascension = 0;
}