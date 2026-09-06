using EquipmentRepairSystem.Dal.Contracts;

namespace EquipmentRepairSystem.Entities;

/// <summary>
/// Справочник моделей и типов оборудования.
/// </summary>
public class Equipment : BaseAuditEntity
{
    /// <summary>
    /// Наименование оборудования
    /// </summary>
    public string EquipmentName { get; set; } = string.Empty;

    /// <summary>
    /// Базовое описание или категория оборудования
    /// </summary>
    public string EquipmentDescription { get; set; } = string.Empty;
}
