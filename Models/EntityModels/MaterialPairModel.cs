namespace HexereiKatepnha.Models.EntityModels;

public class MaterialPairModel
{
    public MaterialModel? MaterialModel { get; set; }
    public double DropNum { get; set; }
}

public static class MaterialPairModelTools
{
    public static List<MaterialPairModel> GetMaterialPairList(MaterialGroupModel groupModel, List<double> rateList)
    {
        List<MaterialPairModel> res = [];
        for (int i = 0; i < groupModel.MaterialList.Count; i++)
        {
            res.Add(new MaterialPairModel() { MaterialModel = groupModel.MaterialList[i], DropNum = rateList[i] });
        }

        return res;
    }

    public static List<MaterialPairModel> GetMaterialPairList(MaterialModel materialModel, double rate)
    {
        List<MaterialPairModel> res = [];
        res.Add(new MaterialPairModel() { MaterialModel = materialModel, DropNum = rate });
        return res;
    }

    public static List<MaterialPairModel> GetMaterialPairList(List<List<MaterialPairModel>> complexList)
    {
        List<MaterialPairModel> res = [];
        for (int i = 0; i < complexList.Count; i++)
        {
            List<MaterialPairModel> thisList = complexList[i];
            for (int j = 0; j < thisList.Count; j++)
            {
                res.Add(thisList[j]);
            }
        }

        return res;
    }
}