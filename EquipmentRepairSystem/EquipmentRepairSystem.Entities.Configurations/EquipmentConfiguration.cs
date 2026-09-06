using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EquipmentRepairSystem.Context.EntityFrameworkCore;

namespace EquipmentRepairSystem.Entities.Configurations;

public class EquipmentConfiguration : IEntityTypeConfiguration<Equipment>
{
    public void Configure(EntityTypeBuilder<Equipment> builder)
    {
        builder.ToTable("Equipment");

        builder.HasIdAsKey();
        builder.ConfigureBaseAuditEntity();

        builder.Property(e => e.EquipmentName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(e => e.EquipmentDescription)
            .HasMaxLength(250);

        builder.HasIndex(e => e.EquipmentName)
            .HasDatabaseName("IX_Equipment_EquipmentName");
    }
}
