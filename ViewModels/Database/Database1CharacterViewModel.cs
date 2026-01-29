using System.Collections;
using System.Collections.ObjectModel;
using System.Globalization;
using CommunityToolkit.Mvvm.ComponentModel;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.ModelsForViews.Database;
using HexereiKatepnha.Models.ModelsForViews.Database.SubModels;

namespace HexereiKatepnha.ViewModels.Database
{
    public partial class Database1CharacterViewModel : ObservableObject
    {
        [ObservableProperty] private bool _isShowMoreNumbers = false;
        [ObservableProperty] private bool _isShowLessNumbers = true;
        public ObservableCollection<Database1CharacterModel> AllCharacterList { get; } = new();

        public Database1CharacterViewModel()
        {
            foreach (CharacterModel e in AllEntities.AllCharacter)
            {
                Database1CharacterModel thisDatabase1CharacterModel = new Database1CharacterModel();
                thisDatabase1CharacterModel.ImagePath = e.ImagePath;
                thisDatabase1CharacterModel.ElementImagePath = StringConstants.ElementTypeImagePath[e.ElementType];
                thisDatabase1CharacterModel.BackgroundImagePath = StringConstants.StarBackgroundImagePath[e.Star];
                thisDatabase1CharacterModel.Name = e.Name;
                thisDatabase1CharacterModel.Vid = e.Vid;
                thisDatabase1CharacterModel.StarImagePath = StringConstants.StarImagePath[e.Star];
                thisDatabase1CharacterModel.BirthdayString = "生日：" + e.BirthMonth + " / " + e.BirthDay;
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
                    .DistinctBy(m => m.Rid)
                    .OrderBy(m => m.Rid);
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
                        List<string> thisStatList = [StringConstants.LevelString[thisLevel]];
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
        }

        partial void OnIsShowMoreNumbersChanged(bool value)
        {
            IsShowLessNumbers = !IsShowMoreNumbers;
        }
    }
}