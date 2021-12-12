using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyNorthwindWithEfCoreCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNorthwindWithEfCoreCodeFirst.Configurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {

            builder.Property(e => e.FirstName).IsRequired().HasColumnType("nvarchar(10)");
            builder.Property(e => e.LastName).IsRequired().HasColumnType("nvarchar(20)");
            builder.Property(e => e.Title).IsRequired(false).HasColumnType("nvarchar(30)");
            builder.Property(e => e.TitleOfCourtesy).IsRequired(false).HasColumnType("nvarchar(25)");
            builder.Property(e => e.BirthDate).IsRequired(false);
            builder.Property(e => e.HireDate).IsRequired(false);
            builder.Property(e => e.Address).IsRequired(false).HasColumnType("nvarchar(60)");
            builder.Property(e => e.City).IsRequired(false).HasColumnType("nvarchar(15)");
            builder.Property(e => e.Region).IsRequired(false).HasColumnType("nvarchar(15)");
            builder.Property(e => e.PostalCode).IsRequired(false).HasColumnType("nvarchar(10)");
            builder.Property(e => e.Country).IsRequired(false).HasColumnType("nvarchar(15)");
            builder.Property(e => e.HomePhone).IsRequired(false).HasColumnType("nvarchar(24)");
            builder.Property(e => e.Extension).IsRequired(false).HasColumnType("nvarchar(4)");
            builder.Property(e => e.Notes).IsRequired(false).HasColumnType("ntext");
        }
    }
}
