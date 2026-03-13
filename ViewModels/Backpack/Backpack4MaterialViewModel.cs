using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Windows.Data;
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
        public ObservableCollection<Backpack4MaterialModel> AllMaterials { get; set; } = new();
        public ICollectionView GroupedMaterialView { get; }

        public Backpack4MaterialViewModel()
        {
            GroupedMaterialView = CollectionViewSource.GetDefaultView(AllMaterials);
            GroupedMaterialView.GroupDescriptions.Add(new PropertyGroupDescription("CategoryName"));
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
                        case Enumeration.MaterialType.Mora: thisBackpack4MaterialModel.CategoryName = "基础培养素材"; break;
                        case Enumeration.MaterialType.CharacterExp: thisBackpack4MaterialModel.CategoryName = "基础培养素材"; break;
                        case Enumeration.MaterialType.CharacterWeaponEnhancement1: thisBackpack4MaterialModel.CategoryName = "角色与武器培养素材"; break;
                        case Enumeration.MaterialType.CharacterWeaponEnhancement2: thisBackpack4MaterialModel.CategoryName = "角色与武器培养素材"; break;
                        case Enumeration.MaterialType.CharacterLevelUp1: thisBackpack4MaterialModel.CategoryName = "角色培养素材"; break;
                        case Enumeration.MaterialType.CharacterLevelUp2: thisBackpack4MaterialModel.CategoryName = "角色培养素材"; break;
                        case Enumeration.MaterialType.CharacterAscension: thisBackpack4MaterialModel.CategoryName = "角色突破素材"; break;
                        case Enumeration.MaterialType.CharacterTalent: thisBackpack4MaterialModel.CategoryName = "角色天赋素材"; break;
                        case Enumeration.MaterialType.WeaponAscension: thisBackpack4MaterialModel.CategoryName = "武器突破素材"; break;
                        case Enumeration.MaterialType.LocalSpecialty: thisBackpack4MaterialModel.CategoryName = "地方特产"; break;
                        case Enumeration.MaterialType.WeaponExp: thisBackpack4MaterialModel.CategoryName = "基础培养素材"; break;
                    }

                    AllMaterials.Add(thisBackpack4MaterialModel);
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
                foreach (Backpack4MaterialModel b in AllMaterials)
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