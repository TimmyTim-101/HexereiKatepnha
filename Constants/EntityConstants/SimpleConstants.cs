namespace HexereiKatepnha.Constants.EntityConstants;

public static class SimpleConstants
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

    public static readonly string ResinImagePath = "/Resources/Images/DungeonAndMonster/UI_ItemIcon_106.png";

    public static readonly Dictionary<int, List<double>> MaterialCharacterAscensionRate = new()
    {
        { 1, [0.0141, 0.144, 1.5961, 2.1607] },
        { 2, [0.007, 0.072, 0.7981, 1.0803] },
        { 3, [0.0047, 0.048, 0.532, 0.7202] },
        { 4, [0.0035, 0.036, 0.399, 0.5402] },
        { 5, [0.0028, 0.288, 0.3192, 0.4321] },
    };

    public static readonly Dictionary<int, List<double>> MaterialCharacterLevelUp1Rate = new()
    {
        { 1, [0.025, 0.2556, 2.0423, 3.8343] },
        { 2, [0.0125, 0.1278, 1.0212, 1.9171] },
        { 3, [0.0083, 0.0852, 0.6808, 1.2781] },
        { 5, [0.005, 0.0511, 0.4085, 0.7669] },
    };

    public static readonly List<double> MaterialCharacterTalentRate = [0.22, 1.98, 2.2];

    public static readonly List<double> MaterialWeaponAscensionRate = [0.062, 0.62, 2.418, 2.2];
}