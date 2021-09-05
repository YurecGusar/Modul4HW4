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
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(a => a.EmployeeId);
            builder.Property(a => a.EmployeeId).IsRequired();
            builder.Property(b => b.FirstName).HasMaxLength(50).HasColumnType("nvarchar").IsRequired();
            builder.Property(c => c.LastName).HasMaxLength(50).HasColumnType("nvarchar").IsRequired();
            builder.Property(d => d.HiredData).HasMaxLength(7).HasColumnType("datetime2").IsRequired();
            builder.Property(e => e.DataOfBirth).HasColumnType("date");
            builder.HasOne(f => f.Office)
                .WithMany(f => f.Employes)
                .HasForeignKey(f => f.OfficeId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(g => g.Title)
                .WithMany(g => g.Employes)
                .HasForeignKey(g => g.TitleId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
