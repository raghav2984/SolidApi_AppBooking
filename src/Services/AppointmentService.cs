using Microsoft.AspNetCore.Http.HttpResults;
using src.Entities;
using src.Repositories;
using src.Services.Exceptions;
using System.Data;

namespace src.Services
{
    public class AppointmentService : IAppointmentService
    {
        //    public static int SlotDurationMinutes = 60;

        //    public static int MorningShiftStarts = 9;
        //    public static int MorningShiftEnds = 13;

        //    public static int AfternoonShiftStarts = 14;
        //    public static int AfternoonShiftEnds = 18;

        public readonly IAppointmentRepository _apptRepository;
        private DateTime parsedDate;

        public AppointmentService(IAppointmentRepository apptRepository)
        {
            _apptRepository = apptRepository;
        }

        public DataTable AppointmentList(string patientName)
        {
            // check if the name is not empty
            if (string.IsNullOrEmpty(patientName))
            {
                throw new NameEmptyException();
            }
            var patientId = Guid.Empty;
            var exists = _apptRepository.IsPatientRegistered(patientName,out patientId);
            if (exists)
            {
                throw new NameAlreadyExistsException(patientName);
            }
            return  _apptRepository.ListAppointment(patientName);
        }

        public async Task<Appointment> Create(string patientName, string doctorName, string dateTime)
        {

        
            if (!DateTime.TryParse(dateTime, out parsedDate))
            {
                throw new DateFormatException();
            }

            // check if the name is not empty
            if (string.IsNullOrEmpty(patientName))
            {
                throw new NameEmptyException();
            }

            
            var patientId = Guid.Empty;
            var exists = _apptRepository.IsPatientRegistered(patientName, out patientId);
            if (!exists)
            {
                throw new NameNotExistsException(patientName);
            }

            exists = _apptRepository.IsSlotAvailable(parsedDate);
            if (exists)
            {
                throw new ApptSlotExistException();
            }

            var doctorId = Guid.Empty;
            exists = _apptRepository.IsDoctorRegistered(doctorName, out doctorId);
            if (!exists)
            {
                throw new NameNotExistsException(doctorName);
            }

            var end = parsedDate.AddHours(1);
            var  _appt = new Appointment { PatientName = patientName,PatientId = patientId, DoctorName = doctorName, BookingId = new Guid(), Start = parsedDate, End = end, IsReservedDescription = false };

            await _apptRepository.AddAppointment(_appt);
            return _appt;
        }

        
    }

}
