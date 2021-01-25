using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_Assesement_5.Models
{
    public class Hospital
    {

        [Key]
        public int HospitalID { get; set; }

        public String HospitalName { get; set; }
        public string HospitalBranch { get; set; }
        public DateTime HospitalOpeningDate { get; set; }
        public String HospitalAddress { get; set; }
        public int HospitalFloor { get; set; }
    }
}
