using Emenu.Productmanagement.Samples;
using Xunit;

namespace Emenu.Productmanagement.EntityFrameworkCore.Applications;

[Collection(ProductmanagementTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ProductmanagementEntityFrameworkCoreTestModule>
{

}
