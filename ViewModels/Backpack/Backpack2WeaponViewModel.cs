using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Data;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.ConfigModels;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.ModelsForViews.Backpack;

namespace HexereiKatepnha.ViewModels.Backpack
{
    public partial class Backpack2WeaponViewModel : ObservableObject
    {
        [ObservableProperty] private int _weaponFilter;
        [ObservableProperty] private int _starFilter;
        private ObservableCollection<Backpack2WeaponModel> WeaponList { get; set; } = new();
        [ObservableProperty] private Backpack2WeaponModel? _selectedWeapon;
        [ObservableProperty] private bool _isLevelPopupOpen;
        [ObservableProperty] private bool _isProgressionPopupOpen;
        public ICollectionView WeaponView { get; }
        public string Weapon1ImagePath { get; set; } = StringConstants.WeaponTypeImagePath[Enumeration.WeaponType.Sword];
        public string Weapon2ImagePath { get; set; } = StringConstants.WeaponTypeImagePath[Enumeration.WeaponType.Claymore];
        public string Weapon3ImagePath { get; set; } = StringConstants.WeaponTypeImagePath[Enumeration.WeaponType.Pole];
        public string Weapon4ImagePath { get; set; } = StringConstants.WeaponTypeImagePath[Enumeration.WeaponType.Catalyst];
        public string Weapon5ImagePath { get; set; } = StringConstants.WeaponTypeImagePath[Enumeration.WeaponType.Bow];
        public string Star1ImagePath { get; set; } = StringConstants.StarImagePath[1];
        public string Star2ImagePath { get; set; } = StringConstants.StarImagePath[2];
        public string Star3ImagePath { get; set; } = StringConstants.StarImagePath[3];
        public string Star4ImagePath { get; set; } = StringConstants.StarImagePath[4];
        public string Star5ImagePath { get; set; } = StringConstants.StarImagePath[5];

        public Backpack2WeaponViewModel()
        {
            Refresh(null);
            WeaponView = CollectionViewSource.GetDefaultView(WeaponList);
            WeaponView.Filter = WeaponsFilter;
            WeaponView.SortDescriptions.Add(new SortDescription(nameof(Backpack2WeaponModel.Star), ListSortDirection.Descending));
            WeaponView.SortDescriptions.Add(new SortDescription("Config.Level", ListSortDirection.Descending));
            WeaponView.SortDescriptions.Add(new SortDescription(nameof(Backpack2WeaponModel.Rid), ListSortDirection.Ascending));
            WeaponView.SortDescriptions.Add(new SortDescription(nameof(Backpack2WeaponModel.Progression), ListSortDirection.Descending));
            if (WeaponView is ICollectionViewLiveShaping liveView)
            {
                liveView.IsLiveSorting = true;
                liveView.LiveSortingProperties.Add(nameof(Backpack2WeaponModel.Star));
                liveView.LiveSortingProperties.Add("Config.Level");
                liveView.LiveSortingProperties.Add(nameof(Backpack2WeaponModel.Rid));
                liveView.LiveSortingProperties.Add(nameof(Backpack2WeaponModel.Progression));
            }
        }

        private bool WeaponsFilter(object item)
        {
            if (item is not Backpack2WeaponModel w) return false;
            bool isWeapon = true;
            bool isStar = true;
            switch (WeaponFilter)
            {
                case 1: isWeapon = w.WeaponType == Enumeration.WeaponType.Sword; break;
                case 2: isWeapon = w.WeaponType == Enumeration.WeaponType.Claymore; break;
                case 3: isWeapon = w.WeaponType == Enumeration.WeaponType.Pole; break;
                case 4: isWeapon = w.WeaponType == Enumeration.WeaponType.Catalyst; break;
                case 5: isWeapon = w.WeaponType == Enumeration.WeaponType.Bow; break;
            }

            switch (StarFilter)
            {
                case 1: isStar = w.Star == 1; break;
                case 2: isStar = w.Star == 2; break;
                case 3: isStar = w.Star == 3; break;
                case 4: isStar = w.Star == 4; break;
                case 5: isStar = w.Star == 5; break;
            }

            return isWeapon && isStar;
        }

