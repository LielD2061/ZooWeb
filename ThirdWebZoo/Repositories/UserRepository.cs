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
        public bool NewUser(User user)
        {
            if (CheckIfInData(user))
            {
                _userContext.Add(user);
                _userContext.SaveChanges();
                return true;
            }
            return false;
        }
        public bool CheckIfInData(User user)
        {
            foreach (var usercheck in _userContext.users!)
            {
                if (usercheck.UserName == user.UserName)
                    return false;
            }
            return true;
        }
    }
}
