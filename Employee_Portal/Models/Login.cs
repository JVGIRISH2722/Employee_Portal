using System.ComponentModel.DataAnnotations;

namespace Employee_Portal.Models
{
    public class Login
    {
        [Key]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
