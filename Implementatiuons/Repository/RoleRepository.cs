using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkedOut.Context;
using LinkedOut.Entites.Identity;
using LinkedOut.Implementations.Repository;
using LinkedOut.Interface.Repository;
using Microsoft.EntityFrameworkCore;

namespace LinkedOut.Implementations.Repository
{
    public class RoleRepository: BaseRepository<Role>, IRoleRepository 
    {
        public RoleRepository(ApplicationContext Context)
        {
            _Context = Context;
        }
        
        public async Task<Role> GetRoleByAdminUsername(string name)
        {
            return await _Context.Roles.Include(x => x.Admin).SingleOrDefaultAsync(x => x.Name == name);
        }
        public async Task<List<Role>> GetAllRoles(string name)
        {
            return await _Context.Roles.Include(x => x.Admin).Where(x => x.Name == name).ToListAsync();
        }
    }
}