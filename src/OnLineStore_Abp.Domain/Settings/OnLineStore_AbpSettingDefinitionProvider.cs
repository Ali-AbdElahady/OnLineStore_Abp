using Volo.Abp.Settings;

namespace OnLineStore_Abp.Settings;

public class OnLineStore_AbpSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(OnLineStore_AbpSettings.MySetting1));
    }
}
