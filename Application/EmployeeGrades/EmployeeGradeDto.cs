namespace Domain.EmployeeGrades
{
    public class EmployeeGradeDto
    {
        public string EmployeeName { get; set; }
        public string GradeName { get; set; }
        public DateTime? StartFrom { get; set; }
        public DateTime? EndAt { get; set; }
    }
}
