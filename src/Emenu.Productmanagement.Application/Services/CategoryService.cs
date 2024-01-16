using Emenu.Productmanagement.Dtos;
using Emenu.Productmanagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Emenu.Productmanagement.Services
{
    public class CategoryService :
        CrudAppService<
        Category, //The Book entity
        CategoryDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateCategoryDto>, //Used to create/update a book
    ICategoryService //implement the IBookAppService
    {
        public CategoryService(IRepository<Category, Guid> repository)
        : base(repository)
        {

        }
    }
}
