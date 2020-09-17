using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5 {
    class Address {
        //index, country, city, street, house, apartment
        public int index;
        public string country;
        public string city;
        public string street;
        public string house;
        public int apartment;

        public Address(int index, string country, string city, string street, string house, int apartment) {
            this.index = index;
            this.country = country;
            this.city = city;
            this.street = street;
            this.house = house;
            this.apartment = apartment;
        }
    }
}
