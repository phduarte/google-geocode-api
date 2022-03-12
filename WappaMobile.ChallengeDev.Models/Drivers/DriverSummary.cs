using System;

namespace WappaMobile.ChallengeDev.Models.Drivers
{
    public class DriverSummary : IPostCondition
    {
        public Guid Id { get; set; }

        public static DriverSummary From(Driver driver)
        {
            return new DriverSummary()
            {
                Id = driver.Id
            };
        }
    }
}