using ThirdWebZoo.Models;

namespace ThirdWebZoo.Repositories
{
    public interface IUserRepository
    {
        public string NewUser(User user);
        public bool IsExist(User Password, User UserName);
    }
}
