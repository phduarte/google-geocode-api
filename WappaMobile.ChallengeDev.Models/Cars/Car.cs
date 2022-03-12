namespace WappaMobile.ChallengeDev.Models.Cars
{
    public class Car : Entity
    {
        public string Brand { get; set; } 
        public string Model { get; set; } 
        public Plate Plate { get; set; } = new Plate();
        public bool IsValid => Plate.IsValid && !Model.IsEmpty();

        public override string ToString()
        {
            return $"{Brand} {Model} - {Plate}";
        }
    }
}
