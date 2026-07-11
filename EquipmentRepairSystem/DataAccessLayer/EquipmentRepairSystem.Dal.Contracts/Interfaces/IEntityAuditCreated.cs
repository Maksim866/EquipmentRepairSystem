namespace EquipmentRepairSystem.Dal.Contracts.Interfaces
{
    /// <summary>
    /// Аудит создания сущности
    /// </summary>
    public interface IEntityAuditCreated
    {
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Пользователь, создавший сущность
        /// </summary>
        public string CreatedBy { get; set; }
    }
}
