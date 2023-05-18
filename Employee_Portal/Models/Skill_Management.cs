using System.ComponentModel.DataAnnotations;

namespace Employee_Portal.Models
{
    public class Skill_Management
    {
        [Key]
        public int Combined_Id { get; set; }
        [Required]
        public string Skill_Id { get; set; }
        [Required]
        public int Employee_Id { get; set; }
        [Required]
        public string Skill_Name { get; set; }
        
    }
}
