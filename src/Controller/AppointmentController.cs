using src.Controller.Dtos;
using Microsoft.AspNetCore.Mvc;
using src.Services;
using src.Database;
using src.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace src.Controller
{
    [Controller]
    [Route("/appointment")]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;
        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        [HttpPost]
        [Route("create/{PatientName}/{DoctorName}/{Start}")]
        public async Task<IActionResult> PutAppointmentSlotRequest([FromBody] PostAppointmentRequest postAppointmentRequest)
        {
            //if  ( _db.Doctor.Find(_db.Doctor, request) != null ) 
            // {
            //     return BadRequest("Doctor's Name already found - Cannot create entry again!!!");
            // }
        
            await _appointmentService.Create(postAppointmentRequest.PatientName, postAppointmentRequest.DoctorName, postAppointmentRequest.Start);
            return Ok("Appointment slot for Patient " + postAppointmentRequest.PatientName + "at " + postAppointmentRequest.Start + " was created successfully...");
        }

        [HttpGet]
        [Route("/listAppt")]
        public DataTable GetAppointments( [FromQuery] string patientName)
        {
            return _appointmentService.AppointmentList(patientName);
        }

    }

  
}
