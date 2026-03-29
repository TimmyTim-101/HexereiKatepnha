using System.Collections.ObjectModel;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.ConfigModels;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.ModelsForViews.Calculator;

namespace HexereiKatepnha.Services.CalculatorService;

public class GoalSimulatorService
{
    private Dictionary<int, double> _materialNumMap;
    private Dictionary<int, int> _materialNeedMap = new();
    private List<int> _lackMaterialList = [];
    private Dictionary<int, int> _dungeonNumMap = new();
    private int _needResinNum;
    private List<int> _ignoreMaterial = new();
    private List<MaterialPairModel> _materialNeedNumList = new();
    private Dictionary<string, int> _planSubExpMap = new();

    public GoalSimulatorService(bool isAll)
    {
        foreach (MaterialModel m in AllEntities.AllMaterialCharacterAscension)
        {
            _ignoreMaterial.Add(m.Rid);
        }

        foreach (MaterialModel m in AllEntities.AllMaterialWeaponExp)
        {
            _ignoreMaterial.Add(m.Rid);
        }

        _ignoreMaterial.Add(3080000);

        _materialNumMap = AutoCalculateConstants.MaterialMap.Values.ToDictionary(m => m.Rid, m => (double)App.BackpackMaterialConfigManagerInstance!.GetMaterialNumber(m.Rid));
        foreach (int characterId in App.BackpackCharacterConfigManagerInstance!.Configuration.CharacterConfig.Keys)
        {
            SingleBackpackCharacterConfigModel thisConfig = App.BackpackCharacterConfigManagerInstance.Configuration.CharacterConfig[characterId];
            _planSubExpMap[characterId.ToString()] = thisConfig.SubExp;
        }

        foreach (string weaponId in App.BackpackWeaponConfigManagerInstance!.Configuration.WeaponConfigMap.Keys)
        {
            SingleBackpackWeaponConfigModel thisConfig = App.BackpackWeaponConfigManagerInstance.Configuration.WeaponConfigMap[weaponId];
            _planSubExpMap[weaponId] = thisConfig.SubExp;
        }

        MainSimulationProcess(isAll);
    }

    private void MainSimulationProcess(bool isAll)
    {
        SeparateTasks(isAll);
        Simulate();
    }

    private void SeparateTasks(bool isAll)
    {
        // 按照任务顺序分割材料和数量到MaterialNeedNumList
        foreach (string thisPlanId in App.CalculatorPlanSettingConfigManagerInstance!.Configuration.OrderList)
        {
            SingleCalculatorPlanConfigModel thisPlan = App.CalculatorPlanSettingConfigManagerInstance.Configuration.PlanMap[thisPlanId];
            int thisPlanType = thisPlan.Type;
            switch (thisPlanType)
            {
                case 1: SeparateOneCharacter(thisPlan); break;
                case 2: SeparateOneWeapon(thisPlan); break;
            }
        }

        if (isAll)
        {
            // todo 全拉满
        }
    }

