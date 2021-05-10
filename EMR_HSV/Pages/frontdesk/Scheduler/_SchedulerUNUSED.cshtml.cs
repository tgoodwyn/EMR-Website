using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMR_HSV.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EMR_HSV.Pages.frontdesk
{
    public class SchedulerModel : PageModel
    {


        private readonly Data.EMR_HSVContext _context;
        [BindProperty]
        public Appointment Appointment { get; set; }

        public SchedulerModel(Data.EMR_HSVContext context)
        {
            _context = context;
        }
        [BindProperty]
        public int selectedTimeSlot { get; set; }

        [BindProperty]
        public int idOfSelectedPatient { get; set; }

        //[BindProperty]
        //public DateTime dateOfAppointment { get; set; }

        public IList<Patient> AvailablePatients { get; set; }

        public async Task OnGetAsync()
        {
            AvailablePatients = await _context.Patient.ToListAsync();
        }

        public Patient SelectedPatient { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    AvailablePatients = await _context.Patient.ToListAsync();
            //    return Page();
            //}
            //var entry = _context.Add(new Appointment());
            //entry.CurrentValues.SetValues(Appointment);
            Appointment.PatientID = idOfSelectedPatient;
            _context.Appointment.Add(Appointment);

            SelectedPatient = await _context.Patient.FirstOrDefaultAsync(m => m.ID == idOfSelectedPatient);

            // assign the patient a time slot of 0 if you want to say they don't have an appointment today 
            if (selectedTimeSlot == 0) SelectedPatient.hasAppointmentToday = false;
            // any other number assumes that they do
            else SelectedPatient.hasAppointmentToday = true;

            // assign them the selected time slot
            SelectedPatient.appointmentTimeSlot = selectedTimeSlot;

            // update the database
            _context.Attach(SelectedPatient).State = EntityState.Modified;

            // save it
            await _context.SaveChangesAsync();

            // goes back to page for Today
            return RedirectToPage("/frontdesk/Today/PatientFlow");
        }
    }
}
