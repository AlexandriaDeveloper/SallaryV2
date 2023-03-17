using Domain.Primitives;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class EmployeeBasicFinancialData : Entity

    {
        [NotMapped]
        public override string Name { get => base.Name; set => base.Name = value; }
        public int EmployeeId { get; set; }
        public int FinancialDataTypesId { get; set; }
        public decimal Amount { get; set; }


        public FinancialDataType FinancialDataTypes { get; set; }
        public Employee Employee { get; set; }
    }
}
