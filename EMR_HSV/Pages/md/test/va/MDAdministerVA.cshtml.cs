using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMR_HSV.Data;
using EMR_HSV.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

using Microsoft.EntityFrameworkCore;

namespace EMR_HSV.Pages.md.eye.test.va
{
    public class CreateModel : PageModel
    {
        private readonly EMR_HSVContext _context;

        public CreateModel(EMR_HSVContext context)
        {
            _context = context;
        }


        [BindProperty]
        public VisualAck CreatedTest { get; set; }
        //public Patient Patient { get; set; }
        public IList<SelectListItem> PatientOptions { get; set; }

        [BindProperty]
        public int patientID { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {

            PatientOptions = await _context.Appointment
                .Where(m => m.AppointmentDate == DayTracker.Today && m.isWithDoctor == true)
                .Select(a => new SelectListItem 
                {   Value = a.Patient.ID.ToString(), 
                    Text = a.Patient.FirstName.ToString() + " " + a.Patient.LastName.ToString() 
                }).ToListAsync();

            PatientOptions.Insert(0, new SelectListItem { Text = "--Select Patient--", Value = "" });

            //Patient = await _context.Patient.FirstOrDefaultAsync(m => m.ID == id);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            Appointment apt = await _context.Appointment.Where(m => m.PatientID == patientID && m.AppointmentDate == DayTracker.Today).FirstAsync();

            CreatedTest.Appointment = apt;
            _context.VisualAck.Add(CreatedTest);
            await _context.SaveChangesAsync();

            return RedirectToPage("/md/MDPortal");
        }

    }
}

