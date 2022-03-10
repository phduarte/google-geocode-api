using System.Threading.Tasks;

namespace WappaMobile.ChallengeDev.Models
{
    public interface IGeoCodeFacade
    {
        Task<Coordinate> SearchAsync(Address address);
    }
}