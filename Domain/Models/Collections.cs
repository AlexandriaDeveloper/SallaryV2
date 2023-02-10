using Domain.Primitives;

namespace Domain.Models
{
    public class Collection : Entity
    {
        public ICollection<EmployeeCollection> CollectionEmployee { get; set; }
    }
}
