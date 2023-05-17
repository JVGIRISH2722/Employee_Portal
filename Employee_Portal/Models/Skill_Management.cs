using System.ComponentModel.DataAnnotations;

namespace Employee_Portal.Models
{
    public class Skill_Management
    {
        [Required]
        public int User_Id { get; set; }
        [Required]
        public string Skill_Id { get; set; }
        [Key]
        public int Combined_ID { get; set; }
        
    }
}
