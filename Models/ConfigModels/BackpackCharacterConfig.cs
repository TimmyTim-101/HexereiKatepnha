using HexereiKatepnha.Constants.EntityConstants;

namespace HexereiKatepnha.Models.ConfigModels;

public class BackpackCharacterConfig
{
    public Dictionary<int, SingleBackpackCharacterConfigModel> CharacterConfig { get; set; } = new();
}

public class SingleBackpackCharacterConfigModel
{
    public Enumeration.Level CharacterLevel { get; set; } = Enumeration.Level.L1;
    public Enumeration.Level TalentALevel { get; set; } = Enumeration.Level.L1;
    public Enumeration.Level TalentELevel { get; set; } = Enumeration.Level.L1;
    public Enumeration.Level TalentQLevel { get; set; } = Enumeration.Level.L1;
    public int Ascension { get; set; } = 0;
}