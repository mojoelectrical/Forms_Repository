using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwimManagementSystem;

namespace SwimManagementSystem
{
    public class SwimMeet
        //there was no outline or any description for this class 
    {
        public PoolType Course { get; set; }
        public DateTime EndDate { get; set; }
        public List<Event> Events { get; } = new List<Event>();
        public string Name { get; set; }
        public byte NoOfLames { get; set; }
        public DateTime StartDate { get; set; }
        public void AddEvent(Event anEvent)
        {
            this.Events.Add(anEvent);
        }
        public void Seed()
        {
            //don't know what seed refers to 
        }
        public SwimMeet()
        {

        }
        public SwimMeet(string name, DateTime start, DateTime end, PoolType course, byte noOfLanes) : this()
        {
            Name = name;
            StartDate = start;
            EndDate = end;
            Course = course;
            NoOfLames = noOfLanes;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        
           
        
    }
}
