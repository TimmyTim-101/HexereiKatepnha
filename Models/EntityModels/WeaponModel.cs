using HexereiKatepnha.Constants.EntityConstants;

namespace HexereiKatepnha.Models.EntityModels;

public class WeaponModel : BaseEntityModel
{
    public override int Rid { get; set; }
    public override int Vid { get; set; }
    public override string Name { get; set; } = "";
    public override int Star { get; set; }
    public override Enumeration.EntityType EntityType { get; set; } = Enumeration.EntityType.Weapon;
    public override string ImagePath { get; set; } = "";

    public Enumeration.WeaponType WeaponType = Enumeration.WeaponType.Unknown;
    public Enumeration.Affix MainAffix = Enumeration.Affix.Attack; // 主属性
    public Enumeration.Affix SubAffix = Enumeration.Affix.Unknown; // 副属性
    public Dictionary<int, string> Progression = new(); // 精炼效果
    public Dictionary<Enumeration.Level, double> MainAffixNumberDictionary = new(); // 主属性各等级数值
    public Dictionary<Enumeration.Level, double> SubAffixNumberDictionary = new(); // 副属性各等级数值
    public Dictionary<Enumeration.Level, List<MaterialPairModel>> LevelUpMaterials = new(); // 各升级升级需要材料
}