﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq;
namespace DataAccess.FluentApi.ProductAggregate
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasIndex(x => x.CategoryId);
            builder.HasIndex(x => x.BrandId);
            builder.HasIndex(x => x.ProductNameUpper).IncludeProperties(x => new { x.Id, x.ProductName });
            builder.HasIndex(x => x.Id).IncludeProperties(typeof(Product).GetProperties().Select(x => x.Name).Where(x => x != "Id").ToArray());
            builder.Property(x => x.ProductName).HasMaxLength(50);
            builder.HasKey(x => x.Id);
        }
    }
}
