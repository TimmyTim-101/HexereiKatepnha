using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using CommunityToolkit.Mvvm.ComponentModel;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.ModelsForViews.Database;

namespace HexereiKatepnha.ViewModels.Database
{
    public class Database4MaterialViewModel : ObservableObject
    {
        public ObservableCollection<Database4MaterialModel> AllMaterials { get; } = new();
        public ICollectionView GroupedMaterialView { get; }

        public Database4MaterialViewModel()
        {
            GroupedMaterialView = CollectionViewSource.GetDefaultView(AllMaterials);
            GroupedMaterialView.GroupDescriptions.Add(new PropertyGroupDescription("CategoryName"));
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
                        case Enumeration.MaterialType.Mora: thisModel.CategoryName = "基础培养素材"; break;
                        case Enumeration.MaterialType.CharacterExp: thisModel.CategoryName = "基础培养素材"; break;
                        case Enumeration.MaterialType.CharacterWeaponEnhancement1: thisModel.CategoryName = "角色与武器培养素材"; break;
                        case Enumeration.MaterialType.CharacterWeaponEnhancement2: thisModel.CategoryName = "角色与武器培养素材"; break;
                        case Enumeration.MaterialType.CharacterLevelUp1: thisModel.CategoryName = "角色培养素材"; break;
                        case Enumeration.MaterialType.CharacterLevelUp2: thisModel.CategoryName = "角色培养素材"; break;
                        case Enumeration.MaterialType.CharacterAscension: thisModel.CategoryName = "角色突破素材"; break;
                        case Enumeration.MaterialType.CharacterTalent: thisModel.CategoryName = "角色天赋素材"; break;
                        case Enumeration.MaterialType.WeaponAscension: thisModel.CategoryName = "武器突破素材"; break;
                        case Enumeration.MaterialType.LocalSpecialty: thisModel.CategoryName = "地方特产"; break;
                        case Enumeration.MaterialType.WeaponExp: thisModel.CategoryName = "基础培养素材"; break;
                    }

                    AllMaterials.Add(thisModel);
                }
            }
        }
    }
}