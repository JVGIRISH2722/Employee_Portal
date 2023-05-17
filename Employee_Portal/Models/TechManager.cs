using System.ComponentModel.DataAnnotations;

namespace Employee_Portal.Models
{
    public class TechManager
    {
        [Key]
        public string Tech_Manager_UserName { get; set; }
        [Required]
        public string Tech_Manager_Password { get; set; }
    }
}
