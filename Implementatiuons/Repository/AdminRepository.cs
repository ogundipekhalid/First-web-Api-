using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkedOut.Context;
using LinkedOut.Entites;
using LinkedOut.Interface.Repository;
using Microsoft.EntityFrameworkCore;

namespace LinkedOut.Implementations.Repository
{
    public class AdminRepository : BaseRepository<Admin> , IAdminRepository 
    {
        public AdminRepository(ApplicationContext Context)
        {
            _Context = Context;
        }

        public async Task<List<Admin>> GetAllAdminsAsync()
        {
            return await _Context.Admins
            .Include(admin => admin.User)
            .Include(c => c.Role).Where(x => x.IsDeleted == false)
            .ToListAsync();
        }
    }
} 