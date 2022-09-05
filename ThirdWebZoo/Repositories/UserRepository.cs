using TheZOO.Data;
using ThirdWebZoo.Models;

namespace ThirdWebZoo.Repositories
{
    public class UserRepository : IUserRepository
    {
        private MyContext _userContext;
        public UserRepository(MyContext myContext)
        {
            _userContext = myContext;
        }
        public bool IsExist(string password, string userName)
        {
            foreach (var user in _userContext.users!)
            {
                if (user.UserName == userName && user.Password == password)
                    return true;
            }
            return false;
        }
        public string NewUser(User user)
        {
            _userContext.Add(user);
            _userContext.SaveChanges();
            return "Congratiolations";
        }

    }
}
