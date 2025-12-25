using HexereiKatepnha.Constants.EntityConstants;

namespace HexereiKatepnha.Models.EntityModels;

public class MaterialModel : BaseEntityModel
{
    public override int Rid { get; set; }
    public override int Vid { get; set; }
    public override string Name { get; set; } = "";
    public override int Star { get; set; }
    public override Enumeration.EntityType EntityType { get; set; } = Enumeration.EntityType.Material;
    public Enumeration.MaterialType MaterialType { get; set; }
    public override string ImagePath { get; set; } = "";
}