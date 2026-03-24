using CommunityToolkit.Mvvm.Messaging.Messages;
using HexereiKatepnha.Constants.EntityConstants;

namespace HexereiKatepnha.Models.Messages;

public record BackpackCharacterChangeRecord(
    string PlanId,
    Enumeration.Level Level,
    Enumeration.Level GoalLevel
);

public class BackpackCharacterLevelChangeMessage : ValueChangedMessage<BackpackCharacterChangeRecord>
{
    public BackpackCharacterLevelChangeMessage(BackpackCharacterChangeRecord value) : base(value)
    {
    }
}

public class BackpackCharacterTalentAChangeMessage : ValueChangedMessage<BackpackCharacterChangeRecord>
{
    public BackpackCharacterTalentAChangeMessage(BackpackCharacterChangeRecord value) : base(value)
    {
    }
}

public class BackpackCharacterTalentEChangeMessage : ValueChangedMessage<BackpackCharacterChangeRecord>
{
    public BackpackCharacterTalentEChangeMessage(BackpackCharacterChangeRecord value) : base(value)
    {
    }
}

public class BackpackCharacterTalentQChangeMessage : ValueChangedMessage<BackpackCharacterChangeRecord>
{
    public BackpackCharacterTalentQChangeMessage(BackpackCharacterChangeRecord value) : base(value)
    {
    }
}