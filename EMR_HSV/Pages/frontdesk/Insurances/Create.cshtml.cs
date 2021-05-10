using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EMR_HSV.Data;
using EMR_HSV.Models;

namespace EMR_HSV.Pages.frontdesk.Insurances
{
    public class CreateModel : PageModel
    {
        private readonly EMR_HSV.Data.EMR_HSVContext _context;

        public CreateModel(EMR_HSV.Data.EMR_HSVContext context)
        {
            _context = context;
        }

        public IList<Patient> Patients { get; set; }
         = new List<Patient>();
        public IActionResult OnGet()
        {
            //ViewData["Patients"] = new SelectList(_context.Patient, "ID", "FirsntName");
            Patients = _context.Patient.ToList();
            return Page();
        }

        [BindProperty]
        public Insurance Insurance { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Insurance.Add(Insurance);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
