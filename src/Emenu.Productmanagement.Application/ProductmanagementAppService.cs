using System;
using System.Collections.Generic;
using System.Text;
using Emenu.Productmanagement.Localization;
using Volo.Abp.Application.Services;

namespace Emenu.Productmanagement;

/* Inherit your application services from this class.
 */
public abstract class ProductmanagementAppService : ApplicationService
{
    protected ProductmanagementAppService()
    {
        LocalizationResource = typeof(ProductmanagementResource);
    }
}
