using Emenu.Productmanagement.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Emenu.Productmanagement.Services
{
    public interface IProductService:
         ICrudAppService<ProductDto,
                         Guid,
                         PagedAndSortedResultRequestDto,
                         CreateUpdateProductDto>
    {
    }
}
