using HexereiKatepnha.Constants.EntityConstants;
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

    public void UpdateLevel(int characterId, Enumeration.Level l)
    {
        if (!Configuration.CharacterConfig.ContainsKey(characterId))
        {
            Configuration.CharacterConfig[characterId] = new SingleBackpackCharacterConfigModel();
        }

        Configuration.CharacterConfig[characterId].CharacterLevel = l;
        Save();
        App.CalculatorPlanSettingConfigManagerInstance!.UpdatePlanSetting();
    }

    public void UpdateTalentA(int characterId, Enumeration.Level l)
    {
        if (!Configuration.CharacterConfig.ContainsKey(characterId))
        {
            Configuration.CharacterConfig[characterId] = new SingleBackpackCharacterConfigModel();
        }

        Configuration.CharacterConfig[characterId].TalentALevel = l;
        Save();
        App.CalculatorPlanSettingConfigManagerInstance!.UpdatePlanSetting();
    }

    public void UpdateTalentE(int characterId, Enumeration.Level l)
    {
        if (!Configuration.CharacterConfig.ContainsKey(characterId))
        {
            Configuration.CharacterConfig[characterId] = new SingleBackpackCharacterConfigModel();
        }

        Configuration.CharacterConfig[characterId].TalentELevel = l;
        Save();
        App.CalculatorPlanSettingConfigManagerInstance!.UpdatePlanSetting();
    }

    public void UpdateTalentQ(int characterId, Enumeration.Level l)
    {
        if (!Configuration.CharacterConfig.ContainsKey(characterId))
        {
            Configuration.CharacterConfig[characterId] = new SingleBackpackCharacterConfigModel();
        }

        Configuration.CharacterConfig[characterId].TalentQLevel = l;
        Save();
        App.CalculatorPlanSettingConfigManagerInstance!.UpdatePlanSetting();
    }

    public void UpdateAscension(int characterId, int num)
    {
        if (!Configuration.CharacterConfig.ContainsKey(characterId))
        {
            Configuration.CharacterConfig[characterId] = new SingleBackpackCharacterConfigModel();
        }

        Configuration.CharacterConfig[characterId].Ascension = num;
        Save();
    }

    public void UpdateLevelGoal(int characterId, Enumeration.Level l)
    {
        if (!Configuration.CharacterConfig.ContainsKey(characterId))
        {
            Configuration.CharacterConfig[characterId] = new SingleBackpackCharacterConfigModel();
        }

        Configuration.CharacterConfig[characterId].CharacterLevelGoal = l;
        Save();
        App.CalculatorPlanSettingConfigManagerInstance!.UpdatePlanSetting();
    }

    public void UpdateTalentAGoal(int characterId, Enumeration.Level l)
    {
        if (!Configuration.CharacterConfig.ContainsKey(characterId))
        {
            Configuration.CharacterConfig[characterId] = new SingleBackpackCharacterConfigModel();
        }

        Configuration.CharacterConfig[characterId].TalentALevelGoal = l;
        Save();
        App.CalculatorPlanSettingConfigManagerInstance!.UpdatePlanSetting();
    }

    public void UpdateTalentEGoal(int characterId, Enumeration.Level l)
    {
        if (!Configuration.CharacterConfig.ContainsKey(characterId))
        {
            Configuration.CharacterConfig[characterId] = new SingleBackpackCharacterConfigModel();
        }

        Configuration.CharacterConfig[characterId].TalentELevelGoal = l;
        Save();
        App.CalculatorPlanSettingConfigManagerInstance!.UpdatePlanSetting();
    }

    public void UpdateTalentQGoal(int characterId, Enumeration.Level l)
    {
        if (!Configuration.CharacterConfig.ContainsKey(characterId))
        {
            Configuration.CharacterConfig[characterId] = new SingleBackpackCharacterConfigModel();
        }

        Configuration.CharacterConfig[characterId].TalentQLevelGoal = l;
        Save();
        App.CalculatorPlanSettingConfigManagerInstance!.UpdatePlanSetting();
    }
}