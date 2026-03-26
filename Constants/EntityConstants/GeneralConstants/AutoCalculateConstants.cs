using HexereiKatepnha.Models.EntityModels;

namespace HexereiKatepnha.Constants.EntityConstants.GeneralConstants;

public static class AutoCalculateConstants
{
    public static Dictionary<int, List<CharacterModel>> CharacterBirthdayDictionary { get; set; } = new();
    public static Dictionary<int, int> MaterialMergeRecipe { get; set; } = new();
    public static Dictionary<int, CharacterModel> CharacterMap { get; set; } = new();
    public static Dictionary<int, WeaponModel> WeaponMap { get; set; } = new();
    public static Dictionary<int, MaterialModel> MaterialMap { get; set; } = new();
    public static Dictionary<int, DungeonModel> DungeonMap { get; set; } = new();
    public static Dictionary<int, int> MaterialDungeonMap { get; set; } = new();
}