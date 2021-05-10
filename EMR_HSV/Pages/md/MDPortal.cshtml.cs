using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMR_HSV.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EMR_HSV.Pages.md
{
    public class MDPortalModel : PageModel
    {

        private readonly Data.EMR_HSVContext _context;

        public MDPortalModel(Data.EMR_HSVContext context)
        {
            _context = context;
        }

        public IList<SelectListItem> PatientOptions { get; set; }
        public static IList<Appointment> TodaysAppointments { get; set; }

        public async Task OnGetAsync()
        {
            PatientOptions = await _context.Appointment.Where(m => m.AppointmentDate == DayTracker.Today && m.isWithDoctor == true).Select(a => new SelectListItem { Value = a.Patient.ID.ToString(), Text = a.Patient.FirstName.ToString() + " " + a.Patient.LastName.ToString() }).ToListAsync();

            PatientOptions.Insert(0, new SelectListItem { Text = "--Select Patient--", Value = "" });
        }
    }
}
