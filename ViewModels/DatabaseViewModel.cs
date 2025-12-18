using CommunityToolkit.Mvvm.ComponentModel;

namespace HexereiKatepnha.ViewModels
{
    public partial class DatabaseViewModel : ObservableObject
    {
        [ObservableProperty] private string _title = "数据库";
    }
}