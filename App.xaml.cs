using System.Text;
using System.Windows;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.ConfigModels;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Services;

namespace HexereiKatepnha
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public static ThemeConfigManager? ThemeConfigManagerInstance { get; set; }
        public static AccountConfigManager? AccountConfigManagerInstance { get; set; }
        public static PrivateAccountConfigManager? PrivateAccountConfigManagerInstance { get; set; }
        public static BackpackMaterialConfigManager? BackpackMaterialConfigManagerInstance { get; set; }

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
            PrivateAccountConfigManagerInstance = new PrivateAccountConfigManager(currentAccountGuid);
            PrivateAccountConfigManagerInstance.Load();
            BackpackMaterialConfigManagerInstance = new BackpackMaterialConfigManager(currentAccountGuid);
            BackpackMaterialConfigManagerInstance.Load();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            AccountConfigManagerInstance?.Save();
            ThemeConfigManagerInstance?.Save();
            PrivateAccountConfigManagerInstance?.Save();
            BackpackMaterialConfigManagerInstance?.Save();
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
        }
    }
}