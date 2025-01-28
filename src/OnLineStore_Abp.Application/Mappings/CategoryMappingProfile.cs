using AutoMapper;
using OnLineStore_Abp.Categories;
using OnLineStore_Abp.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineStore_Abp.Mappings
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<Category, CategoryDto>()
                .ForMember(des=>des.NameAr,opt=>opt.MapFrom(src=>src.NameAr));
            CreateMap<CreateUpdateCategoryDto, Category>();
        }
    }
}
