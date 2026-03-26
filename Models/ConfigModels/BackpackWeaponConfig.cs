using CommunityToolkit.Mvvm.ComponentModel;
using HexereiKatepnha.Constants.EntityConstants;

namespace HexereiKatepnha.Models.ConfigModels;

public class BackpackWeaponConfig
{
    public Dictionary<string, SingleBackpackWeaponConfigModel> WeaponConfigMap { get; set; } = new();
}

public partial class SingleBackpackWeaponConfigModel : ObservableObject
{
    public string Id { get; set; } = "";
    public int Rid { get; set; }
    [ObservableProperty] private int _progression = 1;
    [ObservableProperty] private Enumeration.Level _level = Enumeration.Level.L1;
    [ObservableProperty] private Enumeration.Level _goalLevel = Enumeration.Level.L1;
    [ObservableProperty] private int _characterRid;
    public int SubExp { get; set; }
}