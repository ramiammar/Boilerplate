using Emenu.Productmanagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Emenu.Productmanagement.Permissions;

public class ProductmanagementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ProductmanagementPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ProductmanagementPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ProductmanagementResource>(name);
    }
}
