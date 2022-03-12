using WappaMobile.ChallengeDev.Models.Addresses;
using WappaMobile.ChallengeDev.Models.Cars;

namespace WappaMobile.ChallengeDev.Models.Drivers
{
    public class Driver : Entity, IAggregateRoot
    {
        public Name Name { get; set; }
        public Car Car { get; set; } = new Car();
        public Address Address { get; set; } = new Address();

        public bool IsValid => (Name?.IsValid ?? false) && (Car?.IsValid ?? false) && (Address?.IsValid ?? false);

        public override string ToString()
        {
            return Name;
        }
    }
}
