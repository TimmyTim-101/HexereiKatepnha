using System.Windows;
using HexereiKatepnha.Constants;
using HexereiKatepnha.Models.ConfigModels;

namespace HexereiKatepnha.Services;

public class ThemeConfigManager : ConfigManagerBase<ThemeConfig>
{
    protected sealed override string ConfigFileName { get; set; }

    public ThemeConfigManager(Guid accountGuid)
    {
        ConfigFileName = "Configs/" + accountGuid + "/ThemeConfig.json";
    }

    protected override void OnLoaded()
    {
        int themeIndex = Configuration.ThemeIndex;
        Application.Current.Resources["GlobalBackColor"] = ThemeConstants.BackColor[themeIndex];
        Application.Current.Resources["GlobalFrontColor"] = ThemeConstants.FrontColor[themeIndex];
        Application.Current.Resources["GlobalSelectedColor"] = ThemeConstants.SelectedColor[themeIndex];
    }

    public void UpdateTheme(int value)
    {
        Configuration.ThemeIndex = value;
        OnLoaded();
    }
}