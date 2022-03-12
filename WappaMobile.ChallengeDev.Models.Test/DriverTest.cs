using System;
using Xunit;
using Newtonsoft.Json;
using WappaMobile.ChallengeDev.Models.Drivers;
using WappaMobile.ChallengeDev.Models.Cars;
using WappaMobile.ChallengeDev.Models.Addresses;

namespace WappaMobile.ChallengeDev.Models.Test
{
    public class DriverTest
    {
        [Fact]
        public void ShouldInstanciate()
        {
            _ = new Driver();
        }

        [Fact]
        public void ShouldConvertToJson_WhenPropertiesAreNull()
        {
            var driver = new Driver
            {
                Id = Guid.Parse("C88B881A-41C7-421D-B86F-763CF31D5F9E")
            };

            _ = JsonConvert.SerializeObject(driver);
        }

        [Fact]
        public void ShouldConvertToJson_WhenAllPropertiesAreProvided()
        {
            var driver = new Driver
            {
                Id = Guid.Parse("C88B881A-41C7-421D-B86F-763CF31D5F9E"),
                Name = new Name("Paulo", "Duarte"),
                Car = new Car
                {
                    Id = Guid.NewGuid(),
                    Brand = "Ford",
                    Model = "Ecosport",
                    Plate = new Plate
                    {
                        Letters = "ECS",
                        Numbers = "1461",
                    }
                },
                Address = new Address
                {
                    City = "Belo Horizonte",
                    Coordinate = new Coordinate(1, 1),
                    District = "Barreiro",
                    Number = "309",
                    State = "Minas Gerais",
                    Street = "Amazonas",
                    Suffix = "Av",
                    ZipCode = "011133-552"
                }
            };

            _ = JsonConvert.SerializeObject(driver);
        }

        [Fact]
        public void ShouldBeValid_WhenAllPropertiesAreProvided()
        {
            var driver = new Driver
            {
                Id = Guid.Parse("C88B881A-41C7-421D-B86F-763CF31D5F9E"),
                Name = new Name("Paulo", "Duarte"),
                Car = new Car
                {
                    Id = Guid.NewGuid(),
                    Brand = "Ford",
                    Model = "Ecosport",
                    Plate = new Plate
                    {
                        Letters = "ECS",
                        Numbers = "1461",
                    }
                },
                Address = new Address
                {
                    City = "Belo Horizonte",
                    Coordinate = new Coordinate(1, 1),
                    District = "Barreiro",
                    Number = "309",
                    State = "Minas Gerais",
                    Street = "Amazonas",
                    Suffix = "Av",
                    ZipCode = "011133-552"
                }
            };

            Assert.True(driver.IsValid);
        }

        [Fact]
        public void ShouldDisplayToString()
        {
            var driver = new Driver
            {
                Name = new Name
                {
                    FirstName = "Paulo",
                    LastName = "Duarte"
                }
            };

            Assert.Equal("Paulo Duarte", driver.ToString());
        }
    }
}
