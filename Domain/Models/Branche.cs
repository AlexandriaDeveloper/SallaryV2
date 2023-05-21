using Domain.Primitives;

namespace Domain.Models
{
    public class Branch : Entity
    {
        public int BankId { get; set; }
        public required Bank Bank { get; set; }

    }
}
