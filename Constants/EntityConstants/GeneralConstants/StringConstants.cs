namespace HexereiKatepnha.Constants.EntityConstants.GeneralConstants;

public static class StringConstants
{
    // 圣遗物各位置Icon路径
    public static readonly Dictionary<int, string> ArtifactIconPath = new()
    {
        { 1, "/Resources/Icons/ArtifactIcons/UI_Icon_RelicType1.png" },
        { 2, "/Resources/Icons/ArtifactIcons/UI_Icon_RelicType2.png" },
        { 3, "/Resources/Icons/ArtifactIcons/UI_Icon_RelicType3.png" },
        { 4, "/Resources/Icons/ArtifactIcons/UI_Icon_RelicType4.png" },
        { 5, "/Resources/Icons/ArtifactIcons/UI_Icon_RelicType5.png" },
    };

    public static readonly Dictionary<int, string> StarBackgroundImagePath = new()
    {
        { 1, "/Resources/Images/Star/1_star_background.png" },
        { 2, "/Resources/Images/Star/2_star_background.png" },
        { 3, "/Resources/Images/Star/3_star_background.png" },
        { 4, "/Resources/Images/Star/4_star_background.png" },
        { 5, "/Resources/Images/Star/5_star_background.png" },
        { 6, "/Resources/Images/Star/6_star_background.png" },
    };

    public static readonly Dictionary<int, string> StarImagePath = new()
    {
        { 1, "/Resources/Images/Star/Icon_1_Star.png" },
        { 2, "/Resources/Images/Star/Icon_2_Star.png" },
        { 3, "/Resources/Images/Star/Icon_3_Star.png" },
        { 4, "/Resources/Images/Star/Icon_4_Star.png" },
        { 5, "/Resources/Images/Star/Icon_5_Star.png" },
    };

    public static readonly Dictionary<int, string> DungeonTimeString = new()
    {
        { 0, "全天" },
        { 1, "周一/周四/周日" },
        { 2, "周二/周五/周日" },
        { 3, "周三/周六/周日" },
    };

    public static readonly Dictionary<Enumeration.ElementType, string> ElementTypeString = new()
    {
        { Enumeration.ElementType.Pyro, "火" },
        { Enumeration.ElementType.Hydro, "水" },
        { Enumeration.ElementType.Anemo, "风" },
        { Enumeration.ElementType.Electro, "雷" },
        { Enumeration.ElementType.Dendro, "草" },
        { Enumeration.ElementType.Cryo, "冰" },
        { Enumeration.ElementType.Geo, "岩" },
    };

    public static readonly Dictionary<Enumeration.ElementType, string> ElementTypeImagePath = new()
    {
        { Enumeration.ElementType.Pyro, "/Resources/Images/Element/UI_Buff_Element_Fire.png" },
        { Enumeration.ElementType.Hydro, "/Resources/Images/Element/UI_Buff_Element_Water.png" },
        { Enumeration.ElementType.Anemo, "/Resources/Images/Element/UI_Buff_Element_Wind.png" },
        { Enumeration.ElementType.Electro, "/Resources/Images/Element/UI_Buff_Element_Elect.png" },
        { Enumeration.ElementType.Dendro, "/Resources/Images/Element/UI_Buff_Element_Grass.png" },
        { Enumeration.ElementType.Cryo, "/Resources/Images/Element/UI_Buff_Element_Frost.png" },
        { Enumeration.ElementType.Geo, "/Resources/Images/Element/UI_Buff_Element_Roach.png" },
    };

    public static readonly string ResinImagePath = "/Resources/Images/DungeonAndMonster/UI_ItemIcon_106.png";

    public static readonly Dictionary<Enumeration.Affix, string> AffixString = new()
    {
        { Enumeration.Affix.Empty, "（无）" },
        { Enumeration.Affix.HealthPercent, "生命值百分比" },
        { Enumeration.Affix.AttackPercent, "攻击力百分比" },
        { Enumeration.Affix.DefensePercent, "防御力百分比" },
        { Enumeration.Affix.EnergyRecharge, "元素充能效率" },
        { Enumeration.Affix.ElementalMastery, "元素精通" },
        { Enumeration.Affix.Attack, "攻击力" },
        { Enumeration.Affix.CriticalRate, "暴击率" },
        { Enumeration.Affix.CriticalDamage, "暴击伤害" },
        { Enumeration.Affix.AdditionalHealing, "治疗加成" },
        { Enumeration.Affix.Health, "生命值" },
        { Enumeration.Affix.PyroDamage, "火元素伤害加成" },
        { Enumeration.Affix.ElectroDamage, "雷元素伤害加成" },
        { Enumeration.Affix.CryoDamage, "冰元素伤害加成" },
        { Enumeration.Affix.HydroDamage, "水元素伤害加成" },
        { Enumeration.Affix.AnemoDamage, "风元素伤害加成" },
        { Enumeration.Affix.GeoDamage, "岩元素伤害加成" },
        { Enumeration.Affix.DendroDamage, "草元素伤害加成" },
        { Enumeration.Affix.PhysicalDamage, "物理伤害加成" },
        { Enumeration.Affix.Defense, "防御力" },
    };

    public static readonly Dictionary<Enumeration.WeaponType, string> WeaponTypeString = new()
    {
        { Enumeration.WeaponType.Sword, "单手剑" },
        { Enumeration.WeaponType.Claymore, "双手剑" },
        { Enumeration.WeaponType.Pole, "长柄武器" },
        { Enumeration.WeaponType.Catalyst, "法器" },
        { Enumeration.WeaponType.Bow, "弓" },
    };

