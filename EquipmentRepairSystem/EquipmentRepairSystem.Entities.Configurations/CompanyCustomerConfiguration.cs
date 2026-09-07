using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EquipmentRepairSystem.Entities.Configurations;

public class CompanyCustomerConfiguration : IEntityTypeConfiguration<CompanyCustomer>
{
    public void Configure(EntityTypeBuilder<CompanyCustomer> builder)
    {
        builder.Property(co => co.CompanyName)
            .HasMaxLength(200);

        builder.HasIndex(co => co.CompanyName)
            .HasDatabaseName("IX_CompanyCustomer_CompanyName");
    }
}
