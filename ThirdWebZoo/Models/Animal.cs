namespace ThirdWebZoo.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string? Name { get; set; }
        public int AnimalAge { get; set; }
        public string? Species { get; set; }
        public string? AnimalClass { get; set; }
        public string? Description { get; set; }
        public string? AnimalPicture { get; set; }
        public int CategoryId { get; set; }
        public List<Comment>? Comments_Animals { get; set; }
    }
}

