using System.Threading.Tasks;

namespace WappaMobile.ChallengeDev.Models.Addresses
{
    public interface IGeoCodeFacade : IAntiCorruptionLayer
    {
        Task<Coordinate> SearchAsync(Address address);
    }
}