namespace EquipmentRepairSystem.Entities;

public class IndividualCustomer
{
    /// <summary>
    /// Имя заказчика (заполняется для физического лица или ИП)
    /// </summary>
    public string FirstName { get; set; } = null!;

    /// <summary>
    /// Отчество заказчика (при наличии)
    /// </summary>
    public string? MiddleName { get; set; }

    /// <summary>
    /// Фамилия заказчика (заполняется для физического лица или ИП)
    /// </summary>
    public string LastName { get; set; } = null!;

    /// <summary>
    /// Идентификатор заказчика, связанного с физическим лицом или ИП
    /// </summary>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// Связь с сущностью CustomerInfo
    /// </summary>
    public CustomerInfo CustomerInfo { get; set; } = null!;
}
