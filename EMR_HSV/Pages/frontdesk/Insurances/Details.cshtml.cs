using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EMR_HSV.Data;
using EMR_HSV.Models;

namespace EMR_HSV.Pages.frontdesk.Insurances
{
    public class DetailsModel : PageModel
    {
        private readonly EMR_HSV.Data.EMR_HSVContext _context;

        public DetailsModel(EMR_HSV.Data.EMR_HSVContext context)
        {
            _context = context;
        }

        public Insurance Insurance { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Insurance = await _context.Insurance
                .Include(i => i.Patient).FirstOrDefaultAsync(m => m.Id == id);

            if (Insurance == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
