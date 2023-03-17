using Domain.Employees;

namespace Application.EmployeeVacationTypes
{
    public class EmployeeVacationTypeDto
    {
        public DateTime StartAt { get; set; }
        public DateTime? EndAt { get; set; }
        public int? Qunatity { get; set; }
        public int VacationId { get; set; }
        // public int EmployeeOrderId { get; set; }


        public int FormId { get; set; }
        public string OrderNumber { get; set; }
        public string Details { get; set; }
        public int? EmployeeId { get; set; }
        public virtual EmployeeDto Employee { get; set; }


    }



}
