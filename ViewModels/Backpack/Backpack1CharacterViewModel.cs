using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.ConfigModels;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.Messages;
using HexereiKatepnha.Models.ModelsForViews.Backpack;
using HexereiKatepnha.Models.ModelsForViews.Calculator;
using HexereiKatepnha.Services.CalculatorService;

namespace HexereiKatepnha.ViewModels.Backpack
{
    public partial class Backpack1CharacterViewModel : ObservableObject, IRecipient<WeaponInfoUpdateToCharacterMessage>, IRecipient<CharacterWeaponChangeMessage>, IRecipient<CharacterInfoChangeMessage>, IRecipient<BackpackMaterialConfigChangeMessage>, IRecipient<GoalSimulatorChangeMessage>
    {
        [ObservableProperty] private int _elementFilter;
        [ObservableProperty] private int _weaponFilter;
        [ObservableProperty] private int _starFilter;
        [ObservableProperty] private bool _isHideLowLevelCharacter;
        private ObservableCollection<Backpack1CharacterModel> AllCharacterList { get; } = [];
        [ObservableProperty] private Backpack1CharacterModel _selectedCharacter;
        [ObservableProperty] private SingleCharacterSimulatorService _selectedCharacterSimulatorService;
        [ObservableProperty] private BackpackCharacterPlanInfo _selectedCharacterPlanInfo;
        [ObservableProperty] private bool _isLevelPopupOpen;
        [ObservableProperty] private bool _isTalentAPopupOpen;
        [ObservableProperty] private bool _isTalentEPopupOpen;
        [ObservableProperty] private bool _isTalentQPopupOpen;
        [ObservableProperty] private bool _isAscensionPopupOpen;
        [ObservableProperty] private bool _isSubExpPopupOpen;
        [ObservableProperty] private List<Backpack1CharacterModel> _characterView = [];
        public string Element1ImagePath { get; set; } = StringConstants.ElementTypeImagePath[Enumeration.ElementType.Pyro];
        public string Element2ImagePath { get; set; } = StringConstants.ElementTypeImagePath[Enumeration.ElementType.Hydro];
        public string Element3ImagePath { get; set; } = StringConstants.ElementTypeImagePath[Enumeration.ElementType.Anemo];
        public string Element4ImagePath { get; set; } = StringConstants.ElementTypeImagePath[Enumeration.ElementType.Electro];
        public string Element5ImagePath { get; set; } = StringConstants.ElementTypeImagePath[Enumeration.ElementType.Dendro];
        public string Element6ImagePath { get; set; } = StringConstants.ElementTypeImagePath[Enumeration.ElementType.Cryo];
        public string Element7ImagePath { get; set; } = StringConstants.ElementTypeImagePath[Enumeration.ElementType.Geo];
        public string Weapon1ImagePath { get; set; } = StringConstants.WeaponTypeImagePath[Enumeration.WeaponType.Sword];
        public string Weapon2ImagePath { get; set; } = StringConstants.WeaponTypeImagePath[Enumeration.WeaponType.Claymore];
        public string Weapon3ImagePath { get; set; } = StringConstants.WeaponTypeImagePath[Enumeration.WeaponType.Pole];
        public string Weapon4ImagePath { get; set; } = StringConstants.WeaponTypeImagePath[Enumeration.WeaponType.Catalyst];
        public string Weapon5ImagePath { get; set; } = StringConstants.WeaponTypeImagePath[Enumeration.WeaponType.Bow];
        public string Star4ImagePath { get; set; } = StringConstants.StarImagePath[4];
        public string Star5ImagePath { get; set; } = StringConstants.StarImagePath[5];

        private readonly List<Enumeration.ElementType> _elementTypeSortList =
        [
            Enumeration.ElementType.Geo,
            Enumeration.ElementType.Anemo,
            Enumeration.ElementType.Cryo,
            Enumeration.ElementType.Electro,
            Enumeration.ElementType.Dendro,
            Enumeration.ElementType.Hydro,
            Enumeration.ElementType.Pyro,
            Enumeration.ElementType.Unknown,
        ];

