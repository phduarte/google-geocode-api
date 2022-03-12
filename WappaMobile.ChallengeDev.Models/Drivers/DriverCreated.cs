namespace WappaMobile.ChallengeDev.Models.Drivers
{
    public class DriverCreated : IPostCondition
    {
        public static DriverCreated From(Driver driver)
        {
            return new DriverCreated
            {

            };
        }
    }
}