using Microsoft.EntityFrameworkCore;

namespace EquipmentRepairSystem.Context
{
    /// <summary>
    /// Репрезентует контекст базы данных для системы ремонта оборудования.
    /// </summary>
    public class EquipmentRepairSystemContext : DbContext
    {
        /// <summary>
        /// Создает новый экземпляр контекста базы данных с указанными параметрами.
        /// </summary>
        public EquipmentRepairSystemContext(DbContextOptions<EquipmentRepairSystemContext> options)
            : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
