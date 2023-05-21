using Domain.Primitives;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class Form : Entity
    {
        [NotMapped]
        public override string Name { get; set; }
        [MaxLength(150)]
        public string Details { get; set; }
        [MaxLength(30)]
        public string FormDate { get; set; }
        [MaxLength(5)]
        public string? FileNumber55 { get; set; }
        [MaxLength(5)]
        public string? FileNumber224 { get; set; }

        public ICollection<FormEmployee> FormEmployees { get; set; }

    }
}
