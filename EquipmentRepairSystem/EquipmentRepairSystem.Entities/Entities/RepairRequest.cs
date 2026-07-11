using EquipmentRepairSystem.Entities.Models;

namespace EquipmentRepairSystem.Entities
{
    /// <summary>
    /// Класс для представления информации о заказе
    /// </summary>
    public class RepairRequest
    {
        /// <summary>
        /// Перечень оборудования, которое требуется отремонтировать
        /// </summary>
        public List<EquipmentItem> TableRows { get; set; } = new List<EquipmentItem>();

    }
}
