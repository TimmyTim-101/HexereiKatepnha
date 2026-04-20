using System.Collections.ObjectModel;
using System.Windows;
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

    [ObservableProperty] [NotifyPropertyChangedFor(nameof(IsCharacter))] [NotifyPropertyChangedFor(nameof(IsEmptyCharacter))]
    private string _characterName = "";

    [ObservableProperty] private string _characterImagePath = StringConstants.EmptyImagePath;
    [ObservableProperty] private string _characterBackgroundImagePath = StringConstants.EmptyImagePath;
    [ObservableProperty] private string _characterElementImagePath = StringConstants.EmptyImagePath;
    public bool IsCharacter => !String.IsNullOrEmpty(CharacterName);
    public bool IsEmptyCharacter => String.IsNullOrEmpty(CharacterName);
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

public partial class BackpackWeaponPlanInfo : ObservableObject
{
    [ObservableProperty] private ObservableCollection<BackpackWeaponPlanInfoMaterial> _weaponPlanMaterialList = [];
    [ObservableProperty] private ObservableCollection<BackpackWeaponPlanInfoSubPlan> _weaponPlanSubPlanList = [];
    [ObservableProperty] private bool _isShowSubPlan;
    [ObservableProperty] private bool _isAllComplete;
}

public partial class BackpackWeaponPlanInfoMaterial : ObservableObject
{
    [ObservableProperty] private int _rid;
    [ObservableProperty] private string _name = "";
    [ObservableProperty] private string _backgroundImagePath = "";
    [ObservableProperty] private string _imagePath = "";
    [ObservableProperty] private int _number;
    [ObservableProperty] private int _num1;
    [ObservableProperty] private string _color1 = "#Transparent";
    [ObservableProperty] private string _iconPath = "";
    [ObservableProperty] private string _num2String = "";
    [ObservableProperty] private string _color2 = "#Transparent";
    public Visibility IsMergeVisible => AutoCalculateConstants.MaterialMergeRecipe.ContainsKey(Rid) ? Visibility.Visible : Visibility.Collapsed;

    partial void OnNumberChanged(int value)
    {
        if (App.BackpackMaterialConfigManagerInstance!.GetMaterialNumber(Rid) != value)
        {
            App.BackpackMaterialConfigManagerInstance.UpdateMaterialNumber(Rid, value);
        }
    }
}

public partial class BackpackWeaponPlanInfoSubPlan : ObservableObject
{
    [ObservableProperty] private string _weaponId = "";
    [ObservableProperty] private int _index;
    [ObservableProperty] private string _actionTypeString = "";
    [ObservableProperty] private string _actionDescriptionString = "";
    [ObservableProperty] private ObservableCollection<BackpackWeaponPlanInfoNeedMaterial> _needMaterialList = [];
    [ObservableProperty] private bool _isCheckAble;
    [ObservableProperty] private Enumeration.Level _finishLevel;
}

public partial class BackpackWeaponPlanInfoNeedMaterial : ObservableObject
{
    [ObservableProperty] private int _rid;
    [ObservableProperty] private string _backgroundImagePath = "";
    [ObservableProperty] private string _imagePath = "";
    [ObservableProperty] private string _name = "";
    [ObservableProperty] private int _showNum;
    [ObservableProperty] private int _needNum;
    [ObservableProperty] private string _color = StringConstants.GreenColorString;
}