using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace HexereiKatepnha.ViewModels
{
    public partial class NavigationViewModel : ObservableObject
    {
        [ObservableProperty] private int _position = 1;

        private readonly Action<int> _updateNavigationFlagAction;

        public NavigationViewModel(int navigationFlag, Action<int> updateAction)
        {
            Position = navigationFlag;
            _updateNavigationFlagAction = updateAction;
        }

        [RelayCommand]
        private void ClickOnNavigation(String value)
        {
            int valueInt = Int32.Parse(value);
            Position = valueInt;
            _updateNavigationFlagAction(valueInt);
        }
    }
}