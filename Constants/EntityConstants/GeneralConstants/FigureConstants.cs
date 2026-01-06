namespace HexereiKatepnha.Constants.EntityConstants.GeneralConstants;

public static class FigureConstants
{
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