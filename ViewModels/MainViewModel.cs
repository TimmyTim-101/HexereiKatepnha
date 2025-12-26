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

        private Database1CharacterViewModel? _database1CharacterViewModel;
        private Database2WeaponViewModel? _database2WeaponViewModel;
        private Database3ArtifactViewModel? _database3ArtifactViewModel;
        private Database4MaterialViewModel? _database4MaterialViewModel;
        private Database5DungeonViewModel? _database5DungeonViewModel;

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

                case 41:
                {
                    _database1CharacterViewModel ??= new Database1CharacterViewModel();
                    CurrentContentViewModel = _database1CharacterViewModel;
                    break;
                }
                case 42:
                {
                    _database2WeaponViewModel ??= new Database2WeaponViewModel();
                    CurrentContentViewModel = _database2WeaponViewModel;
                    break;
                }
                case 43:
                {
                    _database3ArtifactViewModel ??= new Database3ArtifactViewModel();
                    CurrentContentViewModel = _database3ArtifactViewModel;
                    break;
                }
                case 44:
                {
                    _database4MaterialViewModel ??= new Database4MaterialViewModel();
                    CurrentContentViewModel = _database4MaterialViewModel;
                    break;
                }
                case 45:
                {
                    _database5DungeonViewModel ??= new Database5DungeonViewModel();
                    CurrentContentViewModel = _database5DungeonViewModel;
                    break;
                }

                case -1: CurrentContentViewModel = new SettingsViewModel(); break;

                default: CurrentContentViewModel = new HomeViewModel(); break;
            }
        }
    }
}