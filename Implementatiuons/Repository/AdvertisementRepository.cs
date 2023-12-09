using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkedOut.Context;
using LinkedOut.Entites;
using LinkedOut.Interface.Repository;
using Microsoft.EntityFrameworkCore;

namespace LinkedOut.Implementations.Repository
{
    public class AdvertisementRepository : BaseRepository<Advertisement> , IAdvertisementRepository
    {
        public AdvertisementRepository(ApplicationContext Context)
        {
            _Context = Context;
        }

    }
}