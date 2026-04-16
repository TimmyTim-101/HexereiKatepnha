using CommunityToolkit.Mvvm.Messaging.Messages;

namespace HexereiKatepnha.Models.Messages;

public class CharacterInfoChangeMessage(int characterRid) : ValueChangedMessage<int>(characterRid); // 角色基本信息变动，通知规划设置config响应

public class CharacterWeaponChangeMessage(int characterRid) : ValueChangedMessage<int>(characterRid); // 角色武器分配变动，通知角色view model响应