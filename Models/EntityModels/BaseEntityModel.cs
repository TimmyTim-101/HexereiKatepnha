using HexereiKatepnha.Constants.EntityConstants;

namespace HexereiKatepnha.Models.EntityModels;

public abstract class BaseEntityModel
{
    public abstract int Rid { get; set; } // 应用中使用ID，一旦创建在项目周期内永不改变
    public abstract int Vid { get; set; } // 游戏中对应ID，可能发生变化
    public abstract string Name { get; set; } // 名称
    public abstract int Star { get; set; }
    public abstract Enumeration.EntityType EntityType { get; set; }
    public abstract string ImagePath { get; set; } // 图片路径
}