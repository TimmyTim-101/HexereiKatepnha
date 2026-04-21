using System.Diagnostics;
using System.Windows.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HexereiKatepnha.Constants;
using HexereiKatepnha.Services.JsonService;
using HexereiKatepnha.Services.OpenFileService;

namespace HexereiKatepnha.ViewModels
{
    public partial class SettingsViewModel : ObservableObject
    {
        [ObservableProperty] [NotifyPropertyChangedFor(nameof(CurrentThemeName))] [NotifyPropertyChangedFor(nameof(CurrentThemeColor))]
        private int _themeIndex = App.ThemeConfigManagerInstance!.Configuration.ThemeIndex;

        public string CurrentThemeName => ThemeConstants.ThemeName[ThemeIndex];
        public SolidColorBrush? CurrentThemeColor => ThemeConstants.FrontColor[ThemeIndex];

        private readonly IOpenFileService _openFileService = new WindowsOpenFileService();
        [ObservableProperty] private string _timeString = "";
        [ObservableProperty] private string _fileName = "";
        [ObservableProperty] private string _uploadJsonStatusSign = "就绪";
        [ObservableProperty] private string _uploadJsonStatusMessage = "";
        [ObservableProperty] private bool _isShowDetail;

        partial void OnThemeIndexChanged(int value)
        {
            App.ThemeConfigManagerInstance!.UpdateTheme(value);
            App.ThemeConfigManagerInstance.Save();
        }

        [RelayCommand]
        private void ClickOnTheme(String value)
        {
            int valueInt = Int32.Parse(value);
            ThemeIndex = valueInt;
        }

        [RelayCommand]
        public void ClickOnImportJson()
        {
            string? filePath = _openFileService.PickJsonFile();
            if (filePath == null) return;
            GoodJsonParseService parseService = new GoodJsonParseService(filePath);
            int result = parseService.GetResult();
            DateTime now = DateTime.Now;
            TimeString = now.ToString("yyyy-MM-dd HH:mm:ss");
            FileName = parseService.GetFileName();
            UploadJsonStatusSign = "导入完成";
            IsShowDetail = false;
            if (result != 1)
            {
                UploadJsonStatusSign = "导入出现错误";
                UploadJsonStatusMessage = parseService.GetErrorMessage();
                IsShowDetail = true;
            }
        }

        [RelayCommand]
        public void OpenHelpWebPage()
        {
            string url = "https://github.com/TimmyTim-101/HexereiKatepnha/wiki/%E8%AE%BE%E7%BD%AE";
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