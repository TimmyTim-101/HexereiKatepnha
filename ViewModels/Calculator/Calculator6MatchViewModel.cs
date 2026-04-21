using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace HexereiKatepnha.ViewModels.Calculator
{
    public partial class Calculator6MatchViewModel : ObservableObject
    {
        [RelayCommand]
        public void OpenHelpWebPage()
        {
            string url = "https://github.com/TimmyTim-101/HexereiKatepnha/wiki/%E8%AE%A1%E7%AE%97%E5%99%A8-%E2%80%90-%E5%9C%A3%E9%81%97%E7%89%A9%E9%85%8D%E8%A3%85";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}