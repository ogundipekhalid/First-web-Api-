using LinkedOut.Context;
using LinkedOut.Entites.Identity;
using LinkedOut.Implementations.Repository;
using LinkedOut.Interface.Repository;
using Microsoft.EntityFrameworkCore;

namespace LinkedOut.Implementations.Repository
{
    public class UserRepository: BaseRepository<User>, IUserRepository 
    {
        public UserRepository(ApplicationContext Context)
        {
            _Context = Context;
        }
        
    }
}