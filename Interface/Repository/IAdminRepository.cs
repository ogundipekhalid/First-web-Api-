using System.Collections.Generic;
using System.Threading.Tasks;
using LinkedOut.Entites;

namespace LinkedOut.Interface.Repository
{
    public interface IAdminRepository : IBaseRepository<Admin>
    {
        Task<List<Admin>> GetAllAdminsAsync();
    }
}