using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homies
{
    public class HomieAddress
    {
        public string Country { get; set; } 
        public string City { get; set; }

        public HomieAddress(string paramCountry, string paramCity)
        {
            this.Country = paramCountry;
            this.City = paramCity;
        }

        public string ShowAddress()
        {
            return this.City + ", " + this.Country;
        }
    }
}
