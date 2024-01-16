using Emenu.Productmanagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Emenu.Productmanagement.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ProductmanagementController : AbpControllerBase
{
    protected ProductmanagementController()
    {
        LocalizationResource = typeof(ProductmanagementResource);
    }
}
