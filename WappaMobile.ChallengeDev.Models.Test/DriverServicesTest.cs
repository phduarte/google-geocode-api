using System;
using Xunit;
using Moq;
using WappaMobile.ChallengeDev.Models.Drivers;
using WappaMobile.ChallengeDev.Models.Addresses;

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

            var expectedDriver = new DriverSummary
            {
                Id = id
            };

            var driverRepository = new Mock<IDriversRepository>();
            var driverService = new GetDriverByIdUseCase(driverRepository.Object);

            driverRepository.Setup(x => x.Get(id)).Returns(driver);
            var emptyRequest = new IdentityRequest
            {
                Id = id
            };

            var savedDriver = driverService.Execute(emptyRequest);

            Assert.Equal(expectedDriver.Id, savedDriver.Id);
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
            var driverService = new CreateDriverUseCase(googleFacade.Object, driverRepository.Object);

            googleFacade.Setup(x => x.SearchAsync(address)).ReturnsAsync(new Coordinate(100, 100));

            var newDriver = new DriverCreationInfo
            {

            };

            driverService.Execute(newDriver);
        }
    }
}
