using src.Database;
using src.Entities;

namespace src.Repositories
{
    public class PatientRepo : IPatientRepository
    {
        private Appt_EF_DataContext _db;
        public PatientRepo(Appt_EF_DataContext db) 
        { 
            _db = db;
        }

        public bool PatientNameIsExist(string name)
        {
            return _db.Doctor.Any(x => x.DoctorName == name);
        }

        public async Task AddPatient(Patient patient)
        {
            _db.Patient.Add(patient);
            await _db.SaveChangesAsync();
        }

    }
}
