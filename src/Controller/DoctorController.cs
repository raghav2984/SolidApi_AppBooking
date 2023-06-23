using src.Controller.Dtos;
using Microsoft.AspNetCore.Mvc;
using src.Services;
using src.Database;
using src.Entities;

namespace src.Controller
{
    [Controller]
    [Route("/doctor")]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;
        //private Appt_EF_DataContext _db;
        //private Doctor newEntry;  
        public DoctorController(IDoctorService categoryService)
        {
            _doctorService = categoryService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateDoctorRequest request)
        {
           //if  ( _db.Doctor.Find(_db.Doctor, request) != null ) 
           // {
           //     return BadRequest("Doctor's Name already found - Cannot create entry again!!!");
           // }
            await _doctorService.Create(request.DoctorName);
            return Ok("Doctor "+ request.DoctorName + " created successfully...");
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }

  
}
