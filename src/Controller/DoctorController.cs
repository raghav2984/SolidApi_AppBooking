using src.Controller.Dtos;
using Microsoft.AspNetCore.Mvc;
using src.Services;

namespace src.Controller
{
    [Controller]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService categoryService)
        {
            _doctorService = categoryService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateDoctorRequest request)
        {
            await _doctorService.Create(request.DoctorName);
            return Ok("Doctor "+ request.DoctorName + " created successfully...");
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }

  
}
