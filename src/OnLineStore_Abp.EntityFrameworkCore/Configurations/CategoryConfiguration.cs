using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnLineStore_Abp.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace OnLineStore_Abp.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ConfigureByConvention();
            builder.Property(x=>x.Id).ValueGeneratedNever();

            builder.Property(x => x.NameAr).
                HasMaxLength(OnLineStore_AbpConsts.GeneralTextMaxLength);
            builder.Property(x => x.NameEn)
                .HasMaxLength(OnLineStore_AbpConsts.GeneralTextMaxLength);
            builder.Property(x => x.DescriptionAr)
                .HasMaxLength(OnLineStore_AbpConsts.DescriptionMaxLength);
            builder.Property(x => x.DescriptionEn)
                .HasMaxLength(OnLineStore_AbpConsts.DescriptionMaxLength);
            
            builder.ToTable("Categories");
        }
    }
}
