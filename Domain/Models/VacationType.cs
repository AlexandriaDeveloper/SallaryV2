using Domain.Primitives;

namespace Domain.Models
{
    public class Vacation : Entity
    {
        public ICollection<FormEmployeeVacation>? EmployeeVacationTypes { get; set; }
    }
}
