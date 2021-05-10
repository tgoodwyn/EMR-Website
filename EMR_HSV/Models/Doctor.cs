using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMR_HSV.Models
{
    public class Doctor
    {
        public int ID { get; set; }
        public string FullName { get; set; }

        public List<Appointment> doctorsAppointments { get; set; }
    }
}