        public Backpack1CharacterViewModel()
        {
            foreach (CharacterModel e in AllEntities.AllCharacter)
            {
                Backpack1CharacterModel thisBackpack1CharacterModel = new Backpack1CharacterModel
                {
                    Rid = e.Rid,
                    ImagePath = e.ImagePath,
                    ElementType = e.ElementType,
                    ElementImagePath = StringConstants.ElementTypeImagePath[e.ElementType],
                    BackgroundImagePath = StringConstants.StarBackgroundImagePath[e.Star],
                    Name = e.Name,
                    Star = e.Star,
                    WeaponType = e.WeaponType,
                    CharacterConfigModel = App.BackpackCharacterConfigManagerInstance!.GetBackpackCharacterConfig(e.Rid)
                };
                thisBackpack1CharacterModel.LevelNameString = StringConstants.LevelNameString[thisBackpack1CharacterModel.CharacterConfigModel.CharacterLevel];
                thisBackpack1CharacterModel.LevelNumberString = StringConstants.LevelNumberString[thisBackpack1CharacterModel.CharacterConfigModel.CharacterLevel];
                thisBackpack1CharacterModel.LevelTotalExp = GetLevelTotalExp(e.LevelUpMaterials.GetValueOrDefault(thisBackpack1CharacterModel.CharacterConfigModel.CharacterLevel, []));
                thisBackpack1CharacterModel.SubExp = thisBackpack1CharacterModel.CharacterConfigModel.SubExp;
                thisBackpack1CharacterModel.IsShowProgress = !SequenceConstants.NoExpLevels.Contains(thisBackpack1CharacterModel.CharacterConfigModel.CharacterLevel);
                thisBackpack1CharacterModel.TalentAString = StringConstants.LevelNumberString[thisBackpack1CharacterModel.CharacterConfigModel.TalentALevel];
                thisBackpack1CharacterModel.TalentEString = StringConstants.LevelNumberString[thisBackpack1CharacterModel.CharacterConfigModel.TalentELevel];
                thisBackpack1CharacterModel.TalentQString = StringConstants.LevelNumberString[thisBackpack1CharacterModel.CharacterConfigModel.TalentQLevel];
                thisBackpack1CharacterModel.LevelGoalNumberString = StringConstants.LevelNumberString[thisBackpack1CharacterModel.CharacterConfigModel.CharacterLevelGoal];
                thisBackpack1CharacterModel.TalentAGoalString = StringConstants.LevelNumberString[thisBackpack1CharacterModel.CharacterConfigModel.TalentALevelGoal];
                thisBackpack1CharacterModel.TalentEGoalString = StringConstants.LevelNumberString[thisBackpack1CharacterModel.CharacterConfigModel.TalentELevelGoal];
                thisBackpack1CharacterModel.TalentQGoalString = StringConstants.LevelNumberString[thisBackpack1CharacterModel.CharacterConfigModel.TalentQLevelGoal];
                thisBackpack1CharacterModel.TalentPropertyDictionary = e.Talent;
                thisBackpack1CharacterModel.ConstellationPropertyDictionary = e.Constellation;
                for (int i = 1; i <= 6; i++)
                {
                    thisBackpack1CharacterModel.AscensionOpacityList[i] = i <= thisBackpack1CharacterModel.CharacterConfigModel.Constellation ? 1.0 : 0.1;
                }

                if (thisBackpack1CharacterModel.CharacterConfigModel.WeaponId != "")
                {
                    string thisWeaponId = thisBackpack1CharacterModel.CharacterConfigModel.WeaponId;
                    SingleBackpackWeaponConfigModel thisWeaponConfig = App.BackpackWeaponConfigManagerInstance!.Configuration.WeaponConfigMap[thisWeaponId];
                    int thisWeaponRid = thisWeaponConfig.Rid;
                    WeaponModel thisWeapon = AutoCalculateConstants.WeaponMap[thisWeaponRid];
                    thisBackpack1CharacterModel.WeaponBackgroundImagePath = StringConstants.StarBackgroundImagePath[thisWeapon.Star];
                    thisBackpack1CharacterModel.WeaponImagePath = thisWeapon.AwakenImagePath;
                    thisBackpack1CharacterModel.WeaponName = thisWeapon.Name;
                    thisBackpack1CharacterModel.WeaponProgression = thisWeaponConfig.Progression;
                    thisBackpack1CharacterModel.WeaponLevelString = StringConstants.LevelNameString[thisWeaponConfig.Level];
                    thisBackpack1CharacterModel.WeaponDescription = thisWeapon.Progression[thisWeaponConfig.Progression];
                    thisBackpack1CharacterModel.WeaponAffixStringList.Add(new ObservableCollection<string>());
                    thisBackpack1CharacterModel.WeaponAffixStringList.Add(new ObservableCollection<string>());
                    thisBackpack1CharacterModel.WeaponAffixStringList.Add(new ObservableCollection<string>());
                    thisBackpack1CharacterModel.WeaponAffixStringList[0].Add(StringConstants.AffixString[Enumeration.Affix.Attack]);
                    thisBackpack1CharacterModel.WeaponAffixStringList[1].Add(":");
                    thisBackpack1CharacterModel.WeaponAffixStringList[2].Add(thisWeapon.MainAffixNumberDictionary[thisWeaponConfig.Level].ToString(CultureInfo.InvariantCulture));
                    if (thisWeapon.SubAffix != Enumeration.Affix.Empty)
                    {
                        thisBackpack1CharacterModel.WeaponAffixStringList[0].Add(StringConstants.AffixString[thisWeapon.SubAffix]);
                        thisBackpack1CharacterModel.WeaponAffixStringList[1].Add(":");
                        thisBackpack1CharacterModel.WeaponAffixStringList[2].Add(thisWeapon.SubAffixNumberDictionary[thisWeaponConfig.Level] + (SequenceConstants.AffixPercentageSymbolList.Contains(thisWeapon.SubAffix) ? "%" : ""));
                    }
                }

                AllCharacterList.Add(thisBackpack1CharacterModel);
            }

            ApplyFilters();
            SelectedCharacter = CharacterView.FirstOrDefault()!;
            SelectedCharacterSimulatorService = new SingleCharacterSimulatorService(SelectedCharacter.Rid);
            SelectedCharacterPlanInfo = SelectedCharacterSimulatorService.GetCharacterPlanInfo();
            WeakReferenceMessenger.Default.Register<WeaponInfoUpdateToCharacterMessage>(this);
            WeakReferenceMessenger.Default.Register<CharacterWeaponChangeMessage>(this);
            WeakReferenceMessenger.Default.Register<CharacterInfoChangeMessage>(this);
            WeakReferenceMessenger.Default.Register<BackpackMaterialConfigChangeMessage>(this);
            WeakReferenceMessenger.Default.Register<GoalSimulatorChangeMessage>(this);
        }

