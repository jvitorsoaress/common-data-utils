using CommonDataUtils.Abstractions.Dapper;
using CommonDataUtils.Abstractions.Repositories;
using CommonDataUtils.Abstractions.Transactions;

namespace CommonDataUtils.Abstractions.UnitOfWork;
public interface IUnitOfWork
{
    IGenericRepository<T> Repository<T>() where T : class;
    IDapperRepository DapperRepository { get; }
    ITransactionManager TransactionManager { get; }
    Task SaveChangesAsync();
}