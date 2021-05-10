using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMR_HSV.Models
{
    public class MedicalString
    {

        public int ID { get; set; }
        public int fieldRef { get; set; }
        public string text { get; set; }

        public int MedicalHistoryID { get; set; }
        public MedicalHistory MedicalHistoryContainer { get; set; }
        //public MedicalHistory MedicalHistory { get; set; }
    }
}
