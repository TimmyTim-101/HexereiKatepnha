using System.Collections.ObjectModel;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Constants.EntityConstants.MaterialConstants;
using HexereiKatepnha.Models.ConfigModels;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.ModelsForViews.Backpack;
using HexereiKatepnha.Models.ModelsForViews.Calculator;

namespace HexereiKatepnha.Services.CalculatorService;

public class SingleCharacterSimulatorService
{
    private SingleBackpackCharacterConfigModel _characterConfig = new();
    private CharacterModel _characterModel;
    private BackpackCharacterPlanInfo _res = new();

    public SingleCharacterSimulatorService(int characterRid)
    {
        if (App.BackpackCharacterConfigManagerInstance!.Configuration.CharacterConfig.ContainsKey(characterRid))
        {
            _characterConfig = App.BackpackCharacterConfigManagerInstance.Configuration.CharacterConfig[characterRid];
        }

        _characterModel = AutoCalculateConstants.CharacterMap[characterRid];
    }

    private void UpdateMaterial()
    {
        _res.CharacterPlanMaterialList.Clear();
        // 分离材料
        HashSet<int> involvedMaterialRidList = [];
        foreach (List<MaterialPairModel> mpmList in _characterModel.LevelUpMaterials.Values)
        {
            foreach (MaterialPairModel mpm in mpmList)
            {
                involvedMaterialRidList.Add(mpm.MaterialModel!.Rid);
                if (mpm.MaterialModel.Rid == 3020001)
                {
                    involvedMaterialRidList.Add(3020002);
                    involvedMaterialRidList.Add(3020003);
                }
            }
        }

        foreach (List<MaterialPairModel> mpmList in _characterModel.Talent1Materials.Values)
        {
            foreach (MaterialPairModel mpm in mpmList)
            {
                involvedMaterialRidList.Add(mpm.MaterialModel!.Rid);
            }
        }

        foreach (List<MaterialPairModel> mpmList in _characterModel.Talent2Materials.Values)
        {
            foreach (MaterialPairModel mpm in mpmList)
            {
                involvedMaterialRidList.Add(mpm.MaterialModel!.Rid);
            }
        }

        foreach (List<MaterialPairModel> mpmList in _characterModel.Talent3Materials.Values)
        {
            foreach (MaterialPairModel mpm in mpmList)
            {
                involvedMaterialRidList.Add(mpm.MaterialModel!.Rid);
            }
        }

        Dictionary<int, CalculatorPlanMaterialExtraInfo> materialExtraInfoMap = App.GlobalGoalSimulatorServicePart!.GetMaterialExtraInfo();
        foreach (List<MaterialModel> l in AllEntities.AllMaterialLists)
        {
            foreach (MaterialModel e in l)
            {
                if (involvedMaterialRidList.Contains(e.Rid))
                {
                    BackpackCharacterPlanInfoMaterial thisMaterial = new BackpackCharacterPlanInfoMaterial();
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

                    _res.CharacterPlanMaterialList.Add(thisMaterial);
                }
            }
        }
    }

