using WappaMobile.ChallengeDev.Models.Addresses;

namespace WappaMobile.ChallengeDev.Models.Drivers
{
    public class CreateDriverUseCase : IUseCase<Driver, IdentityRequestResponse>
    {
        private readonly IGeoCodeFacade _geoCodeFacade;
        private readonly IDriversRepository _driversRepository;

        public CreateDriverUseCase(IGeoCodeFacade geoCodeFacade, IDriversRepository driversRepository)
        {
            _geoCodeFacade = geoCodeFacade;
            _driversRepository = driversRepository;
        }

        public IdentityRequestResponse Execute(Driver driver)
        {
            //var driver = request.AsModel();
            var coord = _geoCodeFacade.SearchAsync(driver.Address).GetAwaiter().GetResult();

            driver.Address.Coordinate = coord;

            _driversRepository.Add(driver);

            return IdentityRequestResponse.From(driver.Id);
        }
    }
}
