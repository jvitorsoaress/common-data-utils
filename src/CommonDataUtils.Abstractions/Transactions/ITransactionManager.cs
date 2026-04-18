namespace CommonDataUtils.Abstractions.Transactions;
public interface ITransactionManager
{
    Task BeginTransactionAsync();
    Task CommitTransactionAsync();
    Task RollbackTransactionAsync();
}