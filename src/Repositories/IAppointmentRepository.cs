using src.Entities;
using System.Data;

namespace src.Repositories
{
    public interface IAppointmentRepository
    {
        public bool IsSlotAvailable(DateTime slot);
        public DataTable ListAppointment(string doctorName);
        public Task BookAppointment(string doctorName, string patientName, DateTime startTime);
        public Task RemoveAppointment(string doctorName, DateTime slot);
        public bool IsPatientRegistered(string patientName, out Guid patientId);

        public bool IsDoctorRegistered(string doctorName, out Guid doctorId);
        Task AddAppointment(Appointment appt);
    }
}