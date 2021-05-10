using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EMR_HSV.Models
{
    public class Patient
    {
        public int ID { get; set; } //Unique ID for every Patient

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleInitial { get; set; }
        public TitleName Title { get; set; } //Patient Title: Dr, Mr, Mrs, etc
        public string PatientGender { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string PhoneNumberPrimary { get; set; }
        public string PhoneNumberSecondary { get; set; }
        public string SSN { get; set; } 
        public string Email { get; set; }

        //Family Contact Information
        public string FamilyContactFirstName { get; set; }
        public string FamilyContactSecondName { get; set; }
        public string FamilyContactPhoneNumber { get; set; }
        public string FamilyContactStreetAddress { get; set; }
        public string FamilyContactCity { get; set; }
        public string FamilyContactState { get; set; }
        public int FamilyContactZipCode { get; set; }

        //Created FullName to be able to print First + Last Name from a single variable
        public string FullName { get { return this.FirstName + " " + this.LastName; } }
        
        public enum TitleName
        {
            Mr,
            Mrs,
            Ms,
            Miss,
            Dr,
            Professor
        }

        // MEDICAL HISTORY exists as a list of appointments
        public List<Appointment> PastAppointments { get; set; }
        public MedicalHistory MedicalHistory { get; set; }

        public Prescription Prescription { get; set; }

        // SCHEDULING related properties
        public int appointmentTimeSlot { get; set; } // this represents a time slot, not an actual time which is why its an int // could be changed to a TimeSlot object later
        public bool hasAppointmentToday { get; set; } // this always gets set when a patient is assigned a time slot other than 0
        public bool hasArrived { get; set; } // self-explanatory
        public bool hasBeenCheckedIn { get; set; }

        public Insurance Insurance { get; set; }


    }
}
