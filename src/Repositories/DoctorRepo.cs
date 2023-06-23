using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using src.Database;
using src.Entities;
using System.Data.SqlClient;
using System.Net;

namespace src.Repositories
{
    public class DoctorRepo : IDoctorRepository
    {
        private Appt_EF_DataContext _db;
        public DoctorRepo(Appt_EF_DataContext db) 
        { 
            _db = db;
        }

        public bool IsAtleastOneDoctorExist()
        {
            var isDoctorExist = false;

            //var cmd = new SqlCommand("SELECT COUNT(*) FROM Doctor");

            _db.Doctor.Count();
          //  int numOfDoctor = Convert.ToInt32(cmd.ExecuteScalar());
            int numOfDoctor = _db.Doctor.Count();
            if (numOfDoctor > 0 ) 
            { 
                isDoctorExist = true; 
            }
            return isDoctorExist;
        }

        public bool DoctorNameIsExist(string name)
        {
            return _db.Doctor.Any(x => x.DoctorName == name);
        }

        public async Task AddDoctor(Doctor doctor)
        {
            _db.Doctor.Add(doctor);
            await _db.SaveChangesAsync();
        }

    }
}
