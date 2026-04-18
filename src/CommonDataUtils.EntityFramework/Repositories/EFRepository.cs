namespace CommonDataUtils.EntityFramework.Repositories;
public class EFRepository<T> : IReadRepository<T> where T : class
{
    private readonly BaseDBContext _context;
    public EFRepository(BaseDBContext context)
    {
        _context = context;
    }
}