using HexereiKatepnha.Models.ConfigModels;

namespace HexereiKatepnha.Services;

public class PrivateAccountConfigManager : ConfigManagerBase<PrivateAccountConfig>
{
    protected sealed override string ConfigFileName { get; set; }

    public PrivateAccountConfigManager(Guid accountGuid)
    {
        ConfigFileName = "Configs/" + accountGuid + "/PrivateAccountConfig.json";
        Configuration.SelfAccountName = App.AccountConfigManagerInstance!.Configuration.CurrentAccount;
    }
}