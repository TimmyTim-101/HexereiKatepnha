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
            WeakReferenceMessenger.Default.Register<BackpackWeaponChangeMessage>(this, (recipient, message) =>
            {
                string thisPlanId = message.Value.PlanId;
                Enumeration.Level thisLevel = message.Value.Level;
                Enumeration.Level thisGoalLevel = message.Value.GoalLevel;
                int levelIndex = SequenceConstants.AllLevels.IndexOf(thisLevel);
                int goalLevelIndex = SequenceConstants.AllLevels.IndexOf(thisGoalLevel);
                Calculator7PlanSettingModel? thisPlan = null;
                foreach (Calculator7PlanSettingModel p in PlanList)
                {
                    if (p.Id == thisPlanId)
                    {
                        thisPlan = p;
                        break;
                    }
                }

                if (levelIndex == goalLevelIndex)
                {
                    if (thisPlan != null)
                    {
                        PlanList.Remove(thisPlan);
                        for (int i = 0; i < PlanList.Count; i++)
                        {
                            PlanList[i].Index = i + 1;
                        }
                    }
                }
                else
                {
                    if (thisPlan == null)
                    {
                        SingleCalculatorPlanConfigModel thisPlanConfig = App.CalculatorPlanSettingConfigManagerInstance.Configuration.PlanMap[thisPlanId];
                        Calculator7PlanSettingModel thisCalculator7PlanSettingModel = new()
                        {
                            Index = PlanList.Count + 1,
                            Id = thisPlanId
                        };
                        WeaponModel thisWeapon = AutoCalculateConstants.WeaponMap[thisPlanConfig.Rid];
                        int thisLevelGoalIndex = SequenceConstants.AllLevels.IndexOf(thisGoalLevel);
                        int biasLevelIndex = SequenceConstants.AllLevels.IndexOf(Enumeration.Level.L40);
                        thisCalculator7PlanSettingModel.ImagePath = thisLevelGoalIndex > biasLevelIndex ? thisWeapon.AwakenImagePath : thisWeapon.ImagePath;
                        thisCalculator7PlanSettingModel.StarBackgroundImagePath = StringConstants.StarBackgroundImagePath[thisWeapon.Star];
                        thisCalculator7PlanSettingModel.Name = thisWeapon.Name;
                        if (thisLevel != thisGoalLevel) thisCalculator7PlanSettingModel.LevelString = $"等级： {StringConstants.LevelNumberString[thisLevel]} → {StringConstants.LevelNumberString[thisGoalLevel]}";
                        PlanList.Add(thisCalculator7PlanSettingModel);
                    }
                    else
                    {
                        thisPlan.LevelString = $"等级： {StringConstants.LevelNumberString[thisLevel]} → {StringConstants.LevelNumberString[thisGoalLevel]}";
                        int thisLevelGoalIndex = SequenceConstants.AllLevels.IndexOf(App.BackpackWeaponConfigManagerInstance!.Configuration.WeaponConfigMap[thisPlanId].GoalLevel);
                        int biasLevelIndex = SequenceConstants.AllLevels.IndexOf(Enumeration.Level.L40);
                        SingleCalculatorPlanConfigModel thisWeaponConfig = App.CalculatorPlanSettingConfigManagerInstance.Configuration.PlanMap[thisPlanId];
                        WeaponModel thisWeapon = AutoCalculateConstants.WeaponMap[thisWeaponConfig.Rid];
                        thisPlan.ImagePath = thisLevelGoalIndex > biasLevelIndex ? thisWeapon.AwakenImagePath : thisWeapon.ImagePath;
                    }
                }
            });
            WeakReferenceMessenger.Default.Register<BackpackWeaponDeleteMessage>(this, (recipient, message) =>
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
                    for (int i = 0; i < PlanList.Count; i++)
                    {
                        PlanList[i].Index = i + 1;
                    }
                }
            });
            WeakReferenceMessenger.Default.Register<BackpackCharacterLevelChangeMessage>(this, (recipient, message) =>
            {
                string thisPlanId = message.Value.PlanId;
                Enumeration.Level thisLevel = message.Value.Level;
                Enumeration.Level thisGoalLevel = message.Value.GoalLevel;
                int levelIndex = SequenceConstants.AllLevels.IndexOf(thisLevel);
                int goalLevelIndex = SequenceConstants.AllLevels.IndexOf(thisGoalLevel);
                Calculator7PlanSettingModel? thisPlan = null;
                foreach (Calculator7PlanSettingModel p in PlanList)
                {
                    if (p.Id == thisPlanId)
                    {
                        thisPlan = p;
                        break;
                    }
                }

                if (levelIndex == goalLevelIndex)
                {
                    if (thisPlan != null)
                    {
                        thisPlan.LevelString = "";
                        if (thisPlan.LevelString == "" && thisPlan.TalentAString == "" && thisPlan.TalentEString == "" && thisPlan.TalentQString == "")
                        {
                            PlanList.Remove(thisPlan);
                        }
                    }
                }
                else
                {
                    if (thisPlan == null)
                    {
                        SingleCalculatorPlanConfigModel thisPlanConfig = App.CalculatorPlanSettingConfigManagerInstance.Configuration.PlanMap[thisPlanId];
                        Calculator7PlanSettingModel thisCalculator7PlanSettingModel = new()
                        {
                            Index = PlanList.Count + 1,
                            Id = thisPlanConfig.Id
                        };
                        CharacterModel thisCharacter = AutoCalculateConstants.CharacterMap[thisPlanConfig.Rid];
                        thisCalculator7PlanSettingModel.ImagePath = thisCharacter.ImagePath;
                        thisCalculator7PlanSettingModel.StarBackgroundImagePath = StringConstants.StarBackgroundImagePath[thisCharacter.Star];
                        thisCalculator7PlanSettingModel.Name = thisCharacter.Name;
                        thisCalculator7PlanSettingModel.ElementImagePath = StringConstants.ElementTypeImagePath[thisCharacter.ElementType];
                        SingleBackpackCharacterConfigModel thisCharacterConfig = App.BackpackCharacterConfigManagerInstance!.Configuration.CharacterConfig[thisPlanConfig.Rid];
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
                        PlanList.Add(thisCalculator7PlanSettingModel);
                    }
                    else
                    {
                        thisPlan.LevelString = $"等级： {StringConstants.LevelNumberString[thisLevel]} → {StringConstants.LevelNumberString[thisGoalLevel]}";
                    }
                }
            });
            WeakReferenceMessenger.Default.Register<BackpackCharacterTalentAChangeMessage>(this, (recipient, message) =>
            {
                string thisPlanId = message.Value.PlanId;
                Enumeration.Level thisTalentALevel = message.Value.Level;
                Enumeration.Level thisGoalTalentALevel = message.Value.GoalLevel;
                int levelIndex = SequenceConstants.AllLevels.IndexOf(thisTalentALevel);
                int goalLevelIndex = SequenceConstants.AllLevels.IndexOf(thisGoalTalentALevel);
                Calculator7PlanSettingModel? thisPlan = null;
                foreach (Calculator7PlanSettingModel p in PlanList)
                {
                    if (p.Id == thisPlanId)
                    {
                        thisPlan = p;
                        break;
                    }
                }

                if (levelIndex == goalLevelIndex)
                {
                    if (thisPlan != null)
                    {
                        thisPlan.TalentAString = "";
                        if (thisPlan.LevelString == "" && thisPlan.TalentAString == "" && thisPlan.TalentEString == "" && thisPlan.TalentQString == "")
                        {
                            PlanList.Remove(thisPlan);
                        }
                    }
                }
                else
                {
                    if (thisPlan == null)
                    {
                        SingleCalculatorPlanConfigModel thisPlanConfig = App.CalculatorPlanSettingConfigManagerInstance.Configuration.PlanMap[thisPlanId];
                        Calculator7PlanSettingModel thisCalculator7PlanSettingModel = new()
                        {
                            Index = PlanList.Count + 1,
                            Id = thisPlanConfig.Id
                        };
                        CharacterModel thisCharacter = AutoCalculateConstants.CharacterMap[thisPlanConfig.Rid];
                        thisCalculator7PlanSettingModel.ImagePath = thisCharacter.ImagePath;
                        thisCalculator7PlanSettingModel.StarBackgroundImagePath = StringConstants.StarBackgroundImagePath[thisCharacter.Star];
                        thisCalculator7PlanSettingModel.Name = thisCharacter.Name;
                        thisCalculator7PlanSettingModel.ElementImagePath = StringConstants.ElementTypeImagePath[thisCharacter.ElementType];
                        SingleBackpackCharacterConfigModel thisCharacterConfig = App.BackpackCharacterConfigManagerInstance!.Configuration.CharacterConfig[thisPlanConfig.Rid];
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
                        PlanList.Add(thisCalculator7PlanSettingModel);
                    }
                    else
                    {
                        thisPlan.TalentAString = $"A： {StringConstants.LevelNumberString[thisTalentALevel]} → {StringConstants.LevelNumberString[thisGoalTalentALevel]}";
                    }
                }
            });
            WeakReferenceMessenger.Default.Register<BackpackCharacterTalentEChangeMessage>(this, (recipient, message) =>
            {
                string thisPlanId = message.Value.PlanId;
                Enumeration.Level thisTalentELevel = message.Value.Level;
                Enumeration.Level thisGoalTalentELevel = message.Value.GoalLevel;
                int levelIndex = SequenceConstants.AllLevels.IndexOf(thisTalentELevel);
                int goalLevelIndex = SequenceConstants.AllLevels.IndexOf(thisGoalTalentELevel);
                Calculator7PlanSettingModel? thisPlan = null;
                foreach (Calculator7PlanSettingModel p in PlanList)
                {
                    if (p.Id == thisPlanId)
                    {
                        thisPlan = p;
                        break;
                    }
                }

                if (levelIndex == goalLevelIndex)
                {
                    if (thisPlan != null)
                    {
                        thisPlan.TalentEString = "";
                        if (thisPlan.LevelString == "" && thisPlan.TalentAString == "" && thisPlan.TalentEString == "" && thisPlan.TalentQString == "")
                        {
                            PlanList.Remove(thisPlan);
                        }
                    }
                }
                else
                {
                    if (thisPlan == null)
                    {
                        SingleCalculatorPlanConfigModel thisPlanConfig = App.CalculatorPlanSettingConfigManagerInstance.Configuration.PlanMap[thisPlanId];
                        Calculator7PlanSettingModel thisCalculator7PlanSettingModel = new()
                        {
                            Index = PlanList.Count + 1,
                            Id = thisPlanConfig.Id
                        };
                        CharacterModel thisCharacter = AutoCalculateConstants.CharacterMap[thisPlanConfig.Rid];
                        thisCalculator7PlanSettingModel.ImagePath = thisCharacter.ImagePath;
                        thisCalculator7PlanSettingModel.StarBackgroundImagePath = StringConstants.StarBackgroundImagePath[thisCharacter.Star];
                        thisCalculator7PlanSettingModel.Name = thisCharacter.Name;
                        thisCalculator7PlanSettingModel.ElementImagePath = StringConstants.ElementTypeImagePath[thisCharacter.ElementType];
                        SingleBackpackCharacterConfigModel thisCharacterConfig = App.BackpackCharacterConfigManagerInstance!.Configuration.CharacterConfig[thisPlanConfig.Rid];
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
                        PlanList.Add(thisCalculator7PlanSettingModel);
                    }
                    else
                    {
                        thisPlan.TalentEString = $"E： {StringConstants.LevelNumberString[thisTalentELevel]} → {StringConstants.LevelNumberString[thisGoalTalentELevel]}";
                    }
                }
            });
            WeakReferenceMessenger.Default.Register<BackpackCharacterTalentQChangeMessage>(this, (recipient, message) =>
            {
                string thisPlanId = message.Value.PlanId;
                Enumeration.Level thisTalentQLevel = message.Value.Level;
                Enumeration.Level thisGoalTalentQLevel = message.Value.GoalLevel;
                int levelIndex = SequenceConstants.AllLevels.IndexOf(thisTalentQLevel);
                int goalLevelIndex = SequenceConstants.AllLevels.IndexOf(thisGoalTalentQLevel);
                Calculator7PlanSettingModel? thisPlan = null;
                foreach (Calculator7PlanSettingModel p in PlanList)
                {
                    if (p.Id == thisPlanId)
                    {
                        thisPlan = p;
                        break;
                    }
                }

                if (levelIndex == goalLevelIndex)
                {
                    if (thisPlan != null)
                    {
                        thisPlan.TalentQString = "";
                        if (thisPlan.LevelString == "" && thisPlan.TalentAString == "" && thisPlan.TalentEString == "" && thisPlan.TalentQString == "")
                        {
                            PlanList.Remove(thisPlan);
                        }
                    }
                }
                else
                {
                    if (thisPlan == null)
                    {
                        SingleCalculatorPlanConfigModel thisPlanConfig = App.CalculatorPlanSettingConfigManagerInstance.Configuration.PlanMap[thisPlanId];
                        Calculator7PlanSettingModel thisCalculator7PlanSettingModel = new()
                        {
                            Index = PlanList.Count + 1,
                            Id = thisPlanConfig.Id
                        };
                        CharacterModel thisCharacter = AutoCalculateConstants.CharacterMap[thisPlanConfig.Rid];
                        thisCalculator7PlanSettingModel.ImagePath = thisCharacter.ImagePath;
                        thisCalculator7PlanSettingModel.StarBackgroundImagePath = StringConstants.StarBackgroundImagePath[thisCharacter.Star];
                        thisCalculator7PlanSettingModel.Name = thisCharacter.Name;
                        thisCalculator7PlanSettingModel.ElementImagePath = StringConstants.ElementTypeImagePath[thisCharacter.ElementType];
                        SingleBackpackCharacterConfigModel thisCharacterConfig = App.BackpackCharacterConfigManagerInstance!.Configuration.CharacterConfig[thisPlanConfig.Rid];
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
                        PlanList.Add(thisCalculator7PlanSettingModel);
                    }
                    else
                    {
                        thisPlan.TalentQString = $"Q： {StringConstants.LevelNumberString[thisTalentQLevel]} → {StringConstants.LevelNumberString[thisGoalTalentQLevel]}";
                    }
                }
            });
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