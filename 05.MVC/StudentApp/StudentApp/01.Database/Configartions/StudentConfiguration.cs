using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Helpers.Constants;

namespace DataAccess
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(x => x.ID)
                .UseIdentityColumn(seed: ConstantValues.DEFAULT_PRIMARY_KEY, increment: 1);

            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Deleted)
                .HasDefaultValue(ConstantValues.DEFAULT_DELETED_COLUMN_VALUE);
        }
    }
}
