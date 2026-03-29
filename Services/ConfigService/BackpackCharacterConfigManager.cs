using CommunityToolkit.Mvvm.Messaging;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Models.ConfigModels;
using HexereiKatepnha.Models.Messages;

namespace HexereiKatepnha.Services.ConfigService;

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

        SingleBackpackCharacterConfigModel thisCharacterConfig = Configuration.CharacterConfig[characterId];
        thisCharacterConfig.CharacterLevel = l;
        Save();
        App.CalculatorPlanSettingConfigManagerInstance!.UpdateCharacterPlanSetting(characterId);
        WeakReferenceMessenger.Default.Send(new BackpackCharacterLevelChangeMessage(new BackpackCharacterChangeRecord(characterId.ToString(), thisCharacterConfig.CharacterLevel, thisCharacterConfig.CharacterLevelGoal)));
        App.RefreshGoalSimulation();
    }

    public void UpdateTalentA(int characterId, Enumeration.Level l)
    {
        if (!Configuration.CharacterConfig.ContainsKey(characterId))
        {
            Configuration.CharacterConfig[characterId] = new SingleBackpackCharacterConfigModel();
        }

        SingleBackpackCharacterConfigModel thisCharacterConfig = Configuration.CharacterConfig[characterId];
        thisCharacterConfig.TalentALevel = l;
        Save();
        App.CalculatorPlanSettingConfigManagerInstance!.UpdateCharacterPlanSetting(characterId);
        WeakReferenceMessenger.Default.Send(new BackpackCharacterTalentAChangeMessage(new BackpackCharacterChangeRecord(characterId.ToString(), thisCharacterConfig.TalentALevel, thisCharacterConfig.TalentALevelGoal)));
        App.RefreshGoalSimulation();
    }

    public void UpdateTalentE(int characterId, Enumeration.Level l)
    {
        if (!Configuration.CharacterConfig.ContainsKey(characterId))
        {
            Configuration.CharacterConfig[characterId] = new SingleBackpackCharacterConfigModel();
        }

        SingleBackpackCharacterConfigModel thisCharacterConfig = Configuration.CharacterConfig[characterId];
        thisCharacterConfig.TalentELevel = l;
        Save();
        App.CalculatorPlanSettingConfigManagerInstance!.UpdateCharacterPlanSetting(characterId);
        WeakReferenceMessenger.Default.Send(new BackpackCharacterTalentEChangeMessage(new BackpackCharacterChangeRecord(characterId.ToString(), thisCharacterConfig.TalentELevel, thisCharacterConfig.TalentELevelGoal)));
        App.RefreshGoalSimulation();
    }

    public void UpdateTalentQ(int characterId, Enumeration.Level l)
    {
        if (!Configuration.CharacterConfig.ContainsKey(characterId))
        {
            Configuration.CharacterConfig[characterId] = new SingleBackpackCharacterConfigModel();
        }

        SingleBackpackCharacterConfigModel thisCharacterConfig = Configuration.CharacterConfig[characterId];
        thisCharacterConfig.TalentQLevel = l;
        Save();
        App.CalculatorPlanSettingConfigManagerInstance!.UpdateCharacterPlanSetting(characterId);
        WeakReferenceMessenger.Default.Send(new BackpackCharacterTalentQChangeMessage(new BackpackCharacterChangeRecord(characterId.ToString(), thisCharacterConfig.TalentQLevel, thisCharacterConfig.TalentQLevelGoal)));
        App.RefreshGoalSimulation();
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

        SingleBackpackCharacterConfigModel thisCharacterConfig = Configuration.CharacterConfig[characterId];
        thisCharacterConfig.CharacterLevelGoal = l;
        Save();
        App.CalculatorPlanSettingConfigManagerInstance!.UpdateCharacterPlanSetting(characterId);
        WeakReferenceMessenger.Default.Send(new BackpackCharacterLevelChangeMessage(new BackpackCharacterChangeRecord(characterId.ToString(), thisCharacterConfig.CharacterLevel, thisCharacterConfig.CharacterLevelGoal)));
        App.RefreshGoalSimulation();
    }

    public void UpdateTalentAGoal(int characterId, Enumeration.Level l)
    {
        if (!Configuration.CharacterConfig.ContainsKey(characterId))
        {
            Configuration.CharacterConfig[characterId] = new SingleBackpackCharacterConfigModel();
        }

        SingleBackpackCharacterConfigModel thisCharacterConfig = Configuration.CharacterConfig[characterId];
        thisCharacterConfig.TalentALevelGoal = l;
        Save();
        App.CalculatorPlanSettingConfigManagerInstance!.UpdateCharacterPlanSetting(characterId);
        WeakReferenceMessenger.Default.Send(new BackpackCharacterTalentAChangeMessage(new BackpackCharacterChangeRecord(characterId.ToString(), thisCharacterConfig.TalentALevel, thisCharacterConfig.TalentALevelGoal)));
        App.RefreshGoalSimulation();
    }

    public void UpdateTalentEGoal(int characterId, Enumeration.Level l)
    {
        if (!Configuration.CharacterConfig.ContainsKey(characterId))
        {
            Configuration.CharacterConfig[characterId] = new SingleBackpackCharacterConfigModel();
        }

        SingleBackpackCharacterConfigModel thisCharacterConfig = Configuration.CharacterConfig[characterId];
        thisCharacterConfig.TalentELevelGoal = l;
        Save();
        App.CalculatorPlanSettingConfigManagerInstance!.UpdateCharacterPlanSetting(characterId);
        WeakReferenceMessenger.Default.Send(new BackpackCharacterTalentEChangeMessage(new BackpackCharacterChangeRecord(characterId.ToString(), thisCharacterConfig.TalentELevel, thisCharacterConfig.TalentELevelGoal)));
        App.RefreshGoalSimulation();
    }

    public void UpdateTalentQGoal(int characterId, Enumeration.Level l)
    {
        if (!Configuration.CharacterConfig.ContainsKey(characterId))
        {
            Configuration.CharacterConfig[characterId] = new SingleBackpackCharacterConfigModel();
        }

        SingleBackpackCharacterConfigModel thisCharacterConfig = Configuration.CharacterConfig[characterId];
        thisCharacterConfig.TalentQLevelGoal = l;
        Save();
        App.CalculatorPlanSettingConfigManagerInstance!.UpdateCharacterPlanSetting(characterId);
        WeakReferenceMessenger.Default.Send(new BackpackCharacterTalentQChangeMessage(new BackpackCharacterChangeRecord(characterId.ToString(), thisCharacterConfig.TalentQLevel, thisCharacterConfig.TalentQLevelGoal)));
        App.RefreshGoalSimulation();
    }

    public void UpdateSubExp(int characterId, int subExp)
    {
        Configuration.CharacterConfig[characterId].SubExp = subExp;
        Save();
        App.RefreshGoalSimulation();
    }
}