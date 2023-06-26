using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic;
using src.Database;
using src.Entities;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace src.Repositories
{
    public class AppointmentRepo : IAppointmentRepository
    {
        private Appt_EF_DataContext _db;
        public AppointmentRepo(Appt_EF_DataContext db) 
        { 
            _db = db;
        }
        public bool IsSlotAvailable(DateTime start)
        {

            var selectRow = _db.Appointments.AsEnumerable().Where(status => status.Start == start);

            if (selectRow != null) 
            { 
                return false;
            }
            else { return true; }
        }

        public bool IsPatientRegistered(string patientName, out Guid patientId)
        {

            var selectRow = _db.Patient.Where(status => status.PatientName == patientName).ToList<Patient>;

            if (selectRow != null)
            {
                patientId = _db.Patient.First(status => status.PatientName == patientName).PatientId;

                return true;
            }
            else 
            { 
                patientId= Guid.Empty;
                return false; 
            }
        }

        public bool IsDoctorRegistered(string doctorName, out Guid doctorId)
        {

            var selectRow = _db.Doctor.Where(status => status.DoctorName == doctorName);

            if (selectRow != null)
            {
                doctorId = _db.Doctor.First(status => status.DoctorName == doctorName).DoctorId;
                return true;
            }
            else
            {
                doctorId = Guid.Empty;
                return false;
            }
        }

        public async Task AddAppointment(Appointment appt)
        {
            _db.Appointments.Add(appt);
            await _db.SaveChangesAsync();
        }


        public DataTable ListAppointment(string patientName)
        {
            var table = new DataTable();


            var entries =  _db.Patient.Select(x => x).ToList();
            //var count = _db.Appointments.Count();
            //return entries();

            for (int inx = 0; inx < entries.Count; inx++)
            {
                DataRow row = table.NewRow();

                row.ItemArray[inx] = entries.ElementAt(inx);

                table.Rows.Add(row);
            }

            return table;

        }

        public async Task BookAppointment(string doctorName, string patientName, DateTime startTime)
        {
            
            
            await _db.SaveChangesAsync();
        }

        public Task RemoveAppointment(string doctorName, DateTime slot)
        {
            throw new NotImplementedException();
        }
    }
}
