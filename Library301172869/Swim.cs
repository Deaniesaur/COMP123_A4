using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library301172869
{
    public class Swim
    {
        public ushort Heat { get; set; }
        public byte Lane { get; set; }
        public DateTime Time { get; set; }

        public Swim()
        {

        }

        public Swim(ushort heat, byte lane)
        {
            Heat = heat;
            Lane = lane;
        }

        public override string ToString()
        {
            /* The method outputs the string with information about the a swim.
                It includes the heat number, the lane number, and the swim time. 
                If the swim time is not assigned it outputs “no time” instead of 00:00.00. */
            string output = $"{Heat}|{Lane}|";
            if (Time == null)
                output += "no time";
            else
                output += Time.ToString("HH:mm:ss");
            return output;
        }
    }
}
