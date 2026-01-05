using System.Collections.ObjectModel;
using System.Globalization;
using System.Runtime.Intrinsics.X86;
using CommunityToolkit.Mvvm.ComponentModel;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.ModelsForViews.Database;
using HexereiKatepnha.Models.ModelsForViews.Database.SubModels;

namespace HexereiKatepnha.ViewModels.Database
{
    public partial class Database2WeaponViewModel : ObservableObject
    {
        [ObservableProperty] private bool _isShowProgression = false;
        [ObservableProperty] private bool _isShowMoreNumbers = false;
        [ObservableProperty] private bool _isShowLessNumbers = true;
        [ObservableProperty] private bool _isShowAwakenImage = false;
        [ObservableProperty] private bool _isShowOriginalImage = true;
        public ObservableCollection<Database2WeaponModel> AllSwordList { get; } = new();
        public ObservableCollection<Database2WeaponModel> AllClaymoreList { get; } = new();
        public ObservableCollection<Database2WeaponModel> AllPoleList { get; } = new();
        public ObservableCollection<Database2WeaponModel> AllCatalystList { get; } = new();
        public ObservableCollection<Database2WeaponModel> AllBowList { get; } = new();

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
                thisDatabase2WeaponModel.StarImagePath = StringConstants.StarImagePath[e.Star];
                thisDatabase2WeaponModel.WeaponTypeName = StringConstants.WeaponTypeString[e.WeaponType];
                thisDatabase2WeaponModel.WeaponTypeImagePath = StringConstants.WeaponTypeImagePath[e.WeaponType];
                thisDatabase2WeaponModel.SubAffixName = StringConstants.AffixString[e.SubAffix];
                thisDatabase2WeaponModel.NeedMaterialList = [];
                IEnumerable<MaterialModel> allMaterials = e.LevelUpMaterials.Values.SelectMany(list => list).Select(pair => (MaterialModel)pair.MaterialModel!).Where(m => true);
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
                thisDatabase2WeaponModel.SimpleLevelStatTable.Add(new WeaponLevelStatModel() { s1 = "等级", s2 = "基础攻击力", s3 = StringConstants.AffixString[e.SubAffix] });
                thisDatabase2WeaponModel.FullLevelStatTable.Clear();
                thisDatabase2WeaponModel.FullLevelStatTable.Add(new WeaponLevelStatModel() { s1 = "等级", s2 = "基础攻击力", s3 = StringConstants.AffixString[e.SubAffix] });
                for (int i = 0; i < SequenceConstants.AllLevels.Count; i++)
                {
                    Enumeration.Level thisLevel = SequenceConstants.AllLevels[i];
                    if (e.MainAffixNumberDictionary.ContainsKey(thisLevel))
                    {
                        WeaponLevelStatModel thisWeaponLevelStatModel = new WeaponLevelStatModel()
                        {
                            s1 = StringConstants.LevelString[thisLevel],
                            s2 = e.MainAffixNumberDictionary[thisLevel].ToString(CultureInfo.InvariantCulture),
                            s3 = e.SubAffixNumberDictionary[thisLevel].ToString(CultureInfo.InvariantCulture),
                        };
                        if (SequenceConstants.AffixPercentageSymbolList.Contains(e.SubAffix))
                        {
                            thisWeaponLevelStatModel.s3 += "%";
                        }

                        if (thisWeaponLevelStatModel.s3 == "0") thisWeaponLevelStatModel.s3 = "";
                        thisDatabase2WeaponModel.FullLevelStatTable.Add(thisWeaponLevelStatModel);
                        if (SequenceConstants.ImportantLevels.Contains(thisLevel))
                        {
                            thisDatabase2WeaponModel.SimpleLevelStatTable.Add(thisWeaponLevelStatModel);
                        }
                    }
                }

                switch (e.WeaponType)
                {
                    case Enumeration.WeaponType.Sword: AllSwordList.Add(thisDatabase2WeaponModel); break;
                    case Enumeration.WeaponType.Claymore: AllClaymoreList.Add(thisDatabase2WeaponModel); break;
                    case Enumeration.WeaponType.Pole: AllPoleList.Add(thisDatabase2WeaponModel); break;
                    case Enumeration.WeaponType.Catalyst: AllCatalystList.Add(thisDatabase2WeaponModel); break;
                    case Enumeration.WeaponType.Bow: AllBowList.Add(thisDatabase2WeaponModel); break;
                }
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
    }
}