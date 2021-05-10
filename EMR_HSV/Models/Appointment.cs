using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EMR_HSV.Models
{
    
    public class Appointment
    {
        public int AppointmentID { get; set; }
        [Display(Name = "Patient")]
        public int PatientID { get; set; }
        public Patient Patient { get; set; }
        [Display(Name="Doctor")]
        public int DoctorID { get; set; }
        public Doctor DoctorToSee { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        [Display(Name = "Date Of Appointment")]
        public DateTime AppointmentDate { get; set; }
        [Display(Name = "Time Of Appointment")]
        //public DateTime TimeOfArrival { get; set; }
        public double ArrivalTime { get; set; }
        //public DateTime CheckOutTime { get; set; }

        public string reasonForVisit { get; set; }
        // A patient's MEDICAL HISTORY is accessible via these lists
        public List<VisualAck> VisualAcuityTests { get; set; }
        public List<OcularExam> OcularExamTests { get; set; }

        // uncomment when oe is finished
        //public List<OcularExam> OcularExamTests { get; set; }

        //===========================================================
        // variables related to patient status on day of appointment
        //===========================================================
        public bool hasArrived { get; set; } // self-explanatory
        public bool hasBeenCheckedIn { get; set; }
        public bool isWithDoctor { get; set; }
        public bool isFinished { get; set; }

    }
}
