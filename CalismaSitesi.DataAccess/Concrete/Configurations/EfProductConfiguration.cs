using CalismaSitesi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalismaSitesi.DataAccess.Concrete.Configurations
{
    public class EfProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            builder.HasOne(p => p.Category).WithMany(c => c.Products).HasForeignKey(c => c.CategoryId);
        }
    }
}
