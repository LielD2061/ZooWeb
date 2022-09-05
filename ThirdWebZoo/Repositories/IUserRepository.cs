using TheZOO.Data;

namespace ThirdWebZoo.Repositories
{
    public interface IUserRepository
    {
        public MyContext NewUser(string firstName, string lastName, int age, string e_mail, string password, string userName);
    }
}
