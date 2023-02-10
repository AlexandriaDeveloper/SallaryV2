using Domain.Primitives;

namespace Domain.Models
{
    public class EmployeeMonthlySallary :Entity {
        public Guid EmployeeId { get; set; }
        public decimal? VacationAmount { get; set; }
        public decimal? PunishmentAmount { get; set; }
      

    }



}
