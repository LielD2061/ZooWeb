using ThirdWebZoo.Models;

namespace ThirdWebZoo.Repositories
{
    public interface IGeneralRepository
    {
        public AllModel GetData();
        public AllModel GetByCategory(int categoryId);
        public AllModel GetTwoHighestComments();
    }
}
