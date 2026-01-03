using System.Windows.Media;

namespace HexereiKatepnha.Constants;

public static class ThemeConstants
{
    public static readonly string[] ThemeName = ["风", "岩", "雷", "草", "水", "火", "月", "冰", "经典配色", "纯黑配色"];

    public static readonly SolidColorBrush?[] BackColor =
    [
        (SolidColorBrush)new BrushConverter().ConvertFromString("#0E5959")!,
        (SolidColorBrush)new BrushConverter().ConvertFromString("#694D0F")!,
        (SolidColorBrush)new BrushConverter().ConvertFromString("#391151")!,
        (SolidColorBrush)new BrushConverter().ConvertFromString("#32590F")!,
        (SolidColorBrush)new BrushConverter().ConvertFromString("#152F5A")!,
        (SolidColorBrush)new BrushConverter().ConvertFromString("#59100E")!,
        (SolidColorBrush)new BrushConverter().ConvertFromString("#2F3A3E")!,
        (SolidColorBrush)new BrushConverter().ConvertFromString("#133A49")!,
        (SolidColorBrush)new BrushConverter().ConvertFromString("#101632")!,
        (SolidColorBrush)new BrushConverter().ConvertFromString("#000000")!,
    ];

    public static readonly SolidColorBrush?[] FrontColor =
    [
        (SolidColorBrush)new BrushConverter().ConvertFromString("#3F8E8E")!,
        (SolidColorBrush)new BrushConverter().ConvertFromString("#977E47")!,
        (SolidColorBrush)new BrushConverter().ConvertFromString("#6D4187")!,
        (SolidColorBrush)new BrushConverter().ConvertFromString("#658D41")!,
        (SolidColorBrush)new BrushConverter().ConvertFromString("#49628C")!,
        (SolidColorBrush)new BrushConverter().ConvertFromString("#8E413F")!,
        (SolidColorBrush)new BrushConverter().ConvertFromString("#626D71")!,
        (SolidColorBrush)new BrushConverter().ConvertFromString("#426F80")!,
        (SolidColorBrush)new BrushConverter().ConvertFromString("#283250")!,
        (SolidColorBrush)new BrushConverter().ConvertFromString("#202020")!,
    ];

    public static readonly SolidColorBrush?[] SelectedColor =
    [
        (SolidColorBrush)new BrushConverter().ConvertFromString("#85AEAE")!,
        (SolidColorBrush)new BrushConverter().ConvertFromString("#B5A98F")!,
        (SolidColorBrush)new BrushConverter().ConvertFromString("#9C85A9")!,
        (SolidColorBrush)new BrushConverter().ConvertFromString("#99AD87")!,
        (SolidColorBrush)new BrushConverter().ConvertFromString("#8D99AE")!,
        (SolidColorBrush)new BrushConverter().ConvertFromString("#AE8685")!,
        (SolidColorBrush)new BrushConverter().ConvertFromString("#999EA0")!,
        (SolidColorBrush)new BrushConverter().ConvertFromString("#839BA5")!,
        (SolidColorBrush)new BrushConverter().ConvertFromString("#3C4664")!,
        (SolidColorBrush)new BrushConverter().ConvertFromString("#404040")!,
    ];

    public static readonly SolidColorBrush? White70 = (SolidColorBrush)new BrushConverter().ConvertFromString("#B3B3B3")!;

    public static readonly SolidColorBrush? Red = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF3D00")!;
    public static readonly SolidColorBrush? Green = (SolidColorBrush)new BrushConverter().ConvertFromString("#12B981")!;
}