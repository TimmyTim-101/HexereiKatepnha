using System.Collections.ObjectModel;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Constants.EntityConstants.MaterialConstants;
using HexereiKatepnha.Models.ConfigModels;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.ModelsForViews.Backpack;
using HexereiKatepnha.Models.ModelsForViews.Calculator;

namespace HexereiKatepnha.Services.CalculatorService;

public class SingleWeaponSimulatorService
{
    private SingleBackpackWeaponConfigModel _weaponConfig;
    private WeaponModel _weaponModel;

    public SingleWeaponSimulatorService(SingleBackpackWeaponConfigModel weaponConfig)
    {
        _weaponConfig = weaponConfig;
        _weaponModel = AutoCalculateConstants.WeaponMap[weaponConfig.Rid];
    }

    public BackpackWeaponPlanInfo GetWeaponPlanInfo()
    {
        BackpackWeaponPlanInfo res = new BackpackWeaponPlanInfo();
        // 分离材料
        List<int> involvedMaterialRidList = [];
        foreach (List<MaterialPairModel> mpmList in _weaponModel.LevelUpMaterials.Values)
        {
            foreach (MaterialPairModel mpm in mpmList)
            {
                if (!involvedMaterialRidList.Contains(mpm.MaterialModel!.Rid)) involvedMaterialRidList.Add(mpm.MaterialModel.Rid);
                if (mpm.MaterialModel.Rid == 3110001)
                {
                    if (!involvedMaterialRidList.Contains(3110002)) involvedMaterialRidList.Add(3110002);
                    if (!involvedMaterialRidList.Contains(3110003)) involvedMaterialRidList.Add(3110003);
                }
            }
        }

        Dictionary<int, CalculatorPlanMaterialExtraInfo> materialExtraInfoMap = App.GlobalGoalSimulatorServicePart!.GetMaterialExtraInfo();
        foreach (List<MaterialModel> l in AllEntities.AllMaterialLists)
        {
            foreach (MaterialModel e in l)
            {
                if (involvedMaterialRidList.Contains(e.Rid))
                {
                    BackpackWeaponPlanInfoMaterial thisMaterial = new BackpackWeaponPlanInfoMaterial();
                    thisMaterial.Rid = e.Rid;
                    thisMaterial.Name = e.Name;
                    thisMaterial.BackgroundImagePath = StringConstants.StarBackgroundImagePath[e.Star];
                    thisMaterial.ImagePath = e.ImagePath;
                    thisMaterial.Number = App.BackpackMaterialConfigManagerInstance!.GetMaterialNumber(e.Rid);
                    CalculatorPlanMaterialExtraInfo thisMaterialExtraInfo = materialExtraInfoMap[e.Rid];
                    thisMaterial.Num1 = thisMaterialExtraInfo.NeedNum;
                    if (thisMaterialExtraInfo.NeedNum > 0) thisMaterial.Color1 = thisMaterialExtraInfo.IsSatisfy ? StringConstants.GreenColorString : StringConstants.RedColorString;
                    else thisMaterial.Color1 = "#Transparent";
                    thisMaterial.IconPath = thisMaterialExtraInfo.IsSatisfy ? StringConstants.CheckCircleIconPath : StringConstants.CancelIconPath;
                    if (thisMaterialExtraInfo.IsSatisfy)
                    {
                        if (thisMaterialExtraInfo.ActionNum > 0)
                        {
                            thisMaterial.Num2String = thisMaterialExtraInfo.ActionNum.ToString();
                            thisMaterial.Color2 = StringConstants.YellowColorString;
                        }
                        else
                        {
                            thisMaterial.Num2String = "";
                            thisMaterial.Color2 = "#Transparent";
                        }
                    }
                    else
                    {
                        thisMaterial.Num2String = thisMaterialExtraInfo.ActionNum.ToString();
                        thisMaterial.Color2 = StringConstants.RedColorString;
                    }

                    res.WeaponPlanMaterialList.Add(thisMaterial);
                }
            }
        }

        // 分离任务
        int startLevelIndex = SequenceConstants.AllLevels.IndexOf(_weaponConfig.Level);
        int endLevelIndex = startLevelIndex;
        for (int i = startLevelIndex; i < SequenceConstants.AllLevels.Count; i++)
        {
            if (!_weaponModel.LevelUpMaterials.ContainsKey(SequenceConstants.AllLevels[i])) break;
            endLevelIndex++;
        }

        bool isLevelCheckAble = true;
        int tempExp = -_weaponConfig.SubExp;
        string tempStartLevelString = "";
        bool tempIsLevel = false;
        for (int l = startLevelIndex; l < endLevelIndex; l++)
        {
            List<MaterialPairModel> thisLevelMaterialList = _weaponModel.LevelUpMaterials[SequenceConstants.AllLevels[l]];
            if (thisLevelMaterialList.Count == 1 && thisLevelMaterialList[0].MaterialModel!.Rid == 3110001)
            {
                // 是等级继续累加
                if (!tempIsLevel)
                {
                    // 是首次等级
                    tempIsLevel = true;
                    tempStartLevelString = StringConstants.LevelNumberString[SequenceConstants.AllLevels[l]];
                }

                tempExp += (int)thisLevelMaterialList[0].DropNum;
            }

            else
            {
                // 不是等级，停止等级累加进行处理，并且同时处理这个等级该做的事情
                // 结束等级累加
                if (tempIsLevel)
                {
                    BackpackWeaponPlanInfoSubPlan thisLevelSubPlan = new BackpackWeaponPlanInfoSubPlan();
                    thisLevelSubPlan.WeaponId = _weaponConfig.Id;
                    thisLevelSubPlan.Index = res.WeaponPlanSubPlanList.Count + 1;
                    thisLevelSubPlan.ActionTypeString = "武器等级";
                    thisLevelSubPlan.ActionDescriptionString = $"{tempStartLevelString} → {StringConstants.LevelNumberString[SequenceConstants.AllLevels[l]]}";
                    thisLevelSubPlan.FinishLevel = SequenceConstants.AllLevels[l];
                    int[] resultOfMaterial = CalculateWeaponExp(tempExp);
                    MaterialModel[] materialModels =
                    [
                        MaterialConstants01._3010001, MaterialConstants11._3110001, MaterialConstants11._3110002, MaterialConstants11._3110003,
                    ];
                    for (int i = 0; i < 4; i++)
                    {
                        if (resultOfMaterial[i] > 0)
                        {
                            BackpackWeaponPlanInfoNeedMaterial m = new();
                            m.Rid = materialModels[i].Rid;
                            m.BackgroundImagePath = StringConstants.StarBackgroundImagePath[materialModels[i].Star];
                            m.ImagePath = materialModels[i].ImagePath;
                            m.Name = materialModels[i].Name;
                            m.NeedNum = resultOfMaterial[i];
                            int haveNum = App.BackpackMaterialConfigManagerInstance!.GetMaterialNumber(materialModels[i].Rid);
                            if (haveNum >= resultOfMaterial[i])
                            {
                                m.ShowNum = resultOfMaterial[i];
                                m.Color = StringConstants.GreenColorString;
                            }
                            else
                            {
                                m.ShowNum = resultOfMaterial[i] - haveNum;
                                m.Color = StringConstants.RedColorString;
                            }

                            thisLevelSubPlan.NeedMaterialList.Add(m);
                        }
                    }

                    if (isLevelCheckAble)
                    {
                        thisLevelSubPlan.IsCheckAble = true;
                        isLevelCheckAble = false;
                    }
                    else thisLevelSubPlan.IsCheckAble = false;

                    res.WeaponPlanSubPlanList.Add(thisLevelSubPlan);
                    // 还原暂存信息
                    tempIsLevel = false;
                    tempExp = 0;
                    tempStartLevelString = "";
                }

                // 处理突破部分
                BackpackWeaponPlanInfoSubPlan thisSubPlan = new BackpackWeaponPlanInfoSubPlan();
                thisSubPlan.WeaponId = _weaponConfig.Id;
                thisSubPlan.Index = res.WeaponPlanSubPlanList.Count + 1;
                thisSubPlan.ActionTypeString = "武器突破";
                thisSubPlan.ActionDescriptionString = $"{StringConstants.LevelNumberString[SequenceConstants.AllLevels[l]]} ↑";
                thisSubPlan.FinishLevel = SequenceConstants.AllLevels[l + 1];
                ObservableCollection<BackpackWeaponPlanInfoNeedMaterial> thisNeedMaterialList = new();
                foreach (MaterialPairModel mpm in thisLevelMaterialList)
                {
                    int thisMaterialRid = mpm.MaterialModel!.Rid;
                    MaterialModel thisMaterialModel = AutoCalculateConstants.MaterialMap[thisMaterialRid];
                    BackpackWeaponPlanInfoNeedMaterial thisMaterialNeedInfo = new BackpackWeaponPlanInfoNeedMaterial();
                    thisMaterialNeedInfo.Rid = thisMaterialRid;
                    thisMaterialNeedInfo.BackgroundImagePath = StringConstants.StarBackgroundImagePath[thisMaterialModel.Star];
                    thisMaterialNeedInfo.ImagePath = thisMaterialModel.ImagePath;
                    thisMaterialNeedInfo.Name = thisMaterialModel.Name;
                    thisMaterialNeedInfo.NeedNum = (int)mpm.DropNum;
                    int haveNum = App.BackpackMaterialConfigManagerInstance!.GetMaterialNumber(thisMaterialRid);
                    int needNum = (int)mpm.DropNum;
                    if (haveNum >= needNum)
                    {
                        thisMaterialNeedInfo.ShowNum = needNum;
                        thisMaterialNeedInfo.Color = StringConstants.GreenColorString;
                    }
                    else
                    {
                        thisMaterialNeedInfo.ShowNum = needNum - haveNum;
                        thisMaterialNeedInfo.Color = StringConstants.RedColorString;
                    }

                    thisNeedMaterialList.Add(thisMaterialNeedInfo);
                }

                thisSubPlan.NeedMaterialList = thisNeedMaterialList;
                if (isLevelCheckAble)
                {
                    thisSubPlan.IsCheckAble = true;
                    isLevelCheckAble = false;
                }
                else thisSubPlan.IsCheckAble = false;

                res.WeaponPlanSubPlanList.Add(thisSubPlan);
            }
        }

        // 处理残留的等级部分
        if (tempIsLevel)
        {
            BackpackWeaponPlanInfoSubPlan thisLevelSubPlan = new BackpackWeaponPlanInfoSubPlan();
            thisLevelSubPlan.WeaponId = _weaponConfig.Id;
            thisLevelSubPlan.Index = res.WeaponPlanSubPlanList.Count + 1;
            thisLevelSubPlan.ActionTypeString = "武器等级";
            thisLevelSubPlan.ActionDescriptionString = $"{tempStartLevelString} → {StringConstants.LevelNumberString[SequenceConstants.AllLevels[endLevelIndex]]}";
            thisLevelSubPlan.FinishLevel = SequenceConstants.AllLevels[endLevelIndex];
            int[] resultOfMaterial = CalculateWeaponExp(tempExp);
            MaterialModel[] materialModels =
            [
                MaterialConstants01._3010001, MaterialConstants11._3110001, MaterialConstants11._3110002, MaterialConstants11._3110003,
            ];
            for (int i = 0; i < 4; i++)
            {
                if (resultOfMaterial[i] > 0)
                {
                    BackpackWeaponPlanInfoNeedMaterial m = new();
                    m.Rid = materialModels[i].Rid;
                    m.BackgroundImagePath = StringConstants.StarBackgroundImagePath[materialModels[i].Star];
                    m.ImagePath = materialModels[i].ImagePath;
                    m.Name = materialModels[i].Name;
                    m.NeedNum = resultOfMaterial[i];
                    int haveNum = App.BackpackMaterialConfigManagerInstance!.GetMaterialNumber(materialModels[i].Rid);
                    if (haveNum >= resultOfMaterial[i])
                    {
                        m.ShowNum = resultOfMaterial[i];
                        m.Color = StringConstants.GreenColorString;
                    }
                    else
                    {
                        m.ShowNum = resultOfMaterial[i] - haveNum;
                        m.Color = StringConstants.RedColorString;
                    }

                    thisLevelSubPlan.NeedMaterialList.Add(m);
                }
            }

            thisLevelSubPlan.IsCheckAble = isLevelCheckAble;
            res.WeaponPlanSubPlanList.Add(thisLevelSubPlan);
        }

        res.IsShowSubPlan = res.WeaponPlanSubPlanList.Count > 0;
        res.IsAllComplete = res.WeaponPlanSubPlanList.Count == 0;
        return res;
    }

