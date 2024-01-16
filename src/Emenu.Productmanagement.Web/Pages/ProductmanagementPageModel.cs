using Emenu.Productmanagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Emenu.Productmanagement.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ProductmanagementPageModel : AbpPageModel
{
    protected ProductmanagementPageModel()
    {
        LocalizationResourceType = typeof(ProductmanagementResource);
    }
}
