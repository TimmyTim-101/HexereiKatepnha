using System.Windows.Controls;
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

        [ObservableProperty] private object? _currentContentViewModel;

        private UserControl? _backpack4MaterialView;

        private UserControl? _database1CharacterView;
        private UserControl? _database2WeaponView;
        private UserControl? _database3ArtifactView;
        private UserControl? _database4MaterialView;
        private UserControl? _database5DungeonView;

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
                case 24:
                    if (_backpack4MaterialView == null)
                    {
                        _backpack4MaterialView = new HexereiKatepnha.Views.Backpack.Backpack4MaterialView();
                        _backpack4MaterialView.DataContext = new Backpack4MaterialViewModel();
                    }

                    CurrentContentViewModel = _backpack4MaterialView;
                    break;

                case 31: CurrentContentViewModel = new Calculator1ScanViewModel(); break;
                case 37: CurrentContentViewModel = new Calculator7PlanSettingViewModel(); break;
                case 32: CurrentContentViewModel = new Calculator2PlanViewModel(); break;
                case 33: CurrentContentViewModel = new Calculator3AllViewModel(); break;
                case 35: CurrentContentViewModel = new Calculator5PotentialViewModel(); break;
                case 36: CurrentContentViewModel = new Calculator6MatchViewModel(); break;

                case 41:
                    if (_database1CharacterView == null)
                    {
                        _database1CharacterView = new HexereiKatepnha.Views.Database.Database1CharacterView();
                        _database1CharacterView.DataContext = new Database1CharacterViewModel();
                    }

                    CurrentContentViewModel = _database1CharacterView;
                    break;
                case 42:
                    if (_database2WeaponView == null)
                    {
                        _database2WeaponView = new HexereiKatepnha.Views.Database.Database2WeaponView();
                        _database2WeaponView.DataContext = new Database2WeaponViewModel();
                    }

                    CurrentContentViewModel = _database2WeaponView;
                    break;
                case 43:
                    if (_database3ArtifactView == null)
                    {
                        _database3ArtifactView = new HexereiKatepnha.Views.Database.Database3ArtifactView();
                        _database3ArtifactView.DataContext = new Database3ArtifactViewModel();
                    }

                    CurrentContentViewModel = _database3ArtifactView;
                    break;
                case 44:
                    if (_database4MaterialView == null)
                    {
                        _database4MaterialView = new HexereiKatepnha.Views.Database.Database4MaterialView();
                        _database4MaterialView.DataContext = new Database4MaterialViewModel();
                    }

                    CurrentContentViewModel = _database4MaterialView;
                    break;
                case 45:
                    if (_database5DungeonView == null)
                    {
                        _database5DungeonView = new HexereiKatepnha.Views.Database.Database5DungeonView();
                        _database5DungeonView.DataContext = new Database5DungeonViewModel();
                    }

                    CurrentContentViewModel = _database5DungeonView;
                    break;

                case -1: CurrentContentViewModel = new SettingsViewModel(); break;

                default: CurrentContentViewModel = new HomeViewModel(); break;
            }
        }
    }
}