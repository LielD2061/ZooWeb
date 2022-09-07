using System.ComponentModel.DataAnnotations;

namespace ThirdWebZoo.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        [Required(ErrorMessage = "Please enter name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter age between 0-150")]
        [Range (0, 150)]
        public int AnimalAge { get; set; }
        [Required(ErrorMessage = "Please enter species")]
        public string? Species { get; set; }
        [Required(ErrorMessage = "Please enter class")]
        public string? AnimalClass { get; set; }
        [Required(ErrorMessage = "Please enter description")]
        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }
        public string? AnimalPicture { get; set; }
        [Required(ErrorMessage = "Please pick the correct category")]
        public int CategoryId { get; set; }
        public virtual ICollection<Comment>? Comments_Animals { get; set; }
    }
}

