using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierService.Lib.Model
{
   public class Address
    {
        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string house { get; set; }
        public Address() { }
        public Address(string country, string city, string street, string house)
        {
            this.country = country;
            this.city = city;
            this.street = street;
            this.house = house;
        }
    }
}