        private bool CharacterFilter(object item)
        {
            if (item is not Backpack1CharacterModel c) return false;
            bool isElement = true;
            bool isWeapon = true;
            bool isStar = true;
            bool isNotHide = true;
            switch (ElementFilter)
            {
                case 1: isElement = c.ElementType == Enumeration.ElementType.Pyro; break;
                case 2: isElement = c.ElementType == Enumeration.ElementType.Hydro; break;
                case 3: isElement = c.ElementType == Enumeration.ElementType.Anemo; break;
                case 4: isElement = c.ElementType == Enumeration.ElementType.Electro; break;
                case 5: isElement = c.ElementType == Enumeration.ElementType.Dendro; break;
                case 6: isElement = c.ElementType == Enumeration.ElementType.Cryo; break;
                case 7: isElement = c.ElementType == Enumeration.ElementType.Geo; break;
            }

            switch (WeaponFilter)
            {
                case 1: isWeapon = c.WeaponType == Enumeration.WeaponType.Sword; break;
                case 2: isWeapon = c.WeaponType == Enumeration.WeaponType.Claymore; break;
                case 3: isWeapon = c.WeaponType == Enumeration.WeaponType.Pole; break;
                case 4: isWeapon = c.WeaponType == Enumeration.WeaponType.Catalyst; break;
                case 5: isWeapon = c.WeaponType == Enumeration.WeaponType.Bow; break;
            }

            switch (StarFilter)
            {
                case 4: isStar = c.Star == 4; break;
                case 5: isStar = c.Star is 5 or 6; break;
            }

            if (IsHideLowLevelCharacter)
            {
                bool flag = c.CharacterConfigModel.CharacterLevel != Enumeration.Level.L1 || c.CharacterConfigModel.CharacterLevelGoal != Enumeration.Level.L1 || c.CharacterConfigModel.TalentALevel != Enumeration.Level.L1 || c.CharacterConfigModel.TalentALevelGoal != Enumeration.Level.L1 || c.CharacterConfigModel.TalentELevel != Enumeration.Level.L1 || c.CharacterConfigModel.TalentELevelGoal != Enumeration.Level.L1 || c.CharacterConfigModel.TalentQLevel != Enumeration.Level.L1 || c.CharacterConfigModel.TalentQLevelGoal != Enumeration.Level.L1 || c.CharacterConfigModel.Constellation != 0 || c.SubExp != 0;
                isNotHide = flag;
            }

            return isElement && isWeapon && isStar && isNotHide;
        }

        private void ApplyFilters()
        {
            List<Backpack1CharacterModel> tempList = AllCharacterList.Where(CharacterFilter).ToList();
            tempList.Sort((a, b) =>
            {
                int levelA = int.Parse(StringConstants.LevelNameString[a.CharacterConfigModel.CharacterLevel].Split('/')[0].Trim());
                int levelB = int.Parse(StringConstants.LevelNameString[b.CharacterConfigModel.CharacterLevel].Split('/')[0].Trim());
                if (levelA != levelB) return levelB.CompareTo(levelA);
                int subExpA = a.SubExp;
                int subExpB = b.SubExp;
                if (subExpA != subExpB) return subExpB.CompareTo(subExpA);
                int starA = a.Rid == 1010037 ? 5 : a.Star;
                int starB = b.Rid == 1010037 ? 5 : b.Star;
                if (starA != starB) return starB.CompareTo(starA);
                int elementTypeA = _elementTypeSortList.IndexOf(a.ElementType);
                int elementTypeB = _elementTypeSortList.IndexOf(b.ElementType);
                if (elementTypeA != elementTypeB) return elementTypeA.CompareTo(elementTypeB);
                return b.Rid.CompareTo(a.Rid);
            });
            CharacterView = tempList;
            if (!CharacterView.Contains(SelectedCharacter))
            {
                SelectedCharacter = CharacterView.FirstOrDefault()!;
            }
        }

        partial void OnSelectedCharacterChanged(Backpack1CharacterModel value)
        {
            ClickOnLevelGoalSelectionCommand.NotifyCanExecuteChanged();
            ClickOnTalentAGoalSelectionCommand.NotifyCanExecuteChanged();
            ClickOnTalentEGoalSelectionCommand.NotifyCanExecuteChanged();
            ClickOnTalentQGoalSelectionCommand.NotifyCanExecuteChanged();
            SelectedCharacterSimulatorService = new SingleCharacterSimulatorService(SelectedCharacter.Rid);
            SelectedCharacterPlanInfo = SelectedCharacterSimulatorService.GetCharacterPlanInfo();
        }

        partial void OnElementFilterChanged(int value)
        {
            ApplyFilters();
        }

        partial void OnWeaponFilterChanged(int value)
        {
            ApplyFilters();
        }

        partial void OnStarFilterChanged(int value)
        {
            ApplyFilters();
        }

        partial void OnIsHideLowLevelCharacterChanged(bool value)
        {
            ApplyFilters();
        }

        [RelayCommand]
        private void ClickOnElementFilter(String value)
        {
            int valueInt = Int32.Parse(value);
            ElementFilter = valueInt == ElementFilter ? 0 : valueInt;
        }

        [RelayCommand]
        private void ClickOnWeaponFilter(String value)
        {
            int valueInt = Int32.Parse(value);
            WeaponFilter = valueInt == WeaponFilter ? 0 : valueInt;
        }

