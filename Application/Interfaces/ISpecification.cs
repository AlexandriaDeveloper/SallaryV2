using System.Linq.Expressions;

namespace Domain.Interfaces
{
    public interface ISpecification<T>
    {
        //int Take { get; }
        //int Skip { get; }
        int PageIndex { get; }
        int PageSize { get; }
        bool IsPagination { get; }
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression<Func<T, bool>>> Criteries { get; }
        List<Expression<Func<T, object>>> Includes { get; }
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }
    }
}
