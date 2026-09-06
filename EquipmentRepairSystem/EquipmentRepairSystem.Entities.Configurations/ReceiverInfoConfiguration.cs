using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EquipmentRepairSystem.Context.EntityFrameworkCore;

namespace EquipmentRepairSystem.Entities.Configurations;

public class ReceiverInfoConfiguration : IEntityTypeConfiguration<ReceiverInfo>
{
    public void Configure(EntityTypeBuilder<ReceiverInfo> builder)
    {
        builder.ToTable("ReceiverInfo");

        builder.HasIdAsKey();
        builder.ConfigureBaseAuditEntity();

        builder.Property(r => r.FirstName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(r => r.LastName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(r => r.MiddleName)
            .HasMaxLength(50);

        builder.Property(r => r.ReceiverPhone)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(r => r.ReceiverPosition)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasIndex(r => r.ReceiverPhone)
            .HasDatabaseName("IX_ReceiverInfo_ReceiverPhone");

        builder.HasIndex(r => new { r.LastName, r.FirstName })
            .HasDatabaseName("IX_ReceiverInfo_LastName_FirstName");
    }
}
