using System.Configuration;
using System.Data;
using System.Windows;

namespace HexereiKatepnha
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // 修复中文控制台输出乱码
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            Console.WriteLine("退出退出，退出前记得保存");
            base.OnExit(e);
        }
    }
}