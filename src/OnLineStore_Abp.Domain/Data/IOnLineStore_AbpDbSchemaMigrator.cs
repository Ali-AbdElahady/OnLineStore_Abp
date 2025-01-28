using System.Threading.Tasks;

namespace OnLineStore_Abp.Data;

public interface IOnLineStore_AbpDbSchemaMigrator
{
    Task MigrateAsync();
}