    private void SeparateOneCharacter(SingleCalculatorPlanConfigModel characterPlan)
    {
        string thisPlanId = characterPlan.Id;
        int thisCharacterId = characterPlan.Rid;
        CharacterModel thisCharacter = AutoCalculateConstants.CharacterMap[thisCharacterId];
        SingleBackpackCharacterConfigModel thisCharacterConfig = App.BackpackCharacterConfigManagerInstance!.Configuration.CharacterConfig[thisCharacterId];
        // 等级
        Enumeration.Level startLevel = thisCharacterConfig.CharacterLevel;
        Enumeration.Level endLevel = thisCharacterConfig.CharacterLevelGoal;
        int startLevelIndex = SequenceConstants.AllLevels.IndexOf(startLevel);
        int endLevelIndex = SequenceConstants.AllLevels.IndexOf(endLevel);
        for (int l = startLevelIndex; l < endLevelIndex; l++)
        {
            List<MaterialPairModel> thisLevelMaterialList = thisCharacter.LevelUpMaterials[SequenceConstants.AllLevels[l]];
            if (thisLevelMaterialList.Count == 1 && thisLevelMaterialList[0].MaterialModel!.Rid == 3020001)
            {
                // 合并经验类任务 + SubExp
                MaterialPairModel mpm = new MaterialPairModel
                {
                    MaterialModel = thisLevelMaterialList[0].MaterialModel
                };
                int ll;
                for (ll = l; ll < endLevelIndex; ll++)
                {
                    List<MaterialPairModel> thisNextLevelMaterialList = thisCharacter.LevelUpMaterials[SequenceConstants.AllLevels[ll]];
                    if (!(thisNextLevelMaterialList.Count == 1 && thisNextLevelMaterialList[0].MaterialModel!.Rid == 3020001))
                    {
                        break;
                    }

                    mpm.DropNum += thisNextLevelMaterialList[0].DropNum;
                }

                l = ll - 1;
                mpm.DropNum -= _planSubExpMap.GetValueOrDefault(thisPlanId, 0);
                _planSubExpMap[thisPlanId] = 0;
                _materialNeedNumList.Add(mpm);
            }
            else
            {
                foreach (MaterialPairModel mpm in thisLevelMaterialList)
                {
                    _materialNeedNumList.Add(mpm);
                }
            }
        }

        // 天赋A
        Enumeration.Level startTalentALevel = thisCharacterConfig.TalentALevel;
        Enumeration.Level endTalentALevel = thisCharacterConfig.TalentALevelGoal;
        int startTalentALevelIndex = SequenceConstants.AllLevels.IndexOf(startTalentALevel);
        int endTalentALevelIndex = SequenceConstants.AllLevels.IndexOf(endTalentALevel);
        for (int l = startTalentALevelIndex; l < endTalentALevelIndex; l++)
        {
            List<MaterialPairModel> thisLevelMaterialList = thisCharacter.Talent1Materials[SequenceConstants.AllLevels[l]];
            foreach (MaterialPairModel mpm in thisLevelMaterialList)
            {
                _materialNeedNumList.Add(mpm);
            }
        }

        // 天赋E
        Enumeration.Level startTalentELevel = thisCharacterConfig.TalentELevel;
        Enumeration.Level endTalentELevel = thisCharacterConfig.TalentELevelGoal;
        int startTalentELevelIndex = SequenceConstants.AllLevels.IndexOf(startTalentELevel);
        int endTalentELevelIndex = SequenceConstants.AllLevels.IndexOf(endTalentELevel);
        for (int l = startTalentELevelIndex; l < endTalentELevelIndex; l++)
        {
            List<MaterialPairModel> thisLevelMaterialList = thisCharacter.Talent2Materials[SequenceConstants.AllLevels[l]];
            foreach (MaterialPairModel mpm in thisLevelMaterialList)
            {
                _materialNeedNumList.Add(mpm);
            }
        }

        // 天赋Q
        Enumeration.Level startTalentQLevel = thisCharacterConfig.TalentQLevel;
        Enumeration.Level endTalentQLevel = thisCharacterConfig.TalentQLevelGoal;
        int startTalentQLevelIndex = SequenceConstants.AllLevels.IndexOf(startTalentQLevel);
        int endTalentQLevelIndex = SequenceConstants.AllLevels.IndexOf(endTalentQLevel);
        for (int l = startTalentQLevelIndex; l < endTalentQLevelIndex; l++)
        {
            List<MaterialPairModel> thisLevelMaterialList = thisCharacter.Talent3Materials[SequenceConstants.AllLevels[l]];
            foreach (MaterialPairModel mpm in thisLevelMaterialList)
            {
                _materialNeedNumList.Add(mpm);
            }
        }
    }

