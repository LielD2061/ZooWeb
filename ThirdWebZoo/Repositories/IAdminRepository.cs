using ThirdWebZoo.Models;

namespace ThirdWebZoo.Repositories
{
    public interface IAdminRepository
    {
        public Admin GetAdmins();
        public bool AllowAdmin(Admin admin);
    }
}
