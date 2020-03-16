﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reporter.DL.Configurations;
using Reporter.DL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reporter.DL
{
    public class ReporterDBContext: DbContext
    {
        public ReporterDBContext(DbContextOptions<ReporterDBContext> options) : base(options) { }

        public DbSet<RoleEntity> Roles { get; set; }

        public DbSet<PersonRoleEntity> PersonRoles { get; set; }

        public DbSet<PersonEntity> Persons { get; set; }

        public DbSet<ReportEntity> Reports { get; set; }

        public DbSet<CommentEntity> Comments { get; set; }

        public DbSet<DepartmentEntity> Departments { get; set; }

        public DbSet<FacultieEntity> Faculties { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Data Source=DESKTOP-8DEVSOF;Initial Catalog=Reporter;Integrated Security=True");//"Server=(localdb)\\mssqllocaldb;Database=Reporter;Trusted_Connection=True;"
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CommentConfiguration());

            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());

            modelBuilder.ApplyConfiguration(new FacultieConfiguration());

            modelBuilder.ApplyConfiguration(new ReportConfiguration());

            modelBuilder.ApplyConfiguration(new PersonConfiguration());

            modelBuilder.ApplyConfiguration(new PersonRoleConfiguration());

            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }
    }
}
