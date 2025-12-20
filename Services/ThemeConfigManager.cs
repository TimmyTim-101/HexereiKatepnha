using System.Windows;
using System.Windows.Media;
using HexereiKatepnha.Constants;
using HexereiKatepnha.Models.ConfigModels;

namespace HexereiKatepnha.Services;

public class ThemeConfigManager : ConfigManagerBase<ThemeConfig>
{
    protected override string ConfigFileName => "Configs/ThemeConfig.json";

    protected override void OnLoaded()
    {
        int ThemeIndex = Configuration.ThemeIndex;
        Application.Current.Resources["GlobalBackColor"] = ThemeConstants.BackColor[ThemeIndex];
        Application.Current.Resources["GlobalFrontColor"] = ThemeConstants.FrontColor[ThemeIndex];
        Application.Current.Resources["GlobalSelectedColor"] = ThemeConstants.SelectedColor[ThemeIndex];
    }

    public void UpdateTheme(int value)
    {
        Configuration.ThemeIndex = value;
        OnLoaded();
    }
}