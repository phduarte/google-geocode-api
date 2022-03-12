namespace WappaMobile.ChallengeDev.Models.Drivers
{
    public class DriverCreationInfo : IPreCondition
    {
        public Driver AsModel()
        {
            return new Driver
            {

            };
        }

        public static DriverCreationInfo From(Driver driver)
        {
            return new DriverCreationInfo
            {

            };
        }
    }
}