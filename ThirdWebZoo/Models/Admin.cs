using System.ComponentModel.DataAnnotations;

namespace ThirdWebZoo.Models
{
    public class Admin
    {
        public int AdminId { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        public string? AdminName { get; set; }
        [Required(ErrorMessage = "Please enter your password")]
        public string? Password { get; set; }
    }
}
