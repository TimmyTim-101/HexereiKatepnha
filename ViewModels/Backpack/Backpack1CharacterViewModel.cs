using System.Collections.ObjectModel;
using System.Globalization;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.ConfigModels;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.ModelsForViews.Backpack;

namespace HexereiKatepnha.ViewModels.Backpack
{
    public partial class Backpack1CharacterViewModel : ObservableObject
    {
        [ObservableProperty] private int _elementFilter;
        [ObservableProperty] private int _weaponFilter;
        [ObservableProperty] private int _starFilter;
        [ObservableProperty] private bool _isHideLowLevelCharacter;
        private ObservableCollection<Backpack1CharacterModel> AllCharacterList { get; } = [];
        [ObservableProperty] private Backpack1CharacterModel _selectedCharacter;
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
                thisBackpack1CharacterModel.LevelTotalExp = GetLevelTotalExp(e.LevelUpMaterials[thisBackpack1CharacterModel.CharacterConfigModel.CharacterLevel]);
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
                thisBackpack1CharacterModel.AscensionPropertyDictionary = e.Ascension;
                for (int i = 1; i <= 6; i++)
                {
                    thisBackpack1CharacterModel.AscensionOpacityList[i] = i <= thisBackpack1CharacterModel.CharacterConfigModel.Ascension ? 1.0 : 0.1;
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
                    thisBackpack1CharacterModel.WeaponProgression = $"C{thisWeaponConfig.Progression}";
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

            _selectedCharacter = AllCharacterList.FirstOrDefault()!;
            ApplyFilters();
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
                bool flag = c.CharacterConfigModel.CharacterLevel != Enumeration.Level.L1 || c.CharacterConfigModel.CharacterLevelGoal != Enumeration.Level.L1 || c.CharacterConfigModel.TalentALevel != Enumeration.Level.L1 || c.CharacterConfigModel.TalentALevelGoal != Enumeration.Level.L1 || c.CharacterConfigModel.TalentELevel != Enumeration.Level.L1 || c.CharacterConfigModel.TalentELevelGoal != Enumeration.Level.L1 || c.CharacterConfigModel.TalentQLevel != Enumeration.Level.L1 || c.CharacterConfigModel.TalentQLevelGoal != Enumeration.Level.L1 || c.CharacterConfigModel.Ascension != 0 || c.SubExp != 0;
                isNotHide = flag;
            }

            return isElement && isWeapon && isStar && isNotHide;
        }

