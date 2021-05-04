using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
   public class AppConfigConfiguration : IEntityTypeConfiguration<AppConfig>
    {
        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {
            //ten bang la gi
            builder.ToTable("AppConfigs");
            //config khoa chinh
            builder.HasKey(x => x.Key);
            //bat phai nhap 
            builder.Property(x => x.Value).IsRequired(true);
        }
    }
}
