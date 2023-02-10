using Domain.Shared;

namespace Domain.DTOS
{
    public class Pagination : IPagination
    {
        public int PageIndx { get; set; }
        public int PageSize { get; set; }
        public int Length { get; set; }
        //  public IReadOnlyList<T> Data { get ; set ; }


    }
}
