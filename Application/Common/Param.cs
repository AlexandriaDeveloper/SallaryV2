namespace Domain.Shared
{
    public abstract class Param //:IParam
    {
        private const int MaxPageSize = 50;
        public int pageIndex { get; set; } = 1;


        private int _pageSize = 15;
        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }

        public string? Sort { get; set; }
        public int Length { get; set; }
        public string? SortBy { get; set; }
    }
}
