namespace ThirdWebZoo.Models
{
    public class AllModel
    {
        public IEnumerable<Category>? AllCategories { get; set; }
        public IEnumerable<Animal>? AllAnimals { get; set; }
        public IEnumerable<Comment>? AllComments { get; set; }
        public IEnumerable<Admin>? AllAdmins { get; set; }
    }
}
