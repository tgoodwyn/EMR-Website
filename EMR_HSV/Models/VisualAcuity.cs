using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMR_HSV.Models
{
    public class VisualAcuity
    {

        public int ID { get; set; }

        //public static readonly string[] whichEyeOptions = { "OD", "OS", "OU" };
        //public static readonly string[] distanceOptions = { "Distance", "Near" };

        //[Range(0, 2)]
        //public int whichEyes;

        //[Range(0, 1)]
        //public int distanceOrNear { get; set; }

        //[Range(1, 200)]
        //public int measurement { get; set; }
        //public bool correctorsUsed { get; set; }
        //public bool pinholeUsed { get; set; }

        //[Range(1, 200)]
        //public int pinholeMeasurement { get; set; }

        // each VisualAcuity test is attached to an appointment object
        //public int AppointmentID { get; set; }

        //public int viewDistanceNear { get; set; }
        //public int detailDistanceNear { get; set; }
        //public int viewDistanceFar { get; set; }
        //public int detailDistanceFar { get; set; }

        //public int viewDistancePinhole { get; set; }
        //public int detailDistancePinhole { get; set; }
    }
}
