using System.ComponentModel.DataAnnotations;

namespace Employee_Portal.Models
{
    public class Hr
    {
        [Key]
        public string Hr_UserName { get; set; }
        [Required]
        public string Hr_Password { get; set; }
    }
}
