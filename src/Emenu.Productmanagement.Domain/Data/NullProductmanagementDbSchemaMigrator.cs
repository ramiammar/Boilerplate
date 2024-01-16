using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Emenu.Productmanagement.Data;

/* This is used if database provider does't define
 * IProductmanagementDbSchemaMigrator implementation.
 */
public class NullProductmanagementDbSchemaMigrator : IProductmanagementDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
