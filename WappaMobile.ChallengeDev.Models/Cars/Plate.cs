using System.Collections.Generic;

namespace WappaMobile.ChallengeDev.Models.Cars
{
    public class Plate : ValueObject
    {
        string _letters = string.Empty;

        public string Letters { get { return _letters; } set { _letters = value.ToUpper(); } }
        public string Numbers { get; set; } = string.Empty;
        public string NumberPlate => $"{Letters}-{Numbers}";

        public Plate()
        {

        }

        public Plate(string placa)
        {
            _letters = placa.Substring(0, 3);
            Numbers = placa.Substring(placa.Length - 4);
        }

        public Plate(string letras, string numeros)
        {
            _letters = letras;
            Numbers = numeros;
        }

        public bool IsValid
        {
            get
            {
                return Check.IsNumeric(Numbers) && Check.IsLetter(Letters);
            }
        }

        public override string ToString()
        {
            return NumberPlate;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return NumberPlate;
        }

        public static implicit operator Plate(string plate)
        {
            return new Plate(plate);
        }
    }
}