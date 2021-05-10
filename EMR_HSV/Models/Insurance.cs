using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EMR_HSV.Models
{
    public class Insurance
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        public string Name { get; set; }
        public string ContractNumber { get; set; }
        public string WorkNumber { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string Copay { get; set; }
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime EffectiveDate { get; set; }
        
    }
}
