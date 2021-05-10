using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EMR_HSV.Pages.frontdesk.Scheduler
{
    public class SetTodayModel : PageModel
    {

        private readonly Data.EMR_HSVContext _context;

        public SetTodayModel(Data.EMR_HSVContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        [BindProperty]
        [DataType(DataType.Date)]

        public DateTime TodaysDate { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {

            Models.DayTracker.Today = TodaysDate;

            return RedirectToPage("/Index");
        }
    }
}
