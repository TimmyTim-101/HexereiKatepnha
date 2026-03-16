using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Data;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.ModelsForViews.Database;
using HexereiKatepnha.Models.ModelsForViews.Database.SubModels;

namespace HexereiKatepnha.ViewModels.Database
{
    public partial class Database2WeaponViewModel : ObservableObject
    {
        [ObservableProperty] private bool _isShowMoreNumbers;
        [ObservableProperty] private bool _isShowLessNumbers = true;
        [ObservableProperty] private bool _isShowAwakenImage;
        [ObservableProperty] private bool _isShowOriginalImage = true;
        [ObservableProperty] private int _weaponFilter;
        [ObservableProperty] private int _starFilter;
        public ObservableCollection<Database2WeaponModel> AllWeaponList { get; } = new();
        [ObservableProperty] private Database2WeaponModel _selectedWeapon;
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

        public Database2WeaponViewModel()
        {
            foreach (WeaponModel e in AllEntities.AllWeapon)
            {
                Database2WeaponModel thisDatabase2WeaponModel = new Database2WeaponModel();
                thisDatabase2WeaponModel.Vid = e.Vid;
                thisDatabase2WeaponModel.Name = e.Name;
                thisDatabase2WeaponModel.ImagePath = e.ImagePath;
                thisDatabase2WeaponModel.AwakenImagePath = e.AwakenImagePath;
                thisDatabase2WeaponModel.BackgroundImagePath = StringConstants.StarBackgroundImagePath[e.Star];
                thisDatabase2WeaponModel.Star = e.Star;
                thisDatabase2WeaponModel.StarImagePath = StringConstants.StarImagePath[e.Star];
                thisDatabase2WeaponModel.WeaponType = e.WeaponType;
                thisDatabase2WeaponModel.WeaponTypeName = StringConstants.WeaponTypeString[e.WeaponType];
                thisDatabase2WeaponModel.WeaponTypeImagePath = StringConstants.WeaponTypeImagePath[e.WeaponType];
                thisDatabase2WeaponModel.SubAffixName = StringConstants.AffixString[e.SubAffix];
                thisDatabase2WeaponModel.NeedMaterialList = [];
                IEnumerable<MaterialModel> allMaterials = e.LevelUpMaterials.Values.SelectMany(list => list).Select(pair => (MaterialModel)pair.MaterialModel!).Where(_ => true);
                IEnumerable<MaterialModel> uniqueMaterials = allMaterials.DistinctBy(m => m.Rid).OrderBy(m => m.Rid);
                foreach (MaterialModel p in uniqueMaterials)
                {
                    DungeonDropItemModel thisDropModel = new DungeonDropItemModel();
                    thisDropModel.MaterialName = p.Name;
                    thisDropModel.MaterialImagePath = p.ImagePath;
                    thisDropModel.MaterialStarImagePath = StringConstants.StarBackgroundImagePath[p.Star];
                    thisDatabase2WeaponModel.NeedMaterialList.Add(thisDropModel);
                }

                var lastItem = thisDatabase2WeaponModel.NeedMaterialList.Last();
                if (thisDatabase2WeaponModel.NeedMaterialList.Count == 9)
                {
                    thisDatabase2WeaponModel.NeedMaterialList.Insert(1, lastItem);
                    thisDatabase2WeaponModel.NeedMaterialList.RemoveAt(thisDatabase2WeaponModel.NeedMaterialList.Count - 1);
                }

                if (thisDatabase2WeaponModel.NeedMaterialList.Count == 12)
                {
                    thisDatabase2WeaponModel.NeedMaterialList.Insert(4, lastItem);
                    thisDatabase2WeaponModel.NeedMaterialList.RemoveAt(thisDatabase2WeaponModel.NeedMaterialList.Count - 1);
                }

                thisDatabase2WeaponModel.Progression1 = "·" + e.Progression[1];
                thisDatabase2WeaponModel.Progression2 = "·" + e.Progression[2];
                thisDatabase2WeaponModel.Progression3 = "·" + e.Progression[3];
                thisDatabase2WeaponModel.Progression4 = "·" + e.Progression[4];
                thisDatabase2WeaponModel.Progression5 = "·" + e.Progression[5];

                thisDatabase2WeaponModel.SimpleLevelStatTable.Clear();
                thisDatabase2WeaponModel.SimpleLevelStatTable.Add(new WeaponLevelStatModel { S1 = "等级", S2 = "攻击力", S3 = StringConstants.AffixString[e.SubAffix] });
                thisDatabase2WeaponModel.FullLevelStatTable.Clear();
                thisDatabase2WeaponModel.FullLevelStatTable.Add(new WeaponLevelStatModel { S1 = "等级", S2 = "攻击力", S3 = StringConstants.AffixString[e.SubAffix] });
                for (int i = 0; i < SequenceConstants.AllLevels.Count; i++)
                {
                    Enumeration.Level thisLevel = SequenceConstants.AllLevels[i];
                    if (e.MainAffixNumberDictionary.ContainsKey(thisLevel))
                    {
                        WeaponLevelStatModel thisWeaponLevelStatModel = new WeaponLevelStatModel
                        {
                            S1 = StringConstants.LevelString[thisLevel],
                            S2 = e.MainAffixNumberDictionary[thisLevel].ToString(CultureInfo.InvariantCulture),
                            S3 = e.SubAffixNumberDictionary[thisLevel].ToString(CultureInfo.InvariantCulture),
                        };
                        if (SequenceConstants.AffixPercentageSymbolList.Contains(e.SubAffix))
                        {
                            thisWeaponLevelStatModel.S3 += "%";
                        }

                        if (thisWeaponLevelStatModel.S3 == "0") thisWeaponLevelStatModel.S3 = "";
                        thisDatabase2WeaponModel.FullLevelStatTable.Add(thisWeaponLevelStatModel);
                        if (SequenceConstants.ImportantLevels.Contains(thisLevel))
                        {
                            thisDatabase2WeaponModel.SimpleLevelStatTable.Add(thisWeaponLevelStatModel);
                        }
                    }
                }

                AllWeaponList.Add(thisDatabase2WeaponModel);
            }

            _selectedWeapon = AllWeaponList[0];
            WeaponView = CollectionViewSource.GetDefaultView(AllWeaponList);
            WeaponView.Filter = WeaponsFilter;
        }

