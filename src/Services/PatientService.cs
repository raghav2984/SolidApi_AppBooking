using src.Entities;
using src.Repositories;
using src.Services.Exceptions;

namespace src.Services
{
    public class PatientService : IPatientService
    {
        public readonly IPatientRepository _patientRepository;

        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        //Create Tatient ID
        public async Task<Patient> Create(string patientName)
        {

            // check if the name is not empty
            if (string.IsNullOrEmpty(patientName))
            {
                throw new NameEmptyException();
            }


            // make sure the DOCTOR's name is not existing in the REPO
            var exists = _patientRepository.PatientNameIsExist(patientName);
            if (exists)
            {
                throw new NameAlreadyExistsException(patientName);
            }

            var _patient = new Patient { PatientName = patientName, PatientId = Guid.NewGuid() };

            await _patientRepository.AddPatient(_patient);

            return _patient;
        }
    }
}
