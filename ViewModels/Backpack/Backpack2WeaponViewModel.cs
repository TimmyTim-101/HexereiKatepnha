using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Data;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.ConfigModels;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.Messages;
using HexereiKatepnha.Models.ModelsForViews.Backpack;

namespace HexereiKatepnha.ViewModels.Backpack
{
    public class AddPanelModel
    {
        public string BackgroundImagePath { get; init; } = "";
        public string ImagePath { get; init; } = "";
        public string Name { get; init; } = "";
        public Enumeration.WeaponType WeaponType { get; init; } = Enumeration.WeaponType.Unknown;
        public int Star { get; init; }
        public int Rid { get; init; }
    }

    public partial class Backpack2WeaponViewModel : ObservableObject
    {
        [ObservableProperty] private int _weaponFilter;
        [ObservableProperty] private int _starFilter;
        private ObservableCollection<Backpack2WeaponModel> WeaponList { get; }
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

        private List<AddPanelModel> AddPanelModelList { get; set; } = new();
        [ObservableProperty] private bool _isAddPanelPopupOpen;
        public ICollectionView AddPanelView { get; }
        [ObservableProperty] private int _addWeaponFilter;
        [ObservableProperty] private int _addStarFilter;

        public Backpack2WeaponViewModel()
        {
            Dictionary<string, SingleBackpackWeaponConfigModel> currentWeaponConfigList = App.BackpackWeaponConfigManagerInstance!.Configuration.WeaponConfigMap;
            ObservableCollection<Backpack2WeaponModel> tempWeaponList = new();
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
                thisBackpack2WeaponModel.AffixStringList.Add(new ObservableCollection<string>());
                thisBackpack2WeaponModel.AffixStringList.Add(new ObservableCollection<string>());
                thisBackpack2WeaponModel.AffixStringList.Add(new ObservableCollection<string>());
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
                tempWeaponList.Add(thisBackpack2WeaponModel);
            }

            WeaponList = tempWeaponList;
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

            SelectedWeapon = WeaponView.Cast<Backpack2WeaponModel>().FirstOrDefault();
            foreach (WeaponModel wm in AllEntities.AllWeapon)
            {
                AddPanelModel thisAddPanelModel = new()
                {
                    BackgroundImagePath = StringConstants.StarBackgroundImagePath[wm.Star],
                    ImagePath = wm.ImagePath,
                    Name = wm.Name,
                    WeaponType = wm.WeaponType,
                    Star = wm.Star,
                    Rid = wm.Rid
                };
                AddPanelModelList.Add(thisAddPanelModel);
            }

            AddPanelModelList.Sort((w1, w2) => w2.Star.CompareTo(w1.Star));
            AddPanelView = CollectionViewSource.GetDefaultView(AddPanelModelList);
            AddPanelView.Filter = AddPanelFilter;
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
            ClickOnLevelSelectionCommand.NotifyCanExecuteChanged();
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

        [RelayCommand(CanExecute = nameof(CanClickOnLevelSelection))]
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
            int biasLevelIndex = SequenceConstants.AllLevels.IndexOf(Enumeration.Level.L40);
            bool isAwaken = currentLevel > biasLevelIndex;
            WeaponModel thisWeaponModel = AutoCalculateConstants.WeaponMap[SelectedWeapon.Rid];
            SelectedWeapon.ImagePath = isAwaken ? thisWeaponModel.AwakenImagePath : thisWeaponModel.ImagePath;
            SelectedWeapon.AffixStringList.Clear();
            SelectedWeapon.AffixStringList.Add([]);
            SelectedWeapon.AffixStringList.Add([]);
            SelectedWeapon.AffixStringList.Add([]);
            SelectedWeapon.AffixStringList[0].Add(StringConstants.AffixString[Enumeration.Affix.Attack]);
            SelectedWeapon.AffixStringList[1].Add(":");
            SelectedWeapon.AffixStringList[2].Add(thisWeaponModel.MainAffixNumberDictionary[thisLevel].ToString(CultureInfo.InvariantCulture));
            if (thisWeaponModel.SubAffix != Enumeration.Affix.Empty)
            {
                SelectedWeapon.AffixStringList[0].Add(StringConstants.AffixString[thisWeaponModel.SubAffix]);
                SelectedWeapon.AffixStringList[1].Add(":");
                SelectedWeapon.AffixStringList[2].Add(thisWeaponModel.SubAffixNumberDictionary[thisLevel] + ((SequenceConstants.AffixPercentageSymbolList.Contains(thisWeaponModel.SubAffix)) ? "%" : ""));
            }

