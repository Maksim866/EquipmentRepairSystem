namespace EquipmentRepairSystem.Entities.Models
{

    /// <summary>
    /// Строка перечная в заказе на ремонт оборудования
    /// </summary>
    public class EquipmentItem
    {
        /// <summary>
        /// Идентификатор строки перечня
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Наименование оборудования
        /// </summary>
        public string EquipmentName { get; set; } = string.Empty;

        /// <summary>
        /// Количество единиц оборудования
        /// </summary>
        public int Quantity { get; set; }


        /// <summary>
        /// Серийный номер оборудования
        /// </summary>
        public string SerialNumber { get; set; } = string.Empty;

    }
}
