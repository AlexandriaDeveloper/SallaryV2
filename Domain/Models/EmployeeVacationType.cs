using Domain.Primitives;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class FormEmployeeVacation : Entity
    {

        [NotMapped]
        public override string Name { get => base.Name; set => base.Name = value; }
        public DateTime StartAt { get; set; }
        public DateTime? EndAt { get; set; }
        public string? Details { get; set; }
        public int? Qunatity { get; set; }
        public int VacationId { get; set; }
        public int FormEmployeeId { get; set; }
        public  Vacation? Vacation { get; set; }
        public  FormEmployee? FormEmployee { get; set; }
        public ICollection<EmployeeVacationExecuation>? EmployeeVacationTypeExecuation { get; set; }
    }
}