    private void SeparateOneWeapon(SingleCalculatorPlanConfigModel weaponPlan)
    {
        string thisPlanId = weaponPlan.Id;
        int thisWeaponRid = weaponPlan.Rid;
        SingleBackpackWeaponConfigModel thisWeaponConfig = App.BackpackWeaponConfigManagerInstance!.Configuration.WeaponConfigMap[thisPlanId];
        Enumeration.Level startLevel = thisWeaponConfig.Level;
        Enumeration.Level endLevel = thisWeaponConfig.GoalLevel;
        int startLevelIndex = SequenceConstants.AllLevels.IndexOf(startLevel);
        int endLevelIndex = SequenceConstants.AllLevels.IndexOf(endLevel);
        WeaponModel thisWeapon = AutoCalculateConstants.WeaponMap[thisWeaponRid];
        for (int l = startLevelIndex; l < endLevelIndex; l++)
        {
            List<MaterialPairModel> thisLevelMaterialList = thisWeapon.LevelUpMaterials[SequenceConstants.AllLevels[l]];
            if (thisLevelMaterialList.Count == 1 && thisLevelMaterialList[0].MaterialModel!.Rid == 3110001)
            {
                // 合并经验类任务 + SubExp
                MaterialPairModel mpm = new MaterialPairModel
                {
                    MaterialModel = thisLevelMaterialList[0].MaterialModel
                };
                int ll;
                for (ll = l; ll < endLevelIndex; ll++)
                {
                    List<MaterialPairModel> thisNextLevelMaterialList = thisWeapon.LevelUpMaterials[SequenceConstants.AllLevels[ll]];
                    if (!(thisNextLevelMaterialList.Count == 1 && thisNextLevelMaterialList[0].MaterialModel!.Rid == 3110001))
                    {
                        break;
                    }

                    mpm.DropNum += thisNextLevelMaterialList[0].DropNum;
                }

                l = ll - 1;
                mpm.DropNum -= _planSubExpMap.GetValueOrDefault(thisPlanId, 0);
                _planSubExpMap[thisPlanId] = 0;
                _materialNeedNumList.Add(mpm);
            }
            else
            {
                foreach (MaterialPairModel mpm in thisLevelMaterialList)
                {
                    _materialNeedNumList.Add(mpm);
                }
            }
        }
    }

    private void Simulate()
    {
        foreach (MaterialPairModel mpm in _materialNeedNumList)
        {
            MaterialModel thisMaterial = (mpm.MaterialModel as MaterialModel)!;
            double needNum = mpm.DropNum;
            int thisMaterialRid = thisMaterial.Rid;
            if (thisMaterialRid == 3020001) SimulateForCharacterExp(needNum);
            else if (thisMaterialRid == 3110001) SimulateForWeaponExp(needNum);
            else SimulateForOneMaterial(thisMaterialRid, needNum);
        }
    }

    private void SimulateForCharacterExp(double num)
    {
        int largeExpNum = (int)_materialNumMap[3020001];
        int mediumExpNum = (int)_materialNumMap[3020002];
        int smallExpNum = (int)_materialNumMap[3020003];
        // 判断经验书是否够
        if (largeExpNum * 20000 + mediumExpNum * 5000 + smallExpNum * 1000 < num)
        {
            if (!_lackMaterialList.Contains(3020001))
            {
                _lackMaterialList.Add(3020001);
            }

            bool isSatisfy = false;
            while (!isSatisfy)
            {
                DungeonModel thisDungeon = AutoCalculateConstants.DungeonMap[AutoCalculateConstants.MaterialDungeonMap[3020001]];
                foreach (MaterialPairModel mpm in thisDungeon.DropMaterialList)
                {
                    int thisDropMaterialRid = mpm.MaterialModel!.Rid;
                    double thisDropNum = mpm.DropNum;
                    _materialNumMap[thisDropMaterialRid] += thisDropNum;
                }

                _needResinNum += thisDungeon.Cost;
                _dungeonNumMap[thisDungeon.Rid] = _dungeonNumMap.GetValueOrDefault(thisDungeon.Rid, 0) + 1;
                largeExpNum = (int)_materialNumMap[3020001];
                mediumExpNum = (int)_materialNumMap[3020002];
                smallExpNum = (int)_materialNumMap[3020003];
                isSatisfy = largeExpNum * 20000 + mediumExpNum * 5000 + smallExpNum * 1000 >= num;
            }
        }

        // 判断摩拉是否够
        int largeUseNum = Math.Min((int)_materialNumMap[3020001], (int)(num / 20000));
        num -= 20000 * largeUseNum;
        _materialNumMap[3020001] -= largeUseNum;
        int mediumUseNum = Math.Min((int)_materialNumMap[3020002], (int)(num / 5000));
        num -= 5000 * mediumUseNum;
        _materialNumMap[3020002] -= mediumUseNum;
        int smallUseNum = Math.Min((int)_materialNumMap[3020003], (int)(num / 1000));
        num -= 1000 * smallUseNum;
        _materialNumMap[3020003] -= smallUseNum;
        while (num > 0)
        {
            if ((int)_materialNumMap[3020003] > 0)
            {
                num -= 1000;
                _materialNumMap[3020003] -= 1;
                smallUseNum++;
                continue;
            }

            if ((int)_materialNumMap[3020002] > 0)
            {
                num -= 5000;
                _materialNumMap[3020002] -= 1;
                mediumUseNum++;
                continue;
            }

            if ((int)_materialNumMap[3020001] > 0)
            {
                num -= 20000;
                _materialNumMap[3020001] -= 1;
                largeUseNum++;
            }
        }

        int mora = largeUseNum * 4000 + mediumUseNum * 1000 + smallUseNum * 200;
        while (((int)_materialNumMap[3010001]) < mora)
        {
            if (!_lackMaterialList.Contains(3010001))
            {
                _lackMaterialList.Add(3010001);
            }

            DungeonModel thisDungeon = AutoCalculateConstants.DungeonMap[AutoCalculateConstants.MaterialDungeonMap[3010001]];
            foreach (MaterialPairModel mpm in thisDungeon.DropMaterialList)
            {
                int thisDropMaterialRid = mpm.MaterialModel!.Rid;
                double thisDropNum = mpm.DropNum;
                _materialNumMap[thisDropMaterialRid] += thisDropNum;
            }

            _needResinNum += thisDungeon.Cost;
            _dungeonNumMap[thisDungeon.Rid] = _dungeonNumMap.GetValueOrDefault(thisDungeon.Rid, 0) + 1;
        }

        // 实施升级
        _materialNumMap[3010001] -= mora;
        _materialNeedMap[3020001] = _materialNeedMap.GetValueOrDefault(3020001, 0) + largeUseNum;
        _materialNeedMap[3020002] = _materialNeedMap.GetValueOrDefault(3020002, 0) + largeUseNum;
        _materialNeedMap[3020003] = _materialNeedMap.GetValueOrDefault(3020003, 0) + largeUseNum;
    }

