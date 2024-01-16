using Volo.Abp.Modularity;

namespace Emenu.Productmanagement;

[DependsOn(
    typeof(ProductmanagementDomainModule),
    typeof(ProductmanagementTestBaseModule)
)]
public class ProductmanagementDomainTestModule : AbpModule
{

}
