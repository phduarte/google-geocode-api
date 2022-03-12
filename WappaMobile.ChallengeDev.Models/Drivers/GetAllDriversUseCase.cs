using System.Linq;

namespace WappaMobile.ChallengeDev.Models.Drivers
{
    public class GetAllDriversUseCase : IUseCase<DriverSearchCriteria, DriverList>
    {
        private readonly IDriversRepository _driversRepository;

        public GetAllDriversUseCase(IDriversRepository driversRepository)
        {
            _driversRepository = driversRepository;
        }

        public DriverList Execute(DriverSearchCriteria request)
        {
            var response = new DriverList();

            var model = _driversRepository.GetAll().Where(x => x.Name.Equals(request.Name));

            if (request.OrderBy.ToLower().Equals("fistname"))
                response.AddRange(model.OrderBy(x => x.Name.FirstName));

            if (request.OrderBy.ToLower().Equals("lastname"))
                response.AddRange(model.OrderBy(x => x.Name.LastName));

            return response;
        }
    }
}
