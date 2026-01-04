using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.ModelsForViews.Database;
using HexereiKatepnha.Models.ModelsForViews.Database.SubModels;

namespace HexereiKatepnha.ViewModels.Database
{
    public partial class Database2WeaponViewModel : ObservableObject
    {
        [ObservableProperty] private bool _isShowProgression = true;
        [ObservableProperty] private bool _isShowMoreNumbers = true;
        [ObservableProperty] private bool _isShowLessNumbers = false;
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
                thisDatabase2WeaponModel.BackgroundImagePath = SimpleConstants.StarBackgroundImagePath[e.Star];
                thisDatabase2WeaponModel.StarImagePath = SimpleConstants.StarImagePath[e.Star];
                thisDatabase2WeaponModel.WeaponTypeName = SimpleConstants.WeaponTypeString[e.WeaponType];
                thisDatabase2WeaponModel.WeaponTypeImagePath = SimpleConstants.WeaponTypeImagePath[e.WeaponType];
                thisDatabase2WeaponModel.SubAffixName = SimpleConstants.AffixString[e.SubAffix];
                thisDatabase2WeaponModel.NeedMaterialList = [];
                // todo: 去重 + 排序
                foreach (List<MaterialPairModel> l in e.LevelUpMaterials.Values)
                {
                    foreach (MaterialPairModel p in l)
                    {
                        MaterialModel thisMaterial = (MaterialModel)p.MaterialModel!;
                        DungeonDropItemModel thisDropModel = new DungeonDropItemModel();
                        thisDropModel.MaterialName = thisMaterial.Name;
                        thisDropModel.MaterialImagePath = thisMaterial.ImagePath;
                        thisDropModel.MaterialStarImagePath = SimpleConstants.StarBackgroundImagePath[thisMaterial.Star];
                        thisDatabase2WeaponModel.NeedMaterialList.Add(thisDropModel);
                    }
                }

                thisDatabase2WeaponModel.Progression1 = "·" + e.Progression[1];
                thisDatabase2WeaponModel.Progression2 = "·" + e.Progression[2];
                thisDatabase2WeaponModel.Progression3 = "·" + e.Progression[3];
                thisDatabase2WeaponModel.Progression4 = "·" + e.Progression[4];
                thisDatabase2WeaponModel.Progression5 = "·" + e.Progression[5];

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
    }
}