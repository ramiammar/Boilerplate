using AutoMapper;
using Emenu.Productmanagement.Dtos;
using Emenu.Productmanagement.Models;

namespace Emenu.Productmanagement;

public class ProductmanagementApplicationAutoMapperProfile : Profile
{
    public ProductmanagementApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Category, CategoryDto>();
        CreateMap<CreateUpdateCategoryDto, Category>();
    }
}
