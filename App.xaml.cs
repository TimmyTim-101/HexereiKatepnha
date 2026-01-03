using System.Configuration;
using System.Text;
using System.Windows;
using HexereiKatepnha.Models.ConfigModels;
using HexereiKatepnha.Services;

namespace HexereiKatepnha
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public static ThemeConfigManager? ThemeConfigManagerInstance { get; set; }
        public static AccountConfigManager? AccountConfigManagerInstance { get;set; }
        public static PrivateAccountConfigManager? PrivateAccountConfigManagerInstance { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            // 修复中文控制台输出乱码
            Console.OutputEncoding = Encoding.UTF8;
            base.OnStartup(e);
            AccountConfigManagerInstance = new AccountConfigManager();
            AccountConfigManagerInstance.Load();
            Guid currentAccountGuid = AccountConfig.CalculateMd5(AccountConfigManagerInstance.Configuration.CurrentAccount);
            ThemeConfigManagerInstance = new ThemeConfigManager(currentAccountGuid);
            ThemeConfigManagerInstance.Load();
            PrivateAccountConfigManagerInstance = new PrivateAccountConfigManager(currentAccountGuid);
            PrivateAccountConfigManagerInstance.Load();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            AccountConfigManagerInstance?.Save();
            ThemeConfigManagerInstance?.Save();
            PrivateAccountConfigManagerInstance?.Save();
            base.OnExit(e);
        }
    }
}