using CommunityToolkit.Mvvm.Messaging;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Models.ConfigModels;
using HexereiKatepnha.Models.Messages;

namespace HexereiKatepnha.Services.ConfigService;

public class BackpackWeaponConfigManager : ConfigManagerBase<BackpackWeaponConfig>
{
    protected sealed override string ConfigFileName { get; set; }

    public BackpackWeaponConfigManager(Guid accountGuid)
    {
        ConfigFileName = "Configs/" + accountGuid + "/BackpackWeapon.json";
    }

    public void UpdateLevel(string weaponStringId, Enumeration.Level l)
    {
        SingleBackpackWeaponConfigModel thisWeaponConfig = Configuration.WeaponConfigMap[weaponStringId];
        thisWeaponConfig.Level = l;
        Save();
        App.CalculatorPlanSettingConfigManagerInstance!.UpdateWeaponPlanSetting(weaponStringId);
        WeakReferenceMessenger.Default.Send(new BackpackWeaponChangeMessage(new BackpackWeaponChangeRecord(weaponStringId, thisWeaponConfig.Level, thisWeaponConfig.GoalLevel)));
        App.RefreshGoalSimulation();
        if (Configuration.WeaponConfigMap[weaponStringId].CharacterRid != 0)
        {
            WeakReferenceMessenger.Default.Send(new BackpackWeaponChangeCharacterMessage(Configuration.WeaponConfigMap[weaponStringId].CharacterRid));
        }
    }

    public void UpdateLevelGoal(string weaponStringId, Enumeration.Level l)
    {
        SingleBackpackWeaponConfigModel thisWeaponConfig = Configuration.WeaponConfigMap[weaponStringId];
        thisWeaponConfig.GoalLevel = l;
        Save();
        App.CalculatorPlanSettingConfigManagerInstance!.UpdateWeaponPlanSetting(weaponStringId);
        WeakReferenceMessenger.Default.Send(new BackpackWeaponChangeMessage(new BackpackWeaponChangeRecord(weaponStringId, thisWeaponConfig.Level, thisWeaponConfig.GoalLevel)));
        App.RefreshGoalSimulation();
    }

    public void UpdateProgression(string weaponStringId, int i)
    {
        Configuration.WeaponConfigMap[weaponStringId].Progression = i;
        Save();
        if (Configuration.WeaponConfigMap[weaponStringId].CharacterRid != 0)
        {
            WeakReferenceMessenger.Default.Send(new BackpackWeaponChangeCharacterMessage(Configuration.WeaponConfigMap[weaponStringId].CharacterRid));
        }
    }

    public SingleBackpackWeaponConfigModel AddWeapon(int rid)
    {
        SingleBackpackWeaponConfigModel thisConfig = new()
        {
            Rid = rid
        };
        string randomUniqueSign = Guid.NewGuid().ToString("N");
        thisConfig.Id = $"{rid}${randomUniqueSign}";
        Configuration.WeaponConfigMap[thisConfig.Id] = thisConfig;
        Save();
        return thisConfig;
    }

    public void DeleteWeapon(string? id)
    {
        if (id == null) return;
        if (Configuration.WeaponConfigMap[id].CharacterRid != 0)
        {
            App.BackpackCharacterConfigManagerInstance!.UpdateWeapon(Configuration.WeaponConfigMap[id].CharacterRid, "");
        }

        Configuration.WeaponConfigMap.Remove(id);
        Save();
        App.CalculatorPlanSettingConfigManagerInstance!.DeleteWeapon(id);
        WeakReferenceMessenger.Default.Send(new BackpackWeaponDeleteMessage(id));
        App.RefreshGoalSimulation();
    }

    public void UpdateSubExp(string planId, int subExp)
    {
        Configuration.WeaponConfigMap[planId].SubExp = subExp;
        Save();
        App.RefreshGoalSimulation();
    }

    public void UpdateCharacter(string weaponId, int characterRid)
    {
        Configuration.WeaponConfigMap[weaponId].CharacterRid = characterRid;
        Save();
    }
}