using System;
using Xunit;
using Moq;

namespace WappaMobile.ChallengeDev.Models.Test
{
    public class DriverServicesTest
    {
        [Fact]
        public void ShouldGetById()
        {
            var id = Guid.NewGuid();
            var driver = new Driver
            {
                Id = id
            };

            var googleFacade = new Mock<IGeoCodeFacade>();
            var driverRepository = new Mock<IDriversRepository>();
            var driverService = new DriverServices(googleFacade.Object, driverRepository.Object);

            driverRepository.Setup(x => x.Get(id)).Returns(driver);

            var savedDriver = driverService.GetById(id);

            Assert.Equal(driver, savedDriver);
        }

        [Fact]
        public void ShouldAdd()
        {
            var id = Guid.NewGuid();
            var address = new Address();
            var driver = new Driver
            {
                Id = id,
                Address = address
            };

            var googleFacade = new Mock<IGeoCodeFacade>();
            var driverRepository = new Mock<IDriversRepository>();
            var driverService = new DriverServices(googleFacade.Object, driverRepository.Object);

            googleFacade.Setup(x => x.SearchAsync(address)).ReturnsAsync(new Coordinate(100, 100));

            driverService.Add(driver);
        }
    }
}
