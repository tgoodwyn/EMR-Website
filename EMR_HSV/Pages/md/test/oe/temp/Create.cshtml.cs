using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMR_HSV.Data;
using EMR_HSV.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EMR_HSV.Pages.md.test.oe.temp
{
    public class CreateModel : PageModel
    {
        private readonly EMR_HSV.Data.EMR_HSVContext _context;

        public CreateModel(EMR_HSV.Data.EMR_HSVContext context)
        {
            _context = context;
        }


        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public OcularExam OcularExam { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.OcularExam.Add(OcularExam);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
