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

            if (!string.IsNullOrEmpty(request.Name))
            {
                model = model.Where(x => x.Name.ToString().ToLower().Contains(request.Name.ToLower()));
            }

            if (request.OrderBy.ToLower().Equals("fistname"))
                model = model.OrderBy(x => x.Name.FirstName);

            if (request.OrderBy.ToLower().Equals("lastname"))
                model = model.OrderBy(x => x.Name.LastName);

            response.AddRange(model);

            return response;
        }
    }
}
