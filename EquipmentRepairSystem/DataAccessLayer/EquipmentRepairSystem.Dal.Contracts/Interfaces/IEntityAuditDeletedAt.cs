namespace EquipmentRepairSystem.Dal.Contracts.Interfaces
{
    /// <summary>
    /// Аудит удаления сущности
    /// </summary>
    public interface IEntityAuditDeletedAt
    {
        /// <summary>
        /// Дата удаления
        /// </summary>
        public DateTimeOffset? DeletedAt { get; set; }

    }
}
