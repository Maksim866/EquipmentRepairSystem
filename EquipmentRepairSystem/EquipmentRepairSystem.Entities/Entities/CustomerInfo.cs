

namespace EquipmentRepairSystem.Entities
{
    /// <summary>
    /// Информация о заказчике
    /// </summary>
    public class CustomerInfo
    {
        /// <summary>
        /// Имя заказчика
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Телефон заказчика
        /// </summary>
        public string Phone { get; set; } = string.Empty;

        /// <summary>
        /// Описание неисправности со слов заказчика
        /// </summary>
        public string MalfunctionDescription { get; set; } = string.Empty;

        /// <summary>
        /// Имя лица, доставившего оборудование
        /// </summary>
        public string DeliveredBy { get; set; } = string.Empty;

    }
}
