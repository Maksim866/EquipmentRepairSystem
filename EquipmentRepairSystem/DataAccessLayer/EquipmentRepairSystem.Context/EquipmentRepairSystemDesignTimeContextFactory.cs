using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace EquipmentRepairSystem.Context;

/// <summary>
/// Фабрика для создания контекста в DesignTime
/// </summary>
public class EquipmentRepairSystemDesignTimeContextFactory : IDesignTimeDbContextFactory<EquipmentRepairSystemContext>
{
    /// <summary>
    /// Создает экземпляр контекста базы данных для использования в DesignTime
    /// </summary>
    public EquipmentRepairSystemContext CreateDbContext(string[] args)
    {
        var connectionString =
        "Host=localhost;Port=5432;Database=EquipmentRepairSystem;Username=postgres;Password=14082002";

        var options = new DbContextOptionsBuilder<EquipmentRepairSystemContext>()
            .UseNpgsql(connectionString)
            .LogTo(Console.WriteLine)
            .Options;

        return new EquipmentRepairSystemContext(options);
    }
}
