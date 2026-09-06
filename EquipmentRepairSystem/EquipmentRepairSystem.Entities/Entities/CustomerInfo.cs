using EquipmentRepairSystem.Dal.Contracts;
using EquipmentRepairSystem.Dal.Contracts.Enums;

namespace EquipmentRepairSystem.Entities
{
    /// <summary>
    /// Информация о заказчике
    /// </summary>
    public class CustomerInfo : BaseAuditEntity
    {
        /// <summary>
        /// Тип заказчика
        /// </summary>
        public CustomerType CustomerType { get; set; }

        /// <summary>
        /// Наименование организации (заполняется для юридического лица)
        /// </summary>
        public string CompanyName { get; set; } = string.Empty;

        /// <summary>
        /// Имя заказчика (заполняется для физического лица или ИП)
        /// </summary>
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Отчество заказчика (при наличии)
        /// </summary>
        public string MiddleName { get; set; } = string.Empty;

        /// <summary>
        /// Фамилия заказчика (заполняется для физического лица или ИП)
        /// </summary>
        public string LastName { get; set; } = string.Empty;

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
