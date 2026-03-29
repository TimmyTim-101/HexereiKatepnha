using HexereiKatepnha.Models.ConfigModels;

namespace HexereiKatepnha.Services.ConfigService;

public class BackpackMaterialConfigManager : ConfigManagerBase<BackpackMaterialConfig>
{
    protected sealed override string ConfigFileName { get; set; }

    public BackpackMaterialConfigManager(Guid accountGuid)
    {
        ConfigFileName = "Configs/" + accountGuid + "/BackpackMaterial.json";
    }

    public int GetMaterialNumber(int materialId)
    {
        return Configuration.MaterialNumberMap.GetValueOrDefault(materialId, 0);
    }

    public void UpdateMaterialNumber(int materialId, int num)
    {
        if (num >= 0)
        {
            Configuration.MaterialNumberMap[materialId] = num;
            Save();
            App.RefreshGoalSimulation();
        }
    }
}