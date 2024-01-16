using Xunit;

namespace Emenu.Productmanagement.EntityFrameworkCore;

[CollectionDefinition(ProductmanagementTestConsts.CollectionDefinitionName)]
public class ProductmanagementEntityFrameworkCoreCollection : ICollectionFixture<ProductmanagementEntityFrameworkCoreFixture>
{

}
