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
        //public IQueryable Values(User user)
        //{
        //    var values = from ud in _userContext.users
        //                 where user.UserId == ud.UserId &&
        //                 ud.UserName == user.UserName &&
        //                 ud.FirstName == user.FirstName
        //                 select ud;

        //    return values;
        //}
        public bool IsExist(User Password, User UserName)
        {
            var spePassword = _userContext.users!.Contains(Password);
            var speUser = _userContext.users!.Contains(UserName);
            if(spePassword && speUser)
                return true;
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
