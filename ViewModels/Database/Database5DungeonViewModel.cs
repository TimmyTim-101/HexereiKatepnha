using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.ModelsForViews.Database;
using HexereiKatepnha.Models.ModelsForViews.Database.SubModels;

namespace HexereiKatepnha.ViewModels.Database
{
    public class Database5DungeonViewModel : ObservableObject
    {
        public ObservableCollection<Database5DungeonModel> List1 { get; } = new();
        public ObservableCollection<Database5DungeonModel> List2 { get; } = new();
        public ObservableCollection<Database5DungeonModel> List3 { get; } = new();
        public ObservableCollection<Database5DungeonModel> List4 { get; } = new();
        public ObservableCollection<Database5DungeonModel> List5 { get; } = new();
        public ObservableCollection<Database5DungeonModel> List6 { get; } = new();
        public ObservableCollection<Database5DungeonModel> List7 { get; } = new();
        public ObservableCollection<Database5DungeonModel> List8 { get; } = new();
        public ObservableCollection<Database5DungeonModel> List9 { get; } = new();

        public Database5DungeonViewModel()
        {
            List<List<DungeonModel>> sourceList =
            [
                AllEntities.AllDungeonLocalSpecialty, AllEntities.AllDungeonLeyLineOutcrop, AllEntities.AllDungeonEasy, AllEntities.AllDungeonElite,
                AllEntities.AllDungeonBoss, AllEntities.AllDungeonArtifact, AllEntities.AllDungeonWeaponAscension, AllEntities.AllDungeonCharacterTalent,
                AllEntities.AllDungeonTrounce
            ];
            List<ObservableCollection<Database5DungeonModel>> destinationList = [List1, List2, List3, List4, List5, List6, List7, List8, List9];
            for (int i = 0; i < sourceList.Count; i++)
            {
                foreach (DungeonModel e in sourceList[i])
                {
                    Database5DungeonModel thisModel = new Database5DungeonModel();
                    thisModel.Name = e.Name;
                    thisModel.ImagePath = e.ImagePath;
                    thisModel.Cost = e.Cost;
                    thisModel.TimeString = SimpleConstants.DungeonTimeString[e.Time];
                    List<DungeonDropItemModel> thisDropItemList = new List<DungeonDropItemModel>();
                    foreach (MaterialPairModel ipm in e.DropMaterialList)
                    {
                        DungeonDropItemModel thisDropItem = new DungeonDropItemModel();
                        MaterialModel? thisMaterial = ipm.MaterialModel;
                        thisDropItem.MaterialName = thisMaterial!.Name;
                        thisDropItem.MaterialImagePath = thisMaterial.ImagePath;
                        thisDropItem.MaterialStarImagePath = SimpleConstants.StarBackgroundImagePath[thisMaterial.Star];
                        thisDropItem.DropNum = ipm.DropNum;
                        thisDropItemList.Add(thisDropItem);
                    }

                    thisModel.DropItemList = thisDropItemList;
                    destinationList[i].Add(thisModel);
                }
            }
        }
    }
}