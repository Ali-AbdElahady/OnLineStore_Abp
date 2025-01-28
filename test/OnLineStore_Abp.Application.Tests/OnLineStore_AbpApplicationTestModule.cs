using Volo.Abp.Modularity;

namespace OnLineStore_Abp;

[DependsOn(
    typeof(OnLineStore_AbpApplicationModule),
    typeof(OnLineStore_AbpDomainTestModule)
)]
public class OnLineStore_AbpApplicationTestModule : AbpModule
{

}
