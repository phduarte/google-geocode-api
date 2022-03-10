using Xunit;

namespace WappaMobile.ChallengeDev.Models.Test
{
    public class CoordinateTest
    {
        [Fact]
        public void ShouldDisplayToString()
        {
            var coordinate = new Coordinate(10, 100);
            Assert.Equal("10x100", coordinate.ToString());
        }

        [Fact]
        public void ShouldNotBeEmpty_WhenArgumentsPassed()
        {
            var coordinate = new Coordinate(10, 100);
            Assert.False(coordinate.IsEmpty);
        }

        [Fact]
        public void ShouldBeEmpty_WhenInstanciatedWithNoArguments()
        {
            var coordinate = new Coordinate();
            Assert.True(coordinate.IsEmpty);
        }

        [Fact]
        public void ShouldBeEmpty_WhenInstanciateWithZero()
        {
            var coordinate = new Coordinate(0, 0);
            Assert.True(coordinate.IsEmpty);
        }

        [Fact]
        public void ShouldBeSerialized_WhenInstanciateWithZero()
        {
            var coordinate = new Coordinate(0, 0);
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(coordinate);
            Assert.Equal("{\"Latitude\":0.0,\"Longitude\":0.0,\"IsEmpty\":true}", json);
        }

        [Fact]
        public void ShouldBeSerialized_WhenInstanciateWithArguments()
        {
            var coordinate = new Coordinate(1, 2);
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(coordinate);
            Assert.Equal("{\"Latitude\":1.0,\"Longitude\":2.0,\"IsEmpty\":false}", json);
        }
    }
}
