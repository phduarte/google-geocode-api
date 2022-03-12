namespace WappaMobile.ChallengeDev.Models.Drivers
{
    public class GetDriverByIdUseCase : IUseCase<IdentityRequestResponse, DriverSummary>
    {
        private IDriversRepository _driversRepository;

        public GetDriverByIdUseCase(IDriversRepository driversRepository)
        {
            _driversRepository = driversRepository;
        }

        public DriverSummary Execute(IdentityRequestResponse request)
        {
            var data = _driversRepository.Get(request.Id);
            return DriverSummary.From(data);
        }
    }
}
