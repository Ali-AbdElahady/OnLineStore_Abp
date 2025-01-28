using OnLineStore_Abp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace OnLineStore_Abp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(OnLineStore_AbpEntityFrameworkCoreModule),
    typeof(OnLineStore_AbpApplicationContractsModule)
    )]
public class OnLineStore_AbpDbMigratorModule : AbpModule
{
}
