using OnLineStore_Abp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace OnLineStore_Abp.Permissions;

public class OnLineStore_AbpPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(OnLineStore_AbpPermissions.MainGroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(OnLineStore_AbpPermissions.MyPermission1, L("Permission:MyPermission1"));
        var productGroup = context.AddGroup(OnLineStore_AbpPermissions.ProductGroupName, L("OnLineStore_Abp.Products"));

        productGroup.AddPermission(OnLineStore_AbpPermissions.CreateEditProductPermission, L("Permission:Products:CreateEditProduct"));
        productGroup.AddPermission(OnLineStore_AbpPermissions.DeleteProductPermission, L("Permission:Products:DeleteProduct"));
        productGroup.AddPermission(OnLineStore_AbpPermissions.GetProductPermission, L("Permission:Products:GetProduct"));
        productGroup.AddPermission(OnLineStore_AbpPermissions.ListProductPermission, L("Permission:Products:ListProduct"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<OnLineStore_AbpResource>(name);
    }
}
