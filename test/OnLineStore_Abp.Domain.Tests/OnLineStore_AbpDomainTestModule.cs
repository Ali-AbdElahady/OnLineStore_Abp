using Volo.Abp.Modularity;

namespace OnLineStore_Abp;

[DependsOn(
    typeof(OnLineStore_AbpDomainModule),
    typeof(OnLineStore_AbpTestBaseModule)
)]
public class OnLineStore_AbpDomainTestModule : AbpModule
{

}
