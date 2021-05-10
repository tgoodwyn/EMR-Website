using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EMR_HSV.Data;
using EMR_HSV.Models;

namespace EMR_HSV.Pages.md.prescribe.temp
{
    public class stealModel : PageModel
    {
        private readonly EMR_HSV.Data.EMR_HSVContext _context;

        public stealModel(EMR_HSV.Data.EMR_HSVContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["patientID"] = new SelectList(_context.Patient, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Prescription Prescription { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Prescription.Add(Prescription);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
