using EquipmentRepairSystem.Dal.Contracts;

namespace EquipmentRepairSystem.Entities;

/// <summary>
/// Информация о получателе
/// </summary>
public class ReceiverInfo : BaseAuditEntity
{

    /// <summary>
    /// Имя приёмщика
    /// </summary>
    public string FirstName { get; set; } = string.Empty;

    /// <summary>
    /// Фамилия приёмщика
    /// </summary>
    public string LastName { get; set; } = string.Empty;

    /// <summary>
    /// Отчество приёмщика (при наличии)
    /// </summary>
    public string MiddleName { get; set; } = string.Empty;

    /// <summary>
    /// Должность приёмщика
    /// </summary>
    public string ReceiverPosition { get; set; } = string.Empty;

    /// <summary>
    /// Телефон приёмщика
    /// </summary>
    public string ReceiverPhone { get; set; } = string.Empty;

}
