using EquipmentRepairSystem.Context.EntityFrameworkCore;
using EquipmentRepairSystem.Dal.Contracts.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EquipmentRepairSystem.Entities.Configurations;

public class ContractDetailConfiguration : IEntityTypeConfiguration<ContractDetail>
{
    public void Configure(EntityTypeBuilder<ContractDetail> builder)
    {
        builder.ToTable("ContractDetails");

        builder.HasIdAsKey();
        builder.ConfigureBaseAuditEntity();

        builder.Property(cd => cd.ContractNumber)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(cd => cd.ContractDate)
            .IsRequired();

        builder.HasIndex(cd => cd.ContractNumber)
            .IsUnique()
            .HasDatabaseName("IX_ContractDetails_ContractNumber")
            .HasFilter($"\"{nameof(IEntityAuditDeletedAt.DeletedAt)}\" IS NULL");

        builder.HasIndex(cd => cd.ContractDate)
            .HasDatabaseName("IX_ContractDetails_ContractDate");

        builder.HasOne(cd => cd.Customer)
            .WithMany()
            .HasForeignKey(cd => cd.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(cd => cd.Receiver)
            .WithMany()
            .HasForeignKey(cd => cd.ReceiverId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(cd => cd.ContractEquipmentItems)
            .WithOne(cei => cei.ContractDetail)
            .HasForeignKey(cei => cei.ContractDetailId)
            .OnDelete(DeleteBehavior.Cascade);

    }
}
