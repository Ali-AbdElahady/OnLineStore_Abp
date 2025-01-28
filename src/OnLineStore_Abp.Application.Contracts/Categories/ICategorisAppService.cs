using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace OnLineStore_Abp.Categories
{
    public interface ICategorisAppService :ICrudAppService
        <CategoryDto,int,PagedAndSortedResultRequestDto,CreateUpdateCategoryDto>
    {
    }
}
