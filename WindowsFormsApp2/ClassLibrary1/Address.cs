using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimManagementSystem
{
    public struct Address
    {
        public string Street;
        public string City;
        public string Province;
        public string PostalCode;

        public Address(string street, string city, string province, string postcode)
        {
            this.Street = street;
            this.City = city;
            this.Province = province;
            this.PostalCode = postcode;
        }
        public override string ToString()
        {
            return "Address: " + "\b" + "\t" + this.Street + "\b" + "\t" + this.City + "\b" + "\t" + this.Province + "\b" + "\t" + this.PostalCode;
        }
    }
}
