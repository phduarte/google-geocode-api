using WappaMobile.ChallengeDev.Models.Addresses;
using Xunit;

namespace WappaMobile.ChallengeDev.Models.Test
{
    public class AddressTest
    {
        [Fact]
        public void ShouldDisplayToString()
        {
            var address = new Address
            {
                City = "Belo Horizonte",
                District = "Barreiro",
                Number = "100",
                State = "Minas Gerais",
                Street = "Amazonas",
                Suffix = "Av",
                ZipCode = "30785000"
            };

            Assert.Equal("Av Amazonas,100 - Barreiro, Belo Horizonte, Minas Gerais 30785000", address.ToString());
        }
    }
}
