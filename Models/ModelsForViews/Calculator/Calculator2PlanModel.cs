using System.Collections.ObjectModel;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;

namespace HexereiKatepnha.Models.ModelsForViews.Calculator;

public partial class CalculatorPlanLackMaterialModel : ObservableObject
{
    public int Rid { get; set; }
    public string ImagePath { get; set; } = "";
    public string BackgroundImagePath { get; set; } = "";
    public string Name { get; set; } = "";
    [ObservableProperty] private int _backpackNum;
    [ObservableProperty] private int _mergeNum;
    [ObservableProperty] private int _needNum;
    [ObservableProperty] private double _isAccessible = 1.0;
}

public partial class CalculatorPlanBoss60Model : ObservableObject
{
    public string ImagePath { get; set; } = "";
    public string Name { get; set; } = "";
    [ObservableProperty] private int _needNum1;
    [ObservableProperty] private int _haveNum1;
    [ObservableProperty] private int _needNum2;
    [ObservableProperty] private int _haveNum2;
    [ObservableProperty] private int _needNum3;
    [ObservableProperty] private int _haveNum3;
    [ObservableProperty] private int _sort;
    [ObservableProperty] private string _info = "";
    [ObservableProperty] private string _color = "";
    [ObservableProperty] private int _lackIndex;
}

public partial class CalculatorPlanStatistics : ObservableObject
{
    [ObservableProperty] private int _resinNum;
    [ObservableProperty] private int _mergeResinNum;
    [ObservableProperty] private int _dayNum;
}

public partial class CalculatorPlanMaterialExtraInfo : ObservableObject
{
    public int Rid { get; set; }
    [ObservableProperty] private int _needNum;
    [ObservableProperty] private bool _isSatisfy;
    [ObservableProperty] private int _actionNum;
}

public partial class CalculatorPlanDungeon : ObservableObject
{
    public int Rid { get; set; }
    public string Name { get; set; } = "";
    [ObservableProperty] private string _timeString = "";
    [ObservableProperty] private string _resinString = "";
    [ObservableProperty] private string _resinImagePath = StringConstants.EmptyImagePath;
    [ObservableProperty] private string _dayString = "";
    public bool IsShow => !string.IsNullOrEmpty(TimeString);
    [ObservableProperty] private ObservableCollection<CalculatorPlanMaterial> _dungeonMaterialList = new();
    [ObservableProperty] private ObservableCollection<CalculatorPlanItem> _dungeonItemList = new();
    [ObservableProperty] private bool _isVisible;
}

public partial class CalculatorPlanMaterial : ObservableObject
{
    public int Rid { get; set; }
    public string Name { get; set; } = "";
    public string BackgroundImagePath { get; set; } = "";
    public string ImagePath { get; set; } = "";
    [ObservableProperty] private int _number;
    [ObservableProperty] private int _num1;
    [ObservableProperty] private string _color1 = "#Transparent";
    [ObservableProperty] private string _iconPath = "";
    [ObservableProperty] private string _num2String = "";
    [ObservableProperty] private string _color2 = "#Transparent";

    public Visibility IsMergeVisible => AutoCalculateConstants.MaterialMergeRecipe.ContainsKey(Rid) ? Visibility.Visible : Visibility.Collapsed;

    partial void OnNumberChanged(int value)
    {
        if (value != App.BackpackMaterialConfigManagerInstance!.GetMaterialNumber(Rid)) App.BackpackMaterialConfigManagerInstance.UpdateMaterialNumber(Rid, value);
    }
}

public class CalculatorPlanItem
{
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public string BackgroundImagePath { get; set; } = "";
    public string ImagePath { get; set; } = "";
}