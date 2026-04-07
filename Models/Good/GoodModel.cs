using System.Text.Json.Serialization;

namespace HexereiKatepnha.Models.Good;

public class GoodModel
{
    public string format { get; set; } = "";
    public int version { get; set; }
    public string source { get; set; } = "";
    public List<GoodCharacter> characters = new();
    public List<GoodWeapon> weapons = new();
    public Dictionary<string, int> materials = new();
}

public class GoodCharacter
{
    public string key { get; set; } = "";
    public int level { get; set; }
    public int constellation { get; set; }
    public int ascension { get; set; }
    public GoodCharacterTalent talent { get; set; }
}

public class GoodCharacterTalent
{
    public int auto { get; set; }
    public int skill { get; set; }
    public int burst { get; set; }
}

public class GoodWeapon
{
    public string key { get; set; } = "";
    public int level { get; set; }
    public int ascension { get; set; }
    public int refinement { get; set; }
    public string location { get; set; } = "";
    [JsonPropertyName("lock")] public bool isLocked { get; set; }
}