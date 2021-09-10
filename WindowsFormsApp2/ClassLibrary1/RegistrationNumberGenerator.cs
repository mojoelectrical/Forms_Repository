using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimManagementSystem
{
    static public class RegistrationNumberGenerator
    {
        static uint registrationNumber = 3000;
        public static uint RegistrationNumber { get; set; } 

        public static uint GenerateId()
        {
            RegistrationNumber++;
            return RegistrationNumber;
        }
    }
}
