using System.Text;
using System.Windows;
using CommunityToolkit.Mvvm.Messaging;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.ConfigModels;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.Messages;
using HexereiKatepnha.Services.CalculatorService;
using HexereiKatepnha.Services.ConfigService;

namespace HexereiKatepnha
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public static ThemeConfigManager? ThemeConfigManagerInstance { get; set; }
        public static AccountConfigManager? AccountConfigManagerInstance { get; private set; }
        public static BackpackMaterialConfigManager? BackpackMaterialConfigManagerInstance { get; set; }
        public static BackpackCharacterConfigManager? BackpackCharacterConfigManagerInstance { get; set; }
        public static BackpackWeaponConfigManager? BackpackWeaponConfigManagerInstance { get; set; }
        public static CalculatorPlanSettingConfigManager? CalculatorPlanSettingConfigManagerInstance { get; set; }
        public static GoalSimulatorService? GlobalGoalSimulatorServicePart { get; set; }
        public static GoalSimulatorService? GlobalGoalSimulatorServiceAll { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            // 修复中文控制台输出乱码
            Console.OutputEncoding = Encoding.UTF8;
            base.OnStartup(e);
            Initialize();
            AccountConfigManagerInstance = new AccountConfigManager();
            AccountConfigManagerInstance.Load();
            Guid currentAccountGuid = AccountConfig.CalculateMd5(AccountConfigManagerInstance.Configuration.CurrentAccount);
            ThemeConfigManagerInstance = new ThemeConfigManager(currentAccountGuid);
            ThemeConfigManagerInstance.Load();
            BackpackMaterialConfigManagerInstance = new BackpackMaterialConfigManager(currentAccountGuid);
            BackpackMaterialConfigManagerInstance.Load();
            BackpackCharacterConfigManagerInstance = new BackpackCharacterConfigManager(currentAccountGuid);
            BackpackCharacterConfigManagerInstance.Load();
            BackpackWeaponConfigManagerInstance = new BackpackWeaponConfigManager(currentAccountGuid);
            BackpackWeaponConfigManagerInstance.Load();
            CalculatorPlanSettingConfigManagerInstance = new CalculatorPlanSettingConfigManager(currentAccountGuid);
            CalculatorPlanSettingConfigManagerInstance.Load();
            RefreshGoalSimulation();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            AccountConfigManagerInstance?.Save();
            ThemeConfigManagerInstance?.Save();
            BackpackMaterialConfigManagerInstance?.Save();
            BackpackCharacterConfigManagerInstance?.Save();
            BackpackWeaponConfigManagerInstance?.Save();
            CalculatorPlanSettingConfigManagerInstance?.Save();
            base.OnExit(e);
        }

        private void Initialize()
        {
            foreach (CharacterModel cm in AllEntities.AllCharacter)
            {
                int thisCharacterBirthMonth = cm.BirthMonth;
                int thisCharacterBirthDay = cm.BirthDay;
                int thisCharacterBirthday = thisCharacterBirthMonth * 100 + thisCharacterBirthDay;
                if (!AutoCalculateConstants.CharacterBirthdayDictionary.ContainsKey(thisCharacterBirthday))
                {
                    AutoCalculateConstants.CharacterBirthdayDictionary[thisCharacterBirthday] = new List<CharacterModel>();
                }

                AutoCalculateConstants.CharacterBirthdayDictionary[thisCharacterBirthday].Add(cm);
            }

            foreach (MaterialGroupModel g in AllEntities.AllGroup)
            {
                List<MaterialModel> thisGroupList = g.MaterialList;
                for (int i = 0; i < thisGroupList.Count - 1; i++)
                {
                    AutoCalculateConstants.MaterialMergeRecipe[thisGroupList[i].Rid] = thisGroupList[i + 1].Rid;
                }
            }

            AutoCalculateConstants.CharacterMap = AllEntities.AllCharacter.ToDictionary(c => c.Rid, c => c);
            AutoCalculateConstants.WeaponMap = AllEntities.AllWeapon.ToDictionary(w => w.Rid, w => w);
            foreach (var m in AllEntities.AllMaterialLists.SelectMany(l => l))
            {
                AutoCalculateConstants.MaterialMap[m.Rid] = m;
            }

            foreach (List<DungeonModel> l in AllEntities.AllDungeonLists)
            {
                foreach (DungeonModel m in l)
                {
                    AutoCalculateConstants.DungeonMap[m.Rid] = m;
                    foreach (MaterialPairModel mp in m.DropMaterialList)
                    {
                        AutoCalculateConstants.MaterialDungeonMap[mp.MaterialModel!.Rid] = m.Rid;
                    }
                }
            }
        }

        public static void RefreshGoalSimulation()
        {
            GlobalGoalSimulatorServicePart = new GoalSimulatorService(false);
            GlobalGoalSimulatorServiceAll = new GoalSimulatorService(true);
            WeakReferenceMessenger.Default.Send(new GoalSimulatorChangeMessage());
        }
    }
}