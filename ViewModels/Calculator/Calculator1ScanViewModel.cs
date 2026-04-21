using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace HexereiKatepnha.ViewModels.Calculator
{
    public partial class Calculator1ScanViewModel : ObservableObject
    {
        [RelayCommand]
        public void OpenHelpWebPage()
        {
            string url = "https://github.com/TimmyTim-101/HexereiKatepnha/wiki/%E8%AE%A1%E7%AE%97%E5%99%A8-%E2%80%90-%E8%87%AA%E5%8A%A8%E6%89%AB%E6%8F%8F";
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