using Domain.Primitives;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class EmployeeVacationType : Entity
    {

        [NotMapped]
        public override string Name { get => base.Name; set => base.Name = value; }
        public DateTime StartAt { get; set; }
        public DateTime? EndAt { get; set; }
        public int? Qunatity { get; set; }
        public int VacationId { get; set; }
        public int EmployeeOrderId { get; set; }
        public Vacation Vacation { get; set; }
        public EmployeeOrder EmployeeOrder { get; set; }
        public ICollection<EmployeeVacationTypeExecuation>? EmployeeVacationTypeExecuation { get; set; }
    }
}
