using HexereiKatepnha.Models.ConfigModels;

namespace HexereiKatepnha.Services.ConfigService;

public class CalculatorPlanSettingConfigManager : ConfigManagerBase<CalculatorPlanSettingConfig>
{
    protected override string ConfigFileName { get; set; }

    public CalculatorPlanSettingConfigManager(Guid accountGuid)
    {
        ConfigFileName = "Configs/" + accountGuid + "/CalculatorPlanSetting.json";
    }

    public void UpdateCharacterPlanSetting(int rid)
    {
        SingleBackpackCharacterConfigModel thisBackpackCharacterConfigModel = App.BackpackCharacterConfigManagerInstance!.Configuration.CharacterConfig[rid];
        bool isLevelDone = thisBackpackCharacterConfigModel.CharacterLevel == thisBackpackCharacterConfigModel.CharacterLevelGoal;
        bool isTalentADone = thisBackpackCharacterConfigModel.TalentALevel == thisBackpackCharacterConfigModel.TalentALevelGoal;
        bool isTalentEDone = thisBackpackCharacterConfigModel.TalentELevel == thisBackpackCharacterConfigModel.TalentELevelGoal;
        bool isTalentQDone = thisBackpackCharacterConfigModel.TalentQLevel == thisBackpackCharacterConfigModel.TalentQLevelGoal;
        if (isLevelDone && isTalentADone && isTalentEDone && isTalentQDone)
        {
            // 已完成所有目标，尝试清除
            if (Configuration.OrderList.Remove(rid.ToString()))
            {
                Configuration.PlanMap.Remove(rid.ToString());
            }
        }
        else
        {
            // 存在未完成目标，尝试更新
            if (!Configuration.OrderList.Contains(rid.ToString()))
            {
                // 不存在，需要新增
                SingleCalculatorPlanConfigModel thisConfig = new();
                thisConfig.Id = rid.ToString();
                thisConfig.Type = 1;
                thisConfig.Rid = rid;
                Configuration.OrderList.Add(thisConfig.Id);
                Configuration.PlanMap[thisConfig.Id] = thisConfig;
            }
        }

        Save();
        App.RefreshGoalSimulation();
    }

    public void UpdateWeaponPlanSetting(string planId)
    {
        SingleBackpackWeaponConfigModel thisSingleBackpackWeaponConfigModel = App.BackpackWeaponConfigManagerInstance!.Configuration.WeaponConfigMap[planId];
        bool isLevelDone = thisSingleBackpackWeaponConfigModel.Level == thisSingleBackpackWeaponConfigModel.GoalLevel;
        if (isLevelDone)
        {
            if (Configuration.OrderList.Remove(thisSingleBackpackWeaponConfigModel.Id))
            {
                Configuration.PlanMap.Remove(thisSingleBackpackWeaponConfigModel.Id);
            }
        }
        else
        {
            if (!Configuration.OrderList.Contains(thisSingleBackpackWeaponConfigModel.Id))
            {
                SingleCalculatorPlanConfigModel thisConfig = new();
                thisConfig.Id = thisSingleBackpackWeaponConfigModel.Id;
                thisConfig.Type = 2;
                thisConfig.Rid = thisSingleBackpackWeaponConfigModel.Rid;
                Configuration.OrderList.Add(thisConfig.Id);
                Configuration.PlanMap[thisConfig.Id] = thisConfig;
            }
        }

        Save();
        App.RefreshGoalSimulation();
    }

    public void UpdateTop(string planId)
    {
        if (Configuration.OrderList.Remove(planId))
        {
            Configuration.OrderList.Insert(0, planId);
            Save();
            App.RefreshGoalSimulation();
        }
    }

    public void UpdateUp(string planId)
    {
        int index = Configuration.OrderList.IndexOf(planId);
        if (index > 0)
        {
            Configuration.OrderList.Move(index, index - 1);
            Save();
            App.RefreshGoalSimulation();
        }
    }

    public void UpdateDown(string planId)
    {
        int index = Configuration.OrderList.IndexOf(planId);
        if (index < Configuration.OrderList.Count - 1 && index >= 0)
        {
            Configuration.OrderList.Move(index, index + 1);
            Save();
            App.RefreshGoalSimulation();
        }
    }

    public void DeleteWeapon(string? Id)
    {
        if (Id == null) return;
        if (Configuration.OrderList.Remove(Id))
        {
            Configuration.PlanMap.Remove(Id);
        }

        Save();
        App.RefreshGoalSimulation();
    }

    public void UpdateRecoveryTime(DateTimeOffset t)
    {
        Configuration.RecoveryTime = t;
        Save();
    }
}