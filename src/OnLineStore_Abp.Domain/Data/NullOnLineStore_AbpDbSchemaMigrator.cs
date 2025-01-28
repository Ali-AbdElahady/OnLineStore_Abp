using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace OnLineStore_Abp.Data;

/* This is used if database provider does't define
 * IOnLineStore_AbpDbSchemaMigrator implementation.
 */
public class NullOnLineStore_AbpDbSchemaMigrator : IOnLineStore_AbpDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
