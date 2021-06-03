using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Library301172869
{
    public class Event
    {
        //private RegistrantsSwims swimmingEvents;
        private Dictionary<Registrant, Swim> swimmingEvents;
        public EventDistance Distance { get; set; }
        public Stroke Stroke { get; set; }
        public List<Registrant> Swimmers { 
            get {
                return swimmingEvents.Keys.ToList();
            } 
        }

        public void AddSwimmer(Registrant aSwimmer)
        {
            if (swimmingEvents.ContainsKey(aSwimmer))
            {
                throw new Exception($"Swimmer {aSwimmer.Name},{aSwimmer.Id} is already entered");
            }
            else
            {
                swimmingEvents.Add(aSwimmer, null);
            }
        }

        public void EnterSwimmersTime(Registrant aSwimmer, string time)
        {
            Swim swim = swimmingEvents[aSwimmer];
            swim.Time = DateTime.ParseExact(time, "mm:ss.ff", CultureInfo.InvariantCulture);
        }

        public Event()
        {
            swimmingEvents = new Dictionary<Registrant, Swim>();
        }

        public Event(EventDistance distance, Stroke stroke):this()
        {
            Distance = distance;
            Stroke = stroke;
        }

        public void Seed(byte maxLanes)
        {
            ushort currentHeat = 1;
            byte currentLane = 0;

            Swimmers.ForEach((Registrant swimmer) =>
            {
                //Calculate Next Heat and Lane
                if (++currentLane > maxLanes)
                {
                    currentLane = (byte) (currentLane % maxLanes);
                    currentHeat++;
                }

                Swim swim = new Swim(currentHeat, currentLane);
                swimmingEvents[swimmer] = swim;
            });
        }

        public override string ToString()
        {
            string output = $"\n\t{Distance} {Stroke}\n\tSwimmers:\n";

            Swimmers.ForEach((Registrant swimmer) => {
                output += $"\t{swimmer.Name}\n";
                Swim swim = swimmingEvents[swimmer];
                if(swim == null)
                    output += "\t\tNot seeded/no swim\n";
                else{
                    output += $"\t\tH{swim.Heat}L{swim.Lane}  time: ";

                    if(swim.Time == null || swim.Time == new DateTime(0))
                        output += "no time\n";
                    else
                        output += swim.Time.ToString("mm:ss.ff\n");
                }
            });

            return output;
        }

        //private class RegistrantsSwims
        //{
        //    public List<Registrant> swimmers = new List<Registrant>();
        //    public List<Swim> swims = new List<Swim>();
        //    public Swim Swim { get; set; }

        //    public void AddOrUpdate(Registrant swimmer, Swim swim)
        //    {
        //        int position = swimmers.FindIndex(x => x == swimmer);
        //        if (position == -1)
        //        {
        //            swimmers.Add(swimmer);
        //            swims.Add(swim);
        //        }
        //        else
        //        {
        //            swims[position] = swim;
        //        }
        //    }

        //    public bool Contains(Registrant swimmer)
        //    {
        //        return swimmers.Contains(swimmer);
        //    }

        //    public Swim GetSwimmersSwim(Registrant swimmer)
        //    {
        //        int position = swimmers.FindIndex(x => x == swimmer);
        //        if (position == -1)
        //            throw new Exception("Swimmer has not entered event");

        //        return swims[position];
        //    }
        //}
    }
}
