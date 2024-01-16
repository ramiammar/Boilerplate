using Emenu.Productmanagement.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Emenu.Productmanagement.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ProductmanagementEntityFrameworkCoreModule),
    typeof(ProductmanagementApplicationContractsModule)
    )]
public class ProductmanagementDbMigratorModule : AbpModule
{
}
