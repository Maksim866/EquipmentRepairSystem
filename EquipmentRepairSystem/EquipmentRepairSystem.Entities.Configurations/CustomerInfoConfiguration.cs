using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EquipmentRepairSystem.Context.EntityFrameworkCore;

namespace EquipmentRepairSystem.Entities.Configurations
{
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

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.Phone)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(c => c.MalfunctionDescription)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(c => c.DeliveredBy)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}
