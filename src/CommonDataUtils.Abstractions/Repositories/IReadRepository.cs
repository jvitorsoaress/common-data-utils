namespace CommonDataUtils.Abstractions.Repositories;
public interface IReadRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(object id);
}