        [RelayCommand]
        private void ClickOnStarFilter(String value)
        {
            int valueInt = Int32.Parse(value);
            StarFilter = valueInt == StarFilter ? 0 : valueInt;
        }

        [RelayCommand]
        private void ClickOnLevelSelection(String value)
        {
            int valueInt = Int32.Parse(value);
            Enumeration.Level thisLevel = SequenceConstants.AllLevels[valueInt - 1];
            App.BackpackCharacterConfigManagerInstance!.UpdateLevel(SelectedCharacter.Rid, thisLevel);
            int currentLevel = SequenceConstants.AllLevels.IndexOf(thisLevel);
            int currentGoalLevel = SequenceConstants.AllLevels.IndexOf(SelectedCharacter.CharacterConfigModel.CharacterLevelGoal);
            if (currentLevel > currentGoalLevel)
            {
                App.BackpackCharacterConfigManagerInstance.UpdateLevelGoal(SelectedCharacter.Rid, thisLevel);
            }

            ClickOnLevelGoalSelectionCommand.NotifyCanExecuteChanged();
            IsLevelPopupOpen = false;
            ApplyFilters();
        }

        [RelayCommand]
        private void ClickOnTalentASelection(String value)
        {
            int valueInt = Int32.Parse(value);
            Enumeration.Level thisLevel = SequenceConstants.AllLevels[valueInt - 1];
            App.BackpackCharacterConfigManagerInstance!.UpdateTalentA(SelectedCharacter.Rid, thisLevel);
            int currentLevel = SequenceConstants.AllLevels.IndexOf(thisLevel);
            int currentGoalLevel = SequenceConstants.AllLevels.IndexOf(SelectedCharacter.CharacterConfigModel.TalentALevelGoal);
            if (currentLevel > currentGoalLevel)
            {
                App.BackpackCharacterConfigManagerInstance.UpdateTalentAGoal(SelectedCharacter.Rid, thisLevel);
            }

            ClickOnTalentAGoalSelectionCommand.NotifyCanExecuteChanged();
            IsTalentAPopupOpen = false;
        }

        [RelayCommand]
        private void ClickOnTalentESelection(String value)
        {
            int valueInt = Int32.Parse(value);
            Enumeration.Level thisLevel = SequenceConstants.AllLevels[valueInt - 1];
            App.BackpackCharacterConfigManagerInstance!.UpdateTalentE(SelectedCharacter.Rid, thisLevel);
            int currentLevel = SequenceConstants.AllLevels.IndexOf(thisLevel);
            int currentGoalLevel = SequenceConstants.AllLevels.IndexOf(SelectedCharacter.CharacterConfigModel.TalentELevelGoal);
            if (currentLevel > currentGoalLevel)
            {
                App.BackpackCharacterConfigManagerInstance.UpdateTalentEGoal(SelectedCharacter.Rid, thisLevel);
            }

            ClickOnTalentEGoalSelectionCommand.NotifyCanExecuteChanged();
            IsTalentEPopupOpen = false;
        }

        [RelayCommand]
        private void ClickOnTalentQSelection(String value)
        {
            int valueInt = Int32.Parse(value);
            Enumeration.Level thisLevel = SequenceConstants.AllLevels[valueInt - 1];
            App.BackpackCharacterConfigManagerInstance!.UpdateTalentQ(SelectedCharacter.Rid, thisLevel);
            int currentLevel = SequenceConstants.AllLevels.IndexOf(thisLevel);
            int currentGoalLevel = SequenceConstants.AllLevels.IndexOf(SelectedCharacter.CharacterConfigModel.TalentQLevelGoal);
            if (currentLevel > currentGoalLevel)
            {
                App.BackpackCharacterConfigManagerInstance.UpdateTalentQGoal(SelectedCharacter.Rid, thisLevel);
            }

            ClickOnTalentQGoalSelectionCommand.NotifyCanExecuteChanged();
            IsTalentQPopupOpen = false;
        }

        [RelayCommand]
        private void ClickOnAscensionSelection(String value)
        {
            int valueInt = Int32.Parse(value);
            SelectedCharacter.CharacterConfigModel.Constellation = valueInt;
            for (int i = 1; i <= 6; i++)
            {
                SelectedCharacter.AscensionOpacityList[i] = i <= SelectedCharacter.CharacterConfigModel.Constellation ? 1.0 : 0.1;
            }

            App.BackpackCharacterConfigManagerInstance!.UpdateAscension(SelectedCharacter.Rid, valueInt);
            IsAscensionPopupOpen = false;
            if (valueInt == 0)
            {
                ApplyFilters();
            }
        }

        [RelayCommand(CanExecute = nameof(CanClickOnLevelGoalSelection))]
        private void ClickOnLevelGoalSelection(String value)
        {
            int valueInt = Int32.Parse(value);
            Enumeration.Level thisLevel = SequenceConstants.AllLevels[valueInt - 1];
            App.BackpackCharacterConfigManagerInstance!.UpdateLevelGoal(SelectedCharacter.Rid, thisLevel);
            IsLevelPopupOpen = false;
            if (valueInt == 1)
            {
                ApplyFilters();
            }
        }

        private bool CanClickOnLevelGoalSelection(String value)
        {
            if (SelectedCharacter == null) return false;
            int valueInt = Int32.Parse(value) - 1;
            int currentLevel = SequenceConstants.AllLevels.IndexOf(SelectedCharacter.CharacterConfigModel.CharacterLevel);
            return valueInt >= currentLevel;
        }