        private void ApplyFilters()
        {
            List<Backpack1CharacterModel> tempList = AllCharacterList.Where(CharacterFilter).ToList();
            tempList.Sort((a, b) =>
            {
                int levelA = SequenceConstants.AllLevels.IndexOf(a.CharacterConfigModel.CharacterLevel);
                int levelB = SequenceConstants.AllLevels.IndexOf(b.CharacterConfigModel.CharacterLevel);
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

        partial void OnSelectedCharacterChanged(Backpack1CharacterModel? value)
        {
            ClickOnLevelGoalSelectionCommand.NotifyCanExecuteChanged();
            ClickOnTalentAGoalSelectionCommand.NotifyCanExecuteChanged();
            ClickOnTalentEGoalSelectionCommand.NotifyCanExecuteChanged();
            ClickOnTalentQGoalSelectionCommand.NotifyCanExecuteChanged();
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
            SelectedCharacter.CharacterConfigModel.CharacterLevel = thisLevel;
            SelectedCharacter.CharacterConfigModel.SubExp = 0;
            SelectedCharacter.SubExp = 0;
            SelectedCharacter.LevelNameString = StringConstants.LevelNameString[thisLevel];
            SelectedCharacter.LevelNumberString = StringConstants.LevelNumberString[thisLevel];
            SelectedCharacter.LevelTotalExp = GetLevelTotalExp(AutoCalculateConstants.CharacterMap[SelectedCharacter.Rid].LevelUpMaterials[thisLevel]);
            SelectedCharacter.IsShowProgress = !SequenceConstants.NoExpLevels.Contains(thisLevel);
            App.BackpackCharacterConfigManagerInstance!.UpdateLevel(SelectedCharacter.Rid, thisLevel);
            int currentLevel = SequenceConstants.AllLevels.IndexOf(thisLevel);
            int currentGoalLevel = SequenceConstants.AllLevels.IndexOf(SelectedCharacter.CharacterConfigModel.CharacterLevelGoal);
            if (currentLevel > currentGoalLevel)
            {
                SelectedCharacter.CharacterConfigModel.CharacterLevelGoal = thisLevel;
                SelectedCharacter.LevelGoalNumberString = StringConstants.LevelNumberString[thisLevel];
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
            SelectedCharacter.CharacterConfigModel.TalentALevel = thisLevel;
            SelectedCharacter.TalentAString = StringConstants.LevelNumberString[thisLevel];
            App.BackpackCharacterConfigManagerInstance!.UpdateTalentA(SelectedCharacter.Rid, thisLevel);
            int currentLevel = SequenceConstants.AllLevels.IndexOf(thisLevel);
            int currentGoalLevel = SequenceConstants.AllLevels.IndexOf(SelectedCharacter.CharacterConfigModel.TalentALevelGoal);
            if (currentLevel > currentGoalLevel)
            {
                SelectedCharacter.CharacterConfigModel.TalentALevelGoal = thisLevel;
                SelectedCharacter.TalentAGoalString = StringConstants.LevelNumberString[thisLevel];
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
            SelectedCharacter.CharacterConfigModel.TalentELevel = thisLevel;
            SelectedCharacter.TalentEString = StringConstants.LevelNumberString[thisLevel];
            App.BackpackCharacterConfigManagerInstance!.UpdateTalentE(SelectedCharacter.Rid, thisLevel);
            int currentLevel = SequenceConstants.AllLevels.IndexOf(thisLevel);
            int currentGoalLevel = SequenceConstants.AllLevels.IndexOf(SelectedCharacter.CharacterConfigModel.TalentELevelGoal);
            if (currentLevel > currentGoalLevel)
            {
                SelectedCharacter.CharacterConfigModel.TalentELevelGoal = thisLevel;
                SelectedCharacter.TalentEGoalString = StringConstants.LevelNumberString[thisLevel];
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
            SelectedCharacter.CharacterConfigModel.TalentQLevel = thisLevel;
            SelectedCharacter.TalentQString = StringConstants.LevelNumberString[thisLevel];
            App.BackpackCharacterConfigManagerInstance!.UpdateTalentQ(SelectedCharacter.Rid, thisLevel);
            int currentLevel = SequenceConstants.AllLevels.IndexOf(thisLevel);
            int currentGoalLevel = SequenceConstants.AllLevels.IndexOf(SelectedCharacter.CharacterConfigModel.TalentQLevelGoal);
            if (currentLevel > currentGoalLevel)
            {
                SelectedCharacter.CharacterConfigModel.TalentQLevelGoal = thisLevel;
                SelectedCharacter.TalentQGoalString = StringConstants.LevelNumberString[thisLevel];
                App.BackpackCharacterConfigManagerInstance.UpdateTalentQGoal(SelectedCharacter.Rid, thisLevel);
            }

            ClickOnTalentQGoalSelectionCommand.NotifyCanExecuteChanged();
            IsTalentQPopupOpen = false;
        }

        [RelayCommand]
        private void ClickOnAscensionSelection(String value)
        {
            int valueInt = Int32.Parse(value);
            SelectedCharacter.CharacterConfigModel.Ascension = valueInt;
            for (int i = 1; i <= 6; i++)
            {
                SelectedCharacter.AscensionOpacityList[i] = i <= SelectedCharacter.CharacterConfigModel.Ascension ? 1.0 : 0.1;
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
            SelectedCharacter.CharacterConfigModel.CharacterLevelGoal = thisLevel;
            SelectedCharacter.LevelGoalNumberString = StringConstants.LevelNumberString[thisLevel];
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
            SelectedCharacter.CharacterConfigModel.TalentALevelGoal = thisLevel;
            SelectedCharacter.TalentAGoalString = StringConstants.LevelNumberString[thisLevel];
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
            SelectedCharacter.CharacterConfigModel.TalentELevelGoal = thisLevel;
            SelectedCharacter.TalentEGoalString = StringConstants.LevelNumberString[thisLevel];
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
            SelectedCharacter.CharacterConfigModel.TalentQLevelGoal = thisLevel;
            SelectedCharacter.TalentQGoalString = StringConstants.LevelNumberString[thisLevel];
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
    }
}