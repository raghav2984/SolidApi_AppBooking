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
        public async Task<Doctor> Create(string doctorName)
        {
            //Check if a SINGLE doctor's name exist in the DB

            if (_doctorRepository.IsAtleastOneDoctorExist())
            {
                throw new DbEntryExistException();
            }
   
            
            // check if the name is not empty
            if (string.IsNullOrEmpty(doctorName))
            {
                throw new NameEmptyException();
            }


            // make sure the DOCTOR's name is not existing in the REPO
            var exists = _doctorRepository.DoctorNameIsExist(doctorName);
            if (exists)
            {
                throw new NameAlreadyExistsException(doctorName);
            }

            var _doctor = new Doctor { DoctorName = doctorName, DoctorId = Guid.NewGuid() };

            await _doctorRepository.AddDoctor(_doctor);

            return _doctor;
        }

    }
}
