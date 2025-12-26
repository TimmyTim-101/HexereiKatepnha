namespace HexereiKatepnha.Constants.EntityConstants;

public static class Enumeration
{
    public enum EntityType
    {
        Unknown = 0, // 未知
        Character = 1, // 角色
        Weapon = 2, // 武器
        Material = 3, // 材料
        Dungeon = 4, // 秘境
        Artifact = 5 // 圣遗物
    }

    public enum MaterialType
    {
        Unknown = 0,
        Mora = 1, // 摩拉
        CharacterExp = 2, // 角色经验素材
        CharacterWeaponEnhancement1 = 3, // 角色与武器培养素材_234
        CharacterWeaponEnhancement2 = 4, // 角色与武器培养素材_123
        CharacterLevelUp1 = 5, // 角色培养素材_周本
        CharacterLevelUp2 = 6, // 角色培养素材_40体力BOSS
        CharacterAscension = 7, // 角色突破素材_钻儿块儿片儿粒儿
        CharacterTalent = 8, // 角色天赋素材
        WeaponAscension = 9, // 武器突破素材
        LocalSpecialty = 10, // 地方特产
        WeaponExp = 11 // 武器强化素材
    }
}