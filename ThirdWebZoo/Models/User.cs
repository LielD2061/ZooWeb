using System.ComponentModel.DataAnnotations;

namespace ThirdWebZoo.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "Please enter your username")]
        public string? Password { get; set; }
        [Required(ErrorMessage = "Please enter your Email")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Please enter your first name")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your last name")]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "Please enter your age")]
        public int Age { get; set; }
    }
}
