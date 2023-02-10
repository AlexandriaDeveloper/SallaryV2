using Domain.Primitives;

namespace Domain.Models
{
    public class Subscription : Entity
    {


        public ICollection<EmployeeSubscription> EmployeeSubscriptions { get; set; }
        public ICollection<PeriodicSubscription> PeriodicSubscription { get; set; }

    }


}
