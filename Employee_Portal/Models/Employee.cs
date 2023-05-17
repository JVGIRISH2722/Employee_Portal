using System.ComponentModel.DataAnnotations;

namespace Employee_Portal.Models
{
    public class Employee
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Employee_Name { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Gender { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        [Required]
        public int Experience { get; set; }
        public string Skill { get; set; }
        public string Role { get; set; }
    }
}
