using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMR_HSV.Util
{
    public static class Util
    {
        public static string ConverTime(double time)
        {
            //return (time < 12) ? time + " AM" : time + " PM";
            if (time == 0)
                return "12 AM";
            else if (time < 12)
                return time + " AM";
            else if (time == 12)
                return time + " PM";
            else
            {
                return (time - 12) + " PM";
            }
        }
    }
}
