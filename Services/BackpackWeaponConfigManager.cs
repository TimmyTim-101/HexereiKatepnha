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
        App.CalculatorPlanSettingConfigManagerInstance!.UpdatePlanSetting();
        Save();
    }

    public void UpdateLevelGoal(string weaponStringId, Enumeration.Level l)
    {
        Configuration.WeaponConfigMap[weaponStringId].LevelGoal = l;
        App.CalculatorPlanSettingConfigManagerInstance!.UpdatePlanSetting();
        Save();
    }

    public void UpdateProgression(string weaponStringId, int i)
    {
        Configuration.WeaponConfigMap[weaponStringId].Progression = i;
        Save();
    }

    public string AddWeapon(int rid)
    {
        SingleBackpackWeaponConfigModel thisConfig = new()
        {
            Rid = rid
        };
        string randomUniqueSign = Guid.NewGuid().ToString("N").Substring(0, 8);
        thisConfig.Id = $"{rid}${randomUniqueSign}";
        Configuration.WeaponConfigMap[thisConfig.Id] = thisConfig;
        Save();
        return thisConfig.Id;
    }

    public void DeleteWeapon(string? id)
    {
        if (id == null) return;
        Configuration.WeaponConfigMap.Remove(id);
        App.CalculatorPlanSettingConfigManagerInstance!.DeleteWeapon(id);
        Save();
    }
}