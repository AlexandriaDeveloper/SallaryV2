using Domain.Primitives;
using System.ComponentModel.DataAnnotations.Schema;


namespace Domain.Models
{
    public class FormEmployeeOrderExecuation : Entity
    {
        [NotMapped]
        public override string? Name { get; set; }
        public int? BudgetItemId { get; set; }
        public decimal Amount { get; set; }
        public int FormEmployeeOrderId { get; set; }
        public  FormEmployeeOrder? FormEmployeeOrder { get; set; }
        public BudgetItem? BudgetItem { get; set; }
    }



}
