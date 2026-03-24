using CommunityToolkit.Mvvm.Messaging.Messages;
using HexereiKatepnha.Constants.EntityConstants;

namespace HexereiKatepnha.Models.Messages;

public record BackpackWeaponChangeRecord(
    string PlanId,
    Enumeration.Level Level,
    Enumeration.Level GoalLevel
);

public class BackpackWeaponChangeMessage : ValueChangedMessage<BackpackWeaponChangeRecord>
{
    public BackpackWeaponChangeMessage(BackpackWeaponChangeRecord value) : base(value)
    {
    }
}

public class BackpackWeaponDeleteMessage : ValueChangedMessage<string>
{
    public BackpackWeaponDeleteMessage(string value) : base(value)
    {
    }
}