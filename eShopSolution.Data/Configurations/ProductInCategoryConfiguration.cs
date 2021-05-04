using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class ProductInCategoryConfiguration :IEntityTypeConfiguration<ProductInCategory>
    {
        //https//docs.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cdata-annotations-simple-key%2Csimple-key#other-relationship-patterns
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(t => new { t.CategoryId, t.ProductId });
            builder.ToTable("ProductInCategories");
            //mot product co nhieu category;
            builder.HasOne(pc => pc.Product).WithMany(p=>p.ProductInCategories).HasForeignKey(pc=>pc.ProductId);
            //mot category co nhieu product;
            builder.HasOne(pc => pc.Category).WithMany(c => c.ProductInCategories).HasForeignKey(pc => pc.CategoryId);
        }
    }
}
