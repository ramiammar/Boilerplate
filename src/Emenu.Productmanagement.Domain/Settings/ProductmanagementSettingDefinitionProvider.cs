using Volo.Abp.Settings;

namespace Emenu.Productmanagement.Settings;

public class ProductmanagementSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ProductmanagementSettings.MySetting1));
    }
}
