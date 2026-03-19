using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.ModelsForViews.Backpack;

namespace HexereiKatepnha.ViewModels.Backpack
{
    public partial class Backpack1CharacterViewModel : ObservableObject
    {
        [ObservableProperty] private int _elementFilter;
        [ObservableProperty] private int _weaponFilter;
        [ObservableProperty] private int _starFilter;
        public ObservableCollection<Backpack1CharacterModel> AllCharacterList { get; } = new();
        [ObservableProperty] private Backpack1CharacterModel _selectedCharacter;
        [ObservableProperty] private bool _isLevelPopupOpen;
        [ObservableProperty] private bool _isTalentAPopupOpen;
        [ObservableProperty] private bool _isTalentEPopupOpen;
        [ObservableProperty] private bool _isTalentQPopupOpen;
        [ObservableProperty] private bool _isAscensionPopupOpen;
        public ICollectionView CharacterView { get; }
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

        public Backpack1CharacterViewModel()
        {
            foreach (CharacterModel e in AllEntities.AllCharacter)
            {
                Backpack1CharacterModel thisBackpack1CharacterModel = new Backpack1CharacterModel();
                thisBackpack1CharacterModel.Rid = e.Rid;
                thisBackpack1CharacterModel.ImagePath = e.ImagePath;
                thisBackpack1CharacterModel.ElementType = e.ElementType;
                thisBackpack1CharacterModel.ElementImagePath = StringConstants.ElementTypeImagePath[e.ElementType];
                thisBackpack1CharacterModel.BackgroundImagePath = StringConstants.StarBackgroundImagePath[e.Star];
                thisBackpack1CharacterModel.Name = e.Name;
                thisBackpack1CharacterModel.Star = e.Star;
                thisBackpack1CharacterModel.WeaponType = e.WeaponType;
                thisBackpack1CharacterModel.CharacterConfigModel = App.BackpackCharacterConfigManagerInstance!.GetBackpackCharacterConfig(e.Rid);
                thisBackpack1CharacterModel.LevelNameString = StringConstants.LevelNameString[thisBackpack1CharacterModel.CharacterConfigModel.CharacterLevel];
                thisBackpack1CharacterModel.LevelNumberString = StringConstants.LevelNumberString[thisBackpack1CharacterModel.CharacterConfigModel.CharacterLevel];
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

                AllCharacterList.Add(thisBackpack1CharacterModel);
            }

            _selectedCharacter = AllCharacterList[0];
            CharacterView = CollectionViewSource.GetDefaultView(AllCharacterList);
            CharacterView.Filter = CharacterFilter;
        }

        private bool CharacterFilter(object item)
        {
            if (item is not Backpack1CharacterModel c) return false;
            bool isElement = true;
            bool isWeapon = true;
            bool isStar = true;
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

            return isElement && isWeapon && isStar;
        }

        partial void OnSelectedCharacterChanged(Backpack1CharacterModel m)
        {
            ClickOnLevelGoalSelectionCommand.NotifyCanExecuteChanged();
            ClickOnTalentAGoalSelectionCommand.NotifyCanExecuteChanged();
            ClickOnTalentEGoalSelectionCommand.NotifyCanExecuteChanged();
            ClickOnTalentQGoalSelectionCommand.NotifyCanExecuteChanged();
        }

        private void UpdateSelection()
        {
            if (!CharacterView.Contains(SelectedCharacter))
            {
                SelectedCharacter = CharacterView.Cast<Backpack1CharacterModel>().FirstOrDefault()!;
            }
        }

        partial void OnElementFilterChanged(int value)
        {
            CharacterView.Refresh();
            UpdateSelection();
        }

        partial void OnWeaponFilterChanged(int value)
        {
            CharacterView.Refresh();
            UpdateSelection();
        }

        partial void OnStarFilterChanged(int value)
        {
            CharacterView.Refresh();
            UpdateSelection();
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
            SelectedCharacter.LevelNameString = StringConstants.LevelNameString[thisLevel];
            SelectedCharacter.LevelNumberString = StringConstants.LevelNumberString[thisLevel];
            App.BackpackCharacterConfigManagerInstance!.UpdateLevel(SelectedCharacter.Rid, thisLevel);
            int currentLevel = SequenceConstants.AllLevels.IndexOf(thisLevel);
            int currentGoalLevel = SequenceConstants.AllLevels.IndexOf(SelectedCharacter.CharacterConfigModel.CharacterLevelGoal);
            if (currentLevel > currentGoalLevel)
            {
                SelectedCharacter.CharacterConfigModel.CharacterLevelGoal = thisLevel;
                SelectedCharacter.LevelGoalNumberString = StringConstants.LevelNumberString[thisLevel];
                App.BackpackCharacterConfigManagerInstance!.UpdateLevelGoal(SelectedCharacter.Rid, thisLevel);
            }

            ClickOnLevelGoalSelectionCommand.NotifyCanExecuteChanged();
            IsLevelPopupOpen = false;
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
                App.BackpackCharacterConfigManagerInstance!.UpdateTalentAGoal(SelectedCharacter.Rid, thisLevel);
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
                App.BackpackCharacterConfigManagerInstance!.UpdateTalentEGoal(SelectedCharacter.Rid, thisLevel);
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
                App.BackpackCharacterConfigManagerInstance!.UpdateTalentQGoal(SelectedCharacter.Rid, thisLevel);
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
        }

        private bool CanClickOnLevelGoalSelection(String value)
        {
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
        }

        private bool CanClickOnTalentAGoalSelection(String value)
        {
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
        }

        private bool CanClickOnTalentEGoalSelection(String value)
        {
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
        }

        private bool CanClickOnTalentQGoalSelection(String value)
        {
            int valueInt = Int32.Parse(value) - 1;
            int currentLevel = SequenceConstants.AllLevels.IndexOf(SelectedCharacter.CharacterConfigModel.TalentQLevel);
            return valueInt >= currentLevel;
        }
    }
}