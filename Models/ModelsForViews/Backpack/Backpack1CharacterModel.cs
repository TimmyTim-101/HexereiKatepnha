using System.Collections.ObjectModel;
using System.Windows;
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
    [ObservableProperty] private string _levelNameString = StringConstants.LevelNameString[Enumeration.Level.L1];
    [ObservableProperty] private string _levelNumberString = StringConstants.LevelNumberString[Enumeration.Level.L1];
    [ObservableProperty] private string _talentAString = StringConstants.LevelNumberString[Enumeration.Level.L1];
    [ObservableProperty] private string _talentEString = StringConstants.LevelNumberString[Enumeration.Level.L1];
    [ObservableProperty] private string _talentQString = StringConstants.LevelNumberString[Enumeration.Level.L1];
    [ObservableProperty] private string _levelGoalNumberString = StringConstants.LevelNumberString[Enumeration.Level.L1];
    [ObservableProperty] private string _talentAGoalString = StringConstants.LevelNumberString[Enumeration.Level.L1];
    [ObservableProperty] private string _talentEGoalString = StringConstants.LevelNumberString[Enumeration.Level.L1];
    [ObservableProperty] private string _talentQGoalString = StringConstants.LevelNumberString[Enumeration.Level.L1];
    public Dictionary<int, ImageDescriptionPairModel> TalentPropertyDictionary { get; set; } = new();
    public Dictionary<int, ImageDescriptionPairModel> ConstellationPropertyDictionary { get; set; } = new();
    [ObservableProperty] private ObservableCollection<double> _ascensionOpacityList = [1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0];
    [ObservableProperty] private int _subExp;
    [ObservableProperty] private int _levelTotalExp = 1;
    [ObservableProperty] private bool _isShowProgress = true;
    [ObservableProperty] private string _weaponBackgroundImagePath = StringConstants.EmptyImagePath;
    [ObservableProperty] private string _weaponImagePath = StringConstants.EmptyImagePath;

    [ObservableProperty] [NotifyPropertyChangedFor(nameof(IsWeapon))] [NotifyPropertyChangedFor(nameof(IsEmptyWeapon))]
    private string _weaponName = "";

    [ObservableProperty] private int _weaponProgression = 1;
    [ObservableProperty] private string _weaponLevelString = "";
    [ObservableProperty] private string _weaponDescription = "";
    [ObservableProperty] private ObservableCollection<ObservableCollection<string>> _weaponAffixStringList = [];
    public bool IsWeapon => !String.IsNullOrEmpty(WeaponName);
    public bool IsEmptyWeapon => String.IsNullOrEmpty(WeaponName);

    partial void OnSubExpChanged(int value)
    {
        SubExp = Math.Min(value, LevelTotalExp - 1);
        CharacterConfigModel.SubExp = SubExp;
        App.BackpackCharacterConfigManagerInstance!.UpdateSubExp(Rid, SubExp);
    }
}

public partial class BackpackCharacterPlanInfo : ObservableObject
{
    [ObservableProperty] private ObservableCollection<BackpackCharacterPlanInfoMaterial> _characterPlanMaterialList = [];
    [ObservableProperty] private ObservableCollection<BackpackCharacterPlanInfoSubPlan> _characterPlanSubPlanList = [];
    [ObservableProperty] private bool _isShowSubPlan;
    [ObservableProperty] private bool _isAllComplete;
}

public partial class BackpackCharacterPlanInfoMaterial : ObservableObject
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

public partial class BackpackCharacterPlanInfoSubPlan : ObservableObject
{
    [ObservableProperty] private int _characterRid;
    [ObservableProperty] private int _index;
    [ObservableProperty] private int _type; // 1 - 等级，2 - 天赋A，3 - 天赋E，4 - 天赋Q
    [ObservableProperty] private string _actionTypeString = "";
    [ObservableProperty] private string _actionDescriptionString = "";
    [ObservableProperty] private ObservableCollection<BackpackCharacterPlanInfoNeedMaterial> _needMaterialList = [];
    [ObservableProperty] private bool _isCheckAble;
    [ObservableProperty] private Enumeration.Level _finishLevel;
}

public partial class BackpackCharacterPlanInfoNeedMaterial : ObservableObject
{
    [ObservableProperty] private int _rid;
    [ObservableProperty] private string _backgroundImagePath = "";
    [ObservableProperty] private string _imagePath = "";
    [ObservableProperty] private string _name = "";
    [ObservableProperty] private int _showNum;
    [ObservableProperty] private int _needNum;
    [ObservableProperty] private string _color = StringConstants.GreenColorString;
}