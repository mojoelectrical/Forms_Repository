using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimManagementSystem
{
    public abstract class Registrant
    {
        protected Club club
                             ;
        public Address Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public uint Id { get; }
        public string Name { get; set; }
        public ulong PhoneNumber { get; set; }
        public Club Club
        {
            get { return club; }
            set
            {
                if (this.club == null)
                {
                    club = value;
                }
                if (this.club != null)
                {
                    throw new Exception("Swimmer is registered with a different club");
                }


            }
        }
        public  Registrant()
        {
            this.Id=  RegistrationNumberGenerator.GenerateId();
            
        }
        public Registrant(string name, DateTime dateOfBirth, Address anAddress, ulong phoneNumber) : this()
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Address = anAddress;
            PhoneNumber = phoneNumber;
        }
        internal Registrant(uint regNumber, string name,DateTime dateOfBirth, Address anAddress, ulong phoneNumber) : this()
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Address = anAddress;
            PhoneNumber = phoneNumber;
            Id = regNumber;
        }
        public override string ToString()
        {
            if (club == null)
            {
                return " Registrant name: " + Name + " Date of birth: " + DateOfBirth + " Address: " + Address + " Id Number" + Id + " Phone number: " + PhoneNumber + " Club: " + " Not Assigned";

            } 
            else
            {
               return " Registrant name: " + Name + " Date of birth: " + DateOfBirth + " Address: " + Address + " Id Number" + Id + " Phone number: " + PhoneNumber + " Club: " + club;

            }
        }



    }
}
