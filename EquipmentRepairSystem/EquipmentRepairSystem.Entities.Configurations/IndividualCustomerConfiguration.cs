using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EquipmentRepairSystem.Entities.Configurations;

public class IndividualCustomerConfiguration : IEntityTypeConfiguration<IndividualCustomer>
{
    public void Configure(EntityTypeBuilder<IndividualCustomer> builder)
    {
        builder.ToTable("IndividualCustomers");

        builder.HasKey(i => i.CustomerId);

        builder.Property(i => i.FirstName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(i => i.LastName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(i => i.MiddleName)
            .HasMaxLength(50);

        builder.HasIndex(i => new { i.LastName, i.FirstName })
            .HasDatabaseName("IX_IndividualCustomer_LastName_FirstName");
    }
}
