using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMR_HSV.Models
{
    public class Prescription 
    {
        public int ID { get; set; }

        public float sphereOD { get; set; }
        public float sphereOS { get; set; }
        public float cylinderOD { get; set; }
        public float cylinderOS { get; set; }
        public float axisOD { get; set; }
        public float axisOS { get; set; }
        public float addOD { get; set; }
        public float addOS { get; set; }
        public float prismOD { get; set; }
        public float prismOS { get; set; }
        public float prismBaseOD { get; set; }
        public float prismBaseOS { get; set; }
        public int nearMeasurementOD { get; set; }
        public int nearMeasurementOS { get; set; }
        public int farMeasurementOD { get; set; } 
        public int farMeasurementOS { get; set; }
        

        public int patientID { get; set; }

        public Patient Patient { get; set; }


    }
}
