using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMR_HSV.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EMR_HSV.Pages.Patients.History
{
    public class MDPastTestsModel : PageModel
    {
        private readonly Data.EMR_HSVContext _context;

        public MDPastTestsModel(Data.EMR_HSVContext context)
        {
            _context = context;
        }

        public IList<Patient> retrieved { get; set; }
        public Patient Patient { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            retrieved = await _context.Patient.Where(m => m.ID == id)
                .Include(d => d.PastAppointments).ThenInclude(d => d.DoctorToSee)
                .Include(d => d.PastAppointments).ThenInclude(d => d.VisualAcuityTests)
                .Include(d => d.PastAppointments).ThenInclude(d => d.OcularExamTests).ToListAsync();
            Patient = retrieved.First();

            if (Patient == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
