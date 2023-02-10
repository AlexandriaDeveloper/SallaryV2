namespace Application.EmployeePartTimes
{
    public class EmployeePartTimeDto
    {
        public int? Id { get; set; }
        public DateTime StartFrom { get; set; }
        public DateTime? EndAt { get; set; }
        public string Details { get; set; } = "";
        public int EmployeeId { get; set; }

    }


}
