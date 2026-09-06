using EquipmentRepairSystem.Dal.Contracts;

namespace EquipmentRepairSystem.Entities;

/// <summary>
/// Информация о заказчике
/// </summary>
public class CustomerInfo : BaseAuditEntity
{
    /// <summary>
    /// Телефон заказчика
    /// </summary>
    public string Phone { get; set; } = string.Empty;

    /// <summary>
    /// Описание неисправности со слов заказчика
    /// </summary>
    public string MalfunctionDescription { get; set; } = string.Empty;

    /// <summary>
    /// Имя лица, доставившего оборудование
    /// </summary>
    public string DeliveredBy { get; set; } = string.Empty;

    /// <summary>
    /// Связь с сущностью IndividualCustomer
    /// </summary>
    public IndividualCustomer? IndividualDetails { get; set; }

    /// <summary>
    /// Связь с сущностью CompanyCustomer
    /// </summary>
    public CompanyCustomer? CompanyDetails { get; set; }

}
