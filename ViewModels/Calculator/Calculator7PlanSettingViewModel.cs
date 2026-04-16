using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.ConfigModels;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.Messages;
using HexereiKatepnha.Models.ModelsForViews.Calculator;

namespace HexereiKatepnha.ViewModels.Calculator
{
    public partial class Calculator7PlanSettingViewModel : ObservableObject, IRecipient<ItemGoalChangeMessage>, IRecipient<ItemDeleteMessage>
    {
        public ObservableCollection<Calculator7PlanSettingModel> PlanList { get; set; }

        public Calculator7PlanSettingViewModel()
        {
            ObservableCollection<string> currentOrderList = App.CalculatorPlanSettingConfigManagerInstance!.Configuration.OrderList;
            Dictionary<string, SingleCalculatorPlanConfigModel> currentPlanMap = App.CalculatorPlanSettingConfigManagerInstance.Configuration.PlanMap;
            ObservableCollection<Calculator7PlanSettingModel> tempPlanList = new();
            for (int i = 0; i < currentOrderList.Count; i++)
            {
                string thisPlanId = currentOrderList[i];
                SingleCalculatorPlanConfigModel thisConfig = currentPlanMap[thisPlanId];
                int thisType = thisConfig.Type;
                int thisRid = thisConfig.Rid;
                Calculator7PlanSettingModel thisCalculator7PlanSettingModel = new()
                {
                    Index = tempPlanList.Count + 1,
                    Id = thisPlanId
                };
                switch (thisType)
                {
                    case 1:
                        CharacterModel thisCharacter = AutoCalculateConstants.CharacterMap[thisRid];
                        thisCalculator7PlanSettingModel.ImagePath = thisCharacter.ImagePath;
                        thisCalculator7PlanSettingModel.StarBackgroundImagePath = StringConstants.StarBackgroundImagePath[thisCharacter.Star];
                        thisCalculator7PlanSettingModel.Name = thisCharacter.Name;
                        thisCalculator7PlanSettingModel.ElementImagePath = StringConstants.ElementTypeImagePath[thisCharacter.ElementType];
                        SingleBackpackCharacterConfigModel thisCharacterConfig = App.BackpackCharacterConfigManagerInstance!.Configuration.CharacterConfig[thisRid];
                        Enumeration.Level level = thisCharacterConfig.CharacterLevel;
                        Enumeration.Level goalLevel = thisCharacterConfig.CharacterLevelGoal;
                        if (level != goalLevel) thisCalculator7PlanSettingModel.LevelString = $"等级： {StringConstants.LevelNumberString[level]} → {StringConstants.LevelNumberString[goalLevel]}";
                        Enumeration.Level talentALevel = thisCharacterConfig.TalentALevel;
                        Enumeration.Level talentAGoalLevel = thisCharacterConfig.TalentALevelGoal;
                        if (talentALevel != talentAGoalLevel) thisCalculator7PlanSettingModel.TalentAString = $"A： {StringConstants.LevelNumberString[talentALevel]} → {StringConstants.LevelNumberString[talentAGoalLevel]}";
                        Enumeration.Level talentELevel = thisCharacterConfig.TalentELevel;
                        Enumeration.Level talentEGoalLevel = thisCharacterConfig.TalentELevelGoal;
                        if (talentELevel != talentEGoalLevel) thisCalculator7PlanSettingModel.TalentEString = $"E： {StringConstants.LevelNumberString[talentELevel]} → {StringConstants.LevelNumberString[talentEGoalLevel]}";
                        Enumeration.Level talentQLevel = thisCharacterConfig.TalentQLevel;
                        Enumeration.Level talentQGoalLevel = thisCharacterConfig.TalentQLevelGoal;
                        if (talentQLevel != talentQGoalLevel) thisCalculator7PlanSettingModel.TalentQString = $"Q： {StringConstants.LevelNumberString[talentQLevel]} → {StringConstants.LevelNumberString[talentQGoalLevel]}";
                        break;
                    case 2:
                        WeaponModel thisWeapon = AutoCalculateConstants.WeaponMap[thisRid];
                        int thisLevelGoalIndex = SequenceConstants.AllLevels.IndexOf(App.BackpackWeaponConfigManagerInstance!.Configuration.WeaponConfigMap[thisPlanId].GoalLevel);
                        int biasLevelIndex = SequenceConstants.AllLevels.IndexOf(Enumeration.Level.L40);
                        thisCalculator7PlanSettingModel.ImagePath = thisLevelGoalIndex > biasLevelIndex ? thisWeapon.AwakenImagePath : thisWeapon.ImagePath;
                        thisCalculator7PlanSettingModel.StarBackgroundImagePath = StringConstants.StarBackgroundImagePath[thisWeapon.Star];
                        thisCalculator7PlanSettingModel.Name = thisWeapon.Name;
                        Enumeration.Level weaponLevel = App.BackpackWeaponConfigManagerInstance.Configuration.WeaponConfigMap[thisPlanId].Level;
                        Enumeration.Level weaponGoalLevel = App.BackpackWeaponConfigManagerInstance.Configuration.WeaponConfigMap[thisPlanId].GoalLevel;
                        if (weaponLevel != weaponGoalLevel) thisCalculator7PlanSettingModel.LevelString = $"等级： {StringConstants.LevelNumberString[weaponLevel]} → {StringConstants.LevelNumberString[weaponGoalLevel]}";
                        break;
                }

                tempPlanList.Add(thisCalculator7PlanSettingModel);
            }

            PlanList = tempPlanList;
            WeakReferenceMessenger.Default.Register<ItemGoalChangeMessage>(this);
            WeakReferenceMessenger.Default.Register<ItemDeleteMessage>(this);
        }

