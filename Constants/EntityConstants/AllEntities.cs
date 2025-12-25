using HexereiKatepnha.Models.EntityModels;

namespace HexereiKatepnha.Constants.EntityConstants;

public static class AllEntities
{
    // 1 - 角色

    // 2 - 武器
    // 3 - 材料
    // 301 - 摩拉
    public static readonly List<MaterialModel> AllMaterialMora = [MaterialConstants._3010001];

    // 302 - 角色经验素材
    public static readonly List<MaterialModel> AllMaterialCharacterExp = [];

    // 303 - 角色与武器培养素材_234
    public static readonly List<MaterialModel> AllMaterialCharacterWeaponEnhancement1 = [];

    // 304 - 角色与武器培养素材_123
    public static readonly List<MaterialModel> AllMaterialCharacterWeaponEnhancement2 = [];

    // 305 - 角色培养素材_周本
    public static readonly List<MaterialModel> AllMaterialCharacterLevelUp1 = [];

    // 306 - 角色培养素材_40体力BOSS
    public static readonly List<MaterialModel> AllMaterialCharacterLevelUp2 = [];

    // 307 - 角色突破素材_钻儿块儿片儿粒儿
    public static readonly List<MaterialModel> AllMaterialCharacterAscension = [];

    // 308 - 角色天赋素材
    public static readonly List<MaterialModel> AllMaterialCharacterTalent = [];

    // 309 - 武器突破素材
    public static readonly List<MaterialModel> AllMaterialWeaponAscension = [];

    // 310 - 地方特产
    public static readonly List<MaterialModel> AllMaterialLocalSpecialty =
    [
        MaterialConstants._3100101
    ];

    // 4 - 秘境
    // 5 - 圣遗物
    public static readonly List<ArtifactSetModel> AllArtifactSetEntities =
    [
        ArtifactConstants._501, ArtifactConstants._502, ArtifactConstants._503, ArtifactConstants._504, ArtifactConstants._505, ArtifactConstants._506, ArtifactConstants._507, ArtifactConstants._508,
        ArtifactConstants._509, ArtifactConstants._510, ArtifactConstants._511, ArtifactConstants._512, ArtifactConstants._513, ArtifactConstants._514, ArtifactConstants._515, ArtifactConstants._516,
        ArtifactConstants._517, ArtifactConstants._518, ArtifactConstants._519, ArtifactConstants._520, ArtifactConstants._521, ArtifactConstants._522, ArtifactConstants._523, ArtifactConstants._524,
        ArtifactConstants._525, ArtifactConstants._526, ArtifactConstants._527, ArtifactConstants._528, ArtifactConstants._529, ArtifactConstants._530, ArtifactConstants._531, ArtifactConstants._532,
        ArtifactConstants._533, ArtifactConstants._534, ArtifactConstants._535, ArtifactConstants._536, ArtifactConstants._537, ArtifactConstants._538, ArtifactConstants._539, ArtifactConstants._540,
        ArtifactConstants._541, ArtifactConstants._542, ArtifactConstants._543, ArtifactConstants._544, ArtifactConstants._545, ArtifactConstants._546, ArtifactConstants._547, ArtifactConstants._548,
        ArtifactConstants._549, ArtifactConstants._550, ArtifactConstants._551, ArtifactConstants._552, ArtifactConstants._553, ArtifactConstants._554, ArtifactConstants._555, ArtifactConstants._556,
        ArtifactConstants._557,
    ];
}