    // 计算具体武器经验花费
    private int[] CalculateWeaponExp(int t)
    {
        int[] res = [0, 0, 0, 0]; // [摩拉，大经验矿，中经验矿，小经验矿]
        int largeExpNum = App.BackpackMaterialConfigManagerInstance!.GetMaterialNumber(3110001);
        int mediumExpNum = App.BackpackMaterialConfigManagerInstance.GetMaterialNumber(3110002);
        int smallExpNum = App.BackpackMaterialConfigManagerInstance.GetMaterialNumber(3110003);
        if (10000 * largeExpNum + 2000 * mediumExpNum + 400 * smallExpNum >= t)
        {
            // 现有经验矿足够，按照现有经验矿数量进行分配
            // 可能bug点是说虽然一个大经验矿溢出很多，但是一个就足够不需要耗费其它材料，现在的代码输出会把所有小经验矿都用了
            // 但是这种情况出现概率不高，同时解决方法是结尾再加一个找回的动作就行。
            int largeUseNum = Math.Min(largeExpNum, t / 10000);
            t -= 10000 * largeUseNum;
            largeExpNum -= largeUseNum;
            int mediumUseNum = Math.Min(mediumExpNum, t / 2000);
            t -= 2000 * mediumUseNum;
            mediumExpNum -= mediumUseNum;
            int smallUseNum = Math.Min(smallExpNum, t / 400);
            t -= 400 * smallUseNum;
            smallExpNum -= smallUseNum;
            while (t > 0)
            {
                if (smallExpNum > 0)
                {
                    t -= 400;
                    smallUseNum++;
                    smallExpNum--;
                    continue;
                }

                if (mediumExpNum > 0)
                {
                    t -= 2000;
                    mediumUseNum++;
                    mediumExpNum--;
                    continue;
                }

                if (largeExpNum > 0)
                {
                    t -= 10000;
                    largeUseNum++;
                    largeExpNum--;
                }
            }

            res[1] = largeUseNum;
            res[2] = mediumUseNum;
            res[3] = smallUseNum;
        }
        else
        {
            // 现有经验矿不足，按照最小数量进行分配
            res[1] = t / 10000;
            t -= 10000 * res[1];
            res[2] = t / 2000;
            t -= 2000 * res[2];
            res[3] = t / 400;
            t -= 400 * res[3];
            if (t > 0) res[3]++;
        }

        res[0] = 1000 * res[1] + 200 * res[2] + 40 * res[3];
        return res;
    }
}