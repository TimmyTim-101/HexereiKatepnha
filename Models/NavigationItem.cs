using System;

namespace HexereiKatepnha.Models
{
    public class NavigationItem
    {
        public string Title { get; set; }
        public Type TargetViewModelType { get; set; }

        public NavigationItem(string title, Type targetViewModelType)
        {
            Title = title;
            TargetViewModelType = targetViewModelType;
        }
    }
}