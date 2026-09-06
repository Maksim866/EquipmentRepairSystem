using EquipmentRepairSystem.Context.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EquipmentRepairSystem.Entities.Configurations;

/// <summary>
/// Конфигурация сущности CustomerInfo для Entity Framework Core
/// </summary>
public class CustomerInfoConfiguration : IEntityTypeConfiguration<CustomerInfo>
{
    /// <summary>
    /// Конфигурирует сущность CustomerInfo для Entity Framework Core
    /// </summary>
    public void Configure(EntityTypeBuilder<CustomerInfo> builder)
    {
        builder.ToTable("CustomerInfo");

        builder.HasIdAsKey();
        builder.ConfigureBaseAuditEntity();

        builder.Property(c => c.Phone)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(c => c.MalfunctionDescription)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(c => c.DeliveredBy)
            .IsRequired()
            .HasMaxLength(20);

        builder.HasIndex(c => c.Phone)
            .HasDatabaseName("IX_CustomerInfo_Phone");

        builder.HasIndex(c => c.DeliveredBy)
            .HasDatabaseName("IX_CustomerInfo_DeliveredBy");

        builder.HasOne(c => c.IndividualDetails)
            .WithOne(i => i.CustomerInfo)
            .HasForeignKey<IndividualCustomer>(i => i.CustomerId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(c => c.CompanyDetails)
            .WithOne(co => co.CustomerInfo)
            .HasForeignKey<CompanyCustomer>(co => co.CustomerId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
