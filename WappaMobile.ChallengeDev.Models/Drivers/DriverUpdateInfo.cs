namespace WappaMobile.ChallengeDev.Models.Drivers
{
    public class DriverUpdateInfo : IPreCondition
    {
        internal Driver AsModel()
        {
            return new Driver
            {

            };
        }

        public static DriverUpdateInfo From(Driver value)
        {
            return new DriverUpdateInfo
            {

            };
        }
    }
}