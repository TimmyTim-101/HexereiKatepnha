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
    public class AddPanelModel
    {
        public string BackgroundImagePath { get; init; } = "";
        public string ImagePath { get; init; } = "";
        public string Name { get; init; } = "";
        public Enumeration.WeaponType WeaponType { get; init; } = Enumeration.WeaponType.Unknown;
        public int Star { get; init; }
        public int Rid { get; init; }
    }

    public class SelectCharacterPanelModel
    {
        public string BackgroundImagePath { get; init; } = "";
        public string ImagePath { get; set; } = "";
        public string Name { get; set; } = "";
        public Enumeration.WeaponType WeaponType { get; init; } = Enumeration.WeaponType.Unknown;
        public int Star { get; init; }
        public int Rid { get; init; }
    }

    public partial class Backpack2WeaponViewModel : ObservableObject
    {
        [ObservableProperty] private int _weaponFilter;
        [ObservableProperty] private int _starFilter;
        private ObservableCollection<Backpack2WeaponModel> WeaponList { get; } = [];
        [ObservableProperty] private Backpack2WeaponModel _selectedWeapon;
        [ObservableProperty] private bool _isLevelPopupOpen;
        [ObservableProperty] private bool _isProgressionPopupOpen;
        [ObservableProperty] private bool _isSubExpPopupOpen;
        [ObservableProperty] private List<Backpack2WeaponModel> _weaponView = [];
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
        [ObservableProperty] private List<AddPanelModel> _addPanelView = [];
        [ObservableProperty] private int _addWeaponFilter;
        [ObservableProperty] private int _addStarFilter;

        [ObservableProperty] private bool _isSelectCharacterPopupOpen;
        [ObservableProperty] private bool _isSelectCharacterWithCharacterPopupOpen;
        private List<SelectCharacterPanelModel> SelectCharacterPanelModelList { get; set; } = new();
        [ObservableProperty] private List<SelectCharacterPanelModel> _selectCharacterPanelView = [];
        [ObservableProperty] private int _selectCharacterStarFilter;

        public Backpack2WeaponViewModel()
        {
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
                thisBackpack2WeaponModel.LevelTotalExp = GetLevelTotalExp(thisWeaponModel.LevelUpMaterials[cm.Level]);
                thisBackpack2WeaponModel.SubExp = cm.SubExp;
                thisBackpack2WeaponModel.IsShowProgress = !SequenceConstants.NoExpLevels.Contains(cm.Level);
                thisBackpack2WeaponModel.LevelGoalNumberString = StringConstants.LevelNumberString[cm.GoalLevel];
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
                    thisBackpack2WeaponModel.AffixStringList[2].Add(thisWeaponModel.SubAffixNumberDictionary[cm.Level] + (SequenceConstants.AffixPercentageSymbolList.Contains(thisWeaponModel.SubAffix) ? "%" : ""));
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

            SelectedWeapon = WeaponList.FirstOrDefault()!;
            ApplyFilters();
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

            AddPanelModelList.Sort((a, b) =>
            {
                int starA = a.Star;
                int starB = b.Star;
                if (starA != starB) return starB.CompareTo(starA);
                return b.Rid.CompareTo(a.Rid);
            });
            ApplyAddPanelFilters();

            foreach (CharacterModel cm in AllEntities.AllCharacter)
            {
                SelectCharacterPanelModel thisSelectCharacterPanelModel = new()
                {
                    BackgroundImagePath = StringConstants.StarBackgroundImagePath[cm.Star],
                    ImagePath = cm.ImagePath,
                    Name = cm.Name,
                    WeaponType = cm.WeaponType,
                    Star = cm.Star,
                    Rid = cm.Rid
                };
                SelectCharacterPanelModelList.Add(thisSelectCharacterPanelModel);
            }

            SelectCharacterPanelModelList.Sort((a, b) =>
            {
                int starA = a.Star;
                int starB = b.Star;
                if (starA != starB) return starB.CompareTo(starA);
                return b.Rid.CompareTo(a.Rid);
            });
            ApplySelectCharacterFilters();
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

        private void ApplyFilters()
        {
            List<Backpack2WeaponModel> tempList = WeaponList.Where(WeaponsFilter).ToList();
            tempList.Sort((a, b) =>
            {
                int starA = a.Star;
                int starB = b.Star;
                if (starA != starB) return starB.CompareTo(starA);
                int levelA = SequenceConstants.AllLevels.IndexOf(a.Config.Level);
                int levelB = SequenceConstants.AllLevels.IndexOf(b.Config.Level);
                if (levelA != levelB) return levelB.CompareTo(levelA);
                int subExpA = a.SubExp;
                int subExpB = b.SubExp;
                if (subExpA != subExpB) return subExpB.CompareTo(subExpA);
                int ridA = a.Rid;
                int ridB = b.Rid;
                if (ridA != ridB) return ridA.CompareTo(ridB);
                int progressionA = a.Progression;
                int progressionB = b.Progression;
                if (progressionA != progressionB) return progressionB.CompareTo(progressionA);
                return string.Compare(a.Id, b.Id, StringComparison.Ordinal);
            });
            WeaponView = tempList;
            if (!WeaponView.Contains(SelectedWeapon))
            {
                SelectedWeapon = WeaponView.FirstOrDefault()!;
            }
        }

        private void ApplyAddPanelFilters()
        {
            List<AddPanelModel> tempList = AddPanelModelList.Where(AddPanelFilter).ToList();
            AddPanelView = tempList;
        }

        partial void OnSelectedWeaponChanged(Backpack2WeaponModel? value)
        {
            ClickOnLevelGoalSelectionCommand.NotifyCanExecuteChanged();
            ClickOnLevelSelectionCommand.NotifyCanExecuteChanged();
            ApplySelectCharacterFilters();
        }

        partial void OnWeaponFilterChanged(int value)
        {
            ApplyFilters();
        }

        partial void OnStarFilterChanged(int value)
        {
            ApplyFilters();
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
            SelectedWeapon.Config.Level = thisLevel;
            SelectedWeapon.Config.SubExp = 0;
            SelectedWeapon.SubExp = 0;
            SelectedWeapon.LevelNameString = StringConstants.LevelNameString[thisLevel];
            SelectedWeapon.LevelNumberString = StringConstants.LevelNumberString[thisLevel];
            SelectedWeapon.LevelTotalExp = GetLevelTotalExp(AutoCalculateConstants.WeaponMap[SelectedWeapon.Rid].LevelUpMaterials[thisLevel]);
            SelectedWeapon.IsShowProgress = !SequenceConstants.NoExpLevels.Contains(thisLevel);
            App.BackpackWeaponConfigManagerInstance!.UpdateLevel(SelectedWeapon.Id, thisLevel);
            int currentLevel = SequenceConstants.AllLevels.IndexOf(thisLevel);
            int currentGoalLevel = SequenceConstants.AllLevels.IndexOf(SelectedWeapon.Config.GoalLevel);
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
                SelectedWeapon.Config.GoalLevel = thisLevel;
                SelectedWeapon.LevelGoalNumberString = StringConstants.LevelNumberString[thisLevel];
                App.BackpackWeaponConfigManagerInstance.UpdateLevelGoal(SelectedWeapon.Id, thisLevel);
            }

            ClickOnLevelGoalSelectionCommand.NotifyCanExecuteChanged();
            IsLevelPopupOpen = false;
            ApplyFilters();
        }

        private bool CanClickOnLevelSelection(String value)
        {
            if (SelectedWeapon == null) return false;
            int valueInt = Int32.Parse(value) - 1;
            return AutoCalculateConstants.WeaponMap[SelectedWeapon.Rid].MainAffixNumberDictionary.ContainsKey(SequenceConstants.AllLevels[valueInt]);
        }

        [RelayCommand(CanExecute = nameof(CanClickOnLevelGoalSelection))]
        private void ClickOnLevelGoalSelection(String value)
        {
            int valueInt = Int32.Parse(value);
            Enumeration.Level thisLevel = SequenceConstants.AllLevels[valueInt - 1];
            SelectedWeapon.Config.GoalLevel = thisLevel;
            SelectedWeapon.LevelGoalNumberString = StringConstants.LevelNumberString[thisLevel];
            App.BackpackWeaponConfigManagerInstance!.UpdateLevelGoal(SelectedWeapon.Id, thisLevel);
            IsLevelPopupOpen = false;
        }

        private bool CanClickOnLevelGoalSelection(String value)
        {
            if (SelectedWeapon == null) return false;
            int valueInt = Int32.Parse(value) - 1;
            int currentLevel = SequenceConstants.AllLevels.IndexOf(SelectedWeapon.Config.Level);
            if (!AutoCalculateConstants.WeaponMap[SelectedWeapon.Rid].MainAffixNumberDictionary.ContainsKey(SequenceConstants.AllLevels[valueInt])) return false;
            return valueInt >= currentLevel;
        }

        [RelayCommand]
        private void ClickOnProgressionSelection(String value)
        {
            int valueInt = Int32.Parse(value);
            SelectedWeapon.Config.Progression = valueInt;
            App.BackpackWeaponConfigManagerInstance!.UpdateProgression(SelectedWeapon.Id, valueInt);
            SelectedWeapon.Progression = valueInt;
            SelectedWeapon.Description = AutoCalculateConstants.WeaponMap[SelectedWeapon.Rid].Progression[valueInt];
            IsProgressionPopupOpen = false;
            ApplyFilters();
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
            ApplyAddPanelFilters();
        }

        partial void OnAddStarFilterChanged(int value)
        {
            ApplyAddPanelFilters();
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
            thisBackpack2WeaponModel.LevelTotalExp = GetLevelTotalExp(thisWeaponModel.LevelUpMaterials[thisConfig.Level]);
            thisBackpack2WeaponModel.SubExp = thisConfig.SubExp;
            thisBackpack2WeaponModel.IsShowProgress = !SequenceConstants.NoExpLevels.Contains(thisConfig.Level);
            thisBackpack2WeaponModel.LevelGoalNumberString = StringConstants.LevelNumberString[thisConfig.GoalLevel];
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
            ApplyFilters();
            SelectedWeapon = WeaponList.FirstOrDefault(w => w.Id == thisConfig.Id)!;
            IsAddPanelPopupOpen = false;
        }

        [RelayCommand]
        private void ClickOnDeleteWeapon(string value)
        {
            App.BackpackWeaponConfigManagerInstance!.DeleteWeapon(value);
            WeaponList.Remove(WeaponList.First(w => w.Id == value));
            ApplyFilters();
        }

        private int GetLevelTotalExp(List<MaterialPairModel> l)
        {
            int res = 1;
            foreach (MaterialPairModel m in l)
            {
                if (m.MaterialModel!.Rid == 3110001)
                {
                    res = (int)m.DropNum;
                }
            }

            return res;
        }

        [RelayCommand]
        private void ClickOnWeapon(Backpack2WeaponModel value)
        {
            SelectedWeapon = value;
        }

        private bool SelectCharacterFilter(object item)
        {
            if (item is not SelectCharacterPanelModel m) return false;
            bool isWeapon = true;
            bool isStar = true;
            if (SelectedWeapon != null)
            {
                isWeapon = m.WeaponType == SelectedWeapon.WeaponType;
            }

            switch (SelectCharacterStarFilter)
            {
                case 4: isStar = m.Star == 4; break;
                case 5: isStar = m.Star >= 5; break;
            }

            return isWeapon && isStar;
        }

        partial void OnSelectCharacterStarFilterChanged(int value)
        {
            ApplySelectCharacterFilters();
        }

        private void ApplySelectCharacterFilters()
        {
            SelectCharacterPanelView = SelectCharacterPanelModelList.Where(SelectCharacterFilter).ToList();
        }

        [RelayCommand]
        private void ClickOnSelectCharacterStarFilter(String value)
        {
            int valueInt = Int32.Parse(value);
            SelectCharacterStarFilter = valueInt == SelectCharacterStarFilter ? 0 : valueInt;
        }

        [RelayCommand]
        private void ClickOnEraseSelectCharacter(string value)
        {
            SelectedWeapon.CharacterBackgroundImagePath = StringConstants.EmptyImagePath;
            SelectedWeapon.CharacterElementImagePath = StringConstants.EmptyImagePath;
            SelectedWeapon.CharacterImagePath = StringConstants.EmptyImagePath;
            SelectedWeapon.CharacterName = "";
            int oldCharacterId = SelectedWeapon.Config.CharacterRid;
            App.BackpackWeaponConfigManagerInstance!.UpdateCharacter(value, 0);
            App.BackpackCharacterConfigManagerInstance!.UpdateWeapon(oldCharacterId, "");
            IsSelectCharacterPopupOpen = false;
            IsSelectCharacterWithCharacterPopupOpen = false;
        }

        [RelayCommand]
        private void ClickOnSelectCharacter(int value)
        {
            int thisCharacterRid = value;
            CharacterModel thisCharacter = AutoCalculateConstants.CharacterMap[thisCharacterRid];
            int oldCharacterId = SelectedWeapon.Config.CharacterRid;
            App.BackpackCharacterConfigManagerInstance!.UpdateWeapon(oldCharacterId, "");
            // 遍历所有武器看是否已有武器分配给这个角色
            foreach (Backpack2WeaponModel wm in WeaponList)
            {
                if (wm.Config.CharacterRid == thisCharacterRid)
                {
                    // 如果有，进行交换
                    wm.CharacterName = SelectedWeapon.CharacterName;
                    wm.CharacterBackgroundImagePath = SelectedWeapon.CharacterBackgroundImagePath;
                    wm.CharacterElementImagePath = SelectedWeapon.CharacterElementImagePath;
                    wm.CharacterImagePath = SelectedWeapon.CharacterImagePath;
                    App.BackpackWeaponConfigManagerInstance!.UpdateCharacter(wm.Id, oldCharacterId);
                    App.BackpackCharacterConfigManagerInstance.UpdateWeapon(oldCharacterId, wm.Id);
                    break;
                }
            }

            SelectedWeapon.CharacterName = thisCharacter.Name;
            SelectedWeapon.CharacterBackgroundImagePath = StringConstants.StarBackgroundImagePath[thisCharacter.Star];
            SelectedWeapon.CharacterElementImagePath = StringConstants.ElementTypeImagePath[thisCharacter.ElementType];
            SelectedWeapon.CharacterImagePath = thisCharacter.ImagePath;
            App.BackpackWeaponConfigManagerInstance!.UpdateCharacter(SelectedWeapon.Id, thisCharacterRid);
            App.BackpackCharacterConfigManagerInstance.UpdateWeapon(thisCharacterRid, SelectedWeapon.Id);
            IsSelectCharacterPopupOpen = false;
            IsSelectCharacterWithCharacterPopupOpen = false;
        }
    }
}