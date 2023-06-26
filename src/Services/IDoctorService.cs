using src.Entities;

namespace src.Services
{
    public interface IDoctorService
    {
        public Task<Doctor> Create(string doctorName);
    }
}