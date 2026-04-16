using CommunityToolkit.Mvvm.Messaging;
using HexereiKatepnha.Models.ConfigModels;
using HexereiKatepnha.Models.Messages;

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

    public void UpdateMaterialNumber(List<int> materialIdList, List<int> numList)
    {
        bool isModify = false;
        for (int i = 0; i < materialIdList.Count; i++)
        {
            int thisMaterialId = materialIdList[i];
            int thisMaterialNum = numList[i];
            if (thisMaterialNum >= 0)
            {
                Configuration.MaterialNumberMap[thisMaterialId] = thisMaterialNum;
                isModify = true;
            }
        }

        if (isModify)
        {
            Save();
            WeakReferenceMessenger.Default.Send(new BackpackMaterialConfigChangeMessage(materialIdList));
        }
    }

    public void UpdateMaterialNumber(int materialId, int num)
    {
        UpdateMaterialNumber([materialId], [num]);
    }
}