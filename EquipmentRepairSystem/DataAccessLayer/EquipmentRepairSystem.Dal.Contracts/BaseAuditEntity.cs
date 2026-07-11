using EquipmentRepairSystem.Dal.Contracts.Interfaces;

namespace EquipmentRepairSystem.Dal.Contracts
{
    /// <summary>
    /// Базовый класс с аудитом
    /// </summary>
    public abstract class BaseAuditEntity :
        IEntityAuditCreated,
        IEntityAuditUpdated,
        IEntityAuditDeletedAt,
        IEntityWithId
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Автор создания
        /// </summary>
        public string CreatedBy { get; set; } = string.Empty;

        /// <summary>
        /// Дата последнего изменения
        /// </summary>
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// Автор последнего изменения
        /// </summary>
        public string UpdatedBy { get; set; } = string.Empty;

        /// <summary>
        /// Дата удаления
        /// </summary>
        public DateTimeOffset? DeletedAt { get; set; }
    }
}
