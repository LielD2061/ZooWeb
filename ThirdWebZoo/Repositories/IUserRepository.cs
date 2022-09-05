using TheZOO.Data;

namespace ThirdWebZoo.Repositories
{
    public interface IUserRepository
    {
        public string NewUser(string firstName, string lastName, int age, string e_mail, string password, string userName);
    }
}
