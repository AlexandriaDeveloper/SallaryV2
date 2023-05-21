using Application.VacationTypes;
using Domain.Employees;

namespace Application.FormEmployeeVacations;

public class FormEmployeeVacationDto
{
    public int? Id { get; set; }
    public DateTime StartAt { get; set; }
    public DateTime? EndAt { get; set; }
    public int VacationId { get; set; }
    public string Details { get; set; }


   
    public virtual VacationTypeDto Vacation { get; set; }
    public virtual EmployeeDto Employee { get; set; }

}


