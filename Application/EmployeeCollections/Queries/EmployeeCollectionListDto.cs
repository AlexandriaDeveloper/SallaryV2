namespace Application.EmployeeCollections.Queries
{
    public class EmployeeCollectionListDto
    {
        public int? Id { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeTabCode { get; set; }
        public string EmployeeTegaraCode { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSection { get; set; }
        public string EmployeeCollageName { get; set; }
        public int? EmployeeOrderInCollection { get; set; }
    }
}
