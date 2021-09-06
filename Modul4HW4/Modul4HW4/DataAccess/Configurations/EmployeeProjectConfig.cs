using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modul4HW4.Models;

namespace Modul4HW4.DataAccess.Configurations
{
    public class EmployeeProjectConfig : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.HasKey(a => a.EmployeeProjectId);
            builder.Property(a => a.EmployeeProjectId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(b => b.Rate).IsRequired().HasColumnType("money");
            builder.Property(c => c.StartedDate).IsRequired().HasMaxLength(7).HasColumnType("datetime2");
            builder.HasOne(d => d.Employee)
                .WithMany(q => q.EmployeeProjects)
                .HasForeignKey(z => z.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
            builder.HasOne(q => q.Project)
                .WithMany(z => z.EmployeeProjects)
                .HasForeignKey(r => r.ProjectId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            builder.HasData(new List<EmployeeProject>()
            {
                new EmployeeProject
                {
                    EmployeeProjectId = 1,
                    StartedDate = new DateTime(2021, 1, 1),
                    ProjectId = 1,
                    EmployeeId = 1,
                    Rate = 557,
                },

                new EmployeeProject
                {
                    EmployeeProjectId = 2,
                    StartedDate = new DateTime(2021, 1, 1),
                    ProjectId = 2,
                    EmployeeId = 2,
                    Rate = 557,
                },

                new EmployeeProject
                {
                    EmployeeProjectId = 3,
                    StartedDate = new DateTime(2021, 1, 1),
                    ProjectId = 3,
                    EmployeeId = 3,
                    Rate = 100,
                },

                new EmployeeProject
                {
                    EmployeeProjectId = 4,
                    StartedDate = new DateTime(2021, 1, 1),
                    ProjectId = 4,
                    EmployeeId = 4,
                    Rate = 100,
                },

                new EmployeeProject
                {
                    EmployeeProjectId = 5,
                    StartedDate = new DateTime(2021, 1, 1),
                    ProjectId = 5,
                    EmployeeId = 5,
                    Rate = 557,
                }
            });
        }
    }
}
