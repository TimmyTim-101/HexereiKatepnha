using System.Collections.ObjectModel;

namespace HexereiKatepnha.Models.ConfigModels;

public class CalculatorPlanSettingConfig
{
    public ObservableCollection<string> OrderList { get; set; } = new();
    public Dictionary<string, SingleCalculatorPlanConfigModel> PlanMap { get; set; } = new();
}

public class SingleCalculatorPlanConfigModel
{
    public string Id { get; set; } = "";
    public int Type { get; set; } = 1;
    public int Rid { get; set; }
}