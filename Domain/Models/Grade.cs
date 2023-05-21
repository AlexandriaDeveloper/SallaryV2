using Domain.Primitives;

namespace Domain.Models
{
    public class Grade : Entity
    {

        public int? ParentId { get; set; }
        public int? Priority { get; set; }
        public ICollection<EmployeeGrade>? EmployeeGrades { get; set; }

        public Grade? Parent { get; set; }
    }
}
