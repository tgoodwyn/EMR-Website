using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EMR_HSV.Data;
using EMR_HSV.Models;
using Microsoft.EntityFrameworkCore;

namespace EMR_HSV.Pages.md.prescribe
{
    public class CreateModel : PageModel
    {
        private readonly EMR_HSV.Data.EMR_HSVContext _context;

        public CreateModel(EMR_HSV.Data.EMR_HSVContext context)
        {
            _context = context;
        }

        public IList<SelectListItem> PatientOptions { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            //ViewData["patientID"] = new SelectList(_context.Patient, "ID", "FullName");
            PatientOptions = await _context.Appointment
                .Where(m => m.AppointmentDate == DayTracker.Today && m.isWithDoctor == true)
                .Select(a => new SelectListItem
                {
                    Value = a.Patient.ID.ToString(),
                    Text = a.Patient.FirstName.ToString() + " " + a.Patient.LastName.ToString()
                }).ToListAsync();

            PatientOptions.Insert(0, new SelectListItem { Text = "--Select Patient--", Value = "" });
            return Page();
        }

        [BindProperty]
        public Prescription Prescription { get; set; }
        [BindProperty]
        public int patientID { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            Prescription.patientID = patientID;

            if (PrescriptionExists(Prescription.patientID))
            {
                Prescription old = _context.Prescription.First(e => e.patientID == Prescription.patientID);
                Prescription.ID = old.ID;
                _context.Remove(old);
                _context.Attach(Prescription).State = EntityState.Modified;

                await _context.SaveChangesAsync();
            }
            else
            {

                _context.Prescription.Add(Prescription);
                await _context.SaveChangesAsync();
            }


            return RedirectToPage("/Patients/History/MDPrescription", new { id = patientID });
        }

        private bool PrescriptionExists(int id)
        {
            return _context.Prescription.Any(e => e.patientID == id);
        }
    }
}
