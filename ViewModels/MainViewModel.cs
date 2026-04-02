using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using HexereiKatepnha.ViewModels.Backpack;
using HexereiKatepnha.ViewModels.Calculator;
using HexereiKatepnha.ViewModels.Database;

namespace HexereiKatepnha.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty] private bool _isLoading;
        [ObservableProperty] private int _navigationFlag = 1;
        [ObservableProperty] private ObservableObject _currentNavigationViewModel;
        [ObservableProperty] private object? _currentContentViewModel;

        private UserControl? _homeView;

        private UserControl? _backpack1CharacterView;
        private UserControl? _backpack2WeaponView;
        private UserControl? _backpack3ArtifactView;
        private UserControl? _backpack4MaterialView;

        private UserControl? _calculator1ScanView;
        private UserControl? _calculator7PlanSettingView;
        private UserControl? _calculator2PlanView;
        private UserControl? _calculator3AllView;
        private UserControl? _calculator5PotentialView;
        private UserControl? _calculator6MatchView;

        private UserControl? _database1CharacterView;
        private UserControl? _database2WeaponView;
        private UserControl? _database3ArtifactView;
        private UserControl? _database4MaterialView;
        private UserControl? _database5DungeonView;

        private UserControl? _settingsView;

        public MainViewModel(int navigationFlag)
        {
            NavigationFlag = navigationFlag;
            CurrentNavigationViewModel = new NavigationViewModel(navigationFlag, newFlag => { NavigationFlag = newFlag; });
            UpdateContent(navigationFlag);
            PreloadHeavyViews();
        }

        private async void PreloadHeavyViews()
        {
            await Task.Delay(500);
            IsLoading = true;
            await Task.Delay(50);
            if (_backpack1CharacterView == null)
            {
                _backpack1CharacterView = new HexereiKatepnha.Views.Backpack.Backpack1CharacterView();
                _backpack1CharacterView.DataContext = new Backpack1CharacterViewModel();
                _backpack1CharacterView.Measure(new Size(1706, 1043));
                _backpack1CharacterView.Arrange(new Rect(0, 0, 1706, 1043));
            }

            if (_backpack2WeaponView == null)
            {
                _backpack2WeaponView = new HexereiKatepnha.Views.Backpack.Backpack2WeaponView();
                _backpack2WeaponView.DataContext = new Backpack2WeaponViewModel();
                _backpack2WeaponView.Measure(new Size(1706, 1043));
                _backpack2WeaponView.Arrange(new Rect(0, 0, 1706, 1043));
            }

            if (_backpack3ArtifactView == null)
            {
                _backpack3ArtifactView = new HexereiKatepnha.Views.Backpack.Backpack3ArtifactView();
                _backpack3ArtifactView.DataContext = new Backpack3ArtifactViewModel();
                _backpack3ArtifactView.Measure(new Size(1706, 1043));
                _backpack3ArtifactView.Arrange(new Rect(0, 0, 1706, 1043));
            }

            if (_backpack4MaterialView == null)
            {
                _backpack4MaterialView = new HexereiKatepnha.Views.Backpack.Backpack4MaterialView();
                _backpack4MaterialView.DataContext = new Backpack4MaterialViewModel();
                _backpack4MaterialView.Measure(new Size(1706, 1043));
                _backpack4MaterialView.Arrange(new Rect(0, 0, 1706, 1043));
            }

            if (_calculator1ScanView == null)
            {
                _calculator1ScanView = new HexereiKatepnha.Views.Calculator.Calculator1ScanView();
                _calculator1ScanView.DataContext = new Calculator1ScanViewModel();
                _calculator1ScanView.Measure(new Size(1706, 1043));
                _calculator1ScanView.Arrange(new Rect(0, 0, 1706, 1043));
            }

            if (_calculator2PlanView == null)
            {
                _calculator2PlanView = new HexereiKatepnha.Views.Calculator.Calculator2PlanView();
                _calculator2PlanView.DataContext = new Calculator2PlanViewModel();
                _calculator2PlanView.Measure(new Size(1706, 1043));
                _calculator2PlanView.Arrange(new Rect(0, 0, 1706, 1043));
            }

            if (_calculator3AllView == null)
            {
                _calculator3AllView = new HexereiKatepnha.Views.Calculator.Calculator3AllView();
                _calculator3AllView.DataContext = new Calculator3AllViewModel();
                _calculator3AllView.Measure(new Size(1706, 1043));
                _calculator3AllView.Arrange(new Rect(0, 0, 1706, 1043));
            }

            if (_calculator5PotentialView == null)
            {
                _calculator5PotentialView = new HexereiKatepnha.Views.Calculator.Calculator5PotentialView();
                _calculator5PotentialView.DataContext = new Calculator5PotentialViewModel();
                _calculator5PotentialView.Measure(new Size(1706, 1043));
                _calculator5PotentialView.Arrange(new Rect(0, 0, 1706, 1043));
            }

            if (_calculator6MatchView == null)
            {
                _calculator6MatchView = new HexereiKatepnha.Views.Calculator.Calculator6MatchView();
                _calculator6MatchView.DataContext = new Calculator6MatchViewModel();
                _calculator6MatchView.Measure(new Size(1706, 1043));
                _calculator6MatchView.Arrange(new Rect(0, 0, 1706, 1043));
            }

            if (_calculator7PlanSettingView == null)
            {
                _calculator7PlanSettingView = new HexereiKatepnha.Views.Calculator.Calculator7PlanSettingView();
                _calculator7PlanSettingView.DataContext = new Calculator7PlanSettingViewModel();
                _calculator7PlanSettingView.Measure(new Size(1706, 1043));
                _calculator7PlanSettingView.Arrange(new Rect(0, 0, 1706, 1043));
            }

            if (_database1CharacterView == null)
            {
                _database1CharacterView = new HexereiKatepnha.Views.Database.Database1CharacterView();
                _database1CharacterView.DataContext = new Database1CharacterViewModel();
                _database1CharacterView.Measure(new Size(1706, 1043));
                _database1CharacterView.Arrange(new Rect(0, 0, 1706, 1043));
            }

            if (_database2WeaponView == null)
            {
                _database2WeaponView = new HexereiKatepnha.Views.Database.Database2WeaponView();
                _database2WeaponView.DataContext = new Database2WeaponViewModel();
                _database2WeaponView.Measure(new Size(1706, 1043));
                _database2WeaponView.Arrange(new Rect(0, 0, 1706, 1043));
            }

            if (_database3ArtifactView == null)
            {
                _database3ArtifactView = new HexereiKatepnha.Views.Database.Database3ArtifactView();
                _database3ArtifactView.DataContext = new Database3ArtifactViewModel();
                _database3ArtifactView.Measure(new Size(1706, 1043));
                _database3ArtifactView.Arrange(new Rect(0, 0, 1706, 1043));
            }

            if (_database4MaterialView == null)
            {
                _database4MaterialView = new HexereiKatepnha.Views.Database.Database4MaterialView();
                _database4MaterialView.DataContext = new Database4MaterialViewModel();
                _database4MaterialView.Measure(new Size(1706, 1043));
                _database4MaterialView.Arrange(new Rect(0, 0, 1706, 1043));
            }

            if (_database5DungeonView == null)
            {
                _database5DungeonView = new HexereiKatepnha.Views.Database.Database5DungeonView();
                _database5DungeonView.DataContext = new Database5DungeonViewModel();
                _database5DungeonView.Measure(new Size(1706, 1043));
                _database5DungeonView.Arrange(new Rect(0, 0, 1706, 1043));
            }

            IsLoading = false;
        }

        partial void OnNavigationFlagChanged(int value)
        {
            UpdateContent(value);
        }

        private void UpdateContent(int flag)
        {
            switch (flag)
            {
                case 1:
                    if (_homeView == null)
                    {
                        _homeView = new Views.HomeView();
                        _homeView.DataContext = new HomeViewModel();
                    }

                    CurrentContentViewModel = _homeView;
                    break;

                case 21:
                    if (_backpack1CharacterView == null)
                    {
                        _backpack1CharacterView = new HexereiKatepnha.Views.Backpack.Backpack1CharacterView();
                        _backpack1CharacterView.DataContext = new Backpack1CharacterViewModel();
                    }

                    CurrentContentViewModel = _backpack1CharacterView;
                    break;
                case 22:
                    if (_backpack2WeaponView == null)
                    {
                        _backpack2WeaponView = new HexereiKatepnha.Views.Backpack.Backpack2WeaponView();
                        _backpack2WeaponView.DataContext = new Backpack2WeaponViewModel();
                    }

                    CurrentContentViewModel = _backpack2WeaponView;
                    break;
                case 23:
                    if (_backpack3ArtifactView == null)
                    {
                        _backpack3ArtifactView = new HexereiKatepnha.Views.Backpack.Backpack3ArtifactView();
                        _backpack3ArtifactView.DataContext = new Backpack3ArtifactViewModel();
                    }

                    CurrentContentViewModel = _backpack3ArtifactView;
                    break;
                case 24:
                    if (_backpack4MaterialView == null)
                    {
                        _backpack4MaterialView = new HexereiKatepnha.Views.Backpack.Backpack4MaterialView();
                        _backpack4MaterialView.DataContext = new Backpack4MaterialViewModel();
                    }

                    CurrentContentViewModel = _backpack4MaterialView;
                    break;

                case 31:
                    if (_calculator1ScanView == null)
                    {
                        _calculator1ScanView = new HexereiKatepnha.Views.Calculator.Calculator1ScanView();
                        _calculator1ScanView.DataContext = new Calculator1ScanViewModel();
                    }

                    CurrentContentViewModel = _calculator1ScanView;
                    break;
                case 37:
                    if (_calculator7PlanSettingView == null)
                    {
                        _calculator7PlanSettingView = new HexereiKatepnha.Views.Calculator.Calculator7PlanSettingView();
                        _calculator7PlanSettingView.DataContext = new Calculator7PlanSettingViewModel();
                    }

                    CurrentContentViewModel = _calculator7PlanSettingView;
                    break;
                case 32:
                    if (_calculator2PlanView == null)
                    {
                        _calculator2PlanView = new HexereiKatepnha.Views.Calculator.Calculator2PlanView();
                        _calculator2PlanView.DataContext = new Calculator2PlanViewModel();
                    }

                    CurrentContentViewModel = _calculator2PlanView;
                    break;
                case 33:
                    if (_calculator3AllView == null)
                    {
                        _calculator3AllView = new HexereiKatepnha.Views.Calculator.Calculator3AllView();
                        _calculator3AllView.DataContext = new Calculator3AllViewModel();
                    }

                    CurrentContentViewModel = _calculator3AllView;
                    break;
                case 35:
                    if (_calculator5PotentialView == null)
                    {
                        _calculator5PotentialView = new HexereiKatepnha.Views.Calculator.Calculator5PotentialView();
                        _calculator5PotentialView.DataContext = new Calculator5PotentialViewModel();
                    }

                    CurrentContentViewModel = _calculator5PotentialView;
                    break;
                case 36:
                    if (_calculator6MatchView == null)
                    {
                        _calculator6MatchView = new HexereiKatepnha.Views.Calculator.Calculator6MatchView();
                        _calculator6MatchView.DataContext = new Calculator6MatchViewModel();
                    }

                    CurrentContentViewModel = _calculator6MatchView;
                    break;

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

                case -1:
                    if (_settingsView == null)
                    {
                        _settingsView = new Views.SettingsView();
                        _settingsView.DataContext = new SettingsViewModel();
                    }

                    CurrentContentViewModel = _settingsView;
                    break;

                default:
                    if (_homeView == null)
                    {
                        _homeView = new Views.HomeView();
                        _homeView.DataContext = new HomeViewModel();
                    }

                    CurrentContentViewModel = _homeView;
                    break;
            }
        }
    }
}