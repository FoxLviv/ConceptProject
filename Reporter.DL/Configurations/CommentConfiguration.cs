using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reporter.DL.Entities;

namespace Reporter.DL.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<CommentEntity>
    {
        public void Configure(EntityTypeBuilder<CommentEntity> builder)
        {
            builder.HasKey(comment => comment.Id);

            builder.Property(e => e.ReportId)
                .IsRequired();

            builder.HasOne(e => e.Report)
                .WithMany(report => report.Comments)
                .HasForeignKey(e => e.ReportId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            builder.Property(e => e.AuthorId)
                .IsRequired();

            builder.HasOne(e => e.Author)
                .WithMany(author => author.Comments)
                .HasForeignKey(e => e.AuthorId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

            builder.Property(e => e.CreateAt)
                .IsRequired();

            builder.Property(e => e.Comment)
                .HasMaxLength(300)
                .IsRequired();
        }
    }
}
