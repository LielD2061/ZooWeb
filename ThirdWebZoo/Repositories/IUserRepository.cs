using ThirdWebZoo.Models;

namespace ThirdWebZoo.Repositories
{
    public interface IUserRepository
    {
        public bool NewUser(User user);
        public bool IsExist(string Password, string UserName);
    }
}
