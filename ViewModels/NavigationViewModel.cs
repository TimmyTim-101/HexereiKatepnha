using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using HexereiKatepnha.Models.Messages;

namespace HexereiKatepnha.ViewModels
{
    public partial class NavigationViewModel : ObservableObject, IRecipient<CurrentAccountChangeMessage>
    {
        [ObservableProperty] private int _position = 1;
        [ObservableProperty] private string _currentAccount = "";

        private readonly Action<int> _updateNavigationFlagAction;

        public NavigationViewModel(int navigationFlag, Action<int> updateAction)
        {
            Position = navigationFlag;
            _updateNavigationFlagAction = updateAction;
            CurrentAccount = App.AccountConfigManagerInstance!.Configuration.CurrentAccount;
            WeakReferenceMessenger.Default.Register(this);
        }

        [RelayCommand]
        private void ClickOnNavigation(String value)
        {
            int valueInt = Int32.Parse(value);
            Position = valueInt;
            _updateNavigationFlagAction(valueInt);
        }

        public void Receive(CurrentAccountChangeMessage message)
        {
            CurrentAccount = message.Value;
        }
    }
}