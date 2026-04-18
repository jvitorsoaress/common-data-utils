namespace CommonDataUtils.EntityFramework.Extensions;
public static class DbContextExtensions
{
    public static void ApplyAllConfigurations(this ModelBuilder modelBuilder, Assembly assembly)
    {
        var applyGenericMethod = typeof(ModelBuilder).GetMethods()
            .First(m => m.Name == "ApplyConfiguration" && m.GetParameters().Length == 1);
    }
}