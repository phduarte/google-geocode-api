using System;
using System.Collections.Generic;

namespace WappaMobile.ChallengeDev.Models
{
    public interface IDriverServices
    {
        void Add(Driver driver);
        Driver GetById(Guid guid);
        IEnumerable<Driver> GetDrivers();
        void Remove(Guid guid);
        void Save(Driver driver);
    }
}