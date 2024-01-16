using Volo.Abp.Modularity;

namespace Emenu.Productmanagement;

[DependsOn(
    typeof(ProductmanagementApplicationModule),
    typeof(ProductmanagementDomainTestModule)
)]
public class ProductmanagementApplicationTestModule : AbpModule
{

}
