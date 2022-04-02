﻿using Entities.Concrete.CommentsAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.FluentApi.CommentsAggregate
{

    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(t => t.Id).UseSqlServerIdentityColumn();
        }
    }
}