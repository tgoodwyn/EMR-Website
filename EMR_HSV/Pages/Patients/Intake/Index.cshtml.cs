using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EMR_HSV.Data;
using EMR_HSV.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EMR_HSV.Pages.Patients.Intake
{
    public class IndexModel : PageModel
    {
        private readonly EMR_HSV.Data.EMR_HSVContext _context;

        public IndexModel(EMR_HSV.Data.EMR_HSVContext context)
        {
            _context = context;
        }

        public IList<SelectListItem> PatientOptions { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            PatientOptions = await _context.Appointment
                .Where(m => m.AppointmentDate == DayTracker.Today && m.hasArrived == true)
                .Select(a => new SelectListItem
                {
                    Value = a.Patient.ID.ToString(),
                    Text = a.Patient.FirstName.ToString() + " " + a.Patient.LastName.ToString()
                }).ToListAsync();

            PatientOptions.Insert(0, new SelectListItem { Text = "--Select Patient--", Value = "" });
            return Page();
        }
    }
}
