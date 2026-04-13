using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;

namespace HexereiKatepnha.Models.ModelsForViews.Database;

public class Database3ArtifactModel
{
    public int Vid { get; set; }
    public string Name { get; set; } = "";
    public List<Database3ArtifactPositionModel> PositionList { get; set; } = [];
    public List<Database3ArtifactEffectModel> EffectList { get; set; } = [];
}

public class Database3ArtifactPositionModel
{
    public string PositionIconPath { get; set; } = StringConstants.EmptyImagePath;
    public string PositionName { get; set; } = "";

    public List<Database3ArtifactRarityModel> PositionRarityList { get; set; } = [];
}

public class Database3ArtifactRarityModel
{
    public string BackgroundImagePath { get; set; } = StringConstants.EmptyImagePath;
    public string ImagePath { get; set; } = StringConstants.EmptyImagePath;
}

public class Database3ArtifactEffectModel
{
    public int Num { get; set; }
    public string Effect { get; set; } = "";
}