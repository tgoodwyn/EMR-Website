using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EMR_HSV.Data;
using EMR_HSV.Models;

namespace EMR_HSV.Pages.Patients.Intake
{
    public class EditModel : PageModel
    {
        private readonly EMR_HSV.Data.EMR_HSVContext _context;

        public EditModel(EMR_HSV.Data.EMR_HSVContext context)
        {
            _context = context;
        }

        public MedicalHistory CurrentMedicalHistory { get; set; }
        [BindProperty]
        public MedicalHistory CreatedMedicalHistory { get; set; }

        public Patient Patient { get; set; }
        [BindProperty]
        public List<string> ListOfPastTreatments { get; set; }
        [BindProperty]
        public List<string> ListOfPlannedTreatments { get; set; }
        [BindProperty]
        public List<string> ListOfCurrentMedications { get; set; }
        [BindProperty]
        public List<string> ListOfIllnessAndConditions { get; set; }

        static int storedMHID;
        static int storedPID;
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            storedPID = (int)id;
            Patient = await _context.Patient.Include(p => p.MedicalHistory).ThenInclude(d => d.MedicalStrings).FirstOrDefaultAsync(m => m.ID == id);
            CurrentMedicalHistory = Patient.MedicalHistory;
            //initializeLists();


            if (CurrentMedicalHistory != null)
            {
                storedMHID = CurrentMedicalHistory.ID;
                initializeLists();
                //return NotFound();
            }
            return Page();
        }



        public async Task<IActionResult> OnPostAsync()
        {
            CreatedMedicalHistory.PatientID = storedPID;

            CreatedMedicalHistory.MedicalStrings = new List<MedicalString>();
            createLists();
            if (MedicalHistoryExists(storedMHID))
            {
                CreatedMedicalHistory.ID = storedMHID;

                _context.MedicalHistory.Attach(CreatedMedicalHistory);
                _context.MedicalHistory.Remove(CreatedMedicalHistory);
                await _context.SaveChangesAsync();
                CreatedMedicalHistory.ID = 0;
            }
           
                _context.MedicalHistory.Add(CreatedMedicalHistory);
            

            await _context.SaveChangesAsync();


            return RedirectToPage("./Index");
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
        void createLists()
        {
            foreach (string s in ListOfPastTreatments)
            {
                if (!String.IsNullOrEmpty(s))
                {
                    MedicalString ms = new MedicalString { fieldRef = 0, text = s, MedicalHistoryContainer = CreatedMedicalHistory };
                    CreatedMedicalHistory.MedicalStrings.Add(ms);
                }
            }
            foreach (string s in ListOfPlannedTreatments)
            {
                if (!String.IsNullOrEmpty(s))
                {
                    MedicalString ms = new MedicalString { fieldRef = 1, text = s, MedicalHistoryContainer = CreatedMedicalHistory };
                    CreatedMedicalHistory.MedicalStrings.Add(ms);
                }
            }
            foreach (string s in ListOfCurrentMedications)
            {
                if (!String.IsNullOrEmpty(s))
                {
                    MedicalString ms = new MedicalString { fieldRef = 2, text = s, MedicalHistoryContainer = CreatedMedicalHistory };
                    CreatedMedicalHistory.MedicalStrings.Add(ms);
                }
            }
            foreach (string s in ListOfIllnessAndConditions)
            {
                if (!String.IsNullOrEmpty(s))
                {
                    MedicalString ms = new MedicalString { fieldRef = 3, text = s, MedicalHistoryContainer = CreatedMedicalHistory };
                    CreatedMedicalHistory.MedicalStrings.Add(ms);
                }
            }
        }
        private bool MedicalHistoryExists(int id)
        {
            return _context.MedicalHistory.Any(e => e.ID == id);
        }
    }
}
