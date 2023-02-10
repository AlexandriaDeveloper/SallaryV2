namespace Domain.Shared
{
    public interface IPagination
    {
        public int PageIndx { get; set; }
        public int PageSize { get; set; }
        public int Length { get; set; }
        //  public IReadOnlyList<T> Data { get; set; }




    }
}
