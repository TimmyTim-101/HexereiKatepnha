using CommunityToolkit.Mvvm.Messaging.Messages;

namespace HexereiKatepnha.Models.Messages;

public class BackpackMaterialConfigChangeMessage(List<int> materialRidList) : ValueChangedMessage<List<int>>(materialRidList); // 背包材料数量变动，通知背包材料页、体力规划页、全拉满页以及规划计算服务响应