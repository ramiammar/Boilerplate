using Emenu.Productmanagement.Samples;
using Xunit;

namespace Emenu.Productmanagement.EntityFrameworkCore.Domains;

[Collection(ProductmanagementTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ProductmanagementEntityFrameworkCoreTestModule>
{

}
