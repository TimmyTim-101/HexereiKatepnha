using CommunityToolkit.Mvvm.ComponentModel;

namespace HexereiKatepnha.ViewModels
{
    public partial class SettingsViewModel : ObservableObject
    {
        [ObservableProperty] private string _title = "设置";

        [ObservableProperty] private bool _isNotificationsEnabled = true;

        [ObservableProperty] private bool _isDarkThemeEnabled = false;

        partial void OnIsDarkThemeEnabledChanged(bool value)
        {
            Console.WriteLine($"现在深色模式的状态是：{value}");
        }
    }
}