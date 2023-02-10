using Domain.Primitives;

namespace Domain.Models
{
    public class Bank : Entity
    {

        public ICollection<Branch>? Branches { get; set; }
    }


}
