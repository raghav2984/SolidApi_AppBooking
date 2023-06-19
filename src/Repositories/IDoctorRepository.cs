using src.Entities;

namespace src.Repositories
{
    public interface IDoctorRepository
    {
        public bool DoctorNameIsExist(string doctorName);
        public Task AddDoctor(Doctor doctor);
    }
}