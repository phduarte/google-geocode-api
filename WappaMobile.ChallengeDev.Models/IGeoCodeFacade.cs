using System.Threading.Tasks;

namespace WappaMobile.ChallengeDev.Models
{
    public interface IGeoCodeFacade : IAntiCorruptionLayer
    {
        Task<Coordinate> SearchAsync(Address address);
    }
}