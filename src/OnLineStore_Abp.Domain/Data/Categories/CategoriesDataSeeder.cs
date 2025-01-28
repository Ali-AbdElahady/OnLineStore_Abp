using OnLineStore_Abp.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace OnLineStore_Abp.Data.Categories
{
    public class CategoriesDataSeeder : IDataSeedContributor ,ITransientDependency
    {
        private readonly IRepository<Category, int> categoriesRepo;

        public CategoriesDataSeeder(IRepository<Category,int> categoriesRepo)
        {
            this.categoriesRepo = categoriesRepo;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            if(!await this.categoriesRepo.AnyAsync())
            {
                var categories = new List<Category>
            {
                new Category(id:1,
                nameAr:"أطعمة ومشروبات",
                nameEn:"Food & Drinks",
                descriptionAr:"جميع انواع الاطعمة والمشروبات",
                descriptionEn:"All food and drinks"),
                new Category(id:2,
                nameAr:"مواد تنظيف",
                nameEn:"Detergents",
                descriptionAr:"المنظفات بانوعها",
                descriptionEn:"all materials used for cleaning"),
                new Category(id:3,
                nameAr:"العطور",
                nameEn:"Fragrances",
                descriptionAr:"جميع انواع العطور",
                descriptionEn:"All perfumes and its sub-categories"),
                new Category(id:4,
                nameAr:"بلاستيك",
                nameEn:"Plastic",
                descriptionAr:"البلاستيك القابل للتدوير والغير قابل للتدوير",
                descriptionEn:"All reusable and non-reusable palstic materials")
            };
                await this.categoriesRepo.InsertManyAsync(categories);
            }
            
        }
    }
}
