namespace HexereiKatepnha.Models.EntityModels;

public class MaterialGroupModel
{
    public MaterialModel? StartIMaterial { get; set; }
    public List<MaterialModel> MaterialList { get; set; }
    public int Interval { get; set; }

    public MaterialGroupModel(List<MaterialModel> list, int interval)
    {
        MaterialList = list;
        StartIMaterial = list[0];
        Interval = interval;
    }
}