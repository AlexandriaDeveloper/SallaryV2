using Domain.Primitives;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class PeriodicSubscription : Entity
    {
        [NotMapped]
        public override string? Name { get => base.Name; set => base.Name = value; }

        [Required]
        public int SubscriptionId { get; set; }
        [Required]
        public int FormId { get; set; }
        [Required]
        public int EmployeeId { get; set; }
        public decimal Amount { get; set; }
        public char CreditOrDebit { get; set; }
        public Employee Employee { get; set; }
        public Form Form { get; set; }
        public Subscription Subscription { get; set; }

    }
}
