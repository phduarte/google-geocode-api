namespace WappaMobile.ChallengeDev.Models.Drivers
{
    public class UpdateDriverUseCase : IUseCase<DriverUpdateInfo, DriverCreated>
    {
        private readonly IDriversRepository _driversRepository;

        public UpdateDriverUseCase(IDriversRepository driversRepository)
        {
            _driversRepository = driversRepository;
        }

        public DriverCreated Execute(DriverUpdateInfo request)
        {
            var driver = request.AsModel();
            _driversRepository.Save(driver);
            return DriverCreated.From(driver);
        }
    }
}
