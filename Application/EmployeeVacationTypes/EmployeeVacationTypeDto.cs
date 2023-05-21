using Domain.Employees;

namespace Application.EmployeeVacationTypes
{
    public class FormEmployeeVacationTypeDto
    {
        public DateTime StartAt { get; set; }
        public DateTime? EndAt { get; set; }
        public int? Qunatity { get; set; }
        public int VacationId { get; set; }
        public int? FormEmployeeId { get; set; }
        public string OrderNumber { get; set; }
        public string Details { get; set; }

        public virtual EmployeeDto Employee { get; set; }


    }



}
