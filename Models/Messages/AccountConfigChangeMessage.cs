using CommunityToolkit.Mvvm.Messaging.Messages;

namespace HexereiKatepnha.Models.Messages;

// 当前用户改变时通知导航栏更改
public class CurrentAccountChangeMessage(string accountName) : ValueChangedMessage<string>(accountName);