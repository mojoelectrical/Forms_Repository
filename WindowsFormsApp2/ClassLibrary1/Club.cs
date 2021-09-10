using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimManagementSystem
{
    public class Club
    {
        private Coach coach;
        public Address ClubAddress { get; set; }
        public uint ClubNumber { get; private set; }
        public Coach Coach
        {
            get
            {
                return coach;
            }
            set
            {
                if(value.Club.Name == this.Name)
                {
                    coach = value;
                }
            }
        }
        public string Name { get; set; }
        public ulong PhoneNumber { get; set; }
        public List<Registrant> Swimmers { get; } = new List<Registrant>();
        public Club() { }
        public Club(string name, Address clubAddress, ulong phoneNumber) : this()
        {
            this.Name = name;
            this.ClubAddress = clubAddress;
            this.PhoneNumber = phoneNumber;
         
        }
        internal Club(uint regNumber, string name, Address clubAddress, ulong phoneNumber) : this()
        {
            this.ClubNumber = regNumber;
            this.Name = name;
            this.ClubAddress = clubAddress;
            this.PhoneNumber = phoneNumber;
        }
        public void  AddSwimmer(Registrant aSwimmer)
        {
            if (aSwimmer.Club == this)
            {
                
                throw new Exception("Swimmer is already assigned to: " + this);
            }
            this.Swimmers.Add(aSwimmer);
            
            aSwimmer.Club = this;
            
        }
        public override string ToString()
        {
            if(this.coach == null)
            {
                return " Name: " + this.Name + " Address: " + this.ClubAddress + " Phone: " + this.PhoneNumber + " Reg Number: " + this.ClubNumber + " Swimmers: " + string.Join("\t", this.Swimmers) + " Coach: Not Assigned";
            }
            else
            { 
                return " Name: " + this.Name + " Address: " + this.ClubAddress + " Phone: " + this.PhoneNumber + " Reg Number: " + this.ClubNumber + " Swimmers: " + string.Join("\t", this.Swimmers) + " Coach: " + this.coach ;
            }
        }

    }
}
