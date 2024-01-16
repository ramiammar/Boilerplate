using Microsoft.AspNetCore.Builder;
using Emenu.Productmanagement;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<ProductmanagementWebTestModule>();

public partial class Program
{
}
