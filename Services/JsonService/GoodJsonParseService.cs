using System.Diagnostics;
using System.Text.Json;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.ConfigModels;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.Good;

namespace HexereiKatepnha.Services.JsonService;

public class GoodJsonParseService
{
    private string _jsonFilePath;
    private string _jsonString = "{}";
    private int _status = 1;
    private string _errorMessage = "未知错误";
    private GoodModel _goodModel = new();

    private List<string> _oldOrderList = [];
    private Dictionary<string, SingleCalculatorPlanConfigModel> _oldPlanMap = new();
    private Dictionary<int, SingleBackpackCharacterConfigModel> _oldCharacterConfigMap = new();
    private Dictionary<string, SingleBackpackWeaponConfigModel> _oldWeaponConfigMap = new();
    private Dictionary<string, string> _oldNewWeaponIdMap = new();

    public GoodJsonParseService(string filePath)
    {
        _jsonFilePath = filePath;
        try
        {
            _jsonString = System.IO.File.ReadAllText(filePath);
            ParseMainProcess();
        }
        catch (Exception e)
        {
            _status = 0;
            _errorMessage = e.Message;
        }
    }

    private void ParseMainProcess()
    {
        SaveOldPlan();
        ParseJsonStringToObject();
        BuildInnerObject();
        GiveValueToConfigs();
        Restart();
    }

    private void SaveOldPlan()
    {
        // 对于历史规划做保留
        _oldOrderList = new List<string>(App.CalculatorPlanSettingConfigManagerInstance!.Configuration.OrderList);
        _oldPlanMap = new Dictionary<string, SingleCalculatorPlanConfigModel>(App.CalculatorPlanSettingConfigManagerInstance.Configuration.PlanMap);
        foreach (SingleCalculatorPlanConfigModel scpcm in _oldPlanMap.Values)
        {
            int thisType = scpcm.Type;
            switch (thisType)
            {
                case 1:
                    int thisCharacterRid = scpcm.Rid;
                    SingleBackpackCharacterConfigModel oldCharacterConfig = App.BackpackCharacterConfigManagerInstance!.GetBackpackCharacterConfig(thisCharacterRid);
                    SingleBackpackCharacterConfigModel thisCharacterConfig = new();
                    thisCharacterConfig.CharacterLevel = oldCharacterConfig.CharacterLevel;
                    thisCharacterConfig.TalentALevel = oldCharacterConfig.TalentALevel;
                    thisCharacterConfig.TalentELevel = oldCharacterConfig.TalentELevel;
                    thisCharacterConfig.TalentQLevel = oldCharacterConfig.TalentQLevel;
                    thisCharacterConfig.Ascension = oldCharacterConfig.Ascension;
                    thisCharacterConfig.CharacterLevelGoal = oldCharacterConfig.CharacterLevelGoal;
                    thisCharacterConfig.TalentALevelGoal = oldCharacterConfig.TalentALevelGoal;
                    thisCharacterConfig.TalentELevelGoal = oldCharacterConfig.TalentELevelGoal;
                    thisCharacterConfig.TalentQLevelGoal = oldCharacterConfig.TalentQLevelGoal;
                    thisCharacterConfig.WeaponId = oldCharacterConfig.WeaponId;
                    thisCharacterConfig.SubExp = oldCharacterConfig.SubExp;
                    _oldCharacterConfigMap[thisCharacterRid] = thisCharacterConfig;
                    break;
                case 2:
                    string thisWeaponId = scpcm.Id;
                    SingleBackpackWeaponConfigModel oldWeaponConfig = App.BackpackWeaponConfigManagerInstance!.Configuration.WeaponConfigMap[thisWeaponId];
                    SingleBackpackWeaponConfigModel thisWeaponConfig = new();
                    thisWeaponConfig.Id = oldWeaponConfig.Id;
                    thisWeaponConfig.Rid = oldWeaponConfig.Rid;
                    thisWeaponConfig.Progression = oldWeaponConfig.Progression;
                    thisWeaponConfig.Level = oldWeaponConfig.Level;
                    thisWeaponConfig.GoalLevel = oldWeaponConfig.GoalLevel;
                    thisWeaponConfig.CharacterRid = oldWeaponConfig.CharacterRid;
                    thisWeaponConfig.SubExp = oldWeaponConfig.SubExp;
                    _oldWeaponConfigMap[thisWeaponId] = thisWeaponConfig;
                    break;
            }
        }
    }

