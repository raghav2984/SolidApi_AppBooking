using src.Entities;

namespace src.Repositories
{
    public interface IPatientRepository
    {
        public bool PatientNameIsExist(string name);
        public Task AddPatient(Patient patient);

    }
}