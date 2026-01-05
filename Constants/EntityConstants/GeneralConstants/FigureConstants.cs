using HexereiKatepnha.Models.EntityModels;

namespace HexereiKatepnha.Constants.EntityConstants;

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

    public static readonly Dictionary<Enumeration.Level, double> Weapon1AttackMap = new()
    {
        { Enumeration.Level.L1, 23 }, { Enumeration.Level.L2, 25 }, { Enumeration.Level.L3, 27 }, { Enumeration.Level.L4, 29 }, { Enumeration.Level.L5, 30 },
        { Enumeration.Level.L6, 32 }, { Enumeration.Level.L7, 34 }, { Enumeration.Level.L8, 36 }, { Enumeration.Level.L9, 37 }, { Enumeration.Level.L10, 39 },
        { Enumeration.Level.L11, 41 }, { Enumeration.Level.L12, 42 }, { Enumeration.Level.L13, 44 }, { Enumeration.Level.L14, 46 }, { Enumeration.Level.L15, 48 },
        { Enumeration.Level.L16, 49 }, { Enumeration.Level.L17, 51 }, { Enumeration.Level.L18, 53 }, { Enumeration.Level.L19, 55 }, { Enumeration.Level.L20, 56 }, { Enumeration.Level.L20P, 68 },
        { Enumeration.Level.L21, 70 }, { Enumeration.Level.L22, 71 }, { Enumeration.Level.L23, 73 }, { Enumeration.Level.L24, 75 }, { Enumeration.Level.L25, 76 },
        { Enumeration.Level.L26, 78 }, { Enumeration.Level.L27, 80 }, { Enumeration.Level.L28, 82 }, { Enumeration.Level.L29, 83 }, { Enumeration.Level.L30, 85 },
        { Enumeration.Level.L31, 87 }, { Enumeration.Level.L32, 88 }, { Enumeration.Level.L33, 90 }, { Enumeration.Level.L34, 92 }, { Enumeration.Level.L35, 93 },
        { Enumeration.Level.L36, 95 }, { Enumeration.Level.L37, 97 }, { Enumeration.Level.L38, 98 }, { Enumeration.Level.L39, 100 }, { Enumeration.Level.L40, 102 }, { Enumeration.Level.L40P, 113 },
        { Enumeration.Level.L41, 115 }, { Enumeration.Level.L42, 116 }, { Enumeration.Level.L43, 118 }, { Enumeration.Level.L44, 120 }, { Enumeration.Level.L45, 121 },
        { Enumeration.Level.L46, 123 }, { Enumeration.Level.L47, 125 }, { Enumeration.Level.L48, 126 }, { Enumeration.Level.L49, 128 }, { Enumeration.Level.L50, 130 }, { Enumeration.Level.L50P, 141 },
        { Enumeration.Level.L51, 143 }, { Enumeration.Level.L52, 145 }, { Enumeration.Level.L53, 146 }, { Enumeration.Level.L54, 148 }, { Enumeration.Level.L55, 149 },
        { Enumeration.Level.L56, 151 }, { Enumeration.Level.L57, 153 }, { Enumeration.Level.L58, 154 }, { Enumeration.Level.L59, 156 }, { Enumeration.Level.L60, 158 }, { Enumeration.Level.L60P, 169 },
        { Enumeration.Level.L61, 171 }, { Enumeration.Level.L62, 173 }, { Enumeration.Level.L63, 174 }, { Enumeration.Level.L64, 176 }, { Enumeration.Level.L65, 177 },
        { Enumeration.Level.L66, 179 }, { Enumeration.Level.L67, 181 }, { Enumeration.Level.L68, 182 }, { Enumeration.Level.L69, 184 }, { Enumeration.Level.L70, 185 },
    };

    public static readonly Dictionary<Enumeration.Level, double> Weapon1SubAffixMap = new()
    {
        { Enumeration.Level.L1, 0 }, { Enumeration.Level.L2, 0 }, { Enumeration.Level.L3, 0 }, { Enumeration.Level.L4, 0 }, { Enumeration.Level.L5, 0 },
        { Enumeration.Level.L6, 0 }, { Enumeration.Level.L7, 0 }, { Enumeration.Level.L8, 0 }, { Enumeration.Level.L9, 0 }, { Enumeration.Level.L10, 0 },
        { Enumeration.Level.L11, 0 }, { Enumeration.Level.L12, 0 }, { Enumeration.Level.L13, 0 }, { Enumeration.Level.L14, 0 }, { Enumeration.Level.L15, 0 },
        { Enumeration.Level.L16, 0 }, { Enumeration.Level.L17, 0 }, { Enumeration.Level.L18, 0 }, { Enumeration.Level.L19, 0 }, { Enumeration.Level.L20, 0 }, { Enumeration.Level.L20P, 0 },
        { Enumeration.Level.L21, 0 }, { Enumeration.Level.L22, 0 }, { Enumeration.Level.L23, 0 }, { Enumeration.Level.L24, 0 }, { Enumeration.Level.L25, 0 },
        { Enumeration.Level.L26, 0 }, { Enumeration.Level.L27, 0 }, { Enumeration.Level.L28, 0 }, { Enumeration.Level.L29, 0 }, { Enumeration.Level.L30, 0 },
        { Enumeration.Level.L31, 0 }, { Enumeration.Level.L32, 0 }, { Enumeration.Level.L33, 0 }, { Enumeration.Level.L34, 0 }, { Enumeration.Level.L35, 0 },
        { Enumeration.Level.L36, 0 }, { Enumeration.Level.L37, 0 }, { Enumeration.Level.L38, 0 }, { Enumeration.Level.L39, 0 }, { Enumeration.Level.L40, 0 }, { Enumeration.Level.L40P, 0 },
        { Enumeration.Level.L41, 0 }, { Enumeration.Level.L42, 0 }, { Enumeration.Level.L43, 0 }, { Enumeration.Level.L44, 0 }, { Enumeration.Level.L45, 0 },
        { Enumeration.Level.L46, 0 }, { Enumeration.Level.L47, 0 }, { Enumeration.Level.L48, 0 }, { Enumeration.Level.L49, 0 }, { Enumeration.Level.L50, 0 }, { Enumeration.Level.L50P, 0 },
        { Enumeration.Level.L51, 0 }, { Enumeration.Level.L52, 0 }, { Enumeration.Level.L53, 0 }, { Enumeration.Level.L54, 0 }, { Enumeration.Level.L55, 0 },
        { Enumeration.Level.L56, 0 }, { Enumeration.Level.L57, 0 }, { Enumeration.Level.L58, 0 }, { Enumeration.Level.L59, 0 }, { Enumeration.Level.L60, 0 }, { Enumeration.Level.L60P, 0 },
        { Enumeration.Level.L61, 0 }, { Enumeration.Level.L62, 0 }, { Enumeration.Level.L63, 0 }, { Enumeration.Level.L64, 0 }, { Enumeration.Level.L65, 0 },
        { Enumeration.Level.L66, 0 }, { Enumeration.Level.L67, 0 }, { Enumeration.Level.L68, 0 }, { Enumeration.Level.L69, 0 }, { Enumeration.Level.L70, 0 },
    };

    public static Dictionary<Enumeration.Level, List<MaterialPairModel>> GetWeapon1LevelUpMaterial(MaterialGroupModel g304, MaterialGroupModel g303, MaterialGroupModel g309)
    {
        return new Dictionary<Enumeration.Level, List<MaterialPairModel>>
        {
            { Enumeration.Level.L1, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 125 }] },
            { Enumeration.Level.L2, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 200 }] },
            { Enumeration.Level.L3, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 275 }] },
            { Enumeration.Level.L4, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 350 }] },
            { Enumeration.Level.L5, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 475 }] },
            { Enumeration.Level.L6, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 575 }] },
            { Enumeration.Level.L7, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 700 }] },
            { Enumeration.Level.L8, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 850 }] },
            { Enumeration.Level.L9, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 1000 }] },
            { Enumeration.Level.L10, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 1150 }] },
            { Enumeration.Level.L11, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 1300 }] },
            { Enumeration.Level.L12, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 1475 }] },
            { Enumeration.Level.L13, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 1650 }] },
            { Enumeration.Level.L14, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 1850 }] },
            { Enumeration.Level.L15, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 2050 }] },
            { Enumeration.Level.L16, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 2250 }] },
            { Enumeration.Level.L17, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 2450 }] },
            { Enumeration.Level.L18, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 2675 }] },
            { Enumeration.Level.L19, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 2925 }] },
            {
                Enumeration.Level.L20, [
                    new MaterialPairModel() { MaterialModel = g304.MaterialList[2], DropNum = 1 },
                    new MaterialPairModel() { MaterialModel = g303.MaterialList[2], DropNum = 1 },
                    new MaterialPairModel() { MaterialModel = g309.MaterialList[3], DropNum = 1 },
                ]
            },
            { Enumeration.Level.L20P, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 3150 }] },
            { Enumeration.Level.L21, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 3575 }] },
            { Enumeration.Level.L22, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 3825 }] },
            { Enumeration.Level.L23, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 4100 }] },
            { Enumeration.Level.L24, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 4400 }] },
            { Enumeration.Level.L25, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 4700 }] },
            { Enumeration.Level.L26, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 5000 }] },
            { Enumeration.Level.L27, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 5300 }] },
            { Enumeration.Level.L28, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 5600 }] },
            { Enumeration.Level.L29, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 5925 }] },
            { Enumeration.Level.L30, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 6275 }] },
            { Enumeration.Level.L31, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 6600 }] },
            { Enumeration.Level.L32, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 6950 }] },
            { Enumeration.Level.L33, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 7325 }] },
            { Enumeration.Level.L34, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 7675 }] },
            { Enumeration.Level.L35, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 8050 }] },
            { Enumeration.Level.L36, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 8425 }] },
            { Enumeration.Level.L37, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 8825 }] },
            { Enumeration.Level.L38, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 9225 }] },
            { Enumeration.Level.L39, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 9625 }] },
            {
                Enumeration.Level.L40, [
                    new MaterialPairModel() { MaterialModel = g304.MaterialList[2], DropNum = 2 },
                    new MaterialPairModel() { MaterialModel = g303.MaterialList[2], DropNum = 4 },
                    new MaterialPairModel() { MaterialModel = g309.MaterialList[2], DropNum = 1 },
                    new MaterialPairModel() { MaterialModel = MaterialConstants._3010001, DropNum = 5000 },
                ]
            },
            { Enumeration.Level.L40P, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 10025 }] },
            { Enumeration.Level.L41, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 10975 }] },
            { Enumeration.Level.L42, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 11425 }] },
            { Enumeration.Level.L43, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 11875 }] },
            { Enumeration.Level.L44, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 12350 }] },
            { Enumeration.Level.L45, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 12825 }] },
            { Enumeration.Level.L46, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 13300 }] },
            { Enumeration.Level.L47, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 13775 }] },
            { Enumeration.Level.L48, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 14275 }] },
            { Enumeration.Level.L49, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 14800 }] },
            {
                Enumeration.Level.L50, [
                    new MaterialPairModel() { MaterialModel = g304.MaterialList[1], DropNum = 2 },
                    new MaterialPairModel() { MaterialModel = g303.MaterialList[1], DropNum = 2 },
                    new MaterialPairModel() { MaterialModel = g309.MaterialList[2], DropNum = 2 },
                    new MaterialPairModel() { MaterialModel = MaterialConstants._3010001, DropNum = 5000 },
                ]
            },
            { Enumeration.Level.L50P, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 15300 }] },
            { Enumeration.Level.L51, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 16625 }] },
            { Enumeration.Level.L52, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 17175 }] },
            { Enumeration.Level.L53, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 17725 }] },
            { Enumeration.Level.L54, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 18300 }] },
            { Enumeration.Level.L55, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 18875 }] },
            { Enumeration.Level.L56, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 19475 }] },
            { Enumeration.Level.L57, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 20075 }] },
            { Enumeration.Level.L58, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 20675 }] },
            { Enumeration.Level.L59, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 21300 }] },
            {
                Enumeration.Level.L60, [
                    new MaterialPairModel() { MaterialModel = g304.MaterialList[1], DropNum = 3 },
                    new MaterialPairModel() { MaterialModel = g303.MaterialList[1], DropNum = 4 },
                    new MaterialPairModel() { MaterialModel = g309.MaterialList[1], DropNum = 1 },
                    new MaterialPairModel() { MaterialModel = MaterialConstants._3010001, DropNum = 10000 },
                ]
            },
            { Enumeration.Level.L60P, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 21925 }] },
            { Enumeration.Level.L61, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 23675 }] },
            { Enumeration.Level.L62, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 24350 }] },
            { Enumeration.Level.L63, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 25025 }] },
            { Enumeration.Level.L64, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 25700 }] },
            { Enumeration.Level.L65, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 26400 }] },
            { Enumeration.Level.L66, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 27125 }] },
            { Enumeration.Level.L67, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 27825 }] },
            { Enumeration.Level.L68, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 28550 }] },
            { Enumeration.Level.L69, [new MaterialPairModel() { MaterialModel = MaterialConstants._3110001, DropNum = 29275 }] },
        };
    }
}