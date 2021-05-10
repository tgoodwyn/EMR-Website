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
    public class IndexModel : PageModel
    {
        private readonly EMR_HSV.Data.EMR_HSVContext _context;

        public IndexModel(EMR_HSV.Data.EMR_HSVContext context)
        {
            _context = context;
        }

        public IList<Insurance> Insurance { get;set; }

        public async Task OnGetAsync()
        {
            Insurance = await _context.Insurance
                .Include(i => i.Patient).ToListAsync();
        }
    }
}
