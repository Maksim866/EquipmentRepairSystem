using EquipmentRepairSystem.Dal.Contracts;

namespace EquipmentRepairSystem.Entities;

/// <summary>
/// Промежточная сущность для хранения перечня оборудования
public class ContractEquiomentItem : BaseAuditEntity
{
    /// <summary>
    /// Порядковый номер строки перечня
    /// </summary>
    public int SequenceNumber { get; set; }

    /// <summary>
    /// Количество единиц оборудования
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Серийный номер оборудования
    /// </summary>
    public string SerialNumber { get; set; } = string.Empty;

    /// <summary>
    /// Внешний ключ на договор
    /// </summary>
    public Guid ContractDetailId { get; set; }

    /// <summary>
    /// Навигационное свойство на договор
    /// </summary>
    public ContractDetail? ContractDetail { get; set; }

    /// <summary>
    /// Внешний ключ на модель оборудования из справочника
    /// </summary>
    public Guid EquipmentId { get; set; }

    /// <summary>
    /// Навигационное свойство на модель оборудования из справочника
    /// </summary>
    public Equipment? Equipment { get; set; }

}
