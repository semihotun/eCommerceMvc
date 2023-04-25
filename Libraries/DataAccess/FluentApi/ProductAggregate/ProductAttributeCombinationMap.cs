﻿using Entities.Concrete.ProductAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
namespace DataAccess.FluentApi.ProductAggregate
{

    public class ProductAttributeCombinationMap : IEntityTypeConfiguration<ProductAttributeCombination>
    {
        public void Configure(EntityTypeBuilder<ProductAttributeCombination> builder)
        {
            builder.HasIndex(x => x.ProductId);


            builder.HasKey(x => x.Id);
            builder.Property(t => t.Id).UseIdentityColumn();
        }
    }
}