using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.ModelsForViews.Database;

namespace HexereiKatepnha.ViewModels.Database
{
    public partial class Database5DungeonViewModel : ObservableObject
    {
        public List<Database5DungeonModel> AllDungeonList { get; set; } = [];

        public Database5DungeonViewModel()
        {
            List<List<DungeonModel>> sourceList =
            [
                AllEntities.AllDungeonLocalSpecialty, AllEntities.AllDungeonLeyLineOutcrop, AllEntities.AllDungeonEasy, AllEntities.AllDungeonElite,
                AllEntities.AllDungeonBoss, AllEntities.AllDungeonArtifact, AllEntities.AllDungeonWeaponAscension, AllEntities.AllDungeonCharacterTalent,
                AllEntities.AllDungeonTrounce
            ];
            foreach (List<DungeonModel> l in sourceList)
            {
                foreach (DungeonModel e in l)
                {
                    Database5DungeonModel thisModel = new Database5DungeonModel
                    {
                        Name = e.Name,
                        ImagePath = e.ImagePath,
                        Cost = e.Cost,
                        TimeString = StringConstants.DungeonTimeString[e.Time],
                        IsTimeLimit = e.Time != 0
                    };
                    List<DungeonDropItemModel> thisDropItemList = new List<DungeonDropItemModel>();
                    List<MaterialPairModel> tempList = new(e.DropMaterialList);
                    tempList.Sort((a, b) =>
                    {
                        if (a.MaterialModel!.EntityType == Enumeration.EntityType.Material && b.MaterialModel!.EntityType == Enumeration.EntityType.Material)
                        {
                            MaterialModel modelA = (MaterialModel)a.MaterialModel;
                            MaterialModel modelB = (MaterialModel)b.MaterialModel;
                            if (modelA.MaterialType == Enumeration.MaterialType.CharacterAscension && modelB.MaterialType == Enumeration.MaterialType.CharacterAscension)
                            {
                                int starA = modelA.Star;
                                int starB = modelB.Star;
                                if (starA != starB) return starB.CompareTo(starA);
                            }
                        }

                        return e.DropMaterialList.IndexOf(a).CompareTo(e.DropMaterialList.IndexOf(b));
                    });
                    foreach (MaterialPairModel ipm in tempList)
                    {
                        DungeonDropItemModel thisDropItem = new DungeonDropItemModel();
                        BaseEntityModel? thisMaterial = ipm.MaterialModel;
                        if (thisMaterial!.GetType() == typeof(ArtifactSetModel))
                        {
                            ArtifactSetModel asm = (ArtifactSetModel)thisMaterial;
                            for (int j = 1; j <= 5; j++)
                            {
                                if (asm.PositionImagePathDict.TryGetValue(j, out var thisImagePath))
                                {
                                    thisDropItem.MaterialImagePath = thisImagePath;
                                    thisDropItem.IsShow = false;
                                    thisModel.DropHeight = 110;
                                    break;
                                }
                            }

                            for (int j = 5; j >= 1; j--)
                            {
                                if (asm.RarityList.Contains(j))
                                {
                                    thisDropItem.MaterialStarImagePath = StringConstants.StarBackgroundImagePath[j];
                                    thisDropItem.IsShow = false;
                                    thisModel.DropHeight = 110;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            thisDropItem.MaterialImagePath = thisMaterial.ImagePath;
                            thisDropItem.MaterialStarImagePath = StringConstants.StarBackgroundImagePath[thisMaterial.Star];
                            if (e.Cost == 0)
                            {
                                thisDropItem.IsShow = false;
                                thisModel.DropHeight = 110;
                            }
                        }

                        thisDropItem.MaterialName = thisMaterial.Name;
                        thisDropItem.DropNum = ipm.DropNum;
                        thisDropItemList.Add(thisDropItem);
                    }

                    thisModel.DropItemList = thisDropItemList;
                    AllDungeonList.Add(thisModel);
                }
            }
        }

        [RelayCommand]
        public void OpenHelpWebPage()
        {
            string url = "https://github.com/TimmyTim-101/HexereiKatepnha/wiki/%E6%95%B0%E6%8D%AE%E5%BA%93-%E2%80%90-%E7%A7%98%E5%A2%83-&-%E9%AD%94%E7%89%A9";
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