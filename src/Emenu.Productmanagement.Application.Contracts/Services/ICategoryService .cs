using Emenu.Productmanagement.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Emenu.Productmanagement.Services
{
    public interface ICategoryService:
         ICrudAppService< //Defines CRUD methods
        CategoryDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateCategoryDto> //Used to create/update a book
    {
    }
}
