using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Primitives
{
#nullable enable
    public abstract class Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        [MaxLength(150)]
        public virtual string Name { get; set; } = "";

        //Audtiting
        [MaxLength(40)]
        public string CreatedBy { get; set; } = "";
        public DateTime CreatedDate { get; set; }
        [MaxLength(40)]
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        [NotMapped]
        public bool IsModified
        {
            get
            {
                return ModifiedDate != null;
            }
        }
        [MaxLength(40)]
        public string? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        [NotMapped]
        public bool IsDeleted
        {
            get
            {
                return DeletedDate != null;
            }
        }
    }
}
