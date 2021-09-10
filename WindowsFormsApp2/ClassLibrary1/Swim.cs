using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwimManagementSystem;

namespace SwimManagementSystem
{
    public class Swim
    {
        ushort Heat { get; set; }
        byte Lane { get; set; }
        DateTime Time { get; set; }

        public Swim() { }
        public Swim(ushort heat, byte lane) : this()
        {
            this.Heat = heat;
            this.Lane = lane;
        }
        public override string ToString()
        {
            return " Heat: " + this.Heat + " Lane: " + this.Lane + " Time: " + this.Time;
        }
    }
}
