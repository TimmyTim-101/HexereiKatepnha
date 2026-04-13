using HexereiKatepnha.Constants.EntityConstants;

namespace HexereiKatepnha.Models.EntityModels;

public class ArtifactSetModel : BaseEntityModel
{
    public override int Rid { get; set; }
    public override int Vid { get; set; }
    public override string Name { get; set; } = "";
    public override string GoodKey { get; set; } = "";
    public override int Star { get; set; }
    public override Enumeration.EntityType EntityType { get; set; } = Enumeration.EntityType.Artifact;
    public override string ImagePath { get; set; } = "";
    public List<int> RarityList { get; init; } = [];
    public Dictionary<int, string> PositionNameDict { get; init; } = [];
    public Dictionary<int, string> PositionImagePathDict { get; init; } = [];
    public Dictionary<int, string> EffectDict { get; init; } = [];
}