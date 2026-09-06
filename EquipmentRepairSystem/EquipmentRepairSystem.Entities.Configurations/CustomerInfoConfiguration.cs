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

            builder.Property(c => c.CustomerType)
                .IsRequired()
                .HasConversion<string>()
                .HasMaxLength(30);

            builder.Property(c => c.CompanyName)
                .HasMaxLength(30);

            builder.Property(c => c.FirstName)
                .HasMaxLength(30);

            builder.Property(c => c.MiddleName)
                .HasMaxLength(30);

            builder.Property(c => c.LastName)
                .HasMaxLength(30);

            builder.Property(c => c.Phone)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(c => c.MalfunctionDescription)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(c => c.DeliveredBy)
                .IsRequired()
                .HasMaxLength(20);

            builder.HasIndex(c => c.Phone);
        }
    }
}
