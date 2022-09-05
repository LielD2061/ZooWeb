using System.ComponentModel.DataAnnotations;

namespace ThirdWebZoo.Models
{
    public class User
    {
        public int UserId { get; set; }
        //[Required]
        public string? UserName { get; set; }
        //[Required]
        public string? Password { get; set; }
        //[Required]
        public string? Email { get; set; }
        //[Required]
        public string? FirstName { get; set; }
        //[Required]
        public string? LastName { get; set; }
        //[Required]
        public int Age { get; set; }
    }
}
