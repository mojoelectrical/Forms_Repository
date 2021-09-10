using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimManagementSystem
{
    public class Swimmer : Registrant
    {
        public Club Club

        {
            get { return club; }
            set
            {
                if (this.club == null)
                {
                    Club = value;
                }
                if (this.Club != null)
                {
                    throw new Exception("Swimmer is registered with a different club");
                }


            }
        }
        
        public Swimmer() : base() { }
        public Swimmer(string name, DateTime dateOfBirth, Address anAddress, ulong phoneNumber) : base(name,dateOfBirth,anAddress,phoneNumber)
        {
           
        }
        internal Swimmer(uint regNumber, string name, DateTime dateOfBirth, Address anAddress, ulong phoneNumber) : base(regNumber, name, dateOfBirth, anAddress, phoneNumber)
        {
            
        }



    }
}
