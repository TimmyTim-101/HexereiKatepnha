using System.Collections.ObjectModel;
using System.Diagnostics;
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
    public partial class Backpack4MaterialViewModel : ObservableObject, IRecipient<GoalSimulatorChangeMessage>, IRecipient<BackpackMaterialConfigChangeMessage>
    {
        public ObservableCollection<Backpack4MaterialModel> AllMaterialList { get; } = [];
        private Dictionary<int, Backpack4MaterialModel> MaterialRidMap { get; set; } = new();

        public Backpack4MaterialViewModel()
        {
            foreach (List<MaterialModel> l in AllEntities.AllMaterialLists)
            {
                foreach (MaterialModel e in l)
                {
                    Backpack4MaterialModel thisBackpack4MaterialModel = new Backpack4MaterialModel
                    {
                        ImagePath = e.ImagePath,
                        BackgroundImagePath = StringConstants.StarBackgroundImagePath[e.Star],
                        Name = e.Name,
                        Rid = e.Rid,
                        Number = App.BackpackMaterialConfigManagerInstance!.GetMaterialNumber(e.Rid)
                    };

                    AllMaterialList.Add(thisBackpack4MaterialModel);
                    MaterialRidMap[e.Rid] = thisBackpack4MaterialModel;
                }
            }

            UpdateExtraInfo();
            WeakReferenceMessenger.Default.Register<GoalSimulatorChangeMessage>(this);
            WeakReferenceMessenger.Default.Register<BackpackMaterialConfigChangeMessage>(this);
        }

        [RelayCommand]
        private void AddOneMaterial(Backpack4MaterialModel? clickItem)
        {
            if (clickItem != null)
            {
                App.BackpackMaterialConfigManagerInstance!.UpdateMaterialNumber(clickItem.Rid, clickItem.Number + 1);
            }
        }

        [RelayCommand]
        private void MinusOneMaterial(Backpack4MaterialModel? clickItem)
        {
            if (clickItem is { Number: >= 1 })
            {
                App.BackpackMaterialConfigManagerInstance!.UpdateMaterialNumber(clickItem.Rid, clickItem.Number - 1);
            }
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
                    App.BackpackMaterialConfigManagerInstance!.UpdateMaterialNumber([recipeMaterial.Rid, clickItem.Rid], [recipeMaterial.Number - 3, clickItem.Number + 1]);
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
                if (thisExtraInfo.NeedNum > 0) thisMaterialModel.Color1 = thisExtraInfo.IsSatisfy ? StringConstants.GreenColorString : StringConstants.RedColorString;
                else thisMaterialModel.Color1 = "#Transparent";
                thisMaterialModel.IconPath = thisExtraInfo.IsSatisfy ? "/Resources/Icons/check_circle_30dp_DDDDDD_FILL0_wght400_GRAD0_opsz24.png" : "/Resources/Icons/cancel_30dp_DDDDDD_FILL0_wght400_GRAD0_opsz24.png";
                if (thisExtraInfo.IsSatisfy)
                {
                    if (thisExtraInfo.ActionNum > 0)
                    {
                        thisMaterialModel.Num2String = thisExtraInfo.ActionNum.ToString();
                        thisMaterialModel.Color2 = StringConstants.YellowColorString;
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
                    thisMaterialModel.Color2 = StringConstants.RedColorString;
                }
            }
        }

        [RelayCommand]
        public void OpenHelpWebPage()
        {
            string url = "https://github.com/TimmyTim-101/HexereiKatepnha/wiki/%E8%83%8C%E5%8C%85-%E2%80%90-%E6%9D%90%E6%96%99";
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

        public void Receive(BackpackMaterialConfigChangeMessage message)
        {
            List<int> materialRidList = message.Value;
            foreach (int materialRid in materialRidList)
            {
                MaterialRidMap[materialRid].Number = App.BackpackMaterialConfigManagerInstance!.GetMaterialNumber(materialRid);
            }
        }
    }
}