using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CheWeiHsu_task6
{
    class Program
    {
        public static ObservableCollection<Gwent> GwentCards;
        static void Main(string[] args)
        {
            GwentCards = new ObservableCollection<Gwent>();
            GwentCards.CollectionChanged += GwentCards_CollectionChanged;

            //Console.WriteLine();
            Console.WriteLine("Here is our collection: ");
            AddCards();
            foreach (var w in GwentCards)
                Console.WriteLine("Deck: " + w.Deck + ", Name: " + w.Name + ", Power: " + w.Power + ", Type: " + w.Type);
            Console.WriteLine();
            Console.WriteLine("But for winning, I removed those power under 4: ");
            Console.WriteLine("Wyvern,"+ " Impera Brigade Guard,"+ " Young Berserker,"+ " Poor Fucking Infantry and"+ " Ciaran aep Easnillien");
            Console.WriteLine("But Havekar Healer has unreplaceable bility, so this won't be removed.");

            //foreach (var w in GwentCards)
            //    Console.WriteLine("Deck: " + w.Deck + ", Name: " + w.Name + ", Power: " + w.Power + ", Type: " + w.Type);
            RemoveCards();
            Console.WriteLine();
            Console.WriteLine("Here are after delete remain list: ");
            foreach (var w in GwentCards)
                Console.WriteLine("Name: " + w.Name + ", Power: " + w.Power);
            Console.WriteLine();

            Console.WriteLine("Find out how many cards' power above 7: ");
            Console.WriteLine();
            AboveSeven();
            Console.WriteLine("I want to know these cards' deck ");
            CountDeck();
            //GetCardsTable();
            

        }
        
        private static void CountDeck()
        {
            int Nil = 0;
            int Nor = 0;
            int Neu = 0;
            int Sco = 0;
            int Mon = 0;
            int Ske = 0;
            foreach(var w in GwentCards)
            {
                if (w.Deck == "Nilfgaard")
                {
                    Nil++;
                }else if(w.Deck == "NorthernRealms")
                {
                    Nor++;
                }else if (w.Deck == "Neutral")
                {
                    Neu++;
                }else if(w.Deck== "ScoiaTael")
                {
                    Sco++;
                }else if(w.Deck== "Monsters")
                {
                    Mon++;
                }
                else
                {
                    Ske++;
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("I have: ");
            Console.WriteLine(Nil + " Nilfgaard cards");
            Console.WriteLine(Nor + " NorthernRealms cards");
            Console.WriteLine(Neu + " Neutral cards");
            Console.WriteLine(Sco + " ScoiaTael cards");
            Console.WriteLine(Mon + " Monsters cards");
            Console.WriteLine(Ske + " Skellege cards");
        }
        private static void AboveSeven()
        {
            foreach(var w in GwentCards)
                if (w.Power > 7)
                {
                    Console.WriteLine(w.Name + " "+ w.Power);
                }
                else { }
        }

        private static void AddCards()
        {
            GwentCards.Add(new Gwent("Nilfgaard","Menno Coehoorn",10,"Melee"));
            GwentCards.Add(new Gwent("Neutral", "Cirilla Fiona Elen Riannon", 15, "Melee"));
            GwentCards.Add(new Gwent("ScoiaTael", "Milva", 10, "Range"));
            GwentCards.Add(new Gwent("Skellege", "Young Berserker", 2, "Range"));
            GwentCards.Add(new Gwent("ScoiaTael", "Ciaran aep Easnillien", 3, "Melee/Range"));
            GwentCards.Add(new Gwent("Nilfgaard", "Zerrikanian Fire Scorpion", 5, "Siege"));
            GwentCards.Add(new Gwent("Monsters", "Vampire: Fleder", 4, "Melee"));
            GwentCards.Add(new Gwent("Monsters", "Vampire: Katakan", 5, "Melee"));
            GwentCards.Add(new Gwent("Nilfgaard", "Impera Brigade Guard", 3, "Melee"));
            GwentCards.Add(new Gwent("NorthernRealms", "Dun Banner Medic", 5, "Siege"));
            GwentCards.Add(new Gwent("NorthernRealms", "Vernon Roche", 10, "Melee"));
            GwentCards.Add(new Gwent("Skellege", "Clan Dimun Pirate", 6, "Range"));
            GwentCards.Add(new Gwent("ScoiaTael", "Havekar Healer", 0, "Range"));
            GwentCards.Add(new Gwent("Nilfgaard", "Stefan Skellen", 9, "Hero"));
            GwentCards.Add(new Gwent("Skellege", "Cerys", 10, "Melee"));
            GwentCards.Add(new Gwent("ScoiaTael", "Barclay", 6, "Melee/Range"));
            GwentCards.Add(new Gwent("Nilfgaard", "Black Infantry Archer", 10, "Range"));
            GwentCards.Add(new Gwent("Skellege", "Transformed Young Vildkaarl", 8, "Range"));
            GwentCards.Add(new Gwent("Monsters", "Wyvern", 2, "Range"));
            GwentCards.Add(new Gwent("Neutral", "Olgierd von Everec", 6, "Melee/Range"));
            GwentCards.Add(new Gwent("NorthernRealms", "Poor Fucking Infantry", 1, "Melee"));
        }

        public static void RemoveCards()
        {
            GwentCards.Remove(new Gwent("Monsters", "Wyvern", 2, "Range"));
            GwentCards.Remove(new Gwent("Nilfgaard", "Impera Brigade Guard", 3, "Melee"));
            GwentCards.Remove(new Gwent("Skellege", "Young Berserker", 2, "Range"));
            GwentCards.Remove(new Gwent("NorthernRealms", "Poor Fucking Infantry", 1, "Melee"));
            GwentCards.Remove(new Gwent("ScoiaTael", "Ciaran aep Easnillien", 3, "Melee/Range"));
            //foreach(var w in GwentCards)
            //{
            //    if (w.Power < 4)
            //    {
            //        GwentCards.Remove(w);
            //        break;
            //    }
            //}
        }

        private static void GwentCards_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            //throw new NotImplementedException();
            //if (e.NewItems != null)
            //{
            //    foreach (Gwent w in e.NewItems)
            //    {
                   //Console.WriteLine("Message: Collection changed. New Gwent card added.");
            //        Console.WriteLine(w.Name + " " + w.Power);
            //        Console.WriteLine();
               // }

            //}
            //else
            //{
            //    foreach (Gwent w in e.OldItems)
            //    {
                   //Console.WriteLine("Message: Collection changed. Gwent card removed.");
            //        Console.WriteLine(w.Name + " " + w.Power);
            //        Console.WriteLine();
            //    }
            //}

        }
    }
}
