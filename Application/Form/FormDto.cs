namespace Application.Form
{
    public class FormDto
    {

        public int Id { get; set; }
        public string Details { get; set; }
        public string FormDate { get; set; }
        public string FileNumber55 { get; set; }
        public string FileNumber224 { get; set; }
    }

    public class EmployeeFormDto
    {
        public int? Id { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeTabCode { get; set; }
        public string EmployeeTegaraCode { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSection { get; set; }
        public string EmployeeNationalId { get; set; }
        public string EmployeeCollageName { get; set; }
        public int? EmployeeOrderInCollection { get; set; }
    }
}
