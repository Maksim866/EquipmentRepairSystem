using EquipmentRepairSystem.Entities.Models;
using EquipmentRepairSystem.Dal.Contracts;

namespace EquipmentRepairSystem.Entities
{
    /// <summary>
    /// Класс для представления информации о заказе
    /// </summary>
    public class RepairRequest : BaseAuditEntity
    {
        /// <summary>
        /// Перечень оборудования, которое требуется отремонтировать
        /// </summary>
        public List<EquipmentItem> TableRows { get; set; } = new List<EquipmentItem>();

    }
}