    public void UpdateSubPlan()
    {
        _res.CharacterPlanSubPlanList.Clear();
        // 分离任务
        // 角色等级
        int startCharacterLevelIndex = SequenceConstants.AllLevels.IndexOf(_characterConfig.CharacterLevel);
        int endCharacterLevelIndex = startCharacterLevelIndex;
        for (int i = startCharacterLevelIndex; i < SequenceConstants.AllLevels.Count; i++)
        {
            if (!_characterModel.LevelUpMaterials.ContainsKey(SequenceConstants.AllLevels[i])) break;
            endCharacterLevelIndex++;
        }

        bool isCharacterLevelCheckAble = true;
        int tempExp = -_characterConfig.SubExp;
        string tempStartLevelString = "";
        bool tempIsLevel = false;
        for (int l = startCharacterLevelIndex; l < endCharacterLevelIndex; l++)
        {
            List<MaterialPairModel> thisLevelMaterialList = _characterModel.LevelUpMaterials[SequenceConstants.AllLevels[l]];
            if (thisLevelMaterialList.Count == 1 && thisLevelMaterialList[0].MaterialModel!.Rid == 3020001)
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
                    BackpackCharacterPlanInfoSubPlan thisCharacterLevelSubPlan = new BackpackCharacterPlanInfoSubPlan();
                    thisCharacterLevelSubPlan.CharacterRid = _characterModel.Rid;
                    thisCharacterLevelSubPlan.Index = _res.CharacterPlanSubPlanList.Count + 1;
                    thisCharacterLevelSubPlan.Type = 1;
                    thisCharacterLevelSubPlan.ActionTypeString = "角色等级";
                    thisCharacterLevelSubPlan.ActionDescriptionString = $"{tempStartLevelString} → {StringConstants.LevelNumberString[SequenceConstants.AllLevels[l]]}";
                    thisCharacterLevelSubPlan.FinishLevel = SequenceConstants.AllLevels[l];
                    int[] resultOfMaterial = CalculateCharacterExp(tempExp);
                    MaterialModel[] materialModels =
                    [
                        MaterialConstants01._3010001, MaterialConstants02._3020001, MaterialConstants02._3020002, MaterialConstants02._3020003,
                    ];
                    for (int i = 0; i < 4; i++)
                    {
                        if (resultOfMaterial[i] > 0)
                        {
                            BackpackCharacterPlanInfoNeedMaterial m = new();
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

                            thisCharacterLevelSubPlan.NeedMaterialList.Add(m);
                        }
                    }

                    if (isCharacterLevelCheckAble)
                    {
                        thisCharacterLevelSubPlan.IsCheckAble = true;
                        isCharacterLevelCheckAble = false;
                    }
                    else thisCharacterLevelSubPlan.IsCheckAble = false;

                    _res.CharacterPlanSubPlanList.Add(thisCharacterLevelSubPlan);
                    // 还原暂存信息
                    tempIsLevel = false;
                    tempExp = 0;
                    tempStartLevelString = "";
                }

                // 处理突破部分
                BackpackCharacterPlanInfoSubPlan thisSubPlan = new BackpackCharacterPlanInfoSubPlan();
                thisSubPlan.CharacterRid = _characterModel.Rid;
                thisSubPlan.Index = _res.CharacterPlanSubPlanList.Count + 1;
                thisSubPlan.Type = 1;
                thisSubPlan.ActionTypeString = "角色突破";
                thisSubPlan.ActionDescriptionString = $"{StringConstants.LevelNumberString[SequenceConstants.AllLevels[l]]} ↑";
                thisSubPlan.FinishLevel = SequenceConstants.AllLevels[l + 1];
                ObservableCollection<BackpackCharacterPlanInfoNeedMaterial> thisNeedMaterialList = new();
                foreach (MaterialPairModel mpm in thisLevelMaterialList)
                {
                    int thisMaterialRid = mpm.MaterialModel!.Rid;
                    MaterialModel thisMaterialModel = AutoCalculateConstants.MaterialMap[thisMaterialRid];
                    BackpackCharacterPlanInfoNeedMaterial thisMaterialNeedInfo = new BackpackCharacterPlanInfoNeedMaterial();
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
                if (isCharacterLevelCheckAble)
                {
                    thisSubPlan.IsCheckAble = true;
                    isCharacterLevelCheckAble = false;
                }
                else thisSubPlan.IsCheckAble = false;

                _res.CharacterPlanSubPlanList.Add(thisSubPlan);
            }
        }

