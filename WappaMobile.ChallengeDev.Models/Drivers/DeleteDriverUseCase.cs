namespace WappaMobile.ChallengeDev.Models.Drivers
{
    public class DeleteDriverUseCase : IUseCase<IdentityRequestResponse, EmptyResponse>
    {
        private IDriversRepository _driversRepository;

        public DeleteDriverUseCase(IDriversRepository driversRepository)
        {
            _driversRepository = driversRepository;
        }

        public EmptyResponse Execute(IdentityRequestResponse request)
        {
            _driversRepository.Remove(request.Id);
            return EmptyResponse.Empty;
        }
    }
}
