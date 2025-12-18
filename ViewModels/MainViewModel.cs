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

        [ObservableProperty] private ObservableObject _currentViewModel;

        [ObservableProperty] private NavigationItem _selectedNavigationItem;

        public ObservableCollection<NavigationItem> NavigationItems { get; } = new();

        public MainViewModel()
        {
            // 初始化导航项
            NavigationItems.Add(new NavigationItem("主页", typeof(HomeViewModel)));
            NavigationItems.Add(new NavigationItem("数据库", typeof(DatabaseViewModel)));
            NavigationItems.Add(new NavigationItem("设置", typeof(SettingsViewModel)));

            // 默认选中第一项
            SelectedNavigationItem = NavigationItems[0];
        }

        partial void OnSelectedNavigationItemChanged(NavigationItem value)
        {
            if (value != null)
            {
                if (value.TargetViewModelType == typeof(HomeViewModel))
                {
                    CurrentViewModel = new HomeViewModel();
                }
                else if (value.TargetViewModelType == typeof(SettingsViewModel))
                {
                    CurrentViewModel = new SettingsViewModel();
                }
                else if (value.TargetViewModelType == typeof(DatabaseViewModel))
                {
                    CurrentViewModel = new DatabaseViewModel();
                }
            }
        }
    }
}