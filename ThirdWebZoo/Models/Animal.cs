using System.ComponentModel.DataAnnotations;

namespace ThirdWebZoo.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public int AnimalAge { get; set; }
        [Required]
        public string? Species { get; set; }
        [Required]
        public string? AnimalClass { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }
        public string? AnimalPicture { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public virtual ICollection<Comment>? Comments_Animals { get; set; }
    }
}

