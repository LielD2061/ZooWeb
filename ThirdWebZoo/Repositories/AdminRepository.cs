using TheZOO.Data;
using ThirdWebZoo.Models;

namespace ThirdWebZoo.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly MyContext _context;
        public AdminRepository(MyContext context)
        {
            _context = context;
        }

        public bool AddAnimal(Animal animal)
        {
            var newanimal = new Animal();
            newanimal = animal;
            _context.animals.Add(newanimal);
            _context.SaveChanges();
            return true;
        }

        public bool AllowAdmin(Admin admin)
        {
            foreach (var checkadmin in _context.admins!)
            {
                if (checkadmin.AdminName == admin.AdminName && checkadmin.Password == admin.Password)
                    return true;
            }
            return false;
        }

        public bool RemoveAnimal(int animalId)
        {
            foreach (var animal in _context.animals!)
            {
                if (animal.AnimalId.Equals(animalId))
                {
                    _context.animals.Remove(animal);
                }
            }
            _context.SaveChanges();
            return true;
        }
    }
}
