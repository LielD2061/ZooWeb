using ThirdWebZoo.Models;

namespace ThirdWebZoo.Repositories
{
    public interface IAdminRepository
    {
        public bool AllowAdmin(Admin admin);
        public void AddAnimal(Animal animal);
        public bool CheckAddAnimal(Animal animal);
        public void RemoveAnimal(int animalId);
        public bool CheckRemoveAnimal(int animalId);
        public IEnumerable<Comment> GetAllComments(int animalId);
        public void DeleteComment(int commentId);
        public bool CheckDeleteComment(int commentId);
        public void EditComment(int commentId, string editedComment);
        public bool CheckEditComment(int commentId, string editedComment);
        public void EditAnimal(Animal animal);
        public bool CheckEditAnimal(Animal animal);
        public void CreateAdmin(Admin admin);
        public bool CheckCreateAdmin(Admin admin);
        public IEnumerable<Admin> GetAllAdmin();
        public bool DeleteAdmin(int adminId);
        public IEnumerable<User> GetAllUsers();
        public bool DeleteUser(int userId);
    }
}
