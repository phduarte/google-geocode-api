namespace WappaMobile.ChallengeDev.Models.Drivers
{
    public class DriverSearchCriteria : IPreCondition
    {
        public string OrderBy { get; set; }
        public string Name { get; set; }
    }
}