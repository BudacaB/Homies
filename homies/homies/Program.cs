using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homies
{
    class Program
    {
        static void Main(string[] args)
        {

            Homie budak = new Homie(new HomieAddress("PT", "Lisbon"), "Bog", "Bud", 31);
            Homie andrei = new Homie(new HomieAddress("TH", "Bangkok"), "Andrei", "Sensei", 38);
            Homie buhanu = new Homie(new HomieAddress("BT", "Thimphu"), "Alecs", "ElBuha", 33);
            Homie piere = new Homie(new HomieAddress("JP", "Tokyo"), "Piere", "Vome", 28);
            Homie sai = new Homie(new HomieAddress("CZ", "Prague"), "Psy", "Tzu", 28);
            Homie borch = new Homie(new HomieAddress("NL", "Amsterdam"), "Borcho", "Coiotul", 30);
            Homie craci = new Homie(new HomieAddress("ES", "Madrid"), "Craci", "Cra", 31);
            Homie scoby = new Homie(new HomieAddress("UK", "London"), "Scoby", "Snake", 32);
            Homie gabitzu = new Homie(new HomieAddress("US", "Seattle"), "Gabi", "Tud", 28); 
            Homie felipe = new Homie(new HomieAddress("IT", "Torino"), "Piere", "Vome", 31);

            budak.Friends.Add(andrei);
            budak.Friends.Add(buhanu);


            Console.WriteLine(budak.ShowHomieDetail());
            foreach (var friend in budak.Friends)
            {
                (friend as Homie).ShowHomieDetail();
                //Console.WriteLine(friend.ShowHomieDetail());
            }
            Console.ReadLine();
        }
    }
}
