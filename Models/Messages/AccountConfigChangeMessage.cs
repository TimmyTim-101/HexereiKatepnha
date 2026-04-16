using CommunityToolkit.Mvvm.Messaging.Messages;

namespace HexereiKatepnha.Models.Messages;

public class CurrentAccountChangeMessage(string accountName) : ValueChangedMessage<string>(accountName); // 当前用户改变，通知导航栏view model响应