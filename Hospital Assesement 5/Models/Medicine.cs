using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_Assesement_5.Models
{
    public class Medicine
    {
        [Key]
        public int MedicineID { get; set; }
        public string MedicineName { get; set; }
        public int Price { get; set; }
        //Foreign Key
        public int HospitalID { get; set; }
        public Hospital Hospital_ID { get; set; }
    }
}
