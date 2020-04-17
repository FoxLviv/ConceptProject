using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reporter.DL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reporter.DL.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<RoleEntity>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<RoleEntity> builder)
        {
            builder.HasKey(role => role.Id);

            builder.Property(role => role.Name)
                .IsRequired();
        }
    }
}