        partial void OnSelectedWeaponChanged(Backpack2WeaponModel? value)
        {
            ClickOnLevelGoalSelectionCommand.NotifyCanExecuteChanged();
        }

        private void UpdateSelection()
        {
            if (!WeaponView.Contains(SelectedWeapon))
            {
                SelectedWeapon = WeaponView.Cast<Backpack2WeaponModel>().FirstOrDefault()!;
            }
        }

        partial void OnWeaponFilterChanged(int value)
        {
            WeaponView.Refresh();
            UpdateSelection();
        }

        partial void OnStarFilterChanged(int value)
        {
            WeaponView.Refresh();
            UpdateSelection();
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
            SelectedWeapon!.Config.Level = thisLevel;
            SelectedWeapon.LevelNameString = StringConstants.LevelNameString[thisLevel];
            SelectedWeapon.LevelNumberString = StringConstants.LevelNumberString[thisLevel];
            App.BackpackWeaponConfigManagerInstance!.UpdateLevel(SelectedWeapon.Id, thisLevel);
            int currentLevel = SequenceConstants.AllLevels.IndexOf(thisLevel);
            int currentGoalLevel = SequenceConstants.AllLevels.IndexOf(SelectedWeapon.Config.LevelGoal);
            if (currentLevel > currentGoalLevel)
            {
                SelectedWeapon.Config.LevelGoal = thisLevel;
                SelectedWeapon.LevelGoalNumberString = StringConstants.LevelNumberString[thisLevel];
                App.BackpackWeaponConfigManagerInstance.UpdateLevelGoal(SelectedWeapon.Id, thisLevel);
            }

            ClickOnLevelGoalSelectionCommand.NotifyCanExecuteChanged();
            IsLevelPopupOpen = false;
            Refresh(SelectedWeapon);
        }

        [RelayCommand(CanExecute = nameof(CanClickOnLevelGoalSelection))]
        private void ClickOnLevelGoalSelection(String value)
        {
            int valueInt = Int32.Parse(value);
            Enumeration.Level thisLevel = SequenceConstants.AllLevels[valueInt - 1];
            SelectedWeapon!.Config.LevelGoal = thisLevel;
            SelectedWeapon.LevelGoalNumberString = StringConstants.LevelNumberString[thisLevel];
            App.BackpackWeaponConfigManagerInstance!.UpdateLevelGoal(SelectedWeapon.Id, thisLevel);
            IsLevelPopupOpen = false;
        }

        private bool CanClickOnLevelGoalSelection(String value)
        {
            int valueInt = Int32.Parse(value) - 1;
            int currentLevel = SequenceConstants.AllLevels.IndexOf(SelectedWeapon!.Config.Level);
            return valueInt >= currentLevel;
        }

        [RelayCommand]
        private void ClickOnProgressionSelection(String value)
        {
            int valueInt = Int32.Parse(value);
            SelectedWeapon!.Config.Progression = valueInt;
            App.BackpackWeaponConfigManagerInstance!.UpdateProgression(SelectedWeapon.Id, valueInt);
            IsProgressionPopupOpen = false;
            Refresh(SelectedWeapon);
        }

