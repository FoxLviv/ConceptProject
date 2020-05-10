using Microsoft.EntityFrameworkCore;
using Reporter.DL.Entities;
using System;

namespace Reporter.DL.Migrations
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var FirstUserId = Guid.Parse("30FB2DD3-EA0E-4F05-B0DB-EF6341A593F0");

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
                    AuthorId = FirstUserId,
                    CreatedAt = new DateTime(2020, 9, 5, 11, 0, 0),
                    Report = "On the other hand, we denounce with righteous indignation and dislike men who are so beguiled and demoralized by the charms of pleasure of the moment, so blinded by desire, that they cannot foresee the pain and trouble that are bound to ensue; and equal blame belongs to those who fail in their duty through weakness of will, which is the same as saying through shrinking from toil and pain. These cases are perfectly simple and easy to distinguish. In a free hour, when our power of choice is untrammelled and when nothing prevents our being able to do what we like best, every pleasure is to be welcomed and every pain avoided. But in certain circumstances and owing to the claims of duty or the obligations of business it will frequently occur that pleasures have to be repudiated and annoyances accepted. The wise man therefore always holds in these matters to this principle of selection: he rejects pleasures to secure other greater pleasures, or else he endures pains to avoid worse pains.",
                    Title = "First title"
                });
            modelBuilder.Entity<RoleEntity>()
                .HasData(
                new RoleEntity
                {
                    Id = 1,
                    Name = "Teacher"
                },
                new RoleEntity
                {
                    Id = 2,
                    Name = "Head of Department"
                },
                new RoleEntity
                {
                    Id = 3,
                    Name = "Dean"
                },
                new RoleEntity
                {
                    Id = 4,
                    Name = "Admin"
                });
            modelBuilder.Entity<PersonRoleEntity>()
                .HasData(
                new PersonRoleEntity
                {
                    PersonId = FirstUserId,
                    RoleId = 1
                });
            modelBuilder.Entity<PersonEntity>()
                .HasData(
                new PersonEntity
                {
                    Id = FirstUserId,
                    Email = "burco.ab@gmail.com",
                    FirstName = "Andriy",
                    LastName = "Burtso",
                    PasswordHash = new byte[] { 0, 1, 1, 0 },
                    PasswordSalt = new byte[] { 0, 0, 0, 1 },
                    FacultieId = 1,
                    DepartmentId = 1
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
