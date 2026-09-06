using EquipmentRepairSystem.Dal.Contracts;

namespace EquipmentRepairSystem.Entities;


/// <summary>
/// Реквизиты договора
/// </summary>
public class ContractDetail : BaseAuditEntity
{
    /// <summary>
    /// Номер договора
    /// </summary>
    public string ContractNumber { get; set; } = string.Empty;

    /// <summary>
    /// Дата договора (день, месяц, год)
    /// </summary>
    public DateTimeOffset ContractDate { get; set; }

    /// <summary>
    /// Внешний ключ на заказчика
    /// </summary>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// Навигационное свойство на заказчика
    /// </summary>
    public CustomerInfo? Customer { get; set; }

    /// <summary>
    /// Внешний ключ на приёмщика
    /// </summary>
    public Guid ReceiverId { get; set; }

    /// <summary>
    /// Навигационное свойство на приёмщика
    /// </summary>
    public ReceiverInfo? Receiver { get; set; }

    /// <summary>
    /// Табличная часть оборудования, переданного по данному договору
    /// </summary>
    public ICollection<ContractEquipmentItem> ContractEquipmentItems { get; set; } =
            new List<ContractEquipmentItem>();
}
