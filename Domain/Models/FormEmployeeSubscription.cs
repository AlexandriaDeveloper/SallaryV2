using Domain.Primitives;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class FormEmployeeSubscription : Entity
    {
        [NotMapped]
        public override string? Name { get => base.Name; set => base.Name = value; }

        [Required]
        public int SubscriptionId { get; set; }
        [Required]
        public int FormEmployeeId { get; set; }

        public decimal Amount { get; set; }
        public char CreditOrDebit { get; set; }
        public FormEmployee FormEmployee { get; set; }
        public Subscription Subscription { get; set; }

    }
}
