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
        WeakReferenceMessenger.Default.Send(new CharacterInfoChangeMessage(characterId));
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
        WeakReferenceMessenger.Default.Send(new CharacterInfoChangeMessage(characterId));
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
        WeakReferenceMessenger.Default.Send(new CharacterInfoChangeMessage(characterId));
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
        WeakReferenceMessenger.Default.Send(new CharacterInfoChangeMessage(characterId));
    }

    public void UpdateAscension(int characterId, int num)
    {
        if (!Configuration.CharacterConfig.ContainsKey(characterId))
        {
            Configuration.CharacterConfig[characterId] = new SingleBackpackCharacterConfigModel();
        }

        Configuration.CharacterConfig[characterId].Constellation = num;
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
        WeakReferenceMessenger.Default.Send(new CharacterInfoChangeMessage(characterId));
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
        WeakReferenceMessenger.Default.Send(new CharacterInfoChangeMessage(characterId));
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
        WeakReferenceMessenger.Default.Send(new CharacterInfoChangeMessage(characterId));
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
        WeakReferenceMessenger.Default.Send(new CharacterInfoChangeMessage(characterId));
    }

    public void UpdateSubExp(int characterId, int subExp)
    {
        if (!Configuration.CharacterConfig.ContainsKey(characterId))
        {
            Configuration.CharacterConfig[characterId] = new SingleBackpackCharacterConfigModel();
        }

        SingleBackpackCharacterConfigModel thisCharacterConfig = Configuration.CharacterConfig[characterId];
        thisCharacterConfig.SubExp = subExp;
        Save();
        WeakReferenceMessenger.Default.Send(new PlanChangeMessage());
    }

    public void UpdateWeapon(int characterRid, string weaponId)
    {
        if (!Configuration.CharacterConfig.ContainsKey(characterRid))
        {
            Configuration.CharacterConfig[characterRid] = new SingleBackpackCharacterConfigModel();
        }

        Configuration.CharacterConfig[characterRid].WeaponId = weaponId;
        Save();
        WeakReferenceMessenger.Default.Send(new CharacterWeaponChangeMessage(characterRid));
    }
}