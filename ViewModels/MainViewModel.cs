using CommunityToolkit.Mvvm.ComponentModel;
using HexereiKatepnha.ViewModels.Backpack;
using HexereiKatepnha.ViewModels.Calculator;
using HexereiKatepnha.ViewModels.Database;

namespace HexereiKatepnha.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty] private string _userName = string.Empty;

        [ObservableProperty] private string _greetingMessage = "等待输入...";

        [ObservableProperty] private int _navigationFlag = 1;

        [ObservableProperty] private ObservableObject _currentNavigationViewModel;

        [ObservableProperty] private ObservableObject? _currentContentViewModel;

        public MainViewModel(int navigationFlag)
        {
            NavigationFlag = navigationFlag;
            CurrentNavigationViewModel = new NavigationViewModel(navigationFlag, newFlag => { NavigationFlag = newFlag; });
            UpdateContent(navigationFlag);
        }

        partial void OnNavigationFlagChanged(int value)
        {
            UpdateContent(value);
        }

        private void UpdateContent(int flag)
        {
            switch (flag)
            {
                case 1: CurrentContentViewModel = new HomeViewModel(); break;

                case 21: CurrentContentViewModel = new Backpack1CharacterViewModel(); break;
                case 22: CurrentContentViewModel = new Backpack2WeaponViewModel(); break;
                case 23: CurrentContentViewModel = new Backpack3ArtifactViewModel(); break;
                case 24: CurrentContentViewModel = new Backpack4MaterialViewModel(); break;

                case 31: CurrentContentViewModel = new Calculator1ScanViewModel(); break;
                case 32: CurrentContentViewModel = new Calculator2PlanViewModel(); break;
                case 33: CurrentContentViewModel = new Calculator3AllViewModel(); break;
                case 34: CurrentContentViewModel = new Calculator4SettingViewModel(); break;
                case 35: CurrentContentViewModel = new Calculator5PotentialViewModel(); break;
                case 36: CurrentContentViewModel = new Calculator6MatchViewModel(); break;

                case 41: CurrentContentViewModel = new Database1CharacterViewModel(); break;
                case 42: CurrentContentViewModel = new Database2WeaponViewModel(); break;
                case 43: CurrentContentViewModel = new Database3ArtifactViewModel(); break;
                case 44: CurrentContentViewModel = new Database4MaterialViewModel(); break;
                case 45: CurrentContentViewModel = new Database5DungeonViewModel(); break;

                case -1: CurrentContentViewModel = new SettingsViewModel(); break;

                default: CurrentContentViewModel = new HomeViewModel(); break;
            }
        }
    }
}