using TheZOO.Data;
using ThirdWebZoo.Models;

namespace ThirdWebZoo.Repositories
{
    public class GenerslRepository : IGeneralRepository
    {
        private MyContext _context;
        public GenerslRepository(MyContext context)
        {
            _context = context;
        }
        public AllModel GetData()
        {
            var vm = new AllModel
            {
                AllCategories = _context.categories,
                AllAnimals = _context.animals,
                AllAdmins = _context.admins,
                AllComments = _context.comments
            };
            return vm;
        }
        public AllModel GetByCategory(int categoryId)
        {
            var temp = new AllModel()
            {
                AllAnimals = _context.animals
            };
            if (categoryId == 0 || categoryId > 5) return temp;
            var temp1 = new AllModel();
            temp1.AllAnimals = from a in temp.AllAnimals
                               where a.CategoryId == categoryId
                               select a;
            return temp1;
        }
        public AllModel GetTwoHighestComments()
        {
<<<<<<< HEAD:ThirdWebZoo/Repository/GenerslRepository.cs
            var highestTwoComments = new AllModel()
            {
                AllAnimals = _context.animals.OrderByDescending(a => a.Comments_Animals!.Count).Take(2)
            };
            return highestTwoComments;
=======
            var animalwithhighestcomments = new AllModel
            {
                AllAnimals = _context.animals.OrderByDescending(a => a.Comments_Animals!.Count()).Take(2)
            };
            return animalwithhighestcomments;
>>>>>>> 541e69bc44b9e593ad58d1cc2a5a134606d7b6ef:ThirdWebZoo/Repository/AllAnimalRepository.cs
        }
    }
}
