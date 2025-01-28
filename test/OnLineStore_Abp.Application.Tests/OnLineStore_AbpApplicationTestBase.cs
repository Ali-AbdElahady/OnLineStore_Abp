using Volo.Abp.Modularity;

namespace OnLineStore_Abp;

public abstract class OnLineStore_AbpApplicationTestBase<TStartupModule> : OnLineStore_AbpTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
