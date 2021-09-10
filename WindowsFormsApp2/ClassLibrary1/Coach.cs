using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimManagementSystem
{
    public class Coach : Registrant
    {
        public string Credentials { get; set; }
        public Coach(string name, DateTime dateOfBirth, Address anAddress, ulong phoneNumber, string credentials) : base(name,dateOfBirth,anAddress,phoneNumber)
        {
            Credentials = credentials;
        }
        public override string ToString()
        {
            if (this.Club == null)
            {
                return " Name: " + this.Name + " DOB: " + this.DateOfBirth + " Address: " + this.Address + " Phone Number: " + this.PhoneNumber + " Club: Not Assigned " + " Credentials: " + this.Credentials;
            }
            else
            {
                return " Name: " + this.Name +  " DOB: " + this.DateOfBirth + " Address: " + this.Address + " Phone Number: " + this.PhoneNumber + " Credentials: " + this.Credentials;
            }
        }
    }
}
