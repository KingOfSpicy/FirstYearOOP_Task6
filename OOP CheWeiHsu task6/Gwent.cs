using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CheWeiHsu_task6
{
    class Gwent : IEquatable<Gwent>
    {
        public Gwent(string deck, string name, int power, string type)
        {
            Deck = deck;
            Name = name;
            Power = power;
            Type = type;
        }

        private string aDeck { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return "Deck: " + Deck + ", Name: " + Name + ", Power: " + Power + ", Type: " + Type;
        }


        public override bool Equals(object obj)
        {
            return Equals(obj as Gwent);
        }

        public bool Equals(Gwent other)
        {
            return other != null &&
                   aDeck == other.aDeck &&
                   Name == other.Name &&
                   Power == other.Power &&
                   Type == other.Type &&
                   Deck == other.Deck;
        }

        public override int GetHashCode()
        {
            var hashCode = 575170910;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(aDeck);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Power.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Deck);
            return hashCode;
        }

        public string Deck
        {
            get => aDeck;
            set
            {
                if (value == "Nilfgaard" || value == "NorthernRealms" || value == "Monsters" || value == "ScoiaTael" || value == "Skellege"|| value== "Neutral")
                {
                    aDeck = value;
                }
                else
                {
                    aDeck = "Unknown";
                }
            }
        }
    }
}
