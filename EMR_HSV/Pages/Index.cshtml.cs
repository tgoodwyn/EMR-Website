using EMR_HSV.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMR_HSV.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly EMR_HSV.Data.EMR_HSVContext _context;

        public IndexModel(ILogger<IndexModel> logger, EMR_HSV.Data.EMR_HSVContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IList<Appointment> Appointment { get; set; }
        public void OnGet()
        {
            Appointment =  _context.Appointment.Include(a => a.Patient).Where(a=> a.AppointmentDate.Date== Models.DayTracker.Today).OrderBy(a=> a.ArrivalTime).ToList();
        }
    }
}
