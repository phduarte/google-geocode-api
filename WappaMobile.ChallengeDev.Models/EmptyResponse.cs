namespace WappaMobile.ChallengeDev.Models
{
    public class EmptyResponse : IPostCondition
    {
        public static EmptyResponse Empty => new EmptyResponse();
    }
}