    private void SimulateForWeaponExp(double num)
    {
        int largeExpNum = (int)_materialNumMap[3110001];
        int mediumExpNum = (int)_materialNumMap[3110002];
        int smallExpNum = (int)_materialNumMap[3110003];
        // 判断经验矿是否够
        if (10000 * largeExpNum + 2000 * mediumExpNum + 400 * smallExpNum < num)
        {
            if (!_lackMaterialList.Contains(3110001))
            {
                _lackMaterialList.Add(3110001);
            }

            bool isSatisfy = false;
            while (!isSatisfy)
            {
                _materialNumMap[3110001] += 1;
                largeExpNum = (int)_materialNumMap[3110001];
                mediumExpNum = (int)_materialNumMap[3110002];
                smallExpNum = (int)_materialNumMap[3110003];
                isSatisfy = 10000 * largeExpNum + 2000 * mediumExpNum + 400 * smallExpNum >= num;
            }
        }

        // 判断摩拉是否够
        int largeUseNum = Math.Min((int)_materialNumMap[3110001], (int)(num / 10000));
        num -= 10000 * largeUseNum;
        _materialNumMap[3110001] -= largeUseNum;
        int mediumUseNum = Math.Min((int)_materialNumMap[3110002], (int)(num / 2000));
        num -= 2000 * mediumUseNum;
        _materialNumMap[3110002] -= mediumUseNum;
        int smallUseNum = Math.Min((int)_materialNumMap[3110003], (int)(num / 400));
        num -= 400 * smallUseNum;
        _materialNumMap[3110003] -= smallUseNum;
        while (num > 0)
        {
            if ((int)_materialNumMap[3110003] > 0)
            {
                num -= 400;
                _materialNumMap[3110003] -= 1;
                smallUseNum++;
                continue;
            }

            if ((int)_materialNumMap[3110002] > 0)
            {
                num -= 2000;
                _materialNumMap[3110002] -= 1;
                mediumUseNum++;
                continue;
            }

            if ((int)_materialNumMap[3110001] > 0)
            {
                num -= 10000;
                _materialNumMap[3110001] -= 1;
                largeUseNum++;
            }
        }

        int mora = largeUseNum * 1000 + mediumUseNum * 200 + smallUseNum * 40;
        while (((int)_materialNumMap[3010001]) < mora)
        {
            if (!_lackMaterialList.Contains(3010001))
            {
                _lackMaterialList.Add(3010001);
            }

            DungeonModel thisDungeon = AutoCalculateConstants.DungeonMap[AutoCalculateConstants.MaterialDungeonMap[3010001]];
            foreach (MaterialPairModel mpm in thisDungeon.DropMaterialList)
            {
                int thisDropMaterialRid = mpm.MaterialModel!.Rid;
                double thisDropNum = mpm.DropNum;
                _materialNumMap[thisDropMaterialRid] += thisDropNum;
            }

            _needResinNum += thisDungeon.Cost;
            _dungeonNumMap[thisDungeon.Rid] = _dungeonNumMap.GetValueOrDefault(thisDungeon.Rid, 0) + 1;
        }

        // 计算返还矿数
        int extraExp = (int)-num;
        int extraLargeNum = extraExp / 10000;
        extraExp -= extraLargeNum * 10000;
        int extraMediumNum = extraExp / 2000;
        extraExp -= extraMediumNum * 2000;
        int extraSmallNum = extraExp / 400;
        // 实施升级
        _materialNumMap[3110001] += extraLargeNum;
        _materialNumMap[3110002] += extraMediumNum;
        _materialNumMap[3110003] += extraSmallNum;
        _materialNumMap[3010001] -= mora;
        _materialNeedMap[3110001] = _materialNeedMap.GetValueOrDefault(3110001, 0) + largeUseNum;
        _materialNeedMap[3110002] = _materialNeedMap.GetValueOrDefault(3110002, 0) + largeUseNum;
        _materialNeedMap[3110003] = _materialNeedMap.GetValueOrDefault(3110003, 0) + largeUseNum;
        _materialNeedMap[3010001] = _materialNeedMap.GetValueOrDefault(3010001) + mora;
    }

