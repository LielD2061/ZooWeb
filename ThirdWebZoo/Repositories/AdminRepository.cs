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
        public bool AllowAdmin(Admin admin)
        {
            foreach (var checkadmin in _context.admins!)
            {
                if (checkadmin.AdminName == admin.AdminName && checkadmin.Password == admin.Password)
                    return true;
            }
            return false;
        }
        public void AddAnimal(Animal animal)
        {
            _context.animals!.Add(animal);
            _context.SaveChanges();
        }
        public bool CheckAddAnimal(Animal animal)
        {
            AddAnimal(animal);
            if (_context.animals!.Any(c => c.AnimalId == animal.AnimalId))
                return true;
            return false;
        }
        public void RemoveAnimal(int animalId)
        {
            foreach (var animal in _context.animals!)
            {
                if (animal.AnimalId.Equals(animalId))
                {
                    _context.animals.Remove(animal);
                }
            }
            _context.SaveChanges();
        }
        public bool CheckRemoveAnimal(int animalId)
        {
            RemoveAnimal(animalId);
            if (!_context.animals!.Any(a => a.AnimalId == animalId))
                return true;
            return false;
        }
        public IEnumerable<Comment> GetAllComments(int animalId)
        {
            var comments = _context.comments!.ToList();
            List<Comment> sendComments = new List<Comment>();
            foreach (var comment in comments)
            {
                if (comment.AnimalId == animalId)
                    sendComments.Add(comment);
            }
            return sendComments;
        }
        public void DeleteComment(int commentId)
        {
            foreach (var comment in _context.comments!)
            {
                if (comment.CommentId.Equals(commentId))
                    _context.comments.Remove(comment);
            }
            _context.SaveChanges();
        }
        public bool CheckDeleteComment(int commentId)
        {
            DeleteComment(commentId);
            if (_context.comments!.Any(c => c.CommentId == commentId))
                return true;
            return false;
        }
        public void EditComment(int commentId, string editedComment)
        {
            var comment = _context.comments!.First(c => c.CommentId == commentId);
            comment.Comments = editedComment;
            _context.SaveChanges();
        }
        public bool CheckEditComment(int commentId, string editedComment)
        {
            EditComment(commentId, editedComment);
            foreach (var comment in _context.comments!)
            {
                if (comment.CommentId == commentId && comment.Comments!.Equals(editedComment))
                    return true;
            }
            return false;

        }
        public void EditAnimal(Animal animal)
        {
            Animal oldanimal = new Animal();
            foreach (var a in _context.animals!)
            {
                if (a.AnimalId == animal.AnimalId)
                {
                    oldanimal = a;
                }
            }
            _context.animals.Remove(oldanimal);
            _context.animals.Add(animal);
            _context.SaveChanges();
        }
        public bool CheckEditAnimal(Animal animal)
        {
            EditAnimal(animal);
            foreach (var a in _context.animals!)
            {
                if (a.AnimalId == animal.AnimalId)
                {

                }
            }
            return false;
        }
        public void CreateAdmin(Admin admin)
        {
            _context.admins!.Add(admin);
            _context.SaveChanges();
        }
        public bool CheckCreateAdmin(Admin admin)
        {
            throw new NotImplementedException();
        }
    }
}
