using System;
using System.Collections.Generic;

namespace WappaMobile.ChallengeDev.Models
{
    internal class DriverServices : IDriverServices
    {
        private readonly IGeoCodeFacade _geoCodeFacade;
        private readonly IDriversRepository _driversRepository;

        public DriverServices(IGeoCodeFacade geoCodeFacade, IDriversRepository driversRepository)
        {
            _geoCodeFacade = geoCodeFacade;
            _driversRepository = driversRepository;
        }

        public Driver GetById(Guid guid) => _driversRepository.Get(guid);
        public IEnumerable<Driver> GetDrivers() => _driversRepository.GetAll();
        public void Save(Driver driver) => _driversRepository.Save(driver);
        public void Add(Driver driver)
        {
            //var coord = _geoCodeFacade.SearchAsync(driver.Address).GetAwaiter().GetResult();
            //driver.Address.Coordinate = coord;

            _driversRepository.Add(driver);
        }

        public void Remove(Guid guid) => _driversRepository.Remove(guid);
    }
}
