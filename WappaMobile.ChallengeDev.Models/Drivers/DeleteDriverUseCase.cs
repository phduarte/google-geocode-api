namespace WappaMobile.ChallengeDev.Models.Drivers
{
    public class DeleteDriverUseCase : IUseCase<IdentityRequest, EmptyResponse>
    {
        private IDriversRepository _driversRepository;

        public DeleteDriverUseCase(IDriversRepository driversRepository)
        {
            _driversRepository = driversRepository;
        }

        public EmptyResponse Execute(IdentityRequest request)
        {
            _driversRepository.Remove(request.Id);
            return EmptyResponse.Empty;
        }
    }
}
