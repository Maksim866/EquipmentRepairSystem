namespace EquipmentRepairSystem.Dal.Contracts.Interfaces
{
    /// <summary>
    /// Сущность, связанная с получателем
    /// </summary>
    public interface IEntityWithReceiver
    {
        Guid ReceiverId { get; set; }
    }
}
