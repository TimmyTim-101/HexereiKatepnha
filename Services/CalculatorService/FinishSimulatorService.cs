using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.ConfigModels;
using HexereiKatepnha.Models.EntityModels;

namespace HexereiKatepnha.Services.CalculatorService;

public class FinishSimulatorService
{
    public Dictionary<int, double> MaterialNumMap;
    public Dictionary<int, double> MaterialNeedMap = new();
    public List<int> LackMaterialList = [];
    public Dictionary<int, int> DungeonNumMap = new();
    public int NeedResinNum;
    public List<int> IgnoreMaterial = new();

    public FinishSimulatorService(bool isAll)
    {
        foreach (MaterialModel m in AllEntities.AllMaterialCharacterAscension)
        {
            IgnoreMaterial.Add(m.Rid);
        }

        foreach (MaterialModel m in AllEntities.AllMaterialWeaponExp)
        {
            IgnoreMaterial.Add(m.Rid);
        }

        IgnoreMaterial.Add(3080000);

        MaterialNumMap = AutoCalculateConstants.MaterialMap.Values.ToDictionary(m => m.Rid, m => (double)App.BackpackMaterialConfigManagerInstance!.GetMaterialNumber(m.Rid));
        Simulation(isAll);
    }

    private void Simulation(bool isAll)
    {
        foreach (string thisPlanId in App.CalculatorPlanSettingConfigManagerInstance!.Configuration.OrderList)
        {
            SingleCalculatorPlanConfigModel thisPlan = App.CalculatorPlanSettingConfigManagerInstance.Configuration.PlanMap[thisPlanId];
            int thisPlanType = thisPlan.Type;
            switch (thisPlanType)
            {
                case 1: SimulateOneCharacter(thisPlan); break;
                case 2: SimulateOneWeapon(thisPlan); break;
            }
        }

        if (isAll) SimulateToAll();
    }

    private void SimulateOneCharacter(SingleCalculatorPlanConfigModel thisCharacterPlan)
    {
        int thisCharacterRid = thisCharacterPlan.Rid;
        CharacterModel thisCharacter = AutoCalculateConstants.CharacterMap[thisCharacterRid];
        SingleBackpackCharacterConfigModel thisCharacterConfig = App.BackpackCharacterConfigManagerInstance!.Configuration.CharacterConfig[thisCharacterRid];
        Enumeration.Level startCharacterLevel = thisCharacterConfig.CharacterLevel;
        Enumeration.Level endCharacterLevel = thisCharacterConfig.CharacterLevelGoal;
        int startCharacterLevelIndex = SequenceConstants.AllLevels.IndexOf(startCharacterLevel);
        int endCharacterLevelIndex = SequenceConstants.AllLevels.IndexOf(endCharacterLevel);
        for (int l = startCharacterLevelIndex; l < endCharacterLevelIndex; l++)
        {
            List<MaterialPairModel> thisLevelMaterialList = thisCharacter.LevelUpMaterials[SequenceConstants.AllLevels[l]];
            SimulateOnSetMaterial(thisLevelMaterialList);
        }

        Enumeration.Level startTalentALevel = thisCharacterConfig.TalentALevel;
        Enumeration.Level endTalentALevel = thisCharacterConfig.TalentALevelGoal;
        int startTalentALevelIndex = SequenceConstants.AllLevels.IndexOf(startTalentALevel);
        int endTalentALevelIndex = SequenceConstants.AllLevels.IndexOf(endTalentALevel);
        for (int l = startTalentALevelIndex; l < endTalentALevelIndex; l++)
        {
            List<MaterialPairModel> thisLevelMaterialList = thisCharacter.Talent1Materials[SequenceConstants.AllLevels[l]];
            SimulateOnSetMaterial(thisLevelMaterialList);
        }

        Enumeration.Level startTalentELevel = thisCharacterConfig.TalentELevel;
        Enumeration.Level endTalentELevel = thisCharacterConfig.TalentELevelGoal;
        int startTalentELevelIndex = SequenceConstants.AllLevels.IndexOf(startTalentELevel);
        int endTalentELevelIndex = SequenceConstants.AllLevels.IndexOf(endTalentELevel);
        for (int l = startTalentELevelIndex; l < endTalentELevelIndex; l++)
        {
            List<MaterialPairModel> thisLevelMaterialList = thisCharacter.Talent2Materials[SequenceConstants.AllLevels[l]];
            SimulateOnSetMaterial(thisLevelMaterialList);
        }

        Enumeration.Level startTalentQLevel = thisCharacterConfig.TalentQLevel;
        Enumeration.Level endTalentQLevel = thisCharacterConfig.TalentQLevelGoal;
        int startTalentQLevelIndex = SequenceConstants.AllLevels.IndexOf(startTalentQLevel);
        int endTalentQLevelIndex = SequenceConstants.AllLevels.IndexOf(endTalentQLevel);
        for (int l = startTalentQLevelIndex; l < endTalentQLevelIndex; l++)
        {
            List<MaterialPairModel> thisLevelMaterialList = thisCharacter.Talent3Materials[SequenceConstants.AllLevels[l]];
            SimulateOnSetMaterial(thisLevelMaterialList);
        }
    }

