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
        public ObservableCollection<Database4MaterialModel> MaterialList1 { get; } = new();
        public ObservableCollection<Database4MaterialModel> MaterialList2 { get; } = new();
        public ObservableCollection<Database4MaterialModel> MaterialList3 { get; } = new();
        public ObservableCollection<Database4MaterialModel> MaterialList4 { get; } = new();
        public ObservableCollection<Database4MaterialModel> MaterialList5 { get; } = new();
        public ObservableCollection<Database4MaterialModel> MaterialList6 { get; } = new();
        public ObservableCollection<Database4MaterialModel> MaterialList7 { get; } = new();

        public Database4MaterialViewModel()
        {
            List<List<MaterialModel>> sourceList =
            [
                AllEntities.AllMaterialMora, AllEntities.AllMaterialCharacterExp, AllEntities.AllMaterialWeaponExp, AllEntities.AllMaterialCharacterWeaponEnhancement1,
                AllEntities.AllMaterialCharacterWeaponEnhancement2, AllEntities.AllMaterialCharacterLevelUp1, AllEntities.AllMaterialCharacterLevelUp2, AllEntities.AllMaterialCharacterAscension,
                AllEntities.AllMaterialCharacterTalent, AllEntities.AllMaterialWeaponAscension, AllEntities.AllMaterialLocalSpecialty
            ];
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
                    switch (e.MaterialType)
                    {
                        case Enumeration.MaterialType.Mora: MaterialList1.Add(thisModel); break;
                        case Enumeration.MaterialType.CharacterExp: MaterialList1.Add(thisModel); break;
                        case Enumeration.MaterialType.CharacterWeaponEnhancement1: MaterialList2.Add(thisModel); break;
                        case Enumeration.MaterialType.CharacterWeaponEnhancement2: MaterialList2.Add(thisModel); break;
                        case Enumeration.MaterialType.CharacterLevelUp1: MaterialList3.Add(thisModel); break;
                        case Enumeration.MaterialType.CharacterLevelUp2: MaterialList3.Add(thisModel); break;
                        case Enumeration.MaterialType.CharacterAscension: MaterialList4.Add(thisModel); break;
                        case Enumeration.MaterialType.CharacterTalent: MaterialList5.Add(thisModel); break;
                        case Enumeration.MaterialType.WeaponAscension: MaterialList6.Add(thisModel); break;
                        case Enumeration.MaterialType.LocalSpecialty: MaterialList7.Add(thisModel); break;
                        case Enumeration.MaterialType.WeaponExp: MaterialList1.Add(thisModel); break;
                    }
                }
            }
        }
    }
}