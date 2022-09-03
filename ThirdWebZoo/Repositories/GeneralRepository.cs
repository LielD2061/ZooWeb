using TheZOO.Data;
using ThirdWebZoo.Models;

namespace ThirdWebZoo.Repositories
{
    public class GeneralRepository : IGeneralRepository
    {
        private MyContext _context;
        public GeneralRepository(MyContext context)
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
        public IEnumerable<Animal> GetTwoHighestComments()
        {
            var ac = _context.animals!.ToList();
            var cc = _context.comments!.ToList();
            foreach (var animal in ac)
            {
                foreach (var comment in cc)
                {
                    if (comment.AnimalId == animal.AnimalId && !animal.Comments_Animals!.Any(c => c.CommentId == comment.CommentId))
                    {
                        animal.Comments_Animals!.Add(comment);
                    }
                }
            }
            _context.SaveChanges();
            return _context.animals!.OrderByDescending(c => c.Comments_Animals!.Count).Take(2);
        }
        public string GetNewComment(string newComment, int AnimalId)
        {
            string msg = "Excepted";
            _context.comments!.Add(new Comment { Comments = newComment, AnimalId = AnimalId});
            _context.SaveChanges();
            return msg;
        }
        public string CategoryName(int categoryId)
        {
            foreach (var category in _context.categories!)
            {
                string categoryname;
                if (category.CategoryId == categoryId)
                {
                   return categoryname = category.Name!;
                }
            }
            return "";
        }
    }
}
