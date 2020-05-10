using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reporter.DL.Entities;

namespace Reporter.DL.Configurations
{
    public class ReportConfiguration : IEntityTypeConfiguration<ReportEntity>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<ReportEntity> builder)
        {
            builder.HasKey(report => report.Id);

            builder.Property(e => e.AuthorId)
                .IsRequired();

            builder.HasOne(e => e.Author)
                .WithMany(author => author.Reports)
                .HasForeignKey(e => e.AuthorId)
                .IsRequired();

            builder.Property(e => e.Title)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(e => e.CreatedAt)
                .IsRequired();

            builder.Property(e => e.Report)
                .HasMaxLength(5000)
                .IsRequired();
        }
    }
}