        [RelayCommand(CanExecute = nameof(CanClickOnTalentAGoalSelection))]
        private void ClickOnTalentAGoalSelection(String value)
        {
            int valueInt = Int32.Parse(value);
            Enumeration.Level thisLevel = SequenceConstants.AllLevels[valueInt - 1];
            App.BackpackCharacterConfigManagerInstance!.UpdateTalentAGoal(SelectedCharacter.Rid, thisLevel);
            IsTalentAPopupOpen = false;
            if (valueInt == 1)
            {
                ApplyFilters();
            }
        }

        private bool CanClickOnTalentAGoalSelection(String value)
        {
            if (SelectedCharacter == null) return false;
            int valueInt = Int32.Parse(value) - 1;
            int currentLevel = SequenceConstants.AllLevels.IndexOf(SelectedCharacter.CharacterConfigModel.TalentALevel);
            return valueInt >= currentLevel;
        }

        [RelayCommand(CanExecute = nameof(CanClickOnTalentEGoalSelection))]
        private void ClickOnTalentEGoalSelection(String value)
        {
            int valueInt = Int32.Parse(value);
            Enumeration.Level thisLevel = SequenceConstants.AllLevels[valueInt - 1];
            App.BackpackCharacterConfigManagerInstance!.UpdateTalentEGoal(SelectedCharacter.Rid, thisLevel);
            IsTalentEPopupOpen = false;
            if (valueInt == 1)
            {
                ApplyFilters();
            }
        }

        private bool CanClickOnTalentEGoalSelection(String value)
        {
            if (SelectedCharacter == null) return false;
            int valueInt = Int32.Parse(value) - 1;
            int currentLevel = SequenceConstants.AllLevels.IndexOf(SelectedCharacter.CharacterConfigModel.TalentELevel);
            return valueInt >= currentLevel;
        }

        [RelayCommand(CanExecute = nameof(CanClickOnTalentQGoalSelection))]
        private void ClickOnTalentQGoalSelection(String value)
        {
            int valueInt = Int32.Parse(value);
            Enumeration.Level thisLevel = SequenceConstants.AllLevels[valueInt - 1];
            App.BackpackCharacterConfigManagerInstance!.UpdateTalentQGoal(SelectedCharacter.Rid, thisLevel);
            IsTalentQPopupOpen = false;
            if (valueInt == 1)
            {
                ApplyFilters();
            }
        }

        private bool CanClickOnTalentQGoalSelection(String value)
        {
            if (SelectedCharacter == null) return false;
            int valueInt = Int32.Parse(value) - 1;
            int currentLevel = SequenceConstants.AllLevels.IndexOf(SelectedCharacter.CharacterConfigModel.TalentQLevel);
            return valueInt >= currentLevel;
        }

        private int GetLevelTotalExp(List<MaterialPairModel> l)
        {
            int res = 1;
            foreach (MaterialPairModel m in l)
            {
                if (m.MaterialModel!.Rid == 3020001)
                {
                    res = (int)m.DropNum;
                }
            }

            return res;
        }

        [RelayCommand]
        private void ClickOnCharacter(Backpack1CharacterModel value)
        {
            SelectedCharacter = value;
        }

        [RelayCommand]
        private void AddOneMaterial(BackpackCharacterPlanInfoMaterial? clickItem)
        {
            if (clickItem != null)
            {
                App.BackpackMaterialConfigManagerInstance!.UpdateMaterialNumber(clickItem.Rid, clickItem.Number + 1);
            }
        }

        [RelayCommand]
        private void MinusOneMaterial(BackpackCharacterPlanInfoMaterial? clickItem)
        {
            if (clickItem is { Number: >= 1 })
            {
                App.BackpackMaterialConfigManagerInstance!.UpdateMaterialNumber(clickItem.Rid, clickItem.Number - 1);
            }
        }

        [RelayCommand]
        private void MergeOneMaterial(BackpackCharacterPlanInfoMaterial? clickItem)
        {
            if (clickItem != null)
            {
                int recipeId = AutoCalculateConstants.MaterialMergeRecipe[clickItem.Rid];
                BackpackCharacterPlanInfoMaterial recipeMaterial = SelectedCharacterPlanInfo.CharacterPlanMaterialList.FirstOrDefault(m => m.Rid == recipeId)!;
                if (recipeMaterial.Number >= 3)
                {
                    App.BackpackMaterialConfigManagerInstance!.UpdateMaterialNumber([recipeMaterial.Rid, clickItem.Rid], [recipeMaterial.Number - 3, clickItem.Number + 1]);
                }
            }
        }