    private void SimulateForOneMaterial(int materialRid, double num)
    {
        _materialNeedMap[materialRid] = _materialNeedMap.GetValueOrDefault(materialRid, 0) + (int)num;
        // 判定当前是否满足所需材料
        List<int> relativeMaterialList = [materialRid];
        while (AutoCalculateConstants.MaterialMergeRecipe.ContainsKey(relativeMaterialList[^1]))
        {
            relativeMaterialList.Add(AutoCalculateConstants.MaterialMergeRecipe[relativeMaterialList[^1]]);
        }

        int mergedNum = 0;
        for (int i = relativeMaterialList.Count - 1; i >= 0; i--)
        {
            mergedNum = (int)(mergedNum / 3.0);
            mergedNum += (int)_materialNumMap[relativeMaterialList[i]];
        }

        while (mergedNum < num)
        {
            // 记录缺的材料
            if (!_lackMaterialList.Contains(materialRid)) _lackMaterialList.Add(materialRid);
            // 尝试打相应秘境直到满足
            if (_ignoreMaterial.Contains(materialRid))
            {
                // 对于忽略的材料直接一个一个补充相应的材料
                _materialNumMap[relativeMaterialList[0]] += 1;
            }
            else
            {
                // 打相应的秘境
                DungeonModel thisDungeon = AutoCalculateConstants.DungeonMap[AutoCalculateConstants.MaterialDungeonMap[materialRid]];
                foreach (MaterialPairModel mpm in thisDungeon.DropMaterialList)
                {
                    int thisDropMaterialRid = mpm.MaterialModel!.Rid;
                    double thisDropNum = mpm.DropNum;
                    _materialNumMap[thisDropMaterialRid] += thisDropNum;
                }

                _needResinNum += thisDungeon.Cost;
                _dungeonNumMap[thisDungeon.Rid] = _dungeonNumMap.GetValueOrDefault(thisDungeon.Rid, 0) + 1;
            }

            // 更新可合成数量
            mergedNum = 0;
            for (int i = relativeMaterialList.Count - 1; i >= 0; i--)
            {
                mergedNum = (int)(mergedNum / 3.0);
                mergedNum += (int)_materialNumMap[relativeMaterialList[i]];
            }
        }

        // 现在满足了，扣掉所需材料并且进行下一项
        foreach (var m in relativeMaterialList)
        {
            int useNum = Math.Min((int)num, (int)_materialNumMap[m]);
            _materialNumMap[m] -= useNum;
            num -= useNum;
            num *= 3;
        }
    }

