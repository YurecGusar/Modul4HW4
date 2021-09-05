﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modul4HW4.DataAccess.Configurations;
using Modul4HW4.Models;

namespace Modul4HW4.DataAccess
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> db)
            : base(db)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeProject> EmployeeProjects { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Title> Titles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfig());
            modelBuilder.ApplyConfiguration(new EmployeeProjectConfig());
            modelBuilder.ApplyConfiguration(new OfficeConfig());
            modelBuilder.ApplyConfiguration(new ProjectConfig());
            modelBuilder.ApplyConfiguration(new TitleConfig());
        }
    }
}
