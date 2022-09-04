namespace ThirdWebZoo.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? Name { get; set; }
        public string? AnimalPicture { get; set; }
        public virtual ICollection<Animal>? Animal { get; set; }

    }
}
