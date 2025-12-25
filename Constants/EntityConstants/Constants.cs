namespace HexereiKatepnha.Constants.EntityConstants;

public static class Constants
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
        { 2, "/Resources/Images/Star/Icon_1_Star.png" },
        { 3, "/Resources/Images/Star/Icon_1_Star.png" },
        { 4, "/Resources/Images/Star/Icon_1_Star.png" },
        { 5, "/Resources/Images/Star/Icon_1_Star.png" },
    };
}