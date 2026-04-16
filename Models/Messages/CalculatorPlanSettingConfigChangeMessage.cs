using CommunityToolkit.Mvvm.Messaging.Messages;

namespace HexereiKatepnha.Models.Messages;

public class PlanChangeMessage; // 规划顺序发生变动，通知目标模拟响应

public class ItemGoalChangeMessage(string planId) : ValueChangedMessage<string>(planId); // 某个角色/武器的某个部分出现变动，通知规划设置view model响应

public class ItemDeleteMessage(string planId) : ValueChangedMessage<string>(planId); // 某个角色、武器被删除，通知规划设置view model响应