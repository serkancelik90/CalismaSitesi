using CalismaSitesi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalismaSitesi.DataAccess.Concrete.Configurations
{
    public class EfOrderProductConfiguration : IEntityTypeConfiguration<OrderProduct>
    {
        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {
            builder.HasKey(op => new { op.OrderId, op.ProductId });
            builder.HasOne(op => op.Order).WithMany(op => op.OrderProduct).HasForeignKey(o => o.OrderId);
            builder.HasOne(op => op.Product).WithMany(op => op.OrderProduct).HasForeignKey(p => p.ProductId);
        }
    }
}
