using EquipmentRepairSystem.Dal.Contracts;

namespace EquipmentRepairSystem.Entities
{

    /// <summary>
    /// Реквизиты договора
    /// </summary>
    public class ContractDetail : BaseAuditEntity
    {
        /// <summary>
        /// Номер договора
        /// </summary>
        public string Number { get; set; } = string.Empty;

        /// <summary>
        /// Дата договора (день, месяц, год)
        /// </summary>
        public DateTimeOffset Date { get; set; }
    }
}
