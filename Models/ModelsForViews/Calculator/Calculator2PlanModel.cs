using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

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
    public string CategoryName { get; set; } = "";
    public string Name { get; set; } = "";
    [ObservableProperty] private string _timeString = "";
    [ObservableProperty] private string _resinString = "";
    [ObservableProperty] private string _resinImagePath = "/Resources/Images/empty_item.png";
    [ObservableProperty] private string _dayString = "";
    [ObservableProperty] private ObservableCollection<CalculatorPlanMaterial> _dungeonMaterialList = new();
    [ObservableProperty] private ObservableCollection<CalculatorPlanItem> _dungeonItemList = new();
}

public partial class CalculatorPlanMaterial : ObservableObject
{
    public int Rid { get; set; }
    public string Name { get; set; } = "";
    public string BackgroundImagePath { get; set; } = "";
    public string ImagePath { get; set; } = "";
    [ObservableProperty] private int _needNum;
    [ObservableProperty] private string _color1 = "";
    [ObservableProperty] private int _actionNum;
    [ObservableProperty] private string _color2 = "";
    [ObservableProperty] private int _haveNum;
    public bool IsMerge { get; set; }
}

public class CalculatorPlanItem
{
    public string Name { get; set; } = "";
    public string BackgroundImagePath { get; set; } = "";
    public string ImagePath { get; set; } = "";
}