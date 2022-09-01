using TheZOO.Data;
using ThirdWebZoo.Models;

namespace ThirdWebZoo.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly MyContext _context;
        public AdminRepository(MyContext context)
        {
            _context = context;
        }

        public Admin AllowAdmin()
        {
            throw new NotImplementedException();
        }

        public Admin GetAdmins()
        {
            throw new NotImplementedException();
        }
    }
}
