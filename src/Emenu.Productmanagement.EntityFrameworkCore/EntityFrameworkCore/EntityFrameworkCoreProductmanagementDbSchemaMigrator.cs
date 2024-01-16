using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Emenu.Productmanagement.Data;
using Volo.Abp.DependencyInjection;

namespace Emenu.Productmanagement.EntityFrameworkCore;

public class EntityFrameworkCoreProductmanagementDbSchemaMigrator
    : IProductmanagementDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreProductmanagementDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the ProductmanagementDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ProductmanagementDbContext>()
            .Database
            .MigrateAsync();
    }
}
