using ThirdWebZoo.Models;

namespace ThirdWebZoo.Repositories
{
    public interface IAdminRepository
    {
        public Admin GetAdmins();
        public Admin AllowAdmin();
    }
}
