using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkedOut.Context;
using LinkedOut.Entites;
using LinkedOut.Interface.Repository;
using Microsoft.EntityFrameworkCore;

namespace LinkedOut.Implementations.Repository
{
    public class CompanyRepository : BaseRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(ApplicationContext Context)
        {
            _Context = Context;
        }
    }
}