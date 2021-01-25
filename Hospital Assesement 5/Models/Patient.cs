using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_Assesement_5.Models
{
    public class Patient
    {
        [Key]
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public int ContactNumber { get; set; }
        public string PatientAddress { get; set; }
        //Foreign Key
        //public int HospitalID { get; set; }
        //public Hospital Hospital_obj { get; set; }
        //Foreign Key
        public int DoctorID { get; set; }
        public Doctor Doctor_ID { get; set; }
    }
}
