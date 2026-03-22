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
        public ObservableCollection<Calculator7PlanSettingModel> PlanList { get; set; } = new();

        public Calculator7PlanSettingViewModel()
        {
            Refresh();
        }

        private void Refresh()
        {
            PlanList.Clear();
            ObservableCollection<string> currentOrderList = App.CalculatorPlanSettingConfigManagerInstance!.Configuration.OrderList;
            Dictionary<string, SingleCalculatorPlanConfigModel> currentPlanMap = App.CalculatorPlanSettingConfigManagerInstance!.Configuration.PlanMap;
            for (int i = 0; i < currentOrderList.Count; i++)
            {
                string thisPlanId = currentOrderList[i];
                SingleCalculatorPlanConfigModel thisConfig = currentPlanMap[thisPlanId];
                int thisType = thisConfig.Type;
                int thisRid = thisConfig.Rid;
                Calculator7PlanSettingModel thisCalculator7PlanSettingModel = new();
                thisCalculator7PlanSettingModel.Index = PlanList.Count + 1;
                thisCalculator7PlanSettingModel.Id = thisPlanId;
                switch (thisType)
                {
                    case 1:
                        CharacterModel thisCharacter = AutoCalculateConstants.CharacterMap[thisRid];
                        thisCalculator7PlanSettingModel.ImagePath = thisCharacter.ImagePath;
                        thisCalculator7PlanSettingModel.StarBackgroundImagePath = StringConstants.StarBackgroundImagePath[thisCharacter.Star];
                        thisCalculator7PlanSettingModel.Name = thisCharacter.Name;
                        thisCalculator7PlanSettingModel.ElementImagePath = StringConstants.ElementTypeImagePath[thisCharacter.ElementType];
                        Enumeration.Level level = App.BackpackCharacterConfigManagerInstance!.Configuration.CharacterConfig[thisRid].CharacterLevel;
                        Enumeration.Level goalLevel = App.BackpackCharacterConfigManagerInstance!.Configuration.CharacterConfig[thisRid].CharacterLevelGoal;
                        if (level != goalLevel) thisCalculator7PlanSettingModel.LevelString = $"等级： {StringConstants.LevelNumberString[level]} → {StringConstants.LevelNumberString[goalLevel]}";
                        Enumeration.Level talentALevel = App.BackpackCharacterConfigManagerInstance!.Configuration.CharacterConfig[thisRid].TalentALevel;
                        Enumeration.Level talentAGoalLevel = App.BackpackCharacterConfigManagerInstance!.Configuration.CharacterConfig[thisRid].TalentALevelGoal;
                        if (talentALevel != talentAGoalLevel) thisCalculator7PlanSettingModel.TalentAString = $"A： {StringConstants.LevelNumberString[talentALevel]} → {StringConstants.LevelNumberString[talentAGoalLevel]}";
                        Enumeration.Level talentELevel = App.BackpackCharacterConfigManagerInstance!.Configuration.CharacterConfig[thisRid].TalentELevel;
                        Enumeration.Level talentEGoalLevel = App.BackpackCharacterConfigManagerInstance!.Configuration.CharacterConfig[thisRid].TalentELevelGoal;
                        if (talentELevel != talentEGoalLevel) thisCalculator7PlanSettingModel.TalentEString = $"E： {StringConstants.LevelNumberString[talentELevel]} → {StringConstants.LevelNumberString[talentEGoalLevel]}";
                        Enumeration.Level talentQLevel = App.BackpackCharacterConfigManagerInstance!.Configuration.CharacterConfig[thisRid].TalentQLevel;
                        Enumeration.Level talentQGoalLevel = App.BackpackCharacterConfigManagerInstance!.Configuration.CharacterConfig[thisRid].TalentQLevelGoal;
                        if (talentQLevel != talentQGoalLevel) thisCalculator7PlanSettingModel.TalentQString = $"Q： {StringConstants.LevelNumberString[talentQLevel]} → {StringConstants.LevelNumberString[talentQGoalLevel]}";
                        break;
                    case 2:
                        WeaponModel thisWeapon = AutoCalculateConstants.WeaponMap[thisRid];
                        int thisLevelGoalIndex = SequenceConstants.AllLevels.IndexOf(App.BackpackWeaponConfigManagerInstance!.Configuration.WeaponConfigMap[thisPlanId].LevelGoal);
                        int biasLevelIndex = SequenceConstants.AllLevels.IndexOf(Enumeration.Level.L40);
                        thisCalculator7PlanSettingModel.ImagePath = thisLevelGoalIndex > biasLevelIndex ? thisWeapon.AwakenImagePath : thisWeapon.ImagePath;
                        thisCalculator7PlanSettingModel.StarBackgroundImagePath = StringConstants.StarBackgroundImagePath[thisWeapon.Star];
                        thisCalculator7PlanSettingModel.Name = thisWeapon.Name;
                        Enumeration.Level weaponLevel = App.BackpackWeaponConfigManagerInstance!.Configuration.WeaponConfigMap[thisPlanId].Level;
                        Enumeration.Level weaponGoalLevel = App.BackpackWeaponConfigManagerInstance!.Configuration.WeaponConfigMap[thisPlanId].LevelGoal;
                        if (weaponLevel != weaponGoalLevel) thisCalculator7PlanSettingModel.LevelString = $"等级： {StringConstants.LevelNumberString[weaponLevel]} → {StringConstants.LevelNumberString[weaponGoalLevel]}";
                        break;
                }

                PlanList.Add(thisCalculator7PlanSettingModel);
            }
        }

        [RelayCommand]
        private void ClickOnTop(String value)
        {
            App.CalculatorPlanSettingConfigManagerInstance!.UpdateTop(value);
            Refresh();
        }

        [RelayCommand]
        private void ClickOnUp(String value)
        {
            App.CalculatorPlanSettingConfigManagerInstance!.UpdateUp(value);
            Refresh();
        }

        [RelayCommand]
        private void ClickOnDown(String value)
        {
            App.CalculatorPlanSettingConfigManagerInstance!.UpdateDown(value);
            Refresh();
        }
    }
}