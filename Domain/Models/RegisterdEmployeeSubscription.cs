using Domain.Primitives;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Domain.Models
{
    public class RegisterdEmployeeSubscription : Entity
    {
        [NotMapped]
        public override string? Name { get; set; }
        [MaxLength(200)]
        public string? Details { get; set; }
        public decimal Amount { get; set; }
        public int EmployeeId { get; set; }
        public int SubscriptionId { get; set; }
        public bool IsActive { get; set; } = true;


        public required Employee Employee { get; set; }
        public required Subscription Subscription { get; set; }
    }


}
