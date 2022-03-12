namespace WappaMobile.ChallengeDev.Models.Drivers
{
    public class GetDriverByIdUseCase : IUseCase<IdentityRequest, DriverSummary>
    {
        private IDriversRepository _driversRepository;

        public GetDriverByIdUseCase(IDriversRepository driversRepository)
        {
            _driversRepository = driversRepository;
        }

        public DriverSummary Execute(IdentityRequest request)
        {
            var data = _driversRepository.Get(request.Id);
            return DriverSummary.From(data);
        }
    }
}
