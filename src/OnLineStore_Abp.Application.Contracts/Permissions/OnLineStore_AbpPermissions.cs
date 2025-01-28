namespace OnLineStore_Abp.Permissions;

public static class OnLineStore_AbpPermissions
{
    public const string MainGroupName = "OnLineStore_Abp";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
    public const string ProductGroupName = MainGroupName + ".Products";
    public const string CreateEditProductPermission = ProductGroupName + ".CreateEdit";
    public const string DeleteProductPermission = ProductGroupName + ".Delete";
    public const string GetProductPermission = ProductGroupName + ".Get";
    public const string ListProductPermission = ProductGroupName + ".List";
}
