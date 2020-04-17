using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reporter.DL.Entities;

namespace Reporter.DL.Configurations
{
    public class PersonRoleConfiguration : IEntityTypeConfiguration<PersonRoleEntity>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<PersonRoleEntity> builder)
        {
            builder.HasKey(personRoles => new { personRoles.PersonId, personRoles.RoleId });

            builder
                .HasOne(personRole => personRole.Role)
                .WithMany(role => role.PersonRoles)
                .HasForeignKey(fk => fk.RoleId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(personRole => personRole.Person)
                .WithMany(role => role.PersonRoles)
                .HasForeignKey(fk => fk.PersonId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
