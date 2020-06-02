using Microsoft.EntityFrameworkCore;
using Reporter.DL.Configurations;
using Reporter.DL.Entities;
using Reporter.DL.Migrations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Reporter.DL
{
    public class ReporterDBContext : IdentityDbContext<PersonEntity>
    {
        public ReporterDBContext(DbContextOptions<ReporterDBContext> options)
            : base(options) { }

        public DbSet<PersonEntity> Persons { get; set; }

        public DbSet<ReportEntity> Reports { get; set; }

        public DbSet<CommentEntity> Comments { get; set; }

        public DbSet<DepartmentEntity> Departments { get; set; }

        public DbSet<FacultieEntity> Faculties { get; set; }

        /// <inheritdoc/>
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Reporter;Trusted_Connection=True;MultipleActiveResultSets=True");
        }

        /// <inheritdoc/>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CommentConfiguration());

            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());

            modelBuilder.ApplyConfiguration(new FacultieConfiguration());

            modelBuilder.ApplyConfiguration(new ReportConfiguration());

            modelBuilder.ApplyConfiguration(new PersonConfiguration());

            modelBuilder.Seed();
        }
    }
}
