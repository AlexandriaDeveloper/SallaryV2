using Domain.Primitives;

namespace Domain.Models
{
    public class Grade : Entity
    {
        public ICollection<EmployeeGrade> EmployeeGrades { get; set; }
    }
}
