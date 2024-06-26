﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace DataAccess.FluentApi.ProductAggregate
{
    public class ProductLikesMap : IEntityTypeConfiguration<ProductLike>
    {
        public void Configure(EntityTypeBuilder<ProductLike> builder)
        {
            builder.HasIndex(x => new { x.UserId });
            builder.HasKey(x => x.Id);
        }
    }
}
