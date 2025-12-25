using HexereiKatepnha.Constants.EntityConstants;

namespace HexereiKatepnha.Models.EntityModels;

public class ArtifactSetModel
{
    public int Rid { get; set; }
    public int Vid { get; set; }
    public string Name { get; set; } = "";
    public Enumeration.EntityType EntityType { get; set; } = Enumeration.EntityType.Artifact;
    public List<int> RarityList { get; set; } = [];
    public Dictionary<int, string> PositionNameDict { get; set; } = [];
    public Dictionary<int, string> PositionImagePathDict { get; set; } = [];
    public Dictionary<int, string> EffectDict { get; set; } = [];
}