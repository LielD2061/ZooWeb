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
        public MyContext NewUser(string firstName, string lastName, int age, string e_mail, string password, string userName)
        {
            _userContext.users!.Add(new User { FirstName = firstName, LastName = lastName, Age = age, Email = e_mail, Password = password, UserName = userName });
            _userContext.SaveChanges();
            return _userContext; 
        }
    }
}
