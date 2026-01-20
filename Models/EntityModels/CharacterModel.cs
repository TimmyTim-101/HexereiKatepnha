using HexereiKatepnha.Constants.EntityConstants;

namespace HexereiKatepnha.Models.EntityModels;

public class CharacterModel : BaseEntityModel
{
    public override int Rid { get; set; }
    public override int Vid { get; set; }
    public override string Name { get; set; } = "";
    public override int Star { get; set; }
    public override Enumeration.EntityType EntityType { get; set; } = Enumeration.EntityType.Character;
    public override string ImagePath { get; set; } = "";

    public Enumeration.ElementType ElementType { get; set; }
    public Enumeration.WeaponType WeaponType { get; set; }
    public int BirthMonth { get; set; }
    public int BirthDay { get; set; }
    public Dictionary<int, ImageDescriptionPairModel> Talent = new(); // 天赋信息
    public Dictionary<int, ImageDescriptionPairModel> Ascension = new(); // 命座信息
    public Dictionary<Enumeration.Level, Dictionary<Enumeration.Affix, double>> AffixDictionary = new(); // 各等级各属性数值
    public Dictionary<Enumeration.Level, List<MaterialPairModel>> LevelUpMaterials = new(); // 各等级升级需要材料
    public Dictionary<Enumeration.Level, List<MaterialPairModel>> Talent1Materials = new(); // 天赋1升级需要材料
    public Dictionary<Enumeration.Level, List<MaterialPairModel>> Talent2Materials = new(); // 天赋2升级需要材料
    public Dictionary<Enumeration.Level, List<MaterialPairModel>> Talent3Materials = new(); // 天赋3升级需要材料
}