using System.Linq;
using WappaMobile.ChallengeDev.Models;

namespace WappaMobile.ChallengeDev.Data.InMemory
{
    internal class CarsRepository : Repository<Car>, ICarsRepository
    {
        public Car Find(Plate plate)
        {
            return _cache.First(x => x.Plate.Equals(plate));
        }
    }
}