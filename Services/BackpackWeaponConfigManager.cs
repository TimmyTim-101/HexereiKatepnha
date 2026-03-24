using CommunityToolkit.Mvvm.Messaging;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Models.ConfigModels;
using HexereiKatepnha.Models.Messages;

namespace HexereiKatepnha.Services;

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
        WeakReferenceMessenger.Default.Send(new BackpackWeaponChangeMessage(new BackpackWeaponChangeRecord(weaponStringId, thisWeaponConfig.Level, thisWeaponConfig.LevelGoal)));
    }

    public void UpdateLevelGoal(string weaponStringId, Enumeration.Level l)
    {
        SingleBackpackWeaponConfigModel thisWeaponConfig = Configuration.WeaponConfigMap[weaponStringId];
        thisWeaponConfig.LevelGoal = l;
        Save();
        App.CalculatorPlanSettingConfigManagerInstance!.UpdateWeaponPlanSetting(weaponStringId);
        WeakReferenceMessenger.Default.Send(new BackpackWeaponChangeMessage(new BackpackWeaponChangeRecord(weaponStringId, thisWeaponConfig.Level, thisWeaponConfig.LevelGoal)));
    }

    public void UpdateProgression(string weaponStringId, int i)
    {
        Configuration.WeaponConfigMap[weaponStringId].Progression = i;
        Save();
    }

    public SingleBackpackWeaponConfigModel AddWeapon(int rid)
    {
        SingleBackpackWeaponConfigModel thisConfig = new()
        {
            Rid = rid
        };
        string randomUniqueSign = Guid.NewGuid().ToString("N").Substring(0, 8);
        thisConfig.Id = $"{rid}${randomUniqueSign}";
        Configuration.WeaponConfigMap[thisConfig.Id] = thisConfig;
        Save();
        return thisConfig;
    }

    public void DeleteWeapon(string? id)
    {
        if (id == null) return;
        Configuration.WeaponConfigMap.Remove(id);
        Save();
        App.CalculatorPlanSettingConfigManagerInstance!.DeleteWeapon(id);
        WeakReferenceMessenger.Default.Send(new BackpackWeaponDeleteMessage(id));
    }
}