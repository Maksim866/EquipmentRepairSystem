

namespace EquipmentRepairSystem.Entities
{
    /// <summary>
    /// Информация о получателе
    /// </summary>
    public class ReceiverInfo
    {

        /// <summary>
        /// ФИО сотрудника (или название компании) принимающей стороны 
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Телефон получателя
        /// </summary>
        public string Phone { get; set; } = string.Empty;

    }
}
