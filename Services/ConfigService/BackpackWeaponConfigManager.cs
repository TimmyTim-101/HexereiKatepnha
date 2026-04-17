using CommunityToolkit.Mvvm.Messaging;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Models.ConfigModels;
using HexereiKatepnha.Models.Messages;

namespace HexereiKatepnha.Services.ConfigService;

public class BackpackWeaponConfigManager : ConfigManagerBase<BackpackWeaponConfig>
{
    protected sealed override string ConfigFileName { get; set; }

    public BackpackWeaponConfigManager(Guid accountGuid)
    {
        ConfigFileName = "Configs/" + accountGuid + "/BackpackWeapon.json";
    }

    public void UpdateLevel(string weaponStringId, Enumeration.Level l)
    {
        SingleBackpackWeaponConfigModel thisWeaponConfig = Configuration.WeaponConfigMap[weaponStringId];
        thisWeaponConfig.Level = l;
        thisWeaponConfig.SubExp = 0;
        Save();
        WeakReferenceMessenger.Default.Send(new WeaponInfoChangeMessage(weaponStringId));
        if (thisWeaponConfig.CharacterRid != 0)
        {
            WeakReferenceMessenger.Default.Send(new WeaponInfoUpdateToCharacterMessage(thisWeaponConfig.CharacterRid));
        }
    }

    public void UpdateLevelGoal(string weaponStringId, Enumeration.Level l)
    {
        SingleBackpackWeaponConfigModel thisWeaponConfig = Configuration.WeaponConfigMap[weaponStringId];
        thisWeaponConfig.GoalLevel = l;
        Save();
        WeakReferenceMessenger.Default.Send(new WeaponInfoChangeMessage(weaponStringId));
        if (thisWeaponConfig.CharacterRid != 0)
        {
            WeakReferenceMessenger.Default.Send(new WeaponInfoUpdateToCharacterMessage(thisWeaponConfig.CharacterRid));
        }
    }

    public void UpdateProgression(string weaponStringId, int i)
    {
        Configuration.WeaponConfigMap[weaponStringId].Progression = i;
        Save();
        if (Configuration.WeaponConfigMap[weaponStringId].CharacterRid != 0)
        {
            WeakReferenceMessenger.Default.Send(new WeaponInfoUpdateToCharacterMessage(Configuration.WeaponConfigMap[weaponStringId].CharacterRid));
        }
    }

    public SingleBackpackWeaponConfigModel AddWeapon(int rid)
    {
        SingleBackpackWeaponConfigModel thisConfig = new()
        {
            Rid = rid
        };
        string randomUniqueSign = Guid.NewGuid().ToString("N");
        thisConfig.Id = $"{rid}${randomUniqueSign}";
        Configuration.WeaponConfigMap[thisConfig.Id] = thisConfig;
        Save();
        return thisConfig;
    }

    public void DeleteWeapon(string? id)
    {
        if (id == null) return;
        if (Configuration.WeaponConfigMap[id].CharacterRid != 0)
        {
            App.BackpackCharacterConfigManagerInstance!.UpdateWeapon(Configuration.WeaponConfigMap[id].CharacterRid, "");
            Configuration.WeaponConfigMap.Remove(id);
            Save();
            WeakReferenceMessenger.Default.Send(new WeaponDeleteMessage(id));
        }
    }

    public void UpdateSubExp(string planId, int subExp)
    {
        Configuration.WeaponConfigMap[planId].SubExp = subExp;
        Save();
        WeakReferenceMessenger.Default.Send(new PlanChangeMessage());
    }

    public void UpdateCharacter(string weaponId, int characterRid)
    {
        Configuration.WeaponConfigMap[weaponId].CharacterRid = characterRid;
        Save();
        WeakReferenceMessenger.Default.Send(new WeaponCharacterChangeMessage(weaponId));
    }
}