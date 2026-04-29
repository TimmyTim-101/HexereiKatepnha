using System.Collections.ObjectModel;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Constants.EntityConstants.MaterialConstants;
using HexereiKatepnha.Models.ConfigModels;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.ModelsForViews.Backpack;
using HexereiKatepnha.Models.ModelsForViews.Calculator;

namespace HexereiKatepnha.Services.CalculatorService;

public class SingleWeaponSimulatorService(SingleBackpackWeaponConfigModel weaponConfig)
{
    private readonly WeaponModel _weaponModel = AutoCalculateConstants.WeaponMap[weaponConfig.Rid];
    private BackpackWeaponPlanInfo _res = new();
    private Dictionary<int, int> _materialHaveNumMap = new();
    private Dictionary<int, int> _materialNeedNumMap = new();

    public BackpackWeaponPlanInfo GetWeaponPlanInfo()
    {
        _materialHaveNumMap = new Dictionary<int, int>(App.BackpackMaterialConfigManagerInstance!.Configuration.MaterialNumberMap);
        CalculateSubPlan();
        CalculateMaterial();
        return _res;
    }

    private void CalculateSubPlan()
    {
        bool isLevelDone = weaponConfig.Level == weaponConfig.GoalLevel;
        int startLevelIndex, endLevelIndex;
        if (isLevelDone)
        {
            // 考虑goal后面的部分
            startLevelIndex = SequenceConstants.AllLevels.IndexOf(weaponConfig.GoalLevel);
            endLevelIndex = startLevelIndex;
            for (int i = startLevelIndex; i < SequenceConstants.AllLevels.Count; i++)
            {
                if (!_weaponModel.LevelUpMaterials.ContainsKey(SequenceConstants.AllLevels[i])) break;
                endLevelIndex++;
            }
        }
        else
        {
            // 只考虑规划的部分
            startLevelIndex = SequenceConstants.AllLevels.IndexOf(weaponConfig.Level);
            endLevelIndex = SequenceConstants.AllLevels.IndexOf(weaponConfig.GoalLevel);
        }

        bool isLevelCheckAble = true;
        int tempExp = -weaponConfig.SubExp;
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
                    thisLevelSubPlan.WeaponId = weaponConfig.Id;
                    thisLevelSubPlan.Index = _res.WeaponPlanSubPlanList.Count + 1;
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
                            int haveNum = _materialHaveNumMap.GetValueOrDefault(materialModels[i].Rid, 0);
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
                            _materialHaveNumMap[materialModels[i].Rid] = Math.Max(0, haveNum - resultOfMaterial[i]);
                            _materialNeedNumMap[materialModels[i].Rid] = _materialNeedNumMap.GetValueOrDefault(materialModels[i].Rid, 0) + resultOfMaterial[i];
                        }
                    }

                    if (isLevelCheckAble)
                    {
                        thisLevelSubPlan.IsCheckAble = true;
                        isLevelCheckAble = false;
                    }
                    else thisLevelSubPlan.IsCheckAble = false;

                    _res.WeaponPlanSubPlanList.Add(thisLevelSubPlan);
                    // 还原暂存信息
                    tempIsLevel = false;
                    tempExp = 0;
                    tempStartLevelString = "";
                }

                // 处理突破部分
                BackpackWeaponPlanInfoSubPlan thisSubPlan = new BackpackWeaponPlanInfoSubPlan();
                thisSubPlan.WeaponId = weaponConfig.Id;
                thisSubPlan.Index = _res.WeaponPlanSubPlanList.Count + 1;
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
                    int haveNum = _materialHaveNumMap.GetValueOrDefault(thisMaterialRid, 0);
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
                    _materialHaveNumMap[thisMaterialRid] = Math.Max(0, haveNum - needNum);
                    _materialNeedNumMap[thisMaterialRid] = _materialNeedNumMap.GetValueOrDefault(thisMaterialRid, 0) + needNum;
                }

                thisSubPlan.NeedMaterialList = thisNeedMaterialList;
                if (isLevelCheckAble)
                {
                    thisSubPlan.IsCheckAble = true;
                    isLevelCheckAble = false;
                }
                else thisSubPlan.IsCheckAble = false;

                _res.WeaponPlanSubPlanList.Add(thisSubPlan);
            }
        }

        // 处理残留的等级部分
        if (tempIsLevel)
        {
            BackpackWeaponPlanInfoSubPlan thisLevelSubPlan = new BackpackWeaponPlanInfoSubPlan();
            thisLevelSubPlan.WeaponId = weaponConfig.Id;
            thisLevelSubPlan.Index = _res.WeaponPlanSubPlanList.Count + 1;
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
                    int haveNum = _materialHaveNumMap.GetValueOrDefault(materialModels[i].Rid, 0);
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
                    _materialHaveNumMap[materialModels[i].Rid] = Math.Max(0, haveNum - resultOfMaterial[i]);
                    _materialNeedNumMap[materialModels[i].Rid] = _materialNeedNumMap.GetValueOrDefault(materialModels[i].Rid, 0) + resultOfMaterial[i];
                }
            }

            thisLevelSubPlan.IsCheckAble = isLevelCheckAble;
            _res.WeaponPlanSubPlanList.Add(thisLevelSubPlan);
        }

        _res.IsShowSubPlan = _res.WeaponPlanSubPlanList.Count > 0;
        _res.IsAllComplete = _res.WeaponPlanSubPlanList.Count == 0;
    }

    private void CalculateMaterial()
    {
        if (_res.IsAllComplete) return;
        // 分离材料
        HashSet<int> involvedMaterialRidList = [];
        foreach (List<MaterialPairModel> mpmList in _weaponModel.LevelUpMaterials.Values)
        {
            foreach (MaterialPairModel mpm in mpmList)
            {
                involvedMaterialRidList.Add(mpm.MaterialModel!.Rid);
                if (mpm.MaterialModel.Rid == 3110001)
                {
                    involvedMaterialRidList.Add(3110002);
                    involvedMaterialRidList.Add(3110003);
                }
            }
        }

        // 确定合并后数量
        Dictionary<int, CalculatorPlanMaterialExtraInfo> materialExtraInfoMap = new();
        foreach (List<MaterialModel> l in AllEntities.AllMaterialLists)
        {
            foreach (MaterialModel e in l)
            {
                if (_materialNeedNumMap.ContainsKey(e.Rid))
                {
                    if (materialExtraInfoMap.ContainsKey(e.Rid)) continue;
                    List<int> relativeMaterialList = [e.Rid];
                    while (AutoCalculateConstants.MaterialMergeRecipe.ContainsKey(relativeMaterialList[^1]))
                    {
                        relativeMaterialList.Add(AutoCalculateConstants.MaterialMergeRecipe[relativeMaterialList[^1]]);
                    }

                    int[] relativeHaveNumList = new int[relativeMaterialList.Count];
                    int[] relativeNeedNumList = new int[relativeMaterialList.Count];
                    for (int i = 0; i < relativeMaterialList.Count; i++)
                    {
                        relativeHaveNumList[i] = App.BackpackMaterialConfigManagerInstance!.GetMaterialNumber(relativeMaterialList[i]);
                        relativeNeedNumList[i] = _materialNeedNumMap.GetValueOrDefault(relativeMaterialList[i], 0);
                    }

                    int[] relativeDemandMergeNumList = new int[relativeMaterialList.Count];
                    int[] relativeCanMergeNumList = new int[relativeMaterialList.Count];
                    int[] relativeActualMergeNumList = new int[relativeMaterialList.Count];
                    for (int i = 0; i < relativeMaterialList.Count - 1; i++)
                    {
                        relativeDemandMergeNumList[i] = Math.Max(0, relativeNeedNumList[i] - relativeHaveNumList[i] + 3 * (i == 0 ? 0 : relativeDemandMergeNumList[i - 1]));
                    }

                    for (int i = relativeMaterialList.Count - 1; i > 0; i--)
                    {
                        relativeCanMergeNumList[i] = Math.Min(3 * relativeDemandMergeNumList[i - 1], Math.Max(0, relativeHaveNumList[i] - relativeNeedNumList[i] + relativeActualMergeNumList[i]));
                        relativeActualMergeNumList[i - 1] = relativeCanMergeNumList[i] / 3;
                    }

                    int[] relativeAfterMergeNumList = new int[relativeMaterialList.Count];
                    for (int i = 0; i < relativeMaterialList.Count; i++)
                    {
                        relativeAfterMergeNumList[i] = relativeHaveNumList[i] + relativeActualMergeNumList[i] - (i == 0 ? 0 : 3 * relativeActualMergeNumList[i - 1]);
                    }

                    for (int i = 0; i < relativeMaterialList.Count; i++)
                    {
                        CalculatorPlanMaterialExtraInfo thisModel = new CalculatorPlanMaterialExtraInfo
                        {
                            Rid = relativeMaterialList[i],
                            NeedNum = relativeNeedNumList[i],
                            IsSatisfy = relativeAfterMergeNumList[i] >= relativeNeedNumList[i]
                        };
                        thisModel.ActionNum = thisModel.IsSatisfy ? relativeActualMergeNumList[i] : relativeNeedNumList[i] - relativeAfterMergeNumList[i];
                        materialExtraInfoMap[relativeMaterialList[i]] = thisModel;
                    }
                }
            }
        }

        // 拼装数据
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
                    CalculatorPlanMaterialExtraInfo thisMaterialExtraInfo = materialExtraInfoMap.GetValueOrDefault(e.Rid, new CalculatorPlanMaterialExtraInfo { Rid = e.Rid, NeedNum = 0, ActionNum = 0, IsSatisfy = true });
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

                    _res.WeaponPlanMaterialList.Add(thisMaterial);
                }
            }
        }
    }

    // 计算具体武器经验花费
    private int[] CalculateWeaponExp(int t)
    {
        int[] res = [0, 0, 0, 0]; // [摩拉，大经验矿，中经验矿，小经验矿]
        int largeExpNum = _materialHaveNumMap.GetValueOrDefault(3110001, 0);
        int mediumExpNum = _materialHaveNumMap.GetValueOrDefault(3110002, 0);
        int smallExpNum = _materialHaveNumMap.GetValueOrDefault(3110003, 0);
        if (10000 * largeExpNum + 2000 * mediumExpNum + 400 * smallExpNum >= t)
        {
            // 现有经验矿足够，按照现有经验矿数量进行分配
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
            // 尝试找回
            bool isNeedPutBack = true;
            while (isNeedPutBack)
            {
                isNeedPutBack = false;
                if (t + 10000 < 0 && res[1] > 0)
                {
                    isNeedPutBack = true;
                    res[1] -= 1;
                    t += 10000;
                    continue;
                }

                if (t + 2000 < 0 && res[2] > 0)
                {
                    isNeedPutBack = true;
                    res[2] -= 1;
                    t += 2000;
                    continue;
                }

                if (t + 400 < 0 && res[3] > 0)
                {
                    isNeedPutBack = true;
                    res[3] -= 1;
                    t += 400;
                }
            }
        }
        else
        {
            // 现有经验矿不足，按照额外的最小数量进行分配
            t -= 10000 * largeExpNum + 2000 * mediumExpNum + 400 * smallExpNum;
            res[1] = t / 10000;
            t -= 10000 * res[1];
            res[2] = t / 2000;
            t -= 2000 * res[2];
            res[3] = t / 400;
            t -= 400 * res[3];
            if (t > 0) res[3]++;
            res[1] += largeExpNum;
            res[2] += mediumExpNum;
            res[3] += smallExpNum;
        }

        res[0] = 1000 * res[1] + 200 * res[2] + 40 * res[3];
        return res;
    }
}