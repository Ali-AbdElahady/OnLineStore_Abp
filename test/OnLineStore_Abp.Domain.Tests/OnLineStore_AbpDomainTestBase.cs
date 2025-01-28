using Volo.Abp.Modularity;

namespace OnLineStore_Abp;

/* Inherit from this class for your domain layer tests. */
public abstract class OnLineStore_AbpDomainTestBase<TStartupModule> : OnLineStore_AbpTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
