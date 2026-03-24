using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.ConfigModels;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.ModelsForViews.Calculator;

namespace HexereiKatepnha.ViewModels.Calculator
{
    public partial class Calculator7PlanSettingViewModel : ObservableObject
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
                        int thisLevelGoalIndex = SequenceConstants.AllLevels.IndexOf(App.BackpackWeaponConfigManagerInstance!.Configuration.WeaponConfigMap[thisPlanId].LevelGoal);
                        int biasLevelIndex = SequenceConstants.AllLevels.IndexOf(Enumeration.Level.L40);
                        thisCalculator7PlanSettingModel.ImagePath = thisLevelGoalIndex > biasLevelIndex ? thisWeapon.AwakenImagePath : thisWeapon.ImagePath;
                        thisCalculator7PlanSettingModel.StarBackgroundImagePath = StringConstants.StarBackgroundImagePath[thisWeapon.Star];
                        thisCalculator7PlanSettingModel.Name = thisWeapon.Name;
                        Enumeration.Level weaponLevel = App.BackpackWeaponConfigManagerInstance.Configuration.WeaponConfigMap[thisPlanId].Level;
                        Enumeration.Level weaponGoalLevel = App.BackpackWeaponConfigManagerInstance.Configuration.WeaponConfigMap[thisPlanId].LevelGoal;
                        if (weaponLevel != weaponGoalLevel) thisCalculator7PlanSettingModel.LevelString = $"等级： {StringConstants.LevelNumberString[weaponLevel]} → {StringConstants.LevelNumberString[weaponGoalLevel]}";
                        break;
                }

                tempPlanList.Add(thisCalculator7PlanSettingModel);
            }

            PlanList = tempPlanList;
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
    }
}