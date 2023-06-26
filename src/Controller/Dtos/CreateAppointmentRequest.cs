using System.ComponentModel.DataAnnotations;

namespace src.Controller.Dtos
{
    public class CreateAppointmentRequest
    {
        [Required] public required string PatientName { get; set; }
        [Required] public required string DoctorName { get; set; }
        [Key] public Guid BookingId { get; set; }
        public DateTime Start { get; set; } //Date → 22/02/2023 04:00 pm (1 hour Slot & Starts at start of an hour
        public DateTime End { get; set; } //Date → 22/02/2023 05:00 pm (1 hour Slot)
        public bool IsReservedDescription { get; set; }

    }
}
