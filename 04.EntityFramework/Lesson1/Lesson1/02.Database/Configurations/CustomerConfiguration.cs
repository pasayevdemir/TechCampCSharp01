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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(x => x.ID)
               .UseIdentityColumn<int>(seed: 100, increment: 2);

            builder.Property(x => x.Address)
                .IsRequired()
                .HasMaxLength(300);
            
            builder.Property(x => x.PhoneNumber)
                .IsRequired()
                .HasMaxLength(15);

            builder.Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Age)
               .IsRequired()
               .HasDefaultValueSql<byte>("18");

            builder.Property(x => x.BirthDay)
                .IsRequired()
                .HasColumnType("Date");
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
        }
    }
}
