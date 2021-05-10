using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EMR_HSV.Data;
using EMR_HSV.Models;

namespace EMR_HSV.Pages.md.prescribe
{
    public class IndexModel : PageModel
    {
        private readonly EMR_HSV.Data.EMR_HSVContext _context;

        public IndexModel(EMR_HSV.Data.EMR_HSVContext context)
        {
            _context = context;
        }

        public IList<Prescription> Prescription { get;set; }

        public async Task OnGetAsync()
        {
            Prescription = await _context.Prescription
                .Include(p => p.Patient).ToListAsync();
        }
    }
}
