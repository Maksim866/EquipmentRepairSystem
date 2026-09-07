using EquipmentRepairSystem.Context.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EquipmentRepairSystem.Entities.Configurations;

/// <summary>
/// Конфигурация сущности CustomerInfo для Entity Framework Core
/// </summary>
public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    /// <summary>
    /// Конфигурирует сущность CustomerInfo для Entity Framework Core
    /// </summary>
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("CustomerInfo");

        builder.HasIdAsKey();
        builder.ConfigureBaseAuditEntity();

        builder.Property(c => c.Phone)
            .IsRequired()
            .HasMaxLength(20);

        builder.HasIndex(c => c.Phone)
            .HasDatabaseName("IX_CustomerInfo_Phone");

        builder.HasDiscriminator<string>("CustomerType")
            .HasValue<IndividualCustomer>("Individual")
            .HasValue<CompanyCustomer>("Company");
    }
}
