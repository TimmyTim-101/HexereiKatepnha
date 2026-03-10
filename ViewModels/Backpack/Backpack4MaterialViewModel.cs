using System.Collections.ObjectModel;
using System.Configuration;
using System.Windows.Documents;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.ModelsForViews.Backpack;

namespace HexereiKatepnha.ViewModels.Backpack
{
    public partial class Backpack4MaterialViewModel : ObservableObject
    {
        public ObservableCollection<Backpack4MaterialModel> AllEssentialMaterial { get; } = new();
        public ObservableCollection<Backpack4MaterialModel> AllMaterialCharacterWeaponEnhancement { get; } = new();
        public ObservableCollection<Backpack4MaterialModel> AllMaterialCharacterLevelUp { get; } = new();
        public ObservableCollection<Backpack4MaterialModel> AllMaterialCharacterAscension { get; } = new();
        public ObservableCollection<Backpack4MaterialModel> AllMaterialCharacterTalent { get; } = new();
        public ObservableCollection<Backpack4MaterialModel> AllMaterialWeaponAscension { get; } = new();
        public ObservableCollection<Backpack4MaterialModel> AllMaterialLocalSpecialty { get; } = new();

        public Backpack4MaterialViewModel()
        {
            List<List<MaterialModel>> allLists =
            [
                AllEntities.AllMaterialMora, AllEntities.AllMaterialCharacterExp, AllEntities.AllMaterialCharacterWeaponEnhancement1, AllEntities.AllMaterialCharacterWeaponEnhancement2, AllEntities.AllMaterialCharacterLevelUp1,
                AllEntities.AllMaterialCharacterLevelUp2, AllEntities.AllMaterialCharacterAscension, AllEntities.AllMaterialCharacterTalent, AllEntities.AllMaterialWeaponAscension, AllEntities.AllMaterialLocalSpecialty,
                AllEntities.AllMaterialWeaponExp,
            ];
            foreach (List<MaterialModel> d in allLists)
            {
                foreach (MaterialModel e in d)
                {
                    Backpack4MaterialModel thisBackpack4MaterialModel = new Backpack4MaterialModel();
                    thisBackpack4MaterialModel.ImagePath = e.ImagePath;
                    thisBackpack4MaterialModel.BackgroundImagePath = StringConstants.StarBackgroundImagePath[e.Star];
                    thisBackpack4MaterialModel.Name = e.Name;
                    thisBackpack4MaterialModel.Rid = e.Rid;
                    thisBackpack4MaterialModel.Number = App.BackpackMaterialConfigManagerInstance!.GetMaterialNumber(e.Rid);

                    switch (e.MaterialType)
                    {
                        case Enumeration.MaterialType.Mora: AllEssentialMaterial.Add(thisBackpack4MaterialModel); break;
                        case Enumeration.MaterialType.CharacterExp: AllEssentialMaterial.Add(thisBackpack4MaterialModel); break;
                        case Enumeration.MaterialType.CharacterWeaponEnhancement1: AllMaterialCharacterWeaponEnhancement.Add(thisBackpack4MaterialModel); break;
                        case Enumeration.MaterialType.CharacterWeaponEnhancement2: AllMaterialCharacterWeaponEnhancement.Add(thisBackpack4MaterialModel); break;
                        case Enumeration.MaterialType.CharacterLevelUp1: AllMaterialCharacterLevelUp.Add(thisBackpack4MaterialModel); break;
                        case Enumeration.MaterialType.CharacterLevelUp2: AllMaterialCharacterLevelUp.Add(thisBackpack4MaterialModel); break;
                        case Enumeration.MaterialType.CharacterAscension: AllMaterialCharacterAscension.Add(thisBackpack4MaterialModel); break;
                        case Enumeration.MaterialType.CharacterTalent: AllMaterialCharacterTalent.Add(thisBackpack4MaterialModel); break;
                        case Enumeration.MaterialType.WeaponAscension: AllMaterialWeaponAscension.Add(thisBackpack4MaterialModel); break;
                        case Enumeration.MaterialType.LocalSpecialty: AllMaterialLocalSpecialty.Add(thisBackpack4MaterialModel); break;
                        case Enumeration.MaterialType.WeaponExp: AllEssentialMaterial.Add(thisBackpack4MaterialModel); break;
                    }
                }
            }
        }

        [RelayCommand]
        private void AddOneMaterial(Backpack4MaterialModel? clickItem)
        {
            if (clickItem != null)
            {
                clickItem.Number += 1;
            }
        }

        [RelayCommand]
        private void MinusOneMaterial(Backpack4MaterialModel? clickItem)
        {
            if (clickItem != null)
            {
                if (clickItem.Number >= 1)
                {
                    clickItem.Number -= 1;
                }
            }
        }

        [RelayCommand]
        private void MergeOneMaterial(Backpack4MaterialModel? clickItem)
        {
            if (clickItem != null)
            {
                int recipeId = AutoCalculateConstants.MaterialMergeRecipe[clickItem.Rid];
                List<ObservableCollection<Backpack4MaterialModel>> allLists = [AllMaterialCharacterWeaponEnhancement, AllMaterialCharacterAscension, AllMaterialCharacterTalent, AllMaterialWeaponAscension,];
                foreach (ObservableCollection<Backpack4MaterialModel> l in allLists)
                {
                    foreach (Backpack4MaterialModel b in l)
                    {
                        if (b.Rid == recipeId)
                        {
                            if (b.Number >= 3)
                            {
                                b.Number -= 3;
                                clickItem.Number += 1;
                            }
                        }
                    }
                }
            }
        }
    }
}