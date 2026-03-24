using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Models.ConfigModels;

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
        Configuration.WeaponConfigMap[weaponStringId].Level = l;
        Save();
        App.CalculatorPlanSettingConfigManagerInstance!.UpdatePlanSetting();
    }

    public void UpdateLevelGoal(string weaponStringId, Enumeration.Level l)
    {
        Configuration.WeaponConfigMap[weaponStringId].LevelGoal = l;
        Save();
        App.CalculatorPlanSettingConfigManagerInstance!.UpdatePlanSetting();
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
    }
}