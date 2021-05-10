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
    public class MDPrescriptionModel : PageModel
    {
        private readonly Data.EMR_HSVContext _context;

        public MDPrescriptionModel(Data.EMR_HSVContext context)
        {
            _context = context;
        }

        public Patient Patient { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            Patient = await _context.Patient.Where(m => m.ID == id).Include(d => d.Prescription).FirstAsync();
            if (Patient.Prescription == null)
            {
                return RedirectToPage("/md/MDPortal");
            }
            return Page();
        }
    }
}