        private void Refresh(Backpack2WeaponModel? currentWeaponModel)
        {
            WeaponList.Clear();
            Dictionary<string, SingleBackpackWeaponConfigModel> currentWeaponConfigList = App.BackpackWeaponConfigManagerInstance!.Configuration.WeaponConfigMap;
            foreach (SingleBackpackWeaponConfigModel cm in currentWeaponConfigList.Values)
            {
                Backpack2WeaponModel thisBackpack2WeaponModel = new()
                {
                    Id = cm.Id,
                    Rid = cm.Rid
                };
                WeaponModel thisWeaponModel = AutoCalculateConstants.WeaponMap[cm.Rid];
                thisBackpack2WeaponModel.Name = thisWeaponModel.Name;
                thisBackpack2WeaponModel.Star = thisWeaponModel.Star;
                int currentLevelIndex = SequenceConstants.AllLevels.IndexOf(cm.Level);
                int biasLevelIndex = SequenceConstants.AllLevels.IndexOf(Enumeration.Level.L40);
                bool isAwaken = currentLevelIndex > biasLevelIndex;
                thisBackpack2WeaponModel.ImagePath = isAwaken ? thisWeaponModel.AwakenImagePath : thisWeaponModel.ImagePath;
                thisBackpack2WeaponModel.BackgroundImagePath = StringConstants.StarBackgroundImagePath[thisWeaponModel.Star];
                thisBackpack2WeaponModel.WeaponTypeImagePath = StringConstants.WeaponTypeImagePath[thisWeaponModel.WeaponType];
                thisBackpack2WeaponModel.WeaponType = thisWeaponModel.WeaponType;
                thisBackpack2WeaponModel.Progression = cm.Progression;
                thisBackpack2WeaponModel.LevelNumberString = StringConstants.LevelNumberString[cm.Level];
                thisBackpack2WeaponModel.LevelNameString = StringConstants.LevelNameString[cm.Level];
                thisBackpack2WeaponModel.LevelGoalNumberString = StringConstants.LevelNumberString[cm.LevelGoal];
                thisBackpack2WeaponModel.Description = thisWeaponModel.Progression[cm.Progression];
                thisBackpack2WeaponModel.AffixStringList.Add(new List<string>());
                thisBackpack2WeaponModel.AffixStringList.Add(new List<string>());
                thisBackpack2WeaponModel.AffixStringList.Add(new List<string>());
                thisBackpack2WeaponModel.AffixStringList[0].Add(StringConstants.AffixString[Enumeration.Affix.Attack]);
                thisBackpack2WeaponModel.AffixStringList[1].Add(":");
                thisBackpack2WeaponModel.AffixStringList[2].Add(thisWeaponModel.MainAffixNumberDictionary[cm.Level].ToString(CultureInfo.InvariantCulture));
                if (thisWeaponModel.SubAffix != Enumeration.Affix.Empty)
                {
                    thisBackpack2WeaponModel.AffixStringList[0].Add(StringConstants.AffixString[thisWeaponModel.SubAffix]);
                    thisBackpack2WeaponModel.AffixStringList[1].Add(":");
                    thisBackpack2WeaponModel.AffixStringList[2].Add(thisWeaponModel.SubAffixNumberDictionary[cm.Level] + ((SequenceConstants.AffixPercentageSymbolList.Contains(thisWeaponModel.SubAffix)) ? "%" : ""));
                }

                if (cm.CharacterRid != 0)
                {
                    CharacterModel thisCharacterModel = AutoCalculateConstants.CharacterMap[cm.CharacterRid];
                    thisBackpack2WeaponModel.CharacterName = thisCharacterModel.Name;
                    thisBackpack2WeaponModel.CharacterImagePath = thisCharacterModel.ImagePath;
                    thisBackpack2WeaponModel.CharacterBackgroundImagePath = StringConstants.StarBackgroundImagePath[thisCharacterModel.Star];
                    thisBackpack2WeaponModel.CharacterElementImagePath = StringConstants.ElementTypeImagePath[thisCharacterModel.ElementType];
                }

                thisBackpack2WeaponModel.Config = cm;
                WeaponList.Add(thisBackpack2WeaponModel);
            }

            if (currentWeaponModel == null)
            {
                SelectedWeapon = WeaponList.Count == 0 ? null : WeaponList[0];
            }
            else
            {
                SelectedWeapon = WeaponList.FirstOrDefault(w => w.Id == currentWeaponModel.Id);
            }
        }
    }
}