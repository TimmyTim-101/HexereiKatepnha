using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace HexereiKatepnha.ViewModels.Backpack
{
    public partial class Backpack3ArtifactViewModel : ObservableObject
    {
        [RelayCommand]
        public void OpenHelpWebPage()
        {
            string url = "https://github.com/TimmyTim-101/HexereiKatepnha/wiki/%E8%83%8C%E5%8C%85-%E2%80%90-%E5%9C%A3%E9%81%97%E7%89%A9";
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