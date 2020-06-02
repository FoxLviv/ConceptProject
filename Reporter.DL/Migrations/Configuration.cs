using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Reporter.DL.Entities;
using System;

namespace Reporter.DL.Migrations
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var FirstUserId = "30FB2DD3-EA0E-4F05-B0DB-EF6341A593F0";

            modelBuilder.Entity<FacultieEntity>()
                .HasData(
                new FacultieEntity
                {
                    Id = 1,
                    Name = "AMI"
                });
            modelBuilder.Entity<DepartmentEntity>()
                .HasData(
                new FacultieEntity
                {
                    Id = 1,
                    Name = "Programming"
                });
            modelBuilder.Entity<ReportEntity>()
                .HasData(
                new ReportEntity
                {
                    Id = 1,
                    AuthorId = "30FB2DD3-EA0E-4F05-B0DB-EF6341A593F0",
                    CreatedAt = new DateTime(2020, 9, 5, 11, 0, 0),
                    Report = "On the other hand, we denounce with righteous indignation and dislike men who are so beguiled and demoralized by the charms of pleasure of the moment, so blinded by desire, that they cannot foresee the pain and trouble that are bound to ensue; and equal blame belongs to those who fail in their duty through weakness of will, which is the same as saying through shrinking from toil and pain. These cases are perfectly simple and easy to distinguish. In a free hour, when our power of choice is untrammelled and when nothing prevents our being able to do what we like best, every pleasure is to be welcomed and every pain avoided. But in certain circumstances and owing to the claims of duty or the obligations of business it will frequently occur that pleasures have to be repudiated and annoyances accepted. The wise man therefore always holds in these matters to this principle of selection: he rejects pleasures to secure other greater pleasures, or else he endures pains to avoid worse pains.",
                    Title = "First title"
                });
            modelBuilder.Entity<PersonEntity>()
                .HasData(
                new PersonEntity
                {
                    Id = "30FB2DD3-EA0E-4F05-B0DB-EF6341A593F0",
                    Email = "admin@gmail.com",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    UserName = "Admin",
                    NormalizedUserName = "ADMIN",
                    FirstName = "Andriy",
                    LastName = "Burtso",
                    PasswordHash = "AQAAAAEAACcQAAAAEK3jzQJiCHkx2ap0J5xCP0Qab5XZqelpZKr4SwktVFnsO3n6Zo03yip4c7Q4EoNQqw==",
                    SecurityStamp = "KCI6QACPHAQPPINNHG6JZREXNLW2NTSX",
                    ConcurrencyStamp = "237b4742-5473-47a6-ba78-1ca569e9bed7",
                    LockoutEnabled = true,
                    FacultieId = 1,
                    DepartmentId = 1
                });
            modelBuilder.Entity<IdentityRole>()
                .HasData(
                new IdentityRole
                {
                    Id = "19d016f5-8c54-4516-b6ed-91cb101099bd",
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = "d67661d4-b3ac-494a-a6b9-35f423f285ae"
                });
            modelBuilder.Entity<IdentityUserRole<string>>().
                HasData(
                new IdentityUserRole<string>
                {
                    UserId = "30FB2DD3-EA0E-4F05-B0DB-EF6341A593F0",
                    RoleId = "19d016f5-8c54-4516-b6ed-91cb101099bd",
                });
            modelBuilder.Entity<CommentEntity>()
                .HasData(
                new CommentEntity
                {
                    Id = 1,
                    AuthorId = FirstUserId,
                    ReportId = 1,
                    CreateAt = new DateTime(2020, 10, 5, 11, 0, 0),
                    Comment = "Cool work dude)"
                });
        }
    }
}
