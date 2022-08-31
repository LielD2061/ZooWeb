namespace ThirdWebZoo.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? Name { get; set; }
        public string? AnimalPicture { get; set; }
        public List<Animal>? Animal { get; set; }
    }
}
