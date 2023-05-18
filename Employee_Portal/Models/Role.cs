using System.ComponentModel.DataAnnotations;

namespace Employee_Portal.Models
{
    public class Role
    {
        [Key]
        public int Role_Id { get; set; }
        [Required]
        public string Role1 { get; set; }
    }
}
