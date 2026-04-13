namespace HexereiKatepnha.Models.ModelsForViews.Database.SubModels;

public class ArtifactTableRowModel
{
    public string ArtifactIconPath { get; set; } = "";
    public string Name { get; set; } = "";
    public List<ArtifactImageModel> ImagePathList { get; set; } = [];
}

public class ArtifactImageModel
{
    public string BackgroundPath { get; set; } = "";
    public string ImagePath { get; set; } = "";
}