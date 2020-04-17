using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reporter.DL.Entities;

namespace Reporter.DL.Configurations
{
    public class FacultieConfiguration : IEntityTypeConfiguration<FacultieEntity>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<FacultieEntity> builder)
        {
            builder.HasKey(facultie => facultie.Id);

            builder.Property(e => e.Name)
                .IsRequired();
        }
    }
}
