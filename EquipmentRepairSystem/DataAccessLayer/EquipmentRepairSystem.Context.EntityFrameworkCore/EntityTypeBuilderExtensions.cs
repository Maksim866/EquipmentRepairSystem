using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EquipmentRepairSystem.Dal.Contracts.Interfaces;
using EquipmentRepairSystem.Dal.Contracts;

namespace EquipmentRepairSystem.Context.EntityFrameworkCore
{
    /// <summary>
    /// Методы расширения для конфигурации сущностей в Entity Framework Core
    /// </summary>
    public static class EntityTypeBuilderExtensions
    {
        /// <summary>
        /// Задаёт конфигурацию для сущностей, реализующих интерфейс IEntityWithId, устанавливая свойство Id в качестве ключа
        /// </summary>
        public static void HasIdAsKey<T>(this EntityTypeBuilder<T> builder)
            where T : class, IEntityWithId
        {
            builder.HasKey(c => c.Id);
        }

        /// <summary>
        /// Задаёт конфигурацию для сущностей, наследующихся от BaseAuditEntity
        /// </summary>
        public static void ConfigureBaseAuditEntity<T>(this EntityTypeBuilder<T> builder)
            where T : BaseAuditEntity
        {
            builder.Property(c => c.CreatedAt).IsRequired();
            builder.Property(c => c.CreatedBy).IsRequired().HasMaxLength(50);

            builder.Property(c => c.UpdatedAt);
            builder.Property(c => c.UpdatedBy).HasMaxLength(50);

            builder.Property(c => c.DeletedAt);

            builder.HasIndex(c => c.CustomerId);
            builder.HasIndex(c => c.EquipmentId);
            builder.HasIndex(c => c.ReceiverId);
        }
    }
}
