using CommunityToolkit.Mvvm.Messaging;
using HexereiKatepnha.Models.ConfigModels;
using HexereiKatepnha.Models.Messages;

namespace HexereiKatepnha.Services.ConfigService;

public class AccountConfigManager : ConfigManagerBase<AccountConfig>
{
    protected override string ConfigFileName { get; set; } = "Configs/AccountConfig.json";

    public void UpdateCurrentAccount(string accountName)
    {
        Configuration.CurrentAccount = accountName;
        Save();
        WeakReferenceMessenger.Default.Send(new CurrentAccountChangeMessage(accountName));
    }
}