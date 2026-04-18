namespace CommonDataUtils.EntityFramework.Context;
public class BaseDBContext : DbContext
{
    public BaseDBContext(DbContextOptions options) : base(options)
    {
    }
}