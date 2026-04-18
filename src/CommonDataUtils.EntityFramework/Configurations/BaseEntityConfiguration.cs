namespace CommonDataUtils.EntityFramework.Configurations;
public class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : class
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        // Base configuration for all entities can be added here
    }
}