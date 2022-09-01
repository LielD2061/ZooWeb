namespace ThirdWebZoo.Models
{
    public class Category
    {
        //public static int Id;
        public static int cnt = 1;
        public int CategoryId { get; set; }
        public string? Name { get; set; }
        public string? AnimalPicture { get; set; }
        public List<Animal>? Animal { get; set; }

        public Category()
        {
            cnt++;
        }
    }
}
