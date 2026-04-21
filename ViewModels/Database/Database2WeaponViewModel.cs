using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.ModelsForViews.Database;

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
        private ObservableCollection<Database2WeaponModel> AllWeaponList { get; } = [];
        [ObservableProperty] private Database2WeaponModel _selectedWeapon;
        [ObservableProperty] private List<Database2WeaponModel> _weaponView = [];
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
                Database2WeaponModel thisDatabase2WeaponModel = new Database2WeaponModel
                {
                    Vid = e.Vid,
                    Name = e.Name,
                    ImagePath = e.ImagePath,
                    AwakenImagePath = e.AwakenImagePath,
                    BackgroundImagePath = StringConstants.StarBackgroundImagePath[e.Star],
                    Star = e.Star,
                    StarImagePath = StringConstants.StarImagePath[e.Star],
                    WeaponType = e.WeaponType,
                    WeaponTypeName = StringConstants.WeaponTypeString[e.WeaponType],
                    WeaponTypeImagePath = StringConstants.WeaponTypeImagePath[e.WeaponType],
                    SubAffixName = StringConstants.AffixString[e.SubAffix],
                    NeedMaterialList = []
                };
                IEnumerable<MaterialModel> allMaterials = e.LevelUpMaterials.Values.SelectMany(list => list).Select(pair => (MaterialModel)pair.MaterialModel!).Where(_ => true);
                IEnumerable<MaterialModel> uniqueMaterials = allMaterials.DistinctBy(m => m.Rid).OrderBy(m => m.Rid);
                foreach (MaterialModel p in uniqueMaterials)
                {
                    DungeonDropItemModel thisDropModel = new DungeonDropItemModel
                    {
                        MaterialName = p.Name,
                        MaterialImagePath = p.ImagePath,
                        MaterialStarImagePath = StringConstants.StarBackgroundImagePath[p.Star]
                    };
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
                foreach (Enumeration.Level thisLevel in SequenceConstants.AllLevels)
                {
                    if (e.MainAffixNumberDictionary.TryGetValue(thisLevel, out var value))
                    {
                        WeaponLevelStatModel thisWeaponLevelStatModel = new WeaponLevelStatModel
                        {
                            S1 = StringConstants.LevelNumberString[thisLevel],
                            S2 = value.ToString(CultureInfo.InvariantCulture),
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
            ApplyFilters();
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

        private void ApplyFilters()
        {
            WeaponView = AllWeaponList.Where(WeaponsFilter).ToList();
            if (!WeaponView.Contains(SelectedWeapon))
            {
                SelectedWeapon = WeaponView.FirstOrDefault()!;
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

        [RelayCommand]
        private void ClickOnWeapon(Database2WeaponModel value)
        {
            SelectedWeapon = value;
        }

        [RelayCommand]
        public void OpenHelpWebPage()
        {
            string url = "https://github.com/TimmyTim-101/HexereiKatepnha/wiki/%E6%95%B0%E6%8D%AE%E5%BA%93-%E2%80%90-%E6%AD%A6%E5%99%A8";
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
    }
}