using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMR_HSV.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EMR_HSV.Pages.frontdesk
{
    public class CreateAppointmentModel : PageModel
    {

        private readonly Data.EMR_HSVContext _context;

        public CreateAppointmentModel(Data.EMR_HSVContext context)
        {
            _context = context;
        }


        [BindProperty]
        public Appointment Appointment { get; set; }

        static int patientID;
        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            patientID = (int)id;

            return Page();
        }



        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Appointment.PatientID = patientID;
            _context.Appointment.Add(Appointment);
            await _context.SaveChangesAsync();

            return RedirectToPage("/frontdesk/Scheduler/_Scheduler");
        }
    }
}
