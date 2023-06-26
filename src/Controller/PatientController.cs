using src.Controller.Dtos;
using Microsoft.AspNetCore.Mvc;
using src.Services;
using src.Database;
using src.Entities;

namespace src.Controller
{
    [Controller]
    [Route("/patient")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;
        //private Appt_EF_DataContext _db;
        //private Doctor newEntry;  
        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreatePatientRequest request)
        {
           //if  ( _db.Doctor.Find(_db.Doctor, request) != null ) 
           // {
           //     return BadRequest("Doctor's Name already found - Cannot create entry again!!!");
           // }
            await _patientService.Create(request.PatientName);
            return Ok("Patient "+ request.PatientName + " created successfully...");
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }

  
}
