using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace src.Entities
{
    [Table("appointment")]
    public class Appointment
    {
        [Key][Required] public Guid BookingId { get; set; }
        public DateTime Start { get; set; } //Date → 22/02/2023 04:00 pm (1 hour Slot & Starts at start of an hour
        public DateTime End { get; set; } //Date → 22/02/2023 05:00 pm (1 hour Slot)
        public bool IsReservedDescription { get; set; }
        public decimal Cost { get; set; }
        public Guid PatientId { get; set; }
        public string PatientName { get; set; }
        public Guid DoctorId { get; }
        public string DoctorName { get; set; }

    }
}
