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
        public string NewUser(User user)
        {
            _userContext.Add(user);
            _userContext.SaveChanges();
            return "Congratiolations"; 
        }
    }
}
