namespace EquipmentRepairSystem.Dal.Contracts.Interfaces
{
    /// <summary>
    /// Сущность, связанная с клиентом
    /// </summary>
    public interface IEntityWithCustomer
    {
        Guid CustomerId { get; set; }
    }
}
