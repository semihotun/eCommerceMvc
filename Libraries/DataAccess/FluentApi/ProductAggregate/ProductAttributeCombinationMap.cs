﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace DataAccess.FluentApi.ProductAggregate
{
    public class ProductAttributeCombinationMap : IEntityTypeConfiguration<ProductAttributeCombination>
    {
        public void Configure(EntityTypeBuilder<ProductAttributeCombination> builder)
        {
            builder.HasIndex(x => x.ProductId);
            builder.HasKey(x => x.Id);
        }
    }
}
