using System.CodeDom;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
        public ObservableCollection<Backpack2WeaponModel> WeaponList { get; set; } = new();
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
            Refresh();
            _selectedWeapon = WeaponList.Count == 0 ? null : WeaponList[0];
            WeaponView = CollectionViewSource.GetDefaultView(WeaponList);
            WeaponView.Filter = WeaponsFilter;
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

        private void Refresh()
        {
            WeaponList.Clear();
            Dictionary<string, SingleBackpackWeaponConfigModel> currentWeaponConfigList = App.BackpackWeaponConfigManagerInstance!.Configuration.WeaponConfigMap;
            foreach (SingleBackpackWeaponConfigModel cm in currentWeaponConfigList.Values)
            {
                Backpack2WeaponModel thisBackpack2WeaponModel = new();
                thisBackpack2WeaponModel.Id = cm.Id;
                thisBackpack2WeaponModel.Rid = cm.Rid;
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
                if (cm.CharacterRid != 0)
                {
                    CharacterModel thisCharacterModel = AutoCalculateConstants.CharacterMap[cm.CharacterRid];
                    thisBackpack2WeaponModel.CharacterName = thisCharacterModel.Name;
                    thisBackpack2WeaponModel.CharacterImagePath = thisCharacterModel.ImagePath;
                    thisBackpack2WeaponModel.CharacterBackgroundImagePath = StringConstants.StarBackgroundImagePath[thisCharacterModel.Star];
                    thisBackpack2WeaponModel.CharacterElementImagePath = StringConstants.ElementTypeImagePath[thisCharacterModel.ElementType];
                }

                WeaponList.Add(thisBackpack2WeaponModel);
            }
        }
    }
}