using Domain.Primitives;

namespace Domain.Models
{
    public class Subscription : Entity
    {
        public ICollection<RegisterdEmployeeSubscription>? RegisterdEmployeeSubscriptions { get; set; }
        public ICollection<FormEmployeeSubscription>? FormEmployeeSubscriptions { get; set; }

    }


}
