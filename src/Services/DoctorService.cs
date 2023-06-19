using src.Services.Exceptions;
using src.Repositories;
using System.Diagnostics.Eventing.Reader;
using src.Entities;

namespace src.Services
{
    public class DoctorService : IDoctorService
    {
        public readonly IDoctorRepository _doctorRepository;

        public DoctorService(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        //Create Doctor ID --> ONCE ONLY
        public async Task Create(string doctorName)
        {
            // check if the name is not empty
            if (string.IsNullOrEmpty(doctorName))
            {
                throw new DoctorNameEmptyException();
            }


            // make sure the DOCTOR's name is not existing in the REPO
            var exists = _doctorRepository.DoctorNameIsExist(doctorName);
            if (exists)
            {
                throw new DoctorNameAlreadyExistsException(doctorName);
            }
            var _doctor = new Doctor { DoctorName = doctorName, DoctorId = Guid.NewGuid() };

            await _doctorRepository.AddDoctor(_doctor);
        }

    }
}