            if (currentLevel > currentGoalLevel)
            {
                SelectedWeapon.Config.LevelGoal = thisLevel;
                SelectedWeapon.LevelGoalNumberString = StringConstants.LevelNumberString[thisLevel];
                App.BackpackWeaponConfigManagerInstance.UpdateLevelGoal(SelectedWeapon.Id, thisLevel);
            }

            ClickOnLevelGoalSelectionCommand.NotifyCanExecuteChanged();
            IsLevelPopupOpen = false;
        }

        private bool CanClickOnLevelSelection(String value)
        {
            if (SelectedWeapon == null) return false;
            int valueInt = Int32.Parse(value) - 1;
            return AutoCalculateConstants.WeaponMap[SelectedWeapon!.Rid].MainAffixNumberDictionary.ContainsKey(SequenceConstants.AllLevels[valueInt]);
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
            if (SelectedWeapon == null) return false;
            int valueInt = Int32.Parse(value) - 1;
            int currentLevel = SequenceConstants.AllLevels.IndexOf(SelectedWeapon!.Config.Level);
            if (!AutoCalculateConstants.WeaponMap[SelectedWeapon.Rid].MainAffixNumberDictionary.ContainsKey(SequenceConstants.AllLevels[valueInt])) return false;
            return valueInt >= currentLevel;
        }

        [RelayCommand]
        private void ClickOnProgressionSelection(String value)
        {
            int valueInt = Int32.Parse(value);
            SelectedWeapon!.Config.Progression = valueInt;
            App.BackpackWeaponConfigManagerInstance!.UpdateProgression(SelectedWeapon.Id, valueInt);
            SelectedWeapon.Progression = valueInt;
            SelectedWeapon.Description = AutoCalculateConstants.WeaponMap[SelectedWeapon.Rid].Progression[valueInt];
            IsProgressionPopupOpen = false;
        }

        private bool AddPanelFilter(object item)
        {
            if (item is not AddPanelModel m) return false;
            bool isWeapon = true;
            bool isStar = true;
            switch (AddWeaponFilter)
            {
                case 1: isWeapon = m.WeaponType == Enumeration.WeaponType.Sword; break;
                case 2: isWeapon = m.WeaponType == Enumeration.WeaponType.Claymore; break;
                case 3: isWeapon = m.WeaponType == Enumeration.WeaponType.Pole; break;
                case 4: isWeapon = m.WeaponType == Enumeration.WeaponType.Catalyst; break;
                case 5: isWeapon = m.WeaponType == Enumeration.WeaponType.Bow; break;
            }

            switch (AddStarFilter)
            {
                case 1: isStar = m.Star == 1; break;
                case 2: isStar = m.Star == 2; break;
                case 3: isStar = m.Star == 3; break;
                case 4: isStar = m.Star == 4; break;
                case 5: isStar = m.Star == 5; break;
            }

            return isWeapon && isStar;
        }

        partial void OnAddWeaponFilterChanged(int value)
        {
            AddPanelView.Refresh();
        }

        partial void OnAddStarFilterChanged(int value)
        {
            AddPanelView.Refresh();
        }

        [RelayCommand]
        private void ClickOnAddWeaponFilter(String value)
        {
            int valueInt = Int32.Parse(value);
            AddWeaponFilter = valueInt == AddWeaponFilter ? 0 : valueInt;
        }

        [RelayCommand]
        private void ClickOnAddStarFilter(String value)
        {
            int valueInt = Int32.Parse(value);
            AddStarFilter = valueInt == AddStarFilter ? 0 : valueInt;
        }

