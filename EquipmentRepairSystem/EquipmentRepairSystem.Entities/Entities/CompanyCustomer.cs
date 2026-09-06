namespace EquipmentRepairSystem.Entities;

public class CompanyCustomer
{
    /// <summary>
    /// Наименование организации (заполняется для юридического лица)
    /// </summary>
    public string CompanyName { get; set; } = string.Empty;

    /// <summary>
    /// Идентификатор заказчика, связанного с компанией
    /// </summary>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// Связь с сущностью CustomerInfo
    /// </summary>
    public CustomerInfo CustomerInfo { get; set; } = null!;

}
