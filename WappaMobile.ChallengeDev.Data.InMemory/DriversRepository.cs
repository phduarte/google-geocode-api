using System.Linq;
using WappaMobile.ChallengeDev.Models;
using WappaMobile.ChallengeDev.Models.Drivers;

namespace WappaMobile.ChallengeDev.Data.InMemory
{
    internal class DriversRepository : Repository<Driver>, IDriversRepository
    {
        public Driver Find(Name name)
        {
            return _cache.First(x => x.Name.Equals(name));
        }
    }
}