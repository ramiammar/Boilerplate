using Volo.Abp.Modularity;

namespace Emenu.Productmanagement;

public abstract class ProductmanagementApplicationTestBase<TStartupModule> : ProductmanagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
