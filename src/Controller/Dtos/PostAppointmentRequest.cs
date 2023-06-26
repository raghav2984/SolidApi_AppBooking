using System.ComponentModel.DataAnnotations;

namespace src.Controller.Dtos
{
    public class PostAppointmentRequest
    {
        [Required] public required string PatientName { get; set; }
        [Required] public required string DoctorName { get; set; }
        [Required] public required string Start { get; set; }
    }
}
