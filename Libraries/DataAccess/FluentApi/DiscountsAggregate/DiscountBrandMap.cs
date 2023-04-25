﻿using Entities.Concrete.DiscountsAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.FluentApi.DiscountsAggregate
{
    public class DiscountBrandMap : IEntityTypeConfiguration<DiscountBrand>
    {
        public void Configure(EntityTypeBuilder<DiscountBrand> builder)
        {
            builder.HasIndex(x => x.BrandId);
            builder.HasKey(x => x.Id);
            builder.Property(t => t.Id).UseIdentityColumn();
        }
    }
}