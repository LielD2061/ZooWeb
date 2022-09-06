using System.ComponentModel.DataAnnotations;

namespace ThirdWebZoo.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Please enter your Password")]
        public string? Password { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter your Email")]
        [RegularExpression(".+@.+\\..+")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter your first name")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please enter your age")]
        [Range (5, 99)]
        public int Age { get; set; }
    }
}
