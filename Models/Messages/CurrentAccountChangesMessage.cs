using CommunityToolkit.Mvvm.Messaging.Messages;

namespace HexereiKatepnha.Models.Messages;

public class CurrentAccountChangesMessage : ValueChangedMessage<string>
{
    public CurrentAccountChangesMessage(string value) : base(value)
    {
    }
}