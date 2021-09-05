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
    public class TitleConfig : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.HasKey(a => a.TitleId);
            builder.Property(a => a.TitleId).HasColumnName("TitleId").IsRequired().ValueGeneratedOnAdd();
            builder.Property(b => b.Name).HasColumnName("Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
