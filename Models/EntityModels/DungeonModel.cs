using HexereiKatepnha.Constants.EntityConstants;

namespace HexereiKatepnha.Models.EntityModels;

public class DungeonModel : BaseEntityModel
{
    public override int Rid { get; set; }
    public override int Vid { get; set; } = 0;
    public override string Name { get; set; } = "";
    public override int Star { get; set; } = 1;
    public override Enumeration.EntityType EntityType { get; set; } = Enumeration.EntityType.Dungeon;
    public override string ImagePath { get; set; } = "";
    public int Cost { get; set; }
    public int Time { get; set; } = 0;
    public List<MaterialPairModel> DropMaterialList = [];
}