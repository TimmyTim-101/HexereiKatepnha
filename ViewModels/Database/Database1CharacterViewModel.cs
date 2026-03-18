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
    public partial class Database1CharacterViewModel : ObservableObject
    {
        [ObservableProperty] private bool _isShowMoreNumbers;
        [ObservableProperty] private bool _isShowLessNumbers = true;
        [ObservableProperty] private int _elementFilter;
        [ObservableProperty] private int _weaponFilter;
        [ObservableProperty] private int _starFilter;
        public ObservableCollection<Database1CharacterModel> AllCharacterList { get; } = new();
        [ObservableProperty] private Database1CharacterModel _selectedCharacter;
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

        public Database1CharacterViewModel()
        {
            foreach (CharacterModel e in AllEntities.AllCharacter)
            {
                Database1CharacterModel thisDatabase1CharacterModel = new Database1CharacterModel();
                thisDatabase1CharacterModel.ImagePath = e.ImagePath;
                thisDatabase1CharacterModel.ElementType = e.ElementType;
                thisDatabase1CharacterModel.ElementImagePath = StringConstants.ElementTypeImagePath[e.ElementType];
                thisDatabase1CharacterModel.BackgroundImagePath = StringConstants.StarBackgroundImagePath[e.Star];
                thisDatabase1CharacterModel.Name = e.Name;
                thisDatabase1CharacterModel.Vid = e.Vid;
                thisDatabase1CharacterModel.Star = e.Star;
                thisDatabase1CharacterModel.StarImagePath = StringConstants.StarImagePath[e.Star];
                thisDatabase1CharacterModel.BirthdayString = "生日：" + e.BirthMonth + " / " + e.BirthDay;
                thisDatabase1CharacterModel.WeaponType = e.WeaponType;
                thisDatabase1CharacterModel.WeaponTypeName = StringConstants.WeaponTypeString[e.WeaponType];
                thisDatabase1CharacterModel.WeaponTypeImagePath = StringConstants.WeaponTypeImagePath[e.WeaponType];
                thisDatabase1CharacterModel.NeedMaterialList = [];
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
                    DungeonDropItemModel thisDropModel = new DungeonDropItemModel();
                    thisDropModel.MaterialName = p.Name;
                    thisDropModel.MaterialImagePath = p.ImagePath;
                    thisDropModel.MaterialStarImagePath = StringConstants.StarBackgroundImagePath[p.Star];
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

                thisDatabase1CharacterModel.Ascension1ImagePath = e.Ascension[1].ImagePath;
                thisDatabase1CharacterModel.Ascension1Description = e.Ascension[1].Description;
                thisDatabase1CharacterModel.Ascension2ImagePath = e.Ascension[2].ImagePath;
                thisDatabase1CharacterModel.Ascension2Description = e.Ascension[2].Description;
                thisDatabase1CharacterModel.Ascension3ImagePath = e.Ascension[3].ImagePath;
                thisDatabase1CharacterModel.Ascension3Description = e.Ascension[3].Description;
                thisDatabase1CharacterModel.Ascension4ImagePath = e.Ascension[4].ImagePath;
                thisDatabase1CharacterModel.Ascension4Description = e.Ascension[4].Description;
                thisDatabase1CharacterModel.Ascension5ImagePath = e.Ascension[5].ImagePath;
                thisDatabase1CharacterModel.Ascension5Description = e.Ascension[5].Description;
                thisDatabase1CharacterModel.Ascension6ImagePath = e.Ascension[6].ImagePath;
                thisDatabase1CharacterModel.Ascension6Description = e.Ascension[6].Description;

                List<string> tableBeginning = ["等级", "生命值", "攻击力", "防御力", "暴击率", "暴击伤害"];
                foreach (Enumeration.Affix a in e.AffixDictionary[Enumeration.Level.L1].Keys)
                {
                    if (a != Enumeration.Affix.Health && a != Enumeration.Affix.Attack && a != Enumeration.Affix.Defense && a != Enumeration.Affix.CriticalRate && a != Enumeration.Affix.CriticalDamage)
                    {
                        tableBeginning.Add(StringConstants.AffixString[a]);
                    }
                }

                thisDatabase1CharacterModel.SimpleLevelStatTable.Add(tableBeginning);
                thisDatabase1CharacterModel.FullLevelStatTable.Add(tableBeginning);
                for (int i = 0; i < SequenceConstants.AllLevels.Count; i++)
                {
                    Enumeration.Level thisLevel = SequenceConstants.AllLevels[i];
                    if (e.AffixDictionary.ContainsKey(thisLevel))
                    {
                        Dictionary<Enumeration.Affix, double> thisLevelAffixDictionary = e.AffixDictionary[thisLevel];
                        List<string> thisStatList = [StringConstants.LevelNumberString[thisLevel]];
                        if (thisLevelAffixDictionary.ContainsKey(Enumeration.Affix.Health))
                        {
                            thisStatList.Add(thisLevelAffixDictionary[Enumeration.Affix.Health].ToString(CultureInfo.CurrentCulture));
                        }
                        else
                        {
                            thisStatList.Add("0");
                        }

                        if (thisLevelAffixDictionary.ContainsKey(Enumeration.Affix.Attack))
                        {
                            thisStatList.Add(thisLevelAffixDictionary[Enumeration.Affix.Attack].ToString(CultureInfo.CurrentCulture));
                        }
                        else
                        {
                            thisStatList.Add("0");
                        }

                        if (thisLevelAffixDictionary.ContainsKey(Enumeration.Affix.Defense))
                        {
                            thisStatList.Add(thisLevelAffixDictionary[Enumeration.Affix.Defense].ToString(CultureInfo.CurrentCulture));
                        }
                        else
                        {
                            thisStatList.Add("0");
                        }

                        if (thisLevelAffixDictionary.ContainsKey(Enumeration.Affix.CriticalRate))
                        {
                            thisStatList.Add(thisLevelAffixDictionary[Enumeration.Affix.CriticalRate].ToString(CultureInfo.CurrentCulture) + "%");
                        }
                        else
                        {
                            thisStatList.Add("0%");
                        }

                        if (thisLevelAffixDictionary.ContainsKey(Enumeration.Affix.CriticalDamage))
                        {
                            thisStatList.Add(thisLevelAffixDictionary[Enumeration.Affix.CriticalDamage].ToString(CultureInfo.CurrentCulture) + "%");
                        }
                        else
                        {
                            thisStatList.Add("0%");
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

                                thisStatList.Add(thisString);
                            }
                        }

                        thisDatabase1CharacterModel.FullLevelStatTable.Add(thisStatList);
                        if (SequenceConstants.ImportantLevels.Contains(thisLevel))
                        {
                            thisDatabase1CharacterModel.SimpleLevelStatTable.Add(thisStatList);
                        }
                    }
                }

                AllCharacterList.Add(thisDatabase1CharacterModel);
            }

            _selectedCharacter = AllCharacterList[0];
            CharacterView = CollectionViewSource.GetDefaultView(AllCharacterList);
            CharacterView.Filter = CharacterFilter;
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

        private void UpdateSelection()
        {
            if (!CharacterView.Contains(SelectedCharacter))
            {
                SelectedCharacter = CharacterView.Cast<Database1CharacterModel>().FirstOrDefault()!;
            }
        }

        partial void OnIsShowMoreNumbersChanged(bool value)
        {
            IsShowLessNumbers = !IsShowMoreNumbers;
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
    }
}