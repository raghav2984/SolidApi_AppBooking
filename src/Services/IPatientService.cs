using src.Entities;

namespace src.Services
{
    public interface IPatientService
    {
        public Task<Patient> Create(string patientName);
    }
}