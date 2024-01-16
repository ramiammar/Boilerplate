using Emenu.Productmanagement.Dtos;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Emenu.Productmanagement.Services
{
    public interface IImagdeService :
         ICrudAppService<ImageDto,
                         Guid,
                         PagedAndSortedResultRequestDto,
                         CreateUpdateImageDto>
    {
    }
}
