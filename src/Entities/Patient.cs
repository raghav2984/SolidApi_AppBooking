﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace src.Entities
{
    [Table("patient")]
    public class Patient
    {
        [Key, Required] public Guid Id { get; set; }
        public Guid PatientId { get; set;}
        public string PatientName { get; set; }
        public Guid SlotId { get; set; }
        public DateTime BookingDate { get; set; }
    }
}
 