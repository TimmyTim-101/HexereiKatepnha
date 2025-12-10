using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace HexereiKatepnha.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _userName = string.Empty;

        [ObservableProperty]
        private string _greetingMessage = "等待输入...";

        [RelayCommand]
        private void SayHello()
        {
            if (string.IsNullOrWhiteSpace(UserName))
            {
                GreetingMessage = "请输入名字！";
            }
            else
            {
                // 模拟业务逻辑
                GreetingMessage = $"你好, {UserName}! 欢迎使用 VS2026 风格的应用。";
            }
        }
    }
}
