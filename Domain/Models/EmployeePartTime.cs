using Domain.Primitives;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class EmployeePartTime : Entity
    {
        [NotMapped]
        public override string Name { get; set; } = "";
        public DateTime StartFrom { get; set; }
        public DateTime? EndAt { get; set; }
        [MaxLength(100)]
        public string Details { get; set; } = "";


        public int EmployeeId { get; set; }


        [NotMapped]
        public bool IsPartTimeActive
        {
            get
            {
                if (!EndAt.HasValue)
                {
                    return true;
                }

                //if (EndAt.Value > DateTime.UtcNow)
                //{

                //    return true;
                //}
                return false;

            }
        }
        public required Employee Employee { get; set; }
    }
}
