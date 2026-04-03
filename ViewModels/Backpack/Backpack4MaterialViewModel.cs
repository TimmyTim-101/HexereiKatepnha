using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.Messages;
using HexereiKatepnha.Models.ModelsForViews.Backpack;
using HexereiKatepnha.Models.ModelsForViews.Calculator;

namespace HexereiKatepnha.ViewModels.Backpack
{
    public partial class Backpack4MaterialViewModel : ObservableObject, IRecipient<GoalSimulatorChangeMessage>
    {
        public ObservableCollection<Backpack4MaterialGroupModel> AllMaterialGroupList { get; } = [];
        private Dictionary<int, Backpack4MaterialModel> MaterialRidMap { get; set; } = new();

        public Backpack4MaterialViewModel()
        {
            foreach (MaterialModel e in AutoCalculateConstants.MaterialMap.Values)
            {
                Backpack4MaterialModel thisBackpack4MaterialModel = new Backpack4MaterialModel
                {
                    ImagePath = e.ImagePath,
                    BackgroundImagePath = StringConstants.StarBackgroundImagePath[e.Star],
                    Name = e.Name,
                    Rid = e.Rid,
                    Number = App.BackpackMaterialConfigManagerInstance!.GetMaterialNumber(e.Rid)
                };
                string thisCategoryName = "";

                switch (e.MaterialType)
                {
                    case Enumeration.MaterialType.Mora: thisCategoryName = "基础培养素材"; break;
                    case Enumeration.MaterialType.CharacterExp: thisCategoryName = "基础培养素材"; break;
                    case Enumeration.MaterialType.CharacterWeaponEnhancement1: thisCategoryName = "角色与武器培养素材"; break;
                    case Enumeration.MaterialType.CharacterWeaponEnhancement2: thisCategoryName = "角色与武器培养素材"; break;
                    case Enumeration.MaterialType.CharacterLevelUp1: thisCategoryName = "角色培养素材-周本掉落"; break;
                    case Enumeration.MaterialType.CharacterLevelUp2: thisCategoryName = "角色培养素材-BOSS掉落"; break;
                    case Enumeration.MaterialType.CharacterAscension: thisCategoryName = "角色突破素材"; break;
                    case Enumeration.MaterialType.CharacterTalent: thisCategoryName = "角色天赋素材"; break;
                    case Enumeration.MaterialType.WeaponAscension: thisCategoryName = "武器突破素材"; break;
                    case Enumeration.MaterialType.LocalSpecialty: thisCategoryName = "地方特产"; break;
                    case Enumeration.MaterialType.WeaponExp: thisCategoryName = "基础培养素材"; break;
                }

                bool isNew = true;
                foreach (Backpack4MaterialGroupModel thisGroup in AllMaterialGroupList)
                {
                    if (thisGroup.CategoryName == thisCategoryName)
                    {
                        thisGroup.ItemList.Add(thisBackpack4MaterialModel);
                        isNew = false;
                    }
                }

                if (isNew)
                {
                    Backpack4MaterialGroupModel thisGroup = new()
                    {
                        CategoryName = thisCategoryName
                    };
                    thisGroup.ItemList.Add(thisBackpack4MaterialModel);
                    AllMaterialGroupList.Add(thisGroup);
                }

                MaterialRidMap[e.Rid] = thisBackpack4MaterialModel;
            }

            UpdateExtraInfo();
            WeakReferenceMessenger.Default.Register(this);
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
            if (clickItem is { Number: >= 1 }) clickItem.Number -= 1;
        }

        [RelayCommand]
        private void MergeOneMaterial(Backpack4MaterialModel? clickItem)
        {
            if (clickItem != null)
            {
                int recipeId = AutoCalculateConstants.MaterialMergeRecipe[clickItem.Rid];
                Backpack4MaterialModel recipeMaterial = MaterialRidMap[recipeId];
                if (recipeMaterial.Number >= 3)
                {
                    recipeMaterial.Number -= 3;
                    clickItem.Number += 1;
                }
            }
        }

        public void Receive(GoalSimulatorChangeMessage message)
        {
            UpdateExtraInfo();
        }

        private void UpdateExtraInfo()
        {
            Dictionary<int, CalculatorPlanMaterialExtraInfo> materialExtraInfoMap = App.GlobalGoalSimulatorServicePart!.GetMaterialExtraInfo();
            foreach (int materialRid in materialExtraInfoMap.Keys)
            {
                CalculatorPlanMaterialExtraInfo thisExtraInfo = materialExtraInfoMap[materialRid];
                Backpack4MaterialModel thisMaterialModel = MaterialRidMap[materialRid];
                thisMaterialModel.Number = App.BackpackMaterialConfigManagerInstance!.GetMaterialNumber(materialRid);
                thisMaterialModel.Num1 = thisExtraInfo.NeedNum;
                if (thisExtraInfo.NeedNum > 0) thisMaterialModel.Color1 = thisExtraInfo.IsSatisfy ? "#12B981" : "#FB7185";
                else thisMaterialModel.Color1 = "#Transparent";
                thisMaterialModel.IconPath = thisExtraInfo.IsSatisfy ? "/Resources/Icons/check_circle_30dp_DDDDDD_FILL0_wght400_GRAD0_opsz24.png" : "/Resources/Icons/cancel_30dp_DDDDDD_FILL0_wght400_GRAD0_opsz24.png";
                if (thisExtraInfo.IsSatisfy)
                {
                    if (thisExtraInfo.ActionNum > 0)
                    {
                        thisMaterialModel.Num2String = thisExtraInfo.ActionNum.ToString();
                        thisMaterialModel.Color2 = "#B98823";
                    }
                    else
                    {
                        thisMaterialModel.Num2String = "";
                        thisMaterialModel.Color2 = "#Transparent";
                    }
                }
                else
                {
                    thisMaterialModel.Num2String = thisExtraInfo.ActionNum.ToString();
                    thisMaterialModel.Color2 = "#FB7185";
                }
            }
        }
    }
}