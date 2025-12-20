using System.Text;
using System.Windows;
using HexereiKatepnha.Services;

namespace HexereiKatepnha
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public static ThemeConfigManager? ThemeConfigManagerInstance { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            // 修复中文控制台输出乱码
            Console.OutputEncoding = Encoding.UTF8;
            base.OnStartup(e);
            ThemeConfigManagerInstance = new ThemeConfigManager();
            ThemeConfigManagerInstance.Load();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            ThemeConfigManagerInstance?.Save();
            base.OnExit(e);
        }
    }
}