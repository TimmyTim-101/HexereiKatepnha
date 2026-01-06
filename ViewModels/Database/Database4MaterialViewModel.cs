using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.ModelsForViews.Database;

namespace HexereiKatepnha.ViewModels.Database
{
    public class Database4MaterialViewModel : ObservableObject
    {
        public ObservableCollection<Database4MaterialModel> List1 { get; } = new();
        public ObservableCollection<Database4MaterialModel> List2 { get; } = new();
        public ObservableCollection<Database4MaterialModel> List3 { get; } = new();
        public ObservableCollection<Database4MaterialModel> List4 { get; } = new();
        public ObservableCollection<Database4MaterialModel> List5 { get; } = new();
        public ObservableCollection<Database4MaterialModel> List6 { get; } = new();
        public ObservableCollection<Database4MaterialModel> List7 { get; } = new();

        public Database4MaterialViewModel()
        {
            List<List<MaterialModel>> sourceList =
            [
                AllEntities.AllMaterialMora, AllEntities.AllMaterialCharacterExp, AllEntities.AllMaterialWeaponExp, AllEntities.AllMaterialCharacterWeaponEnhancement1,
                AllEntities.AllMaterialCharacterWeaponEnhancement2, AllEntities.AllMaterialCharacterLevelUp1, AllEntities.AllMaterialCharacterLevelUp2, AllEntities.AllMaterialCharacterAscension,
                AllEntities.AllMaterialCharacterTalent, AllEntities.AllMaterialWeaponAscension, AllEntities.AllMaterialLocalSpecialty
            ];
            List<ObservableCollection<Database4MaterialModel>> destinationList = [List1, List1, List1, List2, List2, List3, List3, List4, List5, List6, List7];
            for (int i = 0; i < sourceList.Count; i++)
            {
                foreach (MaterialModel e in sourceList[i])
                {
                    Database4MaterialModel thisModel = new Database4MaterialModel();
                    thisModel.Vid = e.Vid;
                    thisModel.Name = e.Name;
                    thisModel.ImagePath = e.ImagePath;
                    thisModel.BackgroundImagePath = StringConstants.StarBackgroundImagePath[e.Star];
                    thisModel.StarImagePath = StringConstants.StarImagePath[e.Star];
                    destinationList[i].Add(thisModel);
                }
            }
        }
    }
}