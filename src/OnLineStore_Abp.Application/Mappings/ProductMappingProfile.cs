using AutoMapper;
using OnLineStore_Abp.Categories;
using OnLineStore_Abp.Modules;
using OnLineStore_Abp.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineStore_Abp.Mappings
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(des => des.NameAr, opt => opt.MapFrom(src => src.NameAr));
            CreateMap<CreateUpdateProductDto, Product>();
        }
    }
}
