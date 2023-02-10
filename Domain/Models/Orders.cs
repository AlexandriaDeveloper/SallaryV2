using Domain.Primitives;

namespace Domain.Models
{
    public class Order : Entity
    {
        public ICollection<EmployeeOrder>? EmployeeOrder { get; set; }
        //  public ICollection<EmployeeOrderDeduction>? EmployeeOrderDeduction { get; set; }
    }



}
