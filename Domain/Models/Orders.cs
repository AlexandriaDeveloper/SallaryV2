using Domain.Primitives;

namespace Domain.Models
{
    public class Order : Entity
    {
        public ICollection<FormEmployeeOrder> FormEmployeeOrders { get; set; }

    }



}
