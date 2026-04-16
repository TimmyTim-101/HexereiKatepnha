using CommunityToolkit.Mvvm.Messaging.Messages;

namespace HexereiKatepnha.Models.Messages;

public class WeaponInfoChangeMessage(string weaponId) : ValueChangedMessage<string>(weaponId); // 武器基本信息变动，通知规划设置config响应

public class WeaponInfoUpdateToCharacterMessage(int characterRid) : ValueChangedMessage<int>(characterRid); // 武器基本信息变动，通知持有此武器的角色view model响应

public class WeaponCharacterChangeMessage(string weaponId) : ValueChangedMessage<string>(weaponId); // 武器归属变动，通知武器view model响应

public class WeaponDeleteMessage(string weaponId) : ValueChangedMessage<string>(weaponId); // 武器被删除，通知规划设置config响应