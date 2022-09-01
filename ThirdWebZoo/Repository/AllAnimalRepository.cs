using TheZOO.Data;
using ThirdWebZoo.Models;

namespace ThirdWebZoo.Repositories
{
    public class AllAnimalRepository : IAllAnimalRepository
    {
        private MyContext _context;
        public AllAnimalRepository(MyContext context)
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
            var animalwithhighestcomments = new AllModel
            {
                AllAnimals = _context.animals.OrderByDescending(a => a.Comments_Animals!.Count()).Take(2)
            };
            return animalwithhighestcomments;
        }
    }
}
