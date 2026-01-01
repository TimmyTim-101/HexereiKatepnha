using System.Windows.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HexereiKatepnha.Constants;

namespace HexereiKatepnha.ViewModels
{
    public partial class SettingsViewModel : ObservableObject
    {
        [ObservableProperty] [NotifyPropertyChangedFor(nameof(CurrentThemeName))] [NotifyPropertyChangedFor(nameof(CurrentThemeColor))]
        private int _themeIndex = App.ThemeConfigManagerInstance!.Configuration.ThemeIndex;

        public string CurrentThemeName => ThemeConstants.ThemeName[ThemeIndex];
        public SolidColorBrush? CurrentThemeColor => ThemeConstants.FrontColor[ThemeIndex];

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
    }
}