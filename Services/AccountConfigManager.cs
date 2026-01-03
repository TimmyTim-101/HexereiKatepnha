using HexereiKatepnha.Models.ConfigModels;

namespace HexereiKatepnha.Services;

public class AccountConfigManager : ConfigManagerBase<AccountConfig>
{
    protected override string ConfigFileName { get; set; } = "Configs/AccountConfig.json";
}