    private void SimulateOneWeapon(SingleCalculatorPlanConfigModel thisWeaponPlan)
    {
        string thisWeaponId = thisWeaponPlan.Id;
        int thisWeaponRid = thisWeaponPlan.Rid;
        SingleBackpackWeaponConfigModel thisWeaponConfig = App.BackpackWeaponConfigManagerInstance!.Configuration.WeaponConfigMap[thisWeaponId];
        Enumeration.Level startLevel = thisWeaponConfig.Level;
        Enumeration.Level endLevel = thisWeaponConfig.GoalLevel;
        int startLevelIndex = SequenceConstants.AllLevels.IndexOf(startLevel);
        int endLevelIndex = SequenceConstants.AllLevels.IndexOf(endLevel);
        WeaponModel thisWeapon = AutoCalculateConstants.WeaponMap[thisWeaponRid];
        for (int l = startLevelIndex; l < endLevelIndex; l++)
        {
            List<MaterialPairModel> thisLevelMaterialList = thisWeapon.LevelUpMaterials[SequenceConstants.AllLevels[l]];
            SimulateOnSetMaterial(thisLevelMaterialList);
        }
    }

    private void SimulateOnSetMaterial(List<MaterialPairModel> l)
    {
        foreach (MaterialPairModel m in l)
        {
            MaterialModel thisMaterial = (m.MaterialModel as MaterialModel)!;
            double needNum = m.DropNum;
            SimulateOneMaterial(thisMaterial, needNum);
        }
    }

    private void SimulateOneMaterial(MaterialModel m, double n)
    {
        if (m == MaterialConstants._3020001)
        {
            SpecialTreatForCharacterExp(n);
            return;
        }

        if (m == MaterialConstants._3110001)
        {
            SpecialTreatForWeaponExp(n);
            return;
        }

        int thisMaterialId = m.Rid;
        MaterialNeedMap[thisMaterialId] = MaterialNeedMap.ContainsKey(thisMaterialId) ? MaterialNeedMap[thisMaterialId] + n : n;
        List<int> relativeMaterialList = [thisMaterialId];
        while (AutoCalculateConstants.MaterialMergeRecipe.ContainsKey(relativeMaterialList[^1]))
        {
            relativeMaterialList.Add(AutoCalculateConstants.MaterialMergeRecipe[relativeMaterialList[^1]]);
        }

        List<double> relativeMaterialNum = [];
        for (int i = 0; i < relativeMaterialList.Count; i++)
        {
            relativeMaterialNum.Add(MaterialNumMap[relativeMaterialList[i]]);
        }

        double sumNum = 0;
        for (int i = 0; i < relativeMaterialList.Count; i++) sumNum += ((int)relativeMaterialNum[i]) / (Math.Pow(3, i));
        if (sumNum < n)
        {
            // 当前库存不足
            // 记录不足的材料
            if (!LackMaterialList.Contains(thisMaterialId)) LackMaterialList.Add(thisMaterialId);
            // 尝试获取直到满足
            if (!IgnoreMaterial.Contains(thisMaterialId)) // 忽略粒儿片儿块儿钻儿 + 武器经验矿
            {
                bool isSatisfy = false;
                while (!isSatisfy)
                {
                    // 打一次相应秘境
                    DungeonModel thisDungeon = AutoCalculateConstants.DungeonMap[AutoCalculateConstants.MaterialDungeonMap[thisMaterialId]];
                    foreach (MaterialPairModel mp in thisDungeon.DropMaterialList)
                    {
                        int thisDropMaterialId = mp.MaterialModel!.Rid;
                        MaterialNumMap[thisDropMaterialId] += mp.DropNum;
                        if (relativeMaterialList.Contains(thisDropMaterialId))
                        {
                            relativeMaterialNum[relativeMaterialList.IndexOf(thisDropMaterialId)] += mp.DropNum;
                        }
                    }

                    DungeonNumMap[thisDungeon.Rid] = DungeonNumMap.ContainsKey(thisDungeon.Rid) ? DungeonNumMap[thisDungeon.Rid] + 1 : 1;
                    NeedResinNum += thisDungeon.Cost;
                    sumNum = 0;
                    for (int i = 0; i < relativeMaterialList.Count; i++) sumNum += ((int)relativeMaterialNum[i]) / (Math.Pow(3, i));
                    isSatisfy = sumNum >= n;
                }
            }
        }

        // 模拟使用
        for (int i = 0; i < relativeMaterialList.Count; i++)
        {
            double actualSpend = Math.Min(n, (int)MaterialNumMap[relativeMaterialList[i]]);
            MaterialNumMap[relativeMaterialList[i]] -= actualSpend;
            n -= actualSpend;
            n *= 3;
        }
    }

