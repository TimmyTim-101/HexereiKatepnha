using System.Collections.ObjectModel;
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
        public ObservableCollection<Backpack4MaterialModel> MaterialList1 { get; } = new();
        public ObservableCollection<Backpack4MaterialModel> MaterialList2 { get; } = new();
        public ObservableCollection<Backpack4MaterialModel> MaterialList3 { get; } = new();
        public ObservableCollection<Backpack4MaterialModel> MaterialList4 { get; } = new();
        public ObservableCollection<Backpack4MaterialModel> MaterialList5 { get; } = new();
        public ObservableCollection<Backpack4MaterialModel> MaterialList6 { get; } = new();
        public ObservableCollection<Backpack4MaterialModel> MaterialList7 { get; } = new();

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
                        case Enumeration.MaterialType.Mora: MaterialList1.Add(thisBackpack4MaterialModel); break;
                        case Enumeration.MaterialType.CharacterExp: MaterialList1.Add(thisBackpack4MaterialModel); break;
                        case Enumeration.MaterialType.CharacterWeaponEnhancement1: MaterialList2.Add(thisBackpack4MaterialModel); break;
                        case Enumeration.MaterialType.CharacterWeaponEnhancement2: MaterialList2.Add(thisBackpack4MaterialModel); break;
                        case Enumeration.MaterialType.CharacterLevelUp1: MaterialList3.Add(thisBackpack4MaterialModel); break;
                        case Enumeration.MaterialType.CharacterLevelUp2: MaterialList3.Add(thisBackpack4MaterialModel); break;
                        case Enumeration.MaterialType.CharacterAscension: MaterialList4.Add(thisBackpack4MaterialModel); break;
                        case Enumeration.MaterialType.CharacterTalent: MaterialList5.Add(thisBackpack4MaterialModel); break;
                        case Enumeration.MaterialType.WeaponAscension: MaterialList6.Add(thisBackpack4MaterialModel); break;
                        case Enumeration.MaterialType.LocalSpecialty: MaterialList7.Add(thisBackpack4MaterialModel); break;
                        case Enumeration.MaterialType.WeaponExp: MaterialList1.Add(thisBackpack4MaterialModel); break;
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
                List<ObservableCollection<Backpack4MaterialModel>> allLists = [MaterialList2, MaterialList4, MaterialList5, MaterialList6];
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