namespace CommonDataUtils.EntityFramework.Repositories;
public class EFReadRepository<T> : IReadRepository<T> where T : class
{
    private readonly BaseDBContext _context;
    public EFReadRepository(BaseDBContext context)
    {
        _context = context;
    }
}