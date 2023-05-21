using Domain.Primitives;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{

    public class EmployeeBankAccount : Entity
    {


        [NotMapped]
        public override string Name { get; set; }
        public int BranchId { get; set; }
        [MaxLength(22)]
        public string? AccountNumber { get; set; }
        public  Branch? Branche { get; set; }
        public  Employee? Employee { get; set; }

    }
}
