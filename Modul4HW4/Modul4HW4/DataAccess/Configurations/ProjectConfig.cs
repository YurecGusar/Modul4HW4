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
    public class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(a => a.ProjectId);
            builder.Property(a => a.ProjectId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(b => b.Name).HasColumnType("nvarchar").HasColumnName("Name").IsRequired();
            builder.Property(c => c.Budget).HasColumnType("money").IsRequired();
            builder.Property(d => d.StartedTime).HasColumnType("datetime2").IsRequired().HasMaxLength(7);
            builder.HasOne(e => e.Client)
                .WithMany(e => e.Projects)
                .HasForeignKey(e => e.ClientId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        }
    }
}
