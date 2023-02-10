using Domain.Primitives;
using Domain.Shared;
using System.Linq.Expressions;

namespace Domain.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<PagedList<T>> GetAllBySpecAsync(ISpecification<T>? spec = null, bool trackingChanges = true);
        Task<T> GetByIdAsync(int id);
        Task<bool> CheckExistAsync(int id);
        Task<T?> GetByNameAsync(string name);
        Task<List<T>> GetAllByExpressionAsync(Expression<Func<T, bool>> expression);
        Task<T?> GetByExpressionAsync(Expression<Func<T, bool>> expression);
        bool CheckByExpressionAsync(Expression<Func<T, bool>> expression);
        Task<int?> Next(Expression<Func<T, int>> orderBy, int id);
        Task<int?> Previous(Expression<Func<T, int>> orderBy, int id);
        //  Task<PagedList<T>> GetBySingleOrDefaultAsync(ISpecification<T>? spec = null, bool trackChanges = true);
        Task<T> GetBySingleOrDefaultAsync(ISpecification<T>? spec = null, bool trackChanges = true);

        Task AddItem(T entity);
        Task Update(T entity);
        Task Delete(int id);
        Task HardDelete(int id);
        Task<int> CountAsync(ISpecification<T> spec);

        Task<PagedList<T>> GetAlDeletedlAsync(ISpecification<T>? spec = null, bool trackingChanges = true);
        Task Restore(int id);

    }
}
