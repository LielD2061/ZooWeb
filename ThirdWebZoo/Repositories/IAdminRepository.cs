using ThirdWebZoo.Models;

namespace ThirdWebZoo.Repositories
{
    public interface IAdminRepository
    {
        public bool AllowAdmin(Admin admin);
        public bool AddAnimal(Animal animal);
        public bool RemoveAnimal(int animalId);
    }
}
