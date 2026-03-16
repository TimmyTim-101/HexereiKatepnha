namespace HexereiKatepnha.Models.EntityModels;

public class MaterialGroupModel(List<MaterialModel> list)
{
    public List<MaterialModel> MaterialList { get; } = list;
}