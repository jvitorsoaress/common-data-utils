namespace CommonDataUtils.EntityFramework.Repositories;
public class EFWriteRepository<T> : IReadRepository<T> where T : class
{
    private readonly BaseDBContext _context;
    public EFWriteRepository(BaseDBContext context)
    {
        _context = context;
    }
}