        [RelayCommand]
        private void ClickOnSubPlanFinish(BackpackCharacterPlanInfoSubPlan value)
        {
            // 消耗当前所有材料，注意不够时用0兜底
            List<int> materialRidList = [];
            List<int> materialNumList = [];
            foreach (BackpackCharacterPlanInfoNeedMaterial m in value.NeedMaterialList)
            {
                materialRidList.Add(m.Rid);
                materialNumList.Add(Math.Max(App.BackpackMaterialConfigManagerInstance!.GetMaterialNumber(m.Rid) - m.NeedNum, 0));
            }

            App.BackpackMaterialConfigManagerInstance!.UpdateMaterialNumber(materialRidList, materialNumList);
            // 更改相应等级
            SingleBackpackCharacterConfigModel thisCharacterConfig = new SingleBackpackCharacterConfigModel();
            if (App.BackpackCharacterConfigManagerInstance!.Configuration.CharacterConfig.TryGetValue(value.CharacterRid, out SingleBackpackCharacterConfigModel? thisConfig))
            {
                thisCharacterConfig = thisConfig;
            }

            switch (value.Type)
            {
                case 1:
                    App.BackpackCharacterConfigManagerInstance.UpdateLevel(value.CharacterRid, value.FinishLevel);
                    int goalCharacterLevelIndex = SequenceConstants.AllLevels.IndexOf(thisCharacterConfig.CharacterLevelGoal);
                    int finishCharacterLevelIndex = SequenceConstants.AllLevels.IndexOf(value.FinishLevel);
                    if (goalCharacterLevelIndex < finishCharacterLevelIndex)
                    {
                        App.BackpackCharacterConfigManagerInstance.UpdateLevelGoal(value.CharacterRid, value.FinishLevel);
                    }

                    if (SelectedCharacter.Rid == value.CharacterRid)
                    {
                        ClickOnLevelGoalSelectionCommand.NotifyCanExecuteChanged();
                    }

                    break;
                case 2:
                    App.BackpackCharacterConfigManagerInstance.UpdateTalentA(value.CharacterRid, value.FinishLevel);
                    int goalTalentALevelIndex = SequenceConstants.AllLevels.IndexOf(thisCharacterConfig.TalentALevelGoal);
                    int finishTalentALevelIndex = SequenceConstants.AllLevels.IndexOf(value.FinishLevel);
                    if (goalTalentALevelIndex < finishTalentALevelIndex)
                    {
                        App.BackpackCharacterConfigManagerInstance.UpdateTalentAGoal(value.CharacterRid, value.FinishLevel);
                    }

                    if (SelectedCharacter.Rid == value.CharacterRid)
                    {
                        ClickOnTalentAGoalSelectionCommand.NotifyCanExecuteChanged();
                    }

                    break;
                case 3:
                    App.BackpackCharacterConfigManagerInstance.UpdateTalentE(value.CharacterRid, value.FinishLevel);
                    int goalTalentELevelIndex = SequenceConstants.AllLevels.IndexOf(thisCharacterConfig.TalentELevelGoal);
                    int finishTalentELevelIndex = SequenceConstants.AllLevels.IndexOf(value.FinishLevel);
                    if (goalTalentELevelIndex < finishTalentELevelIndex)
                    {
                        App.BackpackCharacterConfigManagerInstance.UpdateTalentEGoal(value.CharacterRid, value.FinishLevel);
                    }

                    if (SelectedCharacter.Rid == value.CharacterRid)
                    {
                        ClickOnTalentEGoalSelectionCommand.NotifyCanExecuteChanged();
                    }

                    break;
                case 4:
                    App.BackpackCharacterConfigManagerInstance.UpdateTalentQ(value.CharacterRid, value.FinishLevel);
                    int goalTalentQLevelIndex = SequenceConstants.AllLevels.IndexOf(thisCharacterConfig.TalentQLevelGoal);
                    int finishTalentQLevelIndex = SequenceConstants.AllLevels.IndexOf(value.FinishLevel);
                    if (goalTalentQLevelIndex < finishTalentQLevelIndex)
                    {
                        App.BackpackCharacterConfigManagerInstance.UpdateTalentQGoal(value.CharacterRid, value.FinishLevel);
                    }

                    if (SelectedCharacter.Rid == value.CharacterRid)
                    {
                        ClickOnTalentQGoalSelectionCommand.NotifyCanExecuteChanged();
                    }

                    break;
            }
        }

