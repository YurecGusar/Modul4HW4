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
        }
    }
}
