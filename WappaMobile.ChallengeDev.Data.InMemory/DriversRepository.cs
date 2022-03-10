using System.Linq;
using WappaMobile.ChallengeDev.Models;

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