namespace WappaMobile.ChallengeDev.Models.Drivers
{
    /// <summary>
    /// In Domain Oriented Design, DomainModel should not know about the implementation of data storage mechanisms. Repositories are defined only by contracts that determine what is to be implemented.
    /// This practice makes the system technology agnostic and improves adaptability.
    /// </summary>
    public interface IDriversRepository : IRepository<Driver>
    {
        Driver Find(Name nome);
    }
}
