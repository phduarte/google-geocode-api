using System;

namespace WappaMobile.ChallengeDev.Models
{
    public class IdentityRequestResponse : IPreCondition, IPostCondition
    {
        public Guid Id { get; set; }

        public static IdentityRequestResponse From(Guid id)
        {
            return new IdentityRequestResponse
            {
                Id = id
            };
        }
    }
}
