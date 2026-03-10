using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;

namespace HexereiKatepnha.Models.ModelsForViews.Backpack;

public partial class Backpack4MaterialModel : ObservableObject
{
    public string ImagePath { get; set; } = "";
    public string BackgroundImagePath { get; set; } = "";
    public string Name { get; set; } = "";
    public int Rid { get; set; }
    [ObservableProperty] private int _number;

    public Visibility IsMergeVisible
    {
        get
        {
            if (AutoCalculateConstants.MaterialMergeRecipe.ContainsKey(Rid))
            {
                return Visibility.Visible;
            }

            return Visibility.Collapsed;
        }
    }

    partial void OnNumberChanged(int value)
    {
        App.BackpackMaterialConfigManagerInstance!.UpdateMaterialNumber(Rid, value);
    }
}