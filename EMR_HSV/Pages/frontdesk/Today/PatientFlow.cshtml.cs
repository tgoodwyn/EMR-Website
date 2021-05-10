using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMR_HSV.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EMR_HSV.Pages.frontdesk.Today
{
    public class PatientFlowModel : PageModel
    {

        private readonly Data.EMR_HSVContext _context;

        public PatientFlowModel(Data.EMR_HSVContext context)
        {
            _context = context;
        }
        public static IList<Patient> TodaysPatients { get; set; }
        public IList<Appointment> TodaysAppointments { get; set; }

        public async Task OnGetAsync()
        {
          
            TodaysAppointments = await _context.Appointment.Where(m => m.AppointmentDate == DayTracker.Today)
                .Include(a => a.Patient).ThenInclude(p=>p.MedicalHistory)
                .Include(a=>a.Patient).ThenInclude(p=>p.Insurance)
                .Include(a => a.DoctorToSee).ToListAsync();
            TodaysAppointments = TodaysAppointments.OrderBy(o => o.ArrivalTime).ToList();
        }


        [BindProperty]
        public List<int> arrivalCheckBoxes { get; set; }
        [BindProperty]
        public List<int> checkedinCheckBoxes { get; set; }
        [BindProperty]
        public List<int> withDoctorCheckBoxes { get; set; }    
        [BindProperty]
        public List<int> finishedCheckBoxes { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            TodaysAppointments = await _context.Appointment.Where(m => m.AppointmentDate == DayTracker.Today).ToListAsync();
            foreach (Appointment apt in TodaysAppointments)
            {
                // arrived
                if (arrivalCheckBoxes.Contains(apt.AppointmentID)) apt.hasArrived = true;
                else apt.hasArrived = false;
                // checked in
                if (checkedinCheckBoxes.Contains(apt.AppointmentID)) apt.hasBeenCheckedIn = true;
                else apt.hasBeenCheckedIn = false;
                if (withDoctorCheckBoxes.Contains(apt.AppointmentID)) apt.isWithDoctor = true;
                else apt.isWithDoctor = false;     
                if (finishedCheckBoxes.Contains(apt.AppointmentID)) apt.isFinished = true;
                else apt.isFinished = false;

                //update db
                _context.Attach(apt).State = EntityState.Modified;
            }


            await _context.SaveChangesAsync();


            return RedirectToPage("/frontdesk/Today/PatientFlow");
        }
    }
}
