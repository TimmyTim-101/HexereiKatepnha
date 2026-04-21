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
    public partial class Database1CharacterViewModel : ObservableObject
    {
        [ObservableProperty] private bool _isShowMoreNumbers;
        [ObservableProperty] private bool _isShowLessNumbers = true;
        [ObservableProperty] private int _elementFilter;
        [ObservableProperty] private int _weaponFilter;
        [ObservableProperty] private int _starFilter;
        private ObservableCollection<Database1CharacterModel> AllCharacterList { get; } = [];
        [ObservableProperty] private Database1CharacterModel _selectedCharacter;
        [ObservableProperty] private List<Database1CharacterModel> _characterView = [];
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

        public Database1CharacterViewModel()
        {
            foreach (CharacterModel e in AllEntities.AllCharacter)
            {
                Database1CharacterModel thisDatabase1CharacterModel = new Database1CharacterModel
                {
                    ImagePath = e.ImagePath,
                    ElementType = e.ElementType,
                    ElementImagePath = StringConstants.ElementTypeImagePath[e.ElementType],
                    BackgroundImagePath = StringConstants.StarBackgroundImagePath[e.Star],
                    Name = e.Name,
                    Vid = e.Vid,
                    Star = e.Star,
                    StarImagePath = StringConstants.StarImagePath[e.Star],
                    BirthdayString = "生日：" + e.BirthMonth + " / " + e.BirthDay,
                    WeaponType = e.WeaponType,
                    WeaponTypeName = StringConstants.WeaponTypeString[e.WeaponType],
                    WeaponTypeImagePath = StringConstants.WeaponTypeImagePath[e.WeaponType],
                    NeedMaterialList = []
                };
                IEnumerable<MaterialModel> uniqueMaterials = e.LevelUpMaterials.Values
                    .Concat(e.Talent1Materials.Values)
                    .Concat(e.Talent2Materials.Values)
                    .Concat(e.Talent3Materials.Values)
                    .SelectMany(list => list)
                    .Select(pair => pair.MaterialModel as MaterialModel)
                    .Where(m => m != null)
                    .DistinctBy(m => m!.Rid)
                    .OrderBy(m => m!.Rid)!;
                foreach (MaterialModel p in uniqueMaterials)
                {
                    DungeonDropItemModel thisDropModel = new DungeonDropItemModel
                    {
                        MaterialName = p.Name,
                        MaterialImagePath = p.ImagePath,
                        MaterialStarImagePath = StringConstants.StarBackgroundImagePath[p.Star]
                    };
                    thisDatabase1CharacterModel.NeedMaterialList.Add(thisDropModel);
                }

                if (thisDatabase1CharacterModel.NeedMaterialList.Count == 16)
                {
                    List<DungeonDropItemModel> newNeedMaterialList =
                    [
                        thisDatabase1CharacterModel.NeedMaterialList[0], thisDatabase1CharacterModel.NeedMaterialList[1], thisDatabase1CharacterModel.NeedMaterialList[6], thisDatabase1CharacterModel.NeedMaterialList[5],
                        thisDatabase1CharacterModel.NeedMaterialList[2], thisDatabase1CharacterModel.NeedMaterialList[3], thisDatabase1CharacterModel.NeedMaterialList[4], thisDatabase1CharacterModel.NeedMaterialList[15],
                        thisDatabase1CharacterModel.NeedMaterialList[12], thisDatabase1CharacterModel.NeedMaterialList[13], thisDatabase1CharacterModel.NeedMaterialList[14], thisDatabase1CharacterModel.NeedMaterialList[11],
                        thisDatabase1CharacterModel.NeedMaterialList[7], thisDatabase1CharacterModel.NeedMaterialList[8], thisDatabase1CharacterModel.NeedMaterialList[9], thisDatabase1CharacterModel.NeedMaterialList[10],
                    ];
                    thisDatabase1CharacterModel.NeedMaterialList = newNeedMaterialList;
                }

                thisDatabase1CharacterModel.Talent1ImagePath = e.Talent[1].ImagePath;
                thisDatabase1CharacterModel.Talent1Description = e.Talent[1].Description;
                thisDatabase1CharacterModel.Talent2ImagePath = e.Talent[2].ImagePath;
                thisDatabase1CharacterModel.Talent2Description = e.Talent[2].Description;
                thisDatabase1CharacterModel.Talent3ImagePath = e.Talent[3].ImagePath;
                thisDatabase1CharacterModel.Talent3Description = e.Talent[3].Description;

                thisDatabase1CharacterModel.Ascension1ImagePath = e.Constellation[1].ImagePath;
                thisDatabase1CharacterModel.Ascension1Description = e.Constellation[1].Description;
                thisDatabase1CharacterModel.Ascension2ImagePath = e.Constellation[2].ImagePath;
                thisDatabase1CharacterModel.Ascension2Description = e.Constellation[2].Description;
                thisDatabase1CharacterModel.Ascension3ImagePath = e.Constellation[3].ImagePath;
                thisDatabase1CharacterModel.Ascension3Description = e.Constellation[3].Description;
                thisDatabase1CharacterModel.Ascension4ImagePath = e.Constellation[4].ImagePath;
                thisDatabase1CharacterModel.Ascension4Description = e.Constellation[4].Description;
                thisDatabase1CharacterModel.Ascension5ImagePath = e.Constellation[5].ImagePath;
                thisDatabase1CharacterModel.Ascension5Description = e.Constellation[5].Description;
                thisDatabase1CharacterModel.Ascension6ImagePath = e.Constellation[6].ImagePath;
                thisDatabase1CharacterModel.Ascension6Description = e.Constellation[6].Description;

                CharacterStatModel beginningStat = new CharacterStatModel();
                beginningStat.S1 = "等级";
                beginningStat.S2 = "生命值";
                beginningStat.S3 = "攻击力";
                beginningStat.S4 = "防御力";
                beginningStat.S5 = "暴击率";
                beginningStat.S6 = "暴击伤害";
                foreach (Enumeration.Affix a in e.AffixDictionary[Enumeration.Level.L1].Keys)
                {
                    if (a != Enumeration.Affix.Health && a != Enumeration.Affix.Attack && a != Enumeration.Affix.Defense && a != Enumeration.Affix.CriticalRate && a != Enumeration.Affix.CriticalDamage)
                    {
                        beginningStat.S7 = StringConstants.AffixString[a];
                    }
                }

                thisDatabase1CharacterModel.SimpleLevelStatTable.Add(beginningStat);
                thisDatabase1CharacterModel.FullLevelStatTable.Add(beginningStat);
                foreach (Enumeration.Level thisLevel in SequenceConstants.AllLevels)
                {
                    if (e.AffixDictionary.TryGetValue(thisLevel, out var thisLevelAffixDictionary))
                    {
                        CharacterStatModel thisStat = new CharacterStatModel
                        {
                            S1 = StringConstants.LevelNumberString[thisLevel],
                            S2 = thisLevelAffixDictionary.TryGetValue(Enumeration.Affix.Health, out var value) ? value.ToString(CultureInfo.CurrentCulture) : "0",
                            S3 = thisLevelAffixDictionary.TryGetValue(Enumeration.Affix.Attack, out var value1) ? value1.ToString(CultureInfo.CurrentCulture) : "0",
                            S4 = thisLevelAffixDictionary.TryGetValue(Enumeration.Affix.Defense, out var value2) ? value2.ToString(CultureInfo.CurrentCulture) : "0"
                        };
                        if (thisLevelAffixDictionary.TryGetValue(Enumeration.Affix.CriticalRate, out var value3))
                        {
                            thisStat.S5 = value3.ToString(CultureInfo.CurrentCulture) + "%";
                        }
                        else
                        {
                            thisStat.S5 = "0%";
                        }

                        if (thisLevelAffixDictionary.TryGetValue(Enumeration.Affix.CriticalDamage, out var value4))
                        {
                            thisStat.S6 = value4.ToString(CultureInfo.CurrentCulture) + "%";
                        }
                        else
                        {
                            thisStat.S6 = "0%";
                        }

                        foreach (Enumeration.Affix a in thisLevelAffixDictionary.Keys)
                        {
                            if (a != Enumeration.Affix.Health && a != Enumeration.Affix.Attack && a != Enumeration.Affix.Defense && a != Enumeration.Affix.CriticalRate && a != Enumeration.Affix.CriticalDamage)
                            {
                                string thisString = thisLevelAffixDictionary[a].ToString(CultureInfo.CurrentCulture);
                                if (SequenceConstants.AffixPercentageSymbolList.Contains(a))
                                {
                                    thisString += "%";
                                }

                                thisStat.S7 = thisString;
                            }
                        }

                        thisDatabase1CharacterModel.FullLevelStatTable.Add(thisStat);
                        if (SequenceConstants.ImportantLevels.Contains(thisLevel))
                        {
                            thisDatabase1CharacterModel.SimpleLevelStatTable.Add(thisStat);
                        }
                    }
                }

                AllCharacterList.Add(thisDatabase1CharacterModel);
            }

            _selectedCharacter = AllCharacterList[0];
            ApplyFilters();
        }

        private bool CharacterFilter(object item)
        {
            if (item is Database1CharacterModel c)
            {
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

            return false;
        }

        private void ApplyFilters()
        {
            CharacterView = AllCharacterList.Where(CharacterFilter).ToList();
            if (!CharacterView.Contains(SelectedCharacter))
            {
                SelectedCharacter = CharacterView.FirstOrDefault()!;
            }
        }

        partial void OnIsShowMoreNumbersChanged(bool value)
        {
            IsShowLessNumbers = !IsShowMoreNumbers;
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
        private void ClickOnCharacter(Database1CharacterModel value)
        {
            SelectedCharacter = value;
        }

        [RelayCommand]
        public void OpenHelpWebPage()
        {
            string url = "https://github.com/TimmyTim-101/HexereiKatepnha/wiki/%E6%95%B0%E6%8D%AE%E5%BA%93-%E2%80%90-%E8%A7%92%E8%89%B2";
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