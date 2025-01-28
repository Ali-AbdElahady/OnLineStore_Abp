using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace OnLineStore_Abp.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class OnLineStore_AbpDbContextFactory : IDesignTimeDbContextFactory<OnLineStore_AbpDbContext>
{
    public OnLineStore_AbpDbContext CreateDbContext(string[] args)
    {
        OnLineStore_AbpEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<OnLineStore_AbpDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new OnLineStore_AbpDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../OnLineStore_Abp.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
