using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_Assesement_5.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorID { get; set; }
        public string DoctorName { get; set; }
        public DateTime StartDate { get; set; }
        public int ContactNumber { get; set; }
        public string EmailId { get; set; }
        //Foreign Key
        public int HospitalID { get; set; }
        public Hospital Hospital_ID { get; set; }
    }
}
