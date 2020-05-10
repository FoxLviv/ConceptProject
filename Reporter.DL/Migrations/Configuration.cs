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
                    CreatedAt = 
                })
        }
    }
}
