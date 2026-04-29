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
    private Dictionary<int, int> _materialHaveNumMap = new();
    private Dictionary<int, int> _materialNeedNumMap = new();

    public SingleCharacterSimulatorService(int characterRid)
    {
        if (App.BackpackCharacterConfigManagerInstance!.Configuration.CharacterConfig.ContainsKey(characterRid))
        {
            _characterConfig = App.BackpackCharacterConfigManagerInstance.Configuration.CharacterConfig[characterRid];
        }

        _characterModel = AutoCalculateConstants.CharacterMap[characterRid];
    }

    public BackpackCharacterPlanInfo GetCharacterPlanInfo()
    {
        _materialHaveNumMap = new Dictionary<int, int>(App.BackpackMaterialConfigManagerInstance!.Configuration.MaterialNumberMap);
        CalculateSubPlan();
        CalculateMaterial();
        return _res;
    }

    private void CalculateSubPlan()
    {
        bool isLevelDone = _characterConfig.CharacterLevel == _characterConfig.CharacterLevelGoal;
        bool isTalentADone = _characterConfig.TalentALevel == _characterConfig.TalentALevelGoal;
        bool isTalentEDone = _characterConfig.TalentELevel == _characterConfig.TalentELevelGoal;
        bool isTalentQDone = _characterConfig.TalentQLevel == _characterConfig.TalentQLevelGoal;
        int startLevelIndex, endLevelIndex;
        int startTalentAIndex, endTalentAIndex;
        int startTalentEIndex, endTalentEIndex;
        int startTalentQIndex, endTalentQIndex;
        bool isAllDone = isLevelDone && isTalentADone && isTalentEDone && isTalentQDone;
        if (isAllDone)
        {
            // 考虑goal后面的部分
            startLevelIndex = SequenceConstants.AllLevels.IndexOf(_characterConfig.CharacterLevelGoal);
            endLevelIndex = startLevelIndex;
            for (int i = startLevelIndex; i < SequenceConstants.AllLevels.Count; i++)
            {
                if (!_characterModel.LevelUpMaterials.ContainsKey(SequenceConstants.AllLevels[i])) break;
                endLevelIndex++;
            }

            startTalentAIndex = SequenceConstants.AllLevels.IndexOf(_characterConfig.TalentALevelGoal);
            endTalentAIndex = startTalentAIndex;
            for (int i = startTalentAIndex; i < SequenceConstants.AllLevels.Count; i++)
            {
                if (!_characterModel.Talent1Materials.ContainsKey(SequenceConstants.AllLevels[i])) break;
                endTalentAIndex++;
            }

            startTalentEIndex = SequenceConstants.AllLevels.IndexOf(_characterConfig.TalentELevelGoal);
            endTalentEIndex = startTalentEIndex;
            for (int i = startTalentEIndex; i < SequenceConstants.AllLevels.Count; i++)
            {
                if (!_characterModel.Talent2Materials.ContainsKey(SequenceConstants.AllLevels[i])) break;
                endTalentEIndex++;
            }

            startTalentQIndex = SequenceConstants.AllLevels.IndexOf(_characterConfig.TalentQLevelGoal);
            endTalentQIndex = startTalentQIndex;
            for (int i = startTalentQIndex; i < SequenceConstants.AllLevels.Count; i++)
            {
                if (!_characterModel.Talent3Materials.ContainsKey(SequenceConstants.AllLevels[i])) break;
                endTalentQIndex++;
            }
        }
        else
        {
            // 只考虑规划的部分
            startLevelIndex = SequenceConstants.AllLevels.IndexOf(_characterConfig.CharacterLevel);
            endLevelIndex = SequenceConstants.AllLevels.IndexOf(_characterConfig.CharacterLevelGoal);
            startTalentAIndex = SequenceConstants.AllLevels.IndexOf(_characterConfig.TalentALevel);
            endTalentAIndex = SequenceConstants.AllLevels.IndexOf(_characterConfig.TalentALevelGoal);
            startTalentEIndex = SequenceConstants.AllLevels.IndexOf(_characterConfig.TalentELevel);
            endTalentEIndex = SequenceConstants.AllLevels.IndexOf(_characterConfig.TalentELevelGoal);
            startTalentQIndex = SequenceConstants.AllLevels.IndexOf(_characterConfig.TalentQLevel);
            endTalentQIndex = SequenceConstants.AllLevels.IndexOf(_characterConfig.TalentQLevelGoal);
        }

        // 等级
        bool isCharacterLevelCheckAble = true;
        int tempExp = -_characterConfig.SubExp;
        string tempStartLevelString = "";
        bool tempIsLevel = false;
        for (int l = startLevelIndex; l < endLevelIndex; l++)
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

                            thisCharacterLevelSubPlan.NeedMaterialList.Add(m);
                            _materialHaveNumMap[materialModels[i].Rid] = Math.Max(0, haveNum - resultOfMaterial[i]);
                            _materialNeedNumMap[materialModels[i].Rid] = _materialNeedNumMap.GetValueOrDefault(materialModels[i].Rid, 0) + resultOfMaterial[i];
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
            thisLevelSubPlan.ActionDescriptionString = $"{tempStartLevelString} → {StringConstants.LevelNumberString[SequenceConstants.AllLevels[endLevelIndex]]}";
            thisLevelSubPlan.FinishLevel = SequenceConstants.AllLevels[endLevelIndex];
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

            thisLevelSubPlan.IsCheckAble = isCharacterLevelCheckAble;
            _res.CharacterPlanSubPlanList.Add(thisLevelSubPlan);
        }

        // 天赋A
        bool isTalentACheckable = true;
        for (int l = startTalentAIndex; l < endTalentAIndex; l++)
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
            if (isTalentACheckable)
            {
                thisSubPlan.IsCheckAble = true;
                isTalentACheckable = false;
            }
            else thisSubPlan.IsCheckAble = false;

            _res.CharacterPlanSubPlanList.Add(thisSubPlan);
        }

        // 天赋E
        bool isTalentECheckable = true;
        for (int l = startTalentEIndex; l < endTalentEIndex; l++)
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
            if (isTalentECheckable)
            {
                thisSubPlan.IsCheckAble = true;
                isTalentECheckable = false;
            }
            else thisSubPlan.IsCheckAble = false;

            _res.CharacterPlanSubPlanList.Add(thisSubPlan);
        }

        // 天赋Q
        bool isTalentQCheckable = true;
        for (int l = startTalentQIndex; l < endTalentQIndex; l++)
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

    private void CalculateMaterial()
    {
        if (_res.IsAllComplete) return;
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
                    BackpackCharacterPlanInfoMaterial thisMaterial = new BackpackCharacterPlanInfoMaterial();
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

                    _res.CharacterPlanMaterialList.Add(thisMaterial);
                }
            }
        }
    }

    // 计算具体角色经验花费
    private int[] CalculateCharacterExp(int t)
    {
        int[] res = [0, 0, 0, 0]; // [摩拉，大经验书，中经验书，小经验书]
        int largeExpNum = _materialHaveNumMap.GetValueOrDefault(3020001, 0);
        int mediumExpNum = _materialHaveNumMap.GetValueOrDefault(3020002, 0);
        int smallExpNum = _materialHaveNumMap.GetValueOrDefault(3020003, 0);
        if (20000 * largeExpNum + 5000 * mediumExpNum + 1000 * smallExpNum >= t)
        {
            // 现有经验书足够，按照现有经验书数量进行分配
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
            // 尝试找回
            bool isNeedPutBack = true;
            while (isNeedPutBack)
            {
                isNeedPutBack = false;
                if (t + 20000 < 0 && res[1] > 0)
                {
                    isNeedPutBack = true;
                    res[1] -= 1;
                    t += 20000;
                    continue;
                }

                if (t + 5000 < 0 && res[2] > 0)
                {
                    isNeedPutBack = true;
                    res[2] -= 1;
                    t += 5000;
                    continue;
                }

                if (t + 1000 < 0 && res[3] > 0)
                {
                    isNeedPutBack = true;
                    res[3] -= 1;
                    t += 1000;
                }
            }
        }
        else
        {
            // 现有经验书不足，按照最小数量进行分配
            t -= 20000 * largeExpNum + 5000 * mediumExpNum + 1000 * smallExpNum;
            res[1] = t / 20000;
            t -= 20000 * res[1];
            res[2] = t / 5000;
            t -= 5000 * res[2];
            res[3] = t / 1000;
            t -= 1000 * res[3];
            if (t > 0) res[3]++;
            res[1] += largeExpNum;
            res[2] += mediumExpNum;
            res[3] += smallExpNum;
        }

        res[0] = 4000 * res[1] + 1000 * res[2] + 200 * res[3];
        return res;
    }
}