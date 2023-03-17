using Domain.Primitives;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class EmployeeOrderType : Entity
    {
        [NotMapped]
        public override string Name { get; set; }
        public int OrderId { get; set; }
        public int FormId { get; set; }
        public int EmployeeOrderId { get; set; }
        public Form? Form { get; set; }
        public char CreditOrDebit { get; set; }
        public int? Quantity { get; set; }
        public Order Order { get; set; }
        public EmployeeOrder EmployeeOrder { get; set; }
        public ICollection<EmployeeOrderTypeExecuation>? EmployeeOrderExecuations { get; set; }
    }
}
