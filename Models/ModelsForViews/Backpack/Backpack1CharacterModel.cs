using HexereiKatepnha.Constants.EntityConstants;

namespace HexereiKatepnha.Models.ModelsForViews.Backpack;

public class Backpack1CharacterModel
{
    public string ImagePath { get; set; } = "";
    public Enumeration.ElementType ElementType { get; set; } = Enumeration.ElementType.Unknown;
    public string ElementImagePath { get; set; } = "";
    public string BackgroundImagePath { get; set; } = "";
    public string Name { get; set; } = "";
    public int Rid { get; set; }
    public string StarImagePath { get; set; } = "";
    public Enumeration.WeaponType WeaponType { get; set; } = Enumeration.WeaponType.Unknown;
}