    private void SpecialTreatForCharacterExp(double n)
    {
        // 角色经验单独处理
        double largeExpNum = MaterialNumMap[3020001];
        double mediumExpNum = MaterialNumMap[3020002];
        double smallExpNum = MaterialNumMap[3020003];
        if (20000 * (int)largeExpNum + 5000 * (int)mediumExpNum + 1000 * (int)smallExpNum < n)
        {
            if (!LackMaterialList.Contains(3020001))
            {
                LackMaterialList.Add(3020001);
            }

            bool isSatisfy = false;
            while (!isSatisfy)
            {
                DungeonModel thisDungeon = AutoCalculateConstants.DungeonMap[AutoCalculateConstants.MaterialDungeonMap[3020001]];
                foreach (MaterialPairModel mp in thisDungeon.DropMaterialList)
                {
                    int thisDropMaterialId = mp.MaterialModel!.Rid;
                    MaterialNumMap[thisDropMaterialId] += mp.DropNum;
                }

                largeExpNum = MaterialNumMap[3020001];
                mediumExpNum = MaterialNumMap[3020002];
                smallExpNum = MaterialNumMap[3020003];
                DungeonNumMap[thisDungeon.Rid] = DungeonNumMap.ContainsKey(thisDungeon.Rid) ? DungeonNumMap[thisDungeon.Rid] + 1 : 1;
                NeedResinNum += thisDungeon.Cost;
                isSatisfy = 20000 * (int)largeExpNum + 5000 * (int)mediumExpNum + 1000 * (int)smallExpNum >= n;
            }
        }

        int largeUseNum = Math.Min((int)largeExpNum, (int)Math.Floor(n / 20000));
        n -= largeUseNum * 20000;
        largeExpNum -= largeUseNum;
        int mediumUseNum = Math.Min((int)mediumExpNum, (int)Math.Floor(n / 5000));
        n -= mediumUseNum * 5000;
        mediumExpNum -= mediumUseNum;
        int smallUseNum = Math.Min((int)smallExpNum, (int)Math.Floor(n / 1000));
        n -= smallUseNum * 1000;
        smallExpNum -= smallUseNum;
        while (n > 0)
        {
            if (smallExpNum > 0)
            {
                n -= 1000;
                smallExpNum--;
                smallUseNum++;
                continue;
            }

            if (mediumExpNum > 0)
            {
                n -= 5000;
                mediumExpNum--;
                mediumUseNum++;
                continue;
            }

            if (largeExpNum > 0)
            {
                n -= 20000;
                largeExpNum--;
                largeUseNum++;
            }
        }

        MaterialNumMap[3020001] -= largeUseNum;
        MaterialNumMap[3020002] -= mediumUseNum;
        MaterialNumMap[3020003] -= smallUseNum;
    }

    private void SpecialTreatForWeaponExp(double n)
    {
        // 武器经验单独处理
        double largeExpNum = MaterialNumMap[3110001];
        double mediumExpNum = MaterialNumMap[3110002];
        double smallExpNum = MaterialNumMap[3110003];
        if (10000 * (int)largeExpNum + 2000 * (int)mediumExpNum + 400 * (int)smallExpNum < n)
        {
            if (!LackMaterialList.Contains(3110001))
            {
                LackMaterialList.Add(3110001);
            }

            bool isSatisfy = false;
            while (!isSatisfy)
            {
                MaterialNumMap[3110001] += 1;
                largeExpNum = MaterialNumMap[3110001];
                mediumExpNum = MaterialNumMap[3110002];
                smallExpNum = MaterialNumMap[3110003];
                isSatisfy = 10000 * (int)largeExpNum + 2000 * (int)mediumExpNum + 400 * (int)smallExpNum >= n;
            }
        }

        int largeUseNum = Math.Min((int)largeExpNum, (int)Math.Floor(n / 10000));
        n -= largeUseNum * 10000;
        largeExpNum -= largeUseNum;
        int mediumUseNum = Math.Min((int)mediumExpNum, (int)Math.Floor(n / 2000));
        n -= mediumUseNum * 2000;
        mediumExpNum -= mediumUseNum;
        int smallUseNum = Math.Min((int)smallExpNum, (int)Math.Floor(n / 400));
        n -= smallUseNum * 400;
        smallExpNum -= smallUseNum;
        while (n > 0)
        {
            if (smallExpNum > 0)
            {
                n -= 400;
                smallExpNum--;
                smallUseNum++;
                continue;
            }

            if (mediumExpNum > 0)
            {
                n -= 2000;
                mediumExpNum--;
                mediumUseNum++;
                continue;
            }

            if (largeExpNum > 0)
            {
                n -= 10000;
                largeExpNum--;
                largeUseNum++;
            }
        }

        MaterialNumMap[3110001] -= largeUseNum;
        MaterialNumMap[3110002] -= mediumUseNum;
        MaterialNumMap[3110003] -= smallUseNum;
    }

    private void SimulateToAll()
    {
        // todo 对所有角色
        // todo 对所有武器
    }
}