    public ObservableCollection<CalculatorPlanLackMaterialModel> GetAllLackMaterial()
    {
        ObservableCollection<CalculatorPlanLackMaterialModel> res = [];
        foreach (int materialRid in _lackMaterialList)
        {
            MaterialModel thisMaterial = AutoCalculateConstants.MaterialMap[materialRid];
            List<int> relativeMaterialList = [materialRid];
            while (AutoCalculateConstants.MaterialMergeRecipe.ContainsKey(relativeMaterialList[^1]))
            {
                relativeMaterialList.Add(AutoCalculateConstants.MaterialMergeRecipe[relativeMaterialList[^1]]);
            }

            int mergeNum = 0;
            for (int i = relativeMaterialList.Count - 1; i >= 0; i--)
            {
                mergeNum /= 3;
                mergeNum += App.BackpackMaterialConfigManagerInstance!.GetMaterialNumber(relativeMaterialList[i]);
            }

            double isAccessible = 1.0;
            if (!_ignoreMaterial.Contains(materialRid))
            {
                DateTimeOffset utcNow = DateTimeOffset.UtcNow;
                DateTimeOffset serverTime = utcNow.ToOffset(TimeSpan.FromHours(8));
                DateTimeOffset gameDayTime = serverTime.AddHours(-4);
                DayOfWeek gameDayOfWeek = gameDayTime.DayOfWeek;
                int dayNumber = (int)gameDayOfWeek;
                if (dayNumber == 0) dayNumber = 7;
                DungeonModel thisDungeon = AutoCalculateConstants.DungeonMap[AutoCalculateConstants.MaterialDungeonMap[materialRid]];
                int thisTime = thisDungeon.Time;
                switch (thisTime)
                {
                    case 1:
                        if (dayNumber != 1 && dayNumber != 4 && dayNumber != 7) isAccessible = 0.3;
                        break;
                    case 2:
                        if (dayNumber != 2 && dayNumber != 5 && dayNumber != 7) isAccessible = 0.3;
                        break;
                    case 3:
                        if (dayNumber != 3 && dayNumber != 6 && dayNumber != 7) isAccessible = 0.3;
                        break;
                }
            }

            CalculatorPlanLackMaterialModel thisModel = new()
            {
                Rid = materialRid,
                ImagePath = thisMaterial.ImagePath,
                BackgroundImagePath = StringConstants.StarBackgroundImagePath[thisMaterial.Star],
                Name = thisMaterial.Name,
                BackpackNum = App.BackpackMaterialConfigManagerInstance!.GetMaterialNumber(materialRid),
                MergeNum = mergeNum,
                NeedNum = _materialNeedMap.GetValueOrDefault(materialRid, 0),
                IsAccessible = isAccessible
            };
            res.Add(thisModel);
        }

        return res;
    }

    public ObservableCollection<CalculatorPlanBoss60Model> GetBoss60()
    {
        ObservableCollection<CalculatorPlanBoss60Model> res = [];
        foreach (DungeonModel thisDungeon in AllEntities.AllDungeonTrounce)
        {
            MaterialModel material1 = (thisDungeon.DropMaterialList[0].MaterialModel as MaterialModel)!;
            MaterialModel material2 = (thisDungeon.DropMaterialList[1].MaterialModel as MaterialModel)!;
            MaterialModel material3 = (thisDungeon.DropMaterialList[2].MaterialModel as MaterialModel)!;

            CalculatorPlanBoss60Model thisModel = new CalculatorPlanBoss60Model
            {
                ImagePath = thisDungeon.ImagePath,
                Name = thisDungeon.Name,
                NeedNum1 = _materialNeedMap.GetValueOrDefault(material1.Rid, 0),
                HaveNum1 = App.BackpackMaterialConfigManagerInstance!.GetMaterialNumber(material1.Rid),
                NeedNum2 = _materialNeedMap.GetValueOrDefault(material2.Rid, 0),
                HaveNum2 = App.BackpackMaterialConfigManagerInstance.GetMaterialNumber(material2.Rid),
                NeedNum3 = _materialNeedMap.GetValueOrDefault(material3.Rid, 0),
                HaveNum3 = App.BackpackMaterialConfigManagerInstance.GetMaterialNumber(material3.Rid)
            };
            thisModel.Sort = thisModel.HaveNum1 + thisModel.HaveNum2 + thisModel.HaveNum3 - thisModel.NeedNum1 - thisModel.NeedNum2 - thisModel.NeedNum3;
            thisModel.Info = thisModel.Sort >= 0 ? "佛系" : "要打";
            thisModel.Color = thisModel.Sort >= 0 ? "#12B981" : "#FB7185";
            res.Add(thisModel);
        }

        return new ObservableCollection<CalculatorPlanBoss60Model>(res.OrderBy(m => m.Sort));
    }
}