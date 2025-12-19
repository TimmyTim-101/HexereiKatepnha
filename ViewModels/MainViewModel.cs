using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using HexereiKatepnha.Models;

namespace HexereiKatepnha.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty] private string _userName = string.Empty;

        [ObservableProperty] private string _greetingMessage = "等待输入...";

        [ObservableProperty] private int _navigationFlag = 1;

        [ObservableProperty] private ObservableObject _currentNavigationViewModel;

        [ObservableProperty] private ObservableObject _currentContentViewModel;

        [ObservableProperty] private NavigationItem _selectedNavigationItem;

        public MainViewModel(int navigationFlag)
        {
            NavigationFlag = navigationFlag;
            CurrentNavigationViewModel = new NavigationViewModel(navigationFlag, (newflag) => { NavigationFlag = newflag; });
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
                case -1: CurrentContentViewModel = new SettingsViewModel(); break;
                default: CurrentContentViewModel = new HomeViewModel(); break;
            }
        }
    }
}