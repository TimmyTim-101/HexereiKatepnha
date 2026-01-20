using HexereiKatepnha.Models.EntityModels;

namespace HexereiKatepnha.Constants.EntityConstants.GeneralConstants;

public static class CharacterLevelUpConstants
{
    public static Dictionary<Enumeration.Level, List<MaterialPairModel>> GetCharacterLevelUpMaterial(
        MaterialModel i310, // 地方特产
        MaterialModel i306, // 40体力BOSS
        MaterialGroupModel g307, // 粒儿片儿钻儿块儿
        MaterialGroupModel g304 // 普通材料
    )
    {
        return new Dictionary<Enumeration.Level, List<MaterialPairModel>>
        {
            { Enumeration.Level.L1, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 1000 }] },
            { Enumeration.Level.L2, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 1325 }] },
            { Enumeration.Level.L3, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 1700 }] },
            { Enumeration.Level.L4, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 2150 }] },
            { Enumeration.Level.L5, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 2625 }] },
            { Enumeration.Level.L6, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 3150 }] },
            { Enumeration.Level.L7, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 3725 }] },
            { Enumeration.Level.L8, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 4350 }] },
            { Enumeration.Level.L9, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 5000 }] },
            { Enumeration.Level.L10, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 5700 }] },
            { Enumeration.Level.L11, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 6450 }] },
            { Enumeration.Level.L12, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 7225 }] },
            { Enumeration.Level.L13, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 8050 }] },
            { Enumeration.Level.L14, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 8925 }] },
            { Enumeration.Level.L15, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 9825 }] },
            { Enumeration.Level.L16, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 10750 }] },
            { Enumeration.Level.L17, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 11725 }] },
            { Enumeration.Level.L18, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 12725 }] },
            { Enumeration.Level.L19, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 13775 }] },
            {
                Enumeration.Level.L20, [
                    new MaterialPairModel() { MaterialModel = MaterialConstants._3010001, DropNum = 20000 },
                    new MaterialPairModel() { MaterialModel = g307.MaterialList[3], DropNum = 1 },
                    new MaterialPairModel() { MaterialModel = i310, DropNum = 3 },
                    new MaterialPairModel() { MaterialModel = g304.MaterialList[2], DropNum = 3 },
                ]
            },
            { Enumeration.Level.L20P, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 14875 }] },
            { Enumeration.Level.L21, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 16800 }] },
            { Enumeration.Level.L22, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 18000 }] },
            { Enumeration.Level.L23, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 19250 }] },
            { Enumeration.Level.L24, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 20550 }] },
            { Enumeration.Level.L25, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 21875 }] },
            { Enumeration.Level.L26, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 23250 }] },
            { Enumeration.Level.L27, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 24650 }] },
            { Enumeration.Level.L28, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 26100 }] },
            { Enumeration.Level.L29, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 27575 }] },
            { Enumeration.Level.L30, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 29100 }] },
            { Enumeration.Level.L31, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 30650 }] },
            { Enumeration.Level.L32, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 32250 }] },
            { Enumeration.Level.L33, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 33875 }] },
            { Enumeration.Level.L34, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 35550 }] },
            { Enumeration.Level.L35, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 37250 }] },
            { Enumeration.Level.L36, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 38975 }] },
            { Enumeration.Level.L37, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 40750 }] },
            { Enumeration.Level.L38, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 42575 }] },
            { Enumeration.Level.L39, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 44425 }] },
            {
                Enumeration.Level.L40, [
                    new MaterialPairModel() { MaterialModel = MaterialConstants._3010001, DropNum = 40000 },
                    new MaterialPairModel() { MaterialModel = g307.MaterialList[2], DropNum = 3 },
                    new MaterialPairModel() { MaterialModel = i306, DropNum = 2 },
                    new MaterialPairModel() { MaterialModel = i310, DropNum = 10 },
                    new MaterialPairModel() { MaterialModel = g304.MaterialList[2], DropNum = 15 },
                ]
            },
            { Enumeration.Level.L40P, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 46300 }] },
            { Enumeration.Level.L41, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 50625 }] },
            { Enumeration.Level.L42, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 52700 }] },
            { Enumeration.Level.L43, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 54775 }] },
            { Enumeration.Level.L44, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 56900 }] },
            { Enumeration.Level.L45, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 59075 }] },
            { Enumeration.Level.L46, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 61275 }] },
            { Enumeration.Level.L47, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 63525 }] },
            { Enumeration.Level.L48, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 65800 }] },
            { Enumeration.Level.L49, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 68125 }] },
            {
                Enumeration.Level.L50, [
                    new MaterialPairModel() { MaterialModel = MaterialConstants._3010001, DropNum = 60000 },
                    new MaterialPairModel() { MaterialModel = g307.MaterialList[2], DropNum = 6 },
                    new MaterialPairModel() { MaterialModel = i306, DropNum = 4 },
                    new MaterialPairModel() { MaterialModel = i310, DropNum = 20 },
                    new MaterialPairModel() { MaterialModel = g304.MaterialList[1], DropNum = 12 },
                ]
            },
            { Enumeration.Level.L50P, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 70475 }] },
            { Enumeration.Level.L51, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 76500 }] },
            { Enumeration.Level.L52, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 79050 }] },
            { Enumeration.Level.L53, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 81650 }] },
            { Enumeration.Level.L54, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 84275 }] },
            { Enumeration.Level.L55, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 86950 }] },
            { Enumeration.Level.L56, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 89650 }] },
            { Enumeration.Level.L57, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 92400 }] },
            { Enumeration.Level.L58, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 95175 }] },
            { Enumeration.Level.L59, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 98000 }] },
            {
                Enumeration.Level.L60, [
                    new MaterialPairModel() { MaterialModel = MaterialConstants._3010001, DropNum = 80000 },
                    new MaterialPairModel() { MaterialModel = g307.MaterialList[1], DropNum = 3 },
                    new MaterialPairModel() { MaterialModel = i306, DropNum = 8 },
                    new MaterialPairModel() { MaterialModel = i310, DropNum = 30 },
                    new MaterialPairModel() { MaterialModel = g304.MaterialList[1], DropNum = 18 },
                ]
            },
            { Enumeration.Level.L60P, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 100875 }] },
            { Enumeration.Level.L61, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 108950 }] },
            { Enumeration.Level.L62, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 112050 }] },
            { Enumeration.Level.L63, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 115175 }] },
            { Enumeration.Level.L64, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 118325 }] },
            { Enumeration.Level.L65, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 121525 }] },
            { Enumeration.Level.L66, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 124775 }] },
            { Enumeration.Level.L67, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 128075 }] },
            { Enumeration.Level.L68, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 131400 }] },
            { Enumeration.Level.L69, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 134775 }] },
            {
                Enumeration.Level.L70, [
                    new MaterialPairModel() { MaterialModel = MaterialConstants._3010001, DropNum = 100000 },
                    new MaterialPairModel() { MaterialModel = g307.MaterialList[1], DropNum = 6 },
                    new MaterialPairModel() { MaterialModel = i306, DropNum = 12 },
                    new MaterialPairModel() { MaterialModel = i310, DropNum = 45 },
                    new MaterialPairModel() { MaterialModel = g304.MaterialList[0], DropNum = 12 },
                ]
            },
            { Enumeration.Level.L70P, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 138175 }] },
            { Enumeration.Level.L71, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 148700 }] },
            { Enumeration.Level.L72, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 152375 }] },
            { Enumeration.Level.L73, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 156075 }] },
            { Enumeration.Level.L74, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 159825 }] },
            { Enumeration.Level.L75, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 163600 }] },
            { Enumeration.Level.L76, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 167425 }] },
            { Enumeration.Level.L77, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 171300 }] },
            { Enumeration.Level.L78, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 175225 }] },
            { Enumeration.Level.L79, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 179175 }] },
            {
                Enumeration.Level.L80, [
                    new MaterialPairModel() { MaterialModel = MaterialConstants._3010001, DropNum = 120000 },
                    new MaterialPairModel() { MaterialModel = g307.MaterialList[0], DropNum = 6 },
                    new MaterialPairModel() { MaterialModel = i306, DropNum = 20 },
                    new MaterialPairModel() { MaterialModel = i310, DropNum = 60 },
                    new MaterialPairModel() { MaterialModel = g304.MaterialList[0], DropNum = 24 },
                ]
            },
            { Enumeration.Level.L80P, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 183175 }] },
            { Enumeration.Level.L81, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 216225 }] },
            { Enumeration.Level.L82, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 243025 }] },
            { Enumeration.Level.L83, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 273100 }] },
            { Enumeration.Level.L84, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 306800 }] },
            { Enumeration.Level.L85, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 344600 }] },
            { Enumeration.Level.L86, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 386950 }] },
            { Enumeration.Level.L87, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 434425 }] },
            { Enumeration.Level.L88, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 487625 }] },
            { Enumeration.Level.L89, [new MaterialPairModel() { MaterialModel = MaterialConstants._3020001, DropNum = 547200 }] },
            { Enumeration.Level.L90, [] },
            { Enumeration.Level.L90P, [] },
            { Enumeration.Level.L95, [] },
        };
    }

    public static Dictionary<Enumeration.Level, List<MaterialPairModel>> GetCharacterTalentMaterial(
        MaterialModel i305, // 周本BOSS
        MaterialGroupModel g304, // 普通材料
        MaterialGroupModel g308 // 天赋书
    )
    {
        return new Dictionary<Enumeration.Level, List<MaterialPairModel>>()
        {
            {
                Enumeration.Level.L1, [
                    new MaterialPairModel() { MaterialModel = MaterialConstants._3010001, DropNum = 12500 },
                    new MaterialPairModel() { MaterialModel = g304.MaterialList[2], DropNum = 6 },
                    new MaterialPairModel() { MaterialModel = g308.MaterialList[2], DropNum = 3 },
                ]
            },
            {
                Enumeration.Level.L2, [
                    new MaterialPairModel() { MaterialModel = MaterialConstants._3010001, DropNum = 17500 },
                    new MaterialPairModel() { MaterialModel = g304.MaterialList[1], DropNum = 3 },
                    new MaterialPairModel() { MaterialModel = g308.MaterialList[1], DropNum = 2 },
                ]
            },
            {
                Enumeration.Level.L3, [
                    new MaterialPairModel() { MaterialModel = MaterialConstants._3010001, DropNum = 25000 },
                    new MaterialPairModel() { MaterialModel = g304.MaterialList[1], DropNum = 4 },
                    new MaterialPairModel() { MaterialModel = g308.MaterialList[1], DropNum = 4 },
                ]
            },
            {
                Enumeration.Level.L4, [
                    new MaterialPairModel() { MaterialModel = MaterialConstants._3010001, DropNum = 30000 },
                    new MaterialPairModel() { MaterialModel = g304.MaterialList[1], DropNum = 6 },
                    new MaterialPairModel() { MaterialModel = g308.MaterialList[1], DropNum = 6 },
                ]
            },
            {
                Enumeration.Level.L5, [
                    new MaterialPairModel() { MaterialModel = MaterialConstants._3010001, DropNum = 37500 },
                    new MaterialPairModel() { MaterialModel = g304.MaterialList[1], DropNum = 9 },
                    new MaterialPairModel() { MaterialModel = g308.MaterialList[1], DropNum = 9 },
                ]
            },
            {
                Enumeration.Level.L6, [
                    new MaterialPairModel() { MaterialModel = MaterialConstants._3010001, DropNum = 120000 },
                    new MaterialPairModel() { MaterialModel = g304.MaterialList[0], DropNum = 4 },
                    new MaterialPairModel() { MaterialModel = g308.MaterialList[0], DropNum = 4 },
                    new MaterialPairModel() { MaterialModel = i305, DropNum = 1 },
                ]
            },
            {
                Enumeration.Level.L7, [
                    new MaterialPairModel() { MaterialModel = MaterialConstants._3010001, DropNum = 260000 },
                    new MaterialPairModel() { MaterialModel = g304.MaterialList[0], DropNum = 6 },
                    new MaterialPairModel() { MaterialModel = g308.MaterialList[0], DropNum = 6 },
                    new MaterialPairModel() { MaterialModel = i305, DropNum = 1 },
                ]
            },
            {
                Enumeration.Level.L8, [
                    new MaterialPairModel() { MaterialModel = MaterialConstants._3010001, DropNum = 450000 },
                    new MaterialPairModel() { MaterialModel = g304.MaterialList[0], DropNum = 9 },
                    new MaterialPairModel() { MaterialModel = g308.MaterialList[0], DropNum = 12 },
                    new MaterialPairModel() { MaterialModel = i305, DropNum = 2 },
                ]
            },
            {
                Enumeration.Level.L9, [
                    new MaterialPairModel() { MaterialModel = MaterialConstants._3010001, DropNum = 700000 },
                    new MaterialPairModel() { MaterialModel = g304.MaterialList[0], DropNum = 12 },
                    new MaterialPairModel() { MaterialModel = g308.MaterialList[0], DropNum = 16 },
                    new MaterialPairModel() { MaterialModel = i305, DropNum = 2 },
                    new MaterialPairModel() { MaterialModel = MaterialConstants._3080000, DropNum = 1 },
                ]
            },
        };
    }
}