        // 处理残留的等级部分
        if (tempIsLevel)
        {
            BackpackCharacterPlanInfoSubPlan thisLevelSubPlan = new BackpackCharacterPlanInfoSubPlan();
            thisLevelSubPlan.CharacterRid = _characterModel.Rid;
            thisLevelSubPlan.Index = _res.CharacterPlanSubPlanList.Count + 1;
            thisLevelSubPlan.Type = 1;
            thisLevelSubPlan.ActionTypeString = "角色等级";
            thisLevelSubPlan.ActionDescriptionString = $"{tempStartLevelString} → {StringConstants.LevelNumberString[SequenceConstants.AllLevels[endCharacterLevelIndex]]}";
            thisLevelSubPlan.FinishLevel = SequenceConstants.AllLevels[endCharacterLevelIndex];
            int[] resultOfMaterial = CalculateCharacterExp(tempExp);
            MaterialModel[] materialModels =
            [
                MaterialConstants01._3010001, MaterialConstants02._3020001, MaterialConstants02._3020002, MaterialConstants02._3020003,
            ];
            for (int i = 0; i < 4; i++)
            {
                if (resultOfMaterial[i] > 0)
                {
                    BackpackCharacterPlanInfoNeedMaterial m = new();
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

            thisLevelSubPlan.IsCheckAble = isCharacterLevelCheckAble;
            _res.CharacterPlanSubPlanList.Add(thisLevelSubPlan);
        }

        // 天赋A
        int startTalentALevelIndex = SequenceConstants.AllLevels.IndexOf(_characterConfig.TalentALevel);
        int endTalentALevelIndex = startTalentALevelIndex;
        for (int i = startTalentALevelIndex; i < SequenceConstants.AllLevels.Count; i++)
        {
            if (!_characterModel.Talent1Materials.ContainsKey(SequenceConstants.AllLevels[i])) break;
            endTalentALevelIndex++;
        }

        bool isTalentACheckable = true;
        for (int l = startTalentALevelIndex; l < endTalentALevelIndex; l++)
        {
            BackpackCharacterPlanInfoSubPlan thisSubPlan = new BackpackCharacterPlanInfoSubPlan();
            thisSubPlan.CharacterRid = _characterModel.Rid;
            thisSubPlan.Index = _res.CharacterPlanSubPlanList.Count + 1;
            thisSubPlan.Type = 2;
            thisSubPlan.ActionTypeString = "普通攻击";
            string startLevelString = StringConstants.LevelNumberString[SequenceConstants.AllLevels[l]];
            string endLevelString = StringConstants.LevelNumberString[SequenceConstants.AllLevels[l + 1]];
            thisSubPlan.ActionDescriptionString = $"{startLevelString} → {endLevelString}";
            thisSubPlan.FinishLevel = SequenceConstants.AllLevels[l + 1];
            ObservableCollection<BackpackCharacterPlanInfoNeedMaterial> thisNeedMaterialList = new();
            foreach (MaterialPairModel mpm in _characterModel.Talent1Materials[SequenceConstants.AllLevels[l]])
            {
                int thisMaterialRid = mpm.MaterialModel!.Rid;
                MaterialModel thisMaterialModel = AutoCalculateConstants.MaterialMap[thisMaterialRid];
                BackpackCharacterPlanInfoNeedMaterial thisMaterialNeedInfo = new BackpackCharacterPlanInfoNeedMaterial();
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
            if (isTalentACheckable)
            {
                thisSubPlan.IsCheckAble = true;
                isTalentACheckable = false;
            }
            else thisSubPlan.IsCheckAble = false;

            _res.CharacterPlanSubPlanList.Add(thisSubPlan);
        }

        // 天赋E
        int startTalentELevelIndex = SequenceConstants.AllLevels.IndexOf(_characterConfig.TalentELevel);
        int endTalentELevelIndex = startTalentELevelIndex;
        for (int i = startTalentELevelIndex; i < SequenceConstants.AllLevels.Count; i++)
        {
            if (!_characterModel.Talent2Materials.ContainsKey(SequenceConstants.AllLevels[i])) break;
            endTalentELevelIndex++;
        }

        bool isTalentECheckable = true;
        for (int l = startTalentELevelIndex; l < endTalentELevelIndex; l++)
        {
            BackpackCharacterPlanInfoSubPlan thisSubPlan = new BackpackCharacterPlanInfoSubPlan();
            thisSubPlan.CharacterRid = _characterModel.Rid;
            thisSubPlan.Index = _res.CharacterPlanSubPlanList.Count + 1;
            thisSubPlan.Type = 3;
            thisSubPlan.ActionTypeString = "元素战技";
            string startLevelString = StringConstants.LevelNumberString[SequenceConstants.AllLevels[l]];
            string endLevelString = StringConstants.LevelNumberString[SequenceConstants.AllLevels[l + 1]];
            thisSubPlan.ActionDescriptionString = $"{startLevelString} → {endLevelString}";
            thisSubPlan.FinishLevel = SequenceConstants.AllLevels[l + 1];
            ObservableCollection<BackpackCharacterPlanInfoNeedMaterial> thisNeedMaterialList = new();
            foreach (MaterialPairModel mpm in _characterModel.Talent2Materials[SequenceConstants.AllLevels[l]])
            {
                int thisMaterialRid = mpm.MaterialModel!.Rid;
                MaterialModel thisMaterialModel = AutoCalculateConstants.MaterialMap[thisMaterialRid];
                BackpackCharacterPlanInfoNeedMaterial thisMaterialNeedInfo = new BackpackCharacterPlanInfoNeedMaterial();
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
            if (isTalentECheckable)
            {
                thisSubPlan.IsCheckAble = true;
                isTalentECheckable = false;
            }
            else thisSubPlan.IsCheckAble = false;

            _res.CharacterPlanSubPlanList.Add(thisSubPlan);
        }

        // 天赋Q
        int startTalentQLevelIndex = SequenceConstants.AllLevels.IndexOf(_characterConfig.TalentQLevel);
        int endTalentQLevelIndex = startTalentQLevelIndex;
        for (int i = startTalentQLevelIndex; i < SequenceConstants.AllLevels.Count; i++)
        {
            if (!_characterModel.Talent3Materials.ContainsKey(SequenceConstants.AllLevels[i])) break;
            endTalentQLevelIndex++;
        }

        bool isTalentQCheckable = true;
        for (int l = startTalentQLevelIndex; l < endTalentQLevelIndex; l++)
        {
            BackpackCharacterPlanInfoSubPlan thisSubPlan = new BackpackCharacterPlanInfoSubPlan();
            thisSubPlan.CharacterRid = _characterModel.Rid;
            thisSubPlan.Index = _res.CharacterPlanSubPlanList.Count + 1;
            thisSubPlan.Type = 4;
            thisSubPlan.ActionTypeString = "元素爆发";
            string startLevelString = StringConstants.LevelNumberString[SequenceConstants.AllLevels[l]];
            string endLevelString = StringConstants.LevelNumberString[SequenceConstants.AllLevels[l + 1]];
            thisSubPlan.ActionDescriptionString = $"{startLevelString} → {endLevelString}";
            thisSubPlan.FinishLevel = SequenceConstants.AllLevels[l + 1];
            ObservableCollection<BackpackCharacterPlanInfoNeedMaterial> thisNeedMaterialList = new();
            foreach (MaterialPairModel mpm in _characterModel.Talent3Materials[SequenceConstants.AllLevels[l]])
            {
                int thisMaterialRid = mpm.MaterialModel!.Rid;
                MaterialModel thisMaterialModel = AutoCalculateConstants.MaterialMap[thisMaterialRid];
                BackpackCharacterPlanInfoNeedMaterial thisMaterialNeedInfo = new BackpackCharacterPlanInfoNeedMaterial();
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
            if (isTalentQCheckable)
            {
                thisSubPlan.IsCheckAble = true;
                isTalentQCheckable = false;
            }
            else thisSubPlan.IsCheckAble = false;

            _res.CharacterPlanSubPlanList.Add(thisSubPlan);
        }

        _res.IsShowSubPlan = _res.CharacterPlanSubPlanList.Count > 0;
        _res.IsAllComplete = _res.CharacterPlanSubPlanList.Count == 0;
    }

    public BackpackCharacterPlanInfo GetCharacterPlanInfo()
    {
        UpdateMaterial();
        UpdateSubPlan();
        return _res;
    }

    // 计算具体角色经验花费
    private int[] CalculateCharacterExp(int t)
    {
        int[] res = [0, 0, 0, 0]; // [摩拉，大经验书，中经验书，小经验书]
        int largeExpNum = App.BackpackMaterialConfigManagerInstance!.GetMaterialNumber(3020001);
        int mediumExpNum = App.BackpackMaterialConfigManagerInstance.GetMaterialNumber(3020002);
        int smallExpNum = App.BackpackMaterialConfigManagerInstance.GetMaterialNumber(3020003);
        if (20000 * largeExpNum + 5000 * mediumExpNum + 1000 * smallExpNum >= t)
        {
            // 现有经验书足够，按照现有经验书数量进行分配
            // 可能bug点是说虽然一个大经验书溢出很多，但是一个就足够不需要耗费其它材料，现在的代码输出会把所有小经验书都用了
            // 但是这种情况出现概率不高，同时解决方法是结尾再加一个找回的动作就行。
            int largeUseNum = Math.Min(largeExpNum, t / 20000);
            t -= 20000 * largeUseNum;
            largeExpNum -= largeUseNum;
            int mediumUseNum = Math.Min(mediumExpNum, t / 5000);
            t -= 5000 * mediumUseNum;
            mediumExpNum -= mediumUseNum;
            int smallUseNum = Math.Min(smallExpNum, t / 1000);
            t -= 1000 * smallUseNum;
            smallExpNum -= smallUseNum;
            while (t > 0)
            {
                if (smallExpNum > 0)
                {
                    t -= 1000;
                    smallUseNum++;
                    smallExpNum--;
                    continue;
                }

                if (mediumExpNum > 0)
                {
                    t -= 5000;
                    mediumUseNum++;
                    mediumExpNum--;
                    continue;
                }

                if (largeExpNum > 0)
                {
                    t -= 20000;
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
            // 现有经验书不足，按照最小数量进行分配
            res[1] = t / 20000;
            t -= 20000 * res[1];
            res[2] = t / 5000;
            t -= 5000 * res[2];
            res[3] = t / 1000;
            t -= 1000 * res[3];
            if (t > 0) res[3]++;
        }

        res[0] = 4000 * res[1] + 1000 * res[2] + 200 * res[3];
        return res;
    }
}