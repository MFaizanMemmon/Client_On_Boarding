using System.ComponentModel.DataAnnotations;

namespace Client_On_Boarding.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; } = DateTime.UtcNow;
        public int ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; } = DateTime.UtcNow;
    }
}