        [RelayCommand]
        public void OpenHelpWebPage()
        {
            string url = "https://github.com/TimmyTim-101/HexereiKatepnha/wiki/%E8%83%8C%E5%8C%85-%E2%80%90-%E8%A7%92%E8%89%B2";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void Receive(CharacterWeaponChangeMessage message)
        {
            int thisCharacterId = message.Value;
            // 在角色持有武器变化时更新
            foreach (Backpack1CharacterModel thisBackpack1CharacterModel in AllCharacterList)
            {
                if (thisBackpack1CharacterModel.Rid != thisCharacterId) continue;
                string thisWeaponId = App.BackpackCharacterConfigManagerInstance!.Configuration.CharacterConfig[thisCharacterId].WeaponId;
                if (thisWeaponId != "")
                {
                    SingleBackpackWeaponConfigModel thisWeaponConfig = App.BackpackWeaponConfigManagerInstance!.Configuration.WeaponConfigMap[thisWeaponId];
                    int thisWeaponRid = thisWeaponConfig.Rid;
                    WeaponModel thisWeapon = AutoCalculateConstants.WeaponMap[thisWeaponRid];
                    thisBackpack1CharacterModel.WeaponBackgroundImagePath = StringConstants.StarBackgroundImagePath[thisWeapon.Star];
                    thisBackpack1CharacterModel.WeaponImagePath = thisWeapon.AwakenImagePath;
                    thisBackpack1CharacterModel.WeaponName = thisWeapon.Name;
                    thisBackpack1CharacterModel.WeaponProgression = thisWeaponConfig.Progression;
                    thisBackpack1CharacterModel.WeaponLevelString = StringConstants.LevelNameString[thisWeaponConfig.Level];
                    thisBackpack1CharacterModel.WeaponDescription = thisWeapon.Progression[thisWeaponConfig.Progression];
                    thisBackpack1CharacterModel.WeaponAffixStringList.Clear();
                    thisBackpack1CharacterModel.WeaponAffixStringList.Add(new ObservableCollection<string>());
                    thisBackpack1CharacterModel.WeaponAffixStringList.Add(new ObservableCollection<string>());
                    thisBackpack1CharacterModel.WeaponAffixStringList.Add(new ObservableCollection<string>());
                    thisBackpack1CharacterModel.WeaponAffixStringList[0].Add(StringConstants.AffixString[Enumeration.Affix.Attack]);
                    thisBackpack1CharacterModel.WeaponAffixStringList[1].Add(":");
                    thisBackpack1CharacterModel.WeaponAffixStringList[2].Add(thisWeapon.MainAffixNumberDictionary[thisWeaponConfig.Level].ToString(CultureInfo.InvariantCulture));
                    if (thisWeapon.SubAffix != Enumeration.Affix.Empty)
                    {
                        thisBackpack1CharacterModel.WeaponAffixStringList[0].Add(StringConstants.AffixString[thisWeapon.SubAffix]);
                        thisBackpack1CharacterModel.WeaponAffixStringList[1].Add(":");
                        thisBackpack1CharacterModel.WeaponAffixStringList[2].Add(thisWeapon.SubAffixNumberDictionary[thisWeaponConfig.Level] + (SequenceConstants.AffixPercentageSymbolList.Contains(thisWeapon.SubAffix) ? "%" : ""));
                    }
                }
                else
                {
                    thisBackpack1CharacterModel.WeaponBackgroundImagePath = StringConstants.EmptyImagePath;
                    thisBackpack1CharacterModel.WeaponImagePath = StringConstants.EmptyImagePath;
                    thisBackpack1CharacterModel.WeaponName = "";
                    thisBackpack1CharacterModel.WeaponProgression = 1;
                    thisBackpack1CharacterModel.WeaponLevelString = "";
                    thisBackpack1CharacterModel.WeaponDescription = "";
                    thisBackpack1CharacterModel.WeaponAffixStringList = [];
                }
            }
        }

        public void Receive(WeaponInfoUpdateToCharacterMessage message)
        {
            // 角色持有武器属性发生变化
            int thisCharacterRid = message.Value;
            foreach (Backpack1CharacterModel thisBackpack1CharacterModel in AllCharacterList)
            {
                if (thisBackpack1CharacterModel.Rid != thisCharacterRid) continue;
                string thisWeaponId = thisBackpack1CharacterModel.CharacterConfigModel.WeaponId;
                SingleBackpackWeaponConfigModel thisWeaponConfig = App.BackpackWeaponConfigManagerInstance!.Configuration.WeaponConfigMap[thisWeaponId];
                int thisWeaponRid = thisWeaponConfig.Rid;
                WeaponModel thisWeapon = AutoCalculateConstants.WeaponMap[thisWeaponRid];
                thisBackpack1CharacterModel.WeaponBackgroundImagePath = StringConstants.StarBackgroundImagePath[thisWeapon.Star];
                thisBackpack1CharacterModel.WeaponImagePath = thisWeapon.AwakenImagePath;
                thisBackpack1CharacterModel.WeaponName = thisWeapon.Name;
                thisBackpack1CharacterModel.WeaponProgression = thisWeaponConfig.Progression;
                thisBackpack1CharacterModel.WeaponLevelString = StringConstants.LevelNameString[thisWeaponConfig.Level];
                thisBackpack1CharacterModel.WeaponDescription = thisWeapon.Progression[thisWeaponConfig.Progression];
                thisBackpack1CharacterModel.WeaponAffixStringList.Clear();
                thisBackpack1CharacterModel.WeaponAffixStringList.Add(new ObservableCollection<string>());
                thisBackpack1CharacterModel.WeaponAffixStringList.Add(new ObservableCollection<string>());
                thisBackpack1CharacterModel.WeaponAffixStringList.Add(new ObservableCollection<string>());
                thisBackpack1CharacterModel.WeaponAffixStringList[0].Add(StringConstants.AffixString[Enumeration.Affix.Attack]);
                thisBackpack1CharacterModel.WeaponAffixStringList[1].Add(":");
                thisBackpack1CharacterModel.WeaponAffixStringList[2].Add(thisWeapon.MainAffixNumberDictionary[thisWeaponConfig.Level].ToString(CultureInfo.InvariantCulture));
                if (thisWeapon.SubAffix != Enumeration.Affix.Empty)
                {
                    thisBackpack1CharacterModel.WeaponAffixStringList[0].Add(StringConstants.AffixString[thisWeapon.SubAffix]);
                    thisBackpack1CharacterModel.WeaponAffixStringList[1].Add(":");
                    thisBackpack1CharacterModel.WeaponAffixStringList[2].Add(thisWeapon.SubAffixNumberDictionary[thisWeaponConfig.Level] + (SequenceConstants.AffixPercentageSymbolList.Contains(thisWeapon.SubAffix) ? "%" : ""));
                }
            }
        }

        public void Receive(BackpackMaterialConfigChangeMessage message)
        {
            List<int> thisMaterialRidList = message.Value;
            foreach (int thisMaterialRid in thisMaterialRidList)
            {
                BackpackCharacterPlanInfoMaterial thisViewModel = SelectedCharacterPlanInfo.CharacterPlanMaterialList.FirstOrDefault(m => m.Rid == thisMaterialRid, null);
                if (thisViewModel != null)
                {
                    thisViewModel.Number = App.BackpackMaterialConfigManagerInstance!.GetMaterialNumber(thisMaterialRid);
                }
            }

            SelectedCharacterSimulatorService.UpdateSubPlan();
        }

        public void Receive(GoalSimulatorChangeMessage message)
        {
            Dictionary<int, CalculatorPlanMaterialExtraInfo> materialExtraInfoMap = App.GlobalGoalSimulatorServicePart!.GetMaterialExtraInfo();
            foreach (BackpackCharacterPlanInfoMaterial thisMaterial in SelectedCharacterPlanInfo.CharacterPlanMaterialList)
            {
                int thisMaterialRid = thisMaterial.Rid;
                CalculatorPlanMaterialExtraInfo thisMaterialExtraInfo = materialExtraInfoMap[thisMaterialRid];
                thisMaterial.Num1 = thisMaterialExtraInfo.NeedNum;
                if (thisMaterialExtraInfo.NeedNum > 0) thisMaterial.Color1 = thisMaterialExtraInfo.IsSatisfy ? StringConstants.GreenColorString : StringConstants.RedColorString;
                else thisMaterial.Color1 = "#Transparent";
                thisMaterial.IconPath = thisMaterialExtraInfo.IsSatisfy ? StringConstants.CheckCircleIconPath : StringConstants.CancelIconPath;
                if (thisMaterialExtraInfo.IsSatisfy)
                {
                    if (thisMaterialExtraInfo.ActionNum > 0)
                    {
                        thisMaterial.Num2String = thisMaterialExtraInfo.ActionNum.ToString();
                        thisMaterial.Color2 = StringConstants.YellowColorString;
                    }
                    else
                    {
                        thisMaterial.Num2String = "";
                        thisMaterial.Color2 = "#Transparent";
                    }
                }
                else
                {
                    thisMaterial.Num2String = thisMaterialExtraInfo.ActionNum.ToString();
                    thisMaterial.Color2 = StringConstants.RedColorString;
                }
            }
        }

        public void Receive(CharacterInfoChangeMessage message)
        {
            int thisCharacterRid = message.Value;
            Backpack1CharacterModel thisModel = AllCharacterList.FirstOrDefault(m => m.Rid == thisCharacterRid, null);
            if (thisModel != null)
            {
                SingleBackpackCharacterConfigModel thisConfig = App.BackpackCharacterConfigManagerInstance!.Configuration.CharacterConfig[thisCharacterRid];
                CharacterModel thisCharacterModel = AutoCalculateConstants.CharacterMap[thisCharacterRid];
                if (thisModel.LevelNameString != StringConstants.LevelNameString[thisConfig.CharacterLevel])
                {
                    // level发生改变
                    thisModel.SubExp = 0;
                    thisModel.LevelNameString = StringConstants.LevelNameString[thisConfig.CharacterLevel];
                    thisModel.LevelNumberString = StringConstants.LevelNumberString[thisConfig.CharacterLevel];
                    thisModel.LevelTotalExp = GetLevelTotalExp(thisCharacterModel.LevelUpMaterials.GetValueOrDefault(thisConfig.CharacterLevel, []));
                    thisModel.IsShowProgress = !SequenceConstants.NoExpLevels.Contains(thisConfig.CharacterLevel);
                }

                if (thisModel.TalentAString != StringConstants.LevelNumberString[thisConfig.TalentALevel])
                {
                    // talent A发生改变
                    thisModel.TalentAString = StringConstants.LevelNumberString[thisConfig.TalentALevel];
                }

                if (thisModel.TalentEString != StringConstants.LevelNumberString[thisConfig.TalentELevel])
                {
                    // talent E发生改变
                    thisModel.TalentEString = StringConstants.LevelNumberString[thisConfig.TalentELevel];
                }

                if (thisModel.TalentQString != StringConstants.LevelNumberString[thisConfig.TalentQLevel])
                {
                    // talent Q发生改变
                    thisModel.TalentQString = StringConstants.LevelNumberString[thisConfig.TalentQLevel];
                }

                if (thisModel.LevelGoalNumberString != StringConstants.LevelNumberString[thisConfig.CharacterLevelGoal])
                {
                    // level goal发生改变
                    thisModel.LevelGoalNumberString = StringConstants.LevelNumberString[thisConfig.CharacterLevelGoal];
                }

                if (thisModel.TalentAGoalString != StringConstants.LevelNumberString[thisConfig.TalentALevelGoal])
                {
                    // talent A goal发生改变
                    thisModel.TalentAGoalString = StringConstants.LevelNumberString[thisConfig.TalentALevelGoal];
                }

                if (thisModel.TalentEGoalString != StringConstants.LevelNumberString[thisConfig.TalentELevelGoal])
                {
                    // talent E goal发生改变
                    thisModel.TalentEGoalString = StringConstants.LevelNumberString[thisConfig.TalentELevelGoal];
                }

                if (thisModel.TalentQGoalString != StringConstants.LevelNumberString[thisConfig.TalentQLevelGoal])
                {
                    // talent Q goal发生改变
                    thisModel.TalentQGoalString = StringConstants.LevelNumberString[thisConfig.TalentQLevelGoal];
                }

                if (SelectedCharacter.Rid == thisCharacterRid)
                {
                    SelectedCharacterSimulatorService = new SingleCharacterSimulatorService(SelectedCharacter.Rid);
                    SelectedCharacterPlanInfo = SelectedCharacterSimulatorService.GetCharacterPlanInfo();
                }
            }
        }
    }
}