    private void ParseJsonStringToObject()
    {
        // 将json字符串转换为GOOD对象
        _goodModel = JsonSerializer.Deserialize<GoodModel>(_jsonString)!;
        // Console.WriteLine(_goodModel.format);
    }

    private void BuildInnerObject()
    {
        // 将GOOD对象转化为内部对象
        BuildMaterial();
        BuildCharacter();
        BuildWeapon();
        BuildPlan();
    }

    private void BuildMaterial()
    {
        foreach (List<MaterialModel> l in AllEntities.AllMaterialLists)
        {
            foreach (MaterialModel m in l)
            {
                string thisGoodKey = m.GoodKey;
                if (string.IsNullOrEmpty(thisGoodKey)) continue;
                if (_goodModel.materials.TryGetValue(thisGoodKey, out int materialNum))
                {
                    App.BackpackMaterialConfigManagerInstance!.Configuration.MaterialNumberMap[m.Rid] = materialNum;
                }
            }
        }
    }

    private void BuildCharacter()
    {
        App.BackpackCharacterConfigManagerInstance!.Configuration.CharacterConfig.Clear();
        Dictionary<string, CharacterModel> characterGoodKeyModelMap = AllEntities.AllCharacter.ToDictionary(m => m.GoodKey, m => m);
        foreach (GoodCharacter goodCharacter in _goodModel.characters)
        {
            string thisKey = goodCharacter.key;
            if (characterGoodKeyModelMap.TryGetValue(thisKey, out var thisCharacterModel))
            {
                SingleBackpackCharacterConfigModel thisConfig = new SingleBackpackCharacterConfigModel();
                thisConfig.CharacterLevel = GetLevel(goodCharacter.level, goodCharacter.ascension);
                thisConfig.TalentALevel = GetLevel(goodCharacter.talent.auto, 0);
                thisConfig.TalentELevel = GetLevel(goodCharacter.talent.skill, 0);
                thisConfig.TalentQLevel = GetLevel(goodCharacter.talent.burst, 0);
                thisConfig.Ascension = goodCharacter.constellation;
                thisConfig.CharacterLevelGoal = GetLevel(goodCharacter.level, goodCharacter.ascension);
                thisConfig.TalentALevelGoal = GetLevel(goodCharacter.talent.auto, 0);
                thisConfig.TalentELevelGoal = GetLevel(goodCharacter.talent.skill, 0);
                thisConfig.TalentQLevelGoal = GetLevel(goodCharacter.talent.burst, 0);
                thisConfig.WeaponId = "";
                thisConfig.SubExp = 0;
                App.BackpackCharacterConfigManagerInstance.Configuration.CharacterConfig[thisCharacterModel.Rid] = thisConfig;
            }
        }
    }

    private void BuildWeapon()
    {
        App.BackpackWeaponConfigManagerInstance!.Configuration.WeaponConfigMap.Clear();
        Dictionary<string, CharacterModel> characterGoodKeyModelMap = AllEntities.AllCharacter.ToDictionary(m => m.GoodKey, m => m);
        Dictionary<string, WeaponModel> weaponGoodKeyModelMap = AllEntities.AllWeapon.ToDictionary(m => m.GoodKey, m => m);
        foreach (GoodWeapon goodWeapon in _goodModel.weapons)
        {
            string thisKey = goodWeapon.key;
            if (weaponGoodKeyModelMap.ContainsKey(thisKey))
            {
                WeaponModel thisWeaponModel = weaponGoodKeyModelMap[thisKey];
                SingleBackpackWeaponConfigModel thisConfig = new SingleBackpackWeaponConfigModel();
                string randomUniqueSign = Guid.NewGuid().ToString("N");
                string thisWeaponId = $"{thisWeaponModel.Rid}${randomUniqueSign}";
                thisConfig.Id = thisWeaponId;
                thisConfig.Rid = thisWeaponModel.Rid;
                thisConfig.Progression = goodWeapon.refinement;
                thisConfig.Level = GetLevel(goodWeapon.level, goodWeapon.ascension);
                thisConfig.GoalLevel = GetLevel(goodWeapon.level, goodWeapon.ascension);
                thisConfig.SubExp = 0;
                string thisCharacterGoodKey = goodWeapon.location;
                if (!string.IsNullOrEmpty(thisCharacterGoodKey))
                {
                    if (characterGoodKeyModelMap.ContainsKey(thisCharacterGoodKey))
                    {
                        int thisCharacterRid = characterGoodKeyModelMap[thisCharacterGoodKey].Rid;
                        thisConfig.CharacterRid = thisCharacterRid;
                        App.BackpackCharacterConfigManagerInstance!.Configuration.CharacterConfig[thisCharacterRid].WeaponId = thisWeaponId;
                    }
                }

                App.BackpackWeaponConfigManagerInstance.Configuration.WeaponConfigMap[thisConfig.Id] = thisConfig;
            }
        }
    }

    private void BuildPlan()
    {
        App.CalculatorPlanSettingConfigManagerInstance!.Configuration.OrderList.Clear();
        App.CalculatorPlanSettingConfigManagerInstance.Configuration.PlanMap.Clear();
        // 处理角色
        foreach (int thisCharacterRid in _oldCharacterConfigMap.Keys)
        {
            SingleBackpackCharacterConfigModel thisCharacterOldConfig = _oldCharacterConfigMap[thisCharacterRid];
            if (!App.BackpackCharacterConfigManagerInstance!.Configuration.CharacterConfig.ContainsKey(thisCharacterRid))
            {
                App.BackpackCharacterConfigManagerInstance.Configuration.CharacterConfig[thisCharacterRid] = new SingleBackpackCharacterConfigModel();
            }

            SingleBackpackCharacterConfigModel thisCharacterNewConfig = App.BackpackCharacterConfigManagerInstance.GetBackpackCharacterConfig(thisCharacterRid);
            int oldGoalLevelIndex = SequenceConstants.AllLevels.IndexOf(thisCharacterOldConfig.CharacterLevelGoal);
            int newGoalLevelIndex = SequenceConstants.AllLevels.IndexOf(thisCharacterNewConfig.CharacterLevelGoal);
            if (newGoalLevelIndex < oldGoalLevelIndex) thisCharacterNewConfig.CharacterLevelGoal = thisCharacterOldConfig.CharacterLevelGoal;
            int oldGoalTalentAIndex = SequenceConstants.AllLevels.IndexOf(thisCharacterOldConfig.TalentALevelGoal);
            int newGoalTalentAIndex = SequenceConstants.AllLevels.IndexOf(thisCharacterNewConfig.TalentALevelGoal);
            if (newGoalTalentAIndex < oldGoalTalentAIndex) thisCharacterNewConfig.TalentALevelGoal = thisCharacterOldConfig.TalentALevelGoal;
            int oldGoalTalentEIndex = SequenceConstants.AllLevels.IndexOf(thisCharacterOldConfig.TalentELevelGoal);
            int newGoalTalentEIndex = SequenceConstants.AllLevels.IndexOf(thisCharacterNewConfig.TalentELevelGoal);
            if (newGoalTalentEIndex < oldGoalTalentEIndex) thisCharacterNewConfig.TalentELevelGoal = thisCharacterOldConfig.TalentELevelGoal;
            int oldGoalTalentQIndex = SequenceConstants.AllLevels.IndexOf(thisCharacterOldConfig.TalentQLevelGoal);
            int newGoalTalentQIndex = SequenceConstants.AllLevels.IndexOf(thisCharacterNewConfig.TalentQLevelGoal);
            if (newGoalTalentQIndex < oldGoalTalentQIndex) thisCharacterNewConfig.TalentQLevelGoal = thisCharacterOldConfig.TalentQLevelGoal;
        }

        // 处理武器
        foreach (SingleBackpackWeaponConfigModel sbwcm in _oldWeaponConfigMap.Values)
        {
            string newWeaponId = "";
            foreach (SingleBackpackWeaponConfigModel sbwcm2 in App.BackpackWeaponConfigManagerInstance!.Configuration.WeaponConfigMap.Values)
            {
                bool isRid = sbwcm.Rid == sbwcm2.Rid;
                bool isProgression = sbwcm.Progression == sbwcm2.Progression;
                bool isLevel = sbwcm.Level == sbwcm2.Level;
                bool isCharacterId = sbwcm.CharacterRid == sbwcm2.CharacterRid;
                bool isAvailable = !_oldNewWeaponIdMap.Values.Contains(sbwcm2.Id);
                if (isRid && isProgression && isLevel && isCharacterId && isAvailable)
                {
                    newWeaponId = sbwcm2.Id;
                    break;
                }
            }

            if (newWeaponId != "")
            {
                SingleBackpackWeaponConfigModel thisWeaponNewConfig = App.BackpackWeaponConfigManagerInstance.Configuration.WeaponConfigMap[newWeaponId];
                _oldNewWeaponIdMap[sbwcm.Id] = newWeaponId;
                int oldGoalLevelIndex = SequenceConstants.AllLevels.IndexOf(sbwcm.GoalLevel);
                int newGoalLevelIndex = SequenceConstants.AllLevels.IndexOf(thisWeaponNewConfig.GoalLevel);
                if (newGoalLevelIndex < oldGoalLevelIndex) thisWeaponNewConfig.GoalLevel = sbwcm.GoalLevel;
            }
        }

        // 按顺序填入内部数据结构中
        foreach (string oldPlanId in _oldOrderList)
        {
            SingleCalculatorPlanConfigModel thisPlan = _oldPlanMap[oldPlanId];
            int thisPlanType = thisPlan.Type;
            switch (thisPlanType)
            {
                case 1:
                    int thisCharacterRid = thisPlan.Rid;
                    SingleBackpackCharacterConfigModel thisCharacterConfig = App.BackpackCharacterConfigManagerInstance!.Configuration.CharacterConfig[thisCharacterRid];
                    bool isCharacterLevel = thisCharacterConfig.CharacterLevel != thisCharacterConfig.CharacterLevelGoal;
                    bool isTalentA = thisCharacterConfig.TalentALevel != thisCharacterConfig.TalentALevelGoal;
                    bool isTalentE = thisCharacterConfig.TalentELevel != thisCharacterConfig.TalentELevelGoal;
                    bool isTalentQ = thisCharacterConfig.TalentQLevel != thisCharacterConfig.TalentQLevelGoal;
                    if (isCharacterLevel || isTalentA || isTalentE || isTalentQ)
                    {
                        SingleCalculatorPlanConfigModel newPlan = new SingleCalculatorPlanConfigModel();
                        newPlan.Id = thisCharacterRid.ToString();
                        newPlan.Type = 1;
                        newPlan.Rid = thisCharacterRid;
                        App.CalculatorPlanSettingConfigManagerInstance.Configuration.OrderList.Add(newPlan.Id);
                        App.CalculatorPlanSettingConfigManagerInstance.Configuration.PlanMap[newPlan.Id] = newPlan;
                    }

                    break;
                case 2:
                    string thisOldWeaponId = thisPlan.Id;
                    if (_oldNewWeaponIdMap.TryGetValue(thisOldWeaponId, out string? thisNewWeaponId))
                    {
                        SingleBackpackWeaponConfigModel thisWeaponConfig = App.BackpackWeaponConfigManagerInstance!.Configuration.WeaponConfigMap[thisNewWeaponId];
                        bool isWeaponLevel = thisWeaponConfig.Level != thisWeaponConfig.GoalLevel;
                        if (isWeaponLevel)
                        {
                            SingleCalculatorPlanConfigModel newPlan = new SingleCalculatorPlanConfigModel();
                            newPlan.Id = thisNewWeaponId;
                            newPlan.Type = 2;
                            newPlan.Rid = thisWeaponConfig.Rid;
                            App.CalculatorPlanSettingConfigManagerInstance.Configuration.OrderList.Add(newPlan.Id);
                            App.CalculatorPlanSettingConfigManagerInstance.Configuration.PlanMap[newPlan.Id] = newPlan;
                        }
                    }

                    break;
            }
        }
    }

