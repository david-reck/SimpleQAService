using QAService.Infrastructure;

namespace QAService.Infrastructure.Repositories
{
    public interface IRepository<T>
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
