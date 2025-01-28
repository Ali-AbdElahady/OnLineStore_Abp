using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnLineStore_Abp.Data;
using Volo.Abp.DependencyInjection;

namespace OnLineStore_Abp.EntityFrameworkCore;

public class EntityFrameworkCoreOnLineStore_AbpDbSchemaMigrator
    : IOnLineStore_AbpDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreOnLineStore_AbpDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the OnLineStore_AbpDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<OnLineStore_AbpDbContext>()
            .Database
            .MigrateAsync();
    }
}
