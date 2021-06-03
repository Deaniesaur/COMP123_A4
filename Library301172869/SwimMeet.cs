using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library301172869
{
    public class SwimMeet
    {
        public PoolType Course { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Event> Events { get; } = new List<Event>();
        public string Name { get; set; }
        public byte NoOfLanes { get; set; }

        public void AddEvent(Event anEvent)
        {
            Events.Add(anEvent);
        }

        public void Seed()
        {
            foreach (Event ev in Events)
            {
                ev.Seed(NoOfLanes);
            }
        }

        public SwimMeet(string name, DateTime start, DateTime end, PoolType course, byte noOfLanes)
        {
            Name = name;
            StartDate = start;
            EndDate = end;
            Course = course;
            NoOfLanes = noOfLanes;
        }
        public SwimMeet() : this("", DateTime.Now, DateTime.Now, PoolType.SCM, 8)
        {

        }

        public override string ToString()
        {
            string output =
                $"Swim meet name: {Name}\n" +
                $"From-to: {StartDate.ToString("yyyy-MM-dd")} to {EndDate.ToString("yyyy-MM-dd")}\n" +
                $"Pool type: {Course}\n" +
                $"No lanes: {NoOfLanes}\n" +
                $"Events:";

            Events.ForEach((Event ev) => {
                output += ev.ToString();
            });
            return output;
        }
    }
}
