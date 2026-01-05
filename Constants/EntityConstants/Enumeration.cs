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

    public enum DungeonType
    {
        Unknown = 0,
        LocalSpecialty = 1, // 地方特产
        LeyLineOutcrop = 2, // 地脉衍出
        Easy = 3, // 普通怪物
        Elite = 4, // 精英怪物
        Boss = 5, // 40体力BOSS
        Artifact = 6, // 圣遗物
        WeaponAscension = 7, // 武器
        CharacterTalent = 8, // 天赋
        Trounce = 9, // 60体力BOSS
    }

    public enum WeaponType
    {
        Unknown = 0,
        Sword = 1,
        Claymore = 2,
        Pole = 3,
        Catalyst = 4,
        Bow = 5,
    }

    public enum Affix
    {
        Empty = -1,
        Unknown = 0,
        HealthPercent = 1, // 生命值百分比
        AttackPercent = 2, // 攻击力百分比
        DefensePercent = 3, // 防御力百分比
        EnergyRecharge = 4, // 元素充能效率
        ElementalMastery = 5, // 元素精通
        Attack = 6, // 攻击力
        CriticalRate = 7, // 暴击率
        CriticalDamage = 8, // 暴击伤害
        AdditionalHealing = 9, // 治疗加成
        Health = 10, // 生命值
        PyroDamage = 11, // 火元素伤害加成
        ElectroDamage = 12, // 雷元素伤害加成
        CryoDamage = 13, // 冰元素伤害加成
        HydroDamage = 14, // 水元素伤害加成
        AnemoDamage = 15, // 风元素伤害加成
        GeoDamage = 16, // 岩元素伤害加成
        DendroDamage = 17, // 草元素伤害加成
        PhysicalDamage = 18, // 物理伤害加成
        Defense = 19, // 防御力
    }

    public enum Level
    {
        L1,
        L2,
        L3,
        L4,
        L5,
        L6,
        L7,
        L8,
        L9,
        L10,
        L11,
        L12,
        L13,
        L14,
        L15,
        L16,
        L17,
        L18,
        L19,
        L20,
        L20P,
        L21,
        L22,
        L23,
        L24,
        L25,
        L26,
        L27,
        L28,
        L29,
        L30,
        L31,
        L32,
        L33,
        L34,
        L35,
        L36,
        L37,
        L38,
        L39,
        L40,
        L40P,
        L41,
        L42,
        L43,
        L44,
        L45,
        L46,
        L47,
        L48,
        L49,
        L50,
        L50P,
        L51,
        L52,
        L53,
        L54,
        L55,
        L56,
        L57,
        L58,
        L59,
        L60,
        L60P,
        L61,
        L62,
        L63,
        L64,
        L65,
        L66,
        L67,
        L68,
        L69,
        L70,
        L70P,
        L71,
        L72,
        L73,
        L74,
        L75,
        L76,
        L77,
        L78,
        L79,
        L80,
        L80P,
        L81,
        L82,
        L83,
        L84,
        L85,
        L86,
        L87,
        L88,
        L89,
        L90,
        L90P,
        L91,
        L92,
        L93,
        L94,
        L95,
        L96,
        L97,
        L98,
        L99,
        L100
    }
}