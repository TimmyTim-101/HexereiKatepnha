using CommunityToolkit.Mvvm.ComponentModel;

namespace HexereiKatepnha.Models.ModelsForViews.Calculator;

public class Calculator2PlanModel
{
}

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