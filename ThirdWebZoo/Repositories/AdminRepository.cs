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
            _context.animals!.Add(newanimal);
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
        public IEnumerable<Comment> GetAllComments(int animalId)
        {
            var comments = _context.comments;
            foreach (var comment in comments)
            {
                if (comment.AnimalId == animalId)
                    comments.Add(comment);
            }
            return comments;
        }
        public bool DeleteComment(int commentId)
        {
            foreach (var comment in _context.comments!)
            {
                if (comment.CommentId.Equals(commentId))
                    _context.comments.Remove(comment);
            }
            _context.SaveChanges();
            return true;
        }
        public bool EditComment(int commentId, string editedComment)
        {
            var comment = _context.comments!.First(c => c.CommentId == commentId);
            comment.Comments = editedComment;
            _context.SaveChanges();
            return true;
        }
        public bool EditAnimal(Animal animal)
        {
            Animal animal1 = new Animal();
            foreach (var a in _context.animals!)
            {
                if (a.AnimalId == animal.AnimalId)
                {
                    animal1 = a;
                }
            }
            _context.animals.Remove(animal1);
            _context.animals.Add(animal);
            _context.SaveChanges();
            return true;
        }
    }
}