    private void GiveValueToConfigs()
    {
        // 根据内部对象值保存到config文件
        App.BackpackMaterialConfigManagerInstance!.Save();
        App.BackpackCharacterConfigManagerInstance!.Save();
        App.BackpackWeaponConfigManagerInstance!.Save();
        App.CalculatorPlanSettingConfigManagerInstance!.Save();
    }

    private void Restart()
    {
        // 很懒，不想一个一个页面重写刷新，直接重启得了
        string? currentAppPath = Environment.ProcessPath;
        if (!string.IsNullOrEmpty(currentAppPath))
        {
            Process.Start(currentAppPath);
            Environment.Exit(0);
        }
    }

    public int GetResult()
    {
        return _status;
    }

    public string GetErrorMessage()
    {
        return _errorMessage;
    }

    public string GetFileName()
    {
        return System.IO.Path.GetFileName(_jsonFilePath);
    }

    private static Enumeration.Level GetLevel(int l, int a)
    {
        switch (l)
        {
            case 1: return Enumeration.Level.L1;
            case 2: return Enumeration.Level.L2;
            case 3: return Enumeration.Level.L3;
            case 4: return Enumeration.Level.L4;
            case 5: return Enumeration.Level.L5;
            case 6: return Enumeration.Level.L6;
            case 7: return Enumeration.Level.L7;
            case 8: return Enumeration.Level.L8;
            case 9: return Enumeration.Level.L9;
            case 10: return Enumeration.Level.L10;
            case 11: return Enumeration.Level.L11;
            case 12: return Enumeration.Level.L12;
            case 13: return Enumeration.Level.L13;
            case 14: return Enumeration.Level.L14;
            case 15: return Enumeration.Level.L15;
            case 16: return Enumeration.Level.L16;
            case 17: return Enumeration.Level.L17;
            case 18: return Enumeration.Level.L18;
            case 19: return Enumeration.Level.L19;
            case 20: return a == 0 ? Enumeration.Level.L20 : Enumeration.Level.L20P;
            case 21: return Enumeration.Level.L21;
            case 22: return Enumeration.Level.L22;
            case 23: return Enumeration.Level.L23;
            case 24: return Enumeration.Level.L24;
            case 25: return Enumeration.Level.L25;
            case 26: return Enumeration.Level.L26;
            case 27: return Enumeration.Level.L27;
            case 28: return Enumeration.Level.L28;
            case 29: return Enumeration.Level.L29;
            case 30: return Enumeration.Level.L30;
            case 31: return Enumeration.Level.L31;
            case 32: return Enumeration.Level.L32;
            case 33: return Enumeration.Level.L33;
            case 34: return Enumeration.Level.L34;
            case 35: return Enumeration.Level.L35;
            case 36: return Enumeration.Level.L36;
            case 37: return Enumeration.Level.L37;
            case 38: return Enumeration.Level.L38;
            case 39: return Enumeration.Level.L39;
            case 40: return a == 1 ? Enumeration.Level.L40 : Enumeration.Level.L40P;
            case 41: return Enumeration.Level.L41;
            case 42: return Enumeration.Level.L42;
            case 43: return Enumeration.Level.L43;
            case 44: return Enumeration.Level.L44;
            case 45: return Enumeration.Level.L45;
            case 46: return Enumeration.Level.L46;
            case 47: return Enumeration.Level.L47;
            case 48: return Enumeration.Level.L48;
            case 49: return Enumeration.Level.L49;
            case 50: return a == 2 ? Enumeration.Level.L50 : Enumeration.Level.L50P;
            case 51: return Enumeration.Level.L51;
            case 52: return Enumeration.Level.L52;
            case 53: return Enumeration.Level.L53;
            case 54: return Enumeration.Level.L54;
            case 55: return Enumeration.Level.L55;
            case 56: return Enumeration.Level.L56;
            case 57: return Enumeration.Level.L57;
            case 58: return Enumeration.Level.L58;
            case 59: return Enumeration.Level.L59;
            case 60: return a == 3 ? Enumeration.Level.L60 : Enumeration.Level.L60P;
            case 61: return Enumeration.Level.L61;
            case 62: return Enumeration.Level.L62;
            case 63: return Enumeration.Level.L63;
            case 64: return Enumeration.Level.L64;
            case 65: return Enumeration.Level.L65;
            case 66: return Enumeration.Level.L66;
            case 67: return Enumeration.Level.L67;
            case 68: return Enumeration.Level.L68;
            case 69: return Enumeration.Level.L69;
            case 70: return a == 4 ? Enumeration.Level.L70 : Enumeration.Level.L70P;
            case 71: return Enumeration.Level.L71;
            case 72: return Enumeration.Level.L72;
            case 73: return Enumeration.Level.L73;
            case 74: return Enumeration.Level.L74;
            case 75: return Enumeration.Level.L75;
            case 76: return Enumeration.Level.L76;
            case 77: return Enumeration.Level.L77;
            case 78: return Enumeration.Level.L78;
            case 79: return Enumeration.Level.L79;
            case 80: return a == 5 ? Enumeration.Level.L80 : Enumeration.Level.L80P;
            case 81: return Enumeration.Level.L81;
            case 82: return Enumeration.Level.L82;
            case 83: return Enumeration.Level.L83;
            case 84: return Enumeration.Level.L84;
            case 85: return Enumeration.Level.L85;
            case 86: return Enumeration.Level.L86;
            case 87: return Enumeration.Level.L87;
            case 88: return Enumeration.Level.L88;
            case 89: return Enumeration.Level.L89;
        }

        return Enumeration.Level.L90;
    }
}