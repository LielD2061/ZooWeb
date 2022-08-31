using ThirdWebZoo.Models;

namespace ThirdWebZoo.Repositories
{
    public interface IAllAnimalRepository
    {
        public AllModel GetData();
        public AllModel GetByCategory(int categoryId);
    }
}
