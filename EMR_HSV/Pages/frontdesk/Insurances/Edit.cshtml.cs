using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EMR_HSV.Data;
using EMR_HSV.Models;

namespace EMR_HSV.Pages.frontdesk.Insurances
{
    public class EditModel : PageModel
    {
        private readonly EMR_HSV.Data.EMR_HSVContext _context;

        public EditModel(EMR_HSV.Data.EMR_HSVContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Insurance Insurance { get; set; }
        public IList<Patient> Patients { get; set; }
        = new List<Patient>();
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Insurance = await _context.Insurance
                .Include(i => i.Patient).FirstOrDefaultAsync(m => m.Id == id);
            Patients = _context.Patient.ToList();
            if (Insurance == null)
            {
                return NotFound();
            }
           ViewData["PatientId"] = new SelectList(_context.Patient, "ID", "ID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Insurance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InsuranceExists(Insurance.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool InsuranceExists(int id)
        {
            return _context.Insurance.Any(e => e.Id == id);
        }
    }
}
