using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Emenu.Productmanagement.Pages;

public class Index_Tests : ProductmanagementWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
