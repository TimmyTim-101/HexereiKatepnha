using HexereiKatepnha.Models.EntityModels;

namespace HexereiKatepnha.Constants.EntityConstants.GeneralConstants;

public static class AutoCalculateConstants
{
    public static Dictionary<int, List<CharacterModel>> CharacterBirthdayDictionary { get; set; } = new();
    public static Dictionary<int, int> MaterialMergeRecipe { get; set; } = new();
}