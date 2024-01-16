using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Emenu.Productmanagement.Web;

[Dependency(ReplaceServices = true)]
public class ProductmanagementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Productmanagement";
}
