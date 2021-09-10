using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SwimManagementSystem
{
    public class Event
    { //there was no outline for this class
        private RegistrantSwims swimmingEvents;
        public EventDistance Distance { get; set; }
        public Stroke Stroke { get; set; }
        public List<Registrant> Swimmers { get; } = new List<Registrant>();
        public void AddSwimmer(Registrant aSwimmer)
        {
            
            this.Swimmers.Add(aSwimmer);
        }
        public void EnterSwimmersTime(Registrant aSwimmer, string time)
        {

        }
        public Event() { }
        public Event(EventDistance distance, Stroke stroke) : this()
        {
            this.Distance = distance;
            this.Stroke = stroke;
        }
        public void Seed(byte maxLanes)
        {

        }
        public override string ToString()
        {
            return " Events: " + this.Distance + this.Stroke + string.Join("\b", Swimmers);
        }

    }
    public class RegistrantSwims
    {
        public List<Registrant> swimmers = new List<Registrant>();
        public List<Swim> Swims = new List<Swim>();
        public Swim Swim { get; set; }
        public void AddOrUpdate(Registrant swimmer, Swim swim)
        {

        }
        public bool Contains(Registrant swimmer)
        {
            return true;
             
        }
        public Swim GetSwimmersSwim(Registrant swimmer)
        {
            return null;
        }
    }
}
