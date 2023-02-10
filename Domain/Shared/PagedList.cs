
namespace Domain.Shared
{
    public class PagedList<TEntity>
    {
        public PagedList(List<TEntity> data, IPagination? pagination)
        {
            Data = data;
            Pagination = pagination;
        }

        public List<TEntity> Data { get; private set; }
        public IPagination? Pagination { get; private set; }


    }
}
