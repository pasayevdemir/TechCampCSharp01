using Lesson1.Entities.Concret;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1._02.Database.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {

        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(x => x.ID)
                .UseIdentityColumn<int>(seed: 100, increment: 2);

            builder.HasIndex(x => x.OrderCode).IsUnique();

            //base entity
            builder.Property(x => x.CreateDate)
                    .IsRequired()
                    .HasColumnType("DATETIME")
                    .HasColumnType("(getdate())");

            builder.Property(x => x.UpdateDate)
                    .HasColumnType("DATETIME");

            builder.Property(x => x.Deleted)
                    .IsRequired()
                    .HasDefaultValue<int>(0);

            //relations
            builder.HasOne(x => x.Employee)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.EmployeeId);

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.CustomerId);

        }
    }
}