        [RelayCommand]
        private void ClickOnAddPanelWeapon(int value)
        {
            int thisRid = value;
            SingleBackpackWeaponConfigModel thisConfig = App.BackpackWeaponConfigManagerInstance!.AddWeapon(thisRid);
            Backpack2WeaponModel thisBackpack2WeaponModel = new()
            {
                Id = thisConfig.Id,
                Rid = thisConfig.Rid
            };
            WeaponModel thisWeaponModel = AutoCalculateConstants.WeaponMap[thisRid];
            thisBackpack2WeaponModel.Name = thisWeaponModel.Name;
            thisBackpack2WeaponModel.Star = thisWeaponModel.Star;
            int currentLevelIndex = SequenceConstants.AllLevels.IndexOf(thisConfig.Level);
            int biasLevelIndex = SequenceConstants.AllLevels.IndexOf(Enumeration.Level.L40);
            bool isAwaken = currentLevelIndex > biasLevelIndex;
            thisBackpack2WeaponModel.ImagePath = isAwaken ? thisWeaponModel.AwakenImagePath : thisWeaponModel.ImagePath;
            thisBackpack2WeaponModel.BackgroundImagePath = StringConstants.StarBackgroundImagePath[thisWeaponModel.Star];
            thisBackpack2WeaponModel.WeaponTypeImagePath = StringConstants.WeaponTypeImagePath[thisWeaponModel.WeaponType];
            thisBackpack2WeaponModel.WeaponType = thisWeaponModel.WeaponType;
            thisBackpack2WeaponModel.Progression = thisConfig.Progression;
            thisBackpack2WeaponModel.LevelNumberString = StringConstants.LevelNumberString[thisConfig.Level];
            thisBackpack2WeaponModel.LevelNameString = StringConstants.LevelNameString[thisConfig.Level];
            thisBackpack2WeaponModel.LevelGoalNumberString = StringConstants.LevelNumberString[thisConfig.LevelGoal];
            thisBackpack2WeaponModel.Description = thisWeaponModel.Progression[thisConfig.Progression];
            thisBackpack2WeaponModel.AffixStringList.Add([]);
            thisBackpack2WeaponModel.AffixStringList.Add([]);
            thisBackpack2WeaponModel.AffixStringList.Add([]);
            thisBackpack2WeaponModel.AffixStringList[0].Add(StringConstants.AffixString[Enumeration.Affix.Attack]);
            thisBackpack2WeaponModel.AffixStringList[1].Add(":");
            thisBackpack2WeaponModel.AffixStringList[2].Add(thisWeaponModel.MainAffixNumberDictionary[thisConfig.Level].ToString(CultureInfo.InvariantCulture));
            if (thisWeaponModel.SubAffix != Enumeration.Affix.Empty)
            {
                thisBackpack2WeaponModel.AffixStringList[0].Add(StringConstants.AffixString[thisWeaponModel.SubAffix]);
                thisBackpack2WeaponModel.AffixStringList[1].Add(":");
                thisBackpack2WeaponModel.AffixStringList[2].Add(thisWeaponModel.SubAffixNumberDictionary[thisConfig.Level] + ((SequenceConstants.AffixPercentageSymbolList.Contains(thisWeaponModel.SubAffix)) ? "%" : ""));
            }

            if (thisConfig.CharacterRid != 0)
            {
                CharacterModel thisCharacterModel = AutoCalculateConstants.CharacterMap[thisConfig.CharacterRid];
                thisBackpack2WeaponModel.CharacterName = thisCharacterModel.Name;
                thisBackpack2WeaponModel.CharacterImagePath = thisCharacterModel.ImagePath;
                thisBackpack2WeaponModel.CharacterBackgroundImagePath = StringConstants.StarBackgroundImagePath[thisCharacterModel.Star];
                thisBackpack2WeaponModel.CharacterElementImagePath = StringConstants.ElementTypeImagePath[thisCharacterModel.ElementType];
            }

            thisBackpack2WeaponModel.Config = thisConfig;
            WeaponList.Add(thisBackpack2WeaponModel);
            SelectedWeapon = WeaponList.FirstOrDefault(w => w.Id == thisConfig.Id);
            IsAddPanelPopupOpen = false;
        }

        [RelayCommand]
        private void ClickOnDeleteWeapon(string value)
        {
            App.BackpackWeaponConfigManagerInstance!.DeleteWeapon(value);
            WeaponList.Remove(WeaponList.First(w => w.Id == value));
            SelectedWeapon = WeaponView.Cast<Backpack2WeaponModel>().FirstOrDefault();
        }
    }
}