using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;

namespace HexereiKatepnha.Models.ModelsForViews.Backpack;

public partial class Backpack4MaterialModel : ObservableObject
{
    public string CategoryName { get; set; } = "";
    public string ImagePath { get; set; } = "";
    public string BackgroundImagePath { get; set; } = "";
    public string Name { get; set; } = "";
    public int Rid { get; set; }
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