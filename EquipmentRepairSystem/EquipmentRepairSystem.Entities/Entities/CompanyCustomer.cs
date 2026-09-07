namespace EquipmentRepairSystem.Entities;

public class CompanyCustomer : Customer
{
    /// <summary>
    /// Наименование организации (заполняется для юридического лица)
    /// </summary>
    public string CompanyName { get; set; } = string.Empty;

}
