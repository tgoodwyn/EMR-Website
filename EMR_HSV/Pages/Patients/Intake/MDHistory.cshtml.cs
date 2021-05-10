using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMR_HSV.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EMR_HSV.Pages.Patients.Intake
{
    public class MDHistoryModel : PageModel
    {
        private readonly Data.EMR_HSVContext _context;

        public MDHistoryModel(Data.EMR_HSVContext context)
        {
            _context = context;
        }

        public Patient Patient { get; set; }
        public MedicalHistory CurrentMedicalHistory { get; set; }

        public List<string> ListOfPastTreatments { get; set; }
        public List<string> ListOfPlannedTreatments { get; set; }
        public List<string> ListOfCurrentMedications { get; set; }
        public List<string> ListOfIllnessAndConditions { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            Patient = await _context.Patient.Where(m => m.ID == id).Include(m => m.MedicalHistory).FirstAsync();
            Patient = await _context.Patient.Include(p => p.MedicalHistory).ThenInclude(d => d.MedicalStrings).FirstOrDefaultAsync(m => m.ID == id);
            CurrentMedicalHistory = Patient.MedicalHistory;
            if (CurrentMedicalHistory != null)
            {

            initializeLists();
            } else
            {
                return Redirect("/Patients/Intake/Index");
            }

            return Page();
        }

        void initializeLists()
        {
            ListOfPastTreatments = new List<string>();
            ListOfPlannedTreatments = new List<string>();
            ListOfCurrentMedications = new List<string>();
            ListOfIllnessAndConditions = new List<string>();

            foreach (MedicalString ms in CurrentMedicalHistory.MedicalStrings)
            {
                switch (ms.fieldRef)
                {
                    case 0:
                        ListOfPastTreatments.Add(ms.text);
                        break;
                    case 1:
                        ListOfPlannedTreatments.Add(ms.text);
                        break;
                    case 2:
                        ListOfCurrentMedications.Add(ms.text);
                        break;
                    case 3:
                        ListOfIllnessAndConditions.Add(ms.text);
                        break;
                }
            }
        }
    }
}
