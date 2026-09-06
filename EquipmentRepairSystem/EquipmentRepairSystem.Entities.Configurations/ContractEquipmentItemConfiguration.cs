using EquipmentRepairSystem.Context.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EquipmentRepairSystem.Entities.Configurations;

public class ContractEquipmentItemConfiguration : IEntityTypeConfiguration<ContractEquipmentItem>
{
    public void Configure(EntityTypeBuilder<ContractEquipmentItem> builder)
    {
        builder.ToTable("ContractEquipmentItems");

        builder.HasIdAsKey();
        builder.ConfigureBaseAuditEntity();

        builder.Property(cei => cei.SequenceNumber)
            .IsRequired();

        builder.Property(cei => cei.Quantity)
            .IsRequired();

        builder.Property(cei => cei.SerialNumber)
            .HasMaxLength(100);

        builder.HasIndex(cei => cei.SerialNumber)
            .HasDatabaseName("IX_ContractEquipmentItems_SerialNumber")
            .HasFilter($"\"{nameof(ContractEquipmentItem.SerialNumber)}\" IS NOT NULL");

        builder.HasOne(cei => cei.Equipment)
            .WithMany()
            .HasForeignKey(cei => cei.EquipmentId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
