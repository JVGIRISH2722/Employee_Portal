using System.ComponentModel.DataAnnotations;

namespace Employee_Portal.Models
{
    public class Skill_Id
    {
        [Key]
        public int Skill_id { get; set; }
        [Required]
        public string Skill1 { get; set; }
    }
   
}
