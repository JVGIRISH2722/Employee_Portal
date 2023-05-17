using System.ComponentModel.DataAnnotations;

namespace Employee_Portal.Models
{
    public class DeliveryManager
    {
        [Key]
        public string Delivery_Manager_UserName { get; set; }
        [Required]
        public string Delivery_Manager_Password { get; set; }
    }
}
