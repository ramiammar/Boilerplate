using Emenu.Productmanagement.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Emenu.Productmanagement.Services
{
    public interface IImageAppService : IApplicationService
    {
        Task<ImageDto> SaveImage(CreateUpdateImageDto image);
        Task<bool> DeleteImage(Guid id);
    }
}
