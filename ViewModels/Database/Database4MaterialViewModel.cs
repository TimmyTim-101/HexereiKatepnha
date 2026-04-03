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
        public ObservableCollection<Database4MaterialGroupModel> AllMaterialGroupList { get; set; } = [];

        public Database4MaterialViewModel()
        {
            List<List<MaterialModel>> sourceList =
            [
                AllEntities.AllMaterialMora, AllEntities.AllMaterialCharacterExp, AllEntities.AllMaterialWeaponExp, AllEntities.AllMaterialCharacterWeaponEnhancement1,
                AllEntities.AllMaterialCharacterWeaponEnhancement2, AllEntities.AllMaterialCharacterLevelUp1, AllEntities.AllMaterialCharacterLevelUp2, AllEntities.AllMaterialCharacterAscension,
                AllEntities.AllMaterialCharacterTalent, AllEntities.AllMaterialWeaponAscension, AllEntities.AllMaterialLocalSpecialty
            ];
            foreach (List<MaterialModel> l in sourceList)
            {
                foreach (MaterialModel e in l)
                {
                    Database4MaterialModel thisModel = new Database4MaterialModel
                    {
                        Vid = e.Vid,
                        Name = e.Name,
                        ImagePath = e.ImagePath,
                        BackgroundImagePath = StringConstants.StarBackgroundImagePath[e.Star],
                        StarImagePath = StringConstants.StarImagePath[e.Star]
                    };
                    string thisCategoryName = "";
                    switch (e.MaterialType)
                    {
                        case Enumeration.MaterialType.Mora: thisCategoryName = "基础培养素材"; break;
                        case Enumeration.MaterialType.CharacterExp: thisCategoryName = "基础培养素材"; break;
                        case Enumeration.MaterialType.CharacterWeaponEnhancement1: thisCategoryName = "角色与武器培养素材"; break;
                        case Enumeration.MaterialType.CharacterWeaponEnhancement2: thisCategoryName = "角色与武器培养素材"; break;
                        case Enumeration.MaterialType.CharacterLevelUp1: thisCategoryName = "角色培养素材"; break;
                        case Enumeration.MaterialType.CharacterLevelUp2: thisCategoryName = "角色培养素材"; break;
                        case Enumeration.MaterialType.CharacterAscension: thisCategoryName = "角色突破素材"; break;
                        case Enumeration.MaterialType.CharacterTalent: thisCategoryName = "角色天赋素材"; break;
                        case Enumeration.MaterialType.WeaponAscension: thisCategoryName = "武器突破素材"; break;
                        case Enumeration.MaterialType.LocalSpecialty: thisCategoryName = "地方特产"; break;
                        case Enumeration.MaterialType.WeaponExp: thisCategoryName = "基础培养素材"; break;
                    }

                    bool isNew = true;
                    foreach (Database4MaterialGroupModel thisGroup in AllMaterialGroupList)
                    {
                        if (thisGroup.CategoryName == thisCategoryName)
                        {
                            thisGroup.ItemList.Add(thisModel);
                            isNew = false;
                        }
                    }

                    if (isNew)
                    {
                        Database4MaterialGroupModel thisGroup = new Database4MaterialGroupModel
                        {
                            CategoryName = thisCategoryName
                        };
                        thisGroup.ItemList.Add(thisModel);
                        AllMaterialGroupList.Add(thisGroup);
                    }
                }
            }
        }
    }
}