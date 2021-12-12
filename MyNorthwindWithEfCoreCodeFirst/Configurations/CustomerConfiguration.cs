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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {

            builder.Property(c => c.CompanyName).IsRequired().HasColumnType("nvarchar(40)");
            builder.Property(c => c.ContactName).IsRequired(false).HasColumnType("nvarchar(30)");
            builder.Property(c => c.ContactTitle).IsRequired(false).HasColumnType("nvarchar(30)");
            builder.Property(c => c.Address).IsRequired(false).HasColumnType("nvarchar(60)");
            builder.Property(c => c.City).IsRequired(false).HasColumnType("nvarchar(15)");
            builder.Property(c => c.Region).IsRequired(false).HasColumnType("nvarchar(15)");
            builder.Property(c => c.PostalCode).IsRequired(false).HasColumnType("nvarchar(10)");
            builder.Property(c => c.Country).IsRequired(false).HasColumnType("nvarchar(15)");
            builder.Property(c => c.Phone).IsRequired(false).HasColumnType("nvarchar(24)");
            builder.Property(c => c.Fax).IsRequired(false).HasColumnType("nvarchar(24)");

        }
    }
}