        [RelayCommand]
        private void ClickOnTop(String value)
        {
            App.CalculatorPlanSettingConfigManagerInstance!.UpdateTop(value);
            int thisIndex = FindIndex(value);
            if (thisIndex > 0)
            {
                PlanList.Move(thisIndex, 0);
                RefreshIndex();
            }
        }

        [RelayCommand]
        private void ClickOnUp(String value)
        {
            App.CalculatorPlanSettingConfigManagerInstance!.UpdateUp(value);
            int thisIndex = FindIndex(value);
            if (thisIndex > 0)
            {
                PlanList.Move(thisIndex, thisIndex - 1);
                RefreshIndex();
            }
        }

        [RelayCommand]
        private void ClickOnDown(String value)
        {
            App.CalculatorPlanSettingConfigManagerInstance!.UpdateDown(value);
            int thisIndex = FindIndex(value);
            if (thisIndex >= 0 && thisIndex < PlanList.Count - 1)
            {
                PlanList.Move(thisIndex, thisIndex + 1);
                RefreshIndex();
            }
        }

        private int FindIndex(string id)
        {
            int index = -1;
            for (int i = 0; i < PlanList.Count; i++)
            {
                if (PlanList[i].Id == id) return i;
            }

            return index;
        }

        private void RefreshIndex()
        {
            for (int i = 0; i < PlanList.Count; i++)
            {
                PlanList[i].Index = i + 1;
            }
        }

