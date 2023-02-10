namespace Domain.Interfaces
{
    public interface IParam
    {

        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int PageCount { get; set; }
        public string Sort { get; set; }
        public string Order { get; set; }



    }
}
