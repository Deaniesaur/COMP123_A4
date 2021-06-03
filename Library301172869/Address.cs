using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library301172869
{
    public struct Address
    {
        public string City;
        public string PostalCode;
        public string Province;
        public string Street;

        public Address(string street, string city, string province, string postalCode)
        {
            City = city;
            PostalCode = postalCode;
            Province = province;
            Street = street;
        }

        public override string ToString()
        {
            return $"{Street}|{City}|{Province}|{PostalCode}";
        }
    }
}
