using Domain.Primitives;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class EmployeeCollection : Entity
    {
        [NotMapped]
        public override string Name { get; set; }
        public int EmployeeId { get; set; }
        public int CollectionId { get; set; }


        public int? EmployeeOrderInCollection { get; set; }

        public Collection Collection { get; set; }

        public Employee Employee { get; set; }
    }
}
