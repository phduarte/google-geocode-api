using Xunit;

namespace WappaMobile.ChallengeDev.Models.Test
{
    public class CarTest
    {
        [Fact]
        public void ShouldDisplayToString()
        {
            var car = new Car
            {
                Brand = "Ford",
                Model = "Ecosport",
                Plate = "FDV-0461"
            };

            Assert.Equal("Ford Ecosport - FDV-0461", $"{car}");
        }
    }
}
