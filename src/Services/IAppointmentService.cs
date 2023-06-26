using src.Entities;
using System.Data;

namespace src.Services
{
    public interface IAppointmentService
    {
        //public List<Appointment> GenerateSlots(DateTime start, DateTime end, string scale);
        //private List<TimeCell> GenerateTimeline(DateTime start, DateTime end, string scale);
       // public Task<Appointment> Create(string patientName, string doctorName, DateTime start);
        public Task<Appointment> Create(string patientName, string doctorName, string dateTime);

        public DataTable AppointmentList(string patientName);
    }
}