using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.ModelsForViews.Database.SubModels;

namespace HexereiKatepnha.Models.ModelsForViews.Database;

public class Database3ArtifactModels
{
    public int Vid { get; set; }
    public string Name { get; set; } = "";
    public List<ArtifactTableRowModel> ImageList { get; set; } = [];
    public List<ArtifactEffectModel> EffectList { get; set; } = [];
}