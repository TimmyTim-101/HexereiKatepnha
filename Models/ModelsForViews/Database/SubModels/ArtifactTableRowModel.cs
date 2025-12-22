namespace HexereiKatepnha.Models.ModelsForViews.Database.SubModels;

public class ArtifactTableRowModel
{
    public string ArtifactIconPath { get; set; } = "";
    public string Name { get; set; } = "";
    public List<ArtifactImageModel> ImagePathList { get; set; } = [];
}