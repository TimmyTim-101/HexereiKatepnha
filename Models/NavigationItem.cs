using System;

namespace HexereiKatepnha.Models
{
    public class NavigationItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = "未知导航名称";
        public string IconPath { get; set; } = "?";
    }
}