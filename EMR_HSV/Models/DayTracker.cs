using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMR_HSV.Models
{
    public class DayTracker
    //=============================================================
    // this class does not need a database table, currently just 
    // used to store Today's date
    //=============================================================
    {
        public static DateTime Today = System.DateTime.Today;
    }
}
