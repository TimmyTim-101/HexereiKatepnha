using CommunityToolkit.Mvvm.Messaging;
using HexereiKatepnha.Models.ConfigModels;
using HexereiKatepnha.Models.Messages;

namespace HexereiKatepnha.Services.ConfigService;

public class CalculatorPlanSettingConfigManager : ConfigManagerBase<CalculatorPlanSettingConfig>, IRecipient<CharacterInfoChangeMessage>, IRecipient<WeaponInfoChangeMessage>, IRecipient<WeaponDeleteMessage>
{
    protected sealed override string ConfigFileName { get; set; }

    public CalculatorPlanSettingConfigManager(Guid accountGuid)
    {
        ConfigFileName = "Configs/" + accountGuid + "/CalculatorPlanSetting.json";
        WeakReferenceMessenger.Default.Register<CharacterInfoChangeMessage>(this);
        WeakReferenceMessenger.Default.Register<WeaponInfoChangeMessage>(this);
        WeakReferenceMessenger.Default.Register<WeaponDeleteMessage>(this);
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
        WeakReferenceMessenger.Default.Send(new ItemGoalChangeMessage(rid.ToString()));
        WeakReferenceMessenger.Default.Send(new PlanChangeMessage());
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
        WeakReferenceMessenger.Default.Send(new ItemGoalChangeMessage(planId));
        WeakReferenceMessenger.Default.Send(new PlanChangeMessage());
    }

    public void UpdateTop(string planId)
    {
        if (Configuration.OrderList.Remove(planId))
        {
            Configuration.OrderList.Insert(0, planId);
            Save();
            WeakReferenceMessenger.Default.Send(new PlanChangeMessage());
        }
    }

    public void UpdateUp(string planId)
    {
        int index = Configuration.OrderList.IndexOf(planId);
        if (index > 0)
        {
            Configuration.OrderList.Move(index, index - 1);
            Save();
            WeakReferenceMessenger.Default.Send(new PlanChangeMessage());
        }
    }

    public void UpdateDown(string planId)
    {
        int index = Configuration.OrderList.IndexOf(planId);
        if (index < Configuration.OrderList.Count - 1 && index >= 0)
        {
            Configuration.OrderList.Move(index, index + 1);
            Save();
            WeakReferenceMessenger.Default.Send(new PlanChangeMessage());
        }
    }

    public void UpdateRecoveryTime(DateTimeOffset t)
    {
        Configuration.RecoveryTime = t;
        Save();
    }

    public void Receive(CharacterInfoChangeMessage message)
    {
        int characterRid = message.Value;
        UpdateCharacterPlanSetting(characterRid);
    }

    public void Receive(WeaponInfoChangeMessage message)
    {
        string weaponId = message.Value;
        UpdateWeaponPlanSetting(weaponId);
    }

    public void Receive(WeaponDeleteMessage message)
    {
        string weaponId = message.Value;
        if (Configuration.OrderList.Remove(weaponId))
        {
            Configuration.PlanMap.Remove(weaponId);
            Save();
            WeakReferenceMessenger.Default.Send(new ItemDeleteMessage(weaponId));
            WeakReferenceMessenger.Default.Send(new PlanChangeMessage());
        }
    }
}