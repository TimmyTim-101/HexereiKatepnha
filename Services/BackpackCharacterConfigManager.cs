using HexereiKatepnha.Models.ConfigModels;

namespace HexereiKatepnha.Services;

public class BackpackCharacterConfigManager : ConfigManagerBase<BackpackCharacterConfig>
{
    protected sealed override string ConfigFileName { get; set; }

    public BackpackCharacterConfigManager(Guid accountGuid)
    {
        ConfigFileName = "Configs/" + accountGuid + "/BackpackCharacter.json";
    }

    public SingleBackpackCharacterConfigModel GetBackpackCharacterConfig(int characterId)
    {
        return Configuration.CharacterConfig.TryGetValue(characterId, out var m) ? m : new SingleBackpackCharacterConfigModel();
    }
}