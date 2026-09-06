namespace EquipmentRepairSystem.Dal.Contracts.Enums;

/// <summary>
/// Представляет тип клиента в системе ремонта оборудования
/// </summary>
public enum CustomerType
{
    /// <summary>
    /// Представляет индивидуального клиента
    /// </summary>
    Individual = 1,

    /// <summary>
    /// Представляет компанию или организацию
    /// </summary>
    Company = 2,

    /// <summary>
    /// Представляет индивидуального предпринимателя
    /// </summary>
    SoleProprietorship = 3

}