    public static readonly Dictionary<Enumeration.WeaponType, string> WeaponTypeImagePath = new()
    {
        { Enumeration.WeaponType.Sword, "/Resources/Images/Weapon/UI_GachaTypeIcon_Sword.png" },
        { Enumeration.WeaponType.Claymore, "/Resources/Images/Weapon/UI_GachaTypeIcon_Claymore.png" },
        { Enumeration.WeaponType.Pole, "/Resources/Images/Weapon/UI_GachaTypeIcon_Pole.png" },
        { Enumeration.WeaponType.Catalyst, "/Resources/Images/Weapon/UI_GachaTypeIcon_Catalyst.png" },
        { Enumeration.WeaponType.Bow, "/Resources/Images/Weapon/UI_GachaTypeIcon_Bow.png" },
    };

    public static readonly Dictionary<Enumeration.Level, string> LevelString = new()
    {
        { Enumeration.Level.L1, "1" }, { Enumeration.Level.L2, "2" }, { Enumeration.Level.L3, "3" }, { Enumeration.Level.L4, "4" }, { Enumeration.Level.L5, "5" },
        { Enumeration.Level.L6, "6" }, { Enumeration.Level.L7, "7" }, { Enumeration.Level.L8, "8" }, { Enumeration.Level.L9, "9" }, { Enumeration.Level.L10, "10" },
        { Enumeration.Level.L11, "11" }, { Enumeration.Level.L12, "12" }, { Enumeration.Level.L13, "13" }, { Enumeration.Level.L14, "14" }, { Enumeration.Level.L15, "15" },
        { Enumeration.Level.L16, "16" }, { Enumeration.Level.L17, "17" }, { Enumeration.Level.L18, "18" }, { Enumeration.Level.L19, "19" }, { Enumeration.Level.L20, "20" }, { Enumeration.Level.L20P, "20+" },
        { Enumeration.Level.L21, "21" }, { Enumeration.Level.L22, "22" }, { Enumeration.Level.L23, "23" }, { Enumeration.Level.L24, "24" }, { Enumeration.Level.L25, "25" },
        { Enumeration.Level.L26, "26" }, { Enumeration.Level.L27, "27" }, { Enumeration.Level.L28, "28" }, { Enumeration.Level.L29, "29" }, { Enumeration.Level.L30, "30" },
        { Enumeration.Level.L31, "31" }, { Enumeration.Level.L32, "32" }, { Enumeration.Level.L33, "33" }, { Enumeration.Level.L34, "34" }, { Enumeration.Level.L35, "35" },
        { Enumeration.Level.L36, "36" }, { Enumeration.Level.L37, "37" }, { Enumeration.Level.L38, "38" }, { Enumeration.Level.L39, "39" }, { Enumeration.Level.L40, "40" }, { Enumeration.Level.L40P, "40+" },
        { Enumeration.Level.L41, "41" }, { Enumeration.Level.L42, "42" }, { Enumeration.Level.L43, "43" }, { Enumeration.Level.L44, "44" }, { Enumeration.Level.L45, "45" },
        { Enumeration.Level.L46, "46" }, { Enumeration.Level.L47, "47" }, { Enumeration.Level.L48, "48" }, { Enumeration.Level.L49, "49" }, { Enumeration.Level.L50, "50" }, { Enumeration.Level.L50P, "50+" },
        { Enumeration.Level.L51, "51" }, { Enumeration.Level.L52, "52" }, { Enumeration.Level.L53, "53" }, { Enumeration.Level.L54, "54" }, { Enumeration.Level.L55, "55" },
        { Enumeration.Level.L56, "56" }, { Enumeration.Level.L57, "57" }, { Enumeration.Level.L58, "58" }, { Enumeration.Level.L59, "59" }, { Enumeration.Level.L60, "60" }, { Enumeration.Level.L60P, "60+" },
        { Enumeration.Level.L61, "61" }, { Enumeration.Level.L62, "62" }, { Enumeration.Level.L63, "63" }, { Enumeration.Level.L64, "64" }, { Enumeration.Level.L65, "65" },
        { Enumeration.Level.L66, "66" }, { Enumeration.Level.L67, "67" }, { Enumeration.Level.L68, "68" }, { Enumeration.Level.L69, "69" }, { Enumeration.Level.L70, "70" }, { Enumeration.Level.L70P, "70+" },
        { Enumeration.Level.L71, "71" }, { Enumeration.Level.L72, "72" }, { Enumeration.Level.L73, "73" }, { Enumeration.Level.L74, "74" }, { Enumeration.Level.L75, "75" },
        { Enumeration.Level.L76, "76" }, { Enumeration.Level.L77, "77" }, { Enumeration.Level.L78, "78" }, { Enumeration.Level.L79, "79" }, { Enumeration.Level.L80, "80" }, { Enumeration.Level.L80P, "80+" },
        { Enumeration.Level.L81, "81" }, { Enumeration.Level.L82, "82" }, { Enumeration.Level.L83, "83" }, { Enumeration.Level.L84, "84" }, { Enumeration.Level.L85, "85" },
        { Enumeration.Level.L86, "86" }, { Enumeration.Level.L87, "87" }, { Enumeration.Level.L88, "88" }, { Enumeration.Level.L89, "89" }, { Enumeration.Level.L90, "90" }, { Enumeration.Level.L90P, "90+" },
        { Enumeration.Level.L91, "91" }, { Enumeration.Level.L92, "92" }, { Enumeration.Level.L93, "93" }, { Enumeration.Level.L94, "94" }, { Enumeration.Level.L95, "95" },
        { Enumeration.Level.L96, "96" }, { Enumeration.Level.L97, "97" }, { Enumeration.Level.L98, "98" }, { Enumeration.Level.L99, "99" }, { Enumeration.Level.L100, "100" },
        // { Enumeration.Level.L95, "95" },{ Enumeration.Level.L100, "100" },
    };
}