using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMR_HSV.Models
{
    public class EyeTest
    {

        public int EyeTestID { get; set; }
        public string dateOfTest { get; set; }

        //Foreign key for Patient
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}
