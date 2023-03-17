using Domain.Primitives;

namespace Domain.Models
{
    public class Vacation : Entity
    {


        public ICollection<EmployeeVacationType> EmployeeVacationTypes { get; set; }
    }
}
