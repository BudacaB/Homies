using System; //fundamental and base classes
using System.Collections.Generic; //aid for using arrays
using System.Linq; //collections of objects, arrays
using System.Threading.Tasks; //multi-threading

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
            Homie sai = new Homie(new HomieAddress("CZ", "Prague"), "Psy", "Tzu", 31);
            Homie borch = new Homie(new HomieAddress("NL", "Amsterdam"), "Borcho", "Coiotul", 30);
            Homie blanoz = new Homie(new HomieAddress("NL", "Rotterdam"), "Blanoz", "Distrusoz", 35);
            Homie craci = new Homie(new HomieAddress("ES", "Madrid"), "Craci", "Cra", 31);
            Homie scoby = new Homie(new HomieAddress("UK", "London"), "Scoby", "Snake", 32);
            Homie gabitzu = new Homie(new HomieAddress("US", "Seattle"), "Gabi", "Tud", 28); 
            Homie felipe = new Homie(new HomieAddress("IT", "Torino"), "Felipe", "Stalianu", 31);
            Homie superman = new Homie(new HomieAddress("IT", "Torino"), "Jean", "Stalianu", 31);
            Homie spiderman = new Homie(new HomieAddress("IT", "Torino"), "Titi", "Aur", 31);
            Homie macalan = new Homie(new HomieAddress("IT", "Torino"), "Chelie", "Butelie", 31);

            List<Homie> allHomies = new List<Homie>() {
                budak,
                andrei,
                buhanu,
                piere,
                sai,
                borch,
                blanoz,
                craci,
                scoby,
                gabitzu,
                superman,
                spiderman,
                macalan,
                new Homie(new HomieAddress("IT", "Torino"), "Felipe", "Stalianu", 31)
        };

            Action<Homie> detectFriends = homie => {
                {
                    var myCity = homie.Address.City;
                    var myCountry = homie.Address.Country;
                    Func<Homie, bool> itIsNotMe = h => h.Firstname != homie.Firstname;

                    var otherHomiesFromMyCity = allHomies
                        .Where(h => h.Address.City == myCity)
                        .Where(itIsNotMe);

                    var otherHomiesFromMyCountry = allHomies
                        .Where(h => h.Address.Country == myCountry)
                        .Where(itIsNotMe);

                    homie.Friends.AddRange(otherHomiesFromMyCity);
                    homie.Friends.AddRange(otherHomiesFromMyCountry);
                }
            };
            allHomies.ForEach(detectFriends);

            //foreach (var homie in allHomies)
            //{   
            //    if (homie.Age < 30)
            //    {
            //        Console.WriteLine(homie.ShowHomieDetail());
            //    }

            //}

            //void showIfAgeLessThan30(Homie homie) {
            //    if (homie.Age > 30 && homie.Address.City == "Torino")
            //    {
            //        Console.WriteLine(homie.ShowHomieDetail());
            //    } 
            //}



            allHomies
                //.Where(currentHomie => currentHomie.Age > 30)
                //.Where(currentHomie => currentHomie.Address.City == "Torino")
                .GroupBy(currentHomie => currentHomie.Age)
                .ToList()
                //.ForEach(currentHomie => Console.WriteLine(currentHomie.ShowHomieDetail()));  //lambda or arrow function
                .ForEach(group =>
                {
                    //Console.WriteLine(group.Key);
                    group.ToList().ForEach(h => h.ShowHomieDetail());
                });

            //var over25list = allHomies.Where(h => h.Age > 25).ToList();
            var over25list = from homie in allHomies where homie.Age > 25 select homie;

            var bla = over25list.Where(h => h.Address.City == "Torino").ToList();

            var anyFromTorino = allHomies.Any(h => h.Address.City == "Torino");

            var anyFromTorino2 = allHomies.Where(h => h.Address.City == "Torino").Count() > 0;

            var firstFoundFromTorino = allHomies.First(h => h.Address.City == "Torino");

            var theHomiesFromAmsterdam = allHomies.Where(h => h.Address.City == "Amsterdam").ToList();

            var allHomiesFromSpainAndJapan = allHomies.Where(h => h.Address.Country == "ES" || h.Address.Country == "JP").ToList();

            allHomies
                .OrderBy(h => h.Firstname)
                .ToList()
                .ForEach(h => Console.WriteLine(h.ShowHomieDetail()));

            Console.ReadLine();
        }
    }
}
