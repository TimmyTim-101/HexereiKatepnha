using CommunityToolkit.Mvvm.ComponentModel;

namespace HexereiKatepnha.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        [ObservableProperty] private string _title = "主页";
        [ObservableProperty] private string _welcomeText = "欢迎来到主页！这里是主要内容展示区域。";
    }
}