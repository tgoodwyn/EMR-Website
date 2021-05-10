using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMR_HSV.Models
{
    public class MedicalHistory
    {
        public int ID { get; set; }
        public string PrimaryCareDoctor { get; set; }
        public List<MedicalString> MedicalStrings { get; set; }
        public List<string> PastTreatments;
        public List<string> PlannedTreatments ;
        public List<string> CurrentMedications ;
        public List<string> IllnessesAndConditions ;

        public int PatientID { get; set; }

        public Patient Patient { get; set; }
    }
}
