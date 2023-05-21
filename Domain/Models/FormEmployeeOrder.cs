using Domain.Primitives;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
#nullable enable
    public class FormEmployeeOrder : Entity
    {
        [NotMapped]
        public override string Name { get; set; }
        [MaxLength(5)]
        public string? OrderNumber { get; set; }
        [MaxLength(200)]
        public string? Details { get; set; }
        public int FormEmployeeId { get; set; }
        public int OrderId { get; set; }
        public char CreditOrDebit { get; set; }
        public int? Quantity { get; set; }
        public DateTime? SelectedDate { get; set; }
        public  Order? Order { get; set; }
        public  FormEmployee? FormEmployee { get; set; }
        public ICollection<FormEmployeeOrderExecuation>? FormEmployeeOrderExecuations { get; set; }
 
    }
}
