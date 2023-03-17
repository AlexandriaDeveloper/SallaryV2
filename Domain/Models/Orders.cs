using Domain.Primitives;

namespace Domain.Models
{
    public class Order : Entity
    {
        public ICollection<EmployeeOrderType> EmployeeOrderTypes { get; set; }

    }



}
