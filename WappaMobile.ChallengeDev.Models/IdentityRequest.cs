using System;

namespace WappaMobile.ChallengeDev.Models
{
    public class IdentityRequest : IPreCondition
    {
        public Guid Id { get; set; }

        public static IdentityRequest From(Guid id)
        {
            return new IdentityRequest
            {
                Id = id
            };
        }
    }
}
