using ThirdWebZoo.Models;

namespace ThirdWebZoo.Repositories
{
    public interface IGeneralRepository
    {
        public AllModel GetData();
        public AllModel GetByCategory(int categoryId);
        public IEnumerable<Animal> GetTwoHighestComments();
        public string GetNewComment(string newComment, int AnimalId);
        public string CategoryName(int categoryId);
    }
}