        public void Receive(ItemGoalChangeMessage message)
        {
            string planId = message.Value;
            Calculator7PlanSettingModel? thisPlan = null;
            foreach (Calculator7PlanSettingModel p in PlanList)
            {
                if (p.Id == planId)
                {
                    thisPlan = p;
                    break;
                }
            }

            // 判断是否为新plan
            if (thisPlan == null)
            {
                thisPlan = new Calculator7PlanSettingModel();
                thisPlan.Id = planId;
                PlanList.Add(thisPlan);
            }

            SingleCalculatorPlanConfigModel thisPlanModel = App.CalculatorPlanSettingConfigManagerInstance!.Configuration.PlanMap[planId];
            int thisPlanType = thisPlanModel.Type;
            int thisPlanItemRid = thisPlanModel.Rid;
            switch (thisPlanType)
            {
                case 1:
                    // 角色
                    CharacterModel thisCharacterModel = AutoCalculateConstants.CharacterMap[thisPlanItemRid];
                    if (thisPlan.ImagePath == "") thisPlan.ImagePath = thisCharacterModel.ImagePath;
                    if (thisPlan.StarBackgroundImagePath == "") thisPlan.StarBackgroundImagePath = StringConstants.StarBackgroundImagePath[thisCharacterModel.Star];
                    if (thisPlan.ElementImagePath == "") thisPlan.ElementImagePath = StringConstants.ElementTypeImagePath[thisCharacterModel.ElementType];
                    if (thisPlan.Name == "") thisPlan.Name = thisCharacterModel.Name;
                    SingleBackpackCharacterConfigModel thisCharacterConfig = App.BackpackCharacterConfigManagerInstance!.GetBackpackCharacterConfig(thisPlanItemRid);
                    Enumeration.Level characterLevel = thisCharacterConfig.CharacterLevel;
                    Enumeration.Level characterGoalLevel = thisCharacterConfig.CharacterLevelGoal;
                    thisPlan.LevelString = characterLevel == characterGoalLevel ? "" : $"等级： {StringConstants.LevelNumberString[characterLevel]} → {StringConstants.LevelNumberString[characterGoalLevel]}";
                    Enumeration.Level characterTalentA = thisCharacterConfig.TalentALevel;
                    Enumeration.Level characterTalentAGoal = thisCharacterConfig.TalentALevelGoal;
                    thisPlan.TalentAString = characterTalentA == characterTalentAGoal ? "" : $"A： {StringConstants.LevelNumberString[characterTalentA]} → {StringConstants.LevelNumberString[characterTalentAGoal]}";
                    Enumeration.Level characterTalentE = thisCharacterConfig.TalentELevel;
                    Enumeration.Level characterTalentEGoal = thisCharacterConfig.TalentELevelGoal;
                    thisPlan.TalentEString = characterTalentE == characterTalentEGoal ? "" : $"E： {StringConstants.LevelNumberString[characterTalentE]} → {StringConstants.LevelNumberString[characterTalentEGoal]}";
                    Enumeration.Level characterTalentQ = thisCharacterConfig.TalentQLevel;
                    Enumeration.Level characterTalentQGoal = thisCharacterConfig.TalentQLevelGoal;
                    thisPlan.TalentQString = characterTalentQ == characterTalentQGoal ? "" : $"Q： {StringConstants.LevelNumberString[characterTalentQ]} → {StringConstants.LevelNumberString[characterTalentQGoal]}";
                    break;
                case 2:
                    // 武器
                    WeaponModel thisWeaponModel = AutoCalculateConstants.WeaponMap[thisPlanItemRid];
                    int thisLevelGoalIndex = SequenceConstants.AllLevels.IndexOf(App.BackpackWeaponConfigManagerInstance!.Configuration.WeaponConfigMap[planId].GoalLevel);
                    int biasLevelIndex = SequenceConstants.AllLevels.IndexOf(Enumeration.Level.L40);
                    thisPlan.ImagePath = thisLevelGoalIndex > biasLevelIndex ? thisWeaponModel.AwakenImagePath : thisWeaponModel.ImagePath;
                    if (thisPlan.StarBackgroundImagePath == "") thisPlan.StarBackgroundImagePath = StringConstants.StarBackgroundImagePath[thisWeaponModel.Star];
                    if (thisPlan.Name == "") thisPlan.Name = thisWeaponModel.Name;
                    SingleBackpackWeaponConfigModel thisWeaponConfig = App.BackpackWeaponConfigManagerInstance.Configuration.WeaponConfigMap[planId];
                    Enumeration.Level weaponLevel = thisWeaponConfig.Level;
                    Enumeration.Level weaponGoalLevel = thisWeaponConfig.GoalLevel;
                    thisPlan.LevelString = weaponLevel == weaponGoalLevel ? "" : $"等级： {StringConstants.LevelNumberString[weaponLevel]} → {StringConstants.LevelNumberString[weaponGoalLevel]}";
                    break;
            }

            // 判断plan是否完成
            if (thisPlan is { LevelString: "", TalentAString: "", TalentEString: "", TalentQString: "" })
            {
                PlanList.Remove(thisPlan);
            }

            RefreshIndex();
        }

        public void Receive(ItemDeleteMessage message)
        {
            string thisPlanId = message.Value;
            Calculator7PlanSettingModel? thisPlan = null;
            foreach (Calculator7PlanSettingModel p in PlanList)
            {
                if (p.Id == thisPlanId)
                {
                    thisPlan = p;
                    break;
                }
            }

            if (thisPlan != null)
            {
                PlanList.Remove(thisPlan);
            }

            RefreshIndex();
        }
    }
}