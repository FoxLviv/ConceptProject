using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reporter.DL.Entities;

namespace Reporter.DL.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<PersonEntity>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<PersonEntity> builder)
        {
            builder.HasKey(person => person.Id);

            builder.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(e => e.Email)
                .HasMaxLength(104)
                .IsRequired();

            builder.Property(e => e.PasswordHash)
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(e => e.FacultieId)
                .IsRequired();

            builder.HasOne(e => e.Facultie)
                .WithMany(e => e.Persons)
                .HasForeignKey(e => e.FacultieId)
                .IsRequired();

            builder.Property(e => e.DepartmentId)
                .IsRequired();

            builder.HasOne(e => e.Department)
                .WithMany(e => e.Person)
                .HasForeignKey(e => e.DepartmentId)
                .IsRequired();
        }
    }
}