        private bool WeaponsFilter(object item)
        {
            if (item is Database2WeaponModel w)
            {
                bool isWeapon = true;
                bool isStar = (StarFilter == w.Star) || (StarFilter == 0);
                switch (WeaponFilter)
                {
                    case 1: isWeapon = w.WeaponType == Enumeration.WeaponType.Sword; break;
                    case 2: isWeapon = w.WeaponType == Enumeration.WeaponType.Claymore; break;
                    case 3: isWeapon = w.WeaponType == Enumeration.WeaponType.Pole; break;
                    case 4: isWeapon = w.WeaponType == Enumeration.WeaponType.Catalyst; break;
                    case 5: isWeapon = w.WeaponType == Enumeration.WeaponType.Bow; break;
                }

                return isWeapon && isStar;
            }

            return false;
        }

        private void UpdateSelection()
        {
            if (!WeaponView.Contains(SelectedWeapon))
            {
                SelectedWeapon = WeaponView.Cast<Database2WeaponModel>().FirstOrDefault()!;
            }
        }

        partial void OnIsShowMoreNumbersChanged(bool value)
        {
            IsShowLessNumbers = !IsShowMoreNumbers;
        }

        partial void OnIsShowAwakenImageChanged(bool value)
        {
            IsShowOriginalImage = !IsShowAwakenImage;
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
            if (valueInt == WeaponFilter)
            {
                WeaponFilter = 0;
            }
            else
            {
                WeaponFilter = valueInt;
            }
        }

        [RelayCommand]
        private void ClickOnStarFilter(String value)
        {
            int valueInt = Int32.Parse(value);
            if (valueInt == StarFilter)
            {
                StarFilter = 0;
            }
            else
            {
                StarFilter = valueInt;
            }
        }
    }
}