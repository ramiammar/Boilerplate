using Volo.Abp.Modularity;

namespace Emenu.Productmanagement;

/* Inherit from this class for your domain layer tests. */
public abstract class ProductmanagementDomainTestBase<TStartupModule> : ProductmanagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
