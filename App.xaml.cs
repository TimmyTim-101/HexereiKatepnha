using System.Configuration;
using System.Data;
using System.Windows;
using HexereiKatepnha.Services;

namespace HexereiKatepnha
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ThemeConfigManager ThemeConfigManagerInstance { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            // 修复中文控制台输出乱码
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            base.OnStartup(e);
            ThemeConfigManagerInstance = new ThemeConfigManager();
            ThemeConfigManagerInstance.Load();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            ThemeConfigManagerInstance.Save();
            base.OnExit(e);
        }
    }
}