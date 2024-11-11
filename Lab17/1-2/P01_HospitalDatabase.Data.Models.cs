using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace P01_HospitalDatabase.Data.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public bool HasInsurance { get; set; }

        public ICollection<PatientMedicament> Prescriptions { get; set; } = new List<PatientMedicament>();
    }

    public class Visitation
    {
        public int VisitationId { get; set; }
        public DateTime Date { get; set; }
        public string Comments { get; set; }

        // connections
        public Patient Patient { get; set; }
        public Doctors Doctor { get; set; }

    }

    public class Diagnose
    {
        public int DiagnoseId { get; set; }
        public string Name { get; set; }
        public string Comments { get; set; }

        // connections
        public Patient Patient { get; set; }

    }

    public class Medicament
    {
        public int MedicamentId { get; set; }
        public string Name { get; set; }

        public ICollection<PatientMedicament> Prescriptions { get; set; } = new List<PatientMedicament>();
    }


    public class PatientMedicament
    {
        public int PatientId { get; set; }
        public int MedicamentId { get; set; }

        public Patient Patient { get; set; }
        public Medicament Medicament { get; set; }
    }

    public class Doctors
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Specialization {  get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
    
    }


}
