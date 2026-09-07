namespace EquipmentRepairSystem.Entities;

public class IndividualCustomer : Customer
{
    /// <summary>
    /// Имя заказчика (заполняется для физического лица или ИП)
    /// </summary>
    public string FirstName { get; set; } = string.Empty;

    /// <summary>
    /// Отчество заказчика (при наличии)
    /// </summary>
    public string? MiddleName { get; set; }

    /// <summary>
    /// Фамилия заказчика (заполняется для физического лица или ИП)
    /// </summary>
    public string LastName { get; set; } = string.Empty;
}
