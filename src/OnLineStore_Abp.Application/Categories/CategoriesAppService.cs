using OnLineStore_Abp.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace OnLineStore_Abp.Categories
{
    public class CategoriesAppService : CrudAppService<Category,
        CategoryDto, int,
        PagedAndSortedResultRequestDto,
        CreateUpdateCategoryDto>, ICategorisAppService
    {
        public CategoriesAppService(IRepository<Category, int> repository) : base(repository)
        {
        }
        //public override 
    }
}
