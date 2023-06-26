using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace src.Entities
{
    [Table ("doctor")]
    public class Doctor
    {
        //[Required] public Guid BookingId {get; set;}
        //public DateTime Time { get; set; } //Date → 22/02/2023 04:30 pm
        [Key, Required]public Guid DoctorId { get; set;}
        [Required] public required string DoctorName { get; set; }
        //public bool IsReservedDescription { get; set; }
        //public decimal Cost { get; set; }
    }
}
