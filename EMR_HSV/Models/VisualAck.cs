using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMR_HSV.Models
{
    public class VisualAck
    {
        public int ID { get; set; }

        public static readonly string[] whichEyeOptions = { "OD", "OS", "OU" };
        public static readonly string[] distanceOptions = { "Distance", "Near" };

        [Range(0, 2)]
        public int whichEyes;

        [Range(0, 1)]
        public int distanceOrNear { get; set; }

        [Range(1, 200)]
        public int measurement { get; set; }
        public bool correctorsUsed { get; set; }
        public bool pinholeUsed { get; set; }

        [Range(1, 200)]
        public int pinholeMeasurement { get; set; }
        public string finalResultString { get; set; }

        public int appointmentID { get; set; }
        
        public Appointment Appointment { get; set; }
    }
}
