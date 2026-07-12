namespace EquipmentRepairSystem.Dal.Contracts.Interfaces
{
    /// <summary>
    /// Сущность, связанная с оборудованием
    /// </summary>
    public interface IEntityWithEquipment
    {
        Guid EquipmentId { get; set; }
    }
}
