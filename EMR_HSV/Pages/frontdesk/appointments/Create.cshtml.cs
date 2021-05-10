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

namespace EMR_HSV.Pages.frontdesk.appointments
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
        [BindProperty(SupportsGet = true)]
        public string AppointmentDateType { get; set; }

        public IList<SelectListItem> DoctorOptions { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Patients = _context.Patient.ToList();
            DoctorOptions = await _context.Doctor.Select(a =>
                           new SelectListItem
                           {
                               Value = a.ID.ToString(),
                               Text = a.FullName.ToString()
                           }).ToListAsync();
            DoctorOptions.Insert(0, new SelectListItem { Text = "--Select Doctor to see--", Value = "" });
            return Page();
        }
       

        [BindProperty]
        public Appointment Appointment { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                Patients = _context.Patient.ToList();
                return Page();
            }

            
            if(_context.Appointment.Any(a=> a.ArrivalTime == Appointment.ArrivalTime && a.AppointmentDate == Appointment.AppointmentDate))
            {
                Patients = _context.Patient.ToList();
                ModelState.AddModelError(string.Empty, "Appointment time "+ Util.Util.ConverTime(Appointment.ArrivalTime) + " at " + Appointment.AppointmentDate.ToShortDateString() +" is already booked");
                return Page();
            }
            Appointment.AppointmentDate = Appointment.AppointmentDate.Date;
            _context.Appointment.Add(Appointment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
