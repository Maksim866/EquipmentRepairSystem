using EquipmentRepairSystem.Dal.Contracts;

namespace EquipmentRepairSystem.Entities;

/// <summary>
/// Информация о заказчике
/// </summary>
public abstract class Customer : BaseAuditEntity
{
    /// <summary>
    /// Телефон заказчика
    /// </summary>
    public string Phone { get; set; } = string.Empty;

}
