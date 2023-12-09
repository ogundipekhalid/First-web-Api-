using System.Collections.Generic;
using System.Threading.Tasks;
using LinkedOut.Entites;
using LinkedOut.Entites.Identity;
using LinkedOut.Interface.Repository;

namespace LinkedOut.Interface.Repository
{
    public interface IRoleRepository : IBaseRepository<Role>
    {
        Task<Role> GetRoleByAdminUsername(string name);
        Task<List<Role>> GetAllRoles(